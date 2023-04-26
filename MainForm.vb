Public Class MainForm

    Private Sub Member_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Member.Click
        Dim obj = New Member
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub AllBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllBooks.Click
        Dim obj = New Books
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub IssuedBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuedBooks.Click
        Dim obj = New IssuedBooks
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ReturnBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBooks.Click
        Dim obj = New BookReturn
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub LogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogIn.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class