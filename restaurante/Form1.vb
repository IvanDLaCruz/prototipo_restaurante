Public Class Form1
    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_efectivo.CheckedChanged

    End Sub

    Private Sub PB_Efectivo_MouseClick(sender As Object, e As MouseEventArgs) Handles PB_Efectivo.MouseClick

        Rb_efectivo.Checked = True

    End Sub

    Private Sub PB_Tarjeta_Click(sender As Object, e As EventArgs) Handles PB_Tarjeta.Click


        Rb_Tarjeta.Checked = True
    End Sub

    Private Sub PB_Transferencia_Click(sender As Object, e As EventArgs) Handles PB_Transferencia.Click

        Rb_Transferencia.Checked = True
    End Sub

    Private Sub PB_Cobrar_Click(sender As Object, e As EventArgs) Handles PB_Cobrar.Click
        MessageBox.Show("Imprimiendo ticket")
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Rb_efectivo.Checked = True
    End Sub
End Class
