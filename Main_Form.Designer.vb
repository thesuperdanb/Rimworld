<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.Download_Panel = New System.Windows.Forms.Panel()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Control_Panel = New System.Windows.Forms.Panel()
        Me.Mod_Tools = New System.Windows.Forms.GroupBox()
        Me.Delete_Mod = New System.Windows.Forms.Button()
        Me.Show_Mod_Folder = New System.Windows.Forms.Button()
        Me.Save_Options = New System.Windows.Forms.GroupBox()
        Me.Save_Edit_Button = New System.Windows.Forms.Button()
        Me.Save_Folder = New System.Windows.Forms.Button()
        Me.Process_Options = New System.Windows.Forms.GroupBox()
        Me.Dev_Mode = New System.Windows.Forms.CheckBox()
        Me.Reset_Cache = New System.Windows.Forms.CheckBox()
        Me.Large_Address_Aware = New System.Windows.Forms.CheckBox()
        Me.Core_Options = New System.Windows.Forms.GroupBox()
        Me.Download_Core = New System.Windows.Forms.Button()
        Me.Reset_Core = New System.Windows.Forms.Button()
        Me.Mod_Sites = New System.Windows.Forms.GroupBox()
        Me.Nexus_Mods = New System.Windows.Forms.Button()
        Me.Coming_Soon = New System.Windows.Forms.Button()
        Me.Download_Mods = New System.Windows.Forms.Button()
        Me.Update_Client = New System.Windows.Forms.Button()
        Me.Game_Version = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Play_Game = New System.Windows.Forms.Button()
        Me.Mod_View = New System.Windows.Forms.TreeView()
        Me.Refresh_List = New System.Windows.Forms.Timer(Me.components)
        Me.Download_Panel.SuspendLayout()
        Me.Control_Panel.SuspendLayout()
        Me.Mod_Tools.SuspendLayout()
        Me.Save_Options.SuspendLayout()
        Me.Process_Options.SuspendLayout()
        Me.Core_Options.SuspendLayout()
        Me.Mod_Sites.SuspendLayout()
        Me.SuspendLayout()
        '
        'Download_Panel
        '
        Me.Download_Panel.Controls.Add(Me.ProgressBar)
        Me.Download_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Download_Panel.Location = New System.Drawing.Point(0, 395)
        Me.Download_Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Download_Panel.Name = "Download_Panel"
        Me.Download_Panel.Size = New System.Drawing.Size(725, 29)
        Me.Download_Panel.TabIndex = 0
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(725, 29)
        Me.ProgressBar.TabIndex = 3
        '
        'Control_Panel
        '
        Me.Control_Panel.Controls.Add(Me.Mod_Tools)
        Me.Control_Panel.Controls.Add(Me.Save_Options)
        Me.Control_Panel.Controls.Add(Me.Process_Options)
        Me.Control_Panel.Controls.Add(Me.Core_Options)
        Me.Control_Panel.Controls.Add(Me.Mod_Sites)
        Me.Control_Panel.Controls.Add(Me.Update_Client)
        Me.Control_Panel.Controls.Add(Me.Game_Version)
        Me.Control_Panel.Controls.Add(Me.Name_Label)
        Me.Control_Panel.Controls.Add(Me.Play_Game)
        Me.Control_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Control_Panel.Location = New System.Drawing.Point(349, 0)
        Me.Control_Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Control_Panel.Name = "Control_Panel"
        Me.Control_Panel.Size = New System.Drawing.Size(376, 395)
        Me.Control_Panel.TabIndex = 1
        '
        'Mod_Tools
        '
        Me.Mod_Tools.Controls.Add(Me.Delete_Mod)
        Me.Mod_Tools.Controls.Add(Me.Show_Mod_Folder)
        Me.Mod_Tools.Location = New System.Drawing.Point(7, 249)
        Me.Mod_Tools.Name = "Mod_Tools"
        Me.Mod_Tools.Size = New System.Drawing.Size(230, 77)
        Me.Mod_Tools.TabIndex = 22
        Me.Mod_Tools.TabStop = False
        Me.Mod_Tools.Text = "Mod Tools"
        '
        'Delete_Mod
        '
        Me.Delete_Mod.Location = New System.Drawing.Point(6, 25)
        Me.Delete_Mod.Name = "Delete_Mod"
        Me.Delete_Mod.Size = New System.Drawing.Size(105, 46)
        Me.Delete_Mod.TabIndex = 5
        Me.Delete_Mod.Text = "Delete Selected"
        Me.Delete_Mod.UseVisualStyleBackColor = True
        '
        'Show_Mod_Folder
        '
        Me.Show_Mod_Folder.Location = New System.Drawing.Point(119, 25)
        Me.Show_Mod_Folder.Name = "Show_Mod_Folder"
        Me.Show_Mod_Folder.Size = New System.Drawing.Size(105, 46)
        Me.Show_Mod_Folder.TabIndex = 7
        Me.Show_Mod_Folder.Text = "Mod Folder"
        Me.Show_Mod_Folder.UseVisualStyleBackColor = True
        '
        'Save_Options
        '
        Me.Save_Options.Controls.Add(Me.Save_Edit_Button)
        Me.Save_Options.Controls.Add(Me.Save_Folder)
        Me.Save_Options.Location = New System.Drawing.Point(7, 164)
        Me.Save_Options.Name = "Save_Options"
        Me.Save_Options.Size = New System.Drawing.Size(230, 79)
        Me.Save_Options.TabIndex = 21
        Me.Save_Options.TabStop = False
        Me.Save_Options.Text = "Save Options"
        '
        'Save_Edit_Button
        '
        Me.Save_Edit_Button.Location = New System.Drawing.Point(6, 25)
        Me.Save_Edit_Button.Name = "Save_Edit_Button"
        Me.Save_Edit_Button.Size = New System.Drawing.Size(105, 46)
        Me.Save_Edit_Button.TabIndex = 15
        Me.Save_Edit_Button.Text = "Save Editor"
        Me.Save_Edit_Button.UseVisualStyleBackColor = True
        '
        'Save_Folder
        '
        Me.Save_Folder.Location = New System.Drawing.Point(119, 25)
        Me.Save_Folder.Name = "Save_Folder"
        Me.Save_Folder.Size = New System.Drawing.Size(105, 46)
        Me.Save_Folder.TabIndex = 12
        Me.Save_Folder.Text = "Save Folder"
        Me.Save_Folder.UseVisualStyleBackColor = True
        '
        'Process_Options
        '
        Me.Process_Options.Controls.Add(Me.Dev_Mode)
        Me.Process_Options.Controls.Add(Me.Reset_Cache)
        Me.Process_Options.Controls.Add(Me.Large_Address_Aware)
        Me.Process_Options.Location = New System.Drawing.Point(7, 83)
        Me.Process_Options.Name = "Process_Options"
        Me.Process_Options.Size = New System.Drawing.Size(230, 75)
        Me.Process_Options.TabIndex = 20
        Me.Process_Options.TabStop = False
        Me.Process_Options.Text = "Process Options"
        '
        'Dev_Mode
        '
        Me.Dev_Mode.AutoSize = True
        Me.Dev_Mode.Checked = True
        Me.Dev_Mode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Dev_Mode.Location = New System.Drawing.Point(128, 25)
        Me.Dev_Mode.Name = "Dev_Mode"
        Me.Dev_Mode.Size = New System.Drawing.Size(99, 22)
        Me.Dev_Mode.TabIndex = 10
        Me.Dev_Mode.Text = "Dev Mode"
        Me.Dev_Mode.UseVisualStyleBackColor = True
        '
        'Reset_Cache
        '
        Me.Reset_Cache.AutoSize = True
        Me.Reset_Cache.Location = New System.Drawing.Point(6, 25)
        Me.Reset_Cache.Name = "Reset_Cache"
        Me.Reset_Cache.Size = New System.Drawing.Size(118, 22)
        Me.Reset_Cache.TabIndex = 9
        Me.Reset_Cache.Text = "Reset Cache"
        Me.Reset_Cache.UseVisualStyleBackColor = True
        '
        'Large_Address_Aware
        '
        Me.Large_Address_Aware.AutoSize = True
        Me.Large_Address_Aware.Checked = True
        Me.Large_Address_Aware.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Large_Address_Aware.Location = New System.Drawing.Point(6, 48)
        Me.Large_Address_Aware.Name = "Large_Address_Aware"
        Me.Large_Address_Aware.Size = New System.Drawing.Size(214, 22)
        Me.Large_Address_Aware.TabIndex = 11
        Me.Large_Address_Aware.Text = "4GB Large Address Aware"
        Me.Large_Address_Aware.UseVisualStyleBackColor = True
        '
        'Core_Options
        '
        Me.Core_Options.Controls.Add(Me.Download_Core)
        Me.Core_Options.Controls.Add(Me.Reset_Core)
        Me.Core_Options.Location = New System.Drawing.Point(243, 198)
        Me.Core_Options.Name = "Core_Options"
        Me.Core_Options.Size = New System.Drawing.Size(126, 128)
        Me.Core_Options.TabIndex = 19
        Me.Core_Options.TabStop = False
        Me.Core_Options.Text = "Core Options"
        '
        'Download_Core
        '
        Me.Download_Core.Location = New System.Drawing.Point(6, 23)
        Me.Download_Core.Name = "Download_Core"
        Me.Download_Core.Size = New System.Drawing.Size(115, 46)
        Me.Download_Core.TabIndex = 2
        Me.Download_Core.Text = "Reset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Online"
        Me.Download_Core.UseVisualStyleBackColor = True
        '
        'Reset_Core
        '
        Me.Reset_Core.Location = New System.Drawing.Point(6, 75)
        Me.Reset_Core.Name = "Reset_Core"
        Me.Reset_Core.Size = New System.Drawing.Size(115, 46)
        Me.Reset_Core.TabIndex = 16
        Me.Reset_Core.Text = "Reset Embedded"
        Me.Reset_Core.UseVisualStyleBackColor = True
        '
        'Mod_Sites
        '
        Me.Mod_Sites.Controls.Add(Me.Nexus_Mods)
        Me.Mod_Sites.Controls.Add(Me.Coming_Soon)
        Me.Mod_Sites.Controls.Add(Me.Download_Mods)
        Me.Mod_Sites.Location = New System.Drawing.Point(243, 12)
        Me.Mod_Sites.Name = "Mod_Sites"
        Me.Mod_Sites.Size = New System.Drawing.Size(126, 180)
        Me.Mod_Sites.TabIndex = 18
        Me.Mod_Sites.TabStop = False
        Me.Mod_Sites.Text = "Mod Sites"
        '
        'Nexus_Mods
        '
        Me.Nexus_Mods.Location = New System.Drawing.Point(6, 77)
        Me.Nexus_Mods.Name = "Nexus_Mods"
        Me.Nexus_Mods.Size = New System.Drawing.Size(115, 46)
        Me.Nexus_Mods.TabIndex = 13
        Me.Nexus_Mods.Text = "Nexus Mods"
        Me.Nexus_Mods.UseVisualStyleBackColor = True
        '
        'Coming_Soon
        '
        Me.Coming_Soon.Enabled = False
        Me.Coming_Soon.Location = New System.Drawing.Point(6, 25)
        Me.Coming_Soon.Name = "Coming_Soon"
        Me.Coming_Soon.Size = New System.Drawing.Size(115, 46)
        Me.Coming_Soon.TabIndex = 14
        Me.Coming_Soon.Text = "Coming Soon"
        Me.Coming_Soon.UseVisualStyleBackColor = True
        '
        'Download_Mods
        '
        Me.Download_Mods.Location = New System.Drawing.Point(6, 129)
        Me.Download_Mods.Name = "Download_Mods"
        Me.Download_Mods.Size = New System.Drawing.Size(115, 46)
        Me.Download_Mods.TabIndex = 6
        Me.Download_Mods.Text = "Ludeon Forums"
        Me.Download_Mods.UseVisualStyleBackColor = True
        '
        'Update_Client
        '
        Me.Update_Client.Location = New System.Drawing.Point(7, 332)
        Me.Update_Client.Name = "Update_Client"
        Me.Update_Client.Size = New System.Drawing.Size(362, 38)
        Me.Update_Client.TabIndex = 17
        Me.Update_Client.Text = "Update Game Launcher"
        Me.Update_Client.UseVisualStyleBackColor = True
        '
        'Game_Version
        '
        Me.Game_Version.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Game_Version.Location = New System.Drawing.Point(109, 373)
        Me.Game_Version.Name = "Game_Version"
        Me.Game_Version.Size = New System.Drawing.Size(260, 16)
        Me.Game_Version.TabIndex = 4
        Me.Game_Version.Text = "Missing File"
        Me.Game_Version.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Label.Location = New System.Drawing.Point(4, 373)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(99, 16)
        Me.Name_Label.TabIndex = 3
        Me.Name_Label.Text = "Made by Dan Baer"
        '
        'Play_Game
        '
        Me.Play_Game.Location = New System.Drawing.Point(7, 12)
        Me.Play_Game.Name = "Play_Game"
        Me.Play_Game.Size = New System.Drawing.Size(230, 65)
        Me.Play_Game.TabIndex = 0
        Me.Play_Game.Text = "Play"
        Me.Play_Game.UseVisualStyleBackColor = True
        '
        'Mod_View
        '
        Me.Mod_View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Mod_View.CheckBoxes = True
        Me.Mod_View.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mod_View.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mod_View.FullRowSelect = True
        Me.Mod_View.Location = New System.Drawing.Point(0, 0)
        Me.Mod_View.Margin = New System.Windows.Forms.Padding(4)
        Me.Mod_View.Name = "Mod_View"
        Me.Mod_View.PathSeparator = ""
        Me.Mod_View.ShowLines = False
        Me.Mod_View.ShowPlusMinus = False
        Me.Mod_View.ShowRootLines = False
        Me.Mod_View.Size = New System.Drawing.Size(349, 395)
        Me.Mod_View.TabIndex = 2
        '
        'Refresh_List
        '
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 424)
        Me.Controls.Add(Me.Mod_View)
        Me.Controls.Add(Me.Control_Panel)
        Me.Controls.Add(Me.Download_Panel)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rim World"
        Me.Download_Panel.ResumeLayout(False)
        Me.Control_Panel.ResumeLayout(False)
        Me.Control_Panel.PerformLayout()
        Me.Mod_Tools.ResumeLayout(False)
        Me.Save_Options.ResumeLayout(False)
        Me.Process_Options.ResumeLayout(False)
        Me.Process_Options.PerformLayout()
        Me.Core_Options.ResumeLayout(False)
        Me.Mod_Sites.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Download_Panel As System.Windows.Forms.Panel
    Friend WithEvents Control_Panel As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Play_Game As System.Windows.Forms.Button
    Friend WithEvents Download_Core As System.Windows.Forms.Button
    Friend WithEvents Name_Label As System.Windows.Forms.Label
    Friend WithEvents Game_Version As System.Windows.Forms.Label
    Friend WithEvents Delete_Mod As System.Windows.Forms.Button
    Friend WithEvents Download_Mods As System.Windows.Forms.Button
    Friend WithEvents Show_Mod_Folder As System.Windows.Forms.Button
    Friend WithEvents Mod_View As System.Windows.Forms.TreeView
    Friend WithEvents Reset_Cache As System.Windows.Forms.CheckBox
    Friend WithEvents Dev_Mode As System.Windows.Forms.CheckBox
    Friend WithEvents Large_Address_Aware As System.Windows.Forms.CheckBox
    Friend WithEvents Save_Folder As System.Windows.Forms.Button
    Friend WithEvents Nexus_Mods As System.Windows.Forms.Button
    Friend WithEvents Coming_Soon As System.Windows.Forms.Button
    Friend WithEvents Save_Edit_Button As System.Windows.Forms.Button
    Friend WithEvents Reset_Core As System.Windows.Forms.Button
    Friend WithEvents Update_Client As System.Windows.Forms.Button
    Friend WithEvents Mod_Sites As System.Windows.Forms.GroupBox
    Friend WithEvents Core_Options As System.Windows.Forms.GroupBox
    Friend WithEvents Process_Options As System.Windows.Forms.GroupBox
    Friend WithEvents Save_Options As System.Windows.Forms.GroupBox
    Friend WithEvents Mod_Tools As System.Windows.Forms.GroupBox
    Friend WithEvents Refresh_List As System.Windows.Forms.Timer

End Class
