Imports CSSD_UI.Utility
Imports System.Windows.Forms
Imports System.Drawing

Public Class dlgDetailInstrumen
    Public dt As DataTable
    Public dvTemp As New DataView

    Private Sub dlgDetailInstrumen_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.dt.Columns.Add("Keterangan", GetType(System.String))
        dvTemp.Table = Me.dt
        Me.dgvInstrumen.DataSource = dvTemp

        'format grid
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id Instrumen", 100))
        col.Add(GH.AddModelGridColumn("Kode Instrumen", 150))
        col.Add(GH.AddModelGridColumn("Nama", 300))
        col.Add(GH.AddModelGridColumn("Qty Standar", 100))
        col.Add(GH.AddModelGridColumn("Id Detail Set", 0))
        col.Add(GH.AddModelGridColumn("Keterangan", 100))
        GH.FormatGrid(dgvInstrumen, dt, col, True, True, False, True)

        With dgvInstrumen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        End With
    End Sub

End Class