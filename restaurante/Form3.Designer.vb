<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        PictureBox1 = New PictureBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        PB_Menu = New PictureBox()
        PB_Restaurante = New PictureBox()
        PB_Salir = New PictureBox()
        PictureBox5 = New PictureBox()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PB_Menu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PB_Restaurante, ComponentModel.ISupportInitialize).BeginInit()
        CType(PB_Salir, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Dock = DockStyle.Left
        MaterialDivider1.Location = New Point(0, 0)
        MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(144, 1033)
        MaterialDivider1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cash_register
        PictureBox1.Location = New Point(12, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(32, 166)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(68, 19)
        MaterialLabel1.TabIndex = 2
        MaterialLabel1.Text = "Abrir caja"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(32, 388)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(86, 19)
        MaterialLabel2.TabIndex = 3
        MaterialLabel2.Text = "Restaurante"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(59, 574)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(41, 19)
        MaterialLabel3.TabIndex = 4
        MaterialLabel3.Text = "Menu"
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(37, 774)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(63, 19)
        MaterialLabel4.TabIndex = 5
        MaterialLabel4.Text = "Reportes"
        ' 
        ' PB_Menu
        ' 
        PB_Menu.Image = My.Resources.Resources.menu
        PB_Menu.Location = New Point(12, 467)
        PB_Menu.Name = "PB_Menu"
        PB_Menu.Size = New Size(118, 104)
        PB_Menu.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Menu.TabIndex = 6
        PB_Menu.TabStop = False
        ' 
        ' PB_Restaurante
        ' 
        PB_Restaurante.Image = My.Resources.Resources.restaurante
        PB_Restaurante.Location = New Point(12, 281)
        PB_Restaurante.Name = "PB_Restaurante"
        PB_Restaurante.Size = New Size(118, 104)
        PB_Restaurante.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Restaurante.TabIndex = 7
        PB_Restaurante.TabStop = False
        ' 
        ' PB_Salir
        ' 
        PB_Salir.Image = My.Resources.Resources.cerrar
        PB_Salir.Location = New Point(12, 890)
        PB_Salir.Name = "PB_Salir"
        PB_Salir.Size = New Size(118, 104)
        PB_Salir.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Salir.TabIndex = 8
        PB_Salir.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.reporte_de_negocios
        PictureBox5.Location = New Point(12, 667)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(118, 104)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(59, 997)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(33, 19)
        MaterialLabel5.TabIndex = 10
        MaterialLabel5.Text = "Salir"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(MaterialLabel5)
        Controls.Add(PictureBox5)
        Controls.Add(PB_Salir)
        Controls.Add(PB_Restaurante)
        Controls.Add(PB_Menu)
        Controls.Add(MaterialLabel4)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(PictureBox1)
        Controls.Add(MaterialDivider1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form3"
        Text = "Menu Principal"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PB_Menu, ComponentModel.ISupportInitialize).EndInit()
        CType(PB_Restaurante, ComponentModel.ISupportInitialize).EndInit()
        CType(PB_Salir, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PB_Menu As PictureBox
    Friend WithEvents PB_Restaurante As PictureBox
    Friend WithEvents PB_Salir As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
End Class
