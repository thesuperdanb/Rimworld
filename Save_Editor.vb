Public Class Save_Editor

    Private Sub Save_Editor_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.Location = New Point(Main_Form.Location.X + Main_Form.Width, Main_Form.Location.Y)
    End Sub
End Class