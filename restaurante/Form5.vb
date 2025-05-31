Imports MaterialSkin

Public Class Form5
    ' Variables para arrastrar cualquier PictureBox
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
        ' Asignar eventos a cada PictureBox
        For Each pb As PictureBox In {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7}
            AddHandler pb.MouseDown, AddressOf PictureBox_MouseDown
            AddHandler pb.MouseMove, AddressOf PictureBox_MouseMove
            AddHandler pb.MouseUp, AddressOf PictureBox_MouseUp
        Next
    End Sub


End Class