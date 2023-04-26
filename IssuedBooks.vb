Imports System.Data.OleDb

Public Class IssuedBooks
    Dim cmd As OleDbCommand
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\OneDrive\Documents\Visual Studio 2010\Projects\Lib\Lib\LibrarySDB.accdb")
    Private Sub DisplayIssueBook()
        con.Open()
        Dim query = " select * from IssueBookTB"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        IssueDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub FillStudent()
        con.Open()
        Dim query = "select * from StudentTB"
        Dim cmd As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdCb.DataSource = Tbl
        StIdCb.DisplayMember = "StId"
        StIdCb.ValueMember = "StId"
        con.Close()
    End Sub
    Private Sub GetStudentName()
        con.open()
        Dim query = "select * from StudentTB  where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd = New OleDbCommand(query, con)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StNameTb.Text = "" + reader(1).ToString()
        End While
        con.close()
    End Sub
    Private Sub GetBookName()
        con.open()
        Dim query = "select * from BookTB  where BId=" & BIdCb.SelectedValue.ToString() & ""
        Dim cmd = New OleDbCommand(query, con)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            BookNameTb.Text = "" + reader(1).ToString()
        End While
        con.close()
    End Sub
    Private Sub FillBook()
        con.Open()
        Dim query = "select * from BookTB"
        Dim cmd As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        BIdCb.DataSource = Tbl
        BIdCb.DisplayMember = "BId"
        BIdCb.ValueMember = "BId"
        con.Close()
    End Sub

    Private Sub IssuedBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayIssueBook()
        FillStudent()
        FillBook()
    End Sub
    Private Sub Reset()
        IssueIdTB.Text = ""
        StIdCb.SelectedIndex = -1
        StNameTb.Text = ""
        BIdCb.SelectedIndex = -1
        BookNameTb.Text = ""
        IssueIdTB.Focus()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub StIdCb_SelectionChangeCommited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStudentName()
    End Sub
    Private Sub BIdCb_SelectionChangeCommited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub
    Dim num = 0
    Private Sub CountBook()
        con.open()
        Dim query = "select Count(*) from IssueBookTB where StId =" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, con)
        num = cmd.ExecuteScalar
        con.close()
    End Sub
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        CountBook()
        If IssueIdTB.Text = "" Or StIdCb.SelectedIndex = -1 Or StNameTb.Text = "" Or BIdCb.SelectedIndex = -1 Or BookNameTb.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf num = 5 Then
            MsgBox("A Student Can Not Issue More Than 5 Books")
        Else
            con.open()
            Dim query = "insert into IssueBookTB values(" & IssueIdTB.Text & "," & StIdCb.SelectedValue.ToString() & ",'" & StNameTb.Text & "'," & BIdCb.SelectedValue.ToString() & ",'" & BookNameTb.Text & "','" & IssueDate.Value.Date & "')"
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Book Issued")
            DisplayIssueBook()
            Reset()
        End If
    End Sub

    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub BackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        Dim obj = New MainForm
        obj.Show()
        Me.Hide()
    End Sub
    Dim key = 0
    Private Sub IssueDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        IssueIdTB.Text = row.Cells(0).Value.ToString
        StIdCb.SelectedItem = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BIdCb.SelectedItem = row.Cells(3).Value.ToString
        BookNameTb.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString
        If IssueIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
        
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If IssueIdTB.Text = "" Or StNameTb.Text = "" Or BookNameTb.Text = "" Then
            MsgBox("Enter All Details")
        Else
            con.Open()
            Dim query = "update IssueBookTB set StId=" & StIdCb.SelectedValue.ToString() & ",StName=' " & StNameTb.Text & " ',BookId=" & BIdCb.SelectedValue.ToString() & ",BookName='" & BookNameTb.Text & "',IssueDate= " & IssueDate.Value.Date & " where INum=" & key & ""
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            con.Close()
            DisplayIssueBook()
            Reset()
        End If
    End Sub
End Class