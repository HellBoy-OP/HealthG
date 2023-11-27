Public Class Home
    Private WithEvents updateTimer As New Timer()

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentTime As DateTime = DateTime.Now()
        Dim greeting As String
        Dim userName As String = PresentUserData.Item("name")

        If currentTime.Hour < 4 Then
            greeting = "Welcome, "
        ElseIf currentTime.Hour < 12 Then
            greeting = "Good Morning, "
        ElseIf currentTime.Hour < 18 Then
            greeting = "Good Afternoon, "
        Else
            greeting = "Good Evening, "
        End If

        greeting += userName
        greetingLabel.Text = greeting

        SetTimeInterval()
        DisplayCurrentTime()
        updateTimer.Start()
    End Sub

    Private Sub DisplayCurrentTime()
        Dim currentDateTime As DateTime = DateTime.Now()
        Dim formatedString As String = currentDateTime.ToString("dd/MM/yyyy - HH:mm")

        datetime_label.Text = formatedString
    End Sub

    Private Sub UpdateTimerTick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        DisplayCurrentTime()
        SetTimeInterval()
    End Sub

    Private Sub SetTimeInterval()
        Dim timeLeft As Integer = 60 - DateTime.Now.Second
        updateTimer.Interval = timeLeft * 1000
    End Sub
End Class