Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms

Public Class ucInventoryAdd
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        btnFooter.getBtnSaveAndNew().Visible = False

        AddHandler btnFooter.getBtnSaveAndClose().Click, AddressOf btnSaveClose_Click
        AddHandler btnFooter.getBtnClear().Click, AddressOf btnClear_Click
        AddHandler btnFooter.getBtnCancel().Click, AddressOf btnCancel_Click

    End Sub

    Sub btnSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        If txtJenis.Tag = "2" Then
            If txtMax.Text = 0 Then
                MsgBox("Maaf Max Re-Use harus lebih dari nol !", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If
        End If

        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim retVal As String
        Dim pesan As String = String.Empty

        Try
            Me.Cursor = Cursors.AppStarting

            'insert new data
            retVal = saveOrUpdate(True)
            pesan = "Data Inventory berhasil disimpan"


            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnClear_Click(sender, e)
                txtJenis.Tag = ""
                Return
            Else
                txtNoInventory.Text = retVal
                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucInventoryDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try

            Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
            Dim retVal As String = String.Empty

            Dim data As New model.CSSD_Inventory

            data.KodeAlat = txtKodeAlat.Text
            data.IdJenisAlat = txtJenis.Tag
            If txtJenis.Tag = "2" Then
                data.standar_reuse = txtMax.Text
            Else
                data.standar_reuse = 0
            End If

            retVal = Me.cssdSetupServ.SaveInventory(data)

            InProcFactory.CloseChannel(Me.cssdSetupServ)

            Return retVal

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        UtilsLibs.MainMod.resetText(Me)
        txtJenis.Tag = ""
    End Sub

    Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucInventoryDaftar(), Me)
    End Sub

    Private Sub btnLookJenis_Click(sender As System.Object, e As System.EventArgs) Handles btnLookJenis.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"IdJenisAlat", "id", 0},
                              {"NamaJenis", "Jenis", 300},
                              {"set_instrumen", "Set instrumen", 100}}

        frmLookUp.keyField = "IdJenisAlat"
        frmLookUp.fields = {"NamaJenis", "set_instrumen"}

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdSetupServ.GetJenisAlat()
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdSetupServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtJenis.Text = frmLookUp.returnRow("NamaJenis").ToString()
            txtJenis.Tag = frmLookUp.returnRow("IdJenisAlat").ToString()

            If txtJenis.Tag = "2" Then
                LblMax.Visible = True
                txtMax.Visible = True
                txtMax.Text = 0
            Else
                LblMax.Visible = False
                txtMax.Visible = False
            End If

        End If
    End Sub

    Private Sub btnLookAlat_Click(sender As System.Object, e As System.EventArgs) Handles btnLookAlat.Click

        'If txtJenis.Tag = 1 Then 'tromol
        'Me.LookupTromol()
        'End If

        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeInstrumen", "Kode", 100},
                              {"NamaInstrumen", "Nama", 300}}

        frmLookUp.keyField = "KodeInstrumen"
        frmLookUp.fields = {"KodeInstrumen", "NamaInstrumen"}

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdSetupServ.GetInstrumenByJenis(txtJenis.Tag)
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdSetupServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtKodeAlat.Text = frmLookUp.returnRow("KodeInstrumen").ToString()
            txtNamaAlat.Text = frmLookUp.returnRow("NamaInstrumen").ToString()

        End If

    End Sub

    'Private Sub LookupTromol()
    '    Dim frmLookUp As New UILibs.DlgLookUp()

    '    frmLookUp.fidArray = {{"IdSetInstrumen", "Id", 0},
    '                            {"KodeSetInstrumen", "Kode", 100},
    '                            {"NamaSetInstrumen", "Nama", 250},
    '                            {"Berat", "Berat", 0},
    '                          {"NamaSatuan", "Satuan", 0},
    '                          {"StandarKasa", "StandarKasa", 0}}

    '    frmLookUp.keyField = "KodeSetInstrumen"
    '    frmLookUp.fields = {"KodeSetInstrumen", "NamaSetInstrumen"}

    '    Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

    '    Dim dt As New DataTable
    '    dt = Me.cssdSetupServ.GetAllMasterSetInstrumen()
    '    frmLookUp.dt = dt

    '    InProcFactory.CloseChannel(Me.cssdSetupServ)

    '    If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

    '        txtKodeAlat.Text = frmLookUp.returnRow("KodeSetInstrumen").ToString()
    '        txtNamaAlat.Text = frmLookUp.returnRow("NamaSetInstrumen").ToString()

    '    End If
    'End Sub

End Class
