Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmCetakLabelPetugas
    Dim defaultPrinter As New System.Drawing.Printing.PrinterSettings
    Dim PrinterLabelFound As Boolean
    Dim rpt As New crLabelPetugas
    Public dt As DataTable
    
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim prn As New PrintDialog()
        Dim pgSetting As New Printing.PageSettings
        If Not CmbPrinter.SelectedItem Is Nothing Then
            prn.PrinterSettings.PrinterName = CmbPrinter.SelectedItem.ToString
        Else
            prn.PrinterSettings.PrinterName = defaultPrinter.PrinterName
        End If

        prn.PrinterSettings.Copies = 1
        'rpt.SetParameterValue("KodePetugas", Me.KodePetugas)
        'rpt.SetParameterValue("NamaPetugas", Me.NamaPetugas)
        
        Me.rpt.SetDataSource(dt)
        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = rpt

        Dim x As New Printing.PaperSize("tes", 236, 196)
        x.PaperName = PaperKind.Legal
        pgSetting.PaperSize = x

        rpt.PrintToPrinter(prn.PrinterSettings, pgSetting, False)

        Me.rpt.Dispose()
        Me.rpt.Close()
        pgSetting = Nothing
        prn.Dispose()

        Me.Close()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub frmCetakLabelPetugas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        rpt.SetDataSource(dt)
        crv.ReuseParameterValuesOnRefresh = False
        crv.ReportSource = rpt
    End Sub
End Class