<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPenerimaanSterilisasiAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPenerimaanSterilisasiAdd))
        Me.ParentPanel = New PanelLibs.GroupPanel()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.gridItem = New System.Windows.Forms.DataGridView()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCetakLabelReuse = New System.Windows.Forms.Button()
        Me.btnCetakLabelBarcode = New System.Windows.Forms.Button()
        Me.btnCetakBuktiOrder = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelToolStrip = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.pnTglDatang = New System.Windows.Forms.Panel()
        Me.LblTgl = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dtpTglDatang = New System.Windows.Forms.DateTimePicker()
        Me.gbInformasiOrder = New System.Windows.Forms.GroupBox()
        Me.btnLookPetugas = New C1.Win.C1Input.C1Button()
        Me.txtPetugasSterilisasi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTypeOrder = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbBarang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLookUnit = New C1.Win.C1Input.C1Button()
        Me.txtPetugasOrder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelPetugasEntry = New System.Windows.Forms.Label()
        Me.ParentPanel.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelToolStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnTglDatang.SuspendLayout()
        Me.gbInformasiOrder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ParentPanel.Size = New System.Drawing.Size(1468, 727)
        Me.ParentPanel.TabIndex = 0
        Me.ParentPanel.Title = "Order Sterilisasi"
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.gridItem)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 384)
        Me.PanelGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(1468, 278)
        Me.PanelGrid.TabIndex = 22
        '
        'gridItem
        '
        Me.gridItem.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItem.Location = New System.Drawing.Point(0, 0)
        Me.gridItem.Margin = New System.Windows.Forms.Padding(4)
        Me.gridItem.Name = "gridItem"
        Me.gridItem.Size = New System.Drawing.Size(1468, 278)
        Me.gridItem.TabIndex = 0
        '
        'PanelFooter
        '
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 662)
        Me.PanelFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(1468, 65)
        Me.PanelFooter.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCetakLabelReuse)
        Me.Panel3.Controls.Add(Me.btnCetakLabelBarcode)
        Me.Panel3.Controls.Add(Me.btnCetakBuktiOrder)
        Me.Panel3.Controls.Add(Me.btnSimpan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1008, 63)
        Me.Panel3.TabIndex = 4
        '
        'btnCetakLabelReuse
        '
        Me.btnCetakLabelReuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakLabelReuse.Location = New System.Drawing.Point(677, 9)
        Me.btnCetakLabelReuse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCetakLabelReuse.Name = "btnCetakLabelReuse"
        Me.btnCetakLabelReuse.Size = New System.Drawing.Size(224, 42)
        Me.btnCetakLabelReuse.TabIndex = 3
        Me.btnCetakLabelReuse.Text = "Cetak Label Reuse ( All )"
        Me.btnCetakLabelReuse.UseVisualStyleBackColor = True
        '
        'btnCetakLabelBarcode
        '
        Me.btnCetakLabelBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakLabelBarcode.Location = New System.Drawing.Point(432, 9)
        Me.btnCetakLabelBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCetakLabelBarcode.Name = "btnCetakLabelBarcode"
        Me.btnCetakLabelBarcode.Size = New System.Drawing.Size(237, 42)
        Me.btnCetakLabelBarcode.TabIndex = 2
        Me.btnCetakLabelBarcode.Text = "Cetak Label Tracing ( All )"
        Me.btnCetakLabelBarcode.UseVisualStyleBackColor = True
        '
        'btnCetakBuktiOrder
        '
        Me.btnCetakBuktiOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakBuktiOrder.Location = New System.Drawing.Point(260, 9)
        Me.btnCetakBuktiOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCetakBuktiOrder.Name = "btnCetakBuktiOrder"
        Me.btnCetakBuktiOrder.Size = New System.Drawing.Size(164, 42)
        Me.btnCetakBuktiOrder.TabIndex = 1
        Me.btnCetakBuktiOrder.Text = "Cetak Bukti Order"
        Me.btnCetakBuktiOrder.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(28, 9)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(123, 42)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan [F5]"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnKeluar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1193, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 63)
        Me.Panel2.TabIndex = 3
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(19, 9)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(128, 42)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Batal"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PanelHeader
        '
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.PanelToolStrip)
        Me.PanelHeader.Controls.Add(Me.pnTglDatang)
        Me.PanelHeader.Controls.Add(Me.gbInformasiOrder)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 60)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1468, 324)
        Me.PanelHeader.TabIndex = 20
        '
        'PanelToolStrip
        '
        Me.PanelToolStrip.BackColor = System.Drawing.SystemColors.Control
        Me.PanelToolStrip.Controls.Add(Me.ToolStrip1)
        Me.PanelToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelToolStrip.Location = New System.Drawing.Point(0, 283)
        Me.PanelToolStrip.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelToolStrip.Name = "PanelToolStrip"
        Me.PanelToolStrip.Size = New System.Drawing.Size(1466, 39)
        Me.PanelToolStrip.TabIndex = 98
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(124, 27)
        Me.ToolStrip1.TabIndex = 99
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(57, 24)
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(55, 24)
        Me.btnEdit.Text = "Edit"
        '
        'pnTglDatang
        '
        Me.pnTglDatang.Controls.Add(Me.LblTgl)
        Me.pnTglDatang.Controls.Add(Me.CheckBox1)
        Me.pnTglDatang.Controls.Add(Me.dtpTglDatang)
        Me.pnTglDatang.Location = New System.Drawing.Point(1164, 7)
        Me.pnTglDatang.Margin = New System.Windows.Forms.Padding(4)
        Me.pnTglDatang.Name = "pnTglDatang"
        Me.pnTglDatang.Size = New System.Drawing.Size(298, 80)
        Me.pnTglDatang.TabIndex = 97
        Me.pnTglDatang.Visible = False
        '
        'LblTgl
        '
        Me.LblTgl.AutoSize = True
        Me.LblTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTgl.ForeColor = System.Drawing.Color.Maroon
        Me.LblTgl.Location = New System.Drawing.Point(269, 34)
        Me.LblTgl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(15, 20)
        Me.LblTgl.TabIndex = 79
        Me.LblTgl.Text = "-"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 10)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(180, 21)
        Me.CheckBox1.TabIndex = 97
        Me.CheckBox1.Text = "Setting Tanggal Datang"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtpTglDatang
        '
        Me.dtpTglDatang.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpTglDatang.Enabled = False
        Me.dtpTglDatang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglDatang.Location = New System.Drawing.Point(24, 34)
        Me.dtpTglDatang.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTglDatang.Name = "dtpTglDatang"
        Me.dtpTglDatang.Size = New System.Drawing.Size(167, 22)
        Me.dtpTglDatang.TabIndex = 95
        '
        'gbInformasiOrder
        '
        Me.gbInformasiOrder.Controls.Add(Me.btnLookPetugas)
        Me.gbInformasiOrder.Controls.Add(Me.txtPetugasSterilisasi)
        Me.gbInformasiOrder.Controls.Add(Me.Label7)
        Me.gbInformasiOrder.Controls.Add(Me.cbTypeOrder)
        Me.gbInformasiOrder.Controls.Add(Me.Label6)
        Me.gbInformasiOrder.Controls.Add(Me.cbBarang)
        Me.gbInformasiOrder.Controls.Add(Me.Label5)
        Me.gbInformasiOrder.Controls.Add(Me.btnLookUnit)
        Me.gbInformasiOrder.Controls.Add(Me.txtPetugasOrder)
        Me.gbInformasiOrder.Controls.Add(Me.Label1)
        Me.gbInformasiOrder.Controls.Add(Me.txtNoOrder)
        Me.gbInformasiOrder.Controls.Add(Me.Label2)
        Me.gbInformasiOrder.Controls.Add(Me.Label3)
        Me.gbInformasiOrder.Controls.Add(Me.txtNamaUnit)
        Me.gbInformasiOrder.Controls.Add(Me.Label4)
        Me.gbInformasiOrder.Controls.Add(Me.txtTelp)
        Me.gbInformasiOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformasiOrder.Location = New System.Drawing.Point(8, 5)
        Me.gbInformasiOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInformasiOrder.Name = "gbInformasiOrder"
        Me.gbInformasiOrder.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInformasiOrder.Size = New System.Drawing.Size(777, 269)
        Me.gbInformasiOrder.TabIndex = 18
        Me.gbInformasiOrder.TabStop = False
        Me.gbInformasiOrder.Text = "Informasi Order"
        '
        'btnLookPetugas
        '
        Me.btnLookPetugas.Location = New System.Drawing.Point(540, 209)
        Me.btnLookPetugas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookPetugas.Name = "btnLookPetugas"
        Me.btnLookPetugas.Size = New System.Drawing.Size(61, 27)
        Me.btnLookPetugas.TabIndex = 84
        Me.btnLookPetugas.Text = "Cari"
        Me.btnLookPetugas.UseVisualStyleBackColor = True
        Me.btnLookPetugas.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookPetugas.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtPetugasSterilisasi
        '
        Me.txtPetugasSterilisasi.BackColor = System.Drawing.SystemColors.Control
        Me.txtPetugasSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetugasSterilisasi.Location = New System.Drawing.Point(209, 209)
        Me.txtPetugasSterilisasi.Name = "txtPetugasSterilisasi"
        Me.txtPetugasSterilisasi.Size = New System.Drawing.Size(306, 27)
        Me.txtPetugasSterilisasi.TabIndex = 83
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Petugas Sterilisasi"
        '
        'cbTypeOrder
        '
        Me.cbTypeOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeOrder.FormattingEnabled = True
        Me.cbTypeOrder.Items.AddRange(New Object() {"BIASA", "CITO"})
        Me.cbTypeOrder.Location = New System.Drawing.Point(209, 174)
        Me.cbTypeOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTypeOrder.Name = "cbTypeOrder"
        Me.cbTypeOrder.Size = New System.Drawing.Size(207, 28)
        Me.cbTypeOrder.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Jenis Order"
        '
        'cbBarang
        '
        Me.cbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBarang.FormattingEnabled = True
        Me.cbBarang.Items.AddRange(New Object() {"BERSIH", "KOTOR"})
        Me.cbBarang.Location = New System.Drawing.Point(209, 142)
        Me.cbBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBarang.Name = "cbBarang"
        Me.cbBarang.Size = New System.Drawing.Size(207, 28)
        Me.cbBarang.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Jenis Barang"
        '
        'btnLookUnit
        '
        Me.btnLookUnit.Location = New System.Drawing.Point(600, 85)
        Me.btnLookUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookUnit.Name = "btnLookUnit"
        Me.btnLookUnit.Size = New System.Drawing.Size(61, 27)
        Me.btnLookUnit.TabIndex = 77
        Me.btnLookUnit.UseVisualStyleBackColor = True
        Me.btnLookUnit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUnit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtPetugasOrder
        '
        Me.txtPetugasOrder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPetugasOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetugasOrder.Location = New System.Drawing.Point(209, 54)
        Me.txtPetugasOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugasOrder.Name = "txtPetugasOrder"
        Me.txtPetugasOrder.Size = New System.Drawing.Size(372, 26)
        Me.txtPetugasOrder.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nomor Order"
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtNoOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOrder.Location = New System.Drawing.Point(209, 16)
        Me.txtNoOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(207, 30)
        Me.txtNoOrder.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Petugas Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama Unit"
        '
        'txtNamaUnit
        '
        Me.txtNamaUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaUnit.Location = New System.Drawing.Point(209, 85)
        Me.txtNamaUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaUnit.Name = "txtNamaUnit"
        Me.txtNamaUnit.ReadOnly = True
        Me.txtNamaUnit.Size = New System.Drawing.Size(372, 26)
        Me.txtNamaUnit.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telp"
        '
        'txtTelp
        '
        Me.txtTelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.Location = New System.Drawing.Point(209, 113)
        Me.txtTelp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.ReadOnly = True
        Me.txtTelp.Size = New System.Drawing.Size(207, 26)
        Me.txtTelp.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1468, 60)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.labelPetugasEntry)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(984, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(484, 60)
        Me.Panel4.TabIndex = 1
        '
        'labelPetugasEntry
        '
        Me.labelPetugasEntry.AutoSize = True
        Me.labelPetugasEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelPetugasEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPetugasEntry.ForeColor = System.Drawing.Color.OliveDrab
        Me.labelPetugasEntry.Location = New System.Drawing.Point(237, 26)
        Me.labelPetugasEntry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPetugasEntry.Name = "labelPetugasEntry"
        Me.labelPetugasEntry.Size = New System.Drawing.Size(189, 27)
        Me.labelPetugasEntry.TabIndex = 0
        Me.labelPetugasEntry.Text = "labelPetugasEntry"
        Me.labelPetugasEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucPenerimaanSterilisasiAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ParentPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucPenerimaanSterilisasiAdd"
        Me.Size = New System.Drawing.Size(1468, 727)
        Me.ParentPanel.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelToolStrip.ResumeLayout(False)
        Me.PanelToolStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnTglDatang.ResumeLayout(False)
        Me.pnTglDatang.PerformLayout()
        Me.gbInformasiOrder.ResumeLayout(False)
        Me.gbInformasiOrder.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ParentPanel As PanelLibs.GroupPanel
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPetugasOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbInformasiOrder As System.Windows.Forms.GroupBox
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents gridItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLookUnit As C1.Win.C1Input.C1Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents labelPetugasEntry As System.Windows.Forms.Label
    Friend WithEvents btnCetakLabelBarcode As System.Windows.Forms.Button
    Friend WithEvents btnCetakBuktiOrder As System.Windows.Forms.Button
    Friend WithEvents dtpTglDatang As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnTglDatang As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LblTgl As System.Windows.Forms.Label
    Friend WithEvents PanelToolStrip As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCetakLabelReuse As System.Windows.Forms.Button
    Friend WithEvents cbTypeOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLookPetugas As C1.Win.C1Input.C1Button
    Friend WithEvents txtPetugasSterilisasi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
