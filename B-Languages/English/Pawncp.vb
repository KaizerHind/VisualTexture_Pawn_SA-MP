
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Pawncp

    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Private Sub Pawncp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ChangeBoxText()
        textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor)
        textBox2.Text = HexConverter(pictureBox1.BackColor)
        timer1.Enabled = 1
        timer1.Interval = 200
        timer1.Start()

        Me.Opacity = 0
        Dim i As Double = 0
        Do While (i <= 1)
            Me.Opacity = i
            Me.Refresh()
            System.Threading.Thread.Sleep(15)
            i = (i + 0.1)
        Loop

    End Sub

    ' RGB To HEX Color
    Private Shared Function HexConverter(ByVal c As System.Drawing.Color) As String
        Return ("{" _
                        + (c.R.ToString("X2") _
                        + (c.G.ToString("X2") _
                        + (c.B.ToString("X2") + "}"))))
    End Function

    ' RGB To PAWN Color
    Private Shared Function RGBToPAWNConverter(ByVal c As System.Drawing.Color) As String
        Return ("0x" _
                        + (c.R.ToString("X2") _
                        + (c.G.ToString("X2") _
                        + (c.B.ToString("X2") + c.A.ToString("X2")))))
    End Function

    ' Change pictureBox1
    Private Sub ChangeBoxText()
        pictureBox1.BackColor = Color.FromArgb(hScrollBar4.Value, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value)
    End Sub

    Private Sub hScrollBar1_Scroll_1(sender As Object, e As ScrollEventArgs) Handles hScrollBar1.Scroll
        Dim preview As Color = Color.FromArgb(hScrollBar4.Value, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value)
        pictureBox1.BackColor = preview
        textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor)
        textBox2.Text = HexConverter(pictureBox1.BackColor)
    End Sub

    Private Sub hScrollBar2_Scroll_1(sender As Object, e As ScrollEventArgs) Handles hScrollBar2.Scroll
        Me.ChangeBoxText()
        textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor)

        textBox2.Text = HexConverter(pictureBox1.BackColor)
    End Sub

    Private Sub hScrollBar3_Scroll_1(sender As Object, e As ScrollEventArgs) Handles hScrollBar3.Scroll
        Me.ChangeBoxText()
        textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor)

        textBox2.Text = HexConverter(pictureBox1.BackColor)
    End Sub

    Private Sub hScrollBar4_Scroll_1(sender As Object, e As ScrollEventArgs) Handles hScrollBar4.Scroll
        Me.ChangeBoxText()
        textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor)
        textBox2.Text = HexConverter(pictureBox1.BackColor)
    End Sub

    Private Sub timer1_Tick_1(sender As Object, e As EventArgs) Handles timer1.Tick
        Dim random As Random = New Random
        random = New Random
        label1.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))
    End Sub

    Private Sub toolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles toolStrip1.ItemClicked
        'this.linkLabel1.LinkVisited = true;
        System.Diagnostics.Process.Start("http://forum.sa-mp.com/member.php?u=146395")
    End Sub

    Private Sub Pawncp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Pawncp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub Pawncp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
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
        Application.Exit()
    End Sub

    Private Sub AnimationsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationsViewerToolStripMenuItem.Click
        VAnims.Show()
        Me.Hide()
    End Sub


    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub SpriteViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpriteViewerToolStripMenuItem.Click
        VSprites.Show()
        Me.Hide()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Contact.Show()
        Me.Hide()
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
        Me.Hide()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
        Me.Hide()
    End Sub

    Private Sub SAMPScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAMPScriptToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub

End Class