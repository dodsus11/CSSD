Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports System.Windows.Forms

Public Class ucSetupPetugasDaftar
    Private cssdSrv As ICSSDSetupService

    Dim fidArray(,) As Object = {
                                {"KodePetugas", "kode petugas", 200},
                                 {"NamaPetugas", "nama petugas", 200},
                                 {"NIP", "NIP", 100}
                                }

    Dim dvTemp As New DataView
    Dim dtSatuan As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browsePetugas.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler browsePetugas.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler browsePetugas.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler browsePetugas.getTextBox.TextChanged, AddressOf txtFind_Change

        browsePetugas.getTitle.Text = "Daftar Master Petugas"

    End Sub

    Private Sub ucSetupPetugasDaftar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            browsePetugas.getBtnNew.Enabled = acl.allowSave
            browsePetugas.getBtnEdit.Enabled = acl.allowEdit
            browsePetugas.getBtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Me.dtSatuan = Me.cssdSrv.GetAllSetupPetugas()

        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dtSatuan

        browsePetugas.getGridView().DataSource = dvTemp
        UILibs.GridStyle.C1formatGrid(browsePetugas.getGridView(), dvTemp.Table, fidArray)

        InProcFactory.CloseChannel(Me.cssdSrv)
    End Sub

    Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ucSetupPetugasAdd
        uc.btnCetakBarcode.Visible = False
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim KodePetugas As String = String.Empty
        Dim uc As New ucSetupPetugasAdd

        KodePetugas = browsePetugas.getGridView().Columns("KodePetugas").Value

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_Petugas
        data.KodePetugas = KodePetugas
        data = Me.cssdSrv.ViewSetupPetugas(data)

        InProcFactory.CloseChannel(Me.cssdSrv)
        uc.KodePetugas = data.KodePetugas
        uc.txtKodePetugas.Text = data.KodePetugas
        uc.txtNamaPetugas.Text = data.NamaPetugas
        uc.txtNIP.Text = data.NIP
        uc.txtKodePetugas.ReadOnly = True
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim KodePetugas As String = browsePetugas.getGridView().Item(browsePetugas.getGridView().Row, "KodePetugas")

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_Petugas
        data.KodePetugas = KodePetugas
        Me.cssdSrv.DeleteSetupPetugas(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        MsgBox(String.Format("Kode petugas {0} berhasil dihapus", KodePetugas), MsgBoxStyle.Information)

        'reload form
        ucSetupPetugasDaftar_Load(sender, e)
    End Sub

    Sub txtFind_Change(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = CType(sender, TextBox).Text
        dvTemp.RowFilter = String.Format("KodePetugas LIKE '%{0}%'" &
                                         " OR NamaPetugas LIKE '%{0}%' OR NIP LIKE '%{0}%'" _
                                         , str)
    End Sub

End Class
