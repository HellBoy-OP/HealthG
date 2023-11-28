<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorCard
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        doctorNameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        doctorInfoTextBot = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2CustomGradientPanel2.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel2
        ' 
        Guna2CustomGradientPanel2.BackColor = Color.Transparent
        Guna2CustomGradientPanel2.BorderColor = Color.LightCyan
        Guna2CustomGradientPanel2.BorderRadius = 28
        Guna2CustomGradientPanel2.BorderThickness = 3
        Guna2CustomGradientPanel2.Controls.Add(doctorNameLabel)
        Guna2CustomGradientPanel2.Controls.Add(Guna2PictureBox1)
        Guna2CustomGradientPanel2.Controls.Add(Guna2GradientButton1)
        Guna2CustomGradientPanel2.Controls.Add(doctorInfoTextBot)
        CustomizableEdges7.BottomLeft = False
        CustomizableEdges7.BottomRight = False
        CustomizableEdges7.TopLeft = False
        CustomizableEdges7.TopRight = False
        Guna2CustomGradientPanel2.CustomizableEdges = CustomizableEdges7
        Guna2CustomGradientPanel2.FillColor = Color.SkyBlue
        Guna2CustomGradientPanel2.FillColor2 = Color.Lavender
        Guna2CustomGradientPanel2.FillColor3 = Color.LightSkyBlue
        Guna2CustomGradientPanel2.FillColor4 = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Guna2CustomGradientPanel2.Location = New Point(0, 0)
        Guna2CustomGradientPanel2.Margin = New Padding(2)
        Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Guna2CustomGradientPanel2.ShadowDecoration.BorderRadius = 28
        Guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2CustomGradientPanel2.ShadowDecoration.Enabled = True
        Guna2CustomGradientPanel2.ShadowDecoration.Shadow = New Padding(7)
        Guna2CustomGradientPanel2.Size = New Size(280, 360)
        Guna2CustomGradientPanel2.TabIndex = 27
        ' 
        ' doctorNameLabel
        ' 
        doctorNameLabel.AutoSize = False
        doctorNameLabel.AutoSizeHeightOnly = True
        doctorNameLabel.BackColor = Color.Transparent
        doctorNameLabel.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        doctorNameLabel.Location = New Point(9, 45)
        doctorNameLabel.Name = "doctorNameLabel"
        doctorNameLabel.Size = New Size(126, 47)
        doctorNameLabel.TabIndex = 25
        doctorNameLabel.Text = "doctor name goes here"
        doctorNameLabel.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.BorderRadius = 28
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = My.Resources.Resources.demo
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(140, 10)
        Guna2PictureBox1.Margin = New Padding(2)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.BorderRadius = 28
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.ShadowDecoration.Depth = 1
        Guna2PictureBox1.ShadowDecoration.Enabled = True
        Guna2PictureBox1.ShadowDecoration.Shadow = New Padding(2)
        Guna2PictureBox1.Size = New Size(123, 128)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Animated = True
        Guna2GradientButton1.AnimatedGIF = True
        Guna2GradientButton1.AutoRoundedCorners = True
        Guna2GradientButton1.BackColor = Color.Transparent
        Guna2GradientButton1.BorderColor = Color.DarkGray
        Guna2GradientButton1.BorderRadius = 20
        Guna2GradientButton1.BorderThickness = 2
        Guna2GradientButton1.Cursor = Cursors.Hand
        CustomizableEdges3.BottomRight = False
        CustomizableEdges3.TopLeft = False
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Guna2GradientButton1.FillColor2 = Color.Turquoise
        Guna2GradientButton1.Font = New Font("Bahnschrift SemiBold Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.DarkCyan
        Guna2GradientButton1.Location = New Point(75, 299)
        Guna2GradientButton1.Margin = New Padding(2)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.BorderRadius = 22
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton1.ShadowDecoration.Depth = 10
        Guna2GradientButton1.ShadowDecoration.Enabled = True
        Guna2GradientButton1.ShadowDecoration.Shadow = New Padding(0, 0, 6, 6)
        Guna2GradientButton1.Size = New Size(123, 42)
        Guna2GradientButton1.TabIndex = 24
        Guna2GradientButton1.Text = "BOOK"
        ' 
        ' doctorInfoTextBot
        ' 
        doctorInfoTextBot.Animated = True
        doctorInfoTextBot.BorderColor = Color.FromArgb(CByte(100), CByte(150), CByte(200))
        doctorInfoTextBot.BorderRadius = 20
        doctorInfoTextBot.BorderThickness = 2
        CustomizableEdges5.TopLeft = False
        doctorInfoTextBot.CustomizableEdges = CustomizableEdges5
        doctorInfoTextBot.DefaultText = ""
        doctorInfoTextBot.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        doctorInfoTextBot.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        doctorInfoTextBot.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        doctorInfoTextBot.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        doctorInfoTextBot.FillColor = Color.FromArgb(CByte(200), CByte(190), CByte(250))
        doctorInfoTextBot.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        doctorInfoTextBot.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        doctorInfoTextBot.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        doctorInfoTextBot.Location = New Point(14, 147)
        doctorInfoTextBot.Margin = New Padding(3, 4, 3, 4)
        doctorInfoTextBot.Multiline = True
        doctorInfoTextBot.Name = "doctorInfoTextBot"
        doctorInfoTextBot.PasswordChar = ChrW(0)
        doctorInfoTextBot.PlaceholderText = ""
        doctorInfoTextBot.ReadOnly = True
        doctorInfoTextBot.SelectedText = ""
        doctorInfoTextBot.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        doctorInfoTextBot.Size = New Size(249, 146)
        doctorInfoTextBot.TabIndex = 18
        doctorInfoTextBot.TextAlign = HorizontalAlignment.Center
        ' 
        ' DoctorCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(280, 360)
        Controls.Add(Guna2CustomGradientPanel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "DoctorCard"
        Text = "DoctorCard"
        Guna2CustomGradientPanel2.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents doctorInfoTextBot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents doctorNameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
