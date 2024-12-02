Imports UILibs
Imports model = CSSD_SERVICE.model
Imports CSSD_SERVICE.service
Imports ClientLibs
Imports SessionInfo
Imports System.Windows.Forms
Imports CSSD_UI.Utility
Imports System.Drawing
Imports GenCode128
Imports System.IO
Imports RockUtil
Imports CSSD_SERVICE.CSSDSettings

Public Class dlgOrderSterilisasi

    Private cssdSetupServ As ICSSDSetupService
    Private cssdServ As ICSSDOrderService
    Public Add As Boolean = True
    Public IdOrder As String
    Public IdDetailOrder As Long

    Private Sub ShowDetail(ByVal KodeSetInstrumen As String)
        If KodeSetInstrumen = String.Empty Then
            Exit Sub
        End If

        Dim frmDetail As New dlgDetailInstrumen

        Dim dtDetail As New DataTable
        Dim detail As New model.CSSD_DetailSetInstrumen
        Dim master As New model.CSSD_MasterSetInstrumen
        detail.KodeSetInstrumen = KodeSetInstrumen
        master.KodeSetInstrumen = KodeSetInstrumen

        Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()
        dtDetail = Me.cssdSetupServ.ViewDetailMasterSetInstrumen(detail)

        If lblJenisAlat.Text = "TROMOL" Or _
           lblJenisAlat.Text = "KEMASAN SET" Then
            master = Me.cssdSetupServ.ViewMasterSetInstrumen(master)

            Util.NetLogin(SettingPath.LOGIN_SET_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
            frmDetail.pbPhoto.ImageLocation = SettingPath.SET_INSTRUMEN_IMAGE_PATH & master.PathFoto
        Else
            master = Me.cssdSetupServ.ViewInstrumenNonSet(master)

            Util.NetLogin(SettingPath.LOGIN_INSTRUMEN_IMAGE_PATH, "", SettingPath.SERVER_USER, SettingPath.SERVER_PASS)
            frmDetail.pbPhoto.ImageLocation = SettingPath.INSTRUMEN_IMAGE_PATH & master.PathFoto
        End If
        InProcFactory.CloseChannel(Me.cssdSetupServ)

        frmDetail.dt = dtDetail
        frmDetail.txtKodeSetInstrumen.Text = master.KodeSetInstrumen
        frmDetail.txtNamaSetInstrumen.Text = master.NamaSetInstrumen
        frmDetail.txtKeterangan.Text = master.Keterangan
        frmDetail.txtTglExpired.Text = master.ExpiredDate
        frmDetail.txtBerat.Text = master.Berat
        frmDetail.txtSatuan.Text = master.Satuan.NamaSatuan
        frmDetail.txtStandarKasa.Text = IIf(master.StandarKasa = 0, "", master.StandarKasa)
        frmDetail.ShowDialog()
    End Sub

    Private Sub btnLookInven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookInven.Click

        'Dim frmLookUp As New UILibs.DlgLookUp()

        'frmLookUp.fidArray = {{"NoInventory", "No. Inv", 100},
        '                        {"KodeAlat", "Kode", 100},
        '                        {"NamaAlat", "Nama Alat", 250},
        '                        {"Berat", "Berat", 100},
        '                        {"KodeSatuan", "KodeSatuan", 0},
        '                        {"NamaSatuan", "NamaSatuan", 100}}

        'frmLookUp.keyField = "NoInventory"
        'frmLookUp.fields = {"KodeAlat", "NamaAlat", "Berat", "KodeSatuan", "NamaSatuan"}

        'Me.cssdSetupServ = InProcFactory.CreateChannel(Of CSSDSetupService, ICSSDSetupService)()

        'Dim dt As New DataTable
        'dt = Me.cssdSetupServ.GetInventoryByJenis(1)
        'frmLookUp.dt = dt

        'InProcFactory.CloseChannel(Me.cssdSetupServ)

        'If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    txtNoInvent.Text = frmLookUp.returnRow("NoInventory")
        '    txtKode.Text = frmLookUp.returnRow("KodeAlat").ToString()
        '    txtNama.Text = frmLookUp.returnRow("NamaAlat").ToString()
        '    txtJml.Text = 1
        '    txtBerat.Text = frmLookUp.returnRow("Berat").ToString()
        '    lblSatuan.Tag = frmLookUp.returnRow("KodeSatuan").ToString()
        '    lblSatuan.Text = frmLookUp.returnRow("NamaSatuan").ToString()
        'End If

        Dim dlgLookUp As New dlgLookUpInstrumen

        If dlgLookUp.ShowDialog() = DialogResult.OK Then

            'cek NoInventory is exist
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim retVal As String

            If dlgLookUp.txtJenis.Tag = 2 Then
                If dlgLookUp.cmbJenis.SelectedItem = "Perulangan" Then
                    retVal = Me.cssdServ.ValidateOrder(dlgLookUp.gvDaftar.Columns("NoInventory").Value, _
                                                       dlgLookUp.gvDaftar.Columns("Kode_Identifikasi_Alat").Value)
                End If
            Else
                retVal = Me.cssdServ.ValidateOrder(dlgLookUp.gvDaftar.Columns("NoInventory").Value, _
                                                   String.Empty)
            End If

            InProcFactory.CloseChannel(Me.cssdServ)
            If InStr(retVal, "ERROR") Then
                MsgBox(retVal, MsgBoxStyle.Exclamation, "Pesan")
                Exit Sub
            End If

            txtNoInvent.Text = dlgLookUp.gvDaftar.Columns("NoInventory").Value
            txtKode.Text = dlgLookUp.gvDaftar.Columns("KodeAlat").Value
            txtNama.Text = dlgLookUp.gvDaftar.Columns("NamaAlat").Value
            txtJml.Text = 1
            txtBerat.Text = dlgLookUp.gvDaftar.Columns("Berat").Value
            lblSatuan.Tag = dlgLookUp.gvDaftar.Columns("KodeSatuan").Value
            lblSatuan.Text = dlgLookUp.gvDaftar.Columns("NamaSatuan").Value
            lblJenisAlat.Tag = dlgLookUp.txtJenis.Tag
            lblJenisAlat.Text = dlgLookUp.txtJenis.Text
            If dlgLookUp.txtJenis.Tag = 2 Then
                If dlgLookUp.cmbJenis.SelectedItem = "Baru" Then
                    lblReuse.Tag = dlgLookUp.cmbJenis.SelectedItem
                    lblReuse.Text = String.Empty
                Else
                    lblReuse.Tag = dlgLookUp.cmbJenis.SelectedItem
                    lblReuse.Text = dlgLookUp.gvDaftar.Columns("Kode_Identifikasi_Alat").Value
                End If
            Else
                lblReuse.Tag = String.Empty
                lblReuse.Text = String.Empty
            End If

        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnLookDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookDetail.Click
        ShowDetail(txtKode.Text)
    End Sub

    Function saveOrUpdate(ByVal isNew As Boolean) As String
        Try
            Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
            Dim retVal As String = String.Empty

            Dim data As New model.CSSD_DetailOrder
            data.IdDetailOrder = IdDetailOrder
            data.IdOrder = IdOrder
            data.NoInventory = txtNoInvent.Text
            data.QtyTerima = 1
            data.Berat = txtBerat.Text
            data.KodeSatuan = lblSatuan.Tag
            data.Keterangan = txtKet.Text
            data.create_by = SessionInfo.un
            data.update_by = SessionInfo.un
            data.IdJenisAlat = lblJenisAlat.Tag
            data.JenisReuse = lblReuse.Tag
            data.KodeIdentifikasi = lblReuse.Text

            If isNew Then
                For i As Integer = 1 To txtJml.Text
                    retVal = Me.cssdServ.SaveDetailOrder(data)
                Next
            Else
                retVal = Me.cssdServ.UpdateDetailOrder(data)
            End If

            InProcFactory.CloseChannel(Me.cssdServ)

            Return retVal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda Yakin ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        If lblJenisAlat.Text = "TROMOL" Or lblReuse.Tag = "Perulangan" Then
            If txtJml.Text > 1 Then
                MsgBox("Maaf, untuk TROMOL dan SINGLE USE DI REUSE Perulangan, jumlah tidak boleh melebihi 1 !", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If
        End If

        Dim retVal As String
        Dim pesan As String = String.Empty

        Try
            Me.Cursor = Cursors.AppStarting

            If Add = True Then
                'insert new data
                retVal = saveOrUpdate(True)
                pesan = "Data berhasil ditambahkan"
            Else
                'update data
                retVal = saveOrUpdate(False)
                pesan = "Data berhasil diupdate"
            End If

            If InStr(retVal, "ERROR") Then
                Me.Cursor = Cursors.Default
                MessageBox.Show(retVal, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else
                MessageBox.Show(pesan, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Cursor = Cursors.Default

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim retVal As String = Me.cssdServ.DeleteDetailOrder(IdDetailOrder, SessionInfo.un)
        InProcFactory.CloseChannel(Me.cssdServ)

        If InStr(retVal, "ERROR") Then
            MsgBox(retVal, MsgBoxStyle.Exclamation, "Pesan")
        Else
            MsgBox("Order Berhasil dihapus", MsgBoxStyle.Information, "Pesan")
        End If

        Me.Close()
    End Sub

    Private Sub btnCetakTracking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakTracking.Click
        Dim frmCetak As New frmCetakNoTracing

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dtAlat As New DataTable
        dtAlat = Me.cssdServ.GetReportNoTracing_ByItem(IdDetailOrder)
        InProcFactory.CloseChannel(Me.cssdServ)

        For i As Integer = 0 To dtAlat.Rows.Count - 1
            Dim img As Image = Code128Rendering.MakeBarcodeImage(dtAlat.Rows(0)("NoTracing").ToString, 1, False)
            Dim ms As New MemoryStream
            img.Save(ms, Imaging.ImageFormat.Bmp)
            Dim byt() As Byte = ms.ToArray
            dtAlat.Rows(0)("barcode") = byt
        Next

        frmCetak.dt = dtAlat
        'frmCetak.label_type = dtAlat.Rows(0)("label_type").ToString
        frmCetak.ShowDialog()
    End Sub

    Private Sub btnCetakReuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakReuse.Click
        Dim frmCetak As New frmCetakNoReuse

        Me.cssdServ = InProcFactory.CreateChannel(Of CSSDOrderService, ICSSDOrderService)()
        Dim dt As New DataTable
        dt = Me.cssdServ.GetReportNoReuse_ByItem(IdDetailOrder)
        InProcFactory.CloseChannel(Me.cssdServ)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim img As Image = Code128Rendering.MakeBarcodeImage(dt.Rows(0)("Kode_Identifikasi_Alat").ToString, 1, False)
            Dim ms As New MemoryStream
            img.Save(ms, Imaging.ImageFormat.Bmp)
            Dim byt() As Byte = ms.ToArray

            dt.Rows(0)("barcode") = byt
        Next

        frmCetak.dt = dt
        frmCetak.ShowDialog()
    End Sub
End Class