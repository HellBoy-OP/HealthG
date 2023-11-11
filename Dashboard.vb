
Imports MongoDB.Bson

Public Class Dashboard
    Private Async Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        ' Handles Logout Button
        Dim phone As String = PresentUserData.Item("phone")
        Dim currUser As BsonDocument = Await mongodb.GetUser("phone", phone)
        If currUser IsNot Nothing Then
            mongodb.RememberUser(False, phone)
            Switch_Panel(Form1.Guna2Panel1, StartPage)
        Else
            Switch_Panel(Form1.Guna2Panel1, StartPage)
        End If
        PresentUserData.Clear()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        ' Handles Appointment button
        Switch_Panel(Guna2Panel1, Appointment)
    End Sub
End Class



'Private is_clicked As New Dictionary(Of Button, Boolean)

'Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter
'    Dim entered_button As Button = DirectCast(sender, Button)
'    If is_clicked(entered_button) Then
'        entered_button.BackColor = Color.Silver
'    Else
'        entered_button.BackColor = Color.FromArgb(0, 156, 231)
'    End If
'End Sub

'Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave
'    Dim left_button As Button = DirectCast(sender, Button)
'    If is_clicked(left_button) Then
'        left_button.BackColor = Color.Silver
'    Else
'        left_button.BackColor = Color.Transparent
'    End If
'End Sub

'Private Sub Button1_Clicked(sender As Object, e As EventArgs) Handles Button1.Click
'    is_clicked(Button1) = True
'    For Each button In is_clicked.Keys
'        If button IsNot Button1 Then
'            is_clicked(button) = False
'        End If
'    Next
'    reset_button_color()
'    SwitchPanel(Home)
'End Sub

'Private Sub Button2_Clicked(sender As Object, e As EventArgs) Handles Button2.Click
'    is_clicked(Button2) = True
'    For Each button In is_clicked.Keys
'        If button IsNot Button2 Then
'            is_clicked(button) = False
'        End If
'    Next
'    reset_button_color()
'    SwitchPanel(Settings)
'End Sub

'Private Sub Button3_Clicked(sender As Object, e As EventArgs) Handles Button3.Click
'    is_clicked(Button3) = True
'    For Each button In is_clicked.Keys
'        If button IsNot Button3 Then
'            is_clicked(button) = False
'        End If
'    Next
'    reset_button_color()
'    SwitchPanel(Appointment)
'End Sub

'Private Sub Button4_Clicked(sender As Object, e As EventArgs) Handles Button4.Click
'    is_clicked(Button4) = True
'    For Each button In is_clicked.Keys
'        If button IsNot Button4 Then
'            is_clicked(button) = False
'        End If
'    Next
'    reset_button_color()
'    SwitchPanel(ContactUs)
'End Sub

'Private Sub reset_button_color()
'    For Each btn In is_clicked.Keys()
'        If is_clicked(btn) Then
'            btn.BackColor = Color.Silver
'            btn.ForeColor = Color.FromArgb(0, 156, 231)
'        Else
'            btn.BackColor = Color.Transparent
'            btn.ForeColor = Color.FromArgb(51, 51, 51)
'        End If
'    Next
'End Sub

'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    Button1.ForeColor = Color.FromArgb(0, 156, 231)
'    Button1.BackColor = Color.Silver

'    is_clicked.Add(Button1, True)
'    is_clicked.Add(Button2, False)
'    is_clicked.Add(Button3, False)
'    is_clicked.Add(Button4, False)

'    Dim today As String = DateTime.Today.ToString
'    Label3.Text = today
'    SwitchPanel(Home)
'End Sub

'Private Sub SwitchPanel(ByVal panel As Form)
'    Panel5.Controls.Clear()
'    panel.TopLevel = False
'    Panel5.Controls.Add(panel)
'    panel.Show()
'End Sub
