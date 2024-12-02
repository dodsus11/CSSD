Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ucLaporanPelayananAlatDenganMesin
    Dim yearNow As Integer
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        sfd.Filter = "excel (.xls) | *.xls"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnExportExcel.Tag = sfd.FileName
            Me.exportExcel()
        End If
    End Sub

    Private Sub exportExcel()
        Dim excelapp As Excel.Application
        Dim excelworkbook As Excel.Workbook
        Dim excelworksheet As Excel.Worksheet
        Dim msvalue As Object = System.Reflection.Missing.Value

        excelapp = New Excel.Application
        excelworkbook = excelapp.Workbooks.Add(msvalue)
        excelworksheet = excelworkbook.Sheets("sheet1")

        'Perulangan untuk memindahkan data dari datagridview ke worksheet excel
        For i As Integer = 0 To dgvLaporan.RowCount - 1
            For j As Integer = 0 To dgvLaporan.ColumnCount - 1
                If i = 0 Then
                    excelworksheet.Cells(i + 3, j + 2) = dgvLaporan.Columns(j).HeaderText.ToString
                    excelworksheet.Cells(i + 4, j + 2) = dgvLaporan(j, i).Value.ToString
                Else
                    excelworksheet.Cells(i + 4, j + 2) = dgvLaporan(j, i).Value.ToString

                End If
            Next
        Next

        'total vertical
        For j As Integer = 5 To dgvLaporan.ColumnCount - 1
            excelworksheet.Cells(dgvLaporan.RowCount + 4, j + 2) = excelapp.WorksheetFunction.Sum(
                            excelworksheet.Range(excelworksheet.Cells(4, j + 2),
                                                 excelworksheet.Cells(dgvLaporan.RowCount - 1 + 4, j + 2)))
        Next

        ''total horizontal jml
        'For i As Integer = 0 To dgvLaporan.RowCount - 1
        '    excelworksheet.Cells(i + 4, dgvLaporan.ColumnCount + 2) = excelapp.WorksheetFunction.Sum(
        '                    excelworksheet.Range(excelworksheet.Cells(i + 4, 7),
        '                                         excelworksheet.Cells(i + 4, dgvLaporan.ColumnCount - 1 + 2)))
        'Next

        excelworksheet.Range(excelworksheet.Cells(3, 2), excelworksheet.Cells(3, dgvLaporan.ColumnCount + 1)).Interior.Color = Color.LightBlue

        excelworksheet.Cells(dgvLaporan.RowCount + 4, 0 + 2) = "TOTAL"
        'excelworksheet.Cells(3, dgvLaporan.ColumnCount + 2) = "JML"
        ' Mengatur ukuran baris dan column
        excelworksheet.UsedRange.EntireRow.AutoFit()
        excelworksheet.UsedRange.EntireColumn.AutoFit()

        ' Mengatur border table
        excelworksheet.UsedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        excelworksheet.UsedRange.Borders.Color = Color.Black
        excelworksheet.UsedRange.Borders.Weight = Excel.XlBorderWeight.xlThin

        ' Membuat judul
        excelworksheet.Cells(1, 2) = "Laporan Pelayanan Alat Dengan Mesin " & txtKodeMesin.Text
        ' Menyimpan file excel
        excelworksheet.SaveAs(btnExportExcel.Tag)
        excelworkbook.Close()
        excelworkbook = Nothing
        excelapp.Quit()
        GC.WaitForPendingFinalizers()
        GC.Collect()

        MessageBox.Show("Data berhasil diexport", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnExportExcel.Tag = String.Empty
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        'If Me.cmbBulan.SelectedIndex = -1 Then
        '    MsgBox("Pilih Bulan untuk laporan")
        '    Exit Sub
        'End If

        'If Me.cmbTahun.SelectedIndex = -1 Then
        '    MsgBox("Pilih Tahun untuk laporan")
        '    Exit Sub
        'End If

        If dtFrom.Value.ToString("yyyy-MM") <> dtTo.Value.ToString("yyyy-MM") Then
            MsgBox("Bulan dan Tahun pada range tanggal harus sama !")
            Exit Sub
        End If

        'If String.IsNullOrEmpty(txtMesin.Text) Then
        '    MsgBox("Pilih Mesin untuk laporan")
        '    Exit Sub
        'End If

        Me.LoadLaporan()
    End Sub

    Private Sub LoadLaporan()
        dgvLaporan.DataSource = Nothing
        dgvLaporan.Columns.Clear()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        'dt = Me.cssdServ.GetLaporanPelayananInstrumenDenganMesin(Convert.ToInt32(cmbBulan.Text),
        '                                                         Convert.ToInt32(cmbTahun.Text),
        '                                                         txtMesin.Tag)

        'dt = Me.cssdServ.GetLaporanPelayananInstrumenDenganMesin(dtFrom.Value.ToString("yyyy-MM-dd"),
        '                                                         dtTo.Value.ToString("yyyy-MM-dd"),
        '                                                         txtMesin.Tag)

        dt = Me.cssdServ.GetReportMachine(dtFrom.Value.ToString("yyyy-MM-dd"),
                                          dtTo.Value.ToString("yyyy-MM-dd"),
                                          txtJenisMesin.Tag,
                                          txtKodeMesin.Tag)

        dt.Columns.Add("jml", GetType(System.Int64))
        dt.Columns.Add("Total", GetType(System.Decimal))
        dt.Columns.Add("jml kasa", GetType(System.Int64))

        'jml
        For Each row As DataRow In dt.Rows
            Dim jml As Integer = 0
            For i = row.Table.Columns("StandarKasa").Ordinal + 1 To dt.Columns.Count - 2
                If row(i) Is DBNull.Value Then
                    jml = jml + 0
                Else
                    jml = jml + CInt(row(i))
                End If

            Next
            row.Item("jml") = jml
        Next row

        'total berat
        For Each row As DataRow In dt.Rows
            Dim berat As Decimal = 0
            Dim jml As Integer = 0

            If row(3) Is DBNull.Value Then
                berat = 0
            Else
                berat = row(3)
            End If

            If row(row.Table.Columns("jml").Ordinal) Is DBNull.Value Then
                jml = 0
            Else
                jml = row(row.Table.Columns("jml").Ordinal)
            End If

            row("total") = berat * jml
            
        Next row

        'total kasa
        For Each row As DataRow In dt.Rows
            Dim kasa As Integer = 0
            Dim jml As Integer = 0

            If row(4) Is DBNull.Value Then
                kasa = 0
            Else
                kasa = row(4)
            End If

            If row(row.Table.Columns("jml").Ordinal) Is DBNull.Value Then
                jml = 0
            Else
                jml = row(row.Table.Columns("jml").Ordinal)
            End If

            row("jml kasa") = kasa * jml

        Next row


        dv.Table = dt
        dgvLaporan.DataSource = dv

        GH.FormatGridLapPelayananInstrumen(dgvLaporan, True)
    End Sub

    Private Sub ucLaporanPelayananAlatDenganMesin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.initYear()
        'Me.initMonth()

        txtJenisMesin.Tag = 0
        txtJenisMesin.Text = "All"

        txtKodeMesin.Tag = ""
        txtKodeMesin.Text = "All"
    End Sub

    'Private Sub initYear()
    '    yearNow = Date.Today.Year
    '    cmbTahun.ValueMember = "Value"
    '    cmbTahun.DisplayMember = "Text"
    '    For index = 0 To 2
    '        cmbTahun.Items.Add(New With {.Text = yearNow - index, .Value = yearNow - index})
    '    Next
    'End Sub

    'Private Sub initMonth()
    '    cmbBulan.ValueMember = "Value"
    '    cmbBulan.DisplayMember = "Text"
    '    For index = 1 To 12
    '        cmbBulan.Items.Add(New With {.Text = index, .Value = index})
    '    Next

    'End Sub

    Private Sub btnLookUpMesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUpMesin.Click
        'Dim frmLookUp As New UILibs.DlgLookUp()

        'frmLookUp.fidArray = {{"KodeMesin", "Kode", 100},
        '                      {"NamaMesin", "Nama", 300},
        '                      {"Merk", "Merk", 0},
        '                      {"NamaVendor", "NamaVendor", 0},
        '                      {"TglPengadaan", "TglPengadaan", 0},
        '                      {"IdGroupMesin", "IdGroupMesin", 0},
        '                      {"NamaGroupMesin", "Kelompok", 170},
        '                      {"Tipe", "Tipe", 170},
        '                      {"LoadMesin", "LoadMesin", 100}}

        'frmLookUp.keyField = "KodeMesin"
        'frmLookUp.fields = {"KodeMesin", "NamaMesin"}

        'Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        'Dim dt As New DataTable
        'dt = Me.cssdSetupServ.GetAllSetupMesin

        'Dim rw As DataRow = dt.NewRow
        'rw(0) = "All"
        'rw(1) = "SEMUA"
        'dt.Rows.InsertAt(rw, 0)
        'frmLookUp.dt = dt

        'InProcFactory.CloseChannel(Me.cssdSetupServ)

        'If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    txtMesin.Text = frmLookUp.returnRow("NamaMesin").ToString()
        '    txtMesin.Tag = frmLookUp.returnRow("KodeMesin").ToString()
        'End If



        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeMesinA", "KodeMesinA", 0},
                              {"KodeMesinB", "Kode Mesin", 100},
                              {"NamaMesin", "Nama Mesin", 300}}

        frmLookUp.keyField = "KodeMesinB"
        frmLookUp.fields = {"KodeMesinB", "NamaMesin"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdServ.GetMesin(txtJenisMesin.Tag)
        InProcFactory.CloseChannel(Me.cssdServ)
        frmLookUp.dt = dt

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtKodeMesin.Tag = frmLookUp.returnRow("KodeMesinA").ToString()
            txtKodeMesin.Text = frmLookUp.returnRow("KodeMesinB").ToString()
            txtMesin.Text = frmLookUp.returnRow("NamaMesin").ToString()
        End If
    End Sub

    Private Sub btnLookUpJenisMesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUpJenisMesin.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"IdGroupMesin", "IdGroupMesin", 0},
                              {"NamaGroupMesin", "Nama", 200},
                              {"Tipe", "Tipe", 200}}

        frmLookUp.keyField = "IdGroupMesin"
        frmLookUp.fields = {"NamaGroupMesin", "Tipe"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdServ.GetGroupMesin
        InProcFactory.CloseChannel(Me.cssdServ)
        frmLookUp.dt = dt

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtJenisMesin.Tag = frmLookUp.returnRow("IdGroupMesin").ToString()
            txtJenisMesin.Text = frmLookUp.returnRow("NamaGroupMesin").ToString()
            txtTipeMesin.Text = frmLookUp.returnRow("Tipe").ToString()
        End If
    End Sub

    Private Sub txtMesin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeMesin.TextChanged

    End Sub
End Class
