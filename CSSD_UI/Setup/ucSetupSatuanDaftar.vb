Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports System.Windows.Forms

Public Class ucSetupSatuanDaftar
    Private cssdSrv As ICSSDSetupService

    Dim fidArray(,) As Object = {
                                {"KodeSatuan", "kode", 100},
                                 {"NamaSatuan", "nama", 200}
                                }

    Dim dvTemp As New DataView
    Dim dtSatuan As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browseSatuan.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler browseSatuan.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler browseSatuan.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler browseSatuan.getTextBox.TextChanged, AddressOf txtFind_Change

        browseSatuan.getTitle.Text = "Daftar Master Satuan"

    End Sub

    Private Sub ucSetupSatuanDaftar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            browseSatuan.getBtnNew.Enabled = acl.allowSave
            browseSatuan.getBtnEdit.Enabled = acl.allowEdit
            browseSatuan.getBtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Me.dtSatuan = Me.cssdSrv.GetAllSetupSatuan()

        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dtSatuan

        browseSatuan.getGridView().DataSource = dvTemp
        UILibs.GridStyle.C1formatGrid(browseSatuan.getGridView(), dvTemp.Table, fidArray)

        InProcFactory.CloseChannel(Me.cssdSrv)
    End Sub

    Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucSetupSatuanAdd(), Me)
    End Sub

    Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim KodeSatuan As String = String.Empty
        Dim uc As New ucSetupSatuanAdd

        KodeSatuan = browseSatuan.getGridView().Columns("KodeSatuan").Value
        uc.KodeSatuan = KodeSatuan

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterSatuan
        data.KodeSatuan = KodeSatuan
        data = Me.cssdSrv.ViewSetupSatuan(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        uc.txtKodeSatuan.Text = data.KodeSatuan
        uc.txtNamaSatuan.Text = data.NamaSatuan

        uc.txtKodeSatuan.ReadOnly = True

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return


        Dim KodeSatuan As String = browseSatuan.getGridView().Item(browseSatuan.getGridView().Row, "KodeSatuan")


        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterSatuan
        data.KodeSatuan = KodeSatuan
        Me.cssdSrv.DeleteSetupSatuan(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        MsgBox(String.Format("Kode Satuan {0} berhasil dihapus", KodeSatuan), MsgBoxStyle.Information)

        'reload form
        ucSetupSatuanDaftar_Load(sender, e)
    End Sub

    Sub txtFind_Change(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = CType(sender, TextBox).Text
        dvTemp.RowFilter = String.Format("KodeSatuan LIKE '%{0}%'" &
                                         " OR NamaSatuan LIKE '%{0}%'" _
                                         , str)
    End Sub
End Class
