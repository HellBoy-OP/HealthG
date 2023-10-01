Imports MongoDB.Bson

Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button2.Checked = True
        Guna2Button1.Checked = False
        AssignValidation(Guna2TextBox1, ValidationType.Only_Name)
        AssignValidation(Guna2TextBox2, ValidationType.Phone_Number)
        AssignValidation(Guna2TextBox3, ValidationType.Only_Email)
        If Guna2CheckBox1.Checked Then
            Guna2TextBox5.UseSystemPasswordChar = False
        Else
            Guna2TextBox5.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Switch_Panel(StartPage.Guna2GradientPanel1, Login)
    End Sub

    Private Async Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If Not Check_Fields() Then
            MsgBox("Please fillup all the required fields and agree to the terms and conditions.", MsgBoxStyle.Information, "Register")
        Else
            If Not Guna2TextBox4.Text = Guna2TextBox5.Text Then
                Guna2TextBox4.ForeColor = Color.Red
                Guna2TextBox5.ForeColor = Color.Red
                MsgBox("Password does not match! Please try again.", MsgBoxStyle.Exclamation, "Register")
                Return
            Else
                Guna2TextBox4.ForeColor = Color.FromArgb(125, 137, 149)
                Guna2TextBox5.ForeColor = Color.FromArgb(125, 137, 149)
            End If
            If Guna2TextBox2.Text.Length < 10 Then
                MsgBox("Please use 10-digit phone number! Please try again.", MsgBoxStyle.Exclamation, "Register")
                Return
            End If
            Dim name As String = Guna2TextBox1.Text
            Dim phone As String = Guna2TextBox2.Text
            Dim email As String = Guna2TextBox3.Text
            Dim password As String = Guna2TextBox4.Text

            If phone.StartsWith("+91") Then
                phone = phone.Substring(3)
            End If

            Dim userDocument As BsonDocument = Await mongodb.GetUser("phone", phone)

            If userDocument Is Nothing Then
                Guna2TextBox2.ForeColor = Color.FromArgb(125, 137, 149)
                mongodb.InsertUser(name, email, password, phone)
                MsgBox("Registration Successful! Return to Login Page and login with your credentials!", MsgBoxStyle.OkOnly, "Successfull")
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""
                Guna2TextBox3.Text = ""
                Guna2TextBox4.Text = ""
                Guna2TextBox5.Text = ""
                Guna2CustomCheckBox1.Checked = False
                Guna2CheckBox1.Checked = False
                Switch_Panel(StartPage.Guna2GradientPanel1, Login)
            Else
                Guna2TextBox2.ForeColor = Color.Red
                MsgBox($"The Phone number: {phone} already exists in the Database. Please login using your password!", MsgBoxStyle.Exclamation, "Register")
            End If
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            Guna2TextBox5.UseSystemPasswordChar = False
        Else
            Guna2TextBox5.UseSystemPasswordChar = True
        End If
    End Sub

    Private Function Check_Fields()
        If Guna2TextBox1.Text = "" Then
            Return False
        End If
        If Guna2TextBox2.Text = "" Then
            Return False
        End If
        If Guna2TextBox4.Text = "" Then
            Return False
        End If
        If Guna2TextBox5.Text = "" Then
            Return False
        End If
        If Guna2CustomCheckBox1.Checked = False Then
            Return False
        End If
        Return True
    End Function
End Class