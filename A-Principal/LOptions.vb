Public Class LOptions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Index.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Spanish.Show()
        Me.Hide()
    End Sub

    Private Sub LOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Coral
        TransparencyKey = BackColor
    End Sub
End Class