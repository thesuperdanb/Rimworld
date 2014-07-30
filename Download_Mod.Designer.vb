<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download_Mod
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
        Me.Mod_Flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Mod_Flow
        '
        Me.Mod_Flow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mod_Flow.Location = New System.Drawing.Point(0, 0)
        Me.Mod_Flow.Name = "Mod_Flow"
        Me.Mod_Flow.Size = New System.Drawing.Size(186, 461)
        Me.Mod_Flow.TabIndex = 0
        '
        'Download_Mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Mod_Flow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Download_Mod"
        Me.ShowInTaskbar = False
        Me.Text = "Mods"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mod_Flow As System.Windows.Forms.FlowLayoutPanel
End Class
