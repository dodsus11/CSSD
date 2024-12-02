Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms

Public Class ucSetupSatuanAdd

    Private cssdServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public KodeSatuan As String = String.Empty

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

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

            If Me.KodeSatuan = String.Empty Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data satuan berhasil disimpan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data satuan berhasil diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else
                
                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucSetupSatuanDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim retVal As String = String.Empty


            Dim data As New model.CSSD_MasterSatuan

            data.KodeSatuan = txtKodeSatuan.Text
            data.NamaSatuan = txtNamaSatuan.Text

            If isNew Then

                retVal = Me.cssdServ.SaveSetupSatuan(data)

            Else
                retVal = Me.cssdServ.UpdateSetupSatuan(data)
            End If

            InProcFactory.CloseChannel(Me.cssdServ)

            Return retVal

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        UtilsLibs.MainMod.resetText(Me)
    End Sub

    Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucSetupSatuanDaftar(), Me)
    End Sub

End Class
