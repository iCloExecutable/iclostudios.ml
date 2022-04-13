Public Class Form1

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SystemAbou.ShowDialog()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = ("Netflix25") Then
            NetflixForm.ShowDialog()
        ElseIf TextBox1.Text = ("Google50") Then
            Google50TUR.ShowDialog()
        ElseIf TextBox1.Text = ("Google100") Then
            Google100.ShowDialog()
        ElseIf TextBox1.Text = ("GoPRO") Then
            GoPRO2014.ShowDialog()
        ElseIf TextBox1.Text = ("WinSoft") Then
            Software.ShowDialog()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EnterNameOauth.ShowDialog()

    End Sub
End Class
