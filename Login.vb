Imports System.Data.OleDb

Public Class Login
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim obj = New AdminLogIn
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\OneDrive\Documents\Visual Studio 2010\Projects\Lib\Lib\LibrarySDB.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UserTb.Text = "" Then
            MsgBox("Enter Librarian Name")
        ElseIf PassTb.Text = "" Then
            MsgBox("Enter Password")
        Else
            con.open()
            Dim query = "select * from LibTB where LibName ='" & UserTb.Text & "' and LibPass='" & PassTb.Text & "'"
            Dim cmd = New OleDbCommand(query, con)
            Dim da = New OleDbDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("wrong username or password")
            Else
                Dim obj = New MainForm
                obj.Show()
                Me.Hide()
            End If
            con.close()
        End If
    End Sub

    Private Sub PassTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassTb.TextChanged

    End Sub
End Class