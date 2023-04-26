Public Class AdminLogIn


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PassTb.Text = "" Then
            MsgBox("Enter Password")
        ElseIf PassTb.Text = "Admin" Then
            Dim obj = New Librarian
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Password")
            PassTb.Text = ""
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub
End Class