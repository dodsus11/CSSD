<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSetupPetugasAdd
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
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCetakBarcode = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodePetugas = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugas = New System.Windows.Forms.TextBox()
        Me.btnFooter = New UILibs.BtnSaveTemplate()
        Me.pnTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(853, 43)
        Me.pnTop.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Input Data Petugas"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCetakBarcode)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNIP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtKodePetugas)
        Me.Panel1.Controls.Add(Me.txtNamaPetugas)
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 172)
        Me.Panel1.TabIndex = 72
        '
        'btnCetakBarcode
        '
        Me.btnCetakBarcode.Location = New System.Drawing.Point(464, 127)
        Me.btnCetakBarcode.Name = "btnCetakBarcode"
        Me.btnCetakBarcode.Size = New System.Drawing.Size(136, 31)
        Me.btnCetakBarcode.TabIndex = 83
        Me.btnCetakBarcode.Text = "Cetak Barcode"
        Me.btnCetakBarcode.UseVisualStyleBackColor = True
        Me.btnCetakBarcode.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnCetakBarcode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 14)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "NIP"
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(148, 68)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(134, 20)
        Me.txtNIP.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Petugas"
        '
        'txtKodePetugas
        '
        Me.txtKodePetugas.Location = New System.Drawing.Point(148, 10)
        Me.txtKodePetugas.Name = "txtKodePetugas"
        Me.txtKodePetugas.Size = New System.Drawing.Size(134, 20)
        Me.txtKodePetugas.TabIndex = 51
        '
        'txtNamaPetugas
        '
        Me.txtNamaPetugas.Location = New System.Drawing.Point(148, 38)
        Me.txtNamaPetugas.Name = "txtNamaPetugas"
        Me.txtNamaPetugas.Size = New System.Drawing.Size(289, 20)
        Me.txtNamaPetugas.TabIndex = 52
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 384)
        Me.btnFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(853, 50)
        Me.btnFooter.TabIndex = 70
        '
        'ucSetupPetugasAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFooter)
        Me.Name = "ucSetupPetugasAdd"
        Me.Size = New System.Drawing.Size(853, 434)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodePetugas As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPetugas As System.Windows.Forms.TextBox
    Friend WithEvents btnFooter As UILibs.BtnSaveTemplate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents btnCetakBarcode As C1.Win.C1Input.C1Button

End Class
