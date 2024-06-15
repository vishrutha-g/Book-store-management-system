<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel1 = New Panel()
        Label14 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        AdminBtn = New Label()
        Label4 = New Label()
        LoginBtn = New Button()
        Label3 = New Label()
        Label2 = New Label()
        PasswordTb = New TextBox()
        UserNameTb = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(AdminBtn)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(LoginBtn)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PasswordTb)
        Panel1.Controls.Add(UserNameTb)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(21, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(955, 556)
        Panel1.TabIndex = 0
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(895, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 39)
        Label14.TabIndex = 30
        Label14.Text = "X"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(641, 227)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(61, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 29
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(641, 165)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(61, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(276, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' AdminBtn
        ' 
        AdminBtn.AutoSize = True
        AdminBtn.Font = New Font("High Tower Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AdminBtn.Location = New Point(414, 369)
        AdminBtn.Name = "AdminBtn"
        AdminBtn.Size = New Size(77, 27)
        AdminBtn.TabIndex = 7
        AdminBtn.Text = "Admin"
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
        LoginBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(414, 313)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(94, 41)
        LoginBtn.TabIndex = 5
        LoginBtn.Text = "login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(255, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 33)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(231, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 33)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(423, 227)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(222, 27)
        PasswordTb.TabIndex = 2
        ' 
        ' UserNameTb
        ' 
        UserNameTb.Location = New Point(423, 165)
        UserNameTb.Name = "UserNameTb"
        UserNameTb.Size = New Size(222, 27)
        UserNameTb.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(353, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 39)
        Label1.TabIndex = 0
        Label1.Text = "BOOKSTORE"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(988, 580)
        Controls.Add(Panel1)
        Name = "login"
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UserNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents AdminBtn As Label
End Class
