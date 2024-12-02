Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports System.Windows.Forms


Public Class ucGroupMesinDaftar
    Private cssdSrv As ICSSDSetupService

    Dim fidArray(,) As Object = {
                                {"IdGroupMesin", "kode", 0},
                                 {"NamaGroupMesin", "nama", 200},
                                 {"Tipe", "Tipe Mesin", 100}
                                }

    Dim dvTemp As New DataView
    Dim dtGroupMesinSteril As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browseGroupMesinSteril.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler browseGroupMesinSteril.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler browseGroupMesinSteril.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler browseGroupMesinSteril.getTextBox.TextChanged, AddressOf txtFind_Change

        browseGroupMesinSteril.getTitle.Text = "Daftar Group Mesin Steril"

    End Sub

    Private Sub ucGroupMesinSterilDaftar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            browseGroupMesinSteril.getBtnNew.Enabled = acl.allowSave
            browseGroupMesinSteril.getBtnEdit.Enabled = acl.allowEdit
            browseGroupMesinSteril.getBtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Me.dtGroupMesinSteril = Me.cssdSrv.GetAllSetupGroupMesin()

        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dtGroupMesinSteril

        browseGroupMesinSteril.getGridView().DataSource = dvTemp
        UILibs.GridStyle.C1formatGrid(browseGroupMesinSteril.getGridView(), dvTemp.Table, fidArray)

        InProcFactory.CloseChannel(Me.cssdSrv)
    End Sub

    Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucGroupMesinAdd(), Me)
    End Sub

    Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim GroupID As Integer = 0
        Dim uc As New ucGroupMesinAdd

        GroupID = browseGroupMesinSteril.getGridView().Columns("IdGroupMesin").Value
        uc.GroupId = GroupID

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_GroupMesin
        data.IdGroupMesin = GroupID
        data = Me.cssdSrv.ViewSetupGroupMesin(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        uc.txtGroupMesin.Text = data.NamaGroupMesin
        uc.txtTipeMesin.Text = data.Tipe

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return


        Dim GroupID As String = browseGroupMesinSteril.getGridView().Item(browseGroupMesinSteril.getGridView().Row, "IdGroupMesin")


        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_GroupMesin
        data.IdGroupMesin = GroupID
        Me.cssdSrv.DeleteSetupGroupMesin(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        MsgBox(String.Format("Kode Group Mesin {0} berhasil dihapus", GroupID), MsgBoxStyle.Information)

        'reload form
        ucGroupMesinSterilDaftar_Load(sender, e)
    End Sub

    Sub txtFind_Change(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = CType(sender, TextBox).Text
        dvTemp.RowFilter = String.Format("NamaGroupMesin LIKE '%{0}%'", str)
    End Sub
End Class
