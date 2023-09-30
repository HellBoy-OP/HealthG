Imports Microsoft.Data.SqlClient

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
        Switch_Panel(Form1.Panel1, Login)
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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
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
            Dim today As String = DateTime.Today.ToString("yyyy-MM-dd")

            If phone.StartsWith("+91") Then
                phone = phone.Substring(3)
            End If

            DbCon = New SqlConnection With {
                .ConnectionString = DbAddress
            }
            Try
                If DbCon.State = ConnectionState.Closed Then
                    DbCon.Open()
                End If
                Dim query = String.Format($"SELECT * FROM Users WHERE Phone={phone}")
                adaptor = New SqlDataAdapter(query, DbCon)
                ds = New DataSet
                adaptor.Fill(ds, "Users")
                adaptor.Dispose()
                If ds.Tables("Users").Rows.Count > 0 Then
                    MsgBox($"The Phone number: {phone} already exists in the Database. Please login using your password!")
                    DbCon.Close()
                    Return
                End If
                DbCon.Close()
                Dim insert_cmd As New SqlCommand($"INSERT INTO Users (Name, Phone, Email, Password, JoinDate) VALUES (@name, @phone, @email, @password, @today);", DbCon)
                insert_cmd.Parameters.AddWithValue("name", name.ToString)
                insert_cmd.Parameters.AddWithValue("phone", phone.ToString)
                insert_cmd.Parameters.AddWithValue("password", password.ToString)
                insert_cmd.Parameters.AddWithValue("today", today.ToString)
                If email = "" Then
                    insert_cmd.Parameters.AddWithValue("email", DBNull.Value)
                Else
                    insert_cmd.Parameters.AddWithValue("email", email)
                End If
                If DbCon.State = ConnectionState.Closed Then
                    DbCon.Open()
                End If
                insert_cmd.ExecuteNonQuery()
                DbCon.Close()
                MsgBox("Registration Successful! Return to Login Page and login with your credentials!", MsgBoxStyle.OkOnly, "Successfull")
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""
                Guna2TextBox3.Text = ""
                Guna2TextBox4.Text = ""
                Guna2TextBox5.Text = ""
                Guna2CustomCheckBox1.Checked = False
                Guna2CheckBox1.Checked = False
                Switch_Panel(Form1.Panel1, Login)
            Catch ex As Exception
                MsgBox("Error in Database: " + ex.ToString, MsgBoxStyle.Information, "Registration Error")
            End Try
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            Guna2TextBox5.UseSystemPasswordChar = False
        Else
            Guna2TextBox5.UseSystemPasswordChar = True
        End If
    End Sub
End Class