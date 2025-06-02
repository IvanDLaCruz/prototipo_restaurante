Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cbTipoPedido.Items.Add("Todos")
        cbTipoPedido.Items.Add("Local")
        cbTipoPedido.Items.Add("Para llevar")
        cbTipoPedido.Items.Add("Domicilio")
        cbTipoPedido.SelectedIndex = 0 ' Por defecto "Todos"

        ' Configura las columnas del DataGridView
        With dgvReporte.Columns
            .Add("colFecha", "Fecha")
            .Add("colProducto", "Producto")
            .Add("colCantidad", "Cantidad")
            .Add("colTotal", "Total")
            .Add("colTipo", "Tipo de Pedido")
        End With
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        GenerarReporte()
    End Sub

    Private Sub GenerarReporte()
        dgvReporte.Rows.Clear()

        Dim tipoFiltro As String = cbTipoPedido.SelectedItem.ToString()

        ' Simulando una fuente de datos
        Dim pedidos = {
        New With {.Fecha = "2025-05-28", .Producto = "Tacos", .Cantidad = 3, .Total = 90, .Tipo = "Para llevar"},
        New With {.Fecha = "2025-05-28", .Producto = "Refresco", .Cantidad = 2, .Total = 40, .Tipo = "Local"},
        New With {.Fecha = "2025-05-28", .Producto = "Hamburguesa", .Cantidad = 1, .Total = 70, .Tipo = "Domicilio"}
    }

        Dim total As Decimal = 0

        For Each p In pedidos
            If tipoFiltro = "Todos" OrElse tipoFiltro = p.Tipo Then
                dgvReporte.Rows.Add(p.Fecha, p.Producto, p.Cantidad, p.Total, p.Tipo)
                total += p.Total
            End If
        Next

        lblTotal.Text = "Total: " & total.ToString("C", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))

        ' Colores para distinguir tipo de pedido
        For Each fila As DataGridViewRow In dgvReporte.Rows
            If fila.Cells("colTipo").Value IsNot Nothing Then
                Select Case fila.Cells("colTipo").Value.ToString()
                    Case "Local"
                        fila.DefaultCellStyle.BackColor = Color.LightBlue
                    Case "Para llevar"
                        fila.DefaultCellStyle.BackColor = Color.LightGreen
                    Case "Domicilio"
                        fila.DefaultCellStyle.BackColor = Color.LightSalmon
                End Select
            End If
        Next

    End Sub



End Class