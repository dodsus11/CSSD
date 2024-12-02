<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGudangDaftar
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
        Me.browseMasterGudang = New UILibs.BrowseTemp()
        Me.SuspendLayout()
        '
        'browseMasterGudang
        '
        Me.browseMasterGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browseMasterGudang.Location = New System.Drawing.Point(0, 0)
        Me.browseMasterGudang.Name = "browseMasterGudang"
        Me.browseMasterGudang.Size = New System.Drawing.Size(801, 382)
        Me.browseMasterGudang.TabIndex = 2
        '
        'ucGudangDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.browseMasterGudang)
        Me.Name = "ucGudangDaftar"
        Me.Size = New System.Drawing.Size(801, 382)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browseMasterGudang As UILibs.BrowseTemp

End Class
