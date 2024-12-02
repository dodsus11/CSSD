Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucDistribusiLangsungDaftar
    Private cssdServ As ICSSDOrderService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView

    Sub loadData()
        dgvDaftar.DataSource = Nothing
        dgvDaftar.Columns.Clear()

        Dim dt As New DataTable

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        dt = Me.cssdServ.GetAllDistribusiLangsung(dtFrom.Value, dtTo.Value)
        InProcFactory.CloseChannel(Me.cssdServ)

        dv.Table = dt
        dgvDaftar.DataSource = dv

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("IdDistribusi", 80))
        col.Add(GH.AddModelGridColumn("IdOrderDetail", 0))
        col.Add(GH.AddModelGridColumn("No.Order", 90))
        col.Add(GH.AddModelGridColumn("No.Tracing", 160))
        col.Add(GH.AddModelGridColumn("No.Inventory", 90))
        col.Add(GH.AddModelGridColumn("Kode Alat", 80))
        col.Add(GH.AddModelGridColumn("Nama Alat", 170))
        col.Add(GH.AddModelGridColumn("Jenis", 80))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        col.Add(GH.AddModelGridColumn("Ruangan Order", 170))
        col.Add(GH.AddModelGridColumn("Tgl.Distribusi", 110))
        col.Add(GH.AddModelGridColumn("Petugas Distribusi", 130))
        col.Add(GH.AddModelGridColumn("Petugas Penerima", 0))
        col.Add(GH.AddModelGridColumn("Status", 70))
        GH.FormatGrid(dgvDaftar, dt, col, False, True, False, False)

        'GH.gridControl(dgvDaftar, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, 0)
    End Sub

    Private Sub btnTampil_Click(sender As System.Object, e As System.EventArgs) Handles btnTampil.Click
        loadData()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNewJadwalOp.Click
        'UILibs.PageLink.goToPage(Me.Parent, New ucDistribusi(), Me)
        Dim uc As New ucDistribusiLangsung
        uc.TglAwal = dtFrom.Value
        uc.TglAkhir = dtTo.Value

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnLihatDetail_Click(sender As System.Object, e As System.EventArgs) Handles btnLihatDetail.Click
        'If dgvDaftar.SelectedRows.Count = 0 Then
        '    MsgBox("Pilih data yang akan di lihat.", MsgBoxStyle.Exclamation, "Peringatan")
        '    Exit Sub
        'End If

        'Dim IdOrder As Long
        'Dim IdOperasi As Long
        'Dim NoRegister As Long
        'Dim noorder As String
        'IdOrder = dgvDaftar.SelectedRows(0).DataBoundItem(0)
        'IdOperasi = dgvDaftar.SelectedRows(0).DataBoundItem(1)
        'NoRegister = dgvDaftar.SelectedRows(0).DataBoundItem(2)
        'noorder = dgvDaftar.SelectedRows(0).DataBoundItem(6)

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim masterOrder As New model.CSSD_PasienOperasiView
        'Dim dtDetail As New DataTable

        'Dim uc As New ucDistribusiLangsung
        'uc.idorder = IdOrder
        'uc.noorder = noorder
        'uc.TglAwal = dtFrom.Value
        'uc.TglAkhir = dtTo.Value

        'dtDetail = Me.cssdServ.GetDetailDistribusi(IdOrder)
        'uc.gridItem.DataSource = dtDetail
        'Dim col As New List(Of GridColumnModel)
        'col.Add(GH.AddModelGridColumn("Id OrderDetail", 0))
        'col.Add(GH.AddModelGridColumn("No.Tracing", 160))
        'col.Add(GH.AddModelGridColumn("No.Inventory", 250))
        'col.Add(GH.AddModelGridColumn("Kode Alat", 100))
        'col.Add(GH.AddModelGridColumn("Nama Alat", 100))
        'col.Add(GH.AddModelGridColumn("Jenis", 100))

        'GH.FormatGrid(uc.gridItem, dtDetail, col, False, True, True, False)
        'GH.gridControl(uc.gridItem, GH.GridControlType.Button, "Cetak Ceklist", Color.DarkOliveGreen, uc.gridItem.ColumnCount)
        'GH.gridControl(uc.gridItem, GH.GridControlType.Button, "Batal", Color.Orange, uc.gridItem.ColumnCount)
        'InProcFactory.CloseChannel(Me.cssdServ)
        'uc.btnSimpan.Visible = False
        ''uc.btnLookupPasien.Visible = False
        'uc.Lihatdetail = True
        'UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged
        Dim str As String = CType(sender, TextBox).Text
        dv.RowFilter = String.Format("NamaAlat LIKE '%{0}%'", str)
    End Sub

    Private Sub ucDistribusiDaftar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If dgvDaftar.SelectedRows.Count = 0 Then
            MsgBox("Pilih data terlebih dahulu !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim rpt As New crBuktiDistLangsung
        Dim frm As New FrmPreview

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable

        dt = Me.cssdServ.GetReportBuktiDistribusi(dgvDaftar.SelectedRows(0).DataBoundItem(0))

        InProcFactory.CloseChannel(Me.cssdServ)
        rpt.SetDataSource(dt)
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt
        frm.ShowDialog()
    End Sub

    Private Sub btnBatalDist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalDist.Click
        If dgvDaftar.SelectedRows.Count = 0 Then
            MsgBox("Pilih data terlebih dahulu !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Batalkan distribusi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim datamaster As New model.CSSD_OrderAlatOperasiDetail
        datamaster.userEntry = SessionInfo.uid
        datamaster.IdOrder = dgvDaftar.SelectedRows(0).DataBoundItem(0)
        datamaster.IdOrderDetail = dgvDaftar.SelectedRows(0).DataBoundItem(1)
        datamaster.NoTracing = dgvDaftar.SelectedRows(0).DataBoundItem(3)
        datamaster.NoInventory = dgvDaftar.SelectedRows(0).DataBoundItem(4)

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim retValBatal As String = Me.cssdServ.BatalDistribusi(datamaster)
        InProcFactory.CloseChannel(Me.cssdServ)

        dgvDaftar.DataSource = Nothing
        dgvDaftar.Columns.Clear()

        loadData()
    End Sub

End Class
