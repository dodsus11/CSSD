Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports System.Windows.Forms


Public Class ucGudangDaftar
    Private cssdSrv As ICSSDSetupService

    Dim fidArray(,) As Object = {
                                 {"KodeGudang", "Kode Ruang", 100},
                                 {"NamaGudang", "Nama Ruang", 400},
                                 {"Telp", "Telp", 100}
                                }

    Dim dvTemp As New DataView
    Dim dtGudang As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browseMasterGudang.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler browseMasterGudang.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler browseMasterGudang.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler browseMasterGudang.getTextBox.TextChanged, AddressOf txtFind_Change

        browseMasterGudang.getTitle.Text = "Daftar Ruang dan Telp"

    End Sub

    Private Sub ucGudangDaftar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            browseMasterGudang.getBtnNew.Enabled = acl.allowSave
            browseMasterGudang.getBtnEdit.Enabled = acl.allowEdit
            browseMasterGudang.getBtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Me.dtGudang = Me.cssdSrv.GetAllSetupMasterGudang()

        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dtGudang

        browseMasterGudang.getGridView().DataSource = dvTemp
        UILibs.GridStyle.C1formatGrid(browseMasterGudang.getGridView(), dvTemp.Table, fidArray)

        InProcFactory.CloseChannel(Me.cssdSrv)
    End Sub

    Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucGudangAdd(), Me)
    End Sub

    Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim KodeGudang As String = String.Empty
        Dim uc As New ucGudangAdd

        KodeGudang = browseMasterGudang.getGridView().Columns("KodeGudang").Value
        uc.KodeGudang = KodeGudang

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterGudang
        data.KodeGudang = KodeGudang
        data = Me.cssdSrv.ViewSetupMasterGudang(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        uc.txtKodeGudang.Text = data.KodeGudang
        uc.txtKodeGudang.ReadOnly = True
        uc.txtNamaGudang.Text = data.NamaGudang
        uc.TxtTelp.Text = data.Telp

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return


        Dim KodeGudang As String = browseMasterGudang.getGridView().Item(browseMasterGudang.getGridView().Row, "KodeGudang")


        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterGudang
        data.KodeGudang = KodeGudang
        Me.cssdSrv.DeleteSetupMasterGudang(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        MsgBox(String.Format("Kode Ruang {0} berhasil dihapus", KodeGudang), MsgBoxStyle.Information)

        'reload form
        ucGudangDaftar_Load(sender, e)
    End Sub

    Sub txtFind_Change(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = CType(sender, TextBox).Text
        dvTemp.RowFilter = String.Format("KodeGudang LIKE '%{0}%'" & " OR NamaGudang LIKE '%{0}%'", str)
    End Sub
End Class
