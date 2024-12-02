Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucDistribusiDaftar
    Private cssdServ As ICSSDOrderService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView

    Sub loadData()
        dgvDaftar.DataSource = Nothing
        dgvDaftar.Columns.Clear()

        Dim dt As New DataTable

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        dt = Me.cssdServ.GetAllDistribusiAlat(dtFrom.Value, dtTo.Value)
        InProcFactory.CloseChannel(Me.cssdServ)

        dv.Table = dt
        dgvDaftar.DataSource = dv

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id Order", 0))
        col.Add(GH.AddModelGridColumn("Id Operasi", 0))
        col.Add(GH.AddModelGridColumn("No.Register", 100))
        'col.Add(GH.AddModelGridColumn("TglOrder", 160))
        col.Add(GH.AddModelGridColumn("Nama Pasien", 300))
        col.Add(GH.AddModelGridColumn("Tgl.Distribusi", 160))
        col.Add(GH.AddModelGridColumn("Status", 100))
        GH.FormatGrid(dgvDaftar, dt, col, False, True, False, False)

        'GH.gridControl(dgvDaftar, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, 0)
    End Sub

    Private Sub btnTampil_Click(sender As System.Object, e As System.EventArgs) Handles btnTampil.Click
        loadData()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNewJadwalOp.Click
        'UILibs.PageLink.goToPage(Me.Parent, New ucDistribusi(), Me)
        Dim uc As New ucDistribusi
        uc.TglAwal = dtFrom.Value
        uc.TglAkhir = dtTo.Value

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnLihatDetail_Click(sender As System.Object, e As System.EventArgs) Handles btnLihatDetail.Click
        If dgvDaftar.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang akan di lihat.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim IdOrder As Long
        Dim IdOperasi As Long
        Dim NoRegister As Long
        IdOrder = dgvDaftar.SelectedRows(0).DataBoundItem(0)
        IdOperasi = dgvDaftar.SelectedRows(0).DataBoundItem(1)
        NoRegister = dgvDaftar.SelectedRows(0).DataBoundItem(2)

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim masterOrder As New model.CSSD_PasienOperasiView
        Dim dtDetail As New DataTable
        masterOrder = Me.cssdServ.ViewPasienOperasi(IdOperasi, NoRegister)

        Dim uc As New ucDistribusi
        uc.idorder = IdOrder
        uc.txtNoRegister.Tag = masterOrder.id
        uc.txtNoRegister.Text = masterOrder.NoRegister
        uc.txtNamaPasien.Text = masterOrder.Nama
        uc.txtUmur.Text = masterOrder.Umur
        uc.txtRuang.Text = masterOrder.ruang
        uc.txtDiagnosa.Text = masterOrder.diagnosa
        uc.txtTindakan.Text = masterOrder.tindakan
        uc.txtOperator.Text = masterOrder.OperatorUser
        uc.txtAsisten.Text = masterOrder.StaffUser
        uc.txtOk.Text = masterOrder.theater_name
        uc.txtOKLocation.Text = masterOrder.theater_location
        uc.txtTanggalOperasi.Text = masterOrder.TanggalOperasi
        uc.txtJamOperasi.Text = masterOrder.JamOperasi

        uc.TglAwal = dtFrom.Value
        uc.TglAkhir = dtTo.Value

        dtDetail = Me.cssdServ.GetDetailDistribusi(IdOrder)
        uc.gridItem.DataSource = dtDetail
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id OrderDetail", 0))
        col.Add(GH.AddModelGridColumn("No.Tracing", 160))
        col.Add(GH.AddModelGridColumn("No.Inventory", 250))
        col.Add(GH.AddModelGridColumn("Kode Alat", 100))
        col.Add(GH.AddModelGridColumn("Nama Alat", 100))
        col.Add(GH.AddModelGridColumn("Jenis", 100))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        col.Add(GH.AddModelGridColumn("IdJenisAlat", 0))

        GH.FormatGrid(uc.gridItem, dtDetail, col, False, True, True, False)
        GH.gridControl(uc.gridItem, GH.GridControlType.Button, "Cetak Ceklist", Color.DarkOliveGreen, uc.gridItem.ColumnCount)
        GH.gridControl(uc.gridItem, GH.GridControlType.Button, "Batal Distribusi", Color.Crimson, uc.gridItem.ColumnCount)
        InProcFactory.CloseChannel(Me.cssdServ)
        uc.btnSimpan.Visible = False
        uc.btnLookupPasien.Visible = False
        uc.Lihatdetail = True
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged
        Dim str As String = CType(sender, TextBox).Text
        dv.RowFilter = String.Format("NoRegister LIKE '%{0}%'", str)
    End Sub

    Private Sub btnNewRuangan_Click(sender As System.Object, e As System.EventArgs)
        'UILibs.PageLink.goToPage(Me.Parent, New ucDistribusiRuangan(), Me)
        Dim uc As New ucDistribusiRuangan
        uc.TglAwal = dtFrom.Value
        uc.TglAkhir = dtTo.Value

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnNewLangsung_Click(sender As System.Object, e As System.EventArgs)
        'UILibs.PageLink.goToPage(Me.Parent, New ucDistribusiLangsung(), Me)
        Dim uc As New ucDistribusiLangsung
        uc.TglAwal = dtFrom.Value
        uc.TglAkhir = dtTo.Value

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub ucDistribusiDaftar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

End Class
