Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Red Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class
