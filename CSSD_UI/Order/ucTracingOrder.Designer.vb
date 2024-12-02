<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTracingOrder
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbTypeOrder = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnStatus = New C1.Win.C1Input.C1Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.btnLookUnit = New C1.Win.C1Input.C1Button()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnTampil = New C1.Win.C1Input.C1Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.txtNamaUnit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvDaftar = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIBS = New System.Windows.Forms.Label()
        Me.lblCSSD = New System.Windows.Forms.Label()
        Me.lblSterilisasi = New System.Windows.Forms.Label()
        Me.lblSetting = New System.Windows.Forms.Label()
        Me.lblPencucian = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvDaftar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1803, 48)
        Me.Panel2.TabIndex = 39
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1803, 48)
        Me.Panel7.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbTypeOrder)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.btnStatus)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.txtStatus)
        Me.Panel5.Controls.Add(Me.btnLookUnit)
        Me.Panel5.Controls.Add(Me.dtFrom)
        Me.Panel5.Controls.Add(Me.btnTampil)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.dtTo)
        Me.Panel5.Controls.Add(Me.txtNamaUnit)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1341, 48)
        Me.Panel5.TabIndex = 15
        '
        'cbTypeOrder
        '
        Me.cbTypeOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeOrder.FormattingEnabled = True
        Me.cbTypeOrder.Items.AddRange(New Object() {"ALL", "BIASA", "CITO"})
        Me.cbTypeOrder.Location = New System.Drawing.Point(1078, 6)
        Me.cbTypeOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTypeOrder.Name = "cbTypeOrder"
        Me.cbTypeOrder.Size = New System.Drawing.Size(128, 28)
        Me.cbTypeOrder.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(977, 10)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 20)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Jenis Order"
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(923, 7)
        Me.btnStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(39, 27)
        Me.btnStatus.TabIndex = 83
        Me.btnStatus.Text = "...."
        Me.btnStatus.UseVisualStyleBackColor = True
        Me.btnStatus.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnStatus.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(675, 11)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(739, 7)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(183, 26)
        Me.txtStatus.TabIndex = 81
        '
        'btnLookUnit
        '
        Me.btnLookUnit.Location = New System.Drawing.Point(619, 7)
        Me.btnLookUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookUnit.Name = "btnLookUnit"
        Me.btnLookUnit.Size = New System.Drawing.Size(39, 27)
        Me.btnLookUnit.TabIndex = 80
        Me.btnLookUnit.Text = "...."
        Me.btnLookUnit.UseVisualStyleBackColor = True
        Me.btnLookUnit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUnit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'dtFrom
        '
        Me.dtFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(20, 7)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(128, 24)
        Me.dtFrom.TabIndex = 11
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(1239, 7)
        Me.btnTampil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(99, 28)
        Me.btnTampil.TabIndex = 13
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        Me.btnTampil.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnTampil.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Unit"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MM/yyyy"
        Me.dtTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(181, 9)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(132, 24)
        Me.dtTo.TabIndex = 10
        '
        'txtNamaUnit
        '
        Me.txtNamaUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaUnit.Location = New System.Drawing.Point(376, 7)
        Me.txtNamaUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaUnit.Name = "txtNamaUnit"
        Me.txtNamaUnit.ReadOnly = True
        Me.txtNamaUnit.Size = New System.Drawing.Size(241, 26)
        Me.txtNamaUnit.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(148, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "s/d"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtFilter)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1347, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 48)
        Me.Panel3.TabIndex = 14
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(116, 9)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(332, 22)
        Me.txtFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Data"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(1803, 30)
        Me.pnTop.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(16, 6)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Tracing Order Sterilisasi"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvDaftar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 78)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1803, 370)
        Me.Panel4.TabIndex = 40
        '
        'dgvDaftar
        '
        Me.dgvDaftar.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgvDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDaftar.Location = New System.Drawing.Point(0, 0)
        Me.dgvDaftar.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDaftar.Name = "dgvDaftar"
        Me.dgvDaftar.Size = New System.Drawing.Size(1803, 370)
        Me.dgvDaftar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblIBS)
        Me.Panel1.Controls.Add(Me.lblCSSD)
        Me.Panel1.Controls.Add(Me.lblSterilisasi)
        Me.Panel1.Controls.Add(Me.lblSetting)
        Me.Panel1.Controls.Add(Me.lblPencucian)
        Me.Panel1.Controls.Add(Me.lblOrder)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 448)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1803, 92)
        Me.Panel1.TabIndex = 38
        '
        'lblIBS
        '
        Me.lblIBS.AutoSize = True
        Me.lblIBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBS.ForeColor = System.Drawing.Color.Black
        Me.lblIBS.Location = New System.Drawing.Point(512, 62)
        Me.lblIBS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIBS.Name = "lblIBS"
        Me.lblIBS.Size = New System.Drawing.Size(0, 18)
        Me.lblIBS.TabIndex = 11
        '
        'lblCSSD
        '
        Me.lblCSSD.AutoSize = True
        Me.lblCSSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSSD.ForeColor = System.Drawing.Color.Black
        Me.lblCSSD.Location = New System.Drawing.Point(685, 34)
        Me.lblCSSD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCSSD.Name = "lblCSSD"
        Me.lblCSSD.Size = New System.Drawing.Size(0, 18)
        Me.lblCSSD.TabIndex = 10
        '
        'lblSterilisasi
        '
        Me.lblSterilisasi.AutoSize = True
        Me.lblSterilisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterilisasi.ForeColor = System.Drawing.Color.Black
        Me.lblSterilisasi.Location = New System.Drawing.Point(509, 7)
        Me.lblSterilisasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSterilisasi.Name = "lblSterilisasi"
        Me.lblSterilisasi.Size = New System.Drawing.Size(0, 18)
        Me.lblSterilisasi.TabIndex = 9
        '
        'lblSetting
        '
        Me.lblSetting.AutoSize = True
        Me.lblSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetting.ForeColor = System.Drawing.Color.Black
        Me.lblSetting.Location = New System.Drawing.Point(236, 62)
        Me.lblSetting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSetting.Name = "lblSetting"
        Me.lblSetting.Size = New System.Drawing.Size(0, 18)
        Me.lblSetting.TabIndex = 8
        '
        'lblPencucian
        '
        Me.lblPencucian.AutoSize = True
        Me.lblPencucian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPencucian.ForeColor = System.Drawing.Color.Black
        Me.lblPencucian.Location = New System.Drawing.Point(179, 34)
        Me.lblPencucian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPencucian.Name = "lblPencucian"
        Me.lblPencucian.Size = New System.Drawing.Size(0, 18)
        Me.lblPencucian.TabIndex = 7
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.ForeColor = System.Drawing.Color.Black
        Me.lblOrder.Location = New System.Drawing.Point(140, 7)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 18)
        Me.lblOrder.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(380, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "GUDANG IBS : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(380, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(277, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "GUDANG STERILISASI SENTRAL : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(380, 7)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "STERILISASI : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(55, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SETTING PACKING : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(55, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PENCUCIAN : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ORDER : "
        '
        'ucTracingOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucTracingOrder"
        Me.Size = New System.Drawing.Size(1803, 540)
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvDaftar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvDaftar As System.Windows.Forms.DataGridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampil As C1.Win.C1Input.C1Button
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLookUnit As C1.Win.C1Input.C1Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIBS As System.Windows.Forms.Label
    Friend WithEvents lblCSSD As System.Windows.Forms.Label
    Friend WithEvents lblSterilisasi As System.Windows.Forms.Label
    Friend WithEvents lblSetting As System.Windows.Forms.Label
    Friend WithEvents lblPencucian As System.Windows.Forms.Label
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents btnStatus As C1.Win.C1Input.C1Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents cbTypeOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
