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
        Mod_View.Nodes.Clear()
        For Each Dir As String In Directory.GetFiles(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves")
            Dir = Dir.Replace(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves\", "")
            Mod_View.Nodes.Add(Dir)
        Next
    End Sub
End Class