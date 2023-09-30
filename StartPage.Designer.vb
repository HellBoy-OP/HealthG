<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        Guna2GradientPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Anchor = AnchorStyles.None
        Guna2GradientPanel1.BackColor = Color.Transparent
        Guna2GradientPanel1.BorderRadius = 40
        Guna2GradientPanel1.Controls.Add(Panel1)
        CustomizableEdges1.BottomRight = False
        CustomizableEdges1.TopLeft = False
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(190), CByte(240), CByte(150))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(50), CByte(170), CByte(120))
        Guna2GradientPanel1.GradientMode = Drawing2D.LinearGradientMode.BackwardDiagonal
        Guna2GradientPanel1.Location = New Point(435, 150)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.BorderRadius = 40
        Guna2GradientPanel1.ShadowDecoration.Color = Color.DimGray
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.ShadowDecoration.Shadow = New Padding(5, 5, 40, 10)
        Guna2GradientPanel1.Size = New Size(410, 530)
        Guna2GradientPanel1.TabIndex = 11
        Guna2GradientPanel1.UseTransparentBackground = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.ImeMode = ImeMode.NoControl
        Panel1.Location = New Point(15, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(380, 490)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.circle
        PictureBox2.InitialImage = My.Resources.Resources.circle
        PictureBox2.Location = New Point(-82, 413)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(549, 485)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.circle
        PictureBox1.Location = New Point(755, -200)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(634, 598)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.logo
        PictureBox5.InitialImage = My.Resources.Resources.logo
        PictureBox5.Location = New Point(365, -145)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(550, 470)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' StartPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(100), CByte(210), CByte(120))
        ClientSize = New Size(1280, 705)
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "StartPage"
        Text = "StartPage"
        Guna2GradientPanel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
