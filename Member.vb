Imports System.Data.OleDb

Public Class Member
    Dim cmd As OleDbCommand
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\OneDrive\Documents\Visual Studio 2010\Projects\Lib\Lib\LibrarySDB.accdb")
    Private Sub DisplayMember()
        con.Open()
        Dim query = " select * from StudentTB"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        MembersDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If MIdTB.Text = "" Or MNameTB.Text = "" Or DepartmentTB.Text = "" Or SemesterTB.SelectedIndex = -1 Or MobileTB.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf MobileTB.TextLength <> 10 Then
            MsgBox("Enter  A 10 Digit Mob. No")
        Else
            con.open()
            Dim query = "insert into StudentTB values(" & MIdTB.Text & ",'" & MNameTB.Text & "','" & DepartmentTB.Text & "'," & SemesterTB.SelectedItem.ToString & ",'" & MobileTB.Text & "')"
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Member Added")
            DisplayMember()
            Reset()
        End If
    End Sub
    Private Sub Reset()
        MIdTB.Text = ""
        MNameTB.Text = ""
        DepartmentTB.Text = ""
        SemesterTB.SelectedIndex = 0
        MobileTB.Text = ""
        MNameTB.Focus()
        key = 0
    End Sub

    Private Sub Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayMember()
    End Sub

    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub MembersDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MembersDGV.CellMouseClick
        Dim row As DataGridViewRow = MembersDGV.Rows(e.RowIndex)
        MIdTB.Text = row.Cells(0).Value.ToString
        MNameTB.Text = row.Cells(1).Value.ToString
        DepartmentTB.Text = row.Cells(2).Value.ToString
        SemesterTB.SelectedItem = row.Cells(3).Value.ToString
        MobileTB.Text = row.Cells(4).Value.ToString
        If MNameTB.Text = "" Then
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
            Dim query = " delete from StudentTB where StId=" & key & ""
            Dim cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Member Deleted")
            con.Close()
            DisplayMember()
            Reset()
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If MIdTB.Text = "" Or MNameTB.Text = "" Or DepartmentTB.Text = "" Or SemesterTB.SelectedIndex = -1 Or MobileTB.Text = "" Then
            MsgBox("Enter All Details")
        Else
            con.open()
            Dim query = "update StudentTB set StId=" & MIdTB.Text & ",StName=' " & MNameTB.Text & " ',StDep='" & DepartmentTB.Text & "',StSem=" & SemesterTB.SelectedItem.ToString & ",StPhone=" & MobileTB.Text & " where StId=" & key & ""
            Dim cmd As New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Member Updated")
            DisplayMember()
            Reset()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        Dim obj = New MainForm
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub MIdTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIdTB.TextChanged

    End Sub
End Class