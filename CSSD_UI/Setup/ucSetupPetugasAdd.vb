Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports GenCode128
Imports System.IO
Imports System.Drawing

Public Class ucSetupPetugasAdd
    Private cssdServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public KodePetugas As String = String.Empty

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

            If Me.KodePetugas = String.Empty Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data Petugas berhasil disimpan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data Petugas berhasil diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else

                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucSetupPetugasDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim retVal As String = String.Empty


            Dim data As New model.CSSD_Petugas

            data.KodePetugas = txtKodePetugas.Text
            data.NamaPetugas = txtNamaPetugas.Text
            data.Nip = txtNIP.Text
            data.UserInput = SessionInfo.uid
            data.UserUpdate = SessionInfo.uid

            If isNew Then

                retVal = Me.cssdServ.SaveSetupPetugas(data)

            Else
                retVal = Me.cssdServ.UpdateSetupPetugas(data)
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
        UILibs.PageLink.goToPage(Me.Parent, New ucSetupPetugasDaftar(), Me)
    End Sub


    Private Sub btnCetakBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakBarcode.Click
        Dim frmCetak As New frmCetakLabelPetugas
        Dim dt As New DataTable

        dt.Columns.Add("KodePetugas", GetType(String))
        dt.Columns.Add("NamaPetugas", GetType(String))
        dt.Columns.Add("Barcode", GetType(Byte()))

        Dim img As Image = Code128Rendering.MakeBarcodeImage(txtKodePetugas.Text, 1, False)
        Dim ms As New MemoryStream
        img.Save(ms, Imaging.ImageFormat.Bmp)
        Dim byt() As Byte = ms.ToArray

        dt.Rows.Add(New Object() {txtKodePetugas.Text, txtNamaPetugas.Text, byt})
        frmCetak.dt = dt
        frmCetak.ShowDialog()
    End Sub
End Class
