<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AllBooks = New System.Windows.Forms.PictureBox()
        Me.IssuedBooks = New System.Windows.Forms.PictureBox()
        Me.ReturnBooks = New System.Windows.Forms.PictureBox()
        Me.Member = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogIn = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.AllBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AllBooks)
        Me.Panel1.Controls.Add(Me.IssuedBooks)
        Me.Panel1.Controls.Add(Me.ReturnBooks)
        Me.Panel1.Controls.Add(Me.Member)
        Me.Panel1.Location = New System.Drawing.Point(3, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 358)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(315, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 34)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = " Books"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(576, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 34)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Issue"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(792, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Return"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(58, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Member"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AllBooks
        '
        Me.AllBooks.Image = CType(resources.GetObject("AllBooks.Image"), System.Drawing.Image)
        Me.AllBooks.Location = New System.Drawing.Point(255, 61)
        Me.AllBooks.Name = "AllBooks"
        Me.AllBooks.Size = New System.Drawing.Size(215, 226)
        Me.AllBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AllBooks.TabIndex = 6
        Me.AllBooks.TabStop = False
        '
        'IssuedBooks
        '
        Me.IssuedBooks.Image = CType(resources.GetObject("IssuedBooks.Image"), System.Drawing.Image)
        Me.IssuedBooks.Location = New System.Drawing.Point(494, 61)
        Me.IssuedBooks.Name = "IssuedBooks"
        Me.IssuedBooks.Size = New System.Drawing.Size(210, 226)
        Me.IssuedBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IssuedBooks.TabIndex = 5
        Me.IssuedBooks.TabStop = False
        '
        'ReturnBooks
        '
        Me.ReturnBooks.Image = CType(resources.GetObject("ReturnBooks.Image"), System.Drawing.Image)
        Me.ReturnBooks.Location = New System.Drawing.Point(728, 61)
        Me.ReturnBooks.Name = "ReturnBooks"
        Me.ReturnBooks.Size = New System.Drawing.Size(215, 226)
        Me.ReturnBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReturnBooks.TabIndex = 4
        Me.ReturnBooks.TabStop = False
        '
        'Member
        '
        Me.Member.Image = CType(resources.GetObject("Member.Image"), System.Drawing.Image)
        Me.Member.Location = New System.Drawing.Point(16, 61)
        Me.Member.Name = "Member"
        Me.Member.Size = New System.Drawing.Size(215, 226)
        Me.Member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Member.TabIndex = 3
        Me.Member.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome To Library"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(406, 438)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 34)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Thank You!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LogIn
        '
        Me.LogIn.Image = CType(resources.GetObject("LogIn.Image"), System.Drawing.Image)
        Me.LogIn.Location = New System.Drawing.Point(911, 438)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(45, 41)
        Me.LogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogIn.TabIndex = 10
        Me.LogIn.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(958, 481)
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AllBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Member As System.Windows.Forms.PictureBox
    Friend WithEvents AllBooks As System.Windows.Forms.PictureBox
    Friend WithEvents IssuedBooks As System.Windows.Forms.PictureBox
    Friend WithEvents ReturnBooks As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LogIn As System.Windows.Forms.PictureBox
End Class
