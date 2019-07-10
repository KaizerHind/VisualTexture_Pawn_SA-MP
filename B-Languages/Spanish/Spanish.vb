Public Class Spanish
    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Private Sub Spanish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Gracias por usar VisualTexture."
        Label2.Text = "Esta herramienta a sido creada con el fin de proporcionar informacion mucho mas rapida, a la hora de"
        Label3.Text = "necesitar cualquier tipo de dato, con lo que se refiere a: Funciones, texturas, objectos, sonidos, entre"
        Label4.Text = "otros. De momento, esta herramienta se encuentra en Fase BETA, estamos trabajando constantemente"
        Label5.Text = "para actualizar los datos y el contenido que se proporciona."
        Label6.Text = "VisualTexture tiene como unico proposito, proporcionar datos al usuario, en caso de no tener una red"
        Label7.Text = "disponible y se necesite rapidamente informacion con respecto a pawn, o como bien se menciona"
        Label8.Text = "anteriormente, solo a proporciar informacion mas 'rapida'."
    End Sub

    Private Sub Spanish_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Spanish_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub Spanish_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
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

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        Index.Show()
        Me.Hide()
    End Sub

    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
    End Sub

    Private Sub AnimationsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationsViewerToolStripMenuItem.Click
        VAnims.Show()
        Me.Hide()
    End Sub

    Private Sub SoundsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        MsgBox("Opcion deshabilitada temporalmente.")
    End Sub

    Private Sub CreditosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditosToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Contact.Show()
    End Sub

    Private Sub VisualizadorDeSpritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizadorDeSpritesToolStripMenuItem.Click
        VSprites.Show()
        Me.Hide()
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