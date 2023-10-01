Imports MongoDB.Bson

Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SystemIdHash = GenerateUniqueID()
        Dim userDocument As BsonDocument = Await mongodb.GetUser("systemId", SystemIdHash)
        If userDocument IsNot Nothing Then
            Dim remember = userDocument("remember").AsBoolean
            If remember Then
                Switch_Panel(Guna2Panel1, Dashboard)
            Else
                Switch_Panel(Guna2Panel1, StartPage)
            End If
        Else
            Switch_Panel(Guna2Panel1, StartPage)
        End If
    End Sub
End Class
