Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports RockUtil
Imports System.IO
Imports CSSD_SERVICE.CSSDSettings

Public Class ucSetupMasterInstrumenAdd

    Private cssdServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public IdInstrumen As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UILibs.MyResources.setButtonIcon(btnLookLokasiFoto, "Open v2.png")

        btnFooter.getBtnSaveAndNew().Visible = False

        AddHandler btnFooter.getBtnSaveAndClose().Click, AddressOf btnSaveClose_Click
        AddHandler btnFooter.getBtnClear().Click, AddressOf btnClear_Click
        AddHandler btnFooter.getBtnCancel().Click, AddressOf btnCancel_Click

    End Sub

    Sub btnSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim retVal As String
        Dim pesan As String = String.Empty

        Try
            Me.Cursor = Cursors.AppStarting

            If Me.IdInstrumen = String.Empty Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data master instrumen berhasil disimpan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data master instrumen diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else

                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucSetupMasterInstrumenDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim retVal As String = String.Empty

            Dim data As New model.CSSD_MasterInstrumen
            data.IdInstrumen = txtIdInstrumen.Text
            data.KodeInstrumen = txtKodeInstrumen.Text
            data.NamaInstrumen = txtNamaInstrumen.Text
            data.Berat = Convert.ToDouble(IIf(String.IsNullOrEmpty(txtBerat.Text), "0", txtBerat.Text))
            data.Satuan.KodeSatuan = txtSatuan.Tag
            data.PathFoto = txtPathFoto.Text
            data.UserInput = SessionInfo.uid
            data.UserUpdate = SessionInfo.uid

            If isNew Then
                retVal = Me.cssdServ.SaveSetupMasterInstrumen(data)
            Else
                retVal = Me.cssdServ.UpdateSetupMasterInstrumen(data)
            End If

            InProcFactory.CloseChannel(Me.cssdServ)

            If Not InStr(retVal, "ERROR") Then
                If txtPathFoto.Text <> String.Empty Then
                    Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                    File.Copy(txtPathFoto.Text, SettingPath.INSTRUMEN_IMAGE_PATH & retVal, True)
                End If
            End If

            Return(retVal)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw ex
        End Try
    End Function

    Private Sub btnLookLokasiFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookLokasiFoto.Click
        Try

            ofd.Multiselect = False
            ofd.Filter = "image file (*.jpg)|*.jpg"
            Dim result As Integer = ofd.ShowDialog()

            If result = DialogResult.OK Then
                Dim fileName As String = String.Empty
                fileName = ofd.FileName.ToString()

                txtPathFoto.Text = fileName
                pbPhoto.ImageLocation = fileName
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        UtilsLibs.MainMod.resetText(Me)
    End Sub

    Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucSetupMasterInstrumenDaftar(), Me)

    End Sub

    Private Sub btnLookSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookSatuan.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeSatuan", "Kode", 0},
                                {"NamaSatuan", "Nama", 100}}

        frmLookUp.keyField = "KodeSatuan"
        frmLookUp.fields = {"KodeSatuan", "NamaSatuan"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetAllSetupSatuan
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSatuan.Text = frmLookUp.returnRow("NamaSatuan").ToString()
            txtSatuan.Tag = frmLookUp.returnRow("KodeSatuan").ToString()

        End If
    End Sub

End Class
