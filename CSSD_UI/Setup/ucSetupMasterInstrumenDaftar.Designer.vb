<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSetupMasterInstrumenDaftar
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
        Me.browseMasterInstrumen = New UILibs.BrowseTemp()
        Me.SuspendLayout()
        '
        'browseMasterInstrumen
        '
        Me.browseMasterInstrumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browseMasterInstrumen.Location = New System.Drawing.Point(0, 0)
        Me.browseMasterInstrumen.Name = "browseMasterInstrumen"
        Me.browseMasterInstrumen.Size = New System.Drawing.Size(810, 442)
        Me.browseMasterInstrumen.TabIndex = 1
        '
        'ucSetupMasterInstrumeDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.browseMasterInstrumen)
        Me.Name = "ucSetupMasterInstrumeDaftar"
        Me.Size = New System.Drawing.Size(810, 442)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browseMasterInstrumen As UILibs.BrowseTemp

End Class
