Public Class Index
    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Thanks for using VisualTextures."
        Label2.Text = "This tool has been created in order to provide much faster information, when it comes"
        Label3.Text = "to needing any type of information, with regard to: Functions, textures, objects, sounds, among others."
        Label4.Text = "At the moment, this tool is in the BETA Phase, we are constantly working to update the data and the"
        Label5.Text = "content that is provided."
        Label6.Text = "VisualTexture has as its only purpose, to provide data to the user, in case the person does not have a"
        Label7.Text = "network available, and information regarding pwn is needed quickly, or as mentioned above, we only"
        Label8.Text = "provide more 'quick' information."
    End Sub

    Private Sub Index_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Index_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub Index_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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


    Private Sub GroupBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub GroupBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub SpanishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanishToolStripMenuItem.Click
        Spanish.Show()
        Me.Hide()
    End Sub

    Private Sub AnimationsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationsViewerToolStripMenuItem.Click
        VAnims.Show()
        Me.Hide()
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
    End Sub

    Private Sub ObjectsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("This option is not in use yet.")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub SpriteViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpriteViewerToolStripMenuItem.Click
        VSprites.Show()
        Me.Hide()
    End Sub

    Private Sub PawnColorPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PawnColorPickerToolStripMenuItem.Click
        Pawncp.Show()
        Me.Hide()
    End Sub

    Private Sub EditorZoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorZoneToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/KaizerHind/VisualTexture_Pawn_SA-MP/releases/")
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Contact.Show()
    End Sub
End Class