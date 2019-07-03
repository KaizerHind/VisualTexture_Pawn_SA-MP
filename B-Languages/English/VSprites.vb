Imports System.IO

Public Class VSprites

    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Public Property mainLocation As IEnumerable(Of String)

    Private Sub VSprites_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mainLocation = Directory.GetFiles(".\Sprites\", "*.png", SearchOption.AllDirectories)
        Dim spriteCount As Integer = 0
        Me.MaximizeBox = False
        For Each name As String In mainLocation
            Dim newLoc As String = Path.GetFileName(name)
            listBox1.Items.Add(newLoc)
            spriteCount += 1

        Next
        spriteCount += 1
        label4.Text = spriteCount & " SPRITES"
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AnimationsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationsViewerToolStripMenuItem.Click
        VAnims.Show()
        Me.Hide()
    End Sub

    Private Sub ObjectsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("This option is not in use yet.")
    End Sub

    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox1.SelectedIndexChanged
        Dim count As Integer = 0
        Dim imgPath As String = Nothing
        Dim imgLoc As String = Nothing
        For Each name As String In mainLocation
            If count > listBox1.SelectedIndex Then
                Exit For
            End If
            count += 1
            imgPath = name
            imgLoc = Directory.GetParent(name).Name & ":" & Path.GetFileNameWithoutExtension(imgPath)

        Next
        PictureBox1.Image = System.Drawing.Image.FromFile(imgPath)
        textBox1.Text = imgLoc.ToLower()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Contact.Show()
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub VSprites_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub VSprites_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub VSprites_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
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

    Private Sub PawnColorPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PawnColorPickerToolStripMenuItem.Click
        Pawncp.Show()
        Me.Hide()
    End Sub

    Private Sub SAMPScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAMPScriptToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class