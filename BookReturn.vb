Imports System.Data.OleDb

Public Class BookReturn
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
    Private Sub DisplayReturnedBook()
        con.Open()
        Dim query = " select * from ReturnBookTB"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ReturnDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
    Private Sub BookReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayIssueBook()
        DisplayReturnedBook()
    End Sub
    Private Sub CalcFine()
        Dim Dif As TimeSpan
        Dim Fine As Integer
        Dif = ReturnDate.Value.Date - IssueDate.Value.Date
        Dim Days = Dif.Days
        If Days < 5 Then
            Fine = 0
            FineTb.Text = Convert.ToString(Fine)
        Else
            Fine = Days - 5
            FineTb.Text = Convert.ToString(Fine * 50)
        End If
    End Sub
    Dim key = 0
    Private Sub IssueDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        StIdCb.SelectedItem = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BIdCb.SelectedItem = row.Cells(3).Value.ToString
        BNameTb.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString
        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
        CalcFine()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If StIdCb.Text = "" Or BIdCb.Text = "" Or ReturnIdTb.Text = "" Or StNameTb.Text = "" Or BNameTb.Text = "" Or FineTb.Text = "" Then
            MsgBox("Enter All Details")
        Else
            Try
                con.open()
                Dim query = "insert into ReturnBookTB values(" & ReturnIdTb.Text & " ," & StIdCb.Text & " ,'" & StNameTb.Text & "'," & BIdCb.Text & ",'" & BNameTb.Text & "','" & IssueDate.Value.Date & "','" & ReturnDate.Value.Date & "','" & FineTb.Text & "')"
                Dim cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Book Returned")
                RemoveFromIssue()
                DisplayReturnedBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        Dim obj = New MainForm
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub RemoveFromIssue()
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = " delete from IssueBookTB where INum=" & key & ""
            Dim cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Entry Removed")
            con.Close()
            DisplayIssueBook()
            Reset()
        End If
    End Sub
    Private Sub Reset()
        StNameTb.Text = ""
        StIdCb.SelectedIndex = -1
        ReturnIdTb.Text = ""
        BIdCb.SelectedIndex = -1
        BNameTb.Text = ""
        FineTb.Text = ""
        ReturnIdTb.Focus()
        key = 0
    End Sub
    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
End Class