Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports GenCode128

Public Class ucMesinAdd
    Private cssdServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public KodeMesin As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        UILibs.MyResources.setButtonIcon(btnLookKelompok, "Open v2.png")
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

            If Me.KodeMesin = "" Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data Mesin Steril berhasil disimpan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data Mesin Steril berhasil diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else

                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucMesinDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim retVal As String = String.Empty

            Dim data As New model.CSSD_Mesin

            data.KodeMesin = txtKodeMesin.Text
            data.NamaMesin = txtNamaMesin.Text
            data.Merk = txtMerekMesin.Text
            data.NamaVendor = txtNamaVendor.Text
            data.GroupMesin.IdGroupMesin = txtKodeKelompokMesin.Text
            data.GroupMesin.NamaGroupMesin = txtNamaKelompokMesin.Text
            data.UserInput = SessionInfo.uid
            data.UserUpdate = SessionInfo.uid
            If dtpTglPengadaan.Text = " " Then
                data.TglPengadaan = " "
            Else
                data.TglPengadaan = dtpTglPengadaan.Value.ToString("yyyy-MM-dd")
            End If

            If isNew Then
                retVal = Me.cssdServ.SaveSetupMesin(data)
            Else
                retVal = Me.cssdServ.UpdateSetupMesin(data)
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
        UILibs.PageLink.goToPage(Me.Parent, New ucMesinDaftar(), Me)
    End Sub

    Private Sub btnLookKelompok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookKelompok.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"IdGroupMesin", "Kode", 100},
                                {"NamaGroupMesin", "Nama", 300},
                              {"Tipe", "Tipe", 300}}

        frmLookUp.keyField = "IdGroupMesin"
        frmLookUp.fields = {"NamaGroupMesin", "Tipe"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetAllSetupGroupMesin
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtKodeKelompokMesin.Text = frmLookUp.returnRow("IdGroupMesin").ToString()
            txtNamaKelompokMesin.Text = frmLookUp.returnRow("NamaGroupMesin").ToString()
            txtTipe.Text = frmLookUp.returnRow("Tipe").ToString()

        End If
    End Sub

    Private Sub btnCetakBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakBarcode.Click

        Dim frmCetak As New FrmCetakLabelMesin

        Dim dt As New DataTable

        dt.Columns.Add("KodeMesin", GetType(String))
        dt.Columns.Add("NamaMesin", GetType(String))
        dt.Columns.Add("KelompokMesin", GetType(String))
        dt.Columns.Add("Tipe", GetType(String))
        dt.Columns.Add("Barcode", GetType(Byte()))

        Dim img As Image = Code128Rendering.MakeBarcodeImage(txtKodeMesin.Text, 1, False)
        Dim ms As New MemoryStream
        img.Save(ms, Imaging.ImageFormat.Bmp)
        Dim byt() As Byte = ms.ToArray

        dt.Rows.Add(New Object() {txtKodeMesin.Text,
                                  txtNamaMesin.Text,
                                  txtNamaKelompokMesin.Text,
                                  txtTipe.Text,
                                  byt})
        frmCetak.dt = dt

        frmCetak.ShowDialog()


    End Sub

    Private Sub dtpTglPengadaan_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpTglPengadaan.ValueChanged
        If dtpTglPengadaan.Checked = False Then
            dtpTglPengadaan.CustomFormat = " "
        Else
            dtpTglPengadaan.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub ucMesinAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        dtpTglPengadaan.ShowCheckBox = True
    End Sub

End Class
