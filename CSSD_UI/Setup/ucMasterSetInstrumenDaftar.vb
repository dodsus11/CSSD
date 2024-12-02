Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports RockUtil
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports CSSD_SERVICE.CSSDSettings

Public Class ucMasterSetInstrumenDaftar

    Private cssdSrv As ICSSDSetupService
    Dim dvTemp As New DataView
    Dim dt As DataTable

    Private Sub ucMasterSetInstrumenDaftar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            btnNew.Enabled = acl.allowSave
            btnEdit.Enabled = acl.allowEdit
            BtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Me.dt = Me.cssdSrv.GetAllMasterSetInstrumen()
        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dt
        Me.dgvMasterSetInstrumen.DataSource = dvTemp

        'format grid
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id Set Instrumen", 0))
        col.Add(GH.AddModelGridColumn("Kode Set Instrumen", 200))
        col.Add(GH.AddModelGridColumn("Nama Set Instrumen", 250))
        col.Add(GH.AddModelGridColumn("Berat", 80))
        col.Add(GH.AddModelGridColumn("Satuan", 80))
        col.Add(GH.AddModelGridColumn("Standar Kasa", 150))
        col.Add(GH.AddModelGridColumn("Tgl. Expired", 100))
        col.Add(GH.AddModelGridColumn("Tgl. Revisi", 100))
        col.Add(GH.AddModelGridColumn("Revisi ke", 100))
        col.Add(GH.AddModelGridColumn("Keterangan", 200))
        GH.FormatGrid(dgvMasterSetInstrumen, dt, col, True, True, False, True)

        With dgvMasterSetInstrumen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        End With

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        UILibs.PageLink.goToPage(Me.Parent, New ucMasterSetInstrumenAdd(), Me)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dvTemp.RowFilter = String.Format("KodeSetInstrumen LIKE '%{0}%'" &
                                          " OR NamaSetInstrumen LIKE '%{0}%'" _
                                         , str)
    End Sub

    Private Sub btnShowDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDetail.Click

        If dgvMasterSetInstrumen.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang akan di lihat.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim KodeSetInstrumen As String = String.Empty
        Dim IdSetInstrumen As Integer = 0
        'IdSetInstrumen = dgvMasterSetInstrumen.SelectedRows(0).DataBoundItem(0)
        KodeSetInstrumen = dgvMasterSetInstrumen.SelectedRows(0).DataBoundItem(1)

        Dim frmDetail As New frmViewMasterDetailInstrumen

        Dim dtDetail As New DataTable
        Dim detail As New model.CSSD_DetailSetInstrumen
        Dim master As New model.CSSD_MasterSetInstrumen
        detail.KodeSetInstrumen = KodeSetInstrumen
        master.KodeSetInstrumen = KodeSetInstrumen

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        dtDetail = Me.cssdSrv.ViewDetailMasterSetInstrumen(detail)
        master = Me.cssdSrv.ViewMasterSetInstrumen(master)
        InProcFactory.CloseChannel(Me.cssdSrv)

        frmDetail.dt = dtDetail
        frmDetail.txtKodeSetInstrumen.Text = master.KodeSetInstrumen
        frmDetail.txtNamaSetInstrumen.Text = master.NamaSetInstrumen
        frmDetail.txtKeterangan.Text = master.Keterangan
        frmDetail.txtTglExpired.Text = master.ExpiredDate
        frmDetail.txtBerat.Text = master.Berat
        frmDetail.txtSatuan.Text = master.Satuan.NamaSatuan
        frmDetail.txtStandarKasa.Text = IIf(master.StandarKasa = 0, "", master.StandarKasa)
        Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
        frmDetail.pbPhoto.ImageLocation = SettingPath.SET_INSTRUMEN_IMAGE_PATH & master.PathFoto
        'Util.CloseNetLogin("172.16.1.69\d$\CSSD\SetInstrumen")
        frmDetail.ShowDialog()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If dgvMasterSetInstrumen.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang akan di edit.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim KodeSetInstrumen As String = String.Empty
        KodeSetInstrumen = dgvMasterSetInstrumen.SelectedRows(0).DataBoundItem(1)

        Dim uc As New ucMasterSetInstrumenAdd
        uc.KodeSetInstrumen = KodeSetInstrumen

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If dgvMasterSetInstrumen.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang akan di hapus.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Anda yakin data akan di hapus ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim KodeSetInstrumen As String = String.Empty
        Dim retval As String = String.Empty
        Dim data As New model.CSSD_MasterSetInstrumen
        KodeSetInstrumen = dgvMasterSetInstrumen.SelectedRows(0).DataBoundItem(1)
        data.KodeSetInstrumen = KodeSetInstrumen

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        retval = cssdSrv.DeleteMasterSetInstrumen(data)
        InProcFactory.CloseChannel(Me.cssdSrv)

        If InStr(retval, "ERROR") Then
            MessageBox.Show(retval, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Set Instrumen : " & KodeSetInstrumen & " berhasil di hapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ucMasterSetInstrumenDaftar_Load(sender, e)
    End Sub


    Private Sub btnCetak_Click(sender As System.Object, e As System.EventArgs) Handles btnCetak.Click

        Dim frm As New FrmPreview

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        Dim data As New model.CSSD_TracingOrderDetail

        Dim KodeSetInstrumen As String = String.Empty
        KodeSetInstrumen = dgvMasterSetInstrumen.SelectedRows(0).DataBoundItem(1)

        Dim dtDetail As New DataTable
        Dim detail As New model.CSSD_DetailSetInstrumen
        Dim master As New model.CSSD_MasterSetInstrumen
        detail.KodeSetInstrumen = KodeSetInstrumen
        master.KodeSetInstrumen = KodeSetInstrumen

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        dtDetail = Me.cssdSrv.ViewDetailMasterSetInstrumen(detail)
        master = Me.cssdSrv.ViewMasterSetInstrumen(master)
        InProcFactory.CloseChannel(Me.cssdSrv)

        InProcFactory.CloseChannel(Me.cssdSrv)

        Dim rpt As New crReportSetInstrumen

        rpt.SetDataSource(dtDetail)
       
        rpt.SetParameterValue("KodeSet", master.KodeSetInstrumen)
        rpt.SetParameterValue("NamaSet", master.NamaSetInstrumen)
        rpt.SetParameterValue("Berat", master.Berat)
        rpt.SetParameterValue("Satuan", master.Satuan.NamaSatuan)
        rpt.SetParameterValue("StandarKasa", master.StandarKasa)
        rpt.SetParameterValue("Keterangan", master.Keterangan)
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt
        frm.ShowDialog()

    End Sub
End Class
