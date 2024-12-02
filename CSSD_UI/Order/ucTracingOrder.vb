Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucTracingOrder
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView

    'Private obj = New CSSDOrderService

    Sub sum_order()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jml As Integer
        jml = Me.cssdServ.GetSumProcess("ORDER")
        InProcFactory.CloseChannel(Me.cssdServ)
        lblOrder.Text = jml
    End Sub

    Sub sum_pencucian()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jml As Integer
        jml = Me.cssdServ.GetSumProcess("PENCUCIAN")
        InProcFactory.CloseChannel(Me.cssdServ)
        lblPencucian.Text = jml
    End Sub

    Sub sum_setting()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jml As Integer
        jml = Me.cssdServ.GetSumProcess("SETTING_PACKING")
        InProcFactory.CloseChannel(Me.cssdServ)
        lblSetting.Text = jml
    End Sub

    Sub sum_sterilisasi()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jml As Integer
        jml = Me.cssdServ.GetSumProcess("STERILISASI")
        InProcFactory.CloseChannel(Me.cssdServ)
        lblSterilisasi.Text = jml
    End Sub

    Sub sum_cssd()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jml As Integer
        jml = Me.cssdServ.GetSumProcess("GUDANG_CSSD")
        InProcFactory.CloseChannel(Me.cssdServ)
        lblCSSD.Text = jml
    End Sub

    Sub sum_ibs()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jml As Integer
        jml = Me.cssdServ.GetSumProcess("GUDANG_IBS")
        InProcFactory.CloseChannel(Me.cssdServ)
        lblIBS.Text = jml
    End Sub

    Sub sum_all()
        sum_order()
        sum_pencucian()
        sum_setting()
        sum_sterilisasi()
        sum_cssd()
        sum_ibs()
    End Sub

    Private Sub ucTracingOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNamaUnit.Tag = ""
        txtNamaUnit.Text = "All"

        txtStatus.Tag = ""
        txtStatus.Text = "All"

        cbTypeOrder.SelectedIndex = 0

        'sum_all()
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        If dtFrom.Value.ToString("yyyy-MM") <> dtTo.Value.ToString("yyyy-MM") Then
            MsgBox("Bulan dan Tahun pada range tanggal harus sama !")
            Exit Sub
        End If

        dgvDaftar.DataSource = Nothing
        dgvDaftar.Columns.Clear()

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        'dt = Me.cssdServ.GetReportTracingOrderMaster(dtFrom.Value, dtTo.Value, txtNamaUnit.Tag, txtStatus.Tag)
        'dt = Me.cssdServ.execProcedure("CSSD_TracingOrderGetAll", New Object() {dtFrom.Value, dtTo.Value, txtNamaUnit.Tag, txtStatus.Tag, cbTypeOrder.Text})
        dt = Me.cssdServ.execProcedure("CSSD_TracingOrderGetAll_Rev1", New Object() {dtFrom.Value, dtTo.Value, txtNamaUnit.Tag, txtStatus.Tag, cbTypeOrder.Text})
        InProcFactory.CloseChannel(Me.cssdServ)

        dv.Table = dt
        dgvDaftar.DataSource = dv

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Order", 100))
        col.Add(GH.AddModelGridColumn("Unit", 120))
        col.Add(GH.AddModelGridColumn("No. Tracing", 150))
        col.Add(GH.AddModelGridColumn("No. Inv", 80))
        col.Add(GH.AddModelGridColumn("Kode", 80))
        col.Add(GH.AddModelGridColumn("Nama", 200))
        col.Add(GH.AddModelGridColumn("Jenis Alat", 130))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        col.Add(GH.AddModelGridColumn("Qty", 40))
        col.Add(GH.AddModelGridColumn("Tgl.Order", 130))
        col.Add(GH.AddModelGridColumn("Tgl.Cuci", 130))
        col.Add(GH.AddModelGridColumn("Tgl.Packing", 130))
        col.Add(GH.AddModelGridColumn("Tgl.Sterilisasi", 130))
        col.Add(GH.AddModelGridColumn("Tgl.Masuk Gudang", 130))
        col.Add(GH.AddModelGridColumn("Tgl.Distribusi", 130))
        col.Add(GH.AddModelGridColumn("Status", 200))
        col.Add(GH.AddModelGridColumn("Tgl.Kadaluarsa", 130))
        col.Add(GH.AddModelGridColumn("Jenis Order", 85))
        col.Add(GH.AddModelGridColumn("Selisih Hari", 0))
        col.Add(GH.AddModelGridColumn("Warna", 0))
        GH.FormatGrid(dgvDaftar, dt, col, False, True, False, False)

        GH.gridControl(dgvDaftar, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, 0)
        'dgvDaftar_CellFormatting()
        sum_all()
    End Sub
   

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        Dim str As String = CType(sender, TextBox).Text
        dv.RowFilter = String.Format("NoOrder LIKE '%{0}%'" &
                                     " OR NamaGudang LIKE '%{0}%'" &
                                     " OR NoTracing LIKE '%{0}%'" &
                                     " OR Kode_Identifikasi_Alat LIKE '%{0}%'" &
                                     " OR JenisAlat LIKE '%{0}%'" &
                                     " OR NamaAlat LIKE '%{0}%'" &
                                     " OR type_order LIKE '%{0}%'" &
                                     " OR NoInventory LIKE '%{0}%'" _
                                         , str)
    End Sub

    Private Sub dgvDaftar_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDaftar.CellContentClick
        Dim detailIndex As Integer = dgvDaftar.Columns("detail").Index

        If e.ColumnIndex = detailIndex Then

            Dim NoTracing As String = String.Empty
            NoTracing = dgvDaftar.Item(3, e.RowIndex).Value.ToString

            Dim frmDetail As New frmTracingOrderDetail_Rev
            Dim data As New model.CSSD_TracingOrderDetail

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            data = Me.cssdServ.GetTracingOrderDetail(NoTracing)
            InProcFactory.CloseChannel(Me.cssdServ)

            If dgvDaftar.Item(16, e.RowIndex).Value.ToString = "ORDER" Then
                frmDetail.txtNoTracing.Text = data.NoTracing
                frmDetail.txtNoOrder.Text = data.NoOrder
                frmDetail.txtNama_Alat.Text = data.NamaAlat
                frmDetail.txtKode_Alat.Text = data.KodeAlat
                frmDetail.txtNama_Unit.Text = data.poly_name
                frmDetail.txtTlp.Text = data.Telp
                frmDetail.txtTglEntry.Text = data.TglInput
                frmDetail.txtOrder_PetugasSterilisasi.Text = data.Petugas_input_cssd
                frmDetail.txtOrder_PetugasRuang.Text = data.PetugasOrder
                frmDetail.txtJenisBarang.Text = data.JenisAlat
                frmDetail.txt_JenisOrder.Text = data.type_order
                frmDetail.txt_SterilisasiStatusTerakhir.Text = data.StatusOrder
                frmDetail.txtSterilisasiTgl.Text = data.TglInput
                frmDetail.txtSterilisasiPetugas.Text = data.PetugasSteril
                frmDetail.txtTglKadaluarsa.Text = data.tglKadaluarsa
            ElseIf dgvDaftar.Item(16, e.RowIndex).Value.ToString = "PENCUCIAN" Then
                frmDetail.txtNoTracing.Text = data.NoTracing
                frmDetail.txtNoOrder.Text = data.NoOrder
                frmDetail.txtNama_Alat.Text = data.NamaAlat
                frmDetail.txtKode_Alat.Text = data.KodeAlat
                frmDetail.txtNama_Unit.Text = data.poly_name
                frmDetail.txtTlp.Text = data.Telp
                frmDetail.txtTglEntry.Text = data.TglInput
                frmDetail.txtOrder_PetugasSterilisasi.Text = data.Petugas_input_cssd
                frmDetail.txtOrder_PetugasRuang.Text = data.PetugasOrder
                frmDetail.txtJenisBarang.Text = data.JenisAlat
                frmDetail.txt_JenisOrder.Text = data.type_order
                frmDetail.txt_SterilisasiStatusTerakhir.Text = data.StatusOrder
                frmDetail.txtSterilisasiTgl.Text = data.TglPencucian
                frmDetail.txtSterilisasiPetugas.Text = data.NamaPetugasCuci
                frmDetail.txtTglKadaluarsa.Text = data.tglKadaluarsa
                frmDetail.txtTglCuci.Text = data.TglPencucian
                frmDetail.txtNamaPetugasPencucian.Text = data.NamaPetugasCuci
                frmDetail.txtNamaMesinPencucian.Text = data.NamaMesinCuci

            ElseIf dgvDaftar.Item(16, e.RowIndex).Value.ToString = "SETTING_PACKING" Then
                frmDetail.txtNoTracing.Text = data.NoTracing
                frmDetail.txtNoOrder.Text = data.NoOrder
                frmDetail.txtNama_Alat.Text = data.NamaAlat
                frmDetail.txtKode_Alat.Text = data.KodeAlat
                frmDetail.txtNama_Unit.Text = data.poly_name
                frmDetail.txtTlp.Text = data.Telp
                frmDetail.txtTglEntry.Text = data.TglInput
                frmDetail.txtOrder_PetugasSterilisasi.Text = data.Petugas_input_cssd
                frmDetail.txtOrder_PetugasRuang.Text = data.PetugasOrder
                frmDetail.txtJenisBarang.Text = data.JenisAlat
                frmDetail.txt_JenisOrder.Text = data.type_order
                frmDetail.txt_SterilisasiStatusTerakhir.Text = data.StatusOrder
                frmDetail.txtSterilisasiTgl.Text = data.TglSettingPacking
                frmDetail.txtSterilisasiPetugas.Text = data.PetugasSetting1 & "  " & data.PetugasSetting2
                frmDetail.txtTglKadaluarsa.Text = data.tglKadaluarsa
                frmDetail.txtTglCuci.Text = data.TglPencucian
                frmDetail.txtNamaPetugasPencucian.Text = data.NamaPetugasCuci
                frmDetail.txtNamaMesinPencucian.Text = data.NamaMesinCuci
                frmDetail.txtTglSetting.Text = data.TglSettingPacking
                frmDetail.txtNamaPetugasSetting1.Text = data.PetugasSetting1
                frmDetail.txtNamaPetugasSetting2.Text = data.PetugasSetting2
            ElseIf dgvDaftar.Item(16, e.RowIndex).Value.ToString = "STERILISASI" Then
                frmDetail.txtNoTracing.Text = data.NoTracing
                frmDetail.txtNoOrder.Text = data.NoOrder
                frmDetail.txtNama_Alat.Text = data.NamaAlat
                frmDetail.txtKode_Alat.Text = data.KodeAlat
                frmDetail.txtNama_Unit.Text = data.poly_name
                frmDetail.txtTlp.Text = data.Telp
                frmDetail.txtTglEntry.Text = data.TglInput
                frmDetail.txtOrder_PetugasSterilisasi.Text = data.Petugas_input_cssd
                frmDetail.txtOrder_PetugasRuang.Text = data.PetugasOrder
                frmDetail.txtJenisBarang.Text = data.JenisAlat
                frmDetail.txt_JenisOrder.Text = data.type_order
                frmDetail.txt_SterilisasiStatusTerakhir.Text = data.StatusOrder
                frmDetail.txtSterilisasiTgl.Text = data.TglSterilisasi
                frmDetail.txtSterilisasiPetugas.Text = data.PetugasSteril & "  " & data.PetugasSteril2
                frmDetail.txtTglKadaluarsa.Text = data.tglKadaluarsa
                frmDetail.txtTglCuci.Text = data.TglPencucian
                frmDetail.txtNamaPetugasPencucian.Text = data.NamaPetugasCuci
                frmDetail.txtNamaMesinPencucian.Text = data.NamaMesinCuci
                frmDetail.txtTglSetting.Text = data.TglSettingPacking
                frmDetail.txtNamaPetugasSetting1.Text = data.PetugasSetting1
                frmDetail.txtNamaPetugasSetting2.Text = data.PetugasSetting2
                frmDetail.txtTglSteril.Text = data.TglSterilisasi
                frmDetail.txtNamaPetugasSteril.Text = data.PetugasSteril
                frmDetail.txtnamaSteril2.Text = data.PetugasSteril2
                frmDetail.txtNamaMesinSteril.Text = data.NamaMesinSteril
            ElseIf dgvDaftar.Item(16, e.RowIndex).Value.ToString = "GUDANG_CSSD" Then
                frmDetail.txtNoTracing.Text = data.NoTracing
                frmDetail.txtNoOrder.Text = data.NoOrder
                frmDetail.txtNama_Alat.Text = data.NamaAlat
                frmDetail.txtKode_Alat.Text = data.KodeAlat
                frmDetail.txtNama_Unit.Text = data.poly_name
                frmDetail.txtTlp.Text = data.Telp
                frmDetail.txtTglEntry.Text = data.TglInput
                frmDetail.txtOrder_PetugasSterilisasi.Text = data.Petugas_input_cssd
                frmDetail.txtOrder_PetugasRuang.Text = data.PetugasOrder
                frmDetail.txtJenisBarang.Text = data.JenisAlat
                frmDetail.txt_JenisOrder.Text = data.type_order
                frmDetail.txt_SterilisasiStatusTerakhir.Text = data.StatusOrder
                frmDetail.txtSterilisasiTgl.Text = data.TglmasukGudang
                frmDetail.txtSterilisasiPetugas.Text = data.Petugas_gudang_cssd
                frmDetail.txtTglKadaluarsa.Text = data.tglKadaluarsa
                frmDetail.txtTglCuci.Text = data.TglPencucian
                frmDetail.txtNamaPetugasPencucian.Text = data.NamaPetugasCuci
                frmDetail.txtNamaMesinPencucian.Text = data.NamaMesinCuci
                frmDetail.txtTglSetting.Text = data.TglSettingPacking
                frmDetail.txtNamaPetugasSetting1.Text = data.PetugasSetting1
                frmDetail.txtNamaPetugasSetting2.Text = data.PetugasSetting2
                frmDetail.txtTglSteril.Text = data.TglSterilisasi
                frmDetail.txtNamaPetugasSteril.Text = data.PetugasSteril
                frmDetail.txtnamaSteril2.Text = data.PetugasSteril2
                frmDetail.txtNamaMesinSteril.Text = data.NamaMesinSteril
                frmDetail.txtTglSimpan.Text = data.TglmasukGudang
                frmDetail.txtPetugasSimpan1.Text = data.Petugas_gudang_cssd
                frmDetail.txtPetugasSimpan2.Text = String.Empty

            Else
                frmDetail.txtNoTracing.Text = data.NoTracing
                frmDetail.txtNoOrder.Text = data.NoOrder
                frmDetail.txtNama_Alat.Text = data.NamaAlat
                frmDetail.txtKode_Alat.Text = data.KodeAlat
                frmDetail.txtNama_Unit.Text = data.poly_name
                frmDetail.txtTlp.Text = data.Telp
                frmDetail.txtTglEntry.Text = data.TglInput
                frmDetail.txtOrder_PetugasSterilisasi.Text = data.Petugas_input_cssd
                frmDetail.txtOrder_PetugasRuang.Text = data.PetugasOrder
                frmDetail.txtJenisBarang.Text = data.JenisAlat
                frmDetail.txt_JenisOrder.Text = data.type_order
                frmDetail.txt_SterilisasiStatusTerakhir.Text = data.StatusOrder
                frmDetail.txtSterilisasiTgl.Text = data.TglDistribusi
                frmDetail.txtSterilisasiPetugas.Text = data.PetugasSteril & "  " & data.PetugasOrder
                frmDetail.txtTglKadaluarsa.Text = data.tglKadaluarsa
                frmDetail.txtTglCuci.Text = data.TglPencucian
                frmDetail.txtNamaPetugasPencucian.Text = data.NamaPetugasCuci
                frmDetail.txtNamaMesinPencucian.Text = data.NamaMesinCuci
                frmDetail.txtTglSetting.Text = data.TglSettingPacking
                frmDetail.txtNamaPetugasSetting1.Text = data.PetugasSetting1
                frmDetail.txtNamaPetugasSetting2.Text = data.PetugasSetting2
                frmDetail.txtTglSteril.Text = data.TglSterilisasi
                frmDetail.txtNamaPetugasSteril.Text = data.PetugasSteril
                frmDetail.txtnamaSteril2.Text = data.PetugasSteril2
                frmDetail.txtNamaMesinSteril.Text = data.NamaMesinSteril
                frmDetail.txtTglSimpan.Text = data.TglmasukGudang
                frmDetail.txtPetugasSimpan1.Text = data.Petugas_gudang_cssd
                frmDetail.txtPetugasSimpan2.Text = String.Empty
                frmDetail.txtTglDistribusi.Text = data.TglDistribusi
                frmDetail.txtDistribusi_PetugasSterilisasi.Text = data.Petugas_gudang_cssd
                frmDetail.txtPetugasRuangan.Text = data.PetugasOrder
            End If

            frmDetail.ShowDialog()
        End If


    End Sub

    Private Sub btnLookUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUnit.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeGudang", "Kode", 0},
                              {"NamaGudang", "Ruang", 300},
                              {"Telp", "Telp", 100}}

        frmLookUp.keyField = "KodeGudang"
        frmLookUp.fields = {"KodeGudang", "NamaGudang", "Telp"}

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dtPoli As New DataTable
        'dtPoli = Me.cssdSetupServ.getPolyRoomByType("IN")
        dtPoli = Me.cssdSetupServ.GetAllpoly
        frmLookUp.dt = dtPoli

        InProcFactory.CloseChannel(Me.cssdSetupServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNamaUnit.Tag = frmLookUp.returnRow("KodeGudang").ToString()
            txtNamaUnit.Text = frmLookUp.returnRow("NamaGudang").ToString()
        End If
    End Sub

    Private Sub btnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatus.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"kode", "kode", 0},
                              {"status", "Status", 200}}

        frmLookUp.keyField = "kode"
        frmLookUp.fields = {"kode", "status"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdServ.GetStatusAll
        frmLookUp.dt = dt
        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtStatus.Tag = frmLookUp.returnRow("kode").ToString()
            txtStatus.Text = frmLookUp.returnRow("status").ToString()
        End If
    End Sub

    Private Sub dgvDaftar_CellFormatting()
        Throw New NotImplementedException
    End Sub

    Private Function difference() As Object
        Throw New NotImplementedException
    End Function
    Private Sub dgvDaftar_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvDaftar.RowPrePaint
        If dgvDaftar.Item(20, e.RowIndex).Value.ToString = "hijau" Then
            dgvDaftar.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Lime
        ElseIf dgvDaftar.Item(20, e.RowIndex).Value.ToString = "kuning" Then
            dgvDaftar.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Gold
        ElseIf dgvDaftar.Item(20, e.RowIndex).Value.ToString = "merah" Then
            dgvDaftar.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.DarkRed
        ElseIf dgvDaftar.Item(20, e.RowIndex).Value.ToString = "hitam" Then
            dgvDaftar.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.DarkSlateGray
        End If
    End Sub
End Class
