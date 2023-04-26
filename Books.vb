Imports System.Data
Imports System.Data.OleDb
Public Class Books
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\OneDrive\Documents\Visual Studio 2010\Projects\Lib\Lib\LibrarySDB.accdb")
    Private Sub DisplayBook()
        con.Open()
        Dim query = " select * from BookTB"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If BNameTB.Text = "" Or BAuthorTB.Text = "" Or BPublisherTB.Text = "" Or BId.Text = "" Or Qty.Text = "" Then
            MsgBox("Enter All Details")
        Else
            Dim Insertquery As String = "insert into BookTB(BId,BName,BAuthor,BPublisher,BQty) values (@BID,@BName,@BAuthir,@BPublisher,@BQty)"
            Runquery(Insertquery)
            MsgBox("Book Added")
            DisplayBook()
            Reset()
        End If
    End Sub
    Private Sub Reset()
        BIdTB.Text = ""
        BNameTB.Text = ""
        BAuthorTB.Text = ""
        BPublisherTB.Text = ""
        QtyTB.Text = ""
        BNameTB.Focus()
        key = 0
    End Sub
    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Public Sub Runquery(ByVal query As String)
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@BID", BIdTB.Text)
        cmd.Parameters.AddWithValue("@BName", BNameTB.Text)
        cmd.Parameters.AddWithValue("@BAuthor", BAuthorTB.Text)
        cmd.Parameters.AddWithValue("@BPublisher", BPublisherTB.Text)
        cmd.Parameters.AddWithValue("@BQty", QtyTB.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If BNameTB.Text = "" Or BAuthorTB.Text = "" Or BPublisherTB.Text = "" Or BId.Text = "" Or Qty.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = "update BookTB set BId=" & BIdTB.Text & ",BName=' " & BNameTB.Text & " ',BAuthor='" & BAuthorTB.Text & "',BPublisher='" & BPublisherTB.Text & "',BQty= " & QtyTB.Text & " where BId=" & key & ""
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub
    Private Sub Books_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
    Dim key = 0
    Private Sub BooksDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BooksDGV.CellMouseClick
        Dim row As DataGridViewRow = BooksDGV.Rows(e.RowIndex)
        BIdTB.Text = row.Cells(0).Value.ToString
        BNameTB.Text = row.Cells(1).Value.ToString
        BAuthorTB.Text = row.Cells(2).Value.ToString
        BPublisherTB.Text = row.Cells(3).Value.ToString
        QtyTB.Text = row.Cells(4).Value.ToString
        If BNameTB.Text = "" Then
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
            Dim query = " delete from BookTB where BId=" & key & ""
            Dim cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub BackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        Dim obj = New MainForm
        obj.Show()
        Me.Hide()

    End Sub
End Class