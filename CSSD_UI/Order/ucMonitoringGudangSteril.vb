Imports System.Windows.Forms
Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucMonitoringGudangSteril

    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView

    Private Sub LoadMasterGudang()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dtMasterGudang As DataTable
        dtMasterGudang = Me.cssdServ.GetAllMasterGudang
        InProcFactory.CloseChannel(Me.cssdServ)
        cmbMasterGudang.DataSource = dtMasterGudang
        cmbMasterGudang.ValueMember = "KodeGudang"
        cmbMasterGudang.DisplayMember = "NamaGudang"

    End Sub

    Private Sub btnTampil_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    'Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)

    '    LoadData()

    'End Sub

    'Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim str As String = CType(sender, TextBox).Text
    '    dv.RowFilter = String.Format("NoInventory LIKE '%{0}%'" &
    '                                     " OR KodeAlat LIKE '%{0}%'" &
    '                                     " OR NamaAlat LIKE '%{0}%'" &
    '                                     "OR NamaJenis LIKE '%{0}%'" _
    '                                     , str)
    'End Sub

    Private Sub LoadData()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dtMasterGudang As New DataTable
        dtMasterGudang = Me.cssdServ.GetAllGudangByKode(cmbMasterGudang.SelectedValue)
        dv.Table = dtMasterGudang
        dgvDaftar.DataSource = dv
        InProcFactory.CloseChannel(Me.cssdServ)
        Me.formatGrid(dtMasterGudang)
    End Sub

    Private Sub ucMonitoringGudangSteril_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.LoadMasterGudang()
        'Me.LoadData()
        'Dim timer As New Timer()
        'timer.Interval = 3000
        'AddHandler timer.Tick, AddressOf timer_Tick
        'timer.Start()

        'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        'Dim dtMasterGudang As New DataTable
        'dtMasterGudang = Me.cssdServ.GetAllGudangByKode(cmbMasterGudang.SelectedValue)
        'dv.Table = dtMasterGudang
        'dgvDaftar.DataSource = dv
        'InProcFactory.CloseChannel(Me.cssdServ)
        'Me.formatGrid(dtMasterGudang)
    End Sub

    Private Sub formatGrid(ByVal dt As DataTable)
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("No. Tracing", 160))
        col.Add(GH.AddModelGridColumn("No. Inv", 80))
        col.Add(GH.AddModelGridColumn("Kode Alat", 80))
        col.Add(GH.AddModelGridColumn("NamaAlat", 200))
        col.Add(GH.AddModelGridColumn("Jenis", 110))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 140))
        col.Add(GH.AddModelGridColumn("Tgl. Masuk Gudang", 150))
        col.Add(GH.AddModelGridColumn("User Pengirim", 150))
        col.Add(GH.AddModelGridColumn("User Penerima", 150))
        GH.FormatGrid(dgvDaftar, dt, col, False, True, False, False)
    End Sub

    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        Me.LoadData()
    End Sub
End Class
