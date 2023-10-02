Imports MongoDB.Bson

Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SystemIdHash = GenerateUniqueID()
        Dim userDocument As BsonDocument = Await mongodb.GetUser("systemId", SystemIdHash)
        If userDocument IsNot Nothing Then
            Dim remember = userDocument("remember").AsBoolean
            If remember Then
                PresentUserData.Clear()
                PresentUserData.Add("phone", userDocument("phone").AsString)
                PresentUserData.Add("password", userDocument("password").AsString)
                PresentUserData.Add("systemid", SystemIdHash)
                PresentUserData.Add("name", userDocument("fullname").AsString)
                PresentUserData.Add("email", userDocument("email").AsString)
                PresentUserData.Add("joindate", userDocument("joindate").AsString)
                Switch_Panel(Guna2Panel1, Dashboard)
            Else
                Switch_Panel(Guna2Panel1, StartPage)
            End If
        Else
            Switch_Panel(Guna2Panel1, StartPage)
        End If
    End Sub
End Class
