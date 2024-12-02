<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGudangAdd
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
        Me.btnLookRuang = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTelp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaGudang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeGudang = New System.Windows.Forms.TextBox()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFooter = New UILibs.BtnSaveTemplate()
        Me.Panel1.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLookRuang)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtTelp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNamaGudang)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKodeGudang)
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 102)
        Me.Panel1.TabIndex = 78
        '
        'btnLookRuang
        '
        Me.btnLookRuang.Location = New System.Drawing.Point(221, 6)
        Me.btnLookRuang.Name = "btnLookRuang"
        Me.btnLookRuang.Size = New System.Drawing.Size(46, 22)
        Me.btnLookRuang.TabIndex = 56
        Me.btnLookRuang.Text = "..."
        Me.btnLookRuang.UseVisualStyleBackColor = True
        Me.btnLookRuang.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookRuang.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Telp"
        '
        'TxtTelp
        '
        Me.TxtTelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelp.Location = New System.Drawing.Point(107, 59)
        Me.TxtTelp.Name = "TxtTelp"
        Me.TxtTelp.Size = New System.Drawing.Size(147, 20)
        Me.TxtTelp.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nama Ruang"
        '
        'txtNamaGudang
        '
        Me.txtNamaGudang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaGudang.Location = New System.Drawing.Point(107, 33)
        Me.txtNamaGudang.Name = "txtNamaGudang"
        Me.txtNamaGudang.Size = New System.Drawing.Size(307, 20)
        Me.txtNamaGudang.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Ruang"
        '
        'txtKodeGudang
        '
        Me.txtKodeGudang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKodeGudang.Location = New System.Drawing.Point(107, 8)
        Me.txtKodeGudang.Name = "txtKodeGudang"
        Me.txtKodeGudang.Size = New System.Drawing.Size(108, 20)
        Me.txtKodeGudang.TabIndex = 51
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(770, 43)
        Me.pnTop.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Input Data Ruang"
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 436)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(770, 50)
        Me.btnFooter.TabIndex = 76
        '
        'ucGudangAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.btnFooter)
        Me.Name = "ucGudangAdd"
        Me.Size = New System.Drawing.Size(770, 486)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaGudang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeGudang As System.Windows.Forms.TextBox
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnFooter As UILibs.BtnSaveTemplate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTelp As System.Windows.Forms.TextBox
    Friend WithEvents btnLookRuang As C1.Win.C1Input.C1Button

End Class
