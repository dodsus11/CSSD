Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports RockUtil
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucInventoryDaftar

    Private cssdSetupSrv As ICSSDSetupService
    Dim dvTemp As New DataView
    Dim dt As DataTable

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        UILibs.PageLink.goToPage(Me.Parent, New ucInventoryAdd, Me)
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        LoadData()
    End Sub

    Private Sub LoadJenisAlat()
        Me.cssdSetupSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dtjenisAlat As DataTable
        dtjenisAlat = Me.cssdSetupSrv.GetJenisAlat()
        cmbJenisAlat.DataSource = dtjenisAlat
        cmbJenisAlat.ValueMember = "IdJenisAlat"
        cmbJenisAlat.DisplayMember = "NamaJenis"
    End Sub

    Private Sub LoadData()
        dgvInventory.DataSource = Nothing
        dgvInventory.Columns.Clear()

        Me.cssdSetupSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Me.dt = Me.cssdSetupSrv.GetInventoryByJenis(cmbJenisAlat.SelectedValue)
        InProcFactory.CloseChannel(Me.cssdSetupSrv)

        dvTemp.Table = Me.dt
        Me.dgvInventory.DataSource = dvTemp

        'format grid
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Inventory", 150))
        col.Add(GH.AddModelGridColumn("Kode Alat", 200))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Berat", 100))
        col.Add(GH.AddModelGridColumn("Kode Satuan", 0))
        col.Add(GH.AddModelGridColumn("Nama Satuan", 100))
        If cmbJenisAlat.SelectedValue = 2 Then
            col.Add(GH.AddModelGridColumn("Standar Reuse", 110))
        Else
            col.Add(GH.AddModelGridColumn("Standar Reuse", 0))
        End If
        col.Add(GH.AddModelGridColumn("Non Active", 100))

        GH.FormatGrid(dgvInventory, dt, col, True, True, False, True)

        With dgvInventory
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        End With
    End Sub

    Private Sub ucInventoryDaftar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            btnNew.Enabled = acl.allowSave
            BtnDelete.Enabled = acl.allowDelete
        End If

        LoadJenisAlat()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dvTemp.RowFilter = String.Format("NoInventory LIKE '%{0}%'" &
                                          "OR KodeAlat LIKE '%{0}%'" &
                                          " OR NamaAlat LIKE '%{0}%'" _
                                         , str)
    End Sub

    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang akan di Non Active kan !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Anda yakin data akan di Non Active kan ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim NoInventory As String = String.Empty
        Dim retval As String = String.Empty

        NoInventory = dgvInventory.SelectedRows(0).DataBoundItem(0)

        Me.cssdSetupSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        retval = cssdSetupSrv.DeleteInventory(NoInventory)
        InProcFactory.CloseChannel(Me.cssdSetupSrv)

        If InStr(retval, "ERROR") Then
            MessageBox.Show(retval, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("No. Inventory : " & NoInventory & " berhasil di Non Active kan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LoadData()
    End Sub

End Class
