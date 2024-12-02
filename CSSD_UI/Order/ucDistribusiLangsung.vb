Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports System.IO
Imports RockUtil

Public Class ucDistribusiLangsung

    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Public noorder As String
    Public Lihatdetail As Boolean = False
    Public idorder As Integer
    Public TglAwal As Date
    Public TglAkhir As Date
    Dim KodeGudang As String
    Dim NamaGudang As String
    Dim DEFAULT_GUDANG() As String = {"IBS", "GBS"}

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Lihatdetail = True Then
            Return
        End If

        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return


        If e.KeyCode = Keys.F5 Then

            btnSimpan_Click(sender, e)

        End If

        If e.KeyCode = Keys.F2 Then
            txtKodeBarcode.Focus()
        End If

    End Sub

    Private Sub FormatGridAlat()
        Dim dt As New DataTable("detailItem")
        gridItem.Columns.Clear()
        dt.Columns.Add("NoTracing", GetType(String))
        dt.Columns.Add("NoInventory", GetType(String))
        dt.Columns.Add("KodeAlat", GetType(String))
        dt.Columns.Add("NamaAlat", GetType(String))
        dt.Columns.Add("NamaJenis", GetType(String))
        dt.Columns.Add("Kode_Identifikasi_Alat", GetType(String))
        dt.Columns.Add("NoOrder", GetType(String))
        dt.Columns.Add("RuanganOrder", GetType(String))
        dt.Columns.Add("IdJenisAlat", GetType(String))

        gridItem.DataSource = dt

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Tracing", 150))
        col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Jenis", 100))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        col.Add(GH.AddModelGridColumn("No.Order", 150))
        col.Add(GH.AddModelGridColumn("Ruangan Order", 250))
        col.Add(GH.AddModelGridColumn("IdJenisAlat", 0))

        GH.FormatGrid(gridItem, dt, col, False, True, True, False)
        'dt.Rows.Add(New Object() {"", "", "", "", "", "", "", "", ""})
        'GH.gridControl(gridItem, GH.GridControlType.Button, "pilih", Color.DarkOliveGreen, 0)
        'GH.gridControl(gridItem, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, gridItem.ColumnCount)
        GH.gridControl(gridItem, GH.GridControlType.Button, "hapus", Color.Red, gridItem.ColumnCount)
        'GH.gridColumnBackColor(gridItem, "Qty", Color.Aqua)
        'GH.gridColumnBackColor(gridItem, "Berat", Color.Aqua)
        'GH.gridColumnBackColor(gridItem, "Keterangan", Color.Aqua)

    End Sub


    Private Sub gridItem_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick

        'If Lihatdetail = True Then
        '    Dim cetakIndex As Integer = gridItem.Columns("Cetak Ceklist").Index
        '    Dim batalindex As Integer = gridItem.Columns("Batal").Index

        '    If e.ColumnIndex = cetakIndex Then
        '        Dim rpt As New crBuktiOrder
        '        Dim frm As New FrmPreview

        '        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        '        Dim dt As New DataTable

        '        dt = Me.cssdServ.GetReportBuktiDistribusi(gridItem.DataSource.rows(e.RowIndex).item(1))

        '        InProcFactory.CloseChannel(Me.cssdServ)
        '        rpt.SetDataSource(dt)
        '        rpt.SetParameterValue("PetugasEntry", SessionInfo.fullName)
        '        frm.crv.ReuseParameterValuesOnRefresh = False
        '        frm.crv.ReportSource = rpt
        '        frm.ShowDialog()
        '    End If

        '    If e.ColumnIndex = batalindex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
        '        If MsgBox("Batalkan distribusi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
        '            Exit Sub
        '        End If


        '        Dim datamaster As New model.CSSD_OrderAlatOperasiDetail
        '        datamaster.userEntry = SessionInfo.uid
        '        datamaster.IdOrder = idorder
        '        datamaster.NoTracing = gridItem.DataSource.rows(e.RowIndex).item(1)
        '        datamaster.NoInventory = gridItem.DataSource.rows(e.RowIndex).item(2)
        '        datamaster.IdOrderDetail = gridItem.DataSource.rows(e.RowIndex).item(0)

        '        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        '        Dim retValBatal As String = Me.cssdServ.BatalDistribusi(datamaster)
        '        InProcFactory.CloseChannel(Me.cssdServ)

        '        gridItem.DataSource = Nothing
        '        gridItem.Columns.Clear()


        '        '------------ format grid ----------------
        '        Dim dtdetailx As New DataTable
        '        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        '        dtdetailx = Me.cssdServ.GetDetailDistribusi(idorder)
        '        If dtdetailx.Rows.Count > 0 Then
        '            gridItem.DataSource = dtdetailx
        '            Dim colx As New List(Of GridColumnModel)
        '            colx.Add(GH.AddModelGridColumn("Id OrderDetail", 0))
        '            colx.Add(GH.AddModelGridColumn("No.Tracing", 160))
        '            colx.Add(GH.AddModelGridColumn("No.Inventory", 250))
        '            colx.Add(GH.AddModelGridColumn("Kode Alat", 100))
        '            colx.Add(GH.AddModelGridColumn("Nama Alat", 100))
        '            colx.Add(GH.AddModelGridColumn("Jenis", 100))

        '            GH.FormatGrid(gridItem, dtdetailx, colx, False, True, True, False)
        '            GH.gridControl(gridItem, GH.GridControlType.Button, "Cetak Ceklist", Color.DarkOliveGreen, gridItem.ColumnCount)
        '            GH.gridControl(gridItem, GH.GridControlType.Button, "Batal", Color.Orange, gridItem.ColumnCount)
        '            InProcFactory.CloseChannel(Me.cssdServ)
        '        End If

        '    End If


        '    Return

        'End If


        'Dim pilihIndex As Integer = gridItem.Columns("pilih").Index
        Dim hapusIndex As Integer = gridItem.Columns("hapus").Index


        'If e.ColumnIndex = pilihIndex Then

        '    Dim idUser As Long = SessionInfo.uid
        '    Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        '    Dim dataUser As New model.CSSD_MappingUserGudang
        '    dataUser = Me.cssdSetupServ.ViewUserTerdaftarGudang(idUser)
        '    NamaGudang = dataUser.NamaGudang
        '    KodeGudang = dataUser.KodeGudang
        '    InProcFactory.CloseChannel(Me.cssdSetupServ)

        '    'cek user terdaftar digudang mana
        '    If Not DEFAULT_GUDANG.Contains(KodeGudang) Then
        '        MsgBox("Maaf anda tidak mempunyai akses dimenu ini, anda terdaftar digudang : " & NamaGudang, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
        '        Exit Sub
        '    End If

        '    Dim frmLookUp As New UILibs.DlgLookUp()

        '    frmLookUp.fidArray = {{"NoTracing", "No.Tracing", 150},
        '                            {"NoInventory", "No. Inv", 100},
        '                            {"KodeAlat", "Kode", 100},
        '                            {"NamaAlat", "Nama Alat", 250},
        '                            {"NamaJenis", "Jenis", 100},
        '                            {"Kode_Identifikasi_Alat", "Kode Reuse", 130},
        '                            {"NoOrder", "No.Order", 150},
        '                            {"RuanganOrder", "Ruangan Order", 250},
        '                            {"IdJenisAlat", "IdJenisAlat", 0}}


        '    'frmLookUp.keyField = "NoInventory"
        '    frmLookUp.keyField = "NoTracing"
        '    frmLookUp.fields = {"NoTracing", "KodeAlat", "NamaAlat", "NamaJenis", "Kode_Identifikasi_Alat", "NoOrder", "RuanganOrder"}

        '    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        '    Dim dt As New DataTable
        '    'dt = Me.cssdServ.GetInventoryOnGudang("ALL")
        '    dt = Me.cssdServ.GetInventoryOnGudang(KodeGudang)
        '    frmLookUp.dt = dt

        '    InProcFactory.CloseChannel(Me.cssdServ)

        '    If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

        '        For i As Integer = 0 To gridItem.RowCount - 1
        '            'If frmLookUp.returnRow("NoInventory").ToString() = gridItem.DataSource.rows(i).item(1) Then
        '            '    MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
        '            '    Exit Sub
        '            'End If

        '            If frmLookUp.returnRow("NoTracing").ToString() = gridItem.DataSource.rows(i).item(0) Then
        '                MsgBox("No Tracing yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
        '                Exit Sub
        '            End If

        '            'If frmLookUp.returnRow("NoOrder").ToString() <> gridItem.DataSource.rows(i).item(5) And gridItem.DataSource.rows(i).item(5) <> "" Then
        '            '    MsgBox("kode Alat harus dalam satu No.Order yang sama", MsgBoxStyle.Exclamation, "Peringatan")
        '            '    Exit Sub
        '            'End If
        '        Next

        '        If Convert.ToString(gridItem.DataSource.rows(e.RowIndex).item(1)) = "" Then
        '            gridItem.DataSource.rows.add(New Object() {"", "", "", "", "", "", "", "", ""})
        '        End If

        '        gridItem.DataSource.rows(e.RowIndex).item(0) = frmLookUp.returnRow("NoTracing").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(1) = frmLookUp.returnRow("NoInventory").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(2) = frmLookUp.returnRow("KodeAlat").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(3) = frmLookUp.returnRow("NamaAlat").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(4) = frmLookUp.returnRow("NamaJenis").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(5) = frmLookUp.returnRow("Kode_Identifikasi_Alat").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(6) = frmLookUp.returnRow("NoOrder").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(7) = frmLookUp.returnRow("RuanganOrder").ToString()
        '        gridItem.DataSource.rows(e.RowIndex).item(8) = frmLookUp.returnRow("IdJenisAlat").ToString()

        '    End If

        'End If

        If e.ColumnIndex = hapusIndex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
            If MsgBox("Hapus data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                Exit Sub
            End If
            gridItem.DataSource.rows(e.RowIndex).delete()
        End If

    End Sub

    Private Sub SaveData()
        Try
            If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

            Dim OrderAlatHeader As New model.CSSD_OrderAlatOperasiHeader
            Dim OrderAlatDetail As model.CSSD_OrderAlatOperasiDetail
            Dim ListItem As New List(Of model.CSSD_OrderAlatOperasiDetail)
            Dim retVal As String = String.Empty

            OrderAlatHeader.IdOperasi = 0
            OrderAlatHeader.NoRegister = 0
            OrderAlatHeader.UserInput = SessionInfo.uid
            OrderAlatHeader.Status = "LANGSUNG"
            OrderAlatHeader.UserPenerima = String.Empty

            '---- collect item
            For i As Integer = 0 To gridItem.DataSource.rows.count - 1
                With gridItem.DataSource.rows(i)

                    If gridItem.DataSource.rows(i).item(1) <> String.Empty Then
                        OrderAlatDetail = New model.CSSD_OrderAlatOperasiDetail
                        OrderAlatDetail.NoTracing = gridItem.DataSource.rows(i).item(0)
                        OrderAlatDetail.NoInventory = gridItem.DataSource.rows(i).item(1)
                        OrderAlatDetail.Keterangan = ""
                        ListItem.Add(OrderAlatDetail)
                    End If

                End With
            Next
            '---- eoc collect item

            If ListItem.Count = 0 Then
                MsgBox("ERROR :tidak ada item yang akan disimpan, pilih item untuk disimpan!", MsgBoxStyle.Exclamation)
                Return
            End If

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            retVal = Me.cssdServ.SaveDistribusiLangsung(OrderAlatHeader, ListItem)
            InProcFactory.CloseChannel(Me.cssdServ)

            If InStr(retVal, "ERROR") Then
                MessageBox.Show("Gagal Menyimpan data :" & retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else
                MessageBox.Show("data berhasil di simpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim rpt As New crBuktiDistLangsung
                Dim frm As New FrmPreview

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

                Dim dt As New DataTable

                dt = Me.cssdServ.GetReportBuktiDistribusi(retVal)

                InProcFactory.CloseChannel(Me.cssdServ)
                rpt.SetDataSource(dt)
                frm.crv.ReuseParameterValuesOnRefresh = False
                frm.crv.ReportSource = rpt
                frm.ShowDialog()

                UtilsLibs.MainMod.resetText(Me)
                gridItem.DataSource = Nothing
                gridItem.Columns.Clear()
                Me.FormatGridAlat()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Me.SaveData()
    End Sub

    Private Sub ucDistribusiLangsung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtKodeBarcode.Focus()

        If Lihatdetail = False Then
            btnCetakLabelCeklist.Visible = False
            Me.FormatGridAlat()
        End If

    End Sub

    Private Sub BtnKeluar_Click(sender As System.Object, e As System.EventArgs) Handles BtnKeluar.Click
        'Me.Dispose()
        Dim uc As New ucDistribusiLangsungDaftar
        uc.dtFrom.Value = TglAwal
        uc.dtTo.Value = TglAkhir

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub
  
    Private Sub txtKodeBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim idUser As Long = SessionInfo.uid
            Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim dataUser As New model.CSSD_MappingUserGudang
            dataUser = Me.cssdSetupServ.ViewUserTerdaftarGudang(idUser)
            NamaGudang = dataUser.NamaGudang
            KodeGudang = dataUser.KodeGudang
            InProcFactory.CloseChannel(Me.cssdSetupServ)

            'cek user terdaftar digudang mana
            If Not DEFAULT_GUDANG.Contains(KodeGudang) Then
                MsgBox("Maaf anda tidak mempunyai akses dimenu ini, anda terdaftar digudang : " & NamaGudang, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                txtKodeBarcode.Focus()
                Return
            End If

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim dtview As New DataTable
            dtview = Me.cssdServ.GetNoTrackingOnGudang(KodeGudang, txtKodeBarcode.Text)
            InProcFactory.CloseChannel(Me.cssdServ)

            If dtview.Rows.Count = 0 Then
                MsgBox("Maaf No Tracing tidak ditemukan di gudang : " & NamaGudang, MsgBoxStyle.Exclamation, "Peringatan")
                txtKodeBarcode.Focus()
                Return
            End If

            For i As Integer = 0 To gridItem.RowCount - 1
                'If frmLookUp.returnRow("NoInventory").ToString() = gridItem.DataSource.rows(i).item(1) Then
                '    MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                '    Exit Sub
                'End If

                If dtview.Rows(0)("NoTracing").ToString() = gridItem.DataSource.rows(i).item(0) Then
                    MsgBox("No Tracing yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                    txtKodeBarcode.Focus()
                    Return
                End If

                'If dtview.Rows(0)("NoOrder").ToString() <> gridItem.DataSource.rows(i).item(6) And gridItem.DataSource.rows(i).item(6) <> "" Then
                '    MsgBox("No Tracing harus dalam satu No.Order yang sama", MsgBoxStyle.Exclamation, "Peringatan")
                '    txtKodeBarcode.Focus()
                '    Return
                'End If
            Next

            gridItem.DataSource.Rows.Add(New Object() {dtview.Rows(0)("NoTracing").ToString(),
                                                       dtview.Rows(0)("NoInventory").ToString(),
                                                       dtview.Rows(0)("KodeAlat").ToString(),
                                                       dtview.Rows(0)("NamaAlat").ToString(),
                                                       dtview.Rows(0)("NamaJenis").ToString(),
                                                       dtview.Rows(0)("Kode_Identifikasi_Alat").ToString(),
                                                       dtview.Rows(0)("NoOrder").ToString(),
                                                       dtview.Rows(0)("RuanganOrder").ToString(),
                                                       dtview.Rows(0)("IdJenisAlat").ToString()})

            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()

        End If
    End Sub

End Class
