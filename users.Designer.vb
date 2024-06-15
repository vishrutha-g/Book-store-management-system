<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(users))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        AddressTb = New TextBox()
        Label9 = New Label()
        UserDGV = New DataGridView()
        Label10 = New Label()
        Label11 = New Label()
        ResetBtn = New Button()
        DeleteBtn = New Button()
        EditBtn = New Button()
        SaveBtn = New Button()
        PasswordTb = New TextBox()
        Label13 = New Label()
        Label15 = New Label()
        PhoneTb = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        UnameTb = New TextBox()
        Label18 = New Label()
        Panel3 = New Panel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        PictureBox8 = New PictureBox()
        Label19 = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        PictureBox7 = New PictureBox()
        Label20 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        PictureBox6 = New PictureBox()
        Label21 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox2 = New PictureBox()
        Label22 = New Label()
        Label23 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel3.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveBorder
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(AddressTb)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(UserDGV)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(ResetBtn)
        Panel1.Controls.Add(DeleteBtn)
        Panel1.Controls.Add(EditBtn)
        Panel1.Controls.Add(SaveBtn)
        Panel1.Controls.Add(PasswordTb)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(PhoneTb)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(UnameTb)
        Panel1.Controls.Add(Label18)
        Panel1.Location = New Point(226, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(773, 528)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(167, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' AddressTb
        ' 
        AddressTb.Location = New Point(350, 114)
        AddressTb.Multiline = True
        AddressTb.Name = "AddressTb"
        AddressTb.Size = New Size(168, 93)
        AddressTb.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(719, 4)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 39)
        Label9.TabIndex = 21
        Label9.Text = "X"
        ' 
        ' UserDGV
        ' 
        UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserDGV.Location = New Point(7, 318)
        UserDGV.Name = "UserDGV"
        UserDGV.RowHeadersWidth = 51
        UserDGV.Size = New Size(748, 202)
        UserDGV.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(139, 347)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 27)
        Label10.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(308, 283)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 32)
        Label11.TabIndex = 16
        Label11.Text = "User List"
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = SystemColors.GradientActiveCaption
        ResetBtn.Location = New Point(533, 234)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(94, 29)
        ResetBtn.TabIndex = 15
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = SystemColors.GradientActiveCaption
        DeleteBtn.Location = New Point(367, 234)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(94, 29)
        DeleteBtn.TabIndex = 14
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = SystemColors.ActiveCaption
        EditBtn.Location = New Point(212, 234)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(94, 29)
        EditBtn.TabIndex = 13
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = SystemColors.ActiveCaption
        SaveBtn.Location = New Point(74, 234)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(94, 29)
        SaveBtn.TabIndex = 12
        SaveBtn.Text = " Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(567, 116)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(154, 27)
        PasswordTb.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(567, 77)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 27)
        Label13.TabIndex = 8
        Label13.Text = "password"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(367, 77)
        Label15.Name = "Label15"
        Label15.Size = New Size(87, 27)
        Label15.TabIndex = 6
        Label15.Text = "Address"
        ' 
        ' PhoneTb
        ' 
        PhoneTb.Location = New Point(167, 123)
        PhoneTb.Name = "PhoneTb"
        PhoneTb.Size = New Size(139, 27)
        PhoneTb.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(167, 84)
        Label16.Name = "Label16"
        Label16.Size = New Size(74, 27)
        Label16.TabIndex = 4
        Label16.Text = "Phone"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(7, 84)
        Label17.Name = "Label17"
        Label17.Size = New Size(68, 27)
        Label17.TabIndex = 3
        Label17.Text = "Name"
        ' 
        ' UnameTb
        ' 
        UnameTb.Location = New Point(-3, 122)
        UnameTb.Name = "UnameTb"
        UnameTb.Size = New Size(123, 27)
        UnameTb.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(238, 27)
        Label18.Name = "Label18"
        Label18.Size = New Size(199, 34)
        Label18.TabIndex = 0
        Label18.Text = "BOOKSTORE"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SteelBlue
        Panel3.Controls.Add(FlowLayoutPanel4)
        Panel3.Controls.Add(FlowLayoutPanel3)
        Panel3.Controls.Add(FlowLayoutPanel2)
        Panel3.Controls.Add(FlowLayoutPanel1)
        Panel3.Controls.Add(Label23)
        Panel3.Location = New Point(3, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(217, 528)
        Panel3.TabIndex = 3
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.BackColor = Color.SteelBlue
        FlowLayoutPanel4.Controls.Add(PictureBox8)
        FlowLayoutPanel4.Controls.Add(Label19)
        FlowLayoutPanel4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FlowLayoutPanel4.Location = New Point(-3, 283)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(217, 51)
        FlowLayoutPanel4.TabIndex = 5
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(3, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(45, 48)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 29
        PictureBox8.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ButtonHighlight
        Label19.Location = New Point(54, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(90, 27)
        Label19.TabIndex = 2
        Label19.Text = "Logout"
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.SteelBlue
        FlowLayoutPanel3.Controls.Add(PictureBox7)
        FlowLayoutPanel3.Controls.Add(Label20)
        FlowLayoutPanel3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FlowLayoutPanel3.Location = New Point(-3, 185)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(217, 48)
        FlowLayoutPanel3.TabIndex = 4
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(3, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(45, 40)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 28
        PictureBox7.TabStop = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ButtonHighlight
        Label20.Location = New Point(54, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(116, 27)
        Label20.TabIndex = 2
        Label20.Text = "Dasboard"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = Color.DeepSkyBlue
        FlowLayoutPanel2.Controls.Add(PictureBox6)
        FlowLayoutPanel2.Controls.Add(Label21)
        FlowLayoutPanel2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FlowLayoutPanel2.Location = New Point(0, 131)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(211, 48)
        FlowLayoutPanel2.TabIndex = 3
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(3, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(45, 45)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 28
        PictureBox6.TabStop = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.DeepSkyBlue
        Label21.Font = New Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ButtonHighlight
        Label21.Location = New Point(54, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(73, 27)
        Label21.TabIndex = 2
        Label21.Text = "Users"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BackColor = Color.SteelBlue
        FlowLayoutPanel1.Controls.Add(PictureBox2)
        FlowLayoutPanel1.Controls.Add(Label22)
        FlowLayoutPanel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FlowLayoutPanel1.Location = New Point(-3, 77)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(214, 48)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 48)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 27
        PictureBox2.TabStop = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ButtonHighlight
        Label22.Location = New Point(54, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(78, 27)
        Label22.TabIndex = 2
        Label22.Text = "Books"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ButtonHighlight
        Label23.Location = New Point(3, 9)
        Label23.Name = "Label23"
        Label23.Size = New Size(199, 34)
        Label23.TabIndex = 1
        Label23.Text = "BOOKSTORE"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(-6, 246)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(223, 49)
        Panel2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(63, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 27)
        Label1.TabIndex = 30
        Label1.Text = "Employee"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(6, 5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(48, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 29
        PictureBox3.TabStop = False
        ' 
        ' users
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1011, 561)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "users"
        Text = "users"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(UserDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents UserDGV As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
