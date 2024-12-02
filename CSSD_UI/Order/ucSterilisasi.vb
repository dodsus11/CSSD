Imports System.Windows.Forms
Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucSterilisasi
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Dim DEFAULT_INSTRUMEN_IN() As String = {"SETTING_PACKING"}

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return

        If e.KeyCode = Keys.F2 Then
            txtKodeBarcode.Focus()
        End If

        If e.KeyCode = Keys.F5 Then

            If Not String.IsNullOrEmpty(txtKodePetugasSterilisasi.Text) Then
                If IsValid(txtKodePetugasSterilisasi.Text) = True Then
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

    Private Sub ucSterilisasi_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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
        Dim itempetugas1 As model.CSSD_DetailOrderHistory
        Dim itempetugas2 As model.CSSD_DetailOrderHistory

        For i As Integer = 0 To gridItem.DataSource.rows.count - 1
            With gridItem.DataSource.rows(i)

                If gridItem.DataSource.rows(i).item(1) <> String.Empty Then
                    itempetugas1 = New model.CSSD_DetailOrderHistory
                    itempetugas1.IdDetailOrder = gridItem.DataSource.rows(i).item(0)
                    itempetugas1.KodeMesin = txtKodeMesinSterilisasi.Text
                    itempetugas1.KodePetugas = txtKodePetugasSterilisasi.Text
                    itempetugas1.jenis = "STERILISASI"
                    itempetugas1.StatusOrder = "STERILISASI"
                    itempetugas1.create_by = SessionInfo.un
                    itemList.Add(itempetugas1)

                    If txtKodePetugasSterilisasi2.Text <> String.Empty Then
                        itempetugas2 = New model.CSSD_DetailOrderHistory
                        itempetugas2.IdDetailOrder = gridItem.DataSource.rows(i).item(0)
                        itempetugas2.KodeMesin = txtKodeMesinSterilisasi.Text
                        itempetugas2.KodePetugas = txtKodePetugasSterilisasi2.Text
                        itempetugas2.jenis = "STERILISASI"
                        itempetugas2.StatusOrder = "STERILISASI"
                        itempetugas2.create_by = SessionInfo.un
                        itemList.Add(itempetugas2)
                    End If
                End If

            End With
        Next

        retVal = Me.cssdServ.SaveDetailOrderHistory(txtKodeMesinSterilisasi.Text, itemList)

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

        If txtKodePetugasSterilisasi.Text = value And
            Not String.IsNullOrEmpty(txtKodePetugasSterilisasi.Text) And
            Not String.IsNullOrEmpty(txtNamaPetugasSterilisasi.Text) Then
            Valid = True
        Else

            SetPetugas(value, txtKodePetugasSterilisasi, txtNamaPetugasSterilisasi)
            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()
            Return False
        End If

        If Not String.IsNullOrEmpty(txtKodeMesinSterilisasi.Text) And
            Not String.IsNullOrEmpty(txtNamaMesinSterilisasi.Text) Then
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

            'If value.First = "P" Then

            '    If Not String.IsNullOrEmpty(txtKodePetugasSterilisasi2.Text) Then
            '        txtKodeBarcode.Text = String.Empty
            '        txtKodeBarcode.Focus()
            '        Return
            '    End If

            '    If Not String.IsNullOrEmpty(txtKodePetugasSterilisasi.Text) Then
            '        SetPetugas(value, txtKodePetugasSterilisasi2, txtNamaPetugasSterilisasi2)
            '        txtKodeBarcode.Text = String.Empty
            '        txtKodeBarcode.Focus()
            '    End If

            '    If String.IsNullOrEmpty(txtKodePetugasSterilisasi.Text) Then
            '        SetPetugas(value, txtKodePetugasSterilisasi, txtNamaPetugasSterilisasi)
            '        txtKodeBarcode.Text = String.Empty
            '        txtKodeBarcode.Focus()
            '    End If

            'End If

            If value.First = "P" Then

                If String.IsNullOrEmpty(txtKodePetugasSterilisasi.Text) And String.IsNullOrEmpty(txtKodePetugasSterilisasi2.Text) Then
                    SetPetugas(value, txtKodePetugasSterilisasi, txtNamaPetugasSterilisasi)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                ElseIf Not String.IsNullOrEmpty(txtKodePetugasSterilisasi.Text) Then
                    SetPetugas(value, txtKodePetugasSterilisasi2, txtNamaPetugasSterilisasi2)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                ElseIf Not String.IsNullOrEmpty(txtKodePetugasSterilisasi2.Text) Then
                    SetPetugas(value, txtKodePetugasSterilisasi, txtNamaPetugasSterilisasi)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                Else
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
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

                'cek jenis instrumen DTR (NON KRITIKAL)
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jenis_instrumen As String
                jenis_instrumen = Me.cssdServ.ValidateNonSterilisasi(value)
                InProcFactory.CloseChannel(Me.cssdServ)
                If jenis_instrumen = "DTR (NON KRITIKAL)" Or jenis_instrumen = "DTT (DESINFEKSI TINGKAT TINGGI)" Then
                    MsgBox("Maaf jenis instrumen : " & jenis_instrumen & _
                           " tidak melalui proses sterilisasi ! ", MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
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

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jmlBefore As Integer
                jmlBefore = Me.cssdServ.ValidateProcess(value, "SETTING_PACKING")
                InProcFactory.CloseChannel(Me.cssdServ)

                If jmlBefore = 0 Then
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                    Return
                End If

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jml As Integer
                jml = Me.cssdServ.ValidateProcess(value, "STERILISASI")
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

        txtKodeMesinSterilisasi.Text = dataMesin.KodeMesin
        txtNamaMesinSterilisasi.Text = dataMesin.NamaMesin
        txtNamaGroupMesin.Text = dataMesin.GroupMesin.NamaGroupMesin

        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub

    'Private Sub SetPetugas(ByVal value As String)
    '    Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
    '    Dim dataPetugas As New model.CSSD_Petugas

    '    dataPetugas.KodePetugas = value
    '    dataPetugas = Me.cssdSetupServ.ViewSetupPetugas(dataPetugas)

    '    txtNamaPetugasSterilisasi.Text = dataPetugas.NamaPetugas
    '    txtKodePetugasSterilisasi.Text = dataPetugas.KodePetugas
    '    InProcFactory.CloseChannel(Me.cssdSetupServ)
    'End Sub

    Private Sub SetPetugas(ByVal value As String, ByVal controlKode As TextBox, ByVal controlNama As TextBox)
        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dataPetugas As New model.CSSD_Petugas

        dataPetugas.KodePetugas = value
        dataPetugas = Me.cssdSetupServ.ViewSetupPetugas(dataPetugas)

        controlKode.Text = dataPetugas.KodePetugas
        controlNama.Text = dataPetugas.NamaPetugas

        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub

    Private Sub btnPetugas_Click(sender As System.Object, e As System.EventArgs) Handles btnPetugas.Click
        txtKodePetugasSterilisasi.Text = String.Empty
        txtNamaPetugasSterilisasi.Text = String.Empty
    End Sub

    Private Sub btnPetugas2_Click(sender As System.Object, e As System.EventArgs) Handles btnPetugas2.Click
        txtKodePetugasSterilisasi2.Text = String.Empty
        txtNamaPetugasSterilisasi2.Text = String.Empty
    End Sub

End Class
