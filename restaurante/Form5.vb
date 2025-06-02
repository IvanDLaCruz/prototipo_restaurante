Imports MaterialSkin

Public Class Form5

    Private isDragging As Boolean = False
    Private offsetX As Integer
    Private offsetY As Integer
    Private draggedControl As Control = Nothing


    Private Sub PictureBox_MouseDown(sender As Object, e As MouseEventArgs)
        isDragging = True
        draggedControl = DirectCast(sender, Control)
        offsetX = e.X
        offsetY = e.Y
    End Sub

    Private Sub PictureBox_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging AndAlso draggedControl IsNot Nothing Then
            draggedControl.Left += (e.X - offsetX)
            draggedControl.Top += (e.Y - offsetY)
        End If
    End Sub

    Private Sub PictureBox_MouseUp(sender As Object, e As MouseEventArgs)
        isDragging = False
        draggedControl = Nothing
    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each pb As PictureBox In {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7}
            AddHandler pb.MouseDown, AddressOf PictureBox_MouseDown
            AddHandler pb.MouseMove, AddressOf PictureBox_MouseMove
            AddHandler pb.MouseUp, AddressOf PictureBox_MouseUp
        Next
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
    End Sub

    Private Sub Form5_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then

            If PictureBox1.BackColor = Color.Red Then
                PictureBox1.BackColor = Color.FromArgb(0, 192, 0)
            Else
                PictureBox1.BackColor = Color.Red
            End If

        End If
    End Sub
End Class