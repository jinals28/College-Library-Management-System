Imports System.Data.OleDb

Public Class Librarian
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\OneDrive\Documents\Visual Studio 2010\Projects\Lib\Lib\LibrarySDB.accdb")
    Private Sub DisplayLibrarian()
        con.Open()
        Dim query = " select * from LibTB"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        LibrarianDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Reset()
        LibIdTB.Text = ""
        LibNameTB.Text = ""
        LibMoTB.Text = ""
        LibPassTB.Text = ""
        LibIdTB.Focus()
        key = 0
    End Sub
    

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If LibIdTB.Text = "" Or LibNameTB.Text = "" Or LibMoTB.Text = "" Or LibPassTB.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf LibMoTB.TextLength <> 10 Then
            MsgBox("Enter  A 10 Digit Mob. No")
        Else
            con.open()
            Dim query = "insert into LibTB values(" & LibIdTB.Text & ",'" & LibNameTB.Text & "','" & LibMoTB.Text & "','" & LibPassTB.Text & "')"
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Librarian Added")
            DisplayLibrarian()
            Reset()
        End If
    End Sub

    Private Sub Librarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayLibrarian()
    End Sub

    Private Sub LibrarianDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles LibrarianDGV.CellMouseClick
        Dim row As DataGridViewRow = LibrarianDGV.Rows(e.RowIndex)
        LibIdTB.Text = row.Cells(0).Value.ToString
        LibNameTB.Text = row.Cells(1).Value.ToString
        LibMoTB.Text = row.Cells(2).Value.ToString
        LibPassTB.Text = row.Cells(3).Value.ToString
        If LibNameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = " delete from LibTB where LibId=" & key & ""
            Dim cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Removed")
            con.Close()
            DisplayLibrarian()
            Reset()
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If LibIdTB.Text = "" Or LibNameTB.Text = "" Or LibMoTB.Text = "" Or LibPassTB.Text = "" Then
            MsgBox("Enter All Details")
        Else
            con.open()
            Dim query = "update LibTB set LibId=" & LibIdTB.Text & ",LibName=' " & LibNameTB.Text & " ',LibPhone='" & LibMoTB.Text & " ' ,LibPass='" & LibPassTB.Text & " ' where LibId=" & key & ""
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Member Updated")
            DisplayLibrarian()
            Reset()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
