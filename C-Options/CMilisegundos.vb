Public Class CMilisegundos
    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox2.Text = "" And TextBox3.Text = "") Then
            TextBox2.Text = Val(TextBox2.Text) * 60000
            TextBox3.Text = Val(TextBox2.Text) * 60000

        ElseIf (TextBox2.Text = "" And TextBox2.Text = "") Then
            TextBox2.Text = Val(TextBox3.Text) * 3600
            TextBox2.Text = Val(TextBox3.Text) * 60000
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se admiten numeros. 0-9")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se admiten numeros. 0-9")
        End If
    End Sub
End Class