<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReorderSterilisasi
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbInformasiPetugas = New System.Windows.Forms.GroupBox()
        Me.txtNamaGroupMesin = New System.Windows.Forms.TextBox()
        Me.txtNamaMesinSterilisasi = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugasSterilisasi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeMesinSterilisasi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodePetugasSterilisasi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ParentPanel = New PanelLibs.GroupPanel()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.gbInformasiPetugas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ParentPanel.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.Label4)
        Me.PanelHeader.Controls.Add(Me.Panel5)
        Me.PanelHeader.Controls.Add(Me.gbInformasiPetugas)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 45)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(948, 198)
        Me.PanelHeader.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(351, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tekan [F5] untuk Simpan / Scan barcode petugas lagi untuk menyimpan"
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
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(282, 196)
        Me.Panel5.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tekan [F2] untuk Scan"
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
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(280, 30)
        Me.Panel6.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "[BARCODE SCAN]"
        '
        'gbInformasiPetugas
        '
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaGroupMesin)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaMesinSterilisasi)
        Me.gbInformasiPetugas.Controls.Add(Me.txtNamaPetugasSterilisasi)
        Me.gbInformasiPetugas.Controls.Add(Me.Label1)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodeMesinSterilisasi)
        Me.gbInformasiPetugas.Controls.Add(Me.Label11)
        Me.gbInformasiPetugas.Controls.Add(Me.txtKodePetugasSterilisasi)
        Me.gbInformasiPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformasiPetugas.Location = New System.Drawing.Point(300, 10)
        Me.gbInformasiPetugas.Name = "gbInformasiPetugas"
        Me.gbInformasiPetugas.Size = New System.Drawing.Size(494, 127)
        Me.gbInformasiPetugas.TabIndex = 19
        Me.gbInformasiPetugas.TabStop = False
        '
        'txtNamaGroupMesin
        '
        Me.txtNamaGroupMesin.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaGroupMesin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaGroupMesin.Location = New System.Drawing.Point(233, 82)
        Me.txtNamaGroupMesin.Name = "txtNamaGroupMesin"
        Me.txtNamaGroupMesin.ReadOnly = True
        Me.txtNamaGroupMesin.Size = New System.Drawing.Size(217, 22)
        Me.txtNamaGroupMesin.TabIndex = 101
        '
        'txtNamaMesinSterilisasi
        '
        Me.txtNamaMesinSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaMesinSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaMesinSterilisasi.Location = New System.Drawing.Point(233, 54)
        Me.txtNamaMesinSterilisasi.Name = "txtNamaMesinSterilisasi"
        Me.txtNamaMesinSterilisasi.ReadOnly = True
        Me.txtNamaMesinSterilisasi.Size = New System.Drawing.Size(217, 22)
        Me.txtNamaMesinSterilisasi.TabIndex = 19
        '
        'txtNamaPetugasSterilisasi
        '
        Me.txtNamaPetugasSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaPetugasSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPetugasSterilisasi.Location = New System.Drawing.Point(233, 26)
        Me.txtNamaPetugasSterilisasi.Name = "txtNamaPetugasSterilisasi"
        Me.txtNamaPetugasSterilisasi.ReadOnly = True
        Me.txtNamaPetugasSterilisasi.Size = New System.Drawing.Size(217, 22)
        Me.txtNamaPetugasSterilisasi.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mesin ReSterilisasi"
        '
        'txtKodeMesinSterilisasi
        '
        Me.txtKodeMesinSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtKodeMesinSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeMesinSterilisasi.Location = New System.Drawing.Point(153, 54)
        Me.txtKodeMesinSterilisasi.Name = "txtKodeMesinSterilisasi"
        Me.txtKodeMesinSterilisasi.ReadOnly = True
        Me.txtKodeMesinSterilisasi.Size = New System.Drawing.Size(76, 22)
        Me.txtKodeMesinSterilisasi.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Petugas ReSterilisasi"
        '
        'txtKodePetugasSterilisasi
        '
        Me.txtKodePetugasSterilisasi.BackColor = System.Drawing.Color.Khaki
        Me.txtKodePetugasSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePetugasSterilisasi.Location = New System.Drawing.Point(153, 26)
        Me.txtKodePetugasSterilisasi.Name = "txtKodePetugasSterilisasi"
        Me.txtKodePetugasSterilisasi.ReadOnly = True
        Me.txtKodePetugasSterilisasi.Size = New System.Drawing.Size(76, 22)
        Me.txtKodePetugasSterilisasi.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 45)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(585, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(363, 45)
        Me.Panel4.TabIndex = 1
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
        Me.ParentPanel.Size = New System.Drawing.Size(948, 479)
        Me.ParentPanel.TabIndex = 5
        Me.ParentPanel.Title = "REORDER STERILISASI INSTRUMEN"
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 243)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(948, 183)
        Me.PanelGrid.TabIndex = 22
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(948, 183)
        Me.gridItem.TabIndex = 0
        '
        'PanelFooter
        '
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 426)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(948, 53)
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
        Me.Panel2.Controls.Add(Me.btnKeluar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(741, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 51)
        Me.Panel2.TabIndex = 3
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(21, 7)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(96, 34)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'ucReorderSterilisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentPanel)
        Me.Name = "ucReorderSterilisasi"
        Me.Size = New System.Drawing.Size(948, 479)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.gbInformasiPetugas.ResumeLayout(False)
        Me.gbInformasiPetugas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ParentPanel.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbInformasiPetugas As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaGroupMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMesinSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPetugasSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeMesinSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKodePetugasSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ParentPanel As PanelLibs.GroupPanel
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class
