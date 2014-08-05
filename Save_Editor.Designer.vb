<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Save_Editor
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
        Me.Max_Skills = New System.Windows.Forms.Button()
        Me.Save_Folder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Mod_View
        '
        Me.Mod_View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Mod_View.Dock = System.Windows.Forms.DockStyle.Top
        Me.Mod_View.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mod_View.FullRowSelect = True
        Me.Mod_View.Location = New System.Drawing.Point(0, 0)
        Me.Mod_View.Margin = New System.Windows.Forms.Padding(4)
        Me.Mod_View.Name = "Mod_View"
        Me.Mod_View.PathSeparator = ""
        Me.Mod_View.ShowLines = False
        Me.Mod_View.ShowPlusMinus = False
        Me.Mod_View.ShowRootLines = False
        Me.Mod_View.Size = New System.Drawing.Size(212, 125)
        Me.Mod_View.TabIndex = 3
        '
        'Max_Skills
        '
        Me.Max_Skills.Location = New System.Drawing.Point(12, 169)
        Me.Max_Skills.Name = "Max_Skills"
        Me.Max_Skills.Size = New System.Drawing.Size(188, 31)
        Me.Max_Skills.TabIndex = 5
        Me.Max_Skills.Text = "Max Skills"
        Me.Max_Skills.UseVisualStyleBackColor = True
        '
        'Save_Folder
        '
        Me.Save_Folder.Location = New System.Drawing.Point(12, 132)
        Me.Save_Folder.Name = "Save_Folder"
        Me.Save_Folder.Size = New System.Drawing.Size(188, 31)
        Me.Save_Folder.TabIndex = 13
        Me.Save_Folder.Text = "Save Folder"
        Me.Save_Folder.UseVisualStyleBackColor = True
        '
        'Save_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Save_Folder)
        Me.Controls.Add(Me.Max_Skills)
        Me.Controls.Add(Me.Mod_View)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Save_Editor"
        Me.ShowInTaskbar = False
        Me.Text = "Save Options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mod_View As System.Windows.Forms.TreeView
    Friend WithEvents Max_Skills As System.Windows.Forms.Button
    Friend WithEvents Save_Folder As System.Windows.Forms.Button
End Class
