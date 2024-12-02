<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMappingUserGudang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLookUpGudang = New C1.Win.C1Input.C1Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGudangTujuanDaftar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGudangTerdaftar = New System.Windows.Forms.TextBox()
        Me.btnLookUpUserHMIS = New C1.Win.C1Input.C1Button()
        Me.txtNamaUserHMIS = New System.Windows.Forms.TextBox()
        Me.txtUserHMIS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLookUpGudang)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtGudangTujuanDaftar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtGudangTerdaftar)
        Me.Panel1.Controls.Add(Me.btnLookUpUserHMIS)
        Me.Panel1.Controls.Add(Me.txtNamaUserHMIS)
        Me.Panel1.Controls.Add(Me.txtUserHMIS)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 361)
        Me.Panel1.TabIndex = 78
        '
        'btnLookUpGudang
        '
        Me.btnLookUpGudang.Location = New System.Drawing.Point(452, 132)
        Me.btnLookUpGudang.Name = "btnLookUpGudang"
        Me.btnLookUpGudang.Size = New System.Drawing.Size(46, 22)
        Me.btnLookUpGudang.TabIndex = 82
        Me.btnLookUpGudang.Text = "..."
        Me.btnLookUpGudang.UseVisualStyleBackColor = True
        Me.btnLookUpGudang.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUpGudang.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 14)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "MAPPING KE GUDANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 14)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "USER TERDAFTAR DI GUDANG"
        '
        'txtGudangTujuanDaftar
        '
        Me.txtGudangTujuanDaftar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtGudangTujuanDaftar.Location = New System.Drawing.Point(157, 132)
        Me.txtGudangTujuanDaftar.Name = "txtGudangTujuanDaftar"
        Me.txtGudangTujuanDaftar.ReadOnly = True
        Me.txtGudangTujuanDaftar.Size = New System.Drawing.Size(289, 20)
        Me.txtGudangTujuanDaftar.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "User HMIS"
        '
        'txtGudangTerdaftar
        '
        Me.txtGudangTerdaftar.BackColor = System.Drawing.Color.Khaki
        Me.txtGudangTerdaftar.Location = New System.Drawing.Point(157, 77)
        Me.txtGudangTerdaftar.Name = "txtGudangTerdaftar"
        Me.txtGudangTerdaftar.ReadOnly = True
        Me.txtGudangTerdaftar.Size = New System.Drawing.Size(289, 20)
        Me.txtGudangTerdaftar.TabIndex = 53
        '
        'btnLookUpUserHMIS
        '
        Me.btnLookUpUserHMIS.Location = New System.Drawing.Point(297, 9)
        Me.btnLookUpUserHMIS.Name = "btnLookUpUserHMIS"
        Me.btnLookUpUserHMIS.Size = New System.Drawing.Size(46, 22)
        Me.btnLookUpUserHMIS.TabIndex = 90
        Me.btnLookUpUserHMIS.Text = "..."
        Me.btnLookUpUserHMIS.UseVisualStyleBackColor = True
        Me.btnLookUpUserHMIS.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnLookUpUserHMIS.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'txtNamaUserHMIS
        '
        Me.txtNamaUserHMIS.BackColor = System.Drawing.Color.Khaki
        Me.txtNamaUserHMIS.Location = New System.Drawing.Point(157, 37)
        Me.txtNamaUserHMIS.Name = "txtNamaUserHMIS"
        Me.txtNamaUserHMIS.ReadOnly = True
        Me.txtNamaUserHMIS.Size = New System.Drawing.Size(289, 20)
        Me.txtNamaUserHMIS.TabIndex = 89
        '
        'txtUserHMIS
        '
        Me.txtUserHMIS.BackColor = System.Drawing.Color.Khaki
        Me.txtUserHMIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserHMIS.Location = New System.Drawing.Point(157, 9)
        Me.txtUserHMIS.Name = "txtUserHMIS"
        Me.txtUserHMIS.ReadOnly = True
        Me.txtUserHMIS.Size = New System.Drawing.Size(134, 20)
        Me.txtUserHMIS.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 14)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Nama User"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnTop.Controls.Add(Me.Label9)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(881, 43)
        Me.pnTop.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Mapping User Gudang"
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFooter.Controls.Add(Me.Panel3)
        Me.PanelFooter.Controls.Add(Me.Panel2)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 435)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(881, 53)
        Me.PanelFooter.TabIndex = 79
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBatal)
        Me.Panel3.Controls.Add(Me.btnSimpan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(490, 51)
        Me.Panel3.TabIndex = 4
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(119, 7)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(92, 34)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(21, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(92, 34)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(674, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 51)
        Me.Panel2.TabIndex = 3
        '
        'ucMappingUserGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnTop)
        Me.Name = "ucMappingUserGudang"
        Me.Size = New System.Drawing.Size(881, 488)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.PanelFooter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLookUpGudang As C1.Win.C1Input.C1Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGudangTujuanDaftar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGudangTerdaftar As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLookUpUserHMIS As C1.Win.C1Input.C1Button
    Friend WithEvents txtNamaUserHMIS As System.Windows.Forms.TextBox
    Friend WithEvents txtUserHMIS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
