<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLookUpInstrumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLookUpInstrumen))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelJenis = New System.Windows.Forms.Panel()
        Me.PanelLooping = New System.Windows.Forms.Panel()
        Me.btnAlat = New C1.Win.C1Input.C1Button()
        Me.txtNamaAlat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.btnLookJenis = New C1.Win.C1Input.C1Button()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gvDaftar = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelJenis.SuspendLayout()
        Me.PanelLooping.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.gvDaftar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnOk)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 479)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 65)
        Me.Panel2.TabIndex = 3
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.CadetBlue
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(884, 18)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(108, 31)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Cancel"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.CadetBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(16, 18)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 31)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.PanelJenis)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnLookJenis)
        Me.Panel1.Controls.Add(Me.txtJenis)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 155)
        Me.Panel1.TabIndex = 4
        '
        'PanelJenis
        '
        Me.PanelJenis.Controls.Add(Me.PanelLooping)
        Me.PanelJenis.Controls.Add(Me.cmbJenis)
        Me.PanelJenis.Controls.Add(Me.Label6)
        Me.PanelJenis.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelJenis.Location = New System.Drawing.Point(0, 45)
        Me.PanelJenis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelJenis.Name = "PanelJenis"
        Me.PanelJenis.Size = New System.Drawing.Size(1008, 71)
        Me.PanelJenis.TabIndex = 107
        Me.PanelJenis.Visible = False
        '
        'PanelLooping
        '
        Me.PanelLooping.Controls.Add(Me.btnAlat)
        Me.PanelLooping.Controls.Add(Me.txtNamaAlat)
        Me.PanelLooping.Controls.Add(Me.Label2)
        Me.PanelLooping.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelLooping.Location = New System.Drawing.Point(0, 33)
        Me.PanelLooping.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLooping.Name = "PanelLooping"
        Me.PanelLooping.Size = New System.Drawing.Size(1008, 38)
        Me.PanelLooping.TabIndex = 107
        Me.PanelLooping.Visible = False
        '
        'btnAlat
        '
        Me.btnAlat.Location = New System.Drawing.Point(475, 4)
        Me.btnAlat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlat.Name = "btnAlat"
        Me.btnAlat.Size = New System.Drawing.Size(44, 25)
        Me.btnAlat.TabIndex = 99
        Me.btnAlat.Text = "..."
        Me.btnAlat.UseVisualStyleBackColor = True
        Me.btnAlat.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnAlat.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtNamaAlat
        '
        Me.txtNamaAlat.Location = New System.Drawing.Point(124, 4)
        Me.txtNamaAlat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaAlat.Name = "txtNamaAlat"
        Me.txtNamaAlat.ReadOnly = True
        Me.txtNamaAlat.Size = New System.Drawing.Size(347, 22)
        Me.txtNamaAlat.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Nama Alat"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Baru", "Perulangan"})
        Me.cmbJenis.Location = New System.Drawing.Point(124, 5)
        Me.cmbJenis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(164, 24)
        Me.cmbJenis.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Jenis Reuse"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Azure
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 116)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1008, 39)
        Me.Panel3.TabIndex = 90
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.TxtSearch)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(640, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(368, 39)
        Me.Panel7.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Search : "
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.White
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(85, 7)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(278, 27)
        Me.TxtSearch.TabIndex = 108
        '
        'btnLookJenis
        '
        Me.btnLookJenis.Location = New System.Drawing.Point(425, 17)
        Me.btnLookJenis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLookJenis.Name = "btnLookJenis"
        Me.btnLookJenis.Size = New System.Drawing.Size(44, 25)
        Me.btnLookJenis.TabIndex = 89
        Me.btnLookJenis.Text = "..."
        Me.btnLookJenis.UseVisualStyleBackColor = True
        Me.btnLookJenis.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookJenis.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(124, 17)
        Me.txtJenis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.ReadOnly = True
        Me.txtJenis.Size = New System.Drawing.Size(297, 22)
        Me.txtJenis.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Jenis ALKES"
        '
        'gvDaftar
        '
        Me.gvDaftar.AllowSort = False
        Me.gvDaftar.BackColor = System.Drawing.Color.White
        Me.gvDaftar.CaptionHeight = 17
        Me.gvDaftar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvDaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDaftar.Images.Add(CType(resources.GetObject("gvDaftar.Images"), System.Drawing.Image))
        Me.gvDaftar.Location = New System.Drawing.Point(0, 155)
        Me.gvDaftar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gvDaftar.Name = "gvDaftar"
        Me.gvDaftar.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gvDaftar.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gvDaftar.PreviewInfo.ZoomFactor = 75.0R
        Me.gvDaftar.PrintInfo.PageSettings = CType(resources.GetObject("gvDaftar.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gvDaftar.PropBag = resources.GetString("gvDaftar.PropBag")
        Me.gvDaftar.RowHeight = 18
        Me.gvDaftar.Size = New System.Drawing.Size(1008, 324)
        Me.gvDaftar.TabIndex = 20
        Me.gvDaftar.Text = "C1TrueDBGrid1"
        '
        'dlgLookUpInstrumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 544)
        Me.Controls.Add(Me.gvDaftar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "dlgLookUpInstrumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item ALKES"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelJenis.ResumeLayout(False)
        Me.PanelJenis.PerformLayout()
        Me.PanelLooping.ResumeLayout(False)
        Me.PanelLooping.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.gvDaftar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gvDaftar As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnLookJenis As C1.Win.C1Input.C1Button
    Friend WithEvents txtJenis As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents PanelJenis As System.Windows.Forms.Panel
    Friend WithEvents PanelLooping As System.Windows.Forms.Panel
    Friend WithEvents btnAlat As C1.Win.C1Input.C1Button
    Friend WithEvents txtNamaAlat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
