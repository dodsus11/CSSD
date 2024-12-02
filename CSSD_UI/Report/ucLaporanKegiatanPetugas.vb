Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports Excel = Microsoft.Office.Interop.Excel




Public Class ucLaporanKegiatanPetugas

    Dim yearNow As Integer
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim rpt_laporan As New crLaporanKinerja
    
    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        If dtFrom.Value.ToString("yyyy-MM") <> dtTo.Value.ToString("yyyy-MM") Then
            MsgBox("Bulan dan Tahun pada range tanggal harus sama !")
            Exit Sub
        End If

        LoadLaporan()
    End Sub
    Private Sub LoadLaporan()
       
        dgvLaporan.DataSource = Nothing
        dgvLaporan.Columns.Clear()

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        dt = cssdServ.execProcedure("CSSD_Laporan_Kinerja", New Object() {dtFrom.Value.ToString("yyyy-MM-dd"), dtTo.Value.ToString("yyyy-MM-dd")})
        dv.Table = dt
        dgvLaporan.DataSource = dv

        Dim col As New List(Of GridColumnModel)

        col.Add(GH.AddModelGridColumn("Kode Petugas", 0))
        col.Add(GH.AddModelGridColumn("Nama Petugas", 200))
        col.Add(GH.AddModelGridColumn("Jumlah Order", 100))
        col.Add(GH.AddModelGridColumn("Jumlah Cuci", 100))
        col.Add(GH.AddModelGridColumn("Jumlah Setting", 120))
        col.Add(GH.AddModelGridColumn("Jumlah Steril", 120))
        col.Add(GH.AddModelGridColumn("Jumlah Simpan", 120))
        col.Add(GH.AddModelGridColumn("Jumlah Distribusi", 120))
        col.Add(GH.AddModelGridColumn("Bobot Order", 120))
        col.Add(GH.AddModelGridColumn("Bobot Cuci", 120))
        col.Add(GH.AddModelGridColumn("Bobot Setting", 120))
        col.Add(GH.AddModelGridColumn("Bobot Steril", 120))
        col.Add(GH.AddModelGridColumn("Bobot Simpan", 120))
        col.Add(GH.AddModelGridColumn("Bobot Distribusi", 120))
        col.Add(GH.AddModelGridColumn("Total Kinerja", 120))
        GH.FormatGrid(dgvLaporan, dt, col, False, True, False, False)

    End Sub

    
   
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim frm As New FrmPreview

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable

        dt = cssdServ.execProcedure("CSSD_Laporan_Kinerja", New Object() {dtFrom.Value.ToString("yyyy-MM-dd"), dtTo.Value.ToString("yyyy-MM-dd")})

        InProcFactory.CloseChannel(Me.cssdServ)

        rpt_laporan.SetDataSource(dt)
        rpt_laporan.SetParameterValue("tglfrom", dtFrom.Value.ToString("yyyy-MM-dd"))
        rpt_laporan.SetParameterValue("tglto", dtTo.Value.ToString("yyyy-MM-dd"))
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt_laporan
        frm.ShowDialog()
    End Sub
End Class
