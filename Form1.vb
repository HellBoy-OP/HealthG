Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button1.Checked = True
        If Guna2CheckBox1.Checked Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class
