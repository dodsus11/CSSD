Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports UtilsLibs.MainMod
Imports RockUtil
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports CSSD_SERVICE.CSSDSettings

Public Class ucSettingPacking

    Private cssdServ As ICSSDOrderService
    Private cssdSetupServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Dim DEFAULT_INSTRUMEN_IN() As String = {"PENCUCIAN"}
    Dim DEFAULT_INSTRUMEN_IN_Bersih() As String = {"ORDER"}

    Dim is_set_instrumen As String

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

    Private Sub SaveDataNonSet()
        'cek status instrumen, apakah instrumen masuk ke menu yang benar
        For i As Integer = 0 To gridItem.RowCount - 1
            '------------ cek jenis barang--------
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim jenisbarang As String
            jenisbarang = Me.cssdServ.ValidateJenisBarang(gridItem.DataSource.rows(i).item(1))
            InProcFactory.CloseChannel(cssdServ)
            If jenisbarang = "BERSIH" Then
                'cek status instrumen, apakah instrumen masuk ke menu yang benar
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim statusx As String
                statusx = Me.cssdServ.ValidateProcessOrder(gridItem.DataSource.rows(i).item(1))
                InProcFactory.CloseChannel(Me.cssdServ)
                If Not DEFAULT_INSTRUMEN_IN_Bersih.Contains(statusx) Then
                    MsgBox("Maaf instrumen dg no.tracing : " & gridItem.DataSource.rows(i).item(1) & _
                           " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                           statusx & " dan jenis barang : " & jenisbarang, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                    txtKodeBarcode.Focus()
                    Return
                End If
            Else
                'cek status instrumen, apakah instrumen masuk ke menu yang benar
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
                    itempetugas1.KodeMesin = "-"
                    itempetugas1.KodePetugas = txtKodePetugasPacking1.Text
                    itempetugas1.jenis = "SETTING_PACKING"
                    itempetugas1.StatusOrder = "SETTING_PACKING"
                    itempetugas1.create_by = SessionInfo.un
                    itemList.Add(itempetugas1)

                    itempetugas2 = New model.CSSD_DetailOrderHistory
                    itempetugas2.IdDetailOrder = gridItem.DataSource.rows(i).item(0)
                    itempetugas2.KodeMesin = "-"
                    itempetugas2.KodePetugas = txtKodePetugasPacking2.Text
                    itempetugas2.jenis = "SETTING_PACKING"
                    itempetugas2.StatusOrder = "SETTING_PACKING"
                    itempetugas2.create_by = SessionInfo.un
                    itemList.Add(itempetugas2)
                End If

            End With
        Next

        retVal = Me.cssdServ.SaveDetailOrderHistory("-", itemList)

        If InStr(retVal, "ERROR") Then
            Me.Cursor = Cursors.Default
            MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else

            ' MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        UtilsLibs.MainMod.resetText(Me)
        gridItem.DataSource = Nothing
        'InitGrid()
        gridItem.Columns.Clear()
        txtKodeBarcode.Focus()
    End Sub

    Private Sub SaveDataSet()
        'cek status instrumen, apakah instrumen masuk ke menu yang benar
        '------------ cek jenis barang--------
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim jenisbarang As String
        jenisbarang = Me.cssdServ.ValidateJenisBarang(txtNoTracing.Text)
        InProcFactory.CloseChannel(cssdServ)
        If jenisbarang = "BERSIH" Then
            'cek status instrumen, apakah instrumen masuk ke menu yang benar
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim statusx As String
            statusx = Me.cssdServ.ValidateProcessOrder(txtNoTracing.Text)
            InProcFactory.CloseChannel(Me.cssdServ)
            If Not DEFAULT_INSTRUMEN_IN_Bersih.Contains(statusx) Then
                MsgBox("Maaf instrumen dg no.tracing : " & txtNoTracing.Text & _
                       " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                       statusx & " dan jenis barang : " & jenisbarang, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                txtKodeBarcode.Focus()
                Return
            End If
        Else
            'cek status instrumen, apakah instrumen masuk ke menu yang benar
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim status As String
            status = Me.cssdServ.ValidateProcessOrder(txtNoTracing.Text)
            InProcFactory.CloseChannel(Me.cssdServ)
            If Not DEFAULT_INSTRUMEN_IN.Contains(status) Then
                MsgBox("Maaf instrumen dg no.tracing : " & txtNoTracing.Text & _
                       " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                       status, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
                txtKodeBarcode.Focus()
                Return
            End If
        End If


        Dim retVal As String = String.Empty

        Dim dataPetugas1 As New model.CSSD_DetailOrderHistory
        dataPetugas1.IdDetailOrder = txtNoInventory.Tag
        dataPetugas1.KodePetugas = txtKodePetugasPacking1.Text
        dataPetugas1.KodeMesin = "-"
        dataPetugas1.jenis = "SETTING_PACKING"
        dataPetugas1.StatusOrder = "SETTING_PACKING"
        dataPetugas1.create_by = SessionInfo.un

        Dim dataPetugas2 As New model.CSSD_DetailOrderHistory
        dataPetugas2.IdDetailOrder = txtNoInventory.Tag
        dataPetugas2.KodePetugas = txtKodePetugasPacking2.Text
        dataPetugas2.KodeMesin = "-"
        dataPetugas2.jenis = "SETTING_PACKING"
        dataPetugas2.StatusOrder = "SETTING_PACKING"
        dataPetugas2.create_by = SessionInfo.un

        Dim Detail As model.CSSD_DetailSetting
        Dim ListItem As New List(Of model.CSSD_DetailSetting)

        '---- collect item
        For i As Integer = 0 To gridItem.DataSource.rows.count - 1
            With gridItem.DataSource.rows(i)

                If Not IsNumeric(gridItem.DataSource.rows(i).item(4)) Then
                    MsgBox("ERROR : Qty Setting harus angka !")
                    Return
                End If

                If gridItem.DataSource.rows(i).item(0) <> String.Empty Then
                    Detail = New model.CSSD_DetailSetting
                    Detail.IdInduk = txtKodeAlat.Text
                    Detail.KodeAlat = gridItem.DataSource.rows(i).item(0)
                    Detail.QtyPacking = gridItem.DataSource.rows(i).item(4)
                    Detail.Keterangan = gridItem.DataSource.rows(i).item(5)
                    Detail.IdJenisAlat = txtNoTracing.Tag
                    Detail.iddetailorder = txtNoInventory.Tag
                    ListItem.Add(Detail)
                End If

            End With
        Next
        '---- eoc collect item

        If ListItem.Count = 0 Then
            MsgBox("ERROR :tidak ada item yang akan disimpan, pilih item untuk disimpan!")
            Return
        End If

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        retVal = Me.cssdServ.SaveSettingPacking(dataPetugas1, dataPetugas2, ListItem)
        InProcFactory.CloseChannel(Me.cssdServ)

        If InStr(retVal, "ERROR") Then
            Me.Cursor = Cursors.Default
            MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else

            MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cetak(txtNoTracing.Tag, txtNoTracing.Text)
        End If

        UtilsLibs.MainMod.resetText(Me)
        gridItem.DataSource = Nothing
        gridItem.Columns.Clear()
        txtKodeBarcode.Focus()
    End Sub

    Private Function DataValid() As Boolean
        If is_set_instrumen = "Y" Then
            If txtNoTracing.Text = String.Empty Then
                Return False
            End If
        End If

        If txtKodePetugasPacking1.Text = String.Empty Then
            Return False
        End If

        If txtKodePetugasPacking2.Text = String.Empty Then
            Return False
        End If

        If gridItem.RowCount = 0 Then
            Return False
        End If

        Return True

    End Function

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click

        If DataValid() And is_set_instrumen = "Y" Then
            SaveDataSet()
        ElseIf DataValid() And is_set_instrumen = "N" Then
            SaveDataNonSet()
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
    
    Private Sub ucSettingPacking_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtKodeBarcode.Focus()

    End Sub

    Private Sub txtKodeBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtKodeBarcode.Text = String.Empty Then
                Return
            End If

            Dim value As String = String.Empty
            value = txtKodeBarcode.Text

           
            If value.First = "P" Then

                If Not String.IsNullOrEmpty(txtKodePetugasPacking2.Text) Then
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                    Return
                End If

                If Not String.IsNullOrEmpty(txtKodePetugasPacking1.Text) Then
                    SetPetugas(value, txtKodePetugasPacking2, txtNamaPetugasPacking2)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                End If

                If String.IsNullOrEmpty(txtKodePetugasPacking1.Text) Then
                    SetPetugas(value, txtKodePetugasPacking1, txtNamaPetugasPacking1)
                    txtKodeBarcode.Text = String.Empty
                    txtKodeBarcode.Focus()
                End If

            End If

            If value.First = "T" Then

                '------------ cek jenis barang--------
                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jenisbarang As String
                jenisbarang = Me.cssdServ.ValidateJenisBarang(value)
                InProcFactory.CloseChannel(cssdServ)


                If jenisbarang = "BERSIH" Then

                    'cek status instrumen, apakah instrumen masuk ke menu yang benar
                    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                    Dim statusx As String
                    statusx = Me.cssdServ.ValidateProcessOrder(value)
                    InProcFactory.CloseChannel(Me.cssdServ)
                    If Not DEFAULT_INSTRUMEN_IN_Bersih.Contains(statusx) Then
                        MsgBox("Maaf instrumen dg no.tracing : " & value & _
                               " tidak bisa masuk ke menu ini, status terakhir instrumen adalah : " & _
                               statusx & " dan jenis barang : " & jenisbarang, MsgBoxStyle.Critical, UILibs.MessageTitle.PESAN)
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

                    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                    Dim jmlBefore As Integer
                    jmlBefore = Me.cssdServ.ValidateProcess(value, "CUCI")
                    InProcFactory.CloseChannel(Me.cssdServ)

                    If jmlBefore = 0 Then
                        txtKodeBarcode.Text = String.Empty
                        txtKodeBarcode.Focus()
                        Return
                    End If


                End If

                Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                Dim jml As Integer
                jml = Me.cssdServ.ValidateProcess(value, "SETTING_PACKING")
                InProcFactory.CloseChannel(Me.cssdServ)

                If jml = 0 Then

                    Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                    is_set_instrumen = Me.cssdServ.GetJenisAlat(value)
                    InProcFactory.CloseChannel(Me.cssdServ)

                    If is_set_instrumen = "Y" Then

                        PanelHeaderSet.Visible = True
                        Panelpetugas.Visible = True
                        PanelpotoSetInstrumen.Visible = True
                        PanelpotoInstrumen.Visible = True

                        gridItem.DataSource = Nothing
                        gridItem.Columns.Clear()

                        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
                        Dim data As model.CSSD_TracingDetailView
                        data = Me.cssdServ.TracingDetailView(value)
                        InProcFactory.CloseChannel(Me.cssdServ)

                        txtNoInventory.Tag = data.IdDetailOrder
                        txtNoTracing.Tag = data.IdJenisAlat
                        txtNoTracing.Text = data.NoTracing
                        txtNoInventory.Text = data.NoInventory
                        txtKodeAlat.Text = data.KodeAlat
                        txtNamaAlat.Text = data.NamaAlat

                        GetDetailForSetting(data.NoInventory)

                        If data.NoTracing Is Nothing Then
                            txtKodeBarcode.Text = String.Empty
                            txtKodeBarcode.Focus()
                            Return
                        End If

                        '---- menampilkan poto set instrumen
                        pbPhoto.Image = Nothing
                        PbPotoInstrumen.Image = Nothing
                        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
                        Dim dataMaster As New model.CSSD_MasterSetInstrumen
                        dataMaster.KodeSetInstrumen = txtKodeAlat.Text
                        dataMaster = Me.cssdSetupServ.ViewMasterSetInstrumen(dataMaster)
                        'Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                        If dataMaster.PathFoto <> String.Empty Then
                            Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                            pbPhoto.ImageLocation = SettingPath.SET_INSTRUMEN_IMAGE_PATH & dataMaster.PathFoto
                        End If
                        'pbPhoto.ImageLocation = SettingPath.SET_INSTRUMEN_IMAGE_PATH & dataMaster.PathFoto
                        InProcFactory.CloseChannel(cssdSetupServ)

                    Else

                        If PanelHeaderSet.Visible = True Then
                            gridItem.DataSource = Nothing
                            gridItem.Columns.Clear()
                        End If

                        If gridItem.RowCount = 0 Then
                            PanelHeaderSet.Visible = False
                            Panelpetugas.Visible = True
                            PanelpotoSetInstrumen.Visible = False
                            PanelpotoInstrumen.Visible = True
                            PbPotoInstrumen.Image = Nothing
                            InitGrid()
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

                End If

                txtKodeBarcode.Text = String.Empty
                txtKodeBarcode.Focus()

                Return
            End If

            txtKodeBarcode.Text = String.Empty
            txtKodeBarcode.Focus()

        End If
    End Sub

    Private Sub SetPetugas(ByVal value As String, ByVal controlKode As TextBox, ByVal controlNama As TextBox)
        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        Dim dataPetugas As New model.CSSD_Petugas

        dataPetugas.KodePetugas = value
        dataPetugas = Me.cssdSetupServ.ViewSetupPetugas(dataPetugas)

        controlKode.Text = dataPetugas.KodePetugas
        controlNama.Text = dataPetugas.NamaPetugas

        InProcFactory.CloseChannel(Me.cssdSetupServ)
    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        UtilsLibs.MainMod.resetText(Me)
        gridItem.DataSource = Nothing
        'InitGrid()
        txtKodeBarcode.Focus()
    End Sub

    Public Overrides Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If UtilsLibs.MainMod.IsCheckedUCX(Me) = False Then Return

        If e.KeyCode = Keys.F5 Then
            btnSimpan_Click(sender, e)
        End If

        If e.KeyCode = Keys.F1 Then

            btnHapus_Click(sender, e)

        End If

        If e.KeyCode = Keys.F2 Then

            txtKodeBarcode.Focus()

        End If
    End Sub

    Private Sub GetDetailForSetting(ByVal NoInventory As String)
        Dim dt As DataTable
        Dim dv As New DataView
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        dt = Me.cssdServ.GetDetailForSettingPacking(NoInventory)
        dv.Table = dt
        Me.gridItem.DataSource = dt

        InProcFactory.CloseChannel(Me.cssdServ)
        'format grid
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id", 0))
        col.Add(GH.AddModelGridColumn("Kode Alat", 130))
        col.Add(GH.AddModelGridColumn("Nama Alat", 250))
        col.Add(GH.AddModelGridColumn("Qty Standar", 120))
        col.Add(GH.AddModelGridColumn("Qty Setting", 120))
        col.Add(GH.AddModelGridColumn("Keterangan", 150))

        GH.FormatGrid(gridItem, dt, col, True, True, False, False)
        GH.gridColumnBackColor(gridItem, "QtyPacking", Color.Aqua)
        GH.gridColumnBackColor(gridItem, "Keterangan", Color.Aqua)

        With gridItem
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        End With
    End Sub

    
    Private Sub gridItem_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridItem.CellContentClick
        Dim IdInstrumen As String

        If is_set_instrumen = "Y" Then
            IdInstrumen = gridItem.Item(0, e.RowIndex).Value
            Try

                Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
                Dim data As New model.CSSD_MasterInstrumen
                data.IdInstrumen = IdInstrumen
                data = Me.cssdSetupServ.ViewSetupMasterInstrumen(data)
                InProcFactory.CloseChannel(Me.cssdSetupServ)
                If data.PathFoto = "" Then
                    MsgBox("Tidak ada poto instrumen tersebut", MsgBoxStyle.Exclamation, "Pesan")
                Else

                    Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                    PbPotoInstrumen.ImageLocation = SettingPath.INSTRUMEN_IMAGE_PATH & data.PathFoto
                End If

            Catch ex As Exception
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation, "Pesan")
            End Try
        Else
            IdInstrumen = gridItem.Item(3, e.RowIndex).Value

            Dim hapusIndex As Integer = gridItem.Columns("hapus").Index

            If e.ColumnIndex = hapusIndex And gridItem.DataSource.rows(e.RowIndex).item(1) <> "" Then
                If MsgBox("Hapus data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                    Exit Sub
                End If
                gridItem.DataSource.rows(e.RowIndex).delete()
            Else
                Try

                    Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
                    Dim data As New model.CSSD_MasterInstrumen
                    data.IdInstrumen = IdInstrumen
                    data = Me.cssdSetupServ.ViewSetupMasterInstrumen(data)
                    InProcFactory.CloseChannel(Me.cssdSetupServ)
                    If data.PathFoto = "" Then
                        MsgBox("Tidak ada poto instrumen tersebut", MsgBoxStyle.Exclamation, "Pesan")
                    Else

                        Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                        PbPotoInstrumen.ImageLocation = SettingPath.INSTRUMEN_IMAGE_PATH & data.PathFoto
                    End If

                Catch ex As Exception
                    MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation, "Pesan")
                End Try
            End If
        End If

    End Sub

    Private Sub btnCetak_Click(sender As System.Object, e As System.EventArgs) Handles btnCetak.Click
        Cetak(txtNoTracing.Tag, txtNoTracing.Text)
    End Sub
End Class
