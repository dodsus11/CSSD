<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSetupMasterInstrumenAdd
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLookSatuan = New C1.Win.C1Input.C1Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdInstrumen = New System.Windows.Forms.TextBox()
        Me.btnLookLokasiFoto = New C1.Win.C1Input.C1Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeInstrumen = New System.Windows.Forms.TextBox()
        Me.txtNamaInstrumen = New System.Windows.Forms.TextBox()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFooter = New UILibs.BtnSaveTemplate()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.PanelFoto = New System.Windows.Forms.Panel()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.txtPathFoto = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.pnTop.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPathFoto)
        Me.Panel1.Controls.Add(Me.btnLookSatuan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSatuan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtIdInstrumen)
        Me.Panel1.Controls.Add(Me.btnLookLokasiFoto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtBerat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtKodeInstrumen)
        Me.Panel1.Controls.Add(Me.txtNamaInstrumen)
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 228)
        Me.Panel1.TabIndex = 75
        '
        'btnLookSatuan
        '
        Me.btnLookSatuan.Location = New System.Drawing.Point(306, 112)
        Me.btnLookSatuan.Name = "btnLookSatuan"
        Me.btnLookSatuan.Size = New System.Drawing.Size(46, 22)
        Me.btnLookSatuan.TabIndex = 89
        Me.btnLookSatuan.Text = "..."
        Me.btnLookSatuan.UseVisualStyleBackColor = True
        Me.btnLookSatuan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookSatuan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(158, 112)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.ReadOnly = True
        Me.txtSatuan.Size = New System.Drawing.Size(142, 20)
        Me.txtSatuan.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Berat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Id Instrumen (system)"
        '
        'txtIdInstrumen
        '
        Me.txtIdInstrumen.Location = New System.Drawing.Point(158, 8)
        Me.txtIdInstrumen.Name = "txtIdInstrumen"
        Me.txtIdInstrumen.ReadOnly = True
        Me.txtIdInstrumen.Size = New System.Drawing.Size(134, 20)
        Me.txtIdInstrumen.TabIndex = 80
        '
        'btnLookLokasiFoto
        '
        Me.btnLookLokasiFoto.Location = New System.Drawing.Point(453, 138)
        Me.btnLookLokasiFoto.Name = "btnLookLokasiFoto"
        Me.btnLookLokasiFoto.Size = New System.Drawing.Size(46, 22)
        Me.btnLookLokasiFoto.TabIndex = 78
        Me.btnLookLokasiFoto.Text = "..."
        Me.btnLookLokasiFoto.UseVisualStyleBackColor = True
        Me.btnLookLokasiFoto.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookLokasiFoto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Lokasi Foto"
        '
        'txtBerat
        '
        Me.txtBerat.BackColor = System.Drawing.SystemColors.Window
        Me.txtBerat.Location = New System.Drawing.Point(158, 86)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(142, 20)
        Me.txtBerat.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Instrumen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Instrumen"
        '
        'txtKodeInstrumen
        '
        Me.txtKodeInstrumen.Location = New System.Drawing.Point(158, 34)
        Me.txtKodeInstrumen.Name = "txtKodeInstrumen"
        Me.txtKodeInstrumen.Size = New System.Drawing.Size(134, 20)
        Me.txtKodeInstrumen.TabIndex = 51
        '
        'txtNamaInstrumen
        '
        Me.txtNamaInstrumen.Location = New System.Drawing.Point(158, 60)
        Me.txtNamaInstrumen.Name = "txtNamaInstrumen"
        Me.txtNamaInstrumen.Size = New System.Drawing.Size(450, 20)
        Me.txtNamaInstrumen.TabIndex = 52
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(973, 43)
        Me.pnTop.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Input Data Master Instrumen"
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 390)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(973, 50)
        Me.btnFooter.TabIndex = 73
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(3, 3)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(176, 218)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 76
        Me.pbPhoto.TabStop = False
        '
        'PanelFoto
        '
        Me.PanelFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFoto.Controls.Add(Me.pbPhoto)
        Me.PanelFoto.Location = New System.Drawing.Point(641, 49)
        Me.PanelFoto.Name = "PanelFoto"
        Me.PanelFoto.Size = New System.Drawing.Size(185, 228)
        Me.PanelFoto.TabIndex = 77
        '
        'ofd
        '
        Me.ofd.FileName = "lokasi foto instrumen"
        '
        'txtPathFoto
        '
        Me.txtPathFoto.Location = New System.Drawing.Point(158, 138)
        Me.txtPathFoto.Name = "txtPathFoto"
        Me.txtPathFoto.ReadOnly = True
        Me.txtPathFoto.Size = New System.Drawing.Size(289, 20)
        Me.txtPathFoto.TabIndex = 93
        '
        'ucSetupMasterInstrumenAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelFoto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.btnFooter)
        Me.Name = "ucSetupMasterInstrumenAdd"
        Me.Size = New System.Drawing.Size(973, 440)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnFooter As UILibs.BtnSaveTemplate
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents btnLookLokasiFoto As C1.Win.C1Input.C1Button
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents PanelFoto As System.Windows.Forms.Panel
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdInstrumen As System.Windows.Forms.TextBox
    Friend WithEvents btnLookSatuan As C1.Win.C1Input.C1Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPathFoto As System.Windows.Forms.TextBox

End Class
