Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Object
        a = TimeOfDay()
        Label4.Text = a
        If (a >= FormatDateTime("8:00", 4) And a < FormatDateTime("12:00", 4)) Then
            Label2.Text = "Доброе утро!"
        ElseIf (a >= FormatDateTime("12:00", 4) And a < FormatDateTime("17:00", 4)) Then
            Label2.Text = "Добрый день!"
        ElseIf (a >= FormatDateTime("17:00", 4) And a < FormatDateTime("23:00", 4)) Then
            Label2.Text = "Добрый вечер!"
        Else
            Label2.Text = "Доброй ночи!"
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub
End Class