Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports System.Windows.Forms


Public Class ucMesinDaftar
    Private cssdSrv As ICSSDSetupService

    Dim fidArray(,) As Object = {
                                {"KodeMesin", "Kode Mesin", 100},
                                {"NamaMesin", "Nama Mesin", 200},
                                {"Merk", "Merk Mesin", 100},
                                {"NamaVendor", "Vendor", 100},
                                {"TglPengadaan", "Tgl. Pengadaan", 100},
                                {"IdGroupMesin", "IdGroupMesin", 0},
                                {"NamaGroupMesin", "Group Name", 100},
                                {"Tipe", "Tipe Mesin", 100},
                                {"LoadMesin", "Load Mesin", 100}
                                }

    Dim dvTemp As New DataView
    Dim dtMesinSteril As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler browseMesinSteril.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler browseMesinSteril.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler browseMesinSteril.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler browseMesinSteril.getTextBox.TextChanged, AddressOf txtFind_Change

        browseMesinSteril.getTitle.Text = "Daftar Mesin Steril"

    End Sub

    Private Sub ucMesinSterilDaftar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SET ACL
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        If Not acl Is Nothing Then
            browseMesinSteril.getBtnNew.Enabled = acl.allowSave
            browseMesinSteril.getBtnEdit.Enabled = acl.allowEdit
            browseMesinSteril.getBtnDelete.Enabled = acl.allowDelete
        End If

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Me.dtMesinSteril = Me.cssdSrv.GetAllSetupMesin

        InProcFactory.CloseChannel(Me.cssdSrv)

        dvTemp.Table = Me.dtMesinSteril

        browseMesinSteril.getGridView().DataSource = dvTemp
        UILibs.GridStyle.C1formatGrid(browseMesinSteril.getGridView(), dvTemp.Table, fidArray)
    End Sub

    Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ucMesinAdd
        uc.btnCetakBarcode.Visible = False
        uc.dtpTglPengadaan.Checked = False
        uc.dtpTglPengadaan.CustomFormat = " "
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim KodeMesin As String = 0
        Dim uc As New ucMesinAdd

        KodeMesin = browseMesinSteril.getGridView().Columns("KodeMesin").Value
        uc.KodeMesin = KodeMesin

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_Mesin

        data.KodeMesin = KodeMesin
        data = Me.cssdSrv.ViewSetupMesin(data)

        InProcFactory.CloseChannel(Me.cssdSrv)

        uc.txtKodeMesin.Text = data.KodeMesin
        uc.txtKodeMesin.ReadOnly = True

        uc.txtNamaMesin.Text = data.NamaMesin
        uc.txtMerekMesin.Text = data.Merk
        uc.txtNamaVendor.Text = data.NamaVendor
        uc.txtKodeKelompokMesin.Text = data.GroupMesin.IdGroupMesin
        uc.txtNamaKelompokMesin.Text = data.GroupMesin.NamaGroupMesin
        uc.txtTipe.Text = data.GroupMesin.Tipe
        If data.TglPengadaan = String.Empty Then
            uc.dtpTglPengadaan.Checked = False
            uc.dtpTglPengadaan.CustomFormat = " "
        Else
            uc.dtpTglPengadaan.Checked = True
            uc.dtpTglPengadaan.Value = Date.ParseExact(data.TglPengadaan, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        End If

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim KodeMesin As String = browseMesinSteril.getGridView().Item(browseMesinSteril.getGridView().Row, "KodeMesin")

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_Mesin
        data.KodeMesin = KodeMesin
        Dim retVal As String = Me.cssdSrv.DeleteSetupMesin(data)

        InProcFactory.CloseChannel(Me.cssdSrv)
        If retVal = String.Empty Then
            MsgBox(String.Format("Kode Mesin {0} berhasil dihapus", KodeMesin), MsgBoxStyle.Information)
        End If


        'reload form
        ucMesinSterilDaftar_Load(sender, e)
    End Sub

    Sub txtFind_Change(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = CType(sender, TextBox).Text
        dvTemp.RowFilter = String.Format("KodeMesin LIKE '%{0}%'" &
                                         " OR NamaMesin LIKE '%{0}%' OR Merk LIKE '%{0}%'" _
                                         , str)
    End Sub
End Class
