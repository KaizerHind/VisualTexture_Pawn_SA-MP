Public Class Screenshots
    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean
    '#------------------------
    Dim images(5) As Bitmap
    Dim pos As Integer = 0

    Private Sub Screenshots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = 1
        PictureBox1.Image = images(pos)

        PictureBox1.Image = Global.VisualTextures.My.Resources.Infotexto
        images(1) = Global.VisualTextures.My.Resources.drop1
        images(2) = Global.VisualTextures.My.Resources.drop2
        images(3) = Global.VisualTextures.My.Resources.drop3
        images(4) = Global.VisualTextures.My.Resources.drop4
        images(5) = Global.VisualTextures.My.Resources.Infotexto
    End Sub

    Private Sub Screenshots_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Screenshots_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub Screenshots_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
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

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pos = pos + 1
        If (pos < images.Length - 1) Then
            PictureBox1.Image = images(pos)
        Else
            pos = images.Length - 1
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pos = pos - 1
        If (pos >= 1) Then
            PictureBox1.Image = images(pos)
        Else
            pos = 0
        End If
    End Sub
End Class