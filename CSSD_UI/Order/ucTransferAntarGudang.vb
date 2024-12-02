Imports System.Windows.Forms
Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports CSSD_UI.Utility
Imports System.Drawing

Public Class ucTransferAntarGudang
    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Dim DEFAULT_INSTRUMEN_IN() As String = {"GUDANG_CSSD", "GUDANG_GBS", "GUDANG_IBS"}
    Dim gudang As String

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return

        If e.KeyCode = Keys.F2 Then
            txtKodeBarcode.Focus()
        End If

        If e.KeyCode = Keys.F5 Then

            If IsValid() Then
                saveData()
            Else
                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()
                Return
            End If

        End If
    End Sub

    Private Sub txtKodeBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtKodeBarcode.Text = String.Empty Then
                Return
            End If

            Dim value As String = String.Empty
            value = txtKodeBarcode.Text

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

                'cek status instrumen, apakah instrumen posisi digudang yang benar sesuai mapping user gudang
                If gudang <> status Then
                    MsgBox("Maaf instrumen dg no.tracing : " & value & _
                           " tidak ada digudang : " & lblGudang.Text & ", status terakhir instrumen adalah : " & _
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

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                'Dim jmlBefore As Integer = 0
                Dim jmlAlat As Integer = 0
                jmlAlat = Me.cssdServ.GetJmlBarangDiGudang(value, lblGudang.Tag)
                'jmlAlat = Me.cssdServ.GetJmlBarangDiGudang(value, "CSSD")
                'jmlBefore = Me.cssdServ.ValidateProcess(value, "STERILISASI")
                InProcFactory.CloseChannel(Me.cssdServ)

                'If jmlBefore = 1 And jmlAlat = 1 Then
                'If jmlBefore > 0 And jmlAlat = 1 Then
                If jmlAlat = 1 Then
                    'add to grid
                    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                    Dim data As model.CSSD_TracingDetailView
                    Dim detail As New model.CSSD_TracingOrderDetail
                    data = Me.cssdServ.TracingDetailView(value)
                    detail = Me.cssdServ.GetTracingOrderDetail(value)
                    InProcFactory.CloseChannel(Me.cssdServ)

                    If data.NoTracing Is Nothing Then
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                        Return
                    End If

                    'txtGudangTujuan.Text = detail.poly_name

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

        End If
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

    Private Function IsValid() As Boolean
        Dim Valid As Boolean = False

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

    Private Sub ucTransferAntarGudang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtKodeBarcode.Focus()
        InitGrid()
        Dim idUser As Long = SessionInfo.uid

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dataUser As New model.CSSD_MappingUserGudang
        dataUser = Me.cssdSetupServ.ViewUserTerdaftarGudang(idUser)
        lblGudang.Text = dataUser.NamaGudang
        lblGudang.Tag = dataUser.KodeGudang
        InProcFactory.CloseChannel(Me.cssdSetupServ)
        PetugasEntry.Text = SessionInfo.fullName
        PetugasEntry.Tag = SessionInfo.uid
        txtPetugasPengirim.Text = SessionInfo.fullName
        'If lblGudang.Tag = "CSSD" Then
        '    PnPetugasPenerima.Visible = False
        '    pnPetugasPengirim.Visible = False
        'Else
        '    txtPetugasPengirim.Text = SessionInfo.fullName
        '    txtPetugasPenerima.Text = SessionInfo.fullName
        'End If

        If lblGudang.Tag = "CSSD" Then
            gudang = "GUDANG_CSSD"
        ElseIf lblGudang.Tag = "GBS" Then
            gudang = "GUDANG_GBS"
        ElseIf lblGudang.Tag = "IBS" Then
            gudang = "GUDANG_IBS"
        End If
    End Sub

    Private Sub SaveData()
        For i As Integer = 0 To gridItem.RowCount - 1
            'cek status instrumen, apakah instrumen masuk ke menu yang benar
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

            'cek status instrumen, apakah instrumen posisi digudang yang benar sesuai mapping user gudang
            If gudang <> status Then
                MsgBox("Maaf instrumen dg no.tracing : " & gridItem.DataSource.rows(i).item(1) & _
                       " tidak ada digudang : " & lblGudang.Text & ", status terakhir instrumen adalah : " & _
                       status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                txtKodeBarcode.Focus()
                Return
            End If
        Next


        If txtGudangTujuan.Text = String.Empty Then
            MsgBox("Silakan isi gudang tujuan terlebih dahulu !", MsgBoxStyle.Exclamation, "Pesan")
            txtGudangTujuan.Focus()
            Exit Sub
        End If

        If txtPetugasPenerima.Text = String.Empty Then
            MsgBox("Silakan isi petugas penerima terlebih dahulu !", MsgBoxStyle.Exclamation, "Pesan")
            txtPetugasPenerima.Focus()
            Exit Sub
        End If

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
                    item.KodeGudang = txtGudangTujuan.Tag
                    item.UserPengirim = SessionInfo.fullName
                    item.UserPenerima = txtPetugasPenerima.Text
                    item.KodeGudangAsal = lblGudang.Tag
                    itemList.Add(item)
                End If

            End With
        Next

        retVal = Me.cssdServ.SaveToGudangSteril(itemList)

        'If InStr(retVal, "ERROR") Then
        Me.Cursor = Cursors.Default
        '    MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return
        'Else

        'MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CetakBukti(retVal)

        'End If

        'UtilsLibs.MainMod.resetText(Me)
        txtPetugasPenerima.Text = String.Empty
        txtGudangTujuan.Text = String.Empty
        txtGudangTujuan.Tag = String.Empty
        gridItem.DataSource = Nothing
        InitGrid()
        txtKodeBarcode.Focus()
    End Sub

    Private Sub CetakBukti(ByVal id_group_transfer As Long)
        Dim rpt As New crBuktiTransferGudang
        Dim frm As New FrmPreview

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetReportTransferGudang(id_group_transfer)

        InProcFactory.CloseChannel(Me.cssdServ)
        rpt.SetDataSource(dt)
        frm.crv.ReuseParameterValuesOnRefresh = False
        frm.crv.ReportSource = rpt
        frm.ShowDialog()
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

    Private Sub btnLookUpGudang_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpGudang.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeGudang", "Kode Gudang", 100},
                                {"NamaGudang", "Nama Gudang", 200}}

        frmLookUp.keyField = "KodeGudang"
        frmLookUp.fields = {"KodeGudang", "NamaGudang"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()

        Dim dt As New DataTable
        'dt = Me.cssdSetupServ.GetAllSetupMasterGudang
        dt = Me.cssdServ.GetAllMasterGudang
        frmLookUp.dt = dt
        
        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtGudangTujuan.Text = frmLookUp.returnRow("NamaGudang").ToString()
            txtGudangTujuan.Tag = frmLookUp.returnRow("KodeGudang").ToString()

        End If
    End Sub

End Class
