Imports System.Management
Imports Microsoft.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button1.Checked = True
        Guna2Button2.Checked = False
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Switch_Panel(StartPage.Panel1, Register)
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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If Not Check_Fields() Then
            MsgBox("Please fillup your phone number and password to login!", MsgBoxStyle.Information, "Login")
        Else
            Dim phone As String = Guna2TextBox1.Text
            Dim password As String = Guna2TextBox2.Text

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
                Dim query = String.Format($"SELECT * FROM Users WHERE Phone='{phone}' AND Password='{password}'")
                adaptor = New SqlDataAdapter(query, DbCon)
                ds = New DataSet
                adaptor.Fill(ds, "Users")
                adaptor.Dispose()
                If ds.Tables("Users").Rows.Count = 0 Then
                    MsgBox("Invalid Phone Number or Password! If you are a new user please consider registering yourself!", MsgBoxStyle.Information, "Login")
                    DbCon.Close()
                    Return
                Else
                    DbCon.Close()
                    If Guna2CheckBox2.Checked = True Then
                        Dim update_cmd As New SqlCommand("UPDATE Users SET Remember=@to_remember, SystemIdHash=@systemidhash WHERE Phone=@phone;", DbCon)
                        Dim systemidhash = GenerateUniqueID()
                        update_cmd.Parameters.AddWithValue("phone", phone.ToString)
                        update_cmd.Parameters.AddWithValue("systemidhash", systemidhash.ToString)
                        update_cmd.Parameters.AddWithValue("to_remember", 0)
                        If DbCon.State = ConnectionState.Closed Then
                            DbCon.Open()
                        End If
                        update_cmd.ExecuteNonQuery()
                    Else
                        Dim update_cmd As New SqlCommand("UPDATE Users SET Remember=@to_remember WHERE Phone=@phone;", DbCon)
                        update_cmd.Parameters.AddWithValue("phone", phone.ToString)
                        update_cmd.Parameters.AddWithValue("to_remember", 1)
                        update_cmd.ExecuteNonQuery()
                        If DbCon.State = ConnectionState.Closed Then
                            DbCon.Open()
                        End If
                        update_cmd.ExecuteNonQuery()
                    End If
                    DbCon.Close()
                    Switch_Panel(Form1.Guna2Panel1, Dashboard)
                End If
            Catch ex As Exception
                MsgBox("Error in Database: " + ex.ToString, MsgBoxStyle.Information, "Login Error")
            End Try
        End If
    End Sub
End Class