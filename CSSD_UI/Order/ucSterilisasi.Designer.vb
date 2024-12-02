<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSterilisasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSterilisasi))
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.ParentPanel = New PanelLibs.GroupPanel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbInformasiPetugas = New System.Windows.Forms.GroupBox()
        Me.txtNamaPetugasSterilisasi2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKodePetugasSterilisasi2 = New System.Windows.Forms.TextBox()
        Me.txtNamaGroupMesin = New System.Windows.Forms.TextBox()
        Me.txtNamaMesinSterilisasi = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugasSterilisasi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeMesinSterilisasi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodePetugasSterilisasi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPetugas = New System.Windows.Forms.Button()
        Me.btnPetugas2 = New System.Windows.Forms.Button()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrid.SuspendLayout()
        Me.ParentPanel.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.gbInformasiPetugas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Margin = New System.Windows.Forms.Padding(4)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(1543, 262)
        Me.gridItem.TabIndex = 0
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 308)
        Me.PanelGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(1543, 262)
        Me.PanelGrid.TabIndex = 22
        '
        'ParentPanel
        '
        Me.ParentPanel.Controls.Add(Me.PanelGrid)
        Me.ParentPanel.Controls.Add(Me.PanelFooter)
        Me.ParentPanel.Controls.Add(Me.PanelHeader)
        Me.ParentPanel.Controls.Add(Me.Panel1)
        Me.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParentPanel.Lebar = 250
        Me.ParentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ParentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(1543, 635)
        Me.ParentPanel.TabIndex = 4
        Me.ParentPanel.Title = "Sterilisasi Instrumen"
        '
        'PanelFooter
        '
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 570)
        Me.PanelFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(1543, 65)
        Me.PanelFooter.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(431, 63)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1268, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 63)
        Me.Panel2.TabIndex = 3
        '
        'PanelHeader
        '
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.Label4)
        Me.PanelHeader.Controls.Add(Me.Panel5)
        Me.PanelHeader.Controls.Add(Me.gbInformasiPetugas)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 55)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1543, 253)
        Me.PanelHeader.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tekan [F5] untuk Simpan "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.lblName)
        Me.Panel5.Controls.Add(Me.txtKodeBarcode)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(375, 251)
        Me.Panel5.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 225)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tekan [F2] untuk fokus Scan"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 82)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(316, 17)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "INPUT KODE ( TRACKING / MESIN / PETUGAS )"
        '
        'txtKodeBarcode
        '
        Me.txtKodeBarcode.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtKodeBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKodeBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarcode.Location = New System.Drawing.Point(36, 102)
        Me.txtKodeBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodeBarcode.Name = "txtKodeBarcode"
        Me.txtKodeBarcode.Size = New System.Drawing.Size(269, 29)
        Me.txtKodeBarcode.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SlateGray
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 37)
        Me.Panel6.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "[BARCODE SCAN]"
        '
        'gbInformasiPetugas
        '
        Me.gbInformasiPetugas.Controls.Add(Me.btnPetugas2)
        Me.gbInformasiPetugas.Controls.Add(Me.btnPetugas)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaPetugasSterilisasi2)
        Me.gbInformasiPetugas.Controls.Add(Me.Label5)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodePetugasSterilisasi2)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaGroupMesin)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaMesinSterilisasi)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaPetugasSterilisasi)
        Me.gbInformasiPetugas.Controls.Add(Me.Label1)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodeMesinSterilisasi)
        Me.gbInformasiPetugas.Controls.Add(Me.Label11)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodePetugasSterilisasi)
        Me.gbInformasiPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformasiPetugas.Location = New System.Drawing.Point(400, 12)
        Me.gbInformasiPetugas.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInformasiPetugas.Name = "gbInformasiPetugas"
        Me.gbInformasiPetugas.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInformasiPetugas.Size = New System.Drawing.Size(647, 191)
        Me.gbInformasiPetugas.TabIndex = 19
        Me.gbInformasiPetugas.TabStop = False
        '
        'txtNamaPetugasSterilisasi2
        '
        Me.txtNamaPetugasSterilisasi2.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPetugasSterilisasi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPetugasSterilisasi2.Location = New System.Drawing.Point(305, 70)
        Me.txtNamaPetugasSterilisasi2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaPetugasSterilisasi2.Name = "txtNamaPetugasSterilisasi2"
        Me.txtNamaPetugasSterilisasi2.ReadOnly = True
        Me.txtNamaPetugasSterilisasi2.Size = New System.Drawing.Size(288, 26)
        Me.txtNamaPetugasSterilisasi2.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 20)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Petugas Sterilisasi 2"
        '
        'txtKodePetugasSterilisasi2
        '
        Me.txtKodePetugasSterilisasi2.BackColor = System.Drawing.Color.Khaki
        Me.txtKodePetugasSterilisasi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePetugasSterilisasi2.Location = New System.Drawing.Point(199, 70)
        Me.txtKodePetugasSterilisasi2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodePetugasSterilisasi2.Name = "txtKodePetugasSterilisasi2"
        Me.txtKodePetugasSterilisasi2.ReadOnly = True
        Me.txtKodePetugasSterilisasi2.Size = New System.Drawing.Size(100, 26)
        Me.txtKodePetugasSterilisasi2.TabIndex = 103
        '
        'txtNamaGroupMesin
        '
        Me.txtNamaGroupMesin.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaGroupMesin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaGroupMesin.Location = New System.Drawing.Point(305, 140)
        Me.txtNamaGroupMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaGroupMesin.Name = "txtNamaGroupMesin"
        Me.txtNamaGroupMesin.ReadOnly = True
        Me.txtNamaGroupMesin.Size = New System.Drawing.Size(292, 26)
        Me.txtNamaGroupMesin.TabIndex = 101
        '
        'txtNamaMesinSterilisasi
        '
        Me.txtNamaMesinSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaMesinSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaMesinSterilisasi.Location = New System.Drawing.Point(305, 106)
        Me.txtNamaMesinSterilisasi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaMesinSterilisasi.Name = "txtNamaMesinSterilisasi"
        Me.txtNamaMesinSterilisasi.ReadOnly = True
        Me.txtNamaMesinSterilisasi.Size = New System.Drawing.Size(288, 26)
        Me.txtNamaMesinSterilisasi.TabIndex = 19
        '
        'txtNamaPetugasSterilisasi
        '
        Me.txtNamaPetugasSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPetugasSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPetugasSterilisasi.Location = New System.Drawing.Point(305, 34)
        Me.txtNamaPetugasSterilisasi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaPetugasSterilisasi.Name = "txtNamaPetugasSterilisasi"
        Me.txtNamaPetugasSterilisasi.ReadOnly = True
        Me.txtNamaPetugasSterilisasi.Size = New System.Drawing.Size(288, 26)
        Me.txtNamaPetugasSterilisasi.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mesin Sterilisasi"
        '
        'txtKodeMesinSterilisasi
        '
        Me.txtKodeMesinSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtKodeMesinSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeMesinSterilisasi.Location = New System.Drawing.Point(199, 106)
        Me.txtKodeMesinSterilisasi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodeMesinSterilisasi.Name = "txtKodeMesinSterilisasi"
        Me.txtKodeMesinSterilisasi.ReadOnly = True
        Me.txtKodeMesinSterilisasi.Size = New System.Drawing.Size(100, 26)
        Me.txtKodeMesinSterilisasi.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 39)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Petugas Sterilisasi 1"
        '
        'txtKodePetugasSterilisasi
        '
        Me.txtKodePetugasSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtKodePetugasSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePetugasSterilisasi.Location = New System.Drawing.Point(199, 34)
        Me.txtKodePetugasSterilisasi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodePetugasSterilisasi.Name = "txtKodePetugasSterilisasi"
        Me.txtKodePetugasSterilisasi.ReadOnly = True
        Me.txtKodePetugasSterilisasi.Size = New System.Drawing.Size(100, 26)
        Me.txtKodePetugasSterilisasi.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1543, 55)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1059, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(484, 55)
        Me.Panel4.TabIndex = 1
        '
        'btnPetugas
        '
        Me.btnPetugas.Image = CType(resources.GetObject("btnPetugas.Image"), System.Drawing.Image)
        Me.btnPetugas.Location = New System.Drawing.Point(594, 33)
        Me.btnPetugas.Name = "btnPetugas"
        Me.btnPetugas.Size = New System.Drawing.Size(33, 29)
        Me.btnPetugas.TabIndex = 25
        Me.btnPetugas.UseVisualStyleBackColor = True
        '
        'btnPetugas2
        '
        Me.btnPetugas2.Image = CType(resources.GetObject("btnPetugas2.Image"), System.Drawing.Image)
        Me.btnPetugas2.Location = New System.Drawing.Point(594, 69)
        Me.btnPetugas2.Name = "btnPetugas2"
        Me.btnPetugas2.Size = New System.Drawing.Size(33, 29)
        Me.btnPetugas2.TabIndex = 105
        Me.btnPetugas2.UseVisualStyleBackColor = True
        '
        'ucSterilisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucSterilisasi"
        Me.Size = New System.Drawing.Size(1543, 635)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrid.ResumeLayout(False)
        Me.ParentPanel.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.gbInformasiPetugas.ResumeLayout(False)
        Me.gbInformasiPetugas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents ParentPanel As PanelLibs.GroupPanel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents gbInformasiPetugas As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKodePetugasSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeMesinSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMesinSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPetugasSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaGroupMesin As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPetugasSterilisasi2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodePetugasSterilisasi2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPetugas As System.Windows.Forms.Button
    Friend WithEvents btnPetugas2 As System.Windows.Forms.Button

End Class
