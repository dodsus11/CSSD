<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGudangInstrumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucGudangInstrumen))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.lblGudang = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbInformasiPetugas = New System.Windows.Forms.GroupBox()
        Me.btnPetugas2 = New System.Windows.Forms.Button()
        Me.btnPetugas1 = New System.Windows.Forms.Button()
        Me.TxtKodePetugas2 = New System.Windows.Forms.TextBox()
        Me.TxtKodePetugas1 = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugas2 = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugas1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ParentPanel = New PanelLibs.GroupPanel()
        Me.PanelHeader.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.gbInformasiPetugas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrid.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.ParentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.lblGudang)
        Me.PanelHeader.Controls.Add(Me.Label3)
        Me.PanelHeader.Controls.Add(Me.Panel5)
        Me.PanelHeader.Controls.Add(Me.gbInformasiPetugas)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 53)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1236, 238)
        Me.PanelHeader.TabIndex = 20
        '
        'lblGudang
        '
        Me.lblGudang.AutoSize = True
        Me.lblGudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGudang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblGudang.Location = New System.Drawing.Point(427, 16)
        Me.lblGudang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGudang.Name = "lblGudang"
        Me.lblGudang.Size = New System.Drawing.Size(323, 24)
        Me.lblGudang.TabIndex = 101
        Me.lblGudang.Text = "GUDANG STERILISASI SENTRAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 17)
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
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(375, 236)
        Me.Panel5.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 217)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tekan [F2] untuk Scan"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(59, 78)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(258, 17)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "INPUT KODE ( TRACKING / PETUGAS)"
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
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 37)
        Me.Panel6.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "[BARCODE SCAN]"
        '
        'gbInformasiPetugas
        '
        Me.gbInformasiPetugas.Controls.Add(Me.btnPetugas2)
        Me.gbInformasiPetugas.Controls.Add(Me.btnPetugas1)
        Me.gbInformasiPetugas.Controls.Add(Me.TxtKodePetugas2)
        Me.gbInformasiPetugas.Controls.Add(Me.TxtKodePetugas1)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaPetugas2)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaPetugas1)
        Me.gbInformasiPetugas.Controls.Add(Me.Label4)
        Me.gbInformasiPetugas.Controls.Add(Me.Label8)
        Me.gbInformasiPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformasiPetugas.Location = New System.Drawing.Point(431, 50)
        Me.gbInformasiPetugas.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInformasiPetugas.Name = "gbInformasiPetugas"
        Me.gbInformasiPetugas.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInformasiPetugas.Size = New System.Drawing.Size(773, 123)
        Me.gbInformasiPetugas.TabIndex = 19
        Me.gbInformasiPetugas.TabStop = False
        '
        'btnPetugas2
        '
        Me.btnPetugas2.Image = CType(resources.GetObject("btnPetugas2.Image"), System.Drawing.Image)
        Me.btnPetugas2.Location = New System.Drawing.Point(546, 64)
        Me.btnPetugas2.Name = "btnPetugas2"
        Me.btnPetugas2.Size = New System.Drawing.Size(33, 29)
        Me.btnPetugas2.TabIndex = 107
        Me.btnPetugas2.UseVisualStyleBackColor = True
        '
        'btnPetugas1
        '
        Me.btnPetugas1.Image = CType(resources.GetObject("btnPetugas1.Image"), System.Drawing.Image)
        Me.btnPetugas1.Location = New System.Drawing.Point(546, 29)
        Me.btnPetugas1.Name = "btnPetugas1"
        Me.btnPetugas1.Size = New System.Drawing.Size(33, 29)
        Me.btnPetugas1.TabIndex = 106
        Me.btnPetugas1.UseVisualStyleBackColor = True
        '
        'TxtKodePetugas2
        '
        Me.TxtKodePetugas2.BackColor = System.Drawing.Color.Khaki
        Me.TxtKodePetugas2.Location = New System.Drawing.Point(118, 68)
        Me.TxtKodePetugas2.Name = "TxtKodePetugas2"
        Me.TxtKodePetugas2.ReadOnly = True
        Me.TxtKodePetugas2.Size = New System.Drawing.Size(109, 26)
        Me.TxtKodePetugas2.TabIndex = 104
        '
        'TxtKodePetugas1
        '
        Me.TxtKodePetugas1.BackColor = System.Drawing.Color.Khaki
        Me.TxtKodePetugas1.Location = New System.Drawing.Point(118, 30)
        Me.TxtKodePetugas1.Name = "TxtKodePetugas1"
        Me.TxtKodePetugas1.ReadOnly = True
        Me.TxtKodePetugas1.Size = New System.Drawing.Size(109, 26)
        Me.TxtKodePetugas1.TabIndex = 103
        '
        'txtNamaPetugas2
        '
        Me.txtNamaPetugas2.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPetugas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPetugas2.Location = New System.Drawing.Point(234, 67)
        Me.txtNamaPetugas2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaPetugas2.Name = "txtNamaPetugas2"
        Me.txtNamaPetugas2.ReadOnly = True
        Me.txtNamaPetugas2.Size = New System.Drawing.Size(305, 26)
        Me.txtNamaPetugas2.TabIndex = 102
        '
        'txtNamaPetugas1
        '
        Me.txtNamaPetugas1.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPetugas1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPetugas1.Location = New System.Drawing.Point(234, 30)
        Me.txtNamaPetugas1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaPetugas1.Name = "txtNamaPetugas1"
        Me.txtNamaPetugas1.ReadOnly = True
        Me.txtNamaPetugas1.Size = New System.Drawing.Size(305, 26)
        Me.txtNamaPetugas1.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Petugas 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Petugas 1"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(752, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(484, 53)
        Me.Panel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1236, 53)
        Me.Panel1.TabIndex = 1
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Margin = New System.Windows.Forms.Padding(4)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(1236, 296)
        Me.gridItem.TabIndex = 0
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 291)
        Me.PanelGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(1236, 296)
        Me.PanelGrid.TabIndex = 22
        '
        'PanelFooter
        '
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 587)
        Me.PanelFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(1236, 65)
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
        Me.Panel2.Location = New System.Drawing.Point(961, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 63)
        Me.Panel2.TabIndex = 3
        '
        'ParentPanel
        '
        Me.ParentPanel.Controls.Add(Me.PanelGrid)
        Me.ParentPanel.Controls.Add(Me.PanelFooter)
        Me.ParentPanel.Controls.Add(Me.PanelHeader)
        Me.ParentPanel.Controls.Add(Me.Panel1)
        Me.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParentPanel.Lebar = 400
        Me.ParentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ParentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(1236, 652)
        Me.ParentPanel.TabIndex = 3
        Me.ParentPanel.Title = "PENYIMPANAN DAN MONITORING ALKES STERIL"
        '
        'ucGudangInstrumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucGudangInstrumen"
        Me.Size = New System.Drawing.Size(1236, 652)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.gbInformasiPetugas.ResumeLayout(False)
        Me.gbInformasiPetugas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrid.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        Me.ParentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbInformasiPetugas As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ParentPanel As PanelLibs.GroupPanel
    Friend WithEvents lblGudang As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPetugas2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPetugas1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodePetugas2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodePetugas1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPetugas2 As System.Windows.Forms.Button
    Friend WithEvents btnPetugas1 As System.Windows.Forms.Button

End Class
