<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvReporte = New DataGridView()
        cbTipoPedido = New ComboBox()
        btnGenerar = New Button()
        lblTotal = New Label()
        CType(dgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReporte
        ' 
        dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporte.Location = New Point(42, 83)
        dgvReporte.Name = "dgvReporte"
        dgvReporte.RowHeadersWidth = 51
        dgvReporte.Size = New Size(431, 310)
        dgvReporte.TabIndex = 0
        ' 
        ' cbTipoPedido
        ' 
        cbTipoPedido.FormattingEnabled = True
        cbTipoPedido.Location = New Point(121, 34)
        cbTipoPedido.Name = "cbTipoPedido"
        cbTipoPedido.Size = New Size(151, 28)
        cbTipoPedido.TabIndex = 1
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Location = New Point(296, 34)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(94, 29)
        btnGenerar.TabIndex = 2
        btnGenerar.Text = "Generar"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(393, 407)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(44, 20)
        lblTotal.TabIndex = 3
        lblTotal.Text = "$0.00"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 450)
        Controls.Add(lblTotal)
        Controls.Add(btnGenerar)
        Controls.Add(cbTipoPedido)
        Controls.Add(dgvReporte)
        Name = "Form7"
        Text = "Form7"
        CType(dgvReporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents cbTipoPedido As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents lblTotal As Label
End Class
