Imports System.Management
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Module Module1
    ''' Here we store global variables and global modules '''

    Public PresentUserData As New Dictionary(Of String, String)
    Public mongodb As New DatabaseClass()

    Public Sub Switch_Panel(ByVal panel As Panel, ByVal form As Form)
        panel.Controls.Clear()
        form.Show()
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Location = New Point((panel.Width - form.Width) / 2, (panel.Height - form.Height) / 2)
        form.Refresh()
    End Sub

    Public Function GenerateUniqueID() As String
        Dim macAddress As String = GetMacAddress()
        Dim serialNumber As String = GetHardDriveSerialNumber()
        Dim uniqueID As String = macAddress & serialNumber
        Return uniqueID
    End Function

    Private Function GetMacAddress() As String
        Dim macAddress As String = String.Empty
        Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If macAddress = String.Empty Then
                If CBool(mo("IPEnabled")) Then
                    macAddress = mo("MacAddress").ToString()
                    Exit For
                End If
            End If
        Next
        Return macAddress
    End Function

    Private Function GetHardDriveSerialNumber() As String
        Dim serialNumber As String = String.Empty
        Dim mc As New ManagementClass("Win32_DiskDrive")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            serialNumber = mo("SerialNumber").ToString()
            Exit For
        Next
        Return serialNumber
    End Function

    Public Enum ValidationType
        Only_Numbers = 1
        Only_Name = 2
        Not_Null = 3
        Only_Email = 4
        Phone_Number = 5
    End Enum

    Public Sub AssignValidation(ByRef CTRL As Guna2TextBox, ByVal Validation_Type As ValidationType)
        Dim txt As Guna2TextBox = CTRL
        Select Case Validation_Type
            Case ValidationType.Only_Numbers
                AddHandler txt.KeyPress, AddressOf Number_Leave
            Case ValidationType.Only_Name
                AddHandler txt.KeyPress, AddressOf OCHAR_Leave
            Case ValidationType.Not_Null
                AddHandler txt.Leave, AddressOf NotNull_Leave
            Case ValidationType.Only_Email
                AddHandler txt.Leave, AddressOf Email_Leave
            Case ValidationType.Phone_Number
                AddHandler txt.KeyPress, AddressOf Phonenumber_Leave
        End Select
    End Sub

    Public Sub Number_Leave(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim numbers As Guna2TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Public Sub Phonenumber_Leave(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim numbers As Guna2TextBox = sender
        If numbers.Text.Length >= 13 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Public Sub OCHAR_Leave(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " "c Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Public Sub NotNull_Leave(ByVal sender As Object, ByVal e As EventArgs)
        Dim No As Guna2TextBox = sender
        If No.Text.Trim = "" Then
            MsgBox("You need to fill this field!")
            No.Focus()
        End If
    End Sub

    Public Sub Email_Leave(ByVal sender As Object, ByVal e As EventArgs)
        Dim Email As Guna2TextBox = sender
        If Email.Text <> "" Then
            Dim rex As Match = Regex.Match(Trim(Email.Text), "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
            If rex.Success = False Then
                MessageBox.Show("Please Enter a valid Email Address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Email.ForeColor = Color.Red
                Email.Focus()
                Exit Sub
            Else
                Email.ForeColor = Color.FromArgb(125, 137, 149)
            End If
        End If
    End Sub
End Module
