<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        countBtn = New Button()
        DeleteBtn = New Button()
        AddBtn = New Button()
        PasswordTb = New TextBox()
        Label13 = New Label()
        UsernameTb = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        AdminnoTb = New TextBox()
        Label18 = New Label()
        CountLbl = New Label()
        ResetBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(204, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' countBtn
        ' 
        countBtn.BackColor = SystemColors.ActiveCaption
        countBtn.Location = New Point(487, 308)
        countBtn.Name = "countBtn"
        countBtn.Size = New Size(139, 52)
        countBtn.TabIndex = 38
        countBtn.Text = "Count"
        countBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = SystemColors.ActiveCaption
        DeleteBtn.Location = New Point(303, 308)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(128, 52)
        DeleteBtn.TabIndex = 37
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = SystemColors.ActiveCaption
        AddBtn.Location = New Point(94, 308)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(121, 52)
        AddBtn.TabIndex = 35
        AddBtn.Text = " Save"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(525, 195)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(154, 27)
        PasswordTb.TabIndex = 34
        PasswordTb.Text = "  "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(543, 137)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 27)
        Label13.TabIndex = 33
        Label13.Text = "password"
        ' 
        ' UsernameTb
        ' 
        UsernameTb.Location = New Point(292, 195)
        UsernameTb.Name = "UsernameTb"
        UsernameTb.Size = New Size(139, 27)
        UsernameTb.TabIndex = 31
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(312, 137)
        Label16.Name = "Label16"
        Label16.Size = New Size(109, 27)
        Label16.TabIndex = 30
        Label16.Text = "Username"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(92, 137)
        Label17.Name = "Label17"
        Label17.Size = New Size(113, 27)
        Label17.TabIndex = 29
        Label17.Text = "Admin No"
        ' 
        ' AdminnoTb
        ' 
        AdminnoTb.Location = New Point(92, 195)
        AdminnoTb.Name = "AdminnoTb"
        AdminnoTb.Size = New Size(123, 27)
        AdminnoTb.TabIndex = 28
        AdminnoTb.Text = "   "
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(275, 64)
        Label18.Name = "Label18"
        Label18.Size = New Size(199, 34)
        Label18.TabIndex = 27
        Label18.Text = "BOOKSTORE"
        ' 
        ' CountLbl
        ' 
        CountLbl.AutoSize = True
        CountLbl.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CountLbl.Location = New Point(681, 137)
        CountLbl.Name = "CountLbl"
        CountLbl.Size = New Size(72, 27)
        CountLbl.TabIndex = 42
        CountLbl.Text = "Count"
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = SystemColors.ActiveCaption
        ResetBtn.Location = New Point(651, 308)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(128, 52)
        ResetBtn.TabIndex = 43
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ResetBtn)
        Controls.Add(CountLbl)
        Controls.Add(PictureBox1)
        Controls.Add(countBtn)
        Controls.Add(DeleteBtn)
        Controls.Add(AddBtn)
        Controls.Add(PasswordTb)
        Controls.Add(Label13)
        Controls.Add(UsernameTb)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(AdminnoTb)
        Controls.Add(Label18)
        Name = "Form1"
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents countBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents AdminnoTb As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CountLbl As Label
    Friend WithEvents ResetBtn As Button
End Class
