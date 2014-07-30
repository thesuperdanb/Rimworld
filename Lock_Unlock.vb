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
