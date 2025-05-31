<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        cb4 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        GroupBox1 = New GroupBox()
        MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        cb3 = New MaterialSkin.Controls.MaterialCheckbox()
        cb5 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        cb2 = New MaterialSkin.Controls.MaterialCheckbox()
        cb1 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox1 = New PictureBox()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        MaterialLabel14 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel15 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(26, 38)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(82, 19)
        MaterialLabel1.TabIndex = 0
        MaterialLabel1.Text = "Mesa Num."
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(114, 38)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(19, 19)
        MaterialLabel2.TabIndex = 1
        MaterialLabel2.Text = "09"
        ' 
        ' MaterialLabel6
        ' 
        MaterialLabel6.AutoSize = True
        MaterialLabel6.Depth = 0
        MaterialLabel6.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel6.Location = New Point(214, 38)
        MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel6.Name = "MaterialLabel6"
        MaterialLabel6.Size = New Size(59, 19)
        MaterialLabel6.TabIndex = 8
        MaterialLabel6.Text = "Atendio:"
        ' 
        ' MaterialLabel10
        ' 
        MaterialLabel10.AutoSize = True
        MaterialLabel10.Depth = 0
        MaterialLabel10.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel10.Location = New Point(211, 89)
        MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel10.Name = "MaterialLabel10"
        MaterialLabel10.Size = New Size(50, 19)
        MaterialLabel10.TabIndex = 10
        MaterialLabel10.Text = "$85.00"
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Depth = 0
        cb4.Location = New Point(46, 230)
        cb4.Margin = New Padding(0)
        cb4.MouseLocation = New Point(-1, -1)
        cb4.MouseState = MaterialSkin.MouseState.HOVER
        cb4.Name = "cb4"
        cb4.ReadOnly = False
        cb4.Ripple = True
        cb4.Size = New Size(138, 37)
        cb4.TabIndex = 12
        cb4.Text = "Coca Cola 450"
        cb4.TextAlign = ContentAlignment.MiddleCenter
        cb4.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel11
        ' 
        MaterialLabel11.AutoSize = True
        MaterialLabel11.Depth = 0
        MaterialLabel11.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel11.Location = New Point(21, 53)
        MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel11.Name = "MaterialLabel11"
        MaterialLabel11.Size = New Size(62, 19)
        MaterialLabel11.TabIndex = 9
        MaterialLabel11.Text = "Platillos:"
        ' 
        ' MaterialLabel9
        ' 
        MaterialLabel9.AutoSize = True
        MaterialLabel9.Depth = 0
        MaterialLabel9.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel9.Location = New Point(21, 203)
        MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel9.Name = "MaterialLabel9"
        MaterialLabel9.Size = New Size(62, 19)
        MaterialLabel9.TabIndex = 11
        MaterialLabel9.Text = "Bebidas:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MaterialLabel16)
        GroupBox1.Controls.Add(MaterialLabel12)
        GroupBox1.Controls.Add(cb3)
        GroupBox1.Controls.Add(cb5)
        GroupBox1.Controls.Add(MaterialLabel7)
        GroupBox1.Controls.Add(cb4)
        GroupBox1.Controls.Add(MaterialLabel8)
        GroupBox1.Controls.Add(MaterialLabel9)
        GroupBox1.Controls.Add(cb2)
        GroupBox1.Controls.Add(cb1)
        GroupBox1.Controls.Add(MaterialLabel4)
        GroupBox1.Controls.Add(MaterialLabel11)
        GroupBox1.Controls.Add(MaterialLabel10)
        GroupBox1.Location = New Point(26, 84)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(342, 322)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Productos"
        ' 
        ' MaterialLabel12
        ' 
        MaterialLabel12.AutoSize = True
        MaterialLabel12.Depth = 0
        MaterialLabel12.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel12.Location = New Point(211, 277)
        MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel12.Name = "MaterialLabel12"
        MaterialLabel12.Size = New Size(50, 19)
        MaterialLabel12.TabIndex = 23
        MaterialLabel12.Text = "$20.00"
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Depth = 0
        cb3.Location = New Point(46, 153)
        cb3.Margin = New Padding(0)
        cb3.MouseLocation = New Point(-1, -1)
        cb3.MouseState = MaterialSkin.MouseState.HOVER
        cb3.Name = "cb3"
        cb3.ReadOnly = False
        cb3.Ripple = True
        cb3.Size = New Size(110, 37)
        cb3.TabIndex = 17
        cb3.Text = "Quesadilla"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Depth = 0
        cb5.Location = New Point(46, 267)
        cb5.Margin = New Padding(0)
        cb5.MouseLocation = New Point(-1, -1)
        cb5.MouseState = MaterialSkin.MouseState.HOVER
        cb5.Name = "cb5"
        cb5.ReadOnly = False
        cb5.Ripple = True
        cb5.Size = New Size(128, 37)
        cb5.TabIndex = 13
        cb5.Text = "Jamaica 500"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel7
        ' 
        MaterialLabel7.AutoSize = True
        MaterialLabel7.Depth = 0
        MaterialLabel7.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel7.Location = New Point(211, 240)
        MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel7.Name = "MaterialLabel7"
        MaterialLabel7.Size = New Size(50, 19)
        MaterialLabel7.TabIndex = 21
        MaterialLabel7.Text = "$25.00"
        ' 
        ' MaterialLabel8
        ' 
        MaterialLabel8.AutoSize = True
        MaterialLabel8.Depth = 0
        MaterialLabel8.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel8.Location = New Point(211, 163)
        MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel8.Name = "MaterialLabel8"
        MaterialLabel8.Size = New Size(50, 19)
        MaterialLabel8.TabIndex = 20
        MaterialLabel8.Text = "$45.00"
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Depth = 0
        cb2.Location = New Point(46, 116)
        cb2.Margin = New Padding(0)
        cb2.MouseLocation = New Point(-1, -1)
        cb2.MouseState = MaterialSkin.MouseState.HOVER
        cb2.Name = "cb2"
        cb2.ReadOnly = False
        cb2.Ripple = True
        cb2.Size = New Size(74, 37)
        cb2.TabIndex = 16
        cb2.Text = "Pizza"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Depth = 0
        cb1.Location = New Point(46, 79)
        cb1.Margin = New Padding(0)
        cb1.MouseLocation = New Point(-1, -1)
        cb1.MouseState = MaterialSkin.MouseState.HOVER
        cb1.Name = "cb1"
        cb1.ReadOnly = False
        cb1.Ripple = True
        cb1.Size = New Size(135, 37)
        cb1.TabIndex = 15
        cb1.Text = "Hamburguesa"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(211, 126)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(59, 19)
        MaterialLabel4.TabIndex = 17
        MaterialLabel4.Text = "$145.00"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(440, 269)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(100, 19)
        MaterialLabel3.TabIndex = 15
        MaterialLabel3.Text = "Total a pagar:"
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(440, 486)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(127, 19)
        MaterialLabel5.TabIndex = 16
        MaterialLabel5.Text = "Continuar al pago"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.wallet
        PictureBox1.Location = New Point(440, 386)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 9.6F)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(440, 307)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(166, 50)
        MaterialTextBox1.TabIndex = 19
        MaterialTextBox1.Text = "$135.00"
        MaterialTextBox1.TrailingIcon = Nothing
        ' 
        ' MaterialLabel13
        ' 
        MaterialLabel13.AutoSize = True
        MaterialLabel13.Depth = 0
        MaterialLabel13.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel13.Location = New Point(279, 38)
        MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel13.Name = "MaterialLabel13"
        MaterialLabel13.Size = New Size(72, 19)
        MaterialLabel13.TabIndex = 22
        MaterialLabel13.Text = "Pito Perez"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.all
        PictureBox2.Location = New Point(51, 425)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(95, 74)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.dustpan
        PictureBox3.Location = New Point(212, 425)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(95, 74)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' MaterialLabel14
        ' 
        MaterialLabel14.AutoSize = True
        MaterialLabel14.Depth = 0
        MaterialLabel14.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel14.Location = New Point(194, 502)
        MaterialLabel14.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel14.Name = "MaterialLabel14"
        MaterialLabel14.Size = New Size(136, 19)
        MaterialLabel14.TabIndex = 25
        MaterialLabel14.Text = "Limpiar seleccion" & vbCrLf
        ' 
        ' MaterialLabel15
        ' 
        MaterialLabel15.AutoSize = True
        MaterialLabel15.Depth = 0
        MaterialLabel15.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel15.Location = New Point(37, 502)
        MaterialLabel15.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel15.Name = "MaterialLabel15"
        MaterialLabel15.Size = New Size(119, 19)
        MaterialLabel15.TabIndex = 26
        MaterialLabel15.Text = "Seleccionar todo"
        ' 
        ' MaterialLabel16
        ' 
        MaterialLabel16.AutoSize = True
        MaterialLabel16.Depth = 0
        MaterialLabel16.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel16.Location = New Point(211, 53)
        MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel16.Name = "MaterialLabel16"
        MaterialLabel16.Size = New Size(57, 19)
        MaterialLabel16.TabIndex = 27
        MaterialLabel16.Text = "Precios:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(654, 527)
        Controls.Add(MaterialLabel15)
        Controls.Add(MaterialLabel14)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(MaterialLabel13)
        Controls.Add(MaterialTextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(MaterialLabel5)
        Controls.Add(MaterialLabel3)
        Controls.Add(GroupBox1)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel6)
        Controls.Add(MaterialLabel1)
        Name = "Form2"
        Text = "Cuenta_Mesa"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cb4 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb3 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents cb5 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents cb2 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents cb1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MaterialLabel14 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
End Class
