<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        PictureBox1 = New PictureBox()
        MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        PictureBox2 = New PictureBox()
        pnlProductos = New Panel()
        lvProductos = New ListView()
        txtBusqueda = New TextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlProductos.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.plato
        PictureBox1.Location = New Point(40, 90)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(29, 26)
        MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(162, 667)
        MaterialDivider1.TabIndex = 1
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.refresco
        PictureBox2.Location = New Point(40, 396)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(132, 142)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' pnlProductos
        ' 
        pnlProductos.Controls.Add(lvProductos)
        pnlProductos.Location = New Point(269, 90)
        pnlProductos.Name = "pnlProductos"
        pnlProductos.Size = New Size(546, 540)
        pnlProductos.TabIndex = 3
        ' 
        ' lvProductos
        ' 
        lvProductos.FullRowSelect = True
        lvProductos.GridLines = True
        lvProductos.Location = New Point(14, 21)
        lvProductos.Name = "lvProductos"
        lvProductos.Size = New Size(296, 121)
        lvProductos.TabIndex = 0
        lvProductos.UseCompatibleStateImageBehavior = False
        lvProductos.View = View.Details
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(283, 57)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(172, 27)
        txtBusqueda.TabIndex = 4
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(283, 35)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(72, 19)
        MaterialLabel1.TabIndex = 5
        MaterialLabel1.Text = "Busqueda"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(921, 714)
        Controls.Add(MaterialLabel1)
        Controls.Add(txtBusqueda)
        Controls.Add(pnlProductos)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MaterialDivider1)
        Name = "Form6"
        Text = "Form6"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlProductos.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlProductos As Panel
    Friend WithEvents lvProductos As ListView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
