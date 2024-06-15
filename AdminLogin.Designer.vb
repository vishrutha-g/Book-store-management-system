<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Panel1 = New Panel()
        Label3 = New Label()
        AdminoTb = New TextBox()
        Label2 = New Label()
        UsernameTb = New TextBox()
        Label14 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        LoginBtn = New Button()
        UserLbl = New Label()
        PasswordTb = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(AdminoTb)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(UsernameTb)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(LoginBtn)
        Panel1.Controls.Add(UserLbl)
        Panel1.Controls.Add(PasswordTb)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(843, 427)
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(189, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 33)
        Label3.TabIndex = 36
        Label3.Text = "Admin No"
        ' 
        ' AdminoTb
        ' 
        AdminoTb.Location = New Point(364, 224)
        AdminoTb.Name = "AdminoTb"
        AdminoTb.Size = New Size(222, 27)
        AdminoTb.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(186, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 33)
        Label2.TabIndex = 33
        Label2.Text = "Password"
        ' 
        ' UsernameTb
        ' 
        UsernameTb.Location = New Point(364, 127)
        UsernameTb.Name = "UsernameTb"
        UsernameTb.Size = New Size(222, 27)
        UsernameTb.TabIndex = 32
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(715, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 39)
        Label14.TabIndex = 31
        Label14.Text = "X"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(292, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("High Tower Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(724, 361)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 29)
        Label5.TabIndex = 7
        Label5.Text = "Cancel"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(1032, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 39)
        Label4.TabIndex = 6
        Label4.Text = "X"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = SystemColors.ButtonShadow
        LoginBtn.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(561, 351)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(132, 43)
        LoginBtn.TabIndex = 5
        LoginBtn.Text = "login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' UserLbl
        ' 
        UserLbl.AutoSize = True
        UserLbl.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserLbl.Location = New Point(186, 127)
        UserLbl.Name = "UserLbl"
        UserLbl.Size = New Size(132, 33)
        UserLbl.TabIndex = 4
        UserLbl.Text = "Username"
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(364, 176)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(222, 27)
        PasswordTb.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(384, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 39)
        Label1.TabIndex = 0
        Label1.Text = "Admin Login"
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(867, 454)
        Controls.Add(Panel1)
        Name = "AdminLogin"
        Text = "AdminLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents UserLbl As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AdminoTb As TextBox
End Class
