'Imports Microsoft.Data

Public Class Appointment

    '    Dim DbCon As SqlClient.SqlConnection
    '    Dim adaptor As SqlClient.SqlDataAdapter
    '    Dim ds As DataSet
    '    Dim clinicID As New Dictionary(Of Integer, String)
    '    Dim docID As New Dictionary(Of Integer, String)

    '    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        DBCon = New SqlClient.SqlConnection
    '        DbCon.ConnectionString = "Server='LAPTOP-O23E4BES';Database='AyushmanBhavahDB';Trusted_Connection=True;trustServerCertificate=True"
    '        Try
    '            DbCon.Open()
    '            Dim query = String.Format("SELECT DISTINCT Area FROM Hospital")
    '            adaptor = New SqlClient.SqlDataAdapter(query, DbCon)
    '            ds = New DataSet
    '            adaptor.Fill(ds, "Hospital")
    '            adaptor.Dispose()
    '            If ds.Tables("Hospital").Rows.Count > 0 Then
    '                Me.ComboBox1.Items.Clear()
    '                Dim i As Integer
    '                For i = 0 To ds.Tables("Hospital").Rows.Count - 1
    '                    With Me.ComboBox1.Items.Add(ds.Tables("Hospital").Rows(i).Item("Area"))

    '                    End With
    '                Next
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error in Database Connection! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Finally
    '            DbCon.Close()
    '        End Try
    '        change_label_color(Label2, Color.Silver)
    '        change_label_color(Label3, Color.Silver)
    '        change_label_color(Label4, Color.Silver)
    '        ComboBox2.Enabled = False
    '        ComboBox3.Enabled = False
    '        ComboBox4.Enabled = False
    '    End Sub

    '    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '        change_label_color(Label2, Color.Black)
    '        ComboBox2.Enabled = True

    '        change_label_color(Label3, Color.Silver)
    '        change_label_color(Label4, Color.Silver)
    '        ComboBox3.SelectedIndex = -1
    '        ComboBox4.SelectedIndex = -1
    '        ComboBox3.Items.Clear()
    '        ComboBox4.Items.Clear()
    '        ComboBox3.Enabled = False
    '        ComboBox4.Enabled = False

    '        Dim area As String = ComboBox1.Text
    '        clinicID.Clear()
    '        docID.Clear()
    '        Try
    '            DbCon.Open()
    '            Dim query = String.Format("SELECT Name, Id FROM Hospital WHERE Area = " + area)
    '            adaptor = New SqlClient.SqlDataAdapter(query, DbCon)
    '            ds = New DataSet
    '            adaptor.Fill(ds, "Hospital")
    '            adaptor.Dispose()
    '            If ds.Tables("Hospital").Rows.Count > 0 Then
    '                Me.ComboBox2.Items.Clear()
    '                Dim i As Integer
    '                For i = 0 To ds.Tables("Hospital").Rows.Count - 1
    '                    With Me.ComboBox2.Items.Add(ds.Tables("Hospital").Rows(i).Item("Name"))
    '                    End With
    '                    clinicID.Add(i, String.Format(ds.Tables("Hospital").Rows(i).Item("Id")))
    '                Next
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error in Database Connection! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Finally
    '            DbCon.Close()
    '        End Try
    '        WriteTextBox(0)
    '    End Sub

    '    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
    '        change_label_color(Label3, Color.Black)
    '        ComboBox3.Enabled = True

    '        change_label_color(Label4, Color.Silver)
    '        ComboBox4.Enabled = False
    '        ComboBox4.SelectedIndex = -1
    '        docID.Clear()
    '        Dim hospital As Integer = ComboBox2.SelectedIndex
    '        If hospital >= 0 Then
    '            Try
    '                DbCon.Open()
    '                Dim query = String.Format("SELECT Name, Id FROM Doctor WHERE ClinicID=" + clinicID(hospital))
    '                adaptor = New SqlClient.SqlDataAdapter(query, DbCon)
    '                ds = New DataSet
    '                adaptor.Fill(ds, "Doctor")
    '                adaptor.Dispose()
    '                If ds.Tables("Doctor").Rows.Count > 0 Then
    '                    Me.ComboBox3.Items.Clear()
    '                    Dim i As Integer
    '                    For i = 0 To ds.Tables("Doctor").Rows.Count - 1
    '                        With Me.ComboBox3.Items.Add(ds.Tables("Doctor").Rows(i).Item("Name"))
    '                        End With
    '                        docID.Add(i, String.Format(ds.Tables("Doctor").Rows(i).Item("Id")))
    '                    Next
    '                End If
    '            Catch ex As Exception
    '                MessageBox.Show("Error in Database Connection! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Finally
    '                DbCon.Close()
    '            End Try
    '        End If
    '        WriteTextBox(1)
    '    End Sub

    '    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
    '        change_label_color(Label4, Color.Black)
    '        ComboBox4.Enabled = True
    '        ComboBox4.SelectedIndex = -1

    '        Dim doctor As Integer = ComboBox3.SelectedIndex
    '        If doctor >= 0 Then
    '            ComboBox4.Items.Add("Monday")
    '            ComboBox4.Items.Add("Tuesday")
    '            ComboBox4.Items.Add("Wednesday")
    '            ComboBox4.Items.Add("Thursday")
    '            ComboBox4.Items.Add("Friday")
    '            ComboBox4.Items.Add("Saturday")
    '            ComboBox4.Items.Add("Sunday")
    '        End If
    '        WriteTextBox(2)
    '    End Sub

    '    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
    '        WriteTextBox(3)
    '    End Sub

    '    Private Sub change_label_color(lable As Label, color As Color)
    '        lable.ForeColor = color
    '    End Sub

    '    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
    '        Button1.BackColor = Color.FromArgb(240, 100, 100)
    '    End Sub

    '    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
    '        Button1.BackColor = Color.FromArgb(230, 70, 70)
    '    End Sub

    '    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
    '        Button2.BackColor = Color.FromArgb(50, 250, 50)
    '    End Sub

    '    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
    '        Button2.BackColor = Color.FromArgb(50, 220, 50)
    '    End Sub

    '    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '        ' to do
    '        ' when all 4 data are not selected prompt users to fill up required data
    '        ' when all 4 data are selected, add them to the database and generate a random id (appointment id)
    '    End Sub

    '    Private Sub WriteTextBox(info_at As Integer)
    '        Dim area As String = ComboBox1.Text
    '        Dim clinic As String = ComboBox2.Text
    '        Dim doctor As String = ComboBox3.Text
    '        Dim timing As String = ComboBox4.Text

    '        RichTextBox1.Text = ""
    '        RichTextBox1.AppendText("∘    AREA:        " + area + Environment.NewLine)

    '        Try
    '            DbCon.Open()
    '            If info_at = 0 Then
    '                RichTextBox1.AppendText("∘    CLINIC:      " + clinic + Environment.NewLine)
    '                RichTextBox1.AppendText("∘    SPECIALIST:  " + doctor + Environment.NewLine)
    '                RichTextBox1.AppendText("∘    TIME:        " + timing + Environment.NewLine)
    '            ElseIf info_at = 1 Then
    '                Dim query = String.Format($"SELECT * FROM Hospital WHERE Area={area} AND Id={clinicID(ComboBox2.SelectedIndex())}")
    '                adaptor = New SqlClient.SqlDataAdapter(query, DbCon)
    '                ds = New DataSet
    '                adaptor.Fill(ds, "Hospital")
    '                adaptor.Dispose()
    '                If ds.Tables("Hospital").Rows.Count > 0 Then
    '                    Dim clinicInfo As String = ""
    '                    clinicInfo += ds.Tables("Hospital").Rows(0).Item("Name") + Environment.NewLine
    '                    clinicInfo += "      ∙ Address:    " + ds.Tables("Hospital").Rows(0).Item("Address") + Environment.NewLine
    '                    clinicInfo += "      ∙ Open Hours:   " + ds.Tables("Hospital").Rows(0).Item("OpenHours") + Environment.NewLine
    '                    RichTextBox1.AppendText(Environment.NewLine)
    '                    RichTextBox1.AppendText("∘    CLINIC:      " + clinicInfo + Environment.NewLine)
    '                    RichTextBox1.AppendText("∘    SPECIALIST:  " + doctor + Environment.NewLine)
    '                    RichTextBox1.AppendText("∘    TIME:        " + timing + Environment.NewLine)
    '                End If
    '            ElseIf info_at = 2 Then
    '                Dim query = String.Format($"SELECT * FROM Hospital WHERE Area={area} AND Id={clinicID(ComboBox2.SelectedIndex())}")
    '                adaptor = New SqlClient.SqlDataAdapter(query, DbCon)
    '                ds = New DataSet
    '                adaptor.Fill(ds, "Hospital")
    '                adaptor.Dispose()
    '                If ds.Tables("Hospital").Rows.Count > 0 Then
    '                    Dim clinicInfo As String = ""
    '                    clinicInfo += ds.Tables("Hospital").Rows(0).Item("Name") + Environment.NewLine
    '                    clinicInfo += "      ∙ Address:    " + ds.Tables("Hospital").Rows(0).Item("Address") + Environment.NewLine
    '                    clinicInfo += "      ∙ Open Hours:    " + ds.Tables("Hospital").Rows(0).Item("OpenHours") + Environment.NewLine
    '                    RichTextBox1.AppendText(Environment.NewLine)
    '                    RichTextBox1.AppendText("∘    CLINIC:      " + clinicInfo + Environment.NewLine)

    '                    Dim docQuery = String.Format($"SELECT * FROM Doctor WHERE ClinicID={clinicID(ComboBox2.SelectedIndex())}")
    '                    adaptor = New SqlClient.SqlDataAdapter(docQuery, DbCon)
    '                    ds = New DataSet
    '                    adaptor.Fill(ds, "Doctor")
    '                    adaptor.Dispose()
    '                    If ds.Tables("Doctor").Rows.Count > 0 Then
    '                        Dim docInfo As String = ""
    '                        docInfo += ds.Tables("Doctor").Rows(0).Item("Name") + Environment.NewLine
    '                        docInfo += "      ∙ Degree:    " + String.Format(ds.Tables("Doctor").Rows(0).Item("Degree")) + Environment.NewLine
    '                        docInfo += "      ∙ Specialist:    " + ds.Tables("Doctor").Rows(0).Item("Specialist") + Environment.NewLine
    '                        docInfo += "      ∙ Fees:    " + String.Format(ds.Tables("Doctor").Rows(0).Item("Fees")) + Environment.NewLine
    '                        RichTextBox1.AppendText("∘    SPECIALIST:  " + docInfo + Environment.NewLine)
    '                        RichTextBox1.AppendText("∘    TIME:        " + ComboBox4.Text + Environment.NewLine)
    '                    End If
    '                End If
    '            ElseIf info_at = 3 Then
    '                Dim query = String.Format($"SELECT * FROM Hospital WHERE Area={area} AND Id={clinicID(ComboBox2.SelectedIndex())}")
    '                adaptor = New SqlClient.SqlDataAdapter(query, DbCon)
    '                ds = New DataSet
    '                adaptor.Fill(ds, "Hospital")
    '                adaptor.Dispose()
    '                If ds.Tables("Hospital").Rows.Count > 0 Then
    '                    Dim clinicInfo As String = ""
    '                    clinicInfo += ds.Tables("Hospital").Rows(0).Item("Name") + Environment.NewLine
    '                    clinicInfo += "      ∙ Address:    " + ds.Tables("Hospital").Rows(0).Item("Address") + Environment.NewLine
    '                    clinicInfo += "      ∙ Open Hours:    " + ds.Tables("Hospital").Rows(0).Item("OpenHours") + Environment.NewLine
    '                    RichTextBox1.AppendText(Environment.NewLine)
    '                    RichTextBox1.AppendText("∘    CLINIC:      " + clinicInfo + Environment.NewLine)

    '                    Dim docQuery = String.Format($"SELECT * FROM Doctor WHERE ClinicID={clinicID(ComboBox2.SelectedIndex())}")
    '                    adaptor = New SqlClient.SqlDataAdapter(docQuery, DbCon)
    '                    ds = New DataSet
    '                    adaptor.Fill(ds, "Doctor")
    '                    adaptor.Dispose()
    '                    If ds.Tables("Doctor").Rows.Count > 0 Then
    '                        Dim docInfo As String = ""
    '                        docInfo += ds.Tables("Doctor").Rows(0).Item("Name") + Environment.NewLine
    '                        docInfo += "      ∙ Degree:    " + String.Format(ds.Tables("Doctor").Rows(0).Item("Degree")) + Environment.NewLine
    '                        docInfo += "      ∙ Specialist:    " + ds.Tables("Doctor").Rows(0).Item("Specialist") + Environment.NewLine
    '                        docInfo += "      ∙ Fees:    " + String.Format(ds.Tables("Doctor").Rows(0).Item("Fees")) + Environment.NewLine
    '                        RichTextBox1.AppendText("∘    SPECIALIST:  " + docInfo + Environment.NewLine)

    '                        Dim dayQuery = String.Format($"SELECT {timing} FROM Doctor WHERE Id={docID(ComboBox3.SelectedIndex())}")
    '                        adaptor = New SqlClient.SqlDataAdapter(dayQuery, DbCon)
    '                        ds = New DataSet
    '                        adaptor.Fill(ds, "Doctor")
    '                        adaptor.Dispose()
    '                        If ds.Tables("Doctor").Rows.Count > 0 Then
    '                            Dim timeInfo As String = ""
    '                            Dim _time = ds.Tables("Doctor").Rows(0).Item(timing)
    '                            If IsDBNull(_time) Then
    '                                timeInfo = "Not Available"
    '                            Else
    '                                timeInfo = _time
    '                            End If
    '                            RichTextBox1.AppendText($"∘    TIME:        {timing} [ {timeInfo} ] {Environment.NewLine}")
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error in Database Connection! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Finally
    '            DbCon.Close()
    '        End Try
    '        RichTextBox1.SelectAll()
    '        RichTextBox1.SelectionFont = New Font("Segoe UI Historic", 12, FontStyle.Bold)
    '    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '        ComboBox1.Items.Clear()
    '        ComboBox2.Items.Clear()
    '        ComboBox3.Items.Clear()
    '        ComboBox4.Items.Clear()

    '        ComboBox1.SelectedIndex = -1
    '        ComboBox2.SelectedIndex = -1
    '        ComboBox3.SelectedIndex = -1
    '        ComboBox4.SelectedIndex = -1

    '        RichTextBox1.Text = ""
    '        clinicID.Clear()
    '        docID.Clear()
    '        Appointment_Load(sender, e)
    '    End Sub
End Class

