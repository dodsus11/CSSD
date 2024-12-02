Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms

Public Class ucMappingUserGudang
    Private cssdServ As ICSSDSetupService
    Private cssdorderServ As ICSSDOrderService
    Private acl As SessionInfo.ACLUser

   

    Private Sub btnLookUpGudang_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpGudang.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeGudang", "Kode Gudang", 100},
                                {"NamaGudang", "Nama Gudang", 200}}

        frmLookUp.keyField = "KodeGudang"
        frmLookUp.fields = {"KodeGudang", "NamaGudang"}

        Me.cssdorderServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable
        'dt = Me.cssdServ.GetAllSetupMasterGudang
        dt = Me.cssdorderServ.GetAllMasterGudang
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdorderServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtGudangTujuanDaftar.Text = frmLookUp.returnRow("NamaGudang").ToString()
            txtGudangTujuanDaftar.Tag = frmLookUp.returnRow("KodeGudang").ToString()

        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim retVal As String = String.Empty

        Dim data As New model.CSSD_MappingUserGudang

        data.IdUser = txtUserHMIS.Tag
        data.KodeGudang = txtGudangTujuanDaftar.Tag
        data.UserEntry = SessionInfo.uid

        retVal = Me.cssdServ.SaveMappingUserGudang(data)

        If InStr(retVal, "ERROR") Then
            MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else

            MessageBox.Show("Data Berhasil di simpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        UtilsLibs.MainMod.resetText(Me)

        InProcFactory.CloseChannel(Me.cssdServ)
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        UtilsLibs.MainMod.resetText(Me)
    End Sub

    
    Private Sub btnLookUpUserHMIS_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpUserHMIS.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"id", "id", 100},
                                {"username", "User Name", 200},
                              {"fullname", "Full Name", 300}}

        frmLookUp.keyField = "id"
        frmLookUp.fields = {"username", "fullname"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetUserHMIS
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtUserHMIS.Text = frmLookUp.returnRow("username").ToString()
            txtUserHMIS.Tag = frmLookUp.returnRow("id").ToString()
            txtNamaUserHMIS.Text = frmLookUp.returnRow("fullname").ToString()

        End If

        If txtUserHMIS.Tag <> String.Empty Then
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

            Dim data As New model.CSSD_MappingUserGudang
            data = cssdServ.ViewUserTerdaftarGudang(txtUserHMIS.Tag)
            txtGudangTerdaftar.Text = data.NamaGudang
            InProcFactory.CloseChannel(Me.cssdServ)
        End If
    End Sub
End Class
