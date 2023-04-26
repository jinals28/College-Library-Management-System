<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReturn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookReturn))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReturnIdTb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FineTb = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BIdCb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StIdCb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.StNameTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.BNameTb = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IssueDGV = New System.Windows.Forms.DataGridView()
        Me.ReturnDGV = New System.Windows.Forms.DataGridView()
        Me.LibrarySDBDataSet = New WindowsApplication1.LibrarySDBDataSet()
        Me.IssueBookTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueBookTBTableAdapter = New WindowsApplication1.LibrarySDBDataSetTableAdapters.IssueBookTBTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarySDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueBookTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IssueDate
        '
        Me.IssueDate.Enabled = False
        Me.IssueDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IssueDate.Location = New System.Drawing.Point(779, 139)
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.Size = New System.Drawing.Size(176, 37)
        Me.IssueDate.TabIndex = 24
        Me.IssueDate.Value = New Date(2023, 1, 25, 19, 22, 11, 0)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ReturnIdTb)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.FineTb)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.ReturnDate)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.IssueDate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.BIdCb)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.StIdCb)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.EditBtn)
        Me.Panel2.Controls.Add(Me.StNameTb)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ResetBtn)
        Me.Panel2.Controls.Add(Me.BNameTb)
        Me.Panel2.Controls.Add(Me.SaveBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(43, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1406, 274)
        Me.Panel2.TabIndex = 34
        '
        'ReturnIdTb
        '
        Me.ReturnIdTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnIdTb.ForeColor = System.Drawing.Color.OrangeRed
        Me.ReturnIdTb.Location = New System.Drawing.Point(26, 138)
        Me.ReturnIdTb.Name = "ReturnIdTb"
        Me.ReturnIdTb.Size = New System.Drawing.Size(137, 37)
        Me.ReturnIdTb.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label12.Location = New System.Drawing.Point(20, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 34)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Return Id"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FineTb
        '
        Me.FineTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FineTb.ForeColor = System.Drawing.Color.OrangeRed
        Me.FineTb.Location = New System.Drawing.Point(1163, 138)
        Me.FineTb.Name = "FineTb"
        Me.FineTb.Size = New System.Drawing.Size(98, 37)
        Me.FineTb.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label11.Location = New System.Drawing.Point(1148, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 34)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Fine"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReturnDate
        '
        Me.ReturnDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnDate.Location = New System.Drawing.Point(970, 138)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(174, 37)
        Me.ReturnDate.TabIndex = 26
        Me.ReturnDate.Value = New Date(2023, 1, 25, 19, 22, 18, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(964, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 34)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Return Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(467, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 34)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Book Id"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BIdCb
        '
        Me.BIdCb.Enabled = False
        Me.BIdCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BIdCb.ForeColor = System.Drawing.Color.OrangeRed
        Me.BIdCb.FormattingEnabled = True
        Me.BIdCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.BIdCb.Location = New System.Drawing.Point(466, 138)
        Me.BIdCb.Name = "BIdCb"
        Me.BIdCb.Size = New System.Drawing.Size(116, 38)
        Me.BIdCb.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(177, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 34)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Student Id"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StIdCb
        '
        Me.StIdCb.Enabled = False
        Me.StIdCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StIdCb.ForeColor = System.Drawing.Color.OrangeRed
        Me.StIdCb.FormattingEnabled = True
        Me.StIdCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.StIdCb.Location = New System.Drawing.Point(183, 138)
        Me.StIdCb.Name = "StIdCb"
        Me.StIdCb.Size = New System.Drawing.Size(147, 38)
        Me.StIdCb.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(577, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 39)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Return Details"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.EditBtn.FlatAppearance.BorderSize = 0
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(584, 210)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(172, 42)
        Me.EditBtn.TabIndex = 17
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'StNameTb
        '
        Me.StNameTb.Enabled = False
        Me.StNameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StNameTb.ForeColor = System.Drawing.Color.OrangeRed
        Me.StNameTb.Location = New System.Drawing.Point(342, 139)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(118, 37)
        Me.StNameTb.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(336, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(779, 210)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(172, 42)
        Me.ResetBtn.TabIndex = 15
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'BNameTb
        '
        Me.BNameTb.Enabled = False
        Me.BNameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNameTb.ForeColor = System.Drawing.Color.OrangeRed
        Me.BNameTb.Location = New System.Drawing.Point(593, 138)
        Me.BNameTb.Name = "BNameTb"
        Me.BNameTb.Size = New System.Drawing.Size(167, 37)
        Me.BNameTb.TabIndex = 8
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(386, 210)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(172, 42)
        Me.SaveBtn.TabIndex = 14
        Me.SaveBtn.Text = "Return"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(587, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Book Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(773, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 34)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Issue Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(1007, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 39)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Book Returned"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Return Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.BackBtn.FlatAppearance.BorderSize = 0
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(676, 632)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(172, 42)
        Me.BackBtn.TabIndex = 37
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1486, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1527, 53)
        Me.Panel1.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(252, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 39)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Book Issued"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IssueDGV
        '
        Me.IssueDGV.BackgroundColor = System.Drawing.Color.White
        Me.IssueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDGV.Location = New System.Drawing.Point(34, 380)
        Me.IssueDGV.Name = "IssueDGV"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IssueDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.IssueDGV.RowHeadersWidth = 30
        Me.IssueDGV.RowTemplate.Height = 28
        Me.IssueDGV.Size = New System.Drawing.Size(724, 246)
        Me.IssueDGV.TabIndex = 39
        '
        'ReturnDGV
        '
        Me.ReturnDGV.BackgroundColor = System.Drawing.Color.White
        Me.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnDGV.Location = New System.Drawing.Point(764, 380)
        Me.ReturnDGV.Name = "ReturnDGV"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReturnDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.ReturnDGV.RowHeadersWidth = 30
        Me.ReturnDGV.RowTemplate.Height = 28
        Me.ReturnDGV.Size = New System.Drawing.Size(724, 246)
        Me.ReturnDGV.TabIndex = 40
        '
        'LibrarySDBDataSet
        '
        Me.LibrarySDBDataSet.DataSetName = "LibrarySDBDataSet"
        Me.LibrarySDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssueBookTBBindingSource
        '
        Me.IssueBookTBBindingSource.DataMember = "IssueBookTB"
        Me.IssueBookTBBindingSource.DataSource = Me.LibrarySDBDataSet
        '
        'IssueBookTBTableAdapter
        '
        Me.IssueBookTBTableAdapter.ClearBeforeFill = True
        '
        'BookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1527, 684)
        Me.Controls.Add(Me.ReturnDGV)
        Me.Controls.Add(Me.IssueDGV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookReturn"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarySDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueBookTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BIdCb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StIdCb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents StNameTb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ResetBtn As System.Windows.Forms.Button
    Friend WithEvents BNameTb As System.Windows.Forms.TextBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FineTb As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IssueDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ReturnDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ReturnIdTb As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LibrarySDBDataSet As WindowsApplication1.LibrarySDBDataSet
    Friend WithEvents IssueBookTBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueBookTBTableAdapter As WindowsApplication1.LibrarySDBDataSetTableAdapters.IssueBookTBTableAdapter
End Class
