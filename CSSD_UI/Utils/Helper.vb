Imports System.Windows.Forms
Imports System.Reflection
Imports System.Drawing

Namespace Utility
    Public Class Helper
        Public Shared Sub ClearTextBox(ByVal root As Control)
            For Each ctrl As Control In root.Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Text = String.Empty
                End If
            Next ctrl
        End Sub
        Public Shared Sub AddHeadWidth(ByVal DGridView As DataGridView, ByRef SrcDs As DataTable, ByVal Heads() As Object, ByVal Width() As Integer)
            Try
                Dim firstFont As New System.Drawing.Font("Tahoma", 9, Drawing.FontStyle.Regular)
                Dim ViewCell As DataGridViewCell
                Dim cellstyle As DataGridViewCellStyle
                Dim GridReadOnly As Boolean
                Dim SrcDataSource As DataTable
                SrcDataSource = SrcDs

                DGridView.AllowUserToAddRows = False
                DGridView.AllowUserToDeleteRows = False

                For j = 0 To SrcDataSource.Columns.Count - 1
                    cellstyle = New DataGridViewCellStyle
                    If SrcDataSource.Columns(j).DataType.ToString = "System.Boolean" Then
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        ViewCell = New DataGridViewCheckBoxCell
                        GridReadOnly = False
                    Else
                        ViewCell = New DataGridViewTextBoxCell
                        GridReadOnly = True
                        If SrcDataSource.Columns(j).DataType.ToString = "System.Decimal" Then
                            cellstyle.Format = "N"
                            cellstyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        ElseIf SrcDataSource.Columns(j).DataType.ToString = "System.DateTime" Then
                            cellstyle.Format = "MM/dd/yyyy hh:mm:ss"
                            cellstyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        ElseIf SrcDataSource.Columns(j).DataType.ToString = "System.Int32" Then
                            cellstyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        Else
                            cellstyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        End If

                    End If

                    cellstyle.Font = firstFont
                    cellstyle.ForeColor = Color.Black
                    ViewCell.Style = cellstyle

                    DGridView.Columns(j).HeaderText = Heads(j)
                    If Width(j) <= 0 Then
                        DGridView.Columns(j).Visible = False
                    Else
                        DGridView.Columns(j).Width = Width(j)
                    End If

                    ' DGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 188)
                    DGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                    DGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke
                    DGridView.ColumnHeadersDefaultCellStyle.Font = firstFont
                    DGridView.Columns(j).CellTemplate = ViewCell
                    DGridView.Columns(j).DefaultCellStyle = cellstyle
                    DGridView.Columns(j).ReadOnly = GridReadOnly
                Next

            Catch ex As Exception
                MsgBox(Err.Description & ". ErrCode : " & Err.Number, MsgBoxStyle.Critical, "DatasetToGrid Function Error")
            End Try
        End Sub
    End Class

    Public NotInheritable Class GH

        Public Shared Sub FormatGridLapPelayananInstrumen(ByRef dgv As DataGridView, ByVal GridEnabled As Boolean)

            dgv.Columns("NoInventory").HeaderText = "No. Inv"
            dgv.Columns("NoInventory").Width = 120
            dgv.Columns("KodeAlat").HeaderText = "Kode Alat"
            dgv.Columns("KodeAlat").Width = 120
            dgv.Columns("NamaSetInstrumen").HeaderText = "Nama Set Instrumen"
            dgv.Columns("NamaSetInstrumen").Width = 150
            dgv.Columns("Berat").HeaderText = "Berat"
            dgv.Columns("Berat").Width = 90
            dgv.Columns("StandarKasa").HeaderText = "Standar Kasa"
            dgv.Columns("StandarKasa").Width = 110

            For index = 5 To dgv.ColumnCount - 1
                dgv.Columns(index).Width = 50
            Next
            dgv.Columns("jml kasa").Width = 110
            dgv.Columns(4).Frozen = True
            dgv.Columns(0).DefaultCellStyle.BackColor = Color.Khaki
            dgv.Columns(1).DefaultCellStyle.BackColor = Color.Khaki
            dgv.Columns(2).DefaultCellStyle.BackColor = Color.Khaki
            dgv.Columns(3).DefaultCellStyle.BackColor = Color.Khaki
            dgv.Columns(4).DefaultCellStyle.BackColor = Color.Khaki

            dgv.Enabled = GridEnabled
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke

            Dim headerFont As New System.Drawing.Font("Tahoma", 9, Drawing.FontStyle.Bold)
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgv.EnableHeadersVisualStyles = False

            'dgv.ColumnHeadersHeight = 25
            dgv.ColumnHeadersDefaultCellStyle.Font = headerFont
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgv.AllowUserToResizeRows = False
        End Sub

        Public Shared Sub FormatGrid(ByRef dgv As DataGridView,
                                     ByVal dt As DataTable,
                                     ByVal column As List(Of GridColumnModel),
                                     ByVal sort As Boolean,
                                     ByVal GridEnabled As Boolean,
                                     ByVal isTrans As Boolean,
                                     ByVal AlternateColor As Boolean)

            Dim firstFont As New System.Drawing.Font("Tahoma", 9, Drawing.FontStyle.Regular)
            Dim ViewCell As DataGridViewCell
            Dim cellstyle As DataGridViewCellStyle
            Dim source As DataTable
            source = dt

            dgv.AllowUserToAddRows = False
            dgv.AllowUserToDeleteRows = False
            Dim j As Integer = 0
            For Each item In column


                cellstyle = New DataGridViewCellStyle
                If source.Columns(j).DataType.ToString = "System.Boolean" Then
                    cellstyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ViewCell = New DataGridViewCheckBoxCell
                Else
                    ViewCell = New DataGridViewTextBoxCell

                    If source.Columns(j).DataType.ToString = "System.Decimal" Then
                        cellstyle.Format = "N"
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ElseIf source.Columns(j).DataType.ToString = "System.DateTime" Then
                        cellstyle.Format = "MM/dd/yyyy HH:mm:ss"
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    ElseIf source.Columns(j).DataType.ToString = "System.Int32" Then

                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Else
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If

                End If

                cellstyle.Font = firstFont
                cellstyle.ForeColor = Color.Black
                ViewCell.Style = cellstyle

                dgv.Columns(j).HeaderText = item.columnName
                If item.width <= 0 Then
                    dgv.Columns(j).Visible = False
                Else
                    dgv.Columns(j).Width = item.width
                End If

                If AlternateColor = True Then
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 188)
                End If

                dgv.ColumnHeadersDefaultCellStyle.Font = firstFont
                dgv.Columns(j).CellTemplate = ViewCell
                dgv.Columns(j).DefaultCellStyle = cellstyle
                dgv.Columns(j).ReadOnly = True
                If sort = False Then
                    dgv.Columns(j).SortMode = DataGridViewColumnSortMode.NotSortable
                End If
                j = j + 1
            Next
            dgv.Enabled = GridEnabled
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke

            Dim headerFont As New System.Drawing.Font("Tahoma", 9, Drawing.FontStyle.Bold)
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgv.EnableHeadersVisualStyles = False
            If (isTrans = True) Then
                dgv.RowHeadersVisible = False
            Else
                dgv.RowHeadersVisible = True
            End If

            'dgv.ColumnHeadersHeight = 25
            dgv.ColumnHeadersDefaultCellStyle.Font = headerFont
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgv.AllowUserToResizeRows = False
        End Sub

        Public Shared Sub FormatGridWithNewRow(ByRef dgv As DataGridView,
                                     ByVal dt As DataTable,
                                     ByVal column As List(Of GridColumnModel),
                                     ByVal sort As Boolean,
                                     ByVal GridEnabled As Boolean,
                                     ByVal isTrans As Boolean,
                                     ByVal AlternateColor As Boolean)

            Dim firstFont As New System.Drawing.Font("Tahoma", 9, Drawing.FontStyle.Regular)
            Dim ViewCell As DataGridViewCell
            Dim cellstyle As DataGridViewCellStyle
            Dim source As DataTable
            source = dt

            dgv.AllowUserToAddRows = False
            dgv.AllowUserToDeleteRows = False
            Dim j As Integer = 0
            For Each item In column


                cellstyle = New DataGridViewCellStyle
                If source.Columns(j).DataType.ToString = "System.Boolean" Then
                    cellstyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ViewCell = New DataGridViewCheckBoxCell
                Else
                    ViewCell = New DataGridViewTextBoxCell

                    If source.Columns(j).DataType.ToString = "System.Decimal" Then
                        cellstyle.Format = "N"
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ElseIf source.Columns(j).DataType.ToString = "System.DateTime" Then
                        cellstyle.Format = "MM/dd/yyyy hh:mm:ss"
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    ElseIf source.Columns(j).DataType.ToString = "System.Int32" Then

                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Else
                        cellstyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If

                End If

                cellstyle.Font = firstFont
                cellstyle.ForeColor = Color.Black
                ViewCell.Style = cellstyle

                dgv.Columns(j).HeaderText = item.columnName
                If item.width <= 0 Then
                    dgv.Columns(j).Visible = False
                Else
                    dgv.Columns(j).Width = item.width
                End If

                If AlternateColor = True Then
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 188)
                End If

                dgv.ColumnHeadersDefaultCellStyle.Font = firstFont
                dgv.Columns(j).CellTemplate = ViewCell
                dgv.Columns(j).DefaultCellStyle = cellstyle
                dgv.Columns(j).ReadOnly = True
                If sort = False Then
                    dgv.Columns(j).SortMode = DataGridViewColumnSortMode.NotSortable
                End If
                j = j + 1
            Next
            dgv.Enabled = GridEnabled
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke

            Dim headerFont As New System.Drawing.Font("Tahoma", 9, Drawing.FontStyle.Bold)
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgv.EnableHeadersVisualStyles = False
            If (isTrans = True) Then
                dgv.RowHeadersVisible = False
            Else
                dgv.RowHeadersVisible = True
            End If

            'dgv.ColumnHeadersHeight = 25
            dgv.ColumnHeadersDefaultCellStyle.Font = headerFont
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgv.AllowUserToResizeRows = False


        End Sub


        Public Shared Sub gridColumnBackColor(ByRef dgv As DataGridView,
                                              ByVal columnName As String,
                                              ByVal backColor As Color,
                                              Optional ByVal readOnlyColumn As Boolean = False)
            dgv.Columns(columnName).DefaultCellStyle.BackColor = backColor
            If readOnlyColumn = True Then
                dgv.Columns(columnName).ReadOnly = True
            Else
                dgv.Columns(columnName).ReadOnly = False
            End If
        End Sub

        Public Shared Sub gridRowBackColor(ByRef dgv As DataGridView,
                                              ByVal columnName As String,
                                              ByVal backColor As Color)

        End Sub

        Public Shared Sub gridControl(ByRef dgv As DataGridView,
                                      ByVal control As GridControlType,
                                      ByVal headerText As String,
                                      ByVal color As Color,
                                      ByVal pos As Integer,
                                      Optional ByVal width As Integer = 0
                                      )
            Select Case control
                Case GridControlType.Button

                    Dim column As New DataGridViewButtonColumn
                    With column
                        .Text = headerText
                        .Name = headerText
                        .FlatStyle = FlatStyle.Flat
                        .DefaultCellStyle.BackColor = color
                        .HeaderText = headerText
                        If width = 0 Then
                            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Else
                            .Width = width
                        End If

                    End With
                    dgv.Columns.Insert(pos, column)

                Case GridControlType.CheckBox
                    Dim column As New DataGridViewCheckBoxColumn()
                    With column
                        .HeaderText = headerText
                        .Name = headerText
                        If width = 0 Then
                            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Else
                            .Width = width
                        End If
                        .FlatStyle = FlatStyle.Standard
                        .CellTemplate = New DataGridViewCheckBoxCell()
                        .CellTemplate.Style.BackColor = color
                    End With

                    dgv.Columns.Insert(pos, column)

            End Select

        End Sub

        Public Shared Function AddModelGridColumn(ByVal columnName As String, ByVal width As Integer) As GridColumnModel
            Dim data As New GridColumnModel
            data.columnName = columnName
            data.width = width
            Return data
        End Function
        

        Public Enum GridControlType
            Button
            CheckBox
        End Enum

    End Class


    Public Class GridColumnModel
        Public Property columnName As String
        Public Property width As Integer
    End Class

End Namespace

