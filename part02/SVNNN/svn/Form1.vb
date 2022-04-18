Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FormatDateTime(TextBox1.Text, 4) >= FormatDateTime("8:00", 4) And FormatDateTime(TextBox1.Text, 4) < FormatDateTime("12:00", 4)) Then
            Label2.Text = "Доброе утро!"
        ElseIf (FormatDateTime(TextBox1.Text, 4) >= FormatDateTime("12:00", 4) And FormatDateTime(TextBox1.Text, 4) < FormatDateTime("17:00", 4)) Then
            Label2.Text = "Добрый день!"
        ElseIf (FormatDateTime(TextBox1.Text, 4) >= FormatDateTime("17:00", 4) And FormatDateTime(TextBox1.Text, 4) < FormatDateTime("23:00", 4)) Then
            Label2.Text = "Добрый вечер!"
        Else
            Label2.Text = "Доброй ночи!"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
