Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SystemIdHash = GenerateUniqueID()
        DbCon = New SqlConnection With {.ConnectionString = DbAddress}
        Try
            If DbCon.State = ConnectionState.Closed Then
                DbCon.Open()
            End If
            Dim query = String.Format("SELECT * FROM Users WHERE Remember=0 AND SystemIdHash='" + SystemIdHash.ToString + "'")
            adaptor = New SqlDataAdapter(query, DbCon)
            ds = New DataSet
            adaptor.Fill(ds, "Users")
            adaptor.Dispose()
            If ds.Tables("Users").Rows.Count = 0 Then
                Switch_Panel(Guna2Panel1, StartPage)
            Else
                Switch_Panel(Guna2Panel1, Dashboard)
            End If
            DbCon.Close()
        Catch ex As Exception
            MsgBox("Error in Database: " + ex.ToString, MsgBoxStyle.Information, "Login Error")
        End Try
    End Sub
End Class
