Public Class Form6
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CargarProductos("Platillos")
        PictureBox2.BorderStyle = BorderStyle.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CargarProductos("Bebidas")
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub CargarProductos(categoria As String)
        lvProductos.Items.Clear()

        Dim productos As New List(Of Tuple(Of String, Decimal))

        If categoria = "Platillos" Then
            productos.Add(Tuple.Create("Tacos", 35D))
            productos.Add(Tuple.Create("Hamburguesa", 60D))
        ElseIf categoria = "Bebidas" Then
            productos.Add(Tuple.Create("Refresco", 20D))
            productos.Add(Tuple.Create("Agua", 15D))
        End If

        For Each prod In productos
            Dim item As New ListViewItem(prod.Item1)
            item.SubItems.Add(prod.Item2.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("es-MX")))
            lvProductos.Items.Add(item)
        Next
    End Sub




    Private Sub Producto_Click(sender As Object, e As EventArgs)
        Dim lbl As Label = CType(sender, Label)
        MessageBox.Show($"Seleccionaste: {lbl.Text}")
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvProductos.Columns.Add("Producto", 150)
        lvProductos.Columns.Add("Precio", 70)
        lvProductos.View = View.Details
        CargarProductos("Platillos")
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        For Each item As ListViewItem In lvProductos.Items
            item.BackColor = If(item.Text.ToLower().Contains(txtBusqueda.Text.ToLower()), Color.LightGreen, Color.White)
        Next
    End Sub


End Class