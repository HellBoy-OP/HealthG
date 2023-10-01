Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class DatabaseClass
    Private ReadOnly DbClient As MongoClient
    Private ReadOnly Db As IMongoDatabase
    Private ReadOnly userCollection As IMongoCollection(Of BsonDocument)
    Private hospitalCollection As IMongoCollection(Of BsonDocument)
    Private doctorCollection As IMongoCollection(Of BsonDocument)

    Public Sub New()
        DbClient = New MongoClient("mongodb+srv://anand:imhell@ayushmaanbhavah.m39sdex.mongodb.net/?retryWrites=true&w=majority")
        Db = DbClient.GetDatabase("AyushmaanBhavahDB")
        userCollection = Db.GetCollection(Of BsonDocument)("Users")
        hospitalCollection = Db.GetCollection(Of BsonDocument)("Hospitals")
        doctorCollection = Db.GetCollection(Of BsonDocument)("Doctors")
    End Sub

    Public Async Sub InsertUser(fullname As String, email As String, password As String, phone As String)
        Dim userDocument = New BsonDocument From {
            {"fullname", fullname},
            {"phone", phone},
            {"email", email},
            {"password", password},
            {"remember", False},
            {"systemId", ""},
            {"joindate", DateTime.Today.ToString("dd-MM-yyyy")}
        }
        Await userCollection.InsertOneAsync(userDocument)
    End Sub

    Public Async Sub UpdateUser(key As String, value As Object, phone As String)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("phone", phone)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)(key, value)
        Await userCollection.UpdateOneAsync(filter, update)
    End Sub

    Public Async Sub RememberUser(remember As Boolean, phone As String)
        Try
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("phone", phone)
            Dim update = Builders(Of BsonDocument).Update.Set(Of Boolean)("remember", remember)
            Await userCollection.UpdateOneAsync(filter, update)
        Catch ex As Exception
            MsgBox("Error in Database: " + ex.ToString, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Public Async Sub DeleteUser(phone As String)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("phone", phone)
        Await userCollection.DeleteOneAsync(filter)
    End Sub

    Public Async Function GetUser(key As String, value As String) As Task(Of BsonDocument)
        Return Await userCollection.Find(New BsonDocument(key, value)).FirstOrDefaultAsync()
    End Function

End Class
