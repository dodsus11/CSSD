<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSetupPetugasDaftar
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
        Me.browsePetugas = New UILibs.BrowseTemp()
        Me.SuspendLayout()
        '
        'browsePetugas
        '
        Me.browsePetugas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browsePetugas.Location = New System.Drawing.Point(0, 0)
        Me.browsePetugas.Name = "browsePetugas"
        Me.browsePetugas.Size = New System.Drawing.Size(938, 430)
        Me.browsePetugas.TabIndex = 1
        '
        'ucSetupPetugasDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.browsePetugas)
        Me.Name = "ucSetupPetugasDaftar"
        Me.Size = New System.Drawing.Size(938, 430)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browsePetugas As UILibs.BrowseTemp

End Class
