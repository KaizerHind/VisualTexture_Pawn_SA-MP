Public Class Credits
    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Credits_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Credits_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub Credits_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GroupBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub GroupBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class