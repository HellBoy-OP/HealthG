<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.circle
        PictureBox1.Location = New Point(805, -158)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(634, 598)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.circle
        PictureBox2.Location = New Point(-42, 456)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(500, 485)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.logo
        PictureBox5.Location = New Point(376, -127)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(542, 474)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
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
        Guna2GradientPanel1.Location = New Point(440, 180)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.BorderRadius = 40
        Guna2GradientPanel1.ShadowDecoration.Color = Color.DimGray
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.ShadowDecoration.Shadow = New Padding(5, 5, 40, 10)
        Guna2GradientPanel1.Size = New Size(408, 526)
        Guna2GradientPanel1.TabIndex = 7
        Guna2GradientPanel1.UseTransparentBackground = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.ImeMode = ImeMode.NoControl
        Panel1.Location = New Point(10, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(387, 491)
        Panel1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(103), CByte(209), CByte(119))
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1327, 717)
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ayushman Bhavah"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Guna2GradientPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel1 As Panel
End Class
