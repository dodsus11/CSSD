<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMesinAdd
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMerekMesin = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCetakBarcode = New C1.Win.C1Input.C1Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLookKelompok = New C1.Win.C1Input.C1Button()
        Me.txtKodeKelompokMesin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNamaKelompokMesin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaVendor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeMesin = New System.Windows.Forms.TextBox()
        Me.txtNamaMesin = New System.Windows.Forms.TextBox()
        Me.btnFooter = New UILibs.BtnSaveTemplate()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTglPengadaan = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Merk Mesin"
        '
        'txtMerekMesin
        '
        Me.txtMerekMesin.Location = New System.Drawing.Point(197, 81)
        Me.txtMerekMesin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMerekMesin.Name = "txtMerekMesin"
        Me.txtMerekMesin.Size = New System.Drawing.Size(199, 22)
        Me.txtMerekMesin.TabIndex = 69
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtpTglPengadaan)
        Me.Panel1.Controls.Add(Me.btnCetakBarcode)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTipe)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnLookKelompok)
        Me.Panel1.Controls.Add(Me.txtKodeKelompokMesin)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNamaKelompokMesin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMerekMesin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNamaVendor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtKodeMesin)
        Me.Panel1.Controls.Add(Me.txtNamaMesin)
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1081, 376)
        Me.Panel1.TabIndex = 75
        '
        'btnCetakBarcode
        '
        Me.btnCetakBarcode.Location = New System.Drawing.Point(872, 321)
        Me.btnCetakBarcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCetakBarcode.Name = "btnCetakBarcode"
        Me.btnCetakBarcode.Size = New System.Drawing.Size(181, 38)
        Me.btnCetakBarcode.TabIndex = 82
        Me.btnCetakBarcode.Text = "Cetak Barcode"
        Me.btnCetakBarcode.UseVisualStyleBackColor = True
        Me.btnCetakBarcode.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnCetakBarcode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Tipe"
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(300, 218)
        Me.txtTipe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.ReadOnly = True
        Me.txtTipe.Size = New System.Drawing.Size(256, 22)
        Me.txtTipe.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 153)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 18)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Tgl Pengadaan"
        '
        'btnLookKelompok
        '
        Me.btnLookKelompok.Location = New System.Drawing.Point(565, 186)
        Me.btnLookKelompok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLookKelompok.Name = "btnLookKelompok"
        Me.btnLookKelompok.Size = New System.Drawing.Size(61, 27)
        Me.btnLookKelompok.TabIndex = 77
        Me.btnLookKelompok.Text = "..."
        Me.btnLookKelompok.UseVisualStyleBackColor = True
        Me.btnLookKelompok.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookKelompok.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtKodeKelompokMesin
        '
        Me.txtKodeKelompokMesin.Location = New System.Drawing.Point(197, 186)
        Me.txtKodeKelompokMesin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKodeKelompokMesin.Name = "txtKodeKelompokMesin"
        Me.txtKodeKelompokMesin.ReadOnly = True
        Me.txtKodeKelompokMesin.Size = New System.Drawing.Size(93, 22)
        Me.txtKodeKelompokMesin.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 185)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 18)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Kelompok Mesin"
        '
        'txtNamaKelompokMesin
        '
        Me.txtNamaKelompokMesin.Location = New System.Drawing.Point(300, 186)
        Me.txtNamaKelompokMesin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaKelompokMesin.Name = "txtNamaKelompokMesin"
        Me.txtNamaKelompokMesin.ReadOnly = True
        Me.txtNamaKelompokMesin.Size = New System.Drawing.Size(256, 22)
        Me.txtNamaKelompokMesin.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 18)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Nama Vendor"
        '
        'txtNamaVendor
        '
        Me.txtNamaVendor.Location = New System.Drawing.Point(197, 118)
        Me.txtNamaVendor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaVendor.Name = "txtNamaVendor"
        Me.txtNamaVendor.Size = New System.Drawing.Size(177, 22)
        Me.txtNamaVendor.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Mesin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Mesin"
        '
        'txtKodeMesin
        '
        Me.txtKodeMesin.Location = New System.Drawing.Point(197, 12)
        Me.txtKodeMesin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKodeMesin.Name = "txtKodeMesin"
        Me.txtKodeMesin.Size = New System.Drawing.Size(177, 22)
        Me.txtKodeMesin.TabIndex = 51
        '
        'txtNamaMesin
        '
        Me.txtNamaMesin.Location = New System.Drawing.Point(197, 47)
        Me.txtNamaMesin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaMesin.Name = "txtNamaMesin"
        Me.txtNamaMesin.Size = New System.Drawing.Size(384, 22)
        Me.txtNamaMesin.TabIndex = 52
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 596)
        Me.btnFooter.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(1157, 62)
        Me.btnFooter.TabIndex = 73
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(1157, 53)
        Me.pnTop.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(16, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Input Data Mesin"
        '
        'dtpTglPengadaan
        '
        Me.dtpTglPengadaan.CustomFormat = "dd/MM/yyyy"
        Me.dtpTglPengadaan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglPengadaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglPengadaan.Location = New System.Drawing.Point(197, 151)
        Me.dtpTglPengadaan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTglPengadaan.Name = "dtpTglPengadaan"
        Me.dtpTglPengadaan.Size = New System.Drawing.Size(172, 27)
        Me.dtpTglPengadaan.TabIndex = 130
        '
        'ucMesinAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFooter)
        Me.Controls.Add(Me.pnTop)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucMesinAdd"
        Me.Size = New System.Drawing.Size(1157, 658)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMerekMesin As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaVendor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMesin As System.Windows.Forms.TextBox
    Friend WithEvents btnFooter As UILibs.BtnSaveTemplate
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKodeKelompokMesin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNamaKelompokMesin As System.Windows.Forms.TextBox
    Friend WithEvents btnLookKelompok As C1.Win.C1Input.C1Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTipe As System.Windows.Forms.TextBox
    Friend WithEvents btnCetakBarcode As C1.Win.C1Input.C1Button
    Friend WithEvents dtpTglPengadaan As System.Windows.Forms.DateTimePicker

End Class
