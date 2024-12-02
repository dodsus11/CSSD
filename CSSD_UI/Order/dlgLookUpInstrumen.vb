Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports System.Drawing

Public Class dlgLookUpInstrumen
    Private cssdSetupServ As ICSSDSetupService
    Private cssdOrderServ As ICSSDOrderService
    Dim dv As New DataView
    Dim dt As DataTable
    Public dtTemp As New DataTable
    Dim fidArray(,) As Object = {{"cek", "", 40},
                                 {"NoInventory", "No.Inv", 100},
                                 {"KodeAlat", "Kode Alat", 100},
                                 {"NamaAlat", "Nama Alat", 270},
                                 {"Berat", "Berat", 60},
                                 {"KodeSatuan", "KodeSatuan", 0},
                                 {"NamaSatuan", "Satuan", 50},
                                 {"standar_reuse", "Standar Reuse", 100}}

    Dim fidArrayReuse(,) As Object = {{"cek", "", 40},
                                      {"NoInventory", "No.Inv", 90},
                                      {"Kode_reuse", "Kode Reuse", 120},
                                      {"Kode_Identifikasi_Alat", "Kode Identifikasi", 160},
                                      {"KodeAlat", "Kode Alat", 0},
                                      {"NamaAlat", "Nama Alat", 0},
                                      {"Berat", "Berat", 60},
                                      {"KodeSatuan", "KodeSatuan", 0},
                                      {"NamaSatuan", "Satuan", 50},
                                      {"standar_reuse", "Standar Reuse", 95},
                                      {"jml_reuse", "Jml Reuse", 75}}

    Sub makeTempTable()

        dtTemp.Columns.Add("NoInventory", GetType(String))
        dtTemp.Columns.Add("KodeAlat", GetType(String))
        dtTemp.Columns.Add("NamaAlat", GetType(String))
        dtTemp.Columns.Add("Qty", GetType(Integer))
        dtTemp.Columns.Add("Berat", GetType(Decimal))
        dtTemp.Columns.Add("KodeSatuan", GetType(String))
        dtTemp.Columns.Add("Satuan", GetType(String))
        dtTemp.Columns.Add("Keterangan", GetType(String))
        dtTemp.Columns.Add("IdJenisAlat", GetType(String))
        dtTemp.Columns.Add("JenisAlat", GetType(String))
        dtTemp.Columns.Add("JenisReuse", GetType(String))
        dtTemp.Columns.Add("KodeIdentifikasi", GetType(String))

    End Sub

    Sub LoadData()
        gvDaftar.DataSource = Nothing
        gvDaftar.Columns.Clear()

        Me.Cursor = Cursors.AppStarting

        Me.cssdOrderServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Me.dt = Me.cssdOrderServ.GetAlatByJenis(txtJenis.Tag)
        InProcFactory.CloseChannel(Me.cssdOrderServ)

        dv.Table = Me.dt
        gvDaftar.DataSource = dv
        UILibs.GridStyle.C1formatGrid(gvDaftar, dv.Table, fidArray)

        gvDaftar.Splits(0).DisplayColumns("NoInventory").Locked = True
        gvDaftar.Splits(0).DisplayColumns("KodeAlat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("NamaAlat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("Berat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("KodeSatuan").Locked = True
        gvDaftar.Splits(0).DisplayColumns("NamaSatuan").Locked = True
        gvDaftar.Splits(0).DisplayColumns("standar_reuse").Locked = True

        If txtJenis.Tag = 2 Then
            gvDaftar.Splits(0).DisplayColumns("standar_reuse").Visible = True
        Else
            gvDaftar.Splits(0).DisplayColumns("standar_reuse").Visible = False
        End If

        For i As Integer = 0 To 6
            gvDaftar.Splits(0).DisplayColumns(i).FetchStyle = True
        Next

        Me.Cursor = Cursors.Default

    End Sub

    Sub LoadDataReuse()
        gvDaftar.DataSource = Nothing
        gvDaftar.Columns.Clear()

        Me.Cursor = Cursors.AppStarting

        Me.cssdOrderServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Me.dt = Me.cssdOrderServ.GetSingleReuse(txtNamaAlat.Tag)
        InProcFactory.CloseChannel(Me.cssdOrderServ)

        dv.Table = Me.dt
        gvDaftar.DataSource = dv
        UILibs.GridStyle.C1formatGrid(gvDaftar, dv.Table, fidArrayReuse)

        gvDaftar.Splits(0).DisplayColumns("Kode_reuse").Locked = True
        gvDaftar.Splits(0).DisplayColumns("Kode_Identifikasi_Alat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("KodeAlat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("NamaAlat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("Berat").Locked = True
        gvDaftar.Splits(0).DisplayColumns("KodeSatuan").Locked = True
        gvDaftar.Splits(0).DisplayColumns("NamaSatuan").Locked = True
        gvDaftar.Splits(0).DisplayColumns("standar_reuse").Locked = True
        gvDaftar.Splits(0).DisplayColumns("jml_reuse").Locked = True

        For i As Integer = 0 To 9
            gvDaftar.Splits(0).DisplayColumns(i).FetchStyle = True
        Next

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnLookJenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookJenis.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"IdJenisAlat", "id", 0},
                              {"NamaJenis", "Jenis", 300},
                              {"set_instrumen", "Set instrumen", 100}}

        frmLookUp.keyField = "IdJenisAlat"
        frmLookUp.fields = {"NamaJenis", "set_instrumen"}

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdSetupServ.GetJenisAlat()
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdSetupServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtJenis.Text = frmLookUp.returnRow("NamaJenis").ToString()
            txtJenis.Tag = frmLookUp.returnRow("IdJenisAlat").ToString()

            cmbJenis.Text = String.Empty
            txtNamaAlat.Tag = String.Empty
            txtNamaAlat.Text = String.Empty

            If txtJenis.Tag = "2" Then
                PanelJenis.Visible = True

                PanelLooping.Visible = False

                gvDaftar.DataSource = Nothing
                gvDaftar.Columns.Clear()
            Else
                PanelJenis.Visible = False

                LoadData()
            End If

        End If
    End Sub

    Private Sub cmbJenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenis.SelectedIndexChanged
        If cmbJenis.SelectedItem = "Baru" Then
            PanelLooping.Visible = False

            LoadData()
        Else
            PanelLooping.Visible = True

            gvDaftar.DataSource = Nothing
            gvDaftar.Columns.Clear()
        End If

        txtNamaAlat.Tag = String.Empty
        txtNamaAlat.Text = String.Empty
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Dim str As String = CType(sender, TextBox).Text

        If txtNamaAlat.Tag = String.Empty Then
            dv.RowFilter = String.Format("NoInventory LIKE '%{0}%'" &
                                     " OR KodeAlat LIKE '%{0}%'" & _
                                     " OR NamaAlat LIKE '%{0}%'" _
                                     , str)
        Else
            dv.RowFilter = String.Format("Kode_reuse LIKE '%{0}%'" &
                                     " OR Kode_Identifikasi_Alat LIKE '%{0}%'" _
                                     , str)
        End If
    End Sub

    Private Sub btnAlat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlat.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"NoInventory", "No.Inv", 90},
                              {"KodeAlat", "Kode Alat", 90},
                              {"NamaAlat", "Nama Alat", 200},
                              {"Berat", "Berat", 80},
                              {"KodeSatuan", "KodeSatuan", 0},
                              {"NamaSatuan", "Nama Satuan", 90},
                              {"standar_reuse", "Standar Reuse", 100}}

        frmLookUp.keyField = "NoInventory"
        frmLookUp.fields = {"NoInventory", "KodeAlat", "NamaAlat"}

        'Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        'Dim dt As New DataTable
        'dt = Me.cssdSetupServ.GetInventoryByJenis(txtJenis.Tag)
        'frmLookUp.dt = dt

        'InProcFactory.CloseChannel(Me.cssdSetupServ)

        Me.cssdOrderServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdOrderServ.GetAlatByJenis(txtJenis.Tag)
        frmLookUp.dt = dt
        InProcFactory.CloseChannel(Me.cssdOrderServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtNamaAlat.Tag = frmLookUp.returnRow("NoInventory")
            txtNamaAlat.Text = frmLookUp.returnRow("NamaAlat").ToString()

            LoadDataReuse()

        End If
    End Sub


    Private Sub gvDaftar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDaftar.DoubleClick

        If gvDaftar.Columns("cek").Value = True Then
            gvDaftar.Columns("cek").Value = False
        Else
            gvDaftar.Columns("cek").Value = True
        End If

        'If IsDBNull(gvDaftar.Columns("Berat").Value) Then
        '    MsgBox("Berat alat masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
        '    Return
        'End If

        'If IsDBNull(gvDaftar.Columns("KodeSatuan").Value) Then
        '    MsgBox("Satuan alat masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
        '    Return
        'End If

        'If cmbJenis.SelectedItem = "Perulangan" Then
        '    If gvDaftar.Columns("jml_reuse").Value >= gvDaftar.Columns("standar_reuse").Value Then
        '        If MsgBox("Perhatikan Jml Reuse, Apakah tetap di Reuse lagi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
        '            Return
        '        End If
        '    End If
        'End If

        'Me.DialogResult = Windows.Forms.DialogResult.OK
        'Me.Close()
    End Sub

    Private Sub gvDaftar_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles gvDaftar.FetchCellStyle
        If txtNamaAlat.Tag <> String.Empty Then
            If e.Column.DataColumn.DataField = "jml_reuse" And _
               gvDaftar(e.Row, "jml_reuse") >= gvDaftar(e.Row, "standar_reuse") Then
                e.CellStyle.ForeColor = Color.Crimson
                e.CellStyle.Font = New Font("Tahoma", 9)
            End If
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        For Each row As DataRow In dt.Rows

            If row("cek") = True Then

                If row("Berat") = 0 Then
                    MsgBox("Berat alat masih ada yang kosong !", MsgBoxStyle.Exclamation, "Peringatan")
                    Return
                End If

                If row("KodeSatuan") = "" Then
                    MsgBox("Satuan alat masih ada yang kosong !", MsgBoxStyle.Exclamation, "Peringatan")
                    Return
                End If

                'cek NoInventory is exist
                Me.cssdOrderServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim retVal As String
                If txtJenis.Tag = 2 Then
                    If cmbJenis.SelectedItem = "Perulangan" Then
                        retVal = Me.cssdOrderServ.ValidateOrder(row("NoInventory"), _
                                                                row("Kode_Identifikasi_Alat"))
                    End If
                Else
                    retVal = Me.cssdOrderServ.ValidateOrder(row("NoInventory"), _
                                                            String.Empty)
                End If
                InProcFactory.CloseChannel(Me.cssdOrderServ)

                If InStr(retVal, "ERROR") Then
                    MsgBox(retVal, MsgBoxStyle.Exclamation, "Pesan")
                    Return
                End If


                Dim rowIsCek As DataRow = Me.dtTemp.NewRow
                rowIsCek("NoInventory") = row("NoInventory")
                rowIsCek("KodeAlat") = row("KodeAlat")
                rowIsCek("NamaAlat") = row("NamaAlat")
                rowIsCek("Qty") = 1
                rowIsCek("Berat") = row("Berat")
                rowIsCek("KodeSatuan") = row("KodeSatuan")
                rowIsCek("Satuan") = row("NamaSatuan")
                rowIsCek("Keterangan") = String.Empty
                rowIsCek("IdJenisAlat") = txtJenis.Tag
                rowIsCek("JenisAlat") = txtJenis.Text
                If txtJenis.Tag = 2 Then
                    If cmbJenis.SelectedItem = "Baru" Then
                        rowIsCek("JenisReuse") = cmbJenis.SelectedItem
                        rowIsCek("KodeIdentifikasi") = String.Empty
                    Else
                        rowIsCek("JenisReuse") = cmbJenis.SelectedItem
                        rowIsCek("KodeIdentifikasi") = row("Kode_Identifikasi_Alat")
                    End If
                Else
                    rowIsCek("JenisReuse") = String.Empty
                    rowIsCek("KodeIdentifikasi") = String.Empty
                End If

                Me.dtTemp.Rows.Add(rowIsCek)
            End If

        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dlgLookUpInstrumen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        makeTempTable()
    End Sub

    Private Sub gvDaftar_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles gvDaftar.MouseClick
        'If e.Button = Windows.Forms.MouseButtons.Left Then

        '    gvDaftar.SetActiveCell(gvDaftar.RowContaining(e.Y), 0)

        '    Dim mnu As New ContextMenuStrip()
        '    Dim mnuBill As New ToolStripMenuItem("Cek", Nothing, AddressOf mnuBill_Click)
        '    mnu.Items.AddRange(New ToolStripItem() {mnuBill})
        '    Dim mypoint As Point = gvDaftar.PointToClient(Control.MousePosition)

        '    mnu.Show(gvDaftar, mypoint.X, mypoint.Y)

        'End If
    End Sub

    Private Sub mnuBill_Click(ByVal sender As Object, ByVal e As EventArgs)
        'gvDaftar.Columns("cek").Value = True
       
    End Sub
       
End Class