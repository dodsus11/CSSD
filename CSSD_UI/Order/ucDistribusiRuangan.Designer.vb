<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDistribusiRuangan
    Inherits UILibs.BaseControl

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
        Me.txtNoRM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLookupPasien = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaPasien = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoRegister = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRuang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnPetugasPengirim = New System.Windows.Forms.Panel()
        Me.btnlookPetugasKirim = New System.Windows.Forms.Button()
        Me.txtPetugasKirim = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnPetugasPenerima = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPetugasPenerima = New System.Windows.Forms.TextBox()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnPetugasPengirim.SuspendLayout()
        Me.PnPetugasPenerima.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNoRM)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnLookupPasien)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNamaPasien)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNoRegister)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRuang)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtUmur)
        Me.Panel1.Location = New System.Drawing.Point(853, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 227)
        Me.Panel1.TabIndex = 92
        Me.Panel1.Visible = False
        '
        'txtNoRM
        '
        Me.txtNoRM.BackColor = System.Drawing.Color.Khaki
        Me.txtNoRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRM.Location = New System.Drawing.Point(189, 12)
        Me.txtNoRM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoRM.Name = "txtNoRM"
        Me.txtNoRM.ReadOnly = True
        Me.txtNoRM.Size = New System.Drawing.Size(215, 26)
        Me.txtNoRM.TabIndex = 124
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "No. RM"
        '
        'btnLookupPasien
        '
        Me.btnLookupPasien.Location = New System.Drawing.Point(413, 11)
        Me.btnLookupPasien.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookupPasien.Name = "btnLookupPasien"
        Me.btnLookupPasien.Size = New System.Drawing.Size(175, 28)
        Me.btnLookupPasien.TabIndex = 122
        Me.btnLookupPasien.Text = "Cari Pasien"
        Me.btnLookupPasien.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Nama Pasien"
        '
        'txtNamaPasien
        '
        Me.txtNamaPasien.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPasien.Location = New System.Drawing.Point(189, 82)
        Me.txtNamaPasien.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaPasien.Name = "txtNamaPasien"
        Me.txtNamaPasien.ReadOnly = True
        Me.txtNamaPasien.Size = New System.Drawing.Size(397, 26)
        Me.txtNamaPasien.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "No. Register"
        '
        'txtNoRegister
        '
        Me.txtNoRegister.BackColor = System.Drawing.Color.Khaki
        Me.txtNoRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRegister.Location = New System.Drawing.Point(189, 49)
        Me.txtNoRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoRegister.Name = "txtNoRegister"
        Me.txtNoRegister.ReadOnly = True
        Me.txtNoRegister.Size = New System.Drawing.Size(215, 26)
        Me.txtNoRegister.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Ruang"
        '
        'txtRuang
        '
        Me.txtRuang.BackColor = System.Drawing.Color.Khaki
        Me.txtRuang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuang.Location = New System.Drawing.Point(189, 150)
        Me.txtRuang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuang.Name = "txtRuang"
        Me.txtRuang.ReadOnly = True
        Me.txtRuang.Size = New System.Drawing.Size(484, 26)
        Me.txtRuang.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Umur"
        '
        'txtUmur
        '
        Me.txtUmur.BackColor = System.Drawing.Color.Khaki
        Me.txtUmur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUmur.Location = New System.Drawing.Point(189, 116)
        Me.txtUmur.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.ReadOnly = True
        Me.txtUmur.Size = New System.Drawing.Size(160, 26)
        Me.txtUmur.TabIndex = 96
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.btnSimpan)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 535)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1264, 66)
        Me.Panel4.TabIndex = 96
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnKeluar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(995, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 66)
        Me.Panel3.TabIndex = 4
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(35, 12)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(140, 43)
        Me.BtnKeluar.TabIndex = 1
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(104, 10)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(161, 42)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan [F5]"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(16, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(280, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Distribusi Instrumen Ke Ruangan"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pnPetugasPengirim)
        Me.Panel2.Controls.Add(Me.PnPetugasPenerima)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1264, 246)
        Me.Panel2.TabIndex = 97
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lblName)
        Me.Panel5.Controls.Add(Me.txtKodeBarcode)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(375, 246)
        Me.Panel5.TabIndex = 108
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tekan [F2] untuk fokus Scan"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(89, 82)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(184, 17)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "INPUT KODE ( TRACKING )"
        '
        'txtKodeBarcode
        '
        Me.txtKodeBarcode.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtKodeBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKodeBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarcode.Location = New System.Drawing.Point(48, 102)
        Me.txtKodeBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodeBarcode.Name = "txtKodeBarcode"
        Me.txtKodeBarcode.Size = New System.Drawing.Size(269, 29)
        Me.txtKodeBarcode.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SlateGray
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 37)
        Me.Panel6.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "[BARCODE SCAN]"
        '
        'pnPetugasPengirim
        '
        Me.pnPetugasPengirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnPetugasPengirim.Controls.Add(Me.btnlookPetugasKirim)
        Me.pnPetugasPengirim.Controls.Add(Me.txtPetugasKirim)
        Me.pnPetugasPengirim.Controls.Add(Me.Label8)
        Me.pnPetugasPengirim.Location = New System.Drawing.Point(383, 20)
        Me.pnPetugasPengirim.Margin = New System.Windows.Forms.Padding(4)
        Me.pnPetugasPengirim.Name = "pnPetugasPengirim"
        Me.pnPetugasPengirim.Size = New System.Drawing.Size(665, 59)
        Me.pnPetugasPengirim.TabIndex = 107
        '
        'btnlookPetugasKirim
        '
        Me.btnlookPetugasKirim.Location = New System.Drawing.Point(541, 20)
        Me.btnlookPetugasKirim.Name = "btnlookPetugasKirim"
        Me.btnlookPetugasKirim.Size = New System.Drawing.Size(75, 26)
        Me.btnlookPetugasKirim.TabIndex = 99
        Me.btnlookPetugasKirim.Text = "Cari"
        Me.btnlookPetugasKirim.UseVisualStyleBackColor = True
        '
        'txtPetugasKirim
        '
        Me.txtPetugasKirim.BackColor = System.Drawing.Color.Khaki
        Me.txtPetugasKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetugasKirim.Location = New System.Drawing.Point(185, 20)
        Me.txtPetugasKirim.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugasKirim.Name = "txtPetugasKirim"
        Me.txtPetugasKirim.ReadOnly = True
        Me.txtPetugasKirim.Size = New System.Drawing.Size(316, 26)
        Me.txtPetugasKirim.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Petugas Pengirim"
        '
        'PnPetugasPenerima
        '
        Me.PnPetugasPenerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnPetugasPenerima.Controls.Add(Me.Label6)
        Me.PnPetugasPenerima.Controls.Add(Me.txtPetugasPenerima)
        Me.PnPetugasPenerima.Location = New System.Drawing.Point(383, 86)
        Me.PnPetugasPenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.PnPetugasPenerima.Name = "PnPetugasPenerima"
        Me.PnPetugasPenerima.Size = New System.Drawing.Size(665, 64)
        Me.PnPetugasPenerima.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Petugas Penerima"
        '
        'txtPetugasPenerima
        '
        Me.txtPetugasPenerima.BackColor = System.Drawing.SystemColors.Window
        Me.txtPetugasPenerima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPetugasPenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetugasPenerima.Location = New System.Drawing.Point(185, 18)
        Me.txtPetugasPenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugasPenerima.Name = "txtPetugasPenerima"
        Me.txtPetugasPenerima.Size = New System.Drawing.Size(455, 26)
        Me.txtPetugasPenerima.TabIndex = 102
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 299)
        Me.PanelGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(1264, 236)
        Me.PanelGrid.TabIndex = 98
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Margin = New System.Windows.Forms.Padding(4)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(1264, 236)
        Me.gridItem.TabIndex = 0
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(1264, 53)
        Me.pnTop.TabIndex = 95
        '
        'ucDistribusiRuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.Panel4)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucDistribusiRuangan"
        Me.Size = New System.Drawing.Size(1264, 601)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnPetugasPengirim.ResumeLayout(False)
        Me.pnPetugasPengirim.PerformLayout()
        Me.PnPetugasPenerima.ResumeLayout(False)
        Me.PnPetugasPenerima.PerformLayout()
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLookupPasien As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoRegister As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRuang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents txtNoRM As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents pnPetugasPengirim As System.Windows.Forms.Panel
    Friend WithEvents txtPetugasKirim As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PnPetugasPenerima As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPetugasPenerima As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnlookPetugasKirim As System.Windows.Forms.Button

End Class
