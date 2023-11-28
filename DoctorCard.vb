Public Class DoctorCard
    Public Sub New(doctorName As String, basicInfo As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetDoctorData(doctorName, basicInfo)
    End Sub

    Public Sub SetDoctorData(doctorName As String, basicInfo As String)
        doctorNameLabel.Text = doctorName
        doctorInfoTextBot.Text = basicInfo
        ' to do: add image of the doctor
    End Sub
End Class