<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPencucian
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
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKodePetugasPencucian = New System.Windows.Forms.TextBox()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbInformasiPetugas = New System.Windows.Forms.GroupBox()
        Me.txtNamaGroupMesin = New System.Windows.Forms.TextBox()
        Me.txtNamaMesinPencucian = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugasPencucian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKodeMesinPencucian = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ParentPanel = New PanelLibs.GroupPanel()
        Me.PanelGrid.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.gbInformasiPetugas.SuspendLayout()
        Me.ParentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 237)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(1108, 132)
        Me.PanelGrid.TabIndex = 22
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(1108, 132)
        Me.gridItem.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 43)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(745, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(363, 43)
        Me.Panel4.TabIndex = 1
        '
        'PanelFooter
        '
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 369)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(1108, 53)
        Me.PanelFooter.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 51)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(901, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 51)
        Me.Panel2.TabIndex = 3
        '
        'txtKodePetugasPencucian
        '
        Me.txtKodePetugasPencucian.BackColor = System.Drawing.Color.Khaki
        Me.txtKodePetugasPencucian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePetugasPencucian.Location = New System.Drawing.Point(136, 21)
        Me.txtKodePetugasPencucian.Name = "txtKodePetugasPencucian"
        Me.txtKodePetugasPencucian.ReadOnly = True
        Me.txtKodePetugasPencucian.Size = New System.Drawing.Size(85, 22)
        Me.txtKodePetugasPencucian.TabIndex = 9
        '
        'PanelHeader
        '
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.Label3)
        Me.PanelHeader.Controls.Add(Me.Panel5)
        Me.PanelHeader.Controls.Add(Me.gbInformasiPetugas)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 43)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1108, 194)
        Me.PanelHeader.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tekan [F5] untuk Simpan / Scan barcode petugas lagi untuk menyimpan"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.lblName)
        Me.Panel5.Controls.Add(Me.txtKodeBarcode)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(282, 192)
        Me.Panel5.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tekan [F2] untuk fokus Scan"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(250, 13)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "INPUT KODE ( TRACKING / MESIN / PETUGAS )"
        '
        'txtKodeBarcode
        '
        Me.txtKodeBarcode.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtKodeBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKodeBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarcode.Location = New System.Drawing.Point(36, 83)
        Me.txtKodeBarcode.Name = "txtKodeBarcode"
        Me.txtKodeBarcode.Size = New System.Drawing.Size(203, 24)
        Me.txtKodeBarcode.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SlateGray
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(280, 30)
        Me.Panel6.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "[BARCODE SCAN]"
        '
        'gbInformasiPetugas
        '
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaGroupMesin)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaMesinPencucian)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaPetugasPencucian)
        Me.gbInformasiPetugas.Controls.Add(Me.Label6)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodeMesinPencucian)
        Me.gbInformasiPetugas.Controls.Add(Me.Label8)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodePetugasPencucian)
        Me.gbInformasiPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformasiPetugas.Location = New System.Drawing.Point(298, 3)
        Me.gbInformasiPetugas.Name = "gbInformasiPetugas"
        Me.gbInformasiPetugas.Size = New System.Drawing.Size(502, 118)
        Me.gbInformasiPetugas.TabIndex = 19
        Me.gbInformasiPetugas.TabStop = False
        '
        'txtNamaGroupMesin
        '
        Me.txtNamaGroupMesin.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaGroupMesin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaGroupMesin.Location = New System.Drawing.Point(227, 77)
        Me.txtNamaGroupMesin.Name = "txtNamaGroupMesin"
        Me.txtNamaGroupMesin.ReadOnly = True
        Me.txtNamaGroupMesin.Size = New System.Drawing.Size(235, 22)
        Me.txtNamaGroupMesin.TabIndex = 100
        '
        'txtNamaMesinPencucian
        '
        Me.txtNamaMesinPencucian.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaMesinPencucian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaMesinPencucian.Location = New System.Drawing.Point(227, 49)
        Me.txtNamaMesinPencucian.Name = "txtNamaMesinPencucian"
        Me.txtNamaMesinPencucian.ReadOnly = True
        Me.txtNamaMesinPencucian.Size = New System.Drawing.Size(235, 22)
        Me.txtNamaMesinPencucian.TabIndex = 99
        '
        'txtNamaPetugasPencucian
        '
        Me.txtNamaPetugasPencucian.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPetugasPencucian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPetugasPencucian.Location = New System.Drawing.Point(227, 21)
        Me.txtNamaPetugasPencucian.Name = "txtNamaPetugasPencucian"
        Me.txtNamaPetugasPencucian.ReadOnly = True
        Me.txtNamaPetugasPencucian.Size = New System.Drawing.Size(235, 22)
        Me.txtNamaPetugasPencucian.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Mesin Pencucian"
        '
        'txtKodeMesinPencucian
        '
        Me.txtKodeMesinPencucian.BackColor = System.Drawing.Color.Khaki
        Me.txtKodeMesinPencucian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeMesinPencucian.Location = New System.Drawing.Point(136, 49)
        Me.txtKodeMesinPencucian.Name = "txtKodeMesinPencucian"
        Me.txtKodeMesinPencucian.ReadOnly = True
        Me.txtKodeMesinPencucian.Size = New System.Drawing.Size(85, 22)
        Me.txtKodeMesinPencucian.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Petugas Pencucian"
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
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(1108, 422)
        Me.ParentPanel.TabIndex = 2
        Me.ParentPanel.Title = "Pencucian Instrumen"
        '
        'ucPencucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentPanel)
        Me.Name = "ucPencucian"
        Me.Size = New System.Drawing.Size(1108, 422)
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.gbInformasiPetugas.ResumeLayout(False)
        Me.gbInformasiPetugas.PerformLayout()
        Me.ParentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtKodePetugasPencucian As System.Windows.Forms.TextBox
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents gbInformasiPetugas As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ParentPanel As PanelLibs.GroupPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKodeMesinPencucian As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPetugasPencucian As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMesinPencucian As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaGroupMesin As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
