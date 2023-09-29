Public Class Register

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button2.Checked = True
        Guna2Button1.Checked = False
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Form1.Switch_Panel(Login)
    End Sub
End Class