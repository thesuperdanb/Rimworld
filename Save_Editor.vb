Imports System.IO
Imports System.Net
Imports System.IO.Compression
Imports System.Text
Imports System.Security.Cryptography

Public Class Save_Editor
    Dim user As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Private Sub Save_Editor_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.Location = New Point(Main_Form.Location.X + Main_Form.Width, Main_Form.Location.Y)
    End Sub

    Private Sub Save_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Main_Form.Height
        Me.Width = 228
        Mod_View.Nodes.Clear()
        For Each Dir As String In Directory.GetFiles(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves")
            Dir = Dir.Replace(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\", "")
            Mod_View.Nodes.Add(Dir)
        Next
    End Sub

    Private Sub Check_All_Click(sender As Object, e As EventArgs) Handles Check_All.Click
        For Each tvn As TreeNode In Mod_View.Nodes
            tvn.Checked = True
        Next
    End Sub

    Private Sub Max_Skills_Click(sender As Object, e As EventArgs) Handles Max_Skills.Click
        For Each tvn As TreeNode In Mod_View.Nodes
            If tvn.Checked = True Then
                Try
                    Dim fileContents As String
                    fileContents = My.Computer.FileSystem.ReadAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text)
                    fileContents = fileContents.Replace("<level>" & someString.Contains("[A-Z].") & "</level>", "<level>20</level>")
                    My.Computer.FileSystem.DeleteFile(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                    My.Computer.FileSystem.WriteAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text, fileContents, True)
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        Next
    End Sub
End Class