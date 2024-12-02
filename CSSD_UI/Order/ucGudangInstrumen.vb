Imports System.Windows.Forms
Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucGudangInstrumen

    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Dim DEFAULT_INSTRUMEN_IN() As String = {"STERILISASI", "RESTERILISASI"}
    Dim DEFAULT_INSTRUMEN_IN_NON_STERILISASI() As String = {"SETTING_PACKING"}

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return

        If e.KeyCode = Keys.F2 Then
            txtKodeBarcode.Focus()
        End If

        If e.KeyCode = Keys.F5 Then

            If Not String.IsNullOrEmpty(TxtKodePetugas1.Text) Then
                If IsValid(TxtKodePetugas1.Text) = True Then
                    '        'save
                    SaveData()
                    '        'clear input
                Else
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                End If
            Else
                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()
                Return
            End If
            'If gridItem.RowCount <> 0 Then
            'Me.SaveData()
            'End If

        End If
    End Sub

    Private Sub SaveData()
        'cek status instrumen, apakah instrumen masuk ke menu yang benar
        For i As Integer = 0 To gridItem.RowCount - 1
            'cek jenis instrumen DTR (NON KRITIKAL) Or DTT (DESINFEKSI TINGKAT TINGGI)
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim jenis_instrumen As String
            jenis_instrumen = Me.cssdServ.ValidateNonSterilisasi(gridItem.DataSource.rows(i).item(1))
            InProcFactory.CloseChannel(Me.cssdServ)
            If jenis_instrumen = "DTR (NON KRITIKAL)" Or jenis_instrumen = "DTT (DESINFEKSI TINGKAT TINGGI)" Then
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim status As String
                status = Me.cssdServ.ValidateProcessOrder(gridItem.DataSource.rows(i).item(1))
                InProcFactory.CloseChannel(Me.cssdServ)
                If Not DEFAULT_INSTRUMEN_IN_NON_STERILISASI.Contains(status) Then
                    MsgBox("Maaf instrumen dg no.tracing : " & gridItem.DataSource.rows(i).item(1) & _
                           " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                           status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                    txtKodeBarcode.Focus()
                    Return
                End If
            Else
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim status As String
                status = Me.cssdServ.ValidateProcessOrder(gridItem.DataSource.rows(i).item(1))
                InProcFactory.CloseChannel(Me.cssdServ)
                If Not DEFAULT_INSTRUMEN_IN.Contains(status) Then
                    MsgBox("Maaf instrumen dg no.tracing : " & gridItem.DataSource.rows(i).item(1) & _
                           " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                           status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                    txtKodeBarcode.Focus()
                    Return
                End If
            End If
        Next


        'Dim retVal As String = String.Empty

        Dim retVal As Long

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
                    item.KodeGudang = lblGudang.Tag
                    item.UserPengirim = SessionInfo.fullName
                    'item.UserPengirim_2 = txtKodePetugas2.Text
                    item.UserPenerima = ""
                    item.KodeGudangAsal = ""

                    item.KodePetugasSterilisasi1 = TxtKodePetugas1.Text
                    item.KodePetugasSterilisasi2 = TxtKodePetugas2.Text

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

            'MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        UtilsLibs.MainMod.resetText(Me)
        gridItem.DataSource = Nothing
        InitGrid()
        txtKodeBarcode.Focus()
    End Sub

    Private Sub ucGudangInstrumen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtKodeBarcode.Focus()
        InitGrid()
        LoadMasterGudang()
        lblGudang.Tag = "CSSD"
        'txtNamaPetugas1.Text = SessionInfo.fullName
        'TxtKodePetugas1.Tag = SessionInfo.uid
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
        GH.gridControl(gridItem, GH.GridControlType.Button, "hapus", Color.Red, gridItem.ColumnCount)
        GH.gridColumnBackColor(gridItem, "NoTracing", Color.Aqua, True)
    End Sub

    Private Sub gridItem_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick
        Dim hapusIndex As Integer = gridItem.Columns("hapus").Index

        If e.ColumnIndex = hapusIndex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
            If MsgBox("Hapus data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                Exit Sub
            End If
            gridItem.DataSource.rows(e.RowIndex).delete()
        End If
    End Sub

    Private Sub txtKodeBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtKodeBarcode.Text = String.Empty Then
                Return
            End If

            Dim value As String = String.Empty
            value = txtKodeBarcode.Text

            'set petugas lewat barcode 

            If value.First = "P" Then

                If String.IsNullOrEmpty(TxtKodePetugas1.Text) And String.IsNullOrEmpty(TxtKodePetugas2.Text) Then
                    SetPetugas(value, TxtKodePetugas1, txtNamaPetugas1)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                ElseIf Not String.IsNullOrEmpty(TxtKodePetugas1.Text) Then
                    SetPetugas(value, TxtKodePetugas2, txtNamaPetugas2)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                ElseIf Not String.IsNullOrEmpty(TxtKodePetugas2.Text) Then
                    SetPetugas(value, TxtKodePetugas1, txtNamaPetugas1)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                Else
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                End If

            End If

            If value.First = "T" Then

                'cek jenis instrumen DTR (NON KRITIKAL)
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jenis_instrumen As String
                jenis_instrumen = Me.cssdServ.ValidateNonSterilisasi(value)
                InProcFactory.CloseChannel(Me.cssdServ)
                If jenis_instrumen = "DTR (NON KRITIKAL)" Or jenis_instrumen = "DTT (DESINFEKSI TINGKAT TINGGI)" Then

                    'cek status instrumen, apakah instrumen masuk ke menu yang benar
                    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                    Dim status As String
                    status = Me.cssdServ.ValidateProcessOrder(value)
                    InProcFactory.CloseChannel(Me.cssdServ)
                    If Not DEFAULT_INSTRUMEN_IN_NON_STERILISASI.Contains(status) Then
                        MsgBox("Maaf instrumen dg no.tracing : " & value & _
                               " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                               status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                        txtKodeBarcode.Focus()
                        Return
                    End If

                Else

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

                End If

                
                'validate same tracing number
                For i As Integer = 0 To gridItem.RowCount - 1
                    If value = gridItem.DataSource.rows(i).item(1) Then
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                        Return
                    End If
                Next

                'Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                'Dim jmlBefore As Integer
                'jmlBefore = Me.cssdServ.ValidateProcess(value, "STERILISASI")
                'InProcFactory.CloseChannel(Me.cssdServ)

                ''If jmlBefore = 1 Then
                'If jmlBefore > 0 Then
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

                'End If

                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()

                Return
            End If

        End If
    End Sub

    Private Sub SetPetugas(ByVal value As String, ByVal controlKode As TextBox, ByVal controlNama As TextBox)
        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dataPetugas As New model.CSSD_Petugas

        dataPetugas.KodePetugas = value
        dataPetugas = Me.cssdSetupServ.ViewSetupPetugas(dataPetugas)

        'txtNamaPetugas1.Text = dataPetugas.NamaPetugas
        controlKode.Text = dataPetugas.KodePetugas
        controlNama.Text = dataPetugas.NamaPetugas

        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub

    Private Function IsValid(ByVal value As String) As Boolean
        Dim Valid As Boolean = False

        'If txtKodePetugasGudang.Text = value Then
        '    Valid = True
        'Else
        '    txtKodePetugasGudang.Text = value
        '    SetPetugas(value)
        '    txtKodeBarcode.Text = String.Empty
        '    txtKodeBarcode.Focus()
        '    Return False
        'End If
        If TxtKodePetugas1.Text = value And
            Not String.IsNullOrEmpty(TxtKodePetugas1.Text) And
            Not String.IsNullOrEmpty(txtNamaPetugas1.Text) Then
            Valid = True
        Else

            SetPetugas(value, TxtKodePetugas1, txtNamaPetugas1)
            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()
            Return False
        End If

        'If lblGudang.Tag <> String.Empty Then
        'Valid = True
        'Else
        'Return False
        'End If

        If gridItem.RowCount > 0 Then
            Valid = True
        Else
            Return False
        End If

        Return Valid
    End Function

    Private Sub LoadMasterGudang()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dtMasterGudang As DataTable
        dtMasterGudang = Me.cssdServ.GetAllMasterGudang
        InProcFactory.CloseChannel(Me.cssdServ)
        'cmbMasterGudang.DataSource = dtMasterGudang
        'cmbMasterGudang.ValueMember = "KodeGudang"
        'cmbMasterGudang.DisplayMember = "NamaGudang"
    End Sub

    Private Sub btnPetugas1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetugas1.Click
        TxtKodePetugas1.Text = String.Empty
        txtNamaPetugas1.Text = String.Empty
    End Sub

    Private Sub btnPetugas2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetugas2.Click
        TxtKodePetugas2.Text = String.Empty
        txtNamaPetugas2.Text = String.Empty
    End Sub
End Class
