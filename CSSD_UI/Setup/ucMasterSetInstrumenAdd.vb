Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports RockUtil
Imports System.IO
Imports CSSD_SERVICE.CSSDSettings

Public Class ucMasterSetInstrumenAdd
    Private cssdServ As ICSSDSetupService
    Private acl As SessionInfo.ACLUser

    Public KodeSetInstrumen As String = String.Empty
    Dim dtDetail As DataTable
    Dim itemList As New List(Of model.CSSD_DetailSetInstrumen)
    Dim pathFoto As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        UILibs.MyResources.setButtonIcon(btnLookSatuan, "Open v2.png")

        btnFooter.getBtnSaveAndNew().Visible = False

        AddHandler btnFooter.getBtnSaveAndClose().Click, AddressOf btnSaveClose_Click
        AddHandler btnFooter.getBtnClear().Click, AddressOf btnClear_Click
        AddHandler btnFooter.getBtnCancel().Click, AddressOf btnCancel_Click

    End Sub

    Sub btnSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs)

        If txtKodeSetInstrumen.Text = String.Empty Then
            MessageBox.Show("Maaf Kode Set Instrumen wajib di isi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtNamaSetInstrumen.Text = String.Empty Then
            MessageBox.Show("Maaf Nama Set instrumen wajib di isi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtBerat.Text = String.Empty Or Not IsNumeric(txtBerat.Text) Then
            MessageBox.Show("Maaf Berat wajib di isi dan harus angka !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtSatuan.Text = String.Empty Then
            MessageBox.Show("Maaf Satuan wajib di isi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtStandarKasa.Text = String.Empty Or Not IsNumeric(txtStandarKasa.Text) Then
            MessageBox.Show("Maaf Standar Kasa wajib di isi dan harus angka !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Dim retVal As String
        Dim pesan As String = String.Empty

        Try
            Me.Cursor = Cursors.AppStarting

            If Me.KodeSetInstrumen = "" Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data Set Instrumen berhasil disimpan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data Set Instrumen berhasil diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else

                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.Cursor = Cursors.Default

            UILibs.PageLink.goToPage(Me.Parent, New ucMasterSetInstrumenDaftar(), Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

            Dim MasterSetInstrumen As New model.CSSD_MasterSetInstrumen
            Dim DetailSetInstrumen As model.CSSD_DetailSetInstrumen
            Dim ListItem As New List(Of model.CSSD_DetailSetInstrumen)
            Dim retVal As String = String.Empty

            MasterSetInstrumen.KodeSetInstrumen = txtKodeSetInstrumen.Text
            MasterSetInstrumen.NamaSetInstrumen = txtNamaSetInstrumen.Text
            MasterSetInstrumen.Berat = Convert.ToDouble(IIf(String.IsNullOrEmpty(txtBerat.Text), "0", txtBerat.Text))
            MasterSetInstrumen.Satuan.KodeSatuan = txtSatuan.Tag
            MasterSetInstrumen.Keterangan = txtKeterangan.Text
            MasterSetInstrumen.StandarKasa = txtStandarKasa.Text
            MasterSetInstrumen.PathFoto = txtPathFoto.Text
            MasterSetInstrumen.UserInput = SessionInfo.uid
            MasterSetInstrumen.UserUpdate = SessionInfo.uid
            MasterSetInstrumen.TglRevisi = dtpRevisi.Value
            MasterSetInstrumen.RevisiCount = nudRevisi.Value

            If isNew Then
                '---- collect item
                For i As Integer = 0 To dgvInstrumen.DataSource.rows.count - 1
                    With dgvInstrumen.DataSource.rows(i)

                        If dgvInstrumen.DataSource.rows(i).item(0) <> String.Empty Then
                            DetailSetInstrumen = New model.CSSD_DetailSetInstrumen
                            DetailSetInstrumen.IdInstrumen = dgvInstrumen.DataSource.rows(i).item(0)
                            DetailSetInstrumen.Qty = dgvInstrumen.DataSource.rows(i).item(3)
                            ListItem.Add(DetailSetInstrumen)
                        End If

                    End With
                Next
                '---- eoc collect item

                If ListItem.Count = 0 Then
                    Return "ERROR :tidak ada item yang akan disimpan, pilih item untuk disimpan!"
                End If

                retVal = Me.cssdServ.SaveMasterDetailSetInstrumen(MasterSetInstrumen, ListItem)
                If Not InStr(retVal, "ERROR") Then
                    If txtPathFoto.Text <> "" Then
                        If Not InStr(retVal, "NO_UPLOAD") Then
                            Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                            File.Copy(txtPathFoto.Text, SettingPath.SET_INSTRUMEN_IMAGE_PATH & retVal, True)
                        End If
                    End If

                End If

            Else
                CollectItem()
                'If dgvInstrumen.RowCount - 1 = 0 Then
                '    Return "ERROR :tidak ada item yang akan disimpan, pilih item untuk disimpan!"
                'End If

                retVal = Me.cssdServ.UpdateMasterDetailSetInstrumen(MasterSetInstrumen, itemList)
                If Not InStr(retVal, "ERROR") Then

                    If txtPathFoto.Text <> "" Then
                        If Not InStr(retVal, "NO_UPLOAD") Then
                            Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
                            File.Copy(txtPathFoto.Text, SettingPath.SET_INSTRUMEN_IMAGE_PATH & retVal, True)
                        End If
                    End If

                End If
                itemList.Clear()
            End If

            InProcFactory.CloseChannel(Me.cssdServ)

            Return retVal

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        UtilsLibs.MainMod.resetText(Me)
    End Sub

    Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New ucMasterSetInstrumenDaftar(), Me)
    End Sub

    Private Sub FormatGridSetInstrumen()
        Dim dt As New DataTable("detailItem")
        dgvInstrumen.Columns.Clear()
        dt.Columns.Add("IdInstrumen", GetType(String))
        dt.Columns.Add("KodeInstrumen", GetType(String))
        dt.Columns.Add("NamaInstrumen", GetType(String))
        dt.Columns.Add("Qty", GetType(Decimal))

        dgvInstrumen.DataSource = dt

        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("id", 100))
        col.Add(GH.AddModelGridColumn("Kode Instrumen", 200))
        col.Add(GH.AddModelGridColumn("Nama Instrumen", 300))
        col.Add(GH.AddModelGridColumn("Qty Standar", 100))
        GH.FormatGrid(dgvInstrumen, dt, col, False, True, True, False)
        dt.Rows.Add(New Object() {"", "", "", 0})
        GH.gridControl(dgvInstrumen, GH.GridControlType.Button, "pilih", Color.DarkOliveGreen, 0)
        GH.gridControl(dgvInstrumen, GH.GridControlType.Button, "hapus", Color.Red, dgvInstrumen.ColumnCount)
        GH.gridColumnBackColor(dgvInstrumen, "Qty", Color.Aqua)

    End Sub

    Private Sub ucMasterSetInstrumenAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.KodeSetInstrumen = "" Then
            Me.FormatGridSetInstrumen()
        Else
            Me.ViewData()
        End If
    End Sub

    Public Sub ViewData()
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        'Me.cssdServ = New CSSDSetupService

        Dim dataMaster As New model.CSSD_MasterSetInstrumen
        Dim dataDetail As New model.CSSD_DetailSetInstrumen

        dataMaster.KodeSetInstrumen = Me.KodeSetInstrumen
        dataDetail.KodeSetInstrumen = Me.KodeSetInstrumen 

        dataMaster = Me.cssdServ.ViewMasterSetInstrumen(dataMaster)
        dtDetail = Me.cssdServ.ViewDetailMasterSetInstrumen(dataDetail)
        InProcFactory.CloseChannel(Me.cssdServ)

        txtKodeSetInstrumen.Text = dataMaster.KodeSetInstrumen
        txtKodeSetInstrumen.ReadOnly = True
        txtNamaSetInstrumen.Text = dataMaster.NamaSetInstrumen
        txtKeterangan.Text = dataMaster.Keterangan
        txtBerat.Text = IIf(dataMaster.Berat = 0, "", dataMaster.Berat)
        txtSatuan.Text = dataMaster.Satuan.NamaSatuan
        txtSatuan.Tag = dataMaster.Satuan.KodeSatuan
        txtTglExpired.Text = dataMaster.ExpiredDate
        Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
        pbPhoto.ImageLocation = SettingPath.SET_INSTRUMEN_IMAGE_PATH & dataMaster.PathFoto
        'Util.CloseNetLogin("172.16.1.69\d$\CSSD\Instrumen")
        txtKeterangan.Text = dataMaster.Keterangan
        txtStandarKasa.Text = dataMaster.StandarKasa
        dtpRevisi.Value = dataMaster.TglRevisi
        nudRevisi.Value = dataMaster.RevisiCount
        ' txtPathFoto.Text = SettingPath.SET_INSTRUMEN_IMAGE_PATH & dataMaster.PathFoto
        ' pathFoto = SettingPath.SET_INSTRUMEN_IMAGE_PATH & dataMaster.PathFoto
        dgvInstrumen.DataSource = dtDetail
        Dim col As New List(Of GridColumnModel)
        col.Add(GH.AddModelGridColumn("Id Instrumen", 100))
        col.Add(GH.AddModelGridColumn("Kode Instrumen", 150))
        col.Add(GH.AddModelGridColumn("Nama", 300))
        col.Add(GH.AddModelGridColumn("Qty Standar", 100))
        col.Add(GH.AddModelGridColumn("Id", 0))
        GH.FormatGrid(dgvInstrumen, dtDetail, col, False, True, True, False)
        dtDetail.Rows.Add(New Object() {"", "", "", 0, 0})
        GH.gridControl(dgvInstrumen, GH.GridControlType.Button, "pilih", Color.DarkOliveGreen, 0)
        GH.gridControl(dgvInstrumen, GH.GridControlType.Button, "hapus", Color.Red, dgvInstrumen.ColumnCount)
        GH.gridColumnBackColor(dgvInstrumen, "Qty", Color.Aqua)

    End Sub

    Private Sub dgvInstrumen_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInstrumen.CellContentClick
        Dim pilihIndex As Integer = dgvInstrumen.Columns("pilih").Index
        Dim hapusIndex As Integer = dgvInstrumen.Columns("hapus").Index

        If e.ColumnIndex = pilihIndex Then

            Dim frmLookUp As New UILibs.DlgLookUp()

            frmLookUp.fidArray = {{"IdInstrumen", "Id", 100},
                                    {"KodeInstrumen", "Kode", 100},
                                    {"NamaInstrumen", "Nama", 200}}
            frmLookUp.keyField = "IdInstrumen"
            frmLookUp.fields = {"IdInstrumen", "KodeInstrumen",
                                "NamaInstrumen"}

            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

            Dim dt As New DataTable
            dt = Me.cssdServ.GetAllSetupMasterInstrumen()
            frmLookUp.dt = dt

            InProcFactory.CloseChannel(Me.cssdServ)

            If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then

                For i As Integer = 0 To dgvInstrumen.RowCount - 1
                    If frmLookUp.returnRow("IdInstrumen").ToString() = dgvInstrumen.Item(2, i).Value Then
                        MsgBox("Id instrumen yang sama sudah dimasukkan", MsgBoxStyle.Exclamation, "Peringatan")
                        Exit Sub
                    End If
                Next

                If Convert.ToString(dgvInstrumen.DataSource.rows(e.RowIndex).item(0)) = "" Then
                    dgvInstrumen.DataSource.rows.add(New Object() {"", "", "", 0})
                End If

                dgvInstrumen.DataSource.rows(e.RowIndex).item(0) = frmLookUp.returnRow("IdInstrumen").ToString()
                dgvInstrumen.DataSource.rows(e.RowIndex).item(1) = frmLookUp.returnRow("KodeInstrumen").ToString()
                dgvInstrumen.DataSource.rows(e.RowIndex).item(2) = frmLookUp.returnRow("NamaInstrumen").ToString()
                dgvInstrumen.DataSource.rows(e.RowIndex).item(3) = 0

            End If

        End If

        If e.ColumnIndex = hapusIndex And dgvInstrumen.DataSource.rows(e.RowIndex).item(0) <> "" Then
            If MsgBox("Hapus data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then
                Exit Sub
            End If
            dgvInstrumen.Rows.RemoveAt(e.RowIndex)
            If Me.KodeSetInstrumen <> "" Then
                CollectItem()
            End If
            'dtDetail.AcceptChanges()
        End If
    End Sub

    Private Sub btnLookSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookSatuan.Click
        Dim frmLookUp As New UILibs.DlgLookUp()

        frmLookUp.fidArray = {{"KodeSatuan", "Kode", 0},
                                {"NamaSatuan", "Nama", 100}}

        frmLookUp.keyField = "KodeSatuan"
        frmLookUp.fields = {"KodeSatuan", "NamaSatuan"}

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        Dim dt As New DataTable
        dt = Me.cssdServ.GetAllSetupSatuan
        frmLookUp.dt = dt

        InProcFactory.CloseChannel(Me.cssdServ)

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSatuan.Text = frmLookUp.returnRow("NamaSatuan").ToString()
            txtSatuan.Tag = frmLookUp.returnRow("KodeSatuan").ToString()

        End If
    End Sub

    Private Sub btnLookLokasiFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookLokasiFoto.Click
        Try

            ofd.Multiselect = False
            ofd.Filter = "image file (*.jpg)|*.jpg"
            Dim result As Integer = ofd.ShowDialog()

            If result = DialogResult.OK Then
                Dim fileName As String = String.Empty
                fileName = ofd.FileName.ToString()

                txtPathFoto.Text = fileName
                pbPhoto.ImageLocation = fileName
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CollectItem()

        Dim item As model.CSSD_DetailSetInstrumen
        Dim dtChanges As New DataTable
        Dim dt As DataTable
        dt = dtDetail

        dtChanges = dt.GetChanges(DataRowState.Deleted)
        If Not dtChanges Is Nothing Then
            For index = 0 To dtChanges.Rows.Count - 1
                With dtChanges
                    item = New model.CSSD_DetailSetInstrumen
                    item.IdInstrumen = .Rows(index)("IdInstrumen", DataRowVersion.Original)
                    item.KodeSetInstrumen = txtKodeSetInstrumen.Text
                    item.Qty = .Rows(index)("Qty", DataRowVersion.Original)
                    item.flag = "D"

                    Dim tmpData = (From a In itemList
                                 Where a.IdInstrumen = item.IdInstrumen And a.flag = item.flag
                                 Select a).ToList

                    If tmpData.Count = 0 Then
                        itemList.Add(item)
                    End If
                End With
            Next
        End If

        dtChanges = dt.GetChanges(DataRowState.Modified)
        If Not dtChanges Is Nothing Then
            For index = 0 To dtChanges.Rows.Count - 1
                With dtChanges
                    item = New model.CSSD_DetailSetInstrumen
                    item.IdInstrumen = .Rows(index)("IdInstrumen", DataRowVersion.Current)
                    item.KodeSetInstrumen = txtKodeSetInstrumen.Text
                    item.Qty = .Rows(index)("Qty", DataRowVersion.Current)
                    item.flag = "U"
                    'If item.Qty = 0 Then
                    '    item.flag = "A"
                    'Else
                    '    item.flag = "U"
                    'End If

                    Dim tmpData = (From a In itemList
                                 Where a.IdInstrumen = item.IdInstrumen And a.flag = item.flag
                                 Select a).ToList

                    If tmpData.Count = 0 Then
                        itemList.Add(item)
                    End If

                End With
            Next
        End If

        dtChanges = dt.GetChanges(DataRowState.Added)
        If Not dtChanges Is Nothing Then
            For index = 0 To dtChanges.Rows.Count - 1
                With dtChanges
                    item = New model.CSSD_DetailSetInstrumen
                    item.IdInstrumen = .Rows(index)("IdInstrumen", DataRowVersion.Default)
                    item.KodeSetInstrumen = txtKodeSetInstrumen.Text
                    item.Qty = .Rows(index)("Qty", DataRowVersion.Default)
                    item.flag = "A"
                    If Not String.IsNullOrEmpty(item.IdInstrumen) Then
                        Dim tmpData = (From a In itemList
                                Where a.IdInstrumen = item.IdInstrumen And a.flag = item.flag
                                Select a).ToList

                        If tmpData.Count = 0 Then
                            itemList.Add(item)
                        End If
                    End If

                End With
            Next
        End If

    End Sub


    Private Sub btnFooter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFooter.Load

    End Sub
End Class
