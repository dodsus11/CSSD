<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLaporanPelayananAlatDenganMesin
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
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnTampil = New C1.Win.C1Input.C1Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeMesin = New System.Windows.Forms.TextBox()
        Me.btnLookUpMesin = New C1.Win.C1Input.C1Button()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJenisMesin = New System.Windows.Forms.TextBox()
        Me.btnLookUpJenisMesin = New C1.Win.C1Input.C1Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtTipeMesin = New System.Windows.Forms.TextBox()
        Me.txtMesin = New System.Windows.Forms.TextBox()
        Me.pnTop.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(1072, 43)
        Me.pnTop.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(302, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Laporan Pelayanan Instrumen Dengan Mesin"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvLaporan)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1072, 345)
        Me.Panel4.TabIndex = 44
        '
        'dgvLaporan
        '
        Me.dgvLaporan.AllowUserToAddRows = False
        Me.dgvLaporan.AllowUserToDeleteRows = False
        Me.dgvLaporan.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaporan.Location = New System.Drawing.Point(0, 0)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.ReadOnly = True
        Me.dgvLaporan.Size = New System.Drawing.Size(1072, 345)
        Me.dgvLaporan.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1072, 56)
        Me.Panel2.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 444)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1072, 44)
        Me.Panel1.TabIndex = 42
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnExportExcel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(328, 44)
        Me.Panel6.TabIndex = 0
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(14, 8)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(140, 28)
        Me.btnExportExcel.TabIndex = 0
        Me.btnExportExcel.Text = "EXPORT EXCEL"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtMesin)
        Me.Panel5.Controls.Add(Me.txtTipeMesin)
        Me.Panel5.Controls.Add(Me.btnLookUpJenisMesin)
        Me.Panel5.Controls.Add(Me.txtJenisMesin)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.dtFrom)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.dtTo)
        Me.Panel5.Controls.Add(Me.btnLookUpMesin)
        Me.Panel5.Controls.Add(Me.txtKodeMesin)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.btnTampil)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1010, 56)
        Me.Panel5.TabIndex = 15
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(803, 13)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(90, 30)
        Me.btnTampil.TabIndex = 17
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        Me.btnTampil.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnTampil.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(540, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Mesin"
        '
        'txtKodeMesin
        '
        Me.txtKodeMesin.Location = New System.Drawing.Point(604, 9)
        Me.txtKodeMesin.Name = "txtKodeMesin"
        Me.txtKodeMesin.ReadOnly = True
        Me.txtKodeMesin.Size = New System.Drawing.Size(90, 20)
        Me.txtKodeMesin.TabIndex = 23
        '
        'btnLookUpMesin
        '
        Me.btnLookUpMesin.Location = New System.Drawing.Point(695, 8)
        Me.btnLookUpMesin.Name = "btnLookUpMesin"
        Me.btnLookUpMesin.Size = New System.Drawing.Size(46, 22)
        Me.btnLookUpMesin.TabIndex = 78
        Me.btnLookUpMesin.Text = "..."
        Me.btnLookUpMesin.UseVisualStyleBackColor = True
        Me.btnLookUpMesin.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUpMesin.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MM/yyyy"
        Me.dtTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(156, 9)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(100, 21)
        Me.dtTo.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(123, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "s/d"
        '
        'dtFrom
        '
        Me.dtFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(15, 9)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(97, 21)
        Me.dtFrom.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Jenis Mesin"
        '
        'txtJenisMesin
        '
        Me.txtJenisMesin.Location = New System.Drawing.Point(329, 9)
        Me.txtJenisMesin.Name = "txtJenisMesin"
        Me.txtJenisMesin.ReadOnly = True
        Me.txtJenisMesin.Size = New System.Drawing.Size(155, 20)
        Me.txtJenisMesin.TabIndex = 83
        '
        'btnLookUpJenisMesin
        '
        Me.btnLookUpJenisMesin.Location = New System.Drawing.Point(485, 8)
        Me.btnLookUpJenisMesin.Name = "btnLookUpJenisMesin"
        Me.btnLookUpJenisMesin.Size = New System.Drawing.Size(46, 22)
        Me.btnLookUpJenisMesin.TabIndex = 84
        Me.btnLookUpJenisMesin.Text = "..."
        Me.btnLookUpJenisMesin.UseVisualStyleBackColor = True
        Me.btnLookUpJenisMesin.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUpJenisMesin.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1072, 56)
        Me.Panel7.TabIndex = 6
        '
        'txtTipeMesin
        '
        Me.txtTipeMesin.Location = New System.Drawing.Point(329, 30)
        Me.txtTipeMesin.Name = "txtTipeMesin"
        Me.txtTipeMesin.ReadOnly = True
        Me.txtTipeMesin.Size = New System.Drawing.Size(155, 20)
        Me.txtTipeMesin.TabIndex = 85
        '
        'txtMesin
        '
        Me.txtMesin.Location = New System.Drawing.Point(604, 30)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.ReadOnly = True
        Me.txtMesin.Size = New System.Drawing.Size(168, 20)
        Me.txtMesin.TabIndex = 86
        '
        'ucLaporanPelayananAlatDenganMesin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucLaporanPelayananAlatDenganMesin"
        Me.Size = New System.Drawing.Size(1072, 488)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnLookUpJenisMesin As C1.Win.C1Input.C1Button
    Friend WithEvents txtJenisMesin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLookUpMesin As C1.Win.C1Input.C1Button
    Friend WithEvents txtKodeMesin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTampil As C1.Win.C1Input.C1Button
    Friend WithEvents txtTipeMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtMesin As System.Windows.Forms.TextBox

End Class
