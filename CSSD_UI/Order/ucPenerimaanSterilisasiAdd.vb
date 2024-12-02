Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports GenCode128
Imports System.IO
Imports RockUtil
Imports CSSD_SERVICE.CSSDSettings

Public Class ucPenerimaanSterilisasiAdd

    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Public NoOrderParam As String
    Public Edit As Boolean = False

    'no tracing ex: 201801009611BSC1 = no. order + no. inv tanpa special char(-,.)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UILibs.MyResources.setButtonIcon(btnLookUnit, "Open v2.png")


    End Sub

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return


        If e.KeyCode = Keys.F5 Then

            btnSimpan_Click(sender, e)

        End If
    End Sub

    Private Sub btnLookUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUnit.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeGudang", "Kode", 100},
                              {"NamaGudang", "Keterangan", 300},
                              {"Telp", "Telp", 100}}

        frmLookUp.keyField = "KodeGudang"
        frmLookUp.fields = {"KodeGudang", "NamaGudang", "Telp"}

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dtPoli As New DataTable
        'dtPoli = Me.cssdSetupServ.getPolyRoomByType("IN")
        dtPoli = Me.cssdSetupServ.GetAllSetupMasterGudang
        frmLookUp.dt = dtPoli

        InProcFactory.CloseChannel(Me.cssdSetupServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtNamaUnit.Tag = frmLookUp.returnRow("KodeGudang").ToString()
            txtNamaUnit.Text = frmLookUp.returnRow("NamaGudang").ToString()
            txtTelp.Text = frmLookUp.returnRow("Telp").ToString()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click


        If txtNamaUnit.Text = String.Empty Then
            MessageBox.Show("Maaf nama unit harus diisi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If cbBarang.Text = String.Empty Then
            MessageBox.Show("Maaf jenis barang harus diisi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If cbTypeOrder.Text = String.Empty Then
            MessageBox.Show("Maaf jenis order harus diisi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If txtPetugasSterilisasi.Text = String.Empty Then
            MessageBox.Show("Maaf nama petugas sterilisasi  harus diisi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Try
            If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

            Dim retVal As String = String.Empty

            Dim MasterOrder As New model.CSSD_MasterOrder
            Dim DetailOrder As model.CSSD_DetailOrder
            Dim ListItem As New List(Of model.CSSD_DetailOrder)

            MasterOrder.PetugasOrder = txtPetugasOrder.Text
            MasterOrder.Poly.polyCode = txtNamaUnit.Tag
            MasterOrder.Telp = txtTelp.Text
            MasterOrder.UserInput = SessionInfo.uid
            If CheckBox1.Checked = True Then
                MasterOrder.TglDatang = dtpTglDatang.Value.ToString("yyyy-MM-dd HH:mm")
            End If
            MasterOrder.jenisBarang = cbBarang.Text
            MasterOrder.type_order = cbTypeOrder.Text
            MasterOrder.PetugasSterilisasi = txtPetugasSterilisasi.Tag
            If Me.Edit = True Then
                'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                'retVal = Me.cssdServ.SetTanggalDatang(txtNoOrder.Text, dtpTglDatang.Value)
                'InProcFactory.CloseChannel(Me.cssdServ)
                'If InStr(retVal, "ERROR") Then
                '    MessageBox.Show("Gagal set tanggal datang", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Return
                'Else
                '    MessageBox.Show("Tanggal Datang berhasil di simpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    UILibs.PageLink.goToPage(Me.Parent, New ucPenerimaanSterilisasiDaftar(), Me)
                'End If
                'Return

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                MasterOrder.NoOrder = txtNoOrder.Text
                MasterOrder.update_by = SessionInfo.un

                retVal = Me.cssdServ.UpdateMasterOrder(MasterOrder)

                InProcFactory.CloseChannel(Me.cssdServ)

                If InStr(retVal, "ERROR") Then
                    MessageBox.Show("Gagal update data", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                Else
                    MessageBox.Show("data berhasil diupdate", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Return
            End If


            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

            '---- collect item
            For i As Integer = 0 To gridItem.DataSource.rows.count - 1
                With gridItem.DataSource.rows(i)

                    If gridItem.DataSource.rows(i).item(1) <> String.Empty Then

                        If gridItem.DataSource.rows(i).item(9) = "TROMOL" Or gridItem.DataSource.rows(i).item(10) = "Perulangan" Then
                            If gridItem.DataSource.rows(i).item(3) > 1 Then
                                MsgBox("Maaf, untuk TROMOL dan SINGLE USE DI REUSE Perulangan, jumlah tidak boleh melebihi 1 !", MsgBoxStyle.Exclamation, "Peringatan")
                                Return
                            End If
                        End If

                        For j = 1 To gridItem.DataSource.rows(i).item(3)
                            DetailOrder = New model.CSSD_DetailOrder
                            DetailOrder.NoInventory = gridItem.DataSource.rows(i).item(0)
                            'DetailOrder.QtyTerima = gridItem.DataSource.rows(i).item(3)
                            DetailOrder.QtyTerima = 1
                            DetailOrder.Berat = gridItem.DataSource.rows(i).item(4)
                            DetailOrder.KodeSatuan = gridItem.DataSource.rows(i).item(5)
                            DetailOrder.Keterangan = gridItem.DataSource.rows(i).item(7).ToString
                            DetailOrder.IdJenisAlat = gridItem.DataSource.rows(i).item(8)
                            DetailOrder.create_by = SessionInfo.un
                            DetailOrder.JenisReuse = gridItem.DataSource.rows(i).item(10)
                            DetailOrder.KodeIdentifikasi = gridItem.DataSource.rows(i).item(11)
                            ListItem.Add(DetailOrder)
                        Next

                    End If

                End With
            Next
            '---- eoc collect item

            If ListItem.Count = 0 Then
                MsgBox("ERROR :tidak ada item yang akan disimpan, pilih item untuk disimpan!", MsgBoxStyle.Exclamation)
                Return
            End If

            retVal = Me.cssdServ.SaveOrder(MasterOrder, ListItem)

            InProcFactory.CloseChannel(Me.cssdServ)

            If InStr(retVal, "ERROR") Then
                MessageBox.Show("Gagal Menyimpan data", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else
                txtNoOrder.Text = retVal
                MessageBox.Show("data berhasil di simpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CetakBuktiOrder(retVal)

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim dtcek As New DataTable
                dtcek = Me.cssdServ.GetReportNoReuse(retVal, "Baru")
                InProcFactory.CloseChannel(Me.cssdServ)
                If dtcek.Rows.Count > 0 Then
                    CetakNoReuse(retVal, "Baru")
                End If

                CetakNoTracing(retVal)

                UtilsLibs.MainMod.resetText(Me)
                gridItem.DataSource = Nothing
                gridItem.Columns.Clear()
                Me.FormatGridAlat()
                cbBarang.Text = Nothing
                cbTypeOrder.Text = Nothing
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CetakNoTracing(ByVal NoOrder As String)
        'Me.Cursor = Cursors.AppStarting

        'Dim frmCetak As New frmCetakNoTracing

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim dtOrder As New DataTable
        'dtOrder = Me.cssdServ.GetReportNoTracing(NoOrder, String.Empty)
        'InProcFactory.CloseChannel(Me.cssdServ)

        'For Each row As DataRow In dtOrder.Rows
        '    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        '    Dim dtAlat As New DataTable
        '    dtAlat = Me.cssdServ.GetReportNoTracing(NoOrder, row("label_type"))
        '    InProcFactory.CloseChannel(Me.cssdServ)

        '    For i As Integer = 0 To dtAlat.Rows.Count - 1
        '        Dim img As Image = Code128Rendering.MakeBarcodeImage(dtAlat.Rows(i).Item(1).ToString(), 1, False)
        '        Dim ms As New MemoryStream
        '        img.Save(ms, Imaging.ImageFormat.Bmp)
        '        Dim byt() As Byte = ms.ToArray

        '        dtAlat.Rows(i).Item(5) = byt
        '    Next

        '    frmCetak.dt = dtAlat
        '    frmCetak.label_type = row("label_type")
        '    frmCetak.ShowDialog()
        'Next

        'Me.Cursor = Cursors.Default



        Me.Cursor = Cursors.AppStarting

        Dim frmCetak As New frmCetakNoTracing

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dtAlat As New DataTable
        dtAlat = Me.cssdServ.GetReportNoTracing(NoOrder, String.Empty)
        InProcFactory.CloseChannel(Me.cssdServ)

        For i As Integer = 0 To dtAlat.Rows.Count - 1
            Dim img As Image = Code128Rendering.MakeBarcodeImage(dtAlat.Rows(i).Item(1).ToString(), 1, False)
            Dim ms As New MemoryStream
            img.Save(ms, Imaging.ImageFormat.Bmp)
            Dim byt() As Byte = ms.ToArray

            dtAlat.Rows(i).Item(5) = byt
        Next

        frmCetak.dt = dtAlat
        frmCetak.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CetakNoReuse(ByVal NoOrder As String, ByVal JenisReuse As String)
        Dim frmCetak As New frmCetakNoReuse

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdServ.GetReportNoReuse(NoOrder, JenisReuse)
        InProcFactory.CloseChannel(Me.cssdServ)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim img As Image = Code128Rendering.MakeBarcodeImage(dt.Rows(i).Item(0).ToString(), 1, False)
            Dim ms As New MemoryStream
            img.Save(ms, Imaging.ImageFormat.Bmp)
            Dim byt() As Byte = ms.ToArray

            dt.Rows(i).Item(2) = byt
        Next

        frmCetak.dt = dt
        frmCetak.ShowDialog()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        UILibs.PageLink.goToPage(Me.Parent, New ucPenerimaanSterilisasiDaftar(), Me)
    End Sub

    Private Sub FormatGridAlat()
        Dim dt As New DataTable("detailItem")
        gridItem.Columns.Clear()
        dt.Columns.Add("NoInventory", GetType(String))
        dt.Columns.Add("KodeAlat", GetType(String))
        dt.Columns.Add("NamaAlat", GetType(String))
        dt.Columns.Add("Qty", GetType(Integer))
        dt.Columns.Add("Berat", GetType(Decimal))
        dt.Columns.Add("KodeSatuan", GetType(String))
        dt.Columns.Add("Satuan", GetType(String))
        dt.Columns.Add("Keterangan", GetType(String))
        dt.Columns.Add("IdJenisAlat", GetType(String))
        dt.Columns.Add("JenisAlat", GetType(String))
        dt.Columns.Add("JenisReuse", GetType(String))
        dt.Columns.Add("KodeIdentifikasi", GetType(String))

        gridItem.DataSource = dt

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Jumlah", 70))
        col.Add(GH.AddModelGridColumn("Berat", 70))
        col.Add(GH.AddModelGridColumn("KodeSatuan", 0))
        col.Add(GH.AddModelGridColumn("Satuan", 70))
        col.Add(GH.AddModelGridColumn("Keterangan", 180))
        col.Add(GH.AddModelGridColumn("IdJenisAlat", 0))
        col.Add(GH.AddModelGridColumn("Jenis Alat", 130))
        col.Add(GH.AddModelGridColumn("Jenis Reuse", 90))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        GH.FormatGrid(gridItem, dt, col, False, True, True, False)
        dt.Rows.Add(New Object() {"", "", "", 0, 0, 0, "", "", 0, "", "", ""})
        GH.gridControl(gridItem, GH.GridControlType.Button, "pilih", Color.DarkOliveGreen, 0)
        GH.gridControl(gridItem, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, gridItem.ColumnCount)
        GH.gridControl(gridItem, GH.GridControlType.Button, "hapus", Color.Red, gridItem.ColumnCount)
        GH.gridColumnBackColor(gridItem, "Qty", Color.Aqua)
        GH.gridColumnBackColor(gridItem, "Berat", Color.Aqua)
        GH.gridColumnBackColor(gridItem, "Keterangan", Color.Aqua)

    End Sub

    Sub LoadDetail()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dtDetail As New DataTable
        dtDetail = Me.cssdServ.ViewDetailOrder(NoOrderParam)
        InProcFactory.CloseChannel(Me.cssdServ)

        gridItem.DataSource = dtDetail
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("IdDetailOrder", 0))
        col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        col.Add(GH.AddModelGridColumn("Kode ALat", 0))
        col.Add(GH.AddModelGridColumn("No. Tracing", 150))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Jumlah", 70))
        col.Add(GH.AddModelGridColumn("Berat", 70))
        col.Add(GH.AddModelGridColumn("Satuan", 70))
        col.Add(GH.AddModelGridColumn("Keterangan", 180))
        col.Add(GH.AddModelGridColumn("Jenis Alat", 130))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        GH.FormatGrid(gridItem, dtDetail, col, False, True, False, False)
    End Sub

    Private Sub ucPenerimaanSterilisasiAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        labelPetugasEntry.Text = SessionInfo.fullName
        If NoOrderParam = String.Empty Then
            Me.FormatGridAlat()
            btnCetakBuktiOrder.Visible = False
            btnCetakLabelBarcode.Visible = False
            btnCetakLabelReuse.Visible = False
        Else
            LoadDetail()
        End If

    End Sub

    Private Sub gridItem_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick

        If NoOrderParam <> String.Empty Then
            Return
        End If

        Dim pilihIndex As Integer = gridItem.Columns("pilih").Index
        Dim hapusIndex As Integer = gridItem.Columns("hapus").Index
        Dim DetailIndex As Integer = gridItem.Columns("detail").Index

        If e.ColumnIndex = DetailIndex Then
            Me.ShowDetail(e.RowIndex)
        End If

        If e.ColumnIndex = pilihIndex Then

            'Dim frmLookUp As New UILibs.DlgLookUp()

            'frmLookUp.fidArray = {{"NoInventory", "No. Inv", 100},
            '                        {"KodeAlat", "Kode", 100},
            '                        {"NamaAlat", "Nama Alat", 250},
            '                        {"Berat", "Berat", 100},
            '                        {"KodeSatuan", "KodeSatuan", 0},
            '                        {"NamaSatuan", "NamaSatuan", 100}}

            'frmLookUp.keyField = "NoInventory"
            ''frmLookUp.fields = {"NoInventory", "KodeAlat", "NamaAlat", "Berat", "KodeSatuan", "NamaSatuan"}
            'frmLookUp.fields = {"NoInventory", "KodeAlat", "NamaAlat"}

            'Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

            'Dim dt As New DataTable
            'dt = Me.cssdSetupServ.GetInventoryByJenis(1)
            'frmLookUp.dt = dt

            'InProcFactory.CloseChannel(Me.cssdSetupServ)

            'If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

            '    'cek NoInventory is exist
            '    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            '    Dim retVal As String = Me.cssdServ.ValidateOrder(frmLookUp.returnRow("NoInventory").ToString())
            '    InProcFactory.CloseChannel(Me.cssdServ)
            '    If InStr(retVal, "ERROR") Then
            '        MsgBox(retVal, MsgBoxStyle.Exclamation, "Pesan")
            '        Exit Sub
            '    End If

            '    For i As Integer = 0 To gridItem.RowCount - 1
            '        If frmLookUp.returnRow("NoInventory").ToString() = gridItem.DataSource.rows(i).item(0) Then
            '            MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
            '            Exit Sub
            '        End If
            '    Next

            '    If Convert.ToString(gridItem.DataSource.rows(e.RowIndex).item(1)) = "" Then
            '        gridItem.DataSource.rows.add(New Object() {"", "", "", 0, 0, 0, "", ""})
            '    End If

            '    gridItem.DataSource.rows(e.RowIndex).item(0) = frmLookUp.returnRow("NoInventory")
            '    gridItem.DataSource.rows(e.RowIndex).item(1) = frmLookUp.returnRow("KodeAlat").ToString()
            '    gridItem.DataSource.rows(e.RowIndex).item(2) = frmLookUp.returnRow("NamaAlat").ToString()
            '    gridItem.DataSource.rows(e.RowIndex).item(3) = 1
            '    gridItem.DataSource.rows(e.RowIndex).item(4) = frmLookUp.returnRow("Berat").ToString()
            '    gridItem.DataSource.rows(e.RowIndex).item(5) = frmLookUp.returnRow("KodeSatuan").ToString()
            '    gridItem.DataSource.rows(e.RowIndex).item(6) = frmLookUp.returnRow("NamaSatuan").ToString()

            'End If

            ''ElseIf e.ColumnIndex = gridItem.Columns("Jumlah").Index Or e.ColumnIndex = gridItem.Columns("Berat").Index Then

            ''    If Not IsNumeric(gridItem.DataSource.rows(e.RowIndex).item(3)) Or _
            ''        Not IsNumeric(gridItem.DataSource.rows(e.RowIndex).item(4)) Then
            ''        MsgBox("ERROR :maaf hanya boleh diisi angka saja !", MsgBoxStyle.Exclamation)
            ''        Return
            ''    End If

            Dim dlgLookUp As New dlgLookUpInstrumen

            If dlgLookUp.ShowDialog() = DialogResult.OK Then

                ''cek NoInventory is exist
                'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                'Dim retVal As String

                'If dlgLookUp.txtJenis.Tag = 2 Then
                '    If dlgLookUp.cmbJenis.SelectedItem = "Perulangan" Then
                '        retVal = Me.cssdServ.ValidateOrder(dlgLookUp.gvDaftar.Columns("NoInventory").Value, _
                '                                           dlgLookUp.gvDaftar.Columns("Kode_Identifikasi_Alat").Value)
                '    End If
                'Else
                '    retVal = Me.cssdServ.ValidateOrder(dlgLookUp.gvDaftar.Columns("NoInventory").Value, _
                '                                       String.Empty)
                'End If

                'InProcFactory.CloseChannel(Me.cssdServ)
                'If InStr(retVal, "ERROR") Then
                '    MsgBox(retVal, MsgBoxStyle.Exclamation, "Pesan")
                '    Exit Sub
                'End If

                'For i As Integer = 0 To gridItem.RowCount - 1

                '    If dlgLookUp.txtJenis.Tag = 2 Then
                '        If dlgLookUp.cmbJenis.SelectedItem = "Baru" Then
                '            If dlgLookUp.gvDaftar.Columns("NoInventory").Value = gridItem.DataSource.rows(i).item(0) Then
                '                MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                '                Exit Sub
                '            End If
                '        Else
                '            If Not IsDBNull(gridItem.DataSource.rows(i).item(11)) Then
                '                If dlgLookUp.gvDaftar.Columns("Kode_Identifikasi_Alat").Value = gridItem.DataSource.rows(i).item(11) Then
                '                    MsgBox("kode Reuse yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    Else
                '        If dlgLookUp.gvDaftar.Columns("NoInventory").Value = gridItem.DataSource.rows(i).item(0) Then
                '            MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                '            Exit Sub
                '        End If
                '    End If

                'Next

                'If Convert.ToString(gridItem.DataSource.rows(e.RowIndex).item(1)) = "" Then
                '    gridItem.DataSource.rows.add(New Object() {"", "", "", 0, 0, 0, "", "", "", "", ""})
                'End If

                If gridItem.DataSource.rows(e.RowIndex).item(1) = "" Then
                    gridItem.DataSource.rows(e.RowIndex).delete()
                End If

                For Each row As DataRow In dlgLookUp.dtTemp.Rows
                    'gridItem.DataSource.rows(e.RowIndex).item(0) = dlgLookUp.gvDaftar.Columns("NoInventory").Value
                    'gridItem.DataSource.rows(e.RowIndex).item(1) = dlgLookUp.gvDaftar.Columns("KodeAlat").Value
                    'gridItem.DataSource.rows(e.RowIndex).item(2) = dlgLookUp.gvDaftar.Columns("NamaAlat").Value
                    'gridItem.DataSource.rows(e.RowIndex).item(3) = 1
                    'gridItem.DataSource.rows(e.RowIndex).item(4) = dlgLookUp.gvDaftar.Columns("Berat").Value
                    'gridItem.DataSource.rows(e.RowIndex).item(5) = dlgLookUp.gvDaftar.Columns("KodeSatuan").Value
                    'gridItem.DataSource.rows(e.RowIndex).item(6) = dlgLookUp.gvDaftar.Columns("NamaSatuan").Value
                    'gridItem.DataSource.rows(e.RowIndex).item(8) = dlgLookUp.txtJenis.Tag
                    'gridItem.DataSource.rows(e.RowIndex).item(9) = dlgLookUp.txtJenis.Text
                    'If dlgLookUp.txtJenis.Tag = 2 Then
                    '    If dlgLookUp.cmbJenis.SelectedItem = "Baru" Then
                    '        gridItem.DataSource.rows(e.RowIndex).item(10) = dlgLookUp.cmbJenis.SelectedItem
                    '        gridItem.DataSource.rows(e.RowIndex).item(11) = String.Empty
                    '    Else
                    '        gridItem.DataSource.rows(e.RowIndex).item(10) = dlgLookUp.cmbJenis.SelectedItem
                    '        gridItem.DataSource.rows(e.RowIndex).item(11) = dlgLookUp.gvDaftar.Columns("Kode_Identifikasi_Alat").Value
                    '    End If
                    'Else
                    '    gridItem.DataSource.rows(e.RowIndex).item(10) = String.Empty
                    '    gridItem.DataSource.rows(e.RowIndex).item(11) = String.Empty
                    'End If

                    For i As Integer = 0 To gridItem.RowCount - 1

                        If row("IdJenisAlat") = 2 Then
                            If row("JenisReuse") = "Baru" Then
                                If row("NoInventory") = gridItem.DataSource.rows(i).item(0) Then
                                    MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                                    gridItem.DataSource.rows.add(New Object() {"", "", "", 0, 0, 0, "", "", 0, "", "", ""})
                                    Return
                                End If
                            Else
                                If Not IsDBNull(gridItem.DataSource.rows(i).item(11)) Then
                                    If row("KodeIdentifikasi") = gridItem.DataSource.rows(i).item(11) Then
                                        MsgBox("kode Reuse yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                                        gridItem.DataSource.rows.add(New Object() {"", "", "", 0, 0, 0, "", "", 0, "", "", ""})
                                        Return
                                    End If
                                End If
                            End If
                        Else
                            If row("NoInventory") = gridItem.DataSource.rows(i).item(0) Then
                                MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                                gridItem.DataSource.rows.add(New Object() {"", "", "", 0, 0, 0, "", "", 0, "", "", ""})
                                Return
                            End If
                        End If

                    Next

                    gridItem.DataSource.rows.add(New Object() {row("NoInventory"), _
                                                               row("KodeAlat"), _
                                                               row("NamaAlat"), _
                                                               row("Qty"), _
                                                               row("Berat"), _
                                                               row("KodeSatuan"), _
                                                               row("Satuan"), _
                                                               row("Keterangan"), _
                                                               row("IdJenisAlat"), _
                                                               row("JenisAlat"), _
                                                               row("JenisReuse"), _
                                                               row("KodeIdentifikasi")})

                Next

                gridItem.DataSource.rows.add(New Object() {"", "", "", 0, 0, 0, "", "", 0, "", "", ""})

            End If
        End If

        If e.ColumnIndex = hapusIndex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
            If MsgBox("Hapus data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                Exit Sub
            End If
            gridItem.DataSource.rows(e.RowIndex).delete()
        End If
    End Sub

    Private Sub CetakBuktiOrder(ByVal NoOrder As String)
        Dim rpt As New crBuktiOrder
        Dim frm As New FrmPreview

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetReportBuktiOrder(NoOrder)

        InProcFactory.CloseChannel(Me.cssdServ)
        rpt.SetDataSource(dt)
        'rpt.SetParameterValue("PetugasEntry", SessionInfo.fullName)
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt
        frm.ShowDialog()
    End Sub
   
    Private Sub btnCetakBuktiOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakBuktiOrder.Click
        CetakBuktiOrder(txtNoOrder.Text)
    End Sub

    Private Sub btnCetakLabelBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakLabelBarcode.Click
        CetakNoTracing(txtNoOrder.Text)

        'If gridItem.SelectedRows.Count = 0 Then
        '    MsgBox("Pilih item terlebih dahulu !", MsgBoxStyle.Exclamation, "Peringatan")
        '    Exit Sub
        'End If

        'Dim frmCetak As New frmCetakNoTracing

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim dtAlat As New DataTable
        'dtAlat = Me.cssdServ.GetReportNoTracing_ByItem(gridItem.SelectedRows(0).DataBoundItem(0))
        'InProcFactory.CloseChannel(Me.cssdServ)

        'Dim img As Image = Code128Rendering.MakeBarcodeImage(dtAlat.Rows(0)("NoTracing").ToString, 1, False)
        'Dim ms As New MemoryStream
        'img.Save(ms, Imaging.ImageFormat.Bmp)
        'Dim byt() As Byte = ms.ToArray
        'dtAlat.Rows(0)("barcode") = byt

        'frmCetak.dt = dtAlat
        'frmCetak.jenis_alat = dtAlat.Rows(0)("NamaJenis").ToString
        'frmCetak.ShowDialog()
    End Sub

    Private Sub ShowDetail(ByVal RowIndex As Integer)

        Dim KodeSetInstrumen As String = String.Empty
        KodeSetInstrumen = gridItem.DataSource.rows(RowIndex).item(1)

        If KodeSetInstrumen = String.Empty Then
            Exit Sub
        End If

        Dim frmDetail As New dlgDetailInstrumen

        Dim dtDetail As New DataTable
        Dim detail As New model.CSSD_DetailSetInstrumen
        Dim master As New model.CSSD_MasterSetInstrumen
        detail.KodeSetInstrumen = KodeSetInstrumen
        master.KodeSetInstrumen = KodeSetInstrumen

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        dtDetail = Me.cssdSetupServ.ViewDetailMasterSetInstrumen(detail)

        If gridItem.DataSource.rows(RowIndex).item(9) = "TROMOL" Or _
           gridItem.DataSource.rows(RowIndex).item(9) = "KEMASAN SET" Then
            master = Me.cssdSetupServ.ViewMasterSetInstrumen(master)

            Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
            frmDetail.pbPhoto.ImageLocation = SettingPath.SET_INSTRUMEN_IMAGE_PATH & master.PathFoto
        Else
            master = Me.cssdSetupServ.ViewInstrumenNonSet(master)

            Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
            frmDetail.pbPhoto.ImageLocation = SettingPath.INSTRUMEN_IMAGE_PATH & master.PathFoto
        End If
        InProcFactory.CloseChannel(Me.cssdSetupServ)

        frmDetail.dt = dtDetail
        frmDetail.txtKodeSetInstrumen.Text = master.KodeSetInstrumen
        frmDetail.txtNamaSetInstrumen.Text = master.NamaSetInstrumen
        frmDetail.txtKeterangan.Text = master.Keterangan
        frmDetail.txtTglExpired.Text = master.ExpiredDate
        frmDetail.txtBerat.Text = master.Berat
        frmDetail.txtSatuan.Text = master.Satuan.NamaSatuan
        frmDetail.txtStandarKasa.Text = IIf(master.StandarKasa = 0, "", master.StandarKasa)
        frmDetail.ShowDialog()

    End Sub

    Private Sub gridItem_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles gridItem.DataError
        'MessageBox.Show("Error:  " & e.Context.ToString())

        If e.Context.ToString <> String.Empty Then
            MsgBox("ERROR :maaf hanya boleh diisi angka saja !", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dtpTglDatang.Enabled = True
        Else
            dtpTglDatang.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dlg As New dlgOrderSterilisasi
        dlg.IdOrder = txtNoOrder.Tag
        dlg.btnHapus.Visible = False
        dlg.btnSimpan.Visible = True
        dlg.btnCetakTracking.Visible = False
        dlg.btnCetakReuse.Visible = False
        dlg.ShowDialog()
        LoadDetail()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If gridItem.SelectedRows.Count = 0 Then
            MsgBox("Pilih item terlebih dahulu !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim dlg As New dlgOrderSterilisasi
        dlg.Add = False
        dlg.IdDetailOrder = gridItem.SelectedRows(0).DataBoundItem(0)
        dlg.txtNoInvent.Text = gridItem.SelectedRows(0).DataBoundItem(1)
        dlg.txtKode.Text = gridItem.SelectedRows(0).DataBoundItem(2)
        dlg.txtNama.Text = gridItem.SelectedRows(0).DataBoundItem(4)
        dlg.txtJml.Text = gridItem.SelectedRows(0).DataBoundItem(5)
        dlg.txtBerat.Text = gridItem.SelectedRows(0).DataBoundItem(6)
        dlg.lblSatuan.Text = gridItem.SelectedRows(0).DataBoundItem(7)
        dlg.txtKet.Text = gridItem.SelectedRows(0).DataBoundItem(8)
        dlg.lblJenisAlat.Text = gridItem.SelectedRows(0).DataBoundItem(9)
        dlg.lblReuse.Text = gridItem.SelectedRows(0).DataBoundItem(10)
        dlg.IdOrder = txtNoOrder.Tag

        dlg.btnLookInven.Visible = False
        dlg.btnHapus.Visible = True
        dlg.btnSimpan.Visible = True

        dlg.btnCetakTracking.Visible = True
        dlg.btnCetakReuse.Visible = True

        dlg.txtJml.Enabled = False
        dlg.ShowDialog()
        LoadDetail()
    End Sub

    Private Sub btnCetakLabelReuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakLabelReuse.Click
        CetakNoReuse(txtNoOrder.Text, "Perulangan")

        'If gridItem.SelectedRows.Count = 0 Then
        '    MsgBox("Pilih item terlebih dahulu !", MsgBoxStyle.Exclamation, "Peringatan")
        '    Exit Sub
        'End If

        'Dim frmCetak As New frmCetakNoReuse

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim dt As New DataTable
        'dt = Me.cssdServ.GetReportNoReuse_ByItem(gridItem.SelectedRows(0).DataBoundItem(0))
        'InProcFactory.CloseChannel(Me.cssdServ)

        'For i As Integer = 0 To dt.Rows.Count - 1
        '    Dim img As Image = Code128Rendering.MakeBarcodeImage(dt.Rows(0)("Kode_Identifikasi_Alat").ToString, 1, False)
        '    Dim ms As New MemoryStream
        '    img.Save(ms, Imaging.ImageFormat.Bmp)
        '    Dim byt() As Byte = ms.ToArray

        '    dt.Rows(0)("barcode") = byt
        'Next

        'frmCetak.dt = dt
        'frmCetak.ShowDialog()
    End Sub

    Private Sub btnLookPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookPetugas.Click
        Dim frmLookUpPetugas As New UILibs.DlgLookUp()
        frmLookUpPetugas.fidArray = {{"KodePetugas", "Kode", 0},
                                    {"NamaPetugas", "Petugas", 300}}

        frmLookUpPetugas.keyField = "KodePetugas"
        frmLookUpPetugas.fields = {"KodePetugas", "NamaPetugas"}

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dtPetugas As New DataTable

        dtPetugas = Me.cssdSetupServ.GetAllSetupPetugas
        frmLookUpPetugas.dt = dtPetugas

        InProcFactory.CloseChannel(Me.cssdSetupServ)

        If frmLookUpPetugas.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtPetugasSterilisasi.Tag = frmLookUpPetugas.returnRow("KodePetugas").ToString()
            txtPetugasSterilisasi.Text = frmLookUpPetugas.returnRow("NamaPetugas").ToString()

        End If
    End Sub


    
End Class
