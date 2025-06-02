Public Class Form1

    Public pago, total, cambio As Integer

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
        Form2.totalMesa -= total
        total = 0
        pago = 0

        If Form2.cb1.Checked = True Then
            Form2.cb1.Enabled = False

        ElseIf Form2.cb2.Checked = True Then
            Form2.cb2.Enabled = False

        ElseIf Form2.cb3.Checked = True Then
            Form2.cb3.Enabled = False

        ElseIf Form2.cb4.Checked = True Then
            Form2.cb4.Enabled = False

        ElseIf Form2.cb5.Checked = True Then
            Form2.cb5.Enabled = False
        End If


        Txt_Cambio.Clear()
        Txt_Pago.Clear()
        Txt_Total.Clear()
        MessageBox.Show("Imprimiendo ticket")
        Form2.TxtTotal.Clear()



        Close()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        total = Form2.totalCuenta
        Rb_efectivo.Checked = True
        Txt_Total.Text = total.ToString("C")
    End Sub

    Private Sub Txt_Pago_TextChanged(sender As Object, e As EventArgs) Handles Txt_Pago.TextChanged
        pago = Val(Txt_Pago.Text)
        cambio = pago - total
        Txt_Cambio.Text = cambio.ToString("C")

    End Sub
End Class
