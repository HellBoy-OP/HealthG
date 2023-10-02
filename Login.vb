Imports MongoDB.Bson

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button1.Checked = True
        Guna2Button2.Checked = False
        AssignValidation(Guna2TextBox1, ValidationType.Phone_Number)
        If Guna2CheckBox1.Checked Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Switch_Panel(StartPage.Guna2GradientPanel1, Register)
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Async Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If Not Check_Fields() Then
            MsgBox("Please fillup your phone number and password to login!", MsgBoxStyle.Information, "Login")
            Guna2TextBox1.Focus()
        Else
            Dim phone As String = Guna2TextBox1.Text
            Dim password As String = Guna2TextBox2.Text

            If phone.StartsWith("+91") Then
                phone = phone.Substring(3)
            End If

            Dim systemidhash = GenerateUniqueID()
            Dim userDocument As BsonDocument = Await mongodb.GetUser("phone", phone)

            If userDocument IsNot Nothing Then
                Dim dbpassword As String = userDocument("password").AsString
                If dbpassword = password Then
                    PresentUserData.Clear()
                    Guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149)
                    Guna2TextBox2.ForeColor = Color.FromArgb(125, 137, 149)
                    mongodb.UpdateUser("systemId", systemidhash, phone)
                    If Guna2CheckBox2.Checked = True Then
                        mongodb.RememberUser(True, phone)
                    Else
                        mongodb.RememberUser(False, phone)
                    End If
                    PresentUserData.Add("phone", phone)
                    PresentUserData.Add("password", dbpassword)
                    PresentUserData.Add("systemid", systemidhash)
                    PresentUserData.Add("name", userDocument("fullname").AsString)
                    PresentUserData.Add("email", userDocument("email").AsString)
                    PresentUserData.Add("joindate", userDocument("joindate").AsString)
                    Switch_Panel(Form1.Guna2Panel1, Dashboard)
                    Return
                Else
                    Guna2TextBox1.ForeColor = Color.Red
                    Guna2TextBox2.ForeColor = Color.Red
                    MsgBox("Invalid Phone Number or Password! If you are a new user please consider registering yourself!", MsgBoxStyle.Information, "Login")
                End If
            Else
                Guna2TextBox1.ForeColor = Color.Red
                Guna2TextBox2.ForeColor = Color.Red
                MsgBox("Invalid Phone Number or Password! If you are a new user please consider registering yourself!", MsgBoxStyle.Information, "Login")
            End If
        End If
    End Sub

    Private Function Check_Fields()
        If Guna2TextBox1.Text = "" Then
            Return False
        End If
        If Guna2TextBox2.Text = "" Then
            Return False
        End If
        Return True
    End Function
End Class