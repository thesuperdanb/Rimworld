Module Lock_Unlock
    Public Sub Lock()
        Dim cControl As Control
        For Each cControl In Main_Form.Controls
            cControl.Enabled = False
        Next cControl
        Dim BControl As Control
        For Each BControl In Save_Editor.Controls
            BControl.Enabled = False
        Next BControl
    End Sub
    Public Sub Unlock()
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Game.exe") Then
        Else
            Main_Form.Play_Game.Enabled = False
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/4GB_Game.exe") Then
        Else
            Main_Form.Large_Address_Aware.Enabled = False
        End If
        Dim cControl As Control
        For Each cControl In Main_Form.Controls
            cControl.Enabled = True
        Next cControl
        Dim BControl As Control
        For Each BControl In Save_Editor.Controls
            BControl.Enabled = True
        Next BControl
    End Sub
End Module
