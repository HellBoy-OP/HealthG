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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.download_removebg_preview1
        PictureBox1.Location = New Point(552, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.Location = New Point(623, 432)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(202, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(90), CByte(180), CByte(90))
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(509, 427)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 31)
        Label1.TabIndex = 3
        Label1.Text = "Username :"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(90), CByte(180), CByte(90))
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(514, 487)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 31)
        Label2.TabIndex = 4
        Label2.Text = "Password :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.BackColor = SystemColors.HighlightText
        TextBox2.Location = New Point(642, 488)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 27)
        TextBox2.TabIndex = 5
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.None
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(47, 228)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(128, 20)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forget Password ?"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(90), CByte(180), CByte(90))
        Button1.Location = New Point(180, 228)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 34)
        Button1.TabIndex = 7
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.FromArgb(CByte(90), CByte(180), CByte(90))
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Location = New Point(462, 316)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(416, 325)
        Panel1.TabIndex = 8
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(206, -6)
        Button3.Name = "Button3"
        Button3.Size = New Size(210, 60)
        Button3.TabIndex = 9
        Button3.Text = "Register"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(0, -6)
        Button2.Name = "Button2"
        Button2.Size = New Size(210, 60)
        Button2.TabIndex = 8
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Pristina", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(517, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(293, 52)
        Label3.TabIndex = 9
        Label3.Text = "Ayushman Bhavah"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(100), CByte(200), CByte(100))
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1327, 717)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ayushman Bhavah"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
