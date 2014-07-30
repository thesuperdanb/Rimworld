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
        Me.Height = Main_Form.Height
        Me.Width = 228
        Mod_View.Nodes.Clear()
        For Each Dir As String In Directory.GetFiles(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves")
            Dir = Dir.Replace(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\", "")
            Mod_View.Nodes.Add(Dir)
        Next
    End Sub

    Private Sub Check_All_Click(sender As Object, e As EventArgs)
        For Each tvn As TreeNode In Mod_View.Nodes
            tvn.Checked = True
        Next
    End Sub

    Private Sub Max_Skills_Click(sender As Object, e As EventArgs) Handles Max_Skills.Click
        For Each tvn As TreeNode In Mod_View.Nodes
            If tvn.IsSelected = True Then
                Try
                    Dim fileContents As String
                    fileContents = My.Computer.FileSystem.ReadAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text)
                    fileContents = fileContents.Replace("<level>" & "0" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "1" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "1" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "2" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "3" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "4" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "5" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "6" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "7" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "8" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "9" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "10" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "11" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "12" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "13" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "14" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "15" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "16" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "17" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "18" & "</level>", "<level>20</level>")
                    fileContents = fileContents.Replace("<level>" & "19" & "</level>", "<level>20</level>")
                    My.Computer.FileSystem.DeleteFile(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                    My.Computer.FileSystem.WriteAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\" & tvn.Text, fileContents, True)
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        Next
    End Sub
End Class