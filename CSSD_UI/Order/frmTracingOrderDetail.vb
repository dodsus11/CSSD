Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports RockUtil
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports CSSD_SERVICE.CSSDSettings

Public Class frmTracingOrderDetail
    Private cssdServ As ICSSDOrderService
    Public notrace As String
    Public idjenisalat As Integer


    Private Sub frmTracingOrderDetail_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtNoTracing.Focus()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If idjenisalat = 1 Or idjenisalat = 4 Then
            Cetak(idjenisalat, notrace)
        Else
            MsgBox("Maaf jenis alat tidak memerlukan checklist ! ", MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
        End If
    End Sub

    Private Sub Cetak(ByVal idJenisAlat As Integer, ByVal NoTrace As String)

        Dim frm As New FrmPreview

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable
        Dim data As New model.CSSD_TracingOrderDetail

        dt = Me.cssdServ.GetReportCekLIst(idJenisAlat, NoTrace)
        data = Me.cssdServ.GetTracingOrderDetail(NoTrace)

        InProcFactory.CloseChannel(Me.cssdServ)

        'If idJenisAlat = 1 Then
        Dim rpt As New crCeklistAlat

        rpt.SetDataSource(dt)
        rpt.SetParameterValue("TglSetting", data.TglSettingPacking)
        rpt.SetParameterValue("Petugas1", data.PetugasSetting1)
        rpt.SetParameterValue("Petugas2", data.PetugasSetting2)
        rpt.SetParameterValue("NamaAlat", data.NamaAlat)
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt
        frm.ShowDialog()

        'End If

    End Sub


End Class