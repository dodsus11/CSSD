Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmCetakNoTracing
    Dim defaultPrinter As New System.Drawing.Printing.PrinterSettings
    Dim PrinterLabelFound As Boolean
    Public dt As DataTable
    'Public dt2 As DataTable
    'Public label_type As String

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim prn As New PrintDialog()
        Dim pgSetting As New Printing.PageSettings
        If Not CmbPrinter.SelectedItem Is Nothing Then
            prn.PrinterSettings.PrinterName = CmbPrinter.SelectedItem.ToString
        Else
            prn.PrinterSettings.PrinterName = defaultPrinter.PrinterName
        End If

        prn.PrinterSettings.Copies = 1

        Dim x As New Printing.PaperSize("tes", 236, 196)
        x.PaperName = PaperKind.Legal
        pgSetting.PaperSize = x

        'If label_type = "SINGLE USE DI REUSE" Then
        Dim rpt As New crLabelTracingReuse_Rev
        rpt.SetDataSource(Me.dt)
        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = rpt
        rpt.PrintToPrinter(prn.PrinterSettings, pgSetting, False)
        rpt.Close()
        rpt.Dispose()
        'Else
        '    Dim rpt As New crLabelTracingRepeat_Rev
        '    rpt.SetDataSource(Me.dt)
        '    crv.ReuseParameterValuesOnRefresh = False
        '    crv.ReportSource = rpt
        '    rpt.PrintToPrinter(prn.PrinterSettings, pgSetting, False)
        '    rpt.Close()
        '    rpt.Dispose()
        'End If

        pgSetting = Nothing
        prn.Dispose()
        Me.Close()
    End Sub

    Private Sub frmCetakNoTracing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            CmbPrinter.Items.Add(sPrinters)
            If sPrinters = "tsc ttp-247" Then
                PrinterLabelFound = True
            End If
        Next

        If PrinterLabelFound Then
            CmbPrinter.SelectedText = "tsc ttp-247"
        Else
            CmbPrinter.SelectedText = defaultPrinter.PrinterName
        End If

        'If label_type = "SINGLE USE DI REUSE" Then
        Dim rpt As New crLabelTracingReuse_Rev
        rpt.SetDataSource(Me.dt)
        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = rpt
        'Else
        '    Dim rpt As New crLabelTracingRepeat_Rev
        '    rpt.SetDataSource(Me.dt)
        '    crv.ReuseParameterValuesOnRefresh = False
        '    crv.ReportSource = rpt
        'End If
    End Sub

End Class