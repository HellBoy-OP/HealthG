Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switch_Panel(Login)
    End Sub

    Public Sub Switch_Panel(ByVal panel As Form)
        Guna2GradientPanel1.Controls.Clear()
        panel.TopLevel = False
        Guna2GradientPanel1.Controls.Add(panel)
        panel.Show()
    End Sub
End Class
