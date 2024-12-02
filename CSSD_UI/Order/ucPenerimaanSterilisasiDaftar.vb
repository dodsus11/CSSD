Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucPenerimaanSterilisasiDaftar
    Private cssdServ As ICSSDOrderService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        dgvDaftar.DataSource = Nothing
        dgvDaftar.Columns.Clear()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdServ.GetAllMasterOrder(dtFrom.Value, dtTo.Value, cbTypeOrder.Text)
        dv.Table = dt
        dgvDaftar.DataSource = dv

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Order", 100))
        col.Add(GH.AddModelGridColumn("Petugas Order", 200))
        col.Add(GH.AddModelGridColumn("Ruang", 200))
        col.Add(GH.AddModelGridColumn("Telp", 100))
        col.Add(GH.AddModelGridColumn("Tgl. Entry", 200))
        col.Add(GH.AddModelGridColumn("Jenis Order", 200))
        col.Add(GH.AddModelGridColumn("NamaPetugas", 200))
        'col.Add(GH.AddModelGridColumn("Tgl. Datang", 200))
        GH.FormatGrid(dgvDaftar, dt, col, False, True, False, False)

        'GH.gridControl(dgvDaftar, GH.GridControlType.Button, "detail", Color.DarkOliveGreen, 0)

        InProcFactory.CloseChannel(Me.cssdServ)
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        Dim str As String = CType(sender, TextBox).Text
        dv.RowFilter = String.Format("NoOrder LIKE '%{0}%'" &
                                         " OR PetugasOrder LIKE '%{0}%'" &
                                          " OR type_order LIKE '%{0}%'" &
                                          " OR poly_name LIKE '%{0}%'" _
                                         , str)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim uc As New ucPenerimaanSterilisasiAdd
        uc.PanelToolStrip.Visible = False
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub ucPenerimaanSterilisasiDaftar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            btnDelete.Enabled = acl.allowEdit
            btnEdit.Enabled = acl.allowView
            btnNew.Enabled = acl.allowSave
        End If
        cbTypeOrder.SelectedIndex = 0
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'If dgvDaftar.SelectedRows.Count = 0 Then
        '    MsgBox("Pilih data yang akan di edit.", MsgBoxStyle.Exclamation, "Peringatan")
        '    Exit Sub
        'End If

        'Dim NoOrder As String = String.Empty
        'NoOrder = dgvDaftar.SelectedRows(0).DataBoundItem(0)

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim masterOrder As New model.CSSD_MasterOrder
        'Dim dtDetail As New DataTable
        'masterOrder = Me.cssdServ.ViewMasterOrder(NoOrder)

        'Dim uc As New ucPenerimaanSterilisasiAdd
        'uc.txtNoOrder.Text = NoOrder
        'uc.txtNoOrder.ReadOnly = True
        'uc.txtPetugasOrder.Text = masterOrder.PetugasOrder
        'uc.txtPetugasOrder.ReadOnly = True
        'uc.txtNamaUnit.Text = masterOrder.Poly.polyName
        'uc.txtNamaUnit.ReadOnly = True
        'uc.txtTelp.Text = masterOrder.Telp
        'uc.txtTelp.ReadOnly = True
        'dtDetail = Me.cssdServ.ViewDetailOrder(NoOrder)
        'uc.gridItem.DataSource = dtDetail
        'Dim col As New List(Of GridColumnModel)
        'col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        'col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        'col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        'col.Add(GH.AddModelGridColumn("Jumlah", 100))
        'col.Add(GH.AddModelGridColumn("Berat", 100))
        'col.Add(GH.AddModelGridColumn("Satuan", 100))
        'col.Add(GH.AddModelGridColumn("Keterangan", 250))
        'GH.FormatGrid(uc.gridItem, dtDetail, col, False, True, True, False)
        'InProcFactory.CloseChannel(Me.cssdServ)
        'uc.NoOrderParam = NoOrder
        'uc.btnLookUnit.Enabled = False
        'uc.gridItem.ReadOnly = True
        'uc.btnSimpan.Visible = True
        'uc.gbInformasiOrder.Enabled = False
        'uc.dtpTglDatang.Visible = True
        'uc.EditTglDatang = True
        'UILibs.PageLink.goToPage(Me.Parent, uc, Me)


        If dgvDaftar.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang akan di hapus !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim retVal As String = Me.cssdServ.DeleteOrderAll(dgvDaftar.SelectedRows(0).DataBoundItem(0), SessionInfo.un)
        InProcFactory.CloseChannel(Me.cssdServ)

        If InStr(retVal, "ERROR") Then
            MsgBox(retVal, MsgBoxStyle.Exclamation, "Pesan")
        Else
            MsgBox("Order Berhasil dihapus", MsgBoxStyle.Information, "Pesan")
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'If dgvDaftar.SelectedRows.Count = 0 Then
        '    MsgBox("Pilih data yang akan di lihat.", MsgBoxStyle.Exclamation, "Peringatan")
        '    Exit Sub
        'End If

        'Dim NoOrder As String = String.Empty
        'NoOrder = dgvDaftar.SelectedRows(0).DataBoundItem(0)

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim masterOrder As New model.CSSD_MasterOrder
        'Dim dtDetail As New DataTable
        'masterOrder = Me.cssdServ.ViewMasterOrder(NoOrder)

        'Dim uc As New ucPenerimaanSterilisasiAdd
        'uc.txtNoOrder.Text = NoOrder
        'uc.txtNoOrder.ReadOnly = True
        'uc.txtPetugasOrder.Text = masterOrder.PetugasOrder
        'uc.txtPetugasOrder.ReadOnly = True
        'uc.txtNamaUnit.Text = masterOrder.Poly.polyName
        'uc.txtNamaUnit.ReadOnly = True
        'uc.txtTelp.Text = masterOrder.Telp
        'uc.txtTelp.ReadOnly = True
        'If masterOrder.TglDatang <> String.Empty Then
        '    uc.dtpTglDatang.Value = masterOrder.TglDatang
        'Else
        '    uc.pnTglDatang.Visible = False
        'End If

        'dtDetail = Me.cssdServ.ViewDetailOrder(NoOrder)
        'uc.gridItem.DataSource = dtDetail
        'Dim col As New List(Of GridColumnModel)
        'col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        'col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        'col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        'col.Add(GH.AddModelGridColumn("Jumlah", 100))
        'col.Add(GH.AddModelGridColumn("Berat", 100))
        'col.Add(GH.AddModelGridColumn("Satuan", 100))
        'col.Add(GH.AddModelGridColumn("Keterangan", 250))
        'GH.FormatGrid(uc.gridItem, dtDetail, col, False, True, True, False)
        'InProcFactory.CloseChannel(Me.cssdServ)
        'uc.NoOrderParam = NoOrder
        'uc.btnLookUnit.Enabled = False
        'uc.gridItem.ReadOnly = True
        'uc.btnSimpan.Visible = False
        ''uc.dtpTglDatang.Visible = False
        'UILibs.PageLink.goToPage(Me.Parent, uc, Me)


        If dgvDaftar.SelectedRows.Count = 0 Then
            MsgBox("Pilih data terlebih dahulu !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim NoOrder As String = String.Empty
        NoOrder = dgvDaftar.SelectedRows(0).DataBoundItem(0)

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim masterOrder As New model.CSSD_MasterOrder
        masterOrder = Me.cssdServ.ViewMasterOrder(NoOrder)
        InProcFactory.CloseChannel(Me.cssdServ)

        Dim uc As New ucPenerimaanSterilisasiAdd
        uc.txtNoOrder.Tag = masterOrder.IdOrder
        uc.txtNoOrder.Text = NoOrder
        uc.txtNoOrder.ReadOnly = True
        uc.txtPetugasOrder.Text = masterOrder.PetugasOrder
        uc.txtNamaUnit.Text = masterOrder.Poly.polyName
        uc.txtNamaUnit.Tag = masterOrder.Poly.polyCode
        uc.txtNamaUnit.ReadOnly = True
        uc.txtTelp.Text = masterOrder.Telp
        uc.txtTelp.ReadOnly = True
        uc.LblTgl.Text = masterOrder.TglDatang
        uc.NoOrderParam = NoOrder
        uc.cbBarang.Text = masterOrder.jenisBarang
        uc.cbTypeOrder.Text = masterOrder.type_order
        uc.txtPetugasSterilisasi.Text = masterOrder.PetugasSterilisasi
        uc.txtPetugasSterilisasi.ReadOnly = True
        uc.Edit = True

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub
End Class


