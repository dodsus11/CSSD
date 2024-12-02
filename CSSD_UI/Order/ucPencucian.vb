﻿Imports System.Windows.Forms
Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports CSSD_UI.Utility
Imports System.Drawing
Imports System.Text

Public Class ucPencucian
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Dim DEFAULT_INSTRUMEN_IN() As String = {"ORDER"}

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return

        If e.KeyCode = Keys.F2 Then
            txtKodeBarcode.Focus()
        End If

        If e.KeyCode = Keys.F5 Then

            If Not String.IsNullOrEmpty(txtKodePetugasPencucian.Text) Then
                If IsValid(txtKodePetugasPencucian.Text) = True Then
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

    Private Sub ucPencucian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtKodeBarcode.Focus()
        InitGrid()
    End Sub

    Private Sub SaveData()
        'cek status instrumen, apakah instrumen masuk ke menu yang benar
        For i As Integer = 0 To gridItem.RowCount - 1
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim status As String
            status = Me.cssdServ.ValidateProcessOrder(gridItem.DataSource.rows(i).item(1))
            InProcFactory.CloseChannel(Me.cssdServ)
            If Not DEFAULT_INSTRUMEN_IN.Contains(status) Then
                MsgBox("Maaf instrumen dg no.tracing : " & gridItem.DataSource.rows(i).item(1) & _
                       " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                       status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                Return
            End If
        Next

        Dim retVal As String = String.Empty

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim itemList As New List(Of model.CSSD_DetailOrderHistory)
        Dim item As model.CSSD_DetailOrderHistory

        For i As Integer = 0 To gridItem.DataSource.rows.count - 1
            With gridItem.DataSource.rows(i)

                If gridItem.DataSource.rows(i).item(1) <> String.Empty Then
                    item = New model.CSSD_DetailOrderHistory
                    item.IdDetailOrder = gridItem.DataSource.rows(i).item(0)
                    item.KodeMesin = txtKodeMesinPencucian.Text
                    item.KodePetugas = txtKodePetugasPencucian.Text
                    item.jenis = "CUCI"
                    item.StatusOrder = "PENCUCIAN"
                    item.create_by = SessionInfo.un
                    itemList.Add(item)
                End If

            End With
        Next

        retVal = Me.cssdServ.SaveDetailOrderHistory(txtKodeMesinPencucian.Text, itemList)

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
        dt.Columns.Add("JenisAlat", GetType(String))
        dt.Columns.Add("Kode_Identifikasi_Alat", GetType(String))

        gridItem.DataSource = dt

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("IdDetailOrder", 0))
        col.Add(GH.AddModelGridColumn("No. Tracing", 150))
        col.Add(GH.AddModelGridColumn("No. Inventory", 100))
        col.Add(GH.AddModelGridColumn("Kode ALat", 100))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Jenis Alat", 130))
        col.Add(GH.AddModelGridColumn("Kode Reuse", 130))
        
        GH.FormatGrid(gridItem, dt, col, False, True, True, False)
        'dt.Rows.Add(New Object() {"", "", "", 0, 0, 0, "", ""})
        GH.gridControl(gridItem, GH.GridControlType.Button, "hapus", Color.Red, gridItem.ColumnCount)
        GH.gridColumnBackColor(gridItem, "NoTracing", Color.Aqua, True)
    End Sub

    Private Function IsValid(ByVal value As String) As Boolean
        Dim Valid As Boolean = False

        If txtKodePetugasPencucian.Text = value And
            Not String.IsNullOrEmpty(txtKodePetugasPencucian.Text) And
            Not String.IsNullOrEmpty(txtNamaPetugasPencucian.Text) Then

            Valid = True

        Else
            SetPetugas(value)
            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()
            Return False
        End If

        If Not String.IsNullOrEmpty(txtKodeMesinPencucian.Text) And
            Not String.IsNullOrEmpty(txtNamaMesinPencucian.Text) Then
            Valid = True
        Else
            Return False
        End If

        If gridItem.RowCount > 0 Then
            IsValid = True
        Else
            Return False
        End If

        Return Valid
    End Function

    Private Sub txtKodeBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtKodeBarcode.Text = String.Empty Then
                Return
            End If

            Dim value As String = String.Empty
            value = txtKodeBarcode.Text

            If value.First = "P" Then

                If Not String.IsNullOrEmpty(txtKodePetugasPencucian.Text) Then
                    If IsValid(value) = True Then
                        'save
                        SaveData()
                        'clear input
                    Else
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                    End If
                Else
                    SetPetugas(value)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                    Return
                End If

            End If

            If value.First = "M" Then
                SetMesin(value)
                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()
                Return
            End If

            If value.First = "T" Then

                'cek status instrumen, apakah instrumen masuk ke menu yang benar
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim status As String
                status = Me.cssdServ.ValidateProcessOrder(value)
                InProcFactory.CloseChannel(Me.cssdServ)
                If Not DEFAULT_INSTRUMEN_IN.Contains(status) Then
                    MsgBox("Maaf instrumen dg no.tracing : " & value & _
                           " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                           status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                    txtKodeBarcode.Focus()
                    Return
                End If

                'validate same tracing number
                For i As Integer = 0 To gridItem.RowCount - 1
                    If value = gridItem.DataSource.rows(i).item(1) Then
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                        Return
                    End If
                Next

                'validate jenis barang
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jenisbarang As String
                jenisbarang = Me.cssdServ.ValidateJenisBarang(value)
                If jenisbarang = "BERSIH" Then
                    MessageBox.Show("Maaf jenis barang BERSIH, tidak melalui proses Pencucian ! Silakan ke menu Setting Packing !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                InProcFactory.CloseChannel(Me.cssdServ)

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jml As Integer
                jml = Me.cssdServ.ValidateProcess(value, "CUCI")
                InProcFactory.CloseChannel(Me.cssdServ)

                If jml = 0 Then
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
                                                               data.NamaAlat,
                                                               data.Jenis,
                                                               data.Kode_Identifikasi_Alat})

                End If

                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()

                Return
            End If

            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()

        End If
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

    Private Sub SetMesin(ByVal value As String)
        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dataMesin As New model.CSSD_Mesin
        dataMesin.KodeMesin = value
        dataMesin = Me.cssdSetupServ.ViewSetupMesin(dataMesin)

        txtKodeMesinPencucian.Text = dataMesin.KodeMesin
        txtNamaMesinPencucian.Text = dataMesin.NamaMesin
        txtNamaGroupMesin.Text = dataMesin.GroupMesin.NamaGroupMesin

        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub

    Private Sub SetPetugas(ByVal value As String)
        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dataPetugas As New model.CSSD_Petugas

        dataPetugas.KodePetugas = value
        dataPetugas = Me.cssdSetupServ.ViewSetupPetugas(dataPetugas)

        txtNamaPetugasPencucian.Text = dataPetugas.NamaPetugas
        txtKodePetugasPencucian.Text = dataPetugas.KodePetugas
        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub
   
End Class
