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
        Me.Mod_View = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'Mod_View
        '
        Me.Mod_View.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mod_View.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Mod_View.FullRowSelect = True
        Me.Mod_View.Location = New System.Drawing.Point(0, 0)
        Me.Mod_View.Name = "Mod_View"
        Me.Mod_View.PathSeparator = ""
        Me.Mod_View.ShowPlusMinus = False
        Me.Mod_View.ShowRootLines = False
        Me.Mod_View.Size = New System.Drawing.Size(186, 461)
        Me.Mod_View.TabIndex = 0
        '
        'Download_Mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Mod_View)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Download_Mod"
        Me.ShowInTaskbar = False
        Me.Text = "Mods"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mod_View As System.Windows.Forms.TreeView
End Class
