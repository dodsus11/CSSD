<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMasterSetInstrumenAdd
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnFooter = New UILibs.BtnSaveTemplate()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTglExpired = New System.Windows.Forms.TextBox()
        Me.nudRevisi = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpRevisi = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLookLokasiFoto = New C1.Win.C1Input.C1Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPathFoto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStandarKasa = New System.Windows.Forms.TextBox()
        Me.btnLookSatuan = New C1.Win.C1Input.C1Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNamaSetInstrumen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeSetInstrumen = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelFoto = New System.Windows.Forms.Panel()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvInstrumen = New System.Windows.Forms.DataGridView()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.pnTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nudRevisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelFoto.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvInstrumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 379)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(1178, 50)
        Me.btnFooter.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Input Data Master Set Instrumen"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(1178, 43)
        Me.pnTop.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTglExpired)
        Me.Panel1.Controls.Add(Me.nudRevisi)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dtpRevisi)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnLookLokasiFoto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtPathFoto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtStandarKasa)
        Me.Panel1.Controls.Add(Me.btnLookSatuan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSatuan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBerat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtKeterangan)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNamaSetInstrumen)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKodeSetInstrumen)
        Me.Panel1.Location = New System.Drawing.Point(15, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 250)
        Me.Panel1.TabIndex = 80
        '
        'txtTglExpired
        '
        Me.txtTglExpired.Location = New System.Drawing.Point(146, 111)
        Me.txtTglExpired.Name = "txtTglExpired"
        Me.txtTglExpired.ReadOnly = True
        Me.txtTglExpired.Size = New System.Drawing.Size(142, 20)
        Me.txtTglExpired.TabIndex = 98
        '
        'nudRevisi
        '
        Me.nudRevisi.Location = New System.Drawing.Point(645, 43)
        Me.nudRevisi.Name = "nudRevisi"
        Me.nudRevisi.Size = New System.Drawing.Size(103, 20)
        Me.nudRevisi.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(543, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 14)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Revisi Ke"
        '
        'dtpRevisi
        '
        Me.dtpRevisi.CustomFormat = "dd/MM/yyyy"
        Me.dtpRevisi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRevisi.Location = New System.Drawing.Point(645, 10)
        Me.dtpRevisi.Name = "dtpRevisi"
        Me.dtpRevisi.Size = New System.Drawing.Size(103, 20)
        Me.dtpRevisi.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(543, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 14)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Tanggal Revisi"
        '
        'btnLookLokasiFoto
        '
        Me.btnLookLokasiFoto.Location = New System.Drawing.Point(440, 166)
        Me.btnLookLokasiFoto.Name = "btnLookLokasiFoto"
        Me.btnLookLokasiFoto.Size = New System.Drawing.Size(46, 22)
        Me.btnLookLokasiFoto.TabIndex = 7
        Me.btnLookLokasiFoto.Text = "..."
        Me.btnLookLokasiFoto.UseVisualStyleBackColor = True
        Me.btnLookLokasiFoto.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookLokasiFoto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Lokasi Foto"
        '
        'txtPathFoto
        '
        Me.txtPathFoto.Location = New System.Drawing.Point(146, 167)
        Me.txtPathFoto.Name = "txtPathFoto"
        Me.txtPathFoto.ReadOnly = True
        Me.txtPathFoto.Size = New System.Drawing.Size(289, 20)
        Me.txtPathFoto.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 14)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Standar Kasa"
        '
        'txtStandarKasa
        '
        Me.txtStandarKasa.Location = New System.Drawing.Point(146, 140)
        Me.txtStandarKasa.Name = "txtStandarKasa"
        Me.txtStandarKasa.Size = New System.Drawing.Size(142, 20)
        Me.txtStandarKasa.TabIndex = 5
        '
        'btnLookSatuan
        '
        Me.btnLookSatuan.Location = New System.Drawing.Point(294, 85)
        Me.btnLookSatuan.Name = "btnLookSatuan"
        Me.btnLookSatuan.Size = New System.Drawing.Size(46, 22)
        Me.btnLookSatuan.TabIndex = 4
        Me.btnLookSatuan.Text = "..."
        Me.btnLookSatuan.UseVisualStyleBackColor = True
        Me.btnLookSatuan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookSatuan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(146, 85)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.ReadOnly = True
        Me.txtSatuan.Size = New System.Drawing.Size(142, 20)
        Me.txtSatuan.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 14)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Berat"
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(146, 59)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(142, 20)
        Me.txtBerat.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 14)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(146, 196)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(289, 20)
        Me.txtKeterangan.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 14)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Nama Set Instrumen"
        '
        'txtNamaSetInstrumen
        '
        Me.txtNamaSetInstrumen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaSetInstrumen.Location = New System.Drawing.Point(146, 35)
        Me.txtNamaSetInstrumen.Name = "txtNamaSetInstrumen"
        Me.txtNamaSetInstrumen.Size = New System.Drawing.Size(366, 20)
        Me.txtNamaSetInstrumen.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 14)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Tanggal Expired"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Set Instrumen"
        '
        'txtKodeSetInstrumen
        '
        Me.txtKodeSetInstrumen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKodeSetInstrumen.Location = New System.Drawing.Point(146, 7)
        Me.txtKodeSetInstrumen.Name = "txtKodeSetInstrumen"
        Me.txtKodeSetInstrumen.Size = New System.Drawing.Size(134, 20)
        Me.txtKodeSetInstrumen.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PanelFoto)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1178, 274)
        Me.Panel2.TabIndex = 81
        '
        'PanelFoto
        '
        Me.PanelFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFoto.Controls.Add(Me.pbPhoto)
        Me.PanelFoto.Location = New System.Drawing.Point(828, 6)
        Me.PanelFoto.Name = "PanelFoto"
        Me.PanelFoto.Size = New System.Drawing.Size(175, 250)
        Me.PanelFoto.TabIndex = 91
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(3, 3)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(167, 242)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 76
        Me.pbPhoto.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.dgvInstrumen)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1178, 62)
        Me.Panel3.TabIndex = 82
        '
        'dgvInstrumen
        '
        Me.dgvInstrumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInstrumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInstrumen.Location = New System.Drawing.Point(0, 0)
        Me.dgvInstrumen.Name = "dgvInstrumen"
        Me.dgvInstrumen.Size = New System.Drawing.Size(1178, 62)
        Me.dgvInstrumen.TabIndex = 0
        '
        'ofd
        '
        Me.ofd.FileName = "Lokasi Foto Instrumen"
        '
        'ucMasterSetInstrumenAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnFooter)
        Me.Controls.Add(Me.pnTop)
        Me.Name = "ucMasterSetInstrumenAdd"
        Me.Size = New System.Drawing.Size(1178, 429)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudRevisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanelFoto.ResumeLayout(False)
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvInstrumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFooter As UILibs.BtnSaveTemplate
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSetInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSetInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvInstrumen As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents btnLookSatuan As C1.Win.C1Input.C1Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStandarKasa As System.Windows.Forms.TextBox
    Friend WithEvents PanelFoto As System.Windows.Forms.Panel
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnLookLokasiFoto As C1.Win.C1Input.C1Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPathFoto As System.Windows.Forms.TextBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents nudRevisi As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpRevisi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTglExpired As System.Windows.Forms.TextBox

End Class
