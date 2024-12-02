<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTransferAntarGudang
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPetugasPenerima = New System.Windows.Forms.TextBox()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.btnLookUpGudang = New C1.Win.C1Input.C1Button()
        Me.txtGudangTujuan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnPetugasPengirim = New System.Windows.Forms.Panel()
        Me.txtPetugasPengirim = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnPetugasPenerima = New System.Windows.Forms.Panel()
        Me.lblGudang = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ParentPanel = New PanelLibs.GroupPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PetugasEntry = New System.Windows.Forms.Label()
        Me.PanelGrid.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooter.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.pnPetugasPengirim.SuspendLayout()
        Me.PnPetugasPenerima.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ParentPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 270)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(978, 147)
        Me.PanelGrid.TabIndex = 22
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(978, 147)
        Me.gridItem.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 32)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(771, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 32)
        Me.Panel2.TabIndex = 3
        '
        'PanelFooter
        '
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 417)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(978, 34)
        Me.PanelFooter.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Petugas Penerima"
        '
        'txtPetugasPenerima
        '
        Me.txtPetugasPenerima.BackColor = System.Drawing.SystemColors.Window
        Me.txtPetugasPenerima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPetugasPenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetugasPenerima.Location = New System.Drawing.Point(139, 15)
        Me.txtPetugasPenerima.Name = "txtPetugasPenerima"
        Me.txtPetugasPenerima.Size = New System.Drawing.Size(326, 22)
        Me.txtPetugasPenerima.TabIndex = 102
        '
        'PanelHeader
        '
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.btnLookUpGudang)
        Me.PanelHeader.Controls.Add(Me.txtGudangTujuan)
        Me.PanelHeader.Controls.Add(Me.Label6)
        Me.PanelHeader.Controls.Add(Me.Label5)
        Me.PanelHeader.Controls.Add(Me.pnPetugasPengirim)
        Me.PanelHeader.Controls.Add(Me.PnPetugasPenerima)
        Me.PanelHeader.Controls.Add(Me.lblGudang)
        Me.PanelHeader.Controls.Add(Me.Label3)
        Me.PanelHeader.Controls.Add(Me.Panel5)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 43)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(978, 227)
        Me.PanelHeader.TabIndex = 20
        '
        'btnLookUpGudang
        '
        Me.btnLookUpGudang.Location = New System.Drawing.Point(771, 50)
        Me.btnLookUpGudang.Name = "btnLookUpGudang"
        Me.btnLookUpGudang.Size = New System.Drawing.Size(46, 22)
        Me.btnLookUpGudang.TabIndex = 109
        Me.btnLookUpGudang.Text = "..."
        Me.btnLookUpGudang.UseVisualStyleBackColor = True
        Me.btnLookUpGudang.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUpGudang.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtGudangTujuan
        '
        Me.txtGudangTujuan.BackColor = System.Drawing.Color.Khaki
        Me.txtGudangTujuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGudangTujuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGudangTujuan.Location = New System.Drawing.Point(450, 50)
        Me.txtGudangTujuan.Name = "txtGudangTujuan"
        Me.txtGudangTujuan.ReadOnly = True
        Me.txtGudangTujuan.Size = New System.Drawing.Size(315, 22)
        Me.txtGudangTujuan.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Gudang Tujuan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(307, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Gudang Asal :"
        '
        'pnPetugasPengirim
        '
        Me.pnPetugasPengirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnPetugasPengirim.Controls.Add(Me.txtPetugasPengirim)
        Me.pnPetugasPengirim.Controls.Add(Me.Label8)
        Me.pnPetugasPengirim.Location = New System.Drawing.Point(310, 84)
        Me.pnPetugasPengirim.Name = "pnPetugasPengirim"
        Me.pnPetugasPengirim.Size = New System.Drawing.Size(499, 48)
        Me.pnPetugasPengirim.TabIndex = 105
        '
        'txtPetugasPengirim
        '
        Me.txtPetugasPengirim.BackColor = System.Drawing.Color.Khaki
        Me.txtPetugasPengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetugasPengirim.Location = New System.Drawing.Point(139, 16)
        Me.txtPetugasPengirim.Name = "txtPetugasPengirim"
        Me.txtPetugasPengirim.ReadOnly = True
        Me.txtPetugasPengirim.Size = New System.Drawing.Size(326, 22)
        Me.txtPetugasPengirim.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Petugas Pengirim"
        '
        'PnPetugasPenerima
        '
        Me.PnPetugasPenerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnPetugasPenerima.Controls.Add(Me.Label4)
        Me.PnPetugasPenerima.Controls.Add(Me.txtPetugasPenerima)
        Me.PnPetugasPenerima.Location = New System.Drawing.Point(310, 138)
        Me.PnPetugasPenerima.Name = "PnPetugasPenerima"
        Me.PnPetugasPenerima.Size = New System.Drawing.Size(499, 52)
        Me.PnPetugasPenerima.TabIndex = 104
        '
        'lblGudang
        '
        Me.lblGudang.AutoSize = True
        Me.lblGudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGudang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblGudang.Location = New System.Drawing.Point(421, 13)
        Me.lblGudang.Name = "lblGudang"
        Me.lblGudang.Size = New System.Drawing.Size(83, 18)
        Me.lblGudang.TabIndex = 101
        Me.lblGudang.Text = "lblGudang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 210)
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
        Me.Panel5.Size = New System.Drawing.Size(282, 225)
        Me.Panel5.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tekan [F2] untuk Fokus Scan"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(67, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(143, 13)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "INPUT KODE ( TRACKING )"
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
        Me.ParentPanel.Size = New System.Drawing.Size(978, 451)
        Me.ParentPanel.TabIndex = 5
        Me.ParentPanel.Title = "TRANSFER ANTAR GUDANG"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 43)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PetugasEntry)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(615, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(363, 43)
        Me.Panel4.TabIndex = 1
        '
        'PetugasEntry
        '
        Me.PetugasEntry.AutoSize = True
        Me.PetugasEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetugasEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PetugasEntry.Location = New System.Drawing.Point(17, 12)
        Me.PetugasEntry.Name = "PetugasEntry"
        Me.PetugasEntry.Size = New System.Drawing.Size(113, 18)
        Me.PetugasEntry.TabIndex = 102
        Me.PetugasEntry.Text = "Petugas Entry"
        '
        'ucTransferAntarGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentPanel)
        Me.Name = "ucTransferAntarGudang"
        Me.Size = New System.Drawing.Size(978, 451)
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooter.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.pnPetugasPengirim.ResumeLayout(False)
        Me.pnPetugasPengirim.PerformLayout()
        Me.PnPetugasPenerima.ResumeLayout(False)
        Me.PnPetugasPenerima.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ParentPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPetugasPenerima As System.Windows.Forms.TextBox
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents lblGudang As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPetugasPengirim As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ParentPanel As PanelLibs.GroupPanel
    Friend WithEvents pnPetugasPengirim As System.Windows.Forms.Panel
    Friend WithEvents PnPetugasPenerima As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGudangTujuan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLookUpGudang As C1.Win.C1Input.C1Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PetugasEntry As System.Windows.Forms.Label

End Class
