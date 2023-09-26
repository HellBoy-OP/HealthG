<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Appointment))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        Label5 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(40, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 0
        Label1.Text = "Select Area:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(262, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 23)
        Label2.TabIndex = 2
        Label2.Text = "Select Hospital:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(509, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 23)
        Label3.TabIndex = 4
        Label3.Text = "Select Specialists:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(776, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 23)
        Label4.TabIndex = 6
        Label4.Text = "Select Time:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(40, 70)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(165, 36)
        ComboBox1.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(262, 70)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(189, 36)
        ComboBox2.TabIndex = 8
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(509, 70)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(204, 36)
        ComboBox3.TabIndex = 9
        ' 
        ' ComboBox4
        ' 
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(778, 70)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(185, 36)
        ComboBox4.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(230), CByte(70), CByte(70))
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(843, 544)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 40)
        Button1.TabIndex = 11
        Button1.Text = "Reset ✘"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.PowderBlue
        RichTextBox1.BulletIndent = 4
        RichTextBox1.Cursor = Cursors.IBeam
        RichTextBox1.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(53, 160)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(910, 366)
        RichTextBox1.TabIndex = 12
        RichTextBox1.Text = ""
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Sitka Small Semibold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(695, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(268, 36)
        Label5.TabIndex = 13
        Label5.Text = "Filtered Information"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(50), CByte(220), CByte(50))
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(717, 544)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 40)
        Button2.TabIndex = 14
        Button2.Text = "Submit ✔"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Appointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1020, 625)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(RichTextBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Appointment"
        Text = "Appointment"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
