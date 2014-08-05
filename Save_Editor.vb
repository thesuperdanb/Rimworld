Imports System.IO
Imports System.Net
Imports System.IO.Compression
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class Save_Editor
    Dim user As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Private Sub Save_Editor_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.Location = New Point(Main_Form.Location.X + Main_Form.Width, Main_Form.Location.Y)
    End Sub

    Private Sub Save_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Lock()
        Me.Height = Main_Form.Height
        Me.Width = 228
        Mod_View.Nodes.Clear()
        For Each Dir As String In Directory.GetFiles(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves")
            Dir = Dir.Replace(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\", "")
            Dir = Dir.Replace(".rim", "")
            If Dir.Contains("Autosave") Then
            Else
                Mod_View.Nodes.Add(Dir)
            End If
        Next
        Call Unlock()
    End Sub

    Private Sub Max_Skills_Click(sender As Object, e As EventArgs) Handles Max_Skills.Click
        Call Lock()
        For Each tvn As TreeNode In Mod_View.Nodes
            If tvn.IsSelected = True Then
                Try
                    Dim list = Enumerable.Range(0, 20)
                    Dim fileContents As String
                    fileContents = My.Computer.FileSystem.ReadAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text & ".rim")
                    Dim i As Integer = 0
                    For Each obj In list
                        fileContents = fileContents.Replace("<level>" & i & "</level>", "<level>20</level>")
                        i += 1
                    Next
                    My.Computer.FileSystem.DeleteFile(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text & ".rim", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                    My.Computer.FileSystem.WriteAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text & ".rim", fileContents, True)
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        Next
        Call Unlock()
    End Sub

    Private Sub Save_Folder_Click(sender As Object, e As EventArgs) Handles Save_Folder.Click
        Call Lock()
        Process.Start(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves")
        Call Unlock()
    End Sub
End Class