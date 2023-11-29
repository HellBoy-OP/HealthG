Imports MongoDB.Bson

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillUserData()
    End Sub

    Private Async Sub FillUserData()
        Dim userDocument As BsonDocument = Await mongodb.GetUser("phone", PresentUserData.Item("phone"))
        Dim name As String = userDocument("fullname").AsString
        Dim email As String = userDocument("email").AsString
        Dim phone As String = userDocument("phone").AsString

        namebox.Text = name
        emailbox.Text = email
        phonebox.Text = phone
        oldpasswordbox.Text = ""
        newpassword.Text = ""
        cnfnewpassword.Text = ""
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        FillUserData()
        oldpasswordbox.ForeColor = Color.Black
        newpassword.ForeColor = Color.Black
        cnfnewpassword.ForeColor = Color.Black
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim presentuserphone As String = PresentUserData.Item("phone")

        Dim name As String = namebox.Text
        If name IsNot "" Then
            mongodb.UpdateUser("fullname", name, presentuserphone)
        End If

        Dim email As String = emailbox.Text
        If email IsNot "" Then
            mongodb.UpdateUser("email", email, presentuserphone)
        End If

        Dim phone As String = phonebox.Text
        If phone IsNot "" Then
            mongodb.UpdateUser("phone", phone, presentuserphone)
        End If

        Dim oldpass As String = oldpasswordbox.Text
        If oldpass IsNot "" Then
            Dim newpass As String = newpassword.Text
            Dim cnfnewpass As String = cnfnewpassword.Text

            If oldpass = PresentUserData.Item("password") Then
                If newpass = cnfnewpass Then
                    mongodb.UpdateUser("password", newpass, presentuserphone)
                Else
                    oldpasswordbox.ForeColor = Color.Black
                    newpassword.ForeColor = Color.Red
                    cnfnewpassword.ForeColor = Color.Red
                    MsgBox("The password doesn't match! Try again.", MsgBoxStyle.Information, "Change Password")
                End If
            Else
                oldpasswordbox.ForeColor = Color.Red
                MsgBox("The password you entered is incorrect!", MsgBoxStyle.Information, "Change Password")
            End If
        End If

        MsgBox("Profile Updated!", MsgBoxStyle.OkOnly, "Profile")
    End Sub
End Class