<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOrderSterilisasi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtJml = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblReuse = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblJenisAlat = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLookDetail = New C1.Win.C1Input.C1Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.btnLookInven = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoInvent = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCetakTracking = New System.Windows.Forms.Button()
        Me.btnCetakReuse = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.txtJml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnCetakReuse)
        Me.Panel1.Controls.Add(Me.btnCetakTracking)
        Me.Panel1.Controls.Add(Me.txtJml)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnLookDetail)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtKet)
        Me.Panel1.Controls.Add(Me.lblSatuan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtBerat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKode)
        Me.Panel1.Controls.Add(Me.btnLookInven)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNoInvent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 304)
        Me.Panel1.TabIndex = 1
        '
        'txtJml
        '
        Me.txtJml.BackColor = System.Drawing.Color.Aqua
        Me.txtJml.Location = New System.Drawing.Point(130, 108)
        Me.txtJml.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtJml.Name = "txtJml"
        Me.txtJml.Size = New System.Drawing.Size(48, 20)
        Me.txtJml.TabIndex = 96
        Me.txtJml.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel3.Controls.Add(Me.lblReuse)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblJenisAlat)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(401, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(226, 47)
        Me.Panel3.TabIndex = 95
        '
        'lblReuse
        '
        Me.lblReuse.AutoSize = True
        Me.lblReuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReuse.Location = New System.Drawing.Point(90, 26)
        Me.lblReuse.Name = "lblReuse"
        Me.lblReuse.Size = New System.Drawing.Size(11, 15)
        Me.lblReuse.TabIndex = 96
        Me.lblReuse.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Kode Reuse : "
        '
        'lblJenisAlat
        '
        Me.lblJenisAlat.AutoSize = True
        Me.lblJenisAlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisAlat.Location = New System.Drawing.Point(90, 6)
        Me.lblJenisAlat.Name = "lblJenisAlat"
        Me.lblJenisAlat.Size = New System.Drawing.Size(11, 15)
        Me.lblJenisAlat.TabIndex = 94
        Me.lblJenisAlat.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Jenis Alat :"
        '
        'btnLookDetail
        '
        Me.btnLookDetail.Location = New System.Drawing.Point(278, 51)
        Me.btnLookDetail.Name = "btnLookDetail"
        Me.btnLookDetail.Size = New System.Drawing.Size(70, 22)
        Me.btnLookDetail.TabIndex = 93
        Me.btnLookDetail.Text = "Detail Alat"
        Me.btnLookDetail.UseVisualStyleBackColor = True
        Me.btnLookDetail.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookDetail.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Keterangan"
        '
        'txtKet
        '
        Me.txtKet.BackColor = System.Drawing.Color.Aqua
        Me.txtKet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKet.Location = New System.Drawing.Point(130, 163)
        Me.txtKet.Multiline = True
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(385, 76)
        Me.txtKet.TabIndex = 90
        '
        'lblSatuan
        '
        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatuan.Location = New System.Drawing.Point(199, 138)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(12, 16)
        Me.lblSatuan.TabIndex = 89
        Me.lblSatuan.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Berat"
        '
        'txtBerat
        '
        Me.txtBerat.BackColor = System.Drawing.Color.Aqua
        Me.txtBerat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBerat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBerat.Location = New System.Drawing.Point(130, 135)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(65, 22)
        Me.txtBerat.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Nama Alat"
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        Me.txtNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(130, 79)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(296, 22)
        Me.txtNama.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Kode Alat"
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.Color.White
        Me.txtKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(130, 51)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(145, 22)
        Me.txtKode.TabIndex = 81
        '
        'btnLookInven
        '
        Me.btnLookInven.Location = New System.Drawing.Point(278, 23)
        Me.btnLookInven.Name = "btnLookInven"
        Me.btnLookInven.Size = New System.Drawing.Size(46, 22)
        Me.btnLookInven.TabIndex = 80
        Me.btnLookInven.Text = "......"
        Me.btnLookInven.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLookInven.UseVisualStyleBackColor = True
        Me.btnLookInven.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookInven.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "No. Inventory"
        '
        'txtNoInvent
        '
        Me.txtNoInvent.BackColor = System.Drawing.Color.White
        Me.txtNoInvent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoInvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoInvent.Location = New System.Drawing.Point(130, 23)
        Me.txtNoInvent.Name = "txtNoInvent"
        Me.txtNoInvent.ReadOnly = True
        Me.txtNoInvent.Size = New System.Drawing.Size(145, 22)
        Me.txtNoInvent.TabIndex = 78
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 53)
        Me.Panel2.TabIndex = 2
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.CadetBlue
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(102, 15)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(81, 25)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.CadetBlue
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(537, 15)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(81, 25)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.CadetBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(12, 15)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 25)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnCetakTracking
        '
        Me.btnCetakTracking.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCetakTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetakTracking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakTracking.Location = New System.Drawing.Point(130, 262)
        Me.btnCetakTracking.Name = "btnCetakTracking"
        Me.btnCetakTracking.Size = New System.Drawing.Size(127, 25)
        Me.btnCetakTracking.TabIndex = 97
        Me.btnCetakTracking.Text = "Cetak Label Tracing"
        Me.btnCetakTracking.UseVisualStyleBackColor = False
        '
        'btnCetakReuse
        '
        Me.btnCetakReuse.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCetakReuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetakReuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakReuse.Location = New System.Drawing.Point(263, 262)
        Me.btnCetakReuse.Name = "btnCetakReuse"
        Me.btnCetakReuse.Size = New System.Drawing.Size(127, 25)
        Me.btnCetakReuse.TabIndex = 98
        Me.btnCetakReuse.Text = "Cetak Label Reuse"
        Me.btnCetakReuse.UseVisualStyleBackColor = False
        '
        'dlgOrderSterilisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 357)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOrderSterilisasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item ALKES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtJml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnLookInven As C1.Win.C1Input.C1Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoInvent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblSatuan As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents btnLookDetail As C1.Win.C1Input.C1Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblReuse As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblJenisAlat As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJml As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCetakTracking As System.Windows.Forms.Button
    Friend WithEvents btnCetakReuse As System.Windows.Forms.Button
End Class
