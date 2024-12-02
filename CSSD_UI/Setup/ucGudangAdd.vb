Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms

Public Class ucGudangAdd

    Private cssdServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public KodeGudang As String

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

            If Me.KodeGudang = String.Empty Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data Ruang berhasil disimpan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data Ruang berhasil diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else

                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucGudangDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim retVal As String = String.Empty

            Dim data As New model.CSSD_MasterGudang
            data.KodeGudang = txtKodeGudang.Text
            data.NamaGudang = txtNamaGudang.Text
            data.Telp = TxtTelp.Text

            If isNew Then

                retVal = Me.cssdServ.SaveSetupMasterGudang(data)

            Else
                retVal = Me.cssdServ.UpdateSetupMasterGudang(data)
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
        UILibs.PageLink.goToPage(Me.Parent, New ucGudangDaftar(), Me)
    End Sub

    Private Sub btnLookRuang_Click(sender As System.Object, e As System.EventArgs) Handles btnLookRuang.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"poly_code", "Kode Ruang", 80},
                              {"poly_name", "Nama Ruang", 250},
                              {"building_name", "Unit", 200}}

        frmLookUp.keyField = "poly_code"
        frmLookUp.fields = {"poly_code", "poly_name", "building_name"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetPoly
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtKodeGudang.Text = frmLookUp.returnRow("poly_code").ToString()
            txtNamaGudang.Text = frmLookUp.returnRow("poly_name").ToString()
        End If
    End Sub

End Class
