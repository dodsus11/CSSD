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

Public Class ucDistribusi
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Public idorder As Integer
    Public Lihatdetail As Boolean = False

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
        dt.Columns.Add("IdJenisAlat", GetType(String))

        gridItem.DataSource = dt

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Tracing", 150))
        col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Jenis", 100))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        col.Add(GH.AddModelGridColumn("IdJenisAlat", 0))

        GH.FormatGrid(gridItem, dt, col, False, True, True, False)
        dt.Rows.Add(New Object() {"", "", "", "", "", "", ""})
        GH.gridControl(gridItem, GH.GridControlType.Button, "pilih", Color.DarkOliveGreen, 0)
        'GH.gridControl(gridItem, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, gridItem.ColumnCount)
        GH.gridControl(gridItem, GH.GridControlType.Button, "hapus", Color.Red, gridItem.ColumnCount)
        'GH.gridColumnBackColor(gridItem, "Qty", Color.Aqua)
        'GH.gridColumnBackColor(gridItem, "Berat", Color.Aqua)
        'GH.gridColumnBackColor(gridItem, "Keterangan", Color.Aqua)

    End Sub

    Private Sub ucDistribusi_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Lihatdetail = False Then
            btnCetakLabelCeklist.Visible = False
            Me.FormatGridAlat()
        End If

    End Sub

    Private Sub btnLookupPasien_Click(sender As System.Object, e As System.EventArgs) Handles btnLookupPasien.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        '{"tindakan", "tindakan", 150},
        '{"operator", "operator", 150},
        '{"staff", "staff", 200},

        frmLookUp.fidArray = {{"id", "id", 0},
                              {"NoRegister", "Register", 100},
                              {"nama", "nama", 200},
                              {"umur", "umur", 100},
                              {"ruang", "ruang", 150},
                              {"diagnosa", "diagnosa", 150},
                              {"theater_name", "OK", 100},
                              {"theater_location", "Lokasi OK", 150},
                              {"TanggalOperasi", "Tgl.Operasi", 150},
                              {"JamOperasi", "Jam Operasi", 150}
                             }

        frmLookUp.keyField = "NoRegister"
        frmLookUp.fields = {"NoRegister", "nama"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dtPasien As New DataTable
        dtPasien = Me.cssdServ.GetAllPasienOperasi
        frmLookUp.dt = dtPasien

        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtNoRegister.Tag = frmLookUp.returnRow("id").ToString()
            txtNoRegister.Text = frmLookUp.returnRow("NoRegister").ToString()
            txtNamaPasien.Text = frmLookUp.returnRow("nama").ToString()
            txtUmur.Text = frmLookUp.returnRow("umur").ToString()
            txtRuang.Text = frmLookUp.returnRow("ruang").ToString()
            txtDiagnosa.Text = frmLookUp.returnRow("diagnosa").ToString()
            'txtTindakan.Text = frmLookUp.returnRow("tindakan").ToString()
            'txtOperator.Text = frmLookUp.returnRow("operator").ToString()
            'txtAsisten.Text = frmLookUp.returnRow("staff").ToString()
            txtOk.Text = frmLookUp.returnRow("theater_name").ToString()
            txtOKLocation.Text = frmLookUp.returnRow("theater_location").ToString()
            txtTanggalOperasi.Text = frmLookUp.returnRow("TanggalOperasi").ToString()
            txtJamOperasi.Text = frmLookUp.returnRow("JamOperasi").ToString()
        End If
    End Sub

    Private Sub gridItem_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick

        If Lihatdetail = True Then
            Dim cetakIndex As Integer = gridItem.Columns("Cetak Ceklist").Index
            Dim batalIndex As Integer = gridItem.Columns("Batal Distribusi").Index

            If e.ColumnIndex = cetakIndex Then
                Dim NoTracing As String = String.Empty
                Dim idjenisalat As Integer
                NoTracing = gridItem.DataSource.rows(e.RowIndex).item(1)
                idjenisalat = gridItem.DataSource.rows(e.RowIndex).item(7)

                Dim headerData As New model.CSSD_PasienOperasiView
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                headerData = Me.cssdServ.ViewPasienOperasi(txtNoRegister.Tag, txtNoRegister.Text)
                InProcFactory.CloseChannel(Me.cssdServ)

                If idjenisalat = 1 Or idjenisalat = 4 Then
                    CetakCekListDistribusi(idjenisalat, NoTracing, headerData)
                Else
                    MsgBox("Maaf jenis alat tidak memerlukan checklist ! ", MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                End If

            End If

            If e.ColumnIndex = batalIndex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
                If MsgBox("Batalkan distribusi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                    Exit Sub
                End If


                Dim datamaster As New model.CSSD_OrderAlatOperasiDetail
                datamaster.userEntry = SessionInfo.uid
                datamaster.IdOrder = idorder
                datamaster.NoTracing = gridItem.DataSource.rows(e.RowIndex).item(1)
                datamaster.NoInventory = gridItem.DataSource.rows(e.RowIndex).item(2)
                datamaster.IdOrderDetail = gridItem.DataSource.rows(e.RowIndex).item(0)

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim retValBatal As String = Me.cssdServ.BatalDistribusi(datamaster)
                InProcFactory.CloseChannel(Me.cssdServ)

                gridItem.DataSource = Nothing
                gridItem.Columns.Clear()


                '------------ format grid ----------------
                Dim dtdetailx As New DataTable
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                dtdetailx = Me.cssdServ.GetDetailDistribusi(idorder)
                If dtdetailx.Rows.Count > 0 Then
                    gridItem.DataSource = dtdetailx
                    Dim colx As New List(Of GridColumnModel)
                    colx.Add(GH.AddModelGridColumn("Id OrderDetail", 0))
                    colx.Add(GH.AddModelGridColumn("No.Tracing", 160))
                    colx.Add(GH.AddModelGridColumn("No.Inventory", 250))
                    colx.Add(GH.AddModelGridColumn("Kode Alat", 100))
                    colx.Add(GH.AddModelGridColumn("Nama Alat", 100))
                    colx.Add(GH.AddModelGridColumn("Jenis", 100))
                    colx.Add(GH.AddModelGridColumn("Kode Reuse", 130))
                    colx.Add(GH.AddModelGridColumn("IdJenisAlat", 0))

                    GH.FormatGrid(gridItem, dtdetailx, colx, False, True, True, False)
                    GH.gridControl(gridItem, GH.GridControlType.Button, "Cetak Ceklist", Color.DarkOliveGreen, gridItem.ColumnCount)
                    GH.gridControl(gridItem, GH.GridControlType.Button, "Batal Distribusi", Color.Crimson, gridItem.ColumnCount)
                    InProcFactory.CloseChannel(Me.cssdServ)
                End If

            End If


            Return

        End If


        Dim pilihIndex As Integer = gridItem.Columns("pilih").Index
        Dim hapusIndex As Integer = gridItem.Columns("hapus").Index

        If e.ColumnIndex = pilihIndex Then

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
                Exit Sub
            End If

            Dim frmLookUp As New UILibs.DlgLookUp()

            frmLookUp.fidArray = {{"NoTracing", "No.Tracing", 150},
                                   {"NoInventory", "No. Inv", 100},
                                   {"KodeAlat", "Kode", 100},
                                   {"NamaAlat", "Nama Alat", 250},
                                   {"NamaJenis", "Jenis", 100},
                                   {"Kode_Identifikasi_Alat", "Kode Reuse", 130},
                                   {"NoOrder", "No.Order", 0},
                                   {"RuanganOrder", "Ruangan Order", 0},
                                   {"IdJenisAlat", "IdJenisAlat", 0}}

            'frmLookUp.keyField = "NoInventory"
            frmLookUp.keyField = "NoTracing"
            frmLookUp.fields = {"NoTracing", "KodeAlat", "NamaAlat", "NamaJenis", "Kode_Identifikasi_Alat", "NoOrder", "RuanganOrder"}

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

            Dim dt As New DataTable
            'dt = Me.cssdServ.GetInventoryOnGudang("ALL")
            dt = Me.cssdServ.GetInventoryOnGudang(KodeGudang)
            frmLookUp.dt = dt

            InProcFactory.CloseChannel(Me.cssdServ)

            If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

                'For i As Integer = 0 To gridItem.RowCount - 1
                '    If frmLookUp.returnRow("NoInventory").ToString() = gridItem.DataSource.rows(i).item(1) Then
                '        MsgBox("kode Alat yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                '        Exit Sub
                '    End If
                'Next

                For i As Integer = 0 To gridItem.RowCount - 1
                    If frmLookUp.returnRow("NoTracing").ToString() = gridItem.DataSource.rows(i).item(0) Then
                        MsgBox("No Tracing yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                        Exit Sub
                    End If
                Next

                If Convert.ToString(gridItem.DataSource.rows(e.RowIndex).item(1)) = "" Then
                    gridItem.DataSource.rows.add(New Object() {"", "", "", "", "", "", ""})
                End If

                gridItem.DataSource.rows(e.RowIndex).item(0) = frmLookUp.returnRow("NoTracing").ToString()
                gridItem.DataSource.rows(e.RowIndex).item(1) = frmLookUp.returnRow("NoInventory").ToString()
                gridItem.DataSource.rows(e.RowIndex).item(2) = frmLookUp.returnRow("KodeAlat").ToString()
                gridItem.DataSource.rows(e.RowIndex).item(3) = frmLookUp.returnRow("NamaAlat").ToString()
                gridItem.DataSource.rows(e.RowIndex).item(4) = frmLookUp.returnRow("NamaJenis").ToString()
                gridItem.DataSource.rows(e.RowIndex).item(5) = frmLookUp.returnRow("Kode_Identifikasi_Alat").ToString()
                gridItem.DataSource.rows(e.RowIndex).item(6) = frmLookUp.returnRow("IdJenisAlat").ToString()

            End If

        End If

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

            OrderAlatHeader.IdOperasi = txtNoRegister.Tag
            OrderAlatHeader.NoRegister = txtNoRegister.Text
            OrderAlatHeader.UserInput = SessionInfo.uid
            OrderAlatHeader.Status = "OPERASI"
            OrderAlatHeader.UserPenerima = String.Empty
            
            '---- collect item
            For i As Integer = 0 To gridItem.DataSource.rows.count - 1
                With gridItem.DataSource.rows(i)

                    If gridItem.DataSource.rows(i).item(1) <> String.Empty Then
                        OrderAlatDetail = New model.CSSD_OrderAlatOperasiDetail
                        OrderAlatDetail.NoTracing = gridItem.DataSource.rows(i).item(0)
                        OrderAlatDetail.NoInventory = gridItem.DataSource.rows(i).item(1)
                        OrderAlatDetail.Keterangan = ""
                        OrderAlatDetail.idjenisalat = gridItem.DataSource.rows(i).item(6)
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
                MessageBox.Show("Gagal Menyimpan data", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else
                MessageBox.Show("data berhasil di simpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim headerData As New model.CSSD_PasienOperasiView
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                headerData = Me.cssdServ.ViewPasienOperasi(txtNoRegister.Tag, txtNoRegister.Text)
                InProcFactory.CloseChannel(Me.cssdServ)

                For Each item In ListItem
                    If item.idjenisalat = 1 Or item.idjenisalat = 4 Then
                        CetakCekListDistribusi(item.idjenisalat, item.NoTracing, headerData)
                    End If
                Next

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

    Private Sub CetakCekListDistribusi(ByVal idJenisAlat As Integer,
                      ByVal NoTrace As String,
                      ByVal headerData As model.CSSD_PasienOperasiView)

        Dim frm As New FrmPreview

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable
        Dim data As New model.CSSD_TracingOrderDetail

        dt = Me.cssdServ.GetReportCekLIst(idJenisAlat, NoTrace)
        data = Me.cssdServ.GetTracingOrderDetail(NoTrace)

        InProcFactory.CloseChannel(Me.cssdServ)

        'If idJenisAlat = 1 Then
        Dim rpt As New crCeklistAlatDistribusi

        rpt.SetDataSource(dt)

        rpt.SetParameterValue("NoRegister", headerData.NoRegister)
        rpt.SetParameterValue("Nama", headerData.Nama)
        rpt.SetParameterValue("Umur", headerData.Umur)
        rpt.SetParameterValue("ruang", headerData.ruang)
        rpt.SetParameterValue("diagnosa", headerData.diagnosa)
        rpt.SetParameterValue("tindakan", headerData.tindakan)
        rpt.SetParameterValue("operator", headerData.OperatorUser)
        rpt.SetParameterValue("staff", headerData.StaffUser)
        rpt.SetParameterValue("theater_name", headerData.theater_name)
        rpt.SetParameterValue("theater_location", headerData.theater_location)
        rpt.SetParameterValue("tanggalOperasi", headerData.TanggalOperasi)
        rpt.SetParameterValue("jamOperasi", headerData.JamOperasi)

        rpt.SetParameterValue("TglSetting", data.TglSettingPacking)
        rpt.SetParameterValue("Petugas1", data.PetugasSetting1)
        rpt.SetParameterValue("Petugas2", data.PetugasSetting2)
        rpt.SetParameterValue("NamaAlat", data.NamaAlat)
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt
        frm.ShowDialog()
        'End If

    End Sub

    Private Sub btnCetakLabelCeklist_Click(sender As System.Object, e As System.EventArgs) Handles btnCetakLabelCeklist.Click
        Dim headerData As New model.CSSD_PasienOperasiView
        Dim OrderAlatDetail As model.CSSD_OrderAlatOperasiDetail
        Dim ListItem As New List(Of model.CSSD_OrderAlatOperasiDetail)

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        headerData = Me.cssdServ.ViewPasienOperasi(txtNoRegister.Tag, txtNoRegister.Text)
        InProcFactory.CloseChannel(Me.cssdServ)

        '---- collect item
        For i As Integer = 0 To gridItem.DataSource.rows.count - 1
            With gridItem.DataSource.rows(i)

                If gridItem.DataSource.rows(i).item(1) <> String.Empty Then
                    OrderAlatDetail = New model.CSSD_OrderAlatOperasiDetail
                    OrderAlatDetail.NoTracing = gridItem.DataSource.rows(i).item(1)
                    OrderAlatDetail.idjenisalat = gridItem.DataSource.rows(i).item(7)
                    ListItem.Add(OrderAlatDetail)
                End If

            End With
        Next
        '---- eoc collect item

        For Each item In ListItem
            If item.idjenisalat = 1 Or item.idjenisalat = 4 Then
                CetakCekListDistribusi(item.idjenisalat, item.NoTracing, headerData)
            Else
                MsgBox("Maaf jenis alat tidak memerlukan checklist ! ", MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
            End If
        Next

    End Sub

    Private Sub BtnKeluar_Click(sender As System.Object, e As System.EventArgs) Handles BtnKeluar.Click
        'Me.Dispose()
        Dim uc As New ucDistribusiDaftar
        uc.dtFrom.Value = TglAwal
        uc.dtTo.Value = TglAkhir

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

End Class
