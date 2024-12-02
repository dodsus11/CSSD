<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucInventoryAdd
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
        Me.btnLookJenis = New C1.Win.C1Input.C1Button()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoInventory = New System.Windows.Forms.TextBox()
        Me.btnLookAlat = New C1.Win.C1Input.C1Button()
        Me.txtNamaAlat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeAlat = New System.Windows.Forms.TextBox()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFooter = New UILibs.BtnSaveTemplate()
        Me.LblMax = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        Me.pnTop.SuspendLayout()
        CType(Me.txtMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtMax)
        Me.Panel1.Controls.Add(Me.LblMax)
        Me.Panel1.Controls.Add(Me.btnLookJenis)
        Me.Panel1.Controls.Add(Me.txtJenis)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNoInventory)
        Me.Panel1.Controls.Add(Me.btnLookAlat)
        Me.Panel1.Controls.Add(Me.txtNamaAlat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKodeAlat)
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 177)
        Me.Panel1.TabIndex = 78
        '
        'btnLookJenis
        '
        Me.btnLookJenis.Location = New System.Drawing.Point(307, 47)
        Me.btnLookJenis.Name = "btnLookJenis"
        Me.btnLookJenis.Size = New System.Drawing.Size(46, 22)
        Me.btnLookJenis.TabIndex = 86
        Me.btnLookJenis.Text = "..."
        Me.btnLookJenis.UseVisualStyleBackColor = True
        Me.btnLookJenis.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookJenis.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(107, 47)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.ReadOnly = True
        Me.txtJenis.Size = New System.Drawing.Size(194, 20)
        Me.txtJenis.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 14)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "No. Inventory"
        '
        'txtNoInventory
        '
        Me.txtNoInventory.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtNoInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoInventory.Location = New System.Drawing.Point(107, 13)
        Me.txtNoInventory.Name = "txtNoInventory"
        Me.txtNoInventory.ReadOnly = True
        Me.txtNoInventory.Size = New System.Drawing.Size(194, 26)
        Me.txtNoInventory.TabIndex = 82
        '
        'btnLookAlat
        '
        Me.btnLookAlat.Location = New System.Drawing.Point(503, 73)
        Me.btnLookAlat.Name = "btnLookAlat"
        Me.btnLookAlat.Size = New System.Drawing.Size(46, 22)
        Me.btnLookAlat.TabIndex = 78
        Me.btnLookAlat.Text = "..."
        Me.btnLookAlat.UseVisualStyleBackColor = True
        Me.btnLookAlat.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookAlat.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtNamaAlat
        '
        Me.txtNamaAlat.Location = New System.Drawing.Point(189, 73)
        Me.txtNamaAlat.Name = "txtNamaAlat"
        Me.txtNamaAlat.ReadOnly = True
        Me.txtNamaAlat.Size = New System.Drawing.Size(308, 20)
        Me.txtNamaAlat.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Alat"
        '
        'txtKodeAlat
        '
        Me.txtKodeAlat.Location = New System.Drawing.Point(107, 73)
        Me.txtKodeAlat.Name = "txtKodeAlat"
        Me.txtKodeAlat.ReadOnly = True
        Me.txtKodeAlat.Size = New System.Drawing.Size(76, 20)
        Me.txtKodeAlat.TabIndex = 51
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(880, 43)
        Me.pnTop.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Input Inventory"
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 299)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(880, 50)
        Me.btnFooter.TabIndex = 76
        '
        'LblMax
        '
        Me.LblMax.AutoSize = True
        Me.LblMax.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMax.Location = New System.Drawing.Point(3, 102)
        Me.LblMax.Name = "LblMax"
        Me.LblMax.Size = New System.Drawing.Size(81, 14)
        Me.LblMax.TabIndex = 87
        Me.LblMax.Text = "Max Re-Use"
        Me.LblMax.Visible = False
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(107, 101)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(48, 20)
        Me.txtMax.TabIndex = 89
        Me.txtMax.Visible = False
        '
        'ucInventoryAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.btnFooter)
        Me.Name = "ucInventoryAdd"
        Me.Size = New System.Drawing.Size(880, 349)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        CType(Me.txtMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeAlat As System.Windows.Forms.TextBox
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnFooter As UILibs.BtnSaveTemplate
    Friend WithEvents txtNamaAlat As System.Windows.Forms.TextBox
    Friend WithEvents btnLookAlat As C1.Win.C1Input.C1Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoInventory As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLookJenis As C1.Win.C1Input.C1Button
    Friend WithEvents txtJenis As System.Windows.Forms.TextBox
    Friend WithEvents LblMax As System.Windows.Forms.Label
    Friend WithEvents txtMax As System.Windows.Forms.NumericUpDown

End Class
