Public Class Form3


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
    End Sub

    Private Sub PB_Salir_Click(sender As Object, e As EventArgs) Handles PB_Salir.Click
        Application.Exit()
    End Sub

    Private Sub PB_Restaurante_Click(sender As Object, e As EventArgs) Handles PB_Restaurante.Click
        Form5.Show()
    End Sub
End Class