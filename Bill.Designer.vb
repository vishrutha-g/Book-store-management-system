<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Label13 = New Label()
        Label9 = New Label()
        Label1 = New Label()
        button88 = New Label()
        Label3 = New Label()
        ClientNameTb = New TextBox()
        Label5 = New Label()
        QtyTb = New TextBox()
        Label6 = New Label()
        PricesTb = New TextBox()
        RetsetBtn = New Button()
        AddToBillBtn = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Book1DGV = New DataGridView()
        Label14 = New Label()
        But = New Button()
        PictureBox1 = New PictureBox()
        TotalLbl = New Label()
        UsernameLbl = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        BNameTb = New TextBox()
        BillDGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel4.SuspendLayout()
        CType(Book1DGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(FlowLayoutPanel4)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(214, 722)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 117)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(68, 57)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(71, 117)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 57)
        Button3.TabIndex = 6
        Button3.Text = "Book Details"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.BackColor = Color.SteelBlue
        FlowLayoutPanel4.Controls.Add(Label13)
        FlowLayoutPanel4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FlowLayoutPanel4.Location = New Point(0, 675)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(211, 47)
        FlowLayoutPanel4.TabIndex = 5
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Imprint MT Shadow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ButtonHighlight
        Label13.Location = New Point(3, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(90, 27)
        Label13.TabIndex = 2
        Label13.Text = "Logout"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(3, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(199, 34)
        Label9.TabIndex = 1
        Label9.Text = "BOOKSTORE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(355, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 34)
        Label1.TabIndex = 0
        Label1.Text = "BOOKSTORE"
        ' 
        ' button88
        ' 
        button88.AutoSize = True
        button88.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button88.Location = New Point(13, 85)
        button88.Name = "button88"
        button88.Size = New Size(125, 27)
        button88.TabIndex = 3
        button88.Text = "Book Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 27)
        Label3.TabIndex = 4
        Label3.Text = "Client Name"
        ' 
        ' ClientNameTb
        ' 
        ClientNameTb.Location = New Point(3, 177)
        ClientNameTb.Name = "ClientNameTb"
        ClientNameTb.Size = New Size(123, 27)
        ClientNameTb.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(154, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 27)
        Label5.TabIndex = 8
        Label5.Text = "Quantity"
        ' 
        ' QtyTb
        ' 
        QtyTb.Location = New Point(138, 116)
        QtyTb.Name = "QtyTb"
        QtyTb.Size = New Size(123, 27)
        QtyTb.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(154, 147)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 27)
        Label6.TabIndex = 10
        Label6.Text = "Prices"
        ' 
        ' PricesTb
        ' 
        PricesTb.Location = New Point(141, 177)
        PricesTb.Name = "PricesTb"
        PricesTb.Size = New Size(102, 27)
        PricesTb.TabIndex = 11
        ' 
        ' RetsetBtn
        ' 
        RetsetBtn.BackColor = SystemColors.GradientActiveCaption
        RetsetBtn.Location = New Point(141, 224)
        RetsetBtn.Name = "RetsetBtn"
        RetsetBtn.Size = New Size(120, 46)
        RetsetBtn.TabIndex = 14
        RetsetBtn.Text = "Reset"
        RetsetBtn.UseVisualStyleBackColor = False
        ' 
        ' AddToBillBtn
        ' 
        AddToBillBtn.BackColor = SystemColors.GradientActiveCaption
        AddToBillBtn.Location = New Point(3, 224)
        AddToBillBtn.Name = "AddToBillBtn"
        AddToBillBtn.Size = New Size(123, 46)
        AddToBillBtn.TabIndex = 15
        AddToBillBtn.Text = "Add To Bill"
        AddToBillBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(656, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 32)
        Label7.TabIndex = 16
        Label7.Text = "Books Bill"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(15, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 27)
        Label8.TabIndex = 17
        ' 
        ' Book1DGV
        ' 
        Book1DGV.BackgroundColor = SystemColors.ActiveCaption
        Book1DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Book1DGV.Location = New Point(7, 354)
        Book1DGV.Name = "Book1DGV"
        Book1DGV.RowHeadersWidth = 51
        Book1DGV.Size = New Size(566, 333)
        Book1DGV.TabIndex = 20
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Goudy Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(1050, 7)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 39)
        Label14.TabIndex = 21
        Label14.Text = "X"
        ' 
        ' But
        ' 
        But.BackColor = SystemColors.GradientActiveCaption
        But.Location = New Point(736, 419)
        But.Name = "But"
        But.Size = New Size(94, 29)
        But.TabIndex = 23
        But.Text = "Print"
        But.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(278, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' TotalLbl
        ' 
        TotalLbl.AutoSize = True
        TotalLbl.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalLbl.Location = New Point(758, 373)
        TotalLbl.Name = "TotalLbl"
        TotalLbl.Size = New Size(72, 32)
        TotalLbl.TabIndex = 25
        TotalLbl.Text = "Total"
        ' 
        ' UsernameLbl
        ' 
        UsernameLbl.AutoSize = True
        UsernameLbl.Font = New Font("Goudy Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameLbl.Location = New Point(81, 0)
        UsernameLbl.Name = "UsernameLbl"
        UsernameLbl.Size = New Size(0, 32)
        UsernameLbl.TabIndex = 27
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.InactiveBorder
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(BNameTb)
        Panel2.Controls.Add(BillDGV)
        Panel2.Controls.Add(UsernameLbl)
        Panel2.Controls.Add(Book1DGV)
        Panel2.Controls.Add(TotalLbl)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(But)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(AddToBillBtn)
        Panel2.Controls.Add(RetsetBtn)
        Panel2.Controls.Add(PricesTb)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(QtyTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(ClientNameTb)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(button88)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(235, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1095, 722)
        Panel2.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(75, 54)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' BNameTb
        ' 
        BNameTb.Location = New Point(7, 116)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(125, 27)
        BNameTb.TabIndex = 29
        ' 
        ' BillDGV
        ' 
        BillDGV.BackgroundColor = SystemColors.ActiveCaption
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        BillDGV.GridColor = SystemColors.MenuText
        BillDGV.Location = New Point(436, 105)
        BillDGV.Name = "BillDGV"
        BillDGV.RowHeadersWidth = 51
        BillDGV.Size = New Size(634, 243)
        BillDGV.TabIndex = 28
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "BOOK"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "PRICE"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "QUANTITY"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "TOTAL"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Bill
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1342, 746)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Bill"
        Text = "Bill"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        CType(Book1DGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BookNameTb As TextBox
    Friend WithEvents BNmaeTb As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClientNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PricesTb As TextBox
    Friend WithEvents RetsetBtn As Button
    Friend WithEvents AddToBillBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Book1DGV As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents But As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TotalLbl As Label
    Friend WithEvents UnameLbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents button88 As Label
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents UsernameLbl As Label
End Class
