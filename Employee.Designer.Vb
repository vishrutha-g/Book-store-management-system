<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Label11 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label12 = New Label()
        PictureBox4 = New PictureBox()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        EmpaddressTb = New TextBox()
        Label9 = New Label()
        EmpDGV = New DataGridView()
        Label10 = New Label()
        Label1 = New Label()
        EmpresetBtn = New Button()
        EmpdeleteTb = New Button()
        EmpeditTb = New Button()
        EmpsaveBtn = New Button()
        EmppasswordTb = New TextBox()
        Label13 = New Label()
        Label2 = New Label()
        EmpphoneTb = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        EmpnameTb = New TextBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmpDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(350, 284)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 32)
        Label11.TabIndex = 36
        Label11.Text = "User List"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveBorder
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(EmpaddressTb)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(EmpDGV)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(EmpresetBtn)
        Panel1.Controls.Add(EmpdeleteTb)
        Panel1.Controls.Add(EmpeditTb)
        Panel1.Controls.Add(EmpsaveBtn)
        Panel1.Controls.Add(EmppasswordTb)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(EmpphoneTb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(EmpnameTb)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(-23, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(957, 669)
        Panel1.TabIndex = 40
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(23, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(181, 678)
        Panel2.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(0, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(188, 33)
        Label12.TabIndex = 33
        Label12.Text = "BOOKSTORE"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(0, 134)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(48, 34)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 32
        PictureBox4.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(38, 134)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 33)
        Label8.TabIndex = 31
        Label8.Text = "DashBoard"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(76, 598)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 34)
        Label7.TabIndex = 30
        Label7.Text = "Logout"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 598)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(48, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 29
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.DeepSkyBlue
        Label6.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(42, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 34)
        Label6.TabIndex = 28
        Label6.Text = "Employee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 97)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(342, 34)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(71, 61)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 26
        PictureBox2.TabStop = False
        ' 
        ' EmpaddressTb
        ' 
        EmpaddressTb.Location = New Point(543, 183)
        EmpaddressTb.Multiline = True
        EmpaddressTb.Name = "EmpaddressTb"
        EmpaddressTb.Size = New Size(168, 93)
        EmpaddressTb.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(908, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 39)
        Label9.TabIndex = 21
        Label9.Text = "X"
        ' 
        ' EmpDGV
        ' 
        EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmpDGV.Location = New Point(210, 391)
        EmpDGV.Name = "EmpDGV"
        EmpDGV.RowHeadersWidth = 51
        EmpDGV.Size = New Size(688, 241)
        EmpDGV.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(325, 420)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 27)
        Label10.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(494, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 32)
        Label1.TabIndex = 16
        Label1.Text = "Employee List"
        ' 
        ' EmpresetBtn
        ' 
        EmpresetBtn.BackColor = SystemColors.GradientActiveCaption
        EmpresetBtn.Location = New Point(719, 307)
        EmpresetBtn.Name = "EmpresetBtn"
        EmpresetBtn.Size = New Size(94, 29)
        EmpresetBtn.TabIndex = 15
        EmpresetBtn.Text = "Reset"
        EmpresetBtn.UseVisualStyleBackColor = False
        ' 
        ' EmpdeleteTb
        ' 
        EmpdeleteTb.BackColor = SystemColors.GradientActiveCaption
        EmpdeleteTb.Location = New Point(553, 307)
        EmpdeleteTb.Name = "EmpdeleteTb"
        EmpdeleteTb.Size = New Size(94, 29)
        EmpdeleteTb.TabIndex = 14
        EmpdeleteTb.Text = "Delete"
        EmpdeleteTb.UseVisualStyleBackColor = False
        ' 
        ' EmpeditTb
        ' 
        EmpeditTb.BackColor = SystemColors.ActiveCaption
        EmpeditTb.Location = New Point(398, 307)
        EmpeditTb.Name = "EmpeditTb"
        EmpeditTb.Size = New Size(94, 29)
        EmpeditTb.TabIndex = 13
        EmpeditTb.Text = "Edit"
        EmpeditTb.UseVisualStyleBackColor = False
        ' 
        ' EmpsaveBtn
        ' 
        EmpsaveBtn.BackColor = SystemColors.ActiveCaption
        EmpsaveBtn.Location = New Point(260, 307)
        EmpsaveBtn.Name = "EmpsaveBtn"
        EmpsaveBtn.Size = New Size(94, 29)
        EmpsaveBtn.TabIndex = 12
        EmpsaveBtn.Text = "Save"
        EmpsaveBtn.UseVisualStyleBackColor = False
        ' 
        ' EmppasswordTb
        ' 
        EmppasswordTb.Location = New Point(753, 189)
        EmppasswordTb.Name = "EmppasswordTb"
        EmppasswordTb.Size = New Size(154, 27)
        EmppasswordTb.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(753, 150)
        Label13.Name = "Label13"
        Label13.Size = New Size(136, 27)
        Label13.TabIndex = 8
        Label13.Text = "Employee ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(553, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 27)
        Label2.TabIndex = 6
        Label2.Text = "Address"
        ' 
        ' EmpphoneTb
        ' 
        EmpphoneTb.Location = New Point(353, 196)
        EmpphoneTb.Name = "EmpphoneTb"
        EmpphoneTb.Size = New Size(139, 27)
        EmpphoneTb.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(353, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 27)
        Label3.TabIndex = 4
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(210, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 27)
        Label4.TabIndex = 3
        Label4.Text = "Name"
        ' 
        ' EmpnameTb
        ' 
        EmpnameTb.Location = New Point(210, 196)
        EmpnameTb.Name = "EmpnameTb"
        EmpnameTb.Size = New Size(123, 27)
        EmpnameTb.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(419, 46)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 34)
        Label5.TabIndex = 0
        Label5.Text = "BOOKSTORE"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 649)
        Controls.Add(Panel1)
        Controls.Add(Label11)
        Name = "Employee"
        Text = "Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(EmpDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EmpaddressTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmpDGV As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpresetBtn As Button
    Friend WithEvents EmpdeleteTb As Button
    Friend WithEvents EmpeditTb As Button
    Friend WithEvents EmpsaveBtn As Button
    Friend WithEvents EmppasswordTb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpphoneTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmpnameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label12 As Label
End Class
