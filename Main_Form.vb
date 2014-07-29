Imports System.IO
Imports System.Net
Imports System.IO.Compression
Imports System.Text
Imports System.Security.Cryptography

Public Class Main_Form
    Dim user As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Game_Version.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Version.txt")
        Catch ex As Exception
        End Try
        Refresh_List.Start()
        Dim Ram As Integer = (System.Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024)))
        If Ram < 4000 Then
            Large_Address_Aware.Enabled = False
            Large_Address_Aware.Checked = False
        End If
        Call Load_Mods()
        If My.Computer.Network.IsAvailable Then
        Else
            MsgBox("Can't connect to internet.")
            Download_Core.Enabled = False
        End If
    End Sub
    Private Sub Refresh_Mods_Click(sender As Object, e As EventArgs)
        Call Load_Mods()
    End Sub
    Private Sub Play_Game_Click(sender As Object, e As EventArgs) Handles Play_Game.Click
        If Reset_Cache.Checked Then
            Call Lock()
            ProgressBar.Value = "0"
            Try
                My.Computer.FileSystem.DeleteFile(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\ModsConfig.xml", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Catch ex As Exception
            End Try
            Call Unlock()
            ProgressBar.Value = "100"
        End If
        Call Lock()
        ProgressBar.Value = "0"
        If Dev_Mode.Checked Then
            Try
                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\Prefs.xml")
                fileContents = fileContents.Replace("<devMode>False</devMode>", "<devMode>True</devMode>")
                My.Computer.FileSystem.DeleteFile(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\Prefs.xml", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                My.Computer.FileSystem.WriteAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\Prefs.xml", fileContents, True)
            Catch ex As Exception
            End Try
        Else
            Try
                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\Prefs.xml")
                fileContents = fileContents.Replace("<devMode>True</devMode>", "<devMode>False</devMode>")
                My.Computer.FileSystem.DeleteFile(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\Prefs.xml", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                My.Computer.FileSystem.WriteAllText(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Config\Prefs.xml", fileContents, True)
            Catch ex As Exception
            End Try
        End If
        Call Unlock()
        ProgressBar.Value = "100"
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Mods\Core") Then
            If Large_Address_Aware.Checked Then
                Process.Start(My.Application.Info.DirectoryPath + "\4GB_Game.exe")
            Else
                Process.Start(My.Application.Info.DirectoryPath + "\Game.exe")
            End If

            End
        Else
            MsgBox("You Need To Download Core")
        End If
    End Sub
    Private Sub Load_Mods()
        Call Lock()
        ProgressBar.Value = "0"
        Mod_View.Nodes.Clear()
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Mods") Then
        Else
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\Mods")
        End If
        For Each Dir As String In Directory.GetDirectories(My.Application.Info.DirectoryPath + "\Mods")
            Try
                Dim reader As New System.IO.StreamReader(Dir & "\About\About.xml")
                Dim Name, author As String
                reader.ReadLine()
                reader.ReadLine()
                Name = reader.ReadLine()
                author = reader.ReadLine()
                reader.Close()
                Name = Name.Replace("<name>", "")
                Name = Name.Replace("</name>", "")
                Name = Name.Replace("  ", " ")
                author = author.Replace("<author>", "")
                author = author.Replace("</author>", "")
                author = author.Replace("  ", " ")
                Mod_View.Nodes.Add(Name & " By" & author)
            Catch ex As Exception
                Dir = Dir.Replace(My.Application.Info.DirectoryPath & "\Mods\", "")
                Dir = Trim(RegularExpressions.Regex.Replace(Dir, "[A-Z]", " ${0}"))
                Mod_View.Nodes.Add(" " & Dir)
            End Try
        Next

        Call Unlock()
    End Sub
    Private Sub Download_Core_Click(sender As Object, e As EventArgs) Handles Download_Core.Click
        Call Lock()
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Mods\Core") Then
            My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath + "\Mods\Core", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Download") Then
        Else
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\Download")
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Download\download.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\Download\download.zip", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        client.DownloadFileAsync(New Uri("http://chaostermialcom.ipage.com/Core.zip"), My.Application.Info.DirectoryPath & "\Download" & "\download.zip")
        Me.Text = "Download in Progress"
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Me.Text = "Download Is finished"
        ProgressBar.Value = "0"
        Dim zipPath As String = My.Application.Info.DirectoryPath & "\Download" & "\download.zip"
        Dim extractPath As String = My.Application.Info.DirectoryPath + "\Mods"
        ProgressBar.Value = "10"
        ZipFile.ExtractToDirectory(zipPath, extractPath)
        ProgressBar.Value = "99"
        Call Load_Mods()

    End Sub
    Private Sub Delete_Mod_Click(sender As Object, e As EventArgs) Handles Delete_Mod.Click
        Call Lock()
        For Each tvn As TreeNode In Mod_View.Nodes
            If tvn.Checked Then
                Dim Node As String = tvn.Text
                ProgressBar.Value = "0"
                My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\Mods\" & Node, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                ProgressBar.Value = "99"
            End If
        Next
        Call Load_Mods()
    End Sub
    Private Sub Lock()
        Dim cControl As Control
        For Each cControl In Me.Controls
            cControl.Enabled = False
        Next cControl
    End Sub
    Private Sub Unlock()
        Dim cControl As Control
        For Each cControl In Me.Controls
            cControl.Enabled = True
        Next cControl
    End Sub
    Private Sub Show_Mod_Folder_Click(sender As Object, e As EventArgs) Handles Show_Mod_Folder.Click
        Process.Start(My.Application.Info.DirectoryPath & "\Mods\")
    End Sub
    Private Sub Download_Mods_Click(sender As Object, e As EventArgs) Handles Download_Mods.Click
        Process.Start("http://rimworldgame.com/getmods")
    End Sub
    Private Sub Nexus_Mods_Click(sender As Object, e As EventArgs) Handles Nexus_Mods.Click
        Process.Start("http://www.nexusmods.com/rimworld/?")
    End Sub
    Private Sub Reset_Core_Click(sender As Object, e As EventArgs) Handles Reset_Core.Click
        Call Lock()
        ProgressBar.Value = "0"
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Mods\Core") Then
            My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath + "\Mods\Core", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If
        SaveFromResources(My.Application.Info.DirectoryPath & "\Download" & "\download.zip", My.Resources.Core)
        Dim zipPath As String = My.Application.Info.DirectoryPath & "\Download" & "\download.zip"
        Dim extractPath As String = My.Application.Info.DirectoryPath + "\Mods"
        ProgressBar.Value = "10"
        ZipFile.ExtractToDirectory(zipPath, extractPath)
        ProgressBar.Value = "99"
        Call Load_Mods()
    End Sub
    Public Sub SaveFromResources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub

    Private Sub Large_Address_Aware_CheckedChanged(sender As Object, e As EventArgs) Handles Large_Address_Aware.CheckedChanged
        Dim Ram As Integer = (System.Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024)))
        If Ram < 4000 Then
            Large_Address_Aware.Enabled = False
            Large_Address_Aware.Checked = False
        End If
    End Sub

    Private Sub Update_Client_Click(sender As Object, e As EventArgs) Handles Update_Client.Click
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Update.exe") Then
            Process.Start(My.Application.Info.DirectoryPath & "\Update.exe")
        Else
            SaveFromResources(My.Application.Info.DirectoryPath & "\Update.exe", My.Resources.Update)
            Process.Start(My.Application.Info.DirectoryPath & "\Update.exe")
        End If
        End
    End Sub
    Private Sub Save_Folder_Click(sender As Object, e As EventArgs) Handles Save_Folder.Click
        Process.Start(user & "\AppData\LocalLow\Ludeon Studios\RimWorld\Saves")
    End Sub

    Private Sub Refresh_List_Tick(sender As Object, e As EventArgs) Handles Refresh_List.Tick
        For Each tvn As TreeNode In Mod_View.Nodes
            If tvn.Checked Then Return
        Next
        Try
            Game_Version.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Version.txt")
        Catch ex As Exception
        End Try
        Mod_View.Nodes.Clear()
        For Each Dir As String In Directory.GetDirectories(My.Application.Info.DirectoryPath + "\Mods")
            Try
                Dim reader As New System.IO.StreamReader(Dir & "\About\About.xml")
                Dim Name, author As String
                reader.ReadLine()
                reader.ReadLine()
                Name = reader.ReadLine()
                author = reader.ReadLine()
                reader.Close()
                Name = Name.Replace("<name>", "")
                Name = Name.Replace("</name>", "")
                Name = Name.Replace("  ", " ")
                author = author.Replace("<author>", "")
                author = author.Replace("</author>", "")
                author = author.Replace("  ", " ")
                Mod_View.Nodes.Add(Name & " By" & author)
            Catch ex As Exception
                Dir = Dir.Replace(My.Application.Info.DirectoryPath & "\Mods\", "")
                Dir = Trim(RegularExpressions.Regex.Replace(Dir, "[A-Z]", " ${0}"))
                Mod_View.Nodes.Add(" " & Dir)
            End Try
        Next
    End Sub

    Private Sub EZ_Mod_Click(sender As Object, e As EventArgs) Handles EZ_Mod.Click
        If Download_Mod.Visible Then
            Download_Mod.Hide()
        Else
            Download_Mod.Show()
            Download_Mod.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
        End If
    End Sub
    Private Sub Main_Form_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Download_Mod.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
    End Sub
End Class
