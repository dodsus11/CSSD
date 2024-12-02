Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports RockUtil
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports CSSD_SERVICE.CSSDSettings

Public Class frmViewMasterDetailInstrumen
    Private cssdSrv As ICSSDSetupService
    Public dt As DataTable
    Public dvTemp As New DataView

    Private Sub frmViewMasterDetailInstrumen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dvTemp.Table = Me.dt
        Me.dgvInstrumen.DataSource = dvTemp

        'format grid
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id Instrumen", 100))
        col.Add(GH.AddModelGridColumn("Kode Instrumen", 150))
        col.Add(GH.AddModelGridColumn("Nama", 300))
        col.Add(GH.AddModelGridColumn("Qty Standar", 100))
        col.Add(GH.AddModelGridColumn("Id Detail Set", 0))
        GH.FormatGrid(dgvInstrumen, dt, col, True, True, False, True)

        With dgvInstrumen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        End With
    End Sub

    Private Sub dgvInstrumen_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInstrumen.CellContentClick
        Dim IdInstrumen As String = dgvInstrumen.Item(0, e.RowIndex).Value

        Me.cssdSrv = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim data As New model.CSSD_MasterInstrumen
        data.IdInstrumen = IdInstrumen
        data = Me.cssdSrv.ViewSetupMasterInstrumen(data)
        InProcFactory.CloseChannel(Me.cssdSrv)
        Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
        pbPhotoInstrumen.ImageLocation = SettingPath.INSTRUMEN_IMAGE_PATH & data.PathFoto

    End Sub
End Class