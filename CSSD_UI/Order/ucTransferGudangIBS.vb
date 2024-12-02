Imports System.Windows.Forms
Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucTransferGudangIBS
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return

        If e.KeyCode = Keys.F2 Then
            txtKodeBarcode.Focus()
        End If

        If e.KeyCode = Keys.F5 Then

            If Not String.IsNullOrEmpty(txtKodePetugasGudang.Text) Then
                If IsValid(txtKodePetugasGudang.Text) = True Then
                    'save
                    SaveData()
                    'clear input
                Else
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                End If
            Else
                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()
                Return
            End If

        End If
    End Sub

    Private Sub SaveData()
        Dim retVal As String = String.Empty

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim itemList As New List(Of model.CSSD_GudangSteril)
        Dim item As model.CSSD_GudangSteril

        For i As Integer = 0 To gridItem.DataSource.rows.count - 1
            With gridItem.DataSource.rows(i)

                If gridItem.DataSource.rows(i).item(1) <> String.Empty Then
                    item = New model.CSSD_GudangSteril
                    item.NoTracing = gridItem.DataSource.rows(i).item(1)
                    item.NoInventory = gridItem.DataSource.rows(i).item(2)
                    item.KodeAlat = gridItem.DataSource.rows(i).item(3)
                    item.KodeGudang = "IBS_TRANSFER"
                    item.UserCSSD = txtKodePetugasGudang.Text
                    item.UserIBS = txtPetugasIBS.Text
                    itemList.Add(item)
                End If

            End With
        Next

        retVal = Me.cssdServ.SaveToGudangSteril(itemList)

        If InStr(retVal, "ERROR") Then
            Me.Cursor = Cursors.Default
            MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else

            ' MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        UtilsLibs.MainMod.resetText(Me)
        gridItem.DataSource = Nothing
        InitGrid()
        txtKodeBarcode.Focus()
    End Sub

    Private Sub InitGrid()
        Dim dt As New DataTable("detailItem")
        gridItem.Columns.Clear()
        dt.Columns.Add("IdDetailOrder", GetType(Integer))
        dt.Columns.Add("NoTracing", GetType(String))
        dt.Columns.Add("NoInventory", GetType(String))
        dt.Columns.Add("KodeAlat", GetType(String))
        dt.Columns.Add("NamaAlat", GetType(String))

        gridItem.DataSource = dt

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("IdDetailOrder", 0))
        col.Add(GH.AddModelGridColumn("No. Tracing", 150))
        col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))

        GH.FormatGrid(gridItem, dt, col, False, True, True, False)
        'dt.Rows.Add(New Object() {"", "", "", 0, 0, 0, "", ""})
        GH.gridControl(gridItem, GH.GridControlType.Button, "hapus", Color.Red, gridItem.ColumnCount)
        GH.gridColumnBackColor(gridItem, "NoTracing", Color.Aqua, True)
    End Sub

    Private Sub gridItem_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick
        Dim hapusIndex As Integer = gridItem.Columns("hapus").Index

        If e.ColumnIndex = hapusIndex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
            If MsgBox("Hapus data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                Exit Sub
            End If
            gridItem.DataSource.rows(e.RowIndex).delete()
        End If
    End Sub

    Private Sub SetPetugas(ByVal value As String)
        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dataPetugas As New model.CSSD_Petugas

        dataPetugas.KodePetugas = value
        dataPetugas = Me.cssdSetupServ.ViewSetupPetugas(dataPetugas)

        txtNamaPetugasGudang.Text = dataPetugas.NamaPetugas

        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub

    Private Function IsValid(ByVal value As String) As Boolean
        Dim Valid As Boolean = False

        If txtKodePetugasGudang.Text = value Then
            Valid = True
        Else
            txtKodePetugasGudang.Text = value
            SetPetugas(value)
            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()
            Return False
        End If

        If lblGudang.Tag <> String.Empty Then
            Valid = True
        Else
            Return False
        End If

        If gridItem.RowCount > 0 Then
            Valid = True
        Else
            Return False
        End If

        Return Valid
    End Function

    Private Sub ucTransferGudangIBS_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtKodeBarcode.Focus()
        InitGrid()
        lblGudang.Text = "GUDANG IBS"
        lblGudang.Tag = "IBS_TRANSFER"
    End Sub

    Private Sub txtKodeBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtKodeBarcode.Text = String.Empty Then
                Return
            End If

            Dim value As String = String.Empty
            value = txtKodeBarcode.Text

            If value.First = "P" Then

                If Not String.IsNullOrEmpty(txtKodePetugasGudang.Text) Then
                    If IsValid(value) = True Then
                        'save
                        SaveData()
                        'clear input
                    Else
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                    End If
                Else
                    txtKodePetugasGudang.Text = value
                    SetPetugas(value)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                    Return
                End If

            End If

            If value.First = "T" Then

                'validate same tracing number
                For i As Integer = 0 To gridItem.RowCount - 1
                    If value = gridItem.DataSource.rows(i).item(1) Then
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                        Return
                    End If
                Next

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim dataOrder As New model.CSSD_TracingOrderDetail
                dataOrder = Me.cssdServ.GetTracingOrderDetail(value)
                InProcFactory.CloseChannel(Me.cssdServ)

                If dataOrder.StatusOrder = "GUDANG_CSSD" Then
                    'add to grid
                    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                    Dim data As model.CSSD_TracingDetailView
                    data = Me.cssdServ.TracingDetailView(value)
                    InProcFactory.CloseChannel(Me.cssdServ)

                    If data.NoTracing Is Nothing Then
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                        Return
                    End If

                    gridItem.DataSource.Rows.Add(New Object() {data.IdDetailOrder,
                                                               data.NoTracing,
                                                               data.NoInventory,
                                                               data.KodeAlat,
                                                               data.NamaAlat})

                End If

                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()

                Return
            End If

        End If
    End Sub
End Class
