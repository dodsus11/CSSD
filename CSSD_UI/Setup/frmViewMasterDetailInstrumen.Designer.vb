<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMasterDetailInstrumen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pbPhotoInstrumen = New System.Windows.Forms.PictureBox()
        Me.PanelFoto = New System.Windows.Forms.Panel()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTglExpired = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStandarKasa = New System.Windows.Forms.TextBox()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvInstrumen = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pbPhotoInstrumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFoto.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvInstrumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(953, 43)
        Me.pnTop.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Detail Master Set Instrumen"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.PanelFoto)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 245)
        Me.Panel2.TabIndex = 82
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.pbPhotoInstrumen)
        Me.Panel5.Location = New System.Drawing.Point(766, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(175, 222)
        Me.Panel5.TabIndex = 94
        '
        'pbPhotoInstrumen
        '
        Me.pbPhotoInstrumen.Location = New System.Drawing.Point(3, 3)
        Me.pbPhotoInstrumen.Name = "pbPhotoInstrumen"
        Me.pbPhotoInstrumen.Size = New System.Drawing.Size(167, 214)
        Me.pbPhotoInstrumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhotoInstrumen.TabIndex = 76
        Me.pbPhotoInstrumen.TabStop = False
        '
        'PanelFoto
        '
        Me.PanelFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFoto.Controls.Add(Me.pbPhoto)
        Me.PanelFoto.Location = New System.Drawing.Point(557, 6)
        Me.PanelFoto.Name = "PanelFoto"
        Me.PanelFoto.Size = New System.Drawing.Size(175, 222)
        Me.PanelFoto.TabIndex = 93
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(3, 3)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(167, 214)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 76
        Me.pbPhoto.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTglExpired)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtStandarKasa)
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
        Me.Panel1.Size = New System.Drawing.Size(536, 222)
        Me.Panel1.TabIndex = 92
        '
        'txtTglExpired
        '
        Me.txtTglExpired.Location = New System.Drawing.Point(146, 111)
        Me.txtTglExpired.Name = "txtTglExpired"
        Me.txtTglExpired.ReadOnly = True
        Me.txtTglExpired.Size = New System.Drawing.Size(142, 20)
        Me.txtTglExpired.TabIndex = 91
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
        Me.txtStandarKasa.ReadOnly = True
        Me.txtStandarKasa.Size = New System.Drawing.Size(142, 20)
        Me.txtStandarKasa.TabIndex = 89
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
        Me.txtBerat.ReadOnly = True
        Me.txtBerat.Size = New System.Drawing.Size(142, 20)
        Me.txtBerat.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 14)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(146, 166)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ReadOnly = True
        Me.txtKeterangan.Size = New System.Drawing.Size(366, 20)
        Me.txtKeterangan.TabIndex = 3
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
        Me.txtNamaSetInstrumen.Location = New System.Drawing.Point(146, 35)
        Me.txtNamaSetInstrumen.Name = "txtNamaSetInstrumen"
        Me.txtNamaSetInstrumen.ReadOnly = True
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
        Me.txtKodeSetInstrumen.Location = New System.Drawing.Point(146, 7)
        Me.txtKodeSetInstrumen.Name = "txtKodeSetInstrumen"
        Me.txtKodeSetInstrumen.ReadOnly = True
        Me.txtKodeSetInstrumen.Size = New System.Drawing.Size(134, 20)
        Me.txtKodeSetInstrumen.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.dgvInstrumen)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 288)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(953, 152)
        Me.Panel3.TabIndex = 83
        '
        'dgvInstrumen
        '
        Me.dgvInstrumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInstrumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInstrumen.Location = New System.Drawing.Point(0, 0)
        Me.dgvInstrumen.Name = "dgvInstrumen"
        Me.dgvInstrumen.Size = New System.Drawing.Size(953, 152)
        Me.dgvInstrumen.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 440)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(953, 37)
        Me.Panel4.TabIndex = 83
        '
        'frmViewMasterDetailInstrumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 477)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewMasterDetailInstrumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Setup] Detail Set Instrumen (Tromol)"
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.pbPhotoInstrumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFoto.ResumeLayout(False)
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvInstrumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvInstrumen As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PanelFoto As System.Windows.Forms.Panel
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStandarKasa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSetInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSetInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents txtTglExpired As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pbPhotoInstrumen As System.Windows.Forms.PictureBox
End Class
