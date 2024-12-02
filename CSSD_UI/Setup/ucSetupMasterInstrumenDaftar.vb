Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports RockUtil
Imports System.Windows.Forms
Imports CSSD_SERVICE.CSSDSettings

Public Class ucSetupMasterInstrumenDaftar
    Private cssdSrv As ICSSDSetupService

    Dim fidArray(,) As Object = {
                                {"IdInstrumen", "id", 100},
                                {"KodeInstrumen", "kode", 100},
                                {"NamaInstrumen", "nama", 200},
                                {"Berat", "berat", 70},
                                {"NamaSatuan", "satuan", 90},
                                {"PathFoto", "path foto", 0}
                                }

    Dim dvTemp As New DataView
    Dim dtMasterInstrumen As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browseMasterInstrumen.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler browseMasterInstrumen.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler browseMasterInstrumen.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler browseMasterInstrumen.getTextBox.TextChanged, AddressOf txtFind_Change

        browseMasterInstrumen.getTitle.Text = "Daftar Master Instrumen"

    End Sub

    Private Sub ucSetupMasterInstrumenDaftar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            browseMasterInstrumen.getBtnNew.Enabled = acl.allowSave
            browseMasterInstrumen.getBtnEdit.Enabled = acl.allowEdit
            browseMasterInstrumen.getBtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Me.dtMasterInstrumen = Me.cssdSrv.GetAllSetupMasterInstrumen

        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dtMasterInstrumen

        browseMasterInstrumen.getGridView().DataSource = dvTemp
        UILibs.GridStyle.C1formatGrid(browseMasterInstrumen.getGridView(), dvTemp.Table, fidArray)

        InProcFactory.CloseChannel(Me.cssdSrv)
    End Sub

    Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucSetupMasterInstrumenAdd(), Me)
    End Sub

    Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim IdInstrumen As String = String.Empty
        Dim uc As New ucSetupMasterInstrumenAdd

        IdInstrumen = browseMasterInstrumen.getGridView().Columns("IdInstrumen").Value
        uc.IdInstrumen = IdInstrumen

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterInstrumen
        data.IdInstrumen = IdInstrumen
        data = Me.cssdSrv.ViewSetupMasterInstrumen(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        uc.txtIdInstrumen.Text = data.IdInstrumen
        uc.txtKodeInstrumen.Text = data.KodeInstrumen
        uc.txtNamaInstrumen.Text = data.NamaInstrumen
        uc.txtBerat.Text = IIf(data.Berat = 0, "", data.Berat)
        uc.txtSatuan.Tag = data.Satuan.KodeSatuan
        uc.txtSatuan.Text = data.Satuan.NamaSatuan
        Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
        uc.pbPhoto.ImageLocation = SettingPath.INSTRUMEN_IMAGE_PATH & data.PathFoto
        'Util.CloseNetLogin("172.16.1.69\d$\CSSD\Instrumen")

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim IdInstrumen As String = browseMasterInstrumen.getGridView().Item(browseMasterInstrumen.getGridView().Row, "IdInstrumen")

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterInstrumen
        data.IdInstrumen = IdInstrumen
        Me.cssdSrv.DeleteSetupMasterInstrumen(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        MsgBox(String.Format("Id Instrumen {0} berhasil dihapus", IdInstrumen), MsgBoxStyle.Information)

        'reload form
        ucSetupMasterInstrumenDaftar_Load(sender, e)
    End Sub

    Sub txtFind_Change(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = CType(sender, TextBox).Text
        dvTemp.RowFilter = String.Format("KodeInstrumen LIKE '%{0}%'" &
                                         " OR NamaInstrumen LIKE '%{0}%'" _
                                         , str)
    End Sub

End Class
