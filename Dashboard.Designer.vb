<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.circle
        PictureBox1.Location = New Point(742, -197)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(634, 598)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.circle
        PictureBox2.InitialImage = My.Resources.Resources.circle
        PictureBox2.Location = New Point(-95, 416)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(549, 485)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(27, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 2
        Label3.Text = "Welcome to"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(104), CByte(25), CByte(228))
        Label1.Location = New Point(26, 46)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(127, 24)
        Label1.TabIndex = 11
        Label1.Text = "AYUSHMAN BHAVA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(19, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 20)
        Label5.TabIndex = 12
        Label5.Text = "----------------------------"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.HighlightText
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.ForeColor = Color.FromArgb(CByte(104), CByte(25), CByte(228))
        TextBox5.Location = New Point(66, 9)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(54, 45)
        TextBox5.TabIndex = 15
        TextBox5.Text = "Main Menu"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.ForeColor = Color.FromArgb(CByte(104), CByte(25), CByte(228))
        TextBox4.Location = New Point(62, 15)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 21)
        TextBox4.TabIndex = 7
        TextBox4.Text = "SETTINGS"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.ForeColor = Color.FromArgb(CByte(104), CByte(25), CByte(228))
        TextBox3.Location = New Point(60, 14)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 21)
        TextBox3.TabIndex = 6
        TextBox3.Text = "ABOUT US"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.FromArgb(CByte(104), CByte(25), CByte(228))
        TextBox2.Location = New Point(60, 15)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 21)
        TextBox2.TabIndex = 5
        TextBox2.Text = "APPOINTMENT"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(104), CByte(25), CByte(228))
        TextBox1.Location = New Point(67, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 21)
        TextBox1.TabIndex = 4
        TextBox1.Text = "HOME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(194, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(338, 46)
        Label4.TabIndex = 2
        Label4.Text = "SOUDIPTA MONDAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(194, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(212, 38)
        Label2.TabIndex = 1
        Label2.Text = "Good Morning, "
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(100), CByte(210), CByte(120))
        ClientSize = New Size(1280, 705)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
