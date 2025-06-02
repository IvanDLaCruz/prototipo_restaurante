Public Class Form2
    Public totalMesa As Integer = 315

    Public totalCuenta As Integer

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        cb1.Checked = True
        cb2.Checked = True
        cb3.Checked = True
        cb4.Checked = True
        cb5.Checked = True
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        cb5.Checked = False
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Form1.Show()
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If (cb1.Checked = True) Then
            totalCuenta += 85
        ElseIf cb1.Checked = False Then
            totalCuenta -= 85
        End If

        TxtTotal.Text = totalCuenta.ToString("C")
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If (cb2.Checked = True) Then
            totalCuenta += 145
        ElseIf cb2.Checked = False Then
            totalCuenta -= 145
        End If

        TxtTotal.Text = totalCuenta.ToString("C")
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If (cb3.Checked = True) Then
            totalCuenta += 40
        ElseIf cb3.Checked = False Then
            totalCuenta -= 40
        End If

        TxtTotal.Text = totalCuenta.ToString("C")
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If (cb4.Checked = True) Then
            totalCuenta += 25
        ElseIf cb4.Checked = False Then
            totalCuenta -= 25
        End If

        TxtTotal.Text = totalCuenta.ToString("C")
    End Sub

    Private Sub cb5_CheckedChanged(sender As Object, e As EventArgs) Handles cb5.CheckedChanged
        If (cb5.Checked = True) Then
            totalCuenta += 20
        ElseIf cb5.Checked = False Then
            totalCuenta -= 20
        End If

        TxtTotal.Text = totalCuenta.ToString("C")
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub
End Class