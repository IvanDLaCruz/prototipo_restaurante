<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        PB_Tarjeta = New PictureBox()
        PB_Efectivo = New PictureBox()
        PB_Transferencia = New PictureBox()
        GroupBox1 = New GroupBox()
        Rb_Transferencia = New MaterialSkin.Controls.MaterialRadioButton()
        Rb_Tarjeta = New MaterialSkin.Controls.MaterialRadioButton()
        Rb_efectivo = New MaterialSkin.Controls.MaterialRadioButton()
        MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialTextBox3 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        PB_Cobrar = New PictureBox()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        CType(PB_Tarjeta, ComponentModel.ISupportInitialize).BeginInit()
        CType(PB_Efectivo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PB_Transferencia, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PB_Cobrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 9.6F)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(241, 309)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(173, 50)
        MaterialTextBox1.TabIndex = 0
        MaterialTextBox1.Text = "$200.00"
        MaterialTextBox1.TrailingIcon = Nothing
        ' 
        ' PB_Tarjeta
        ' 
        PB_Tarjeta.Image = CType(resources.GetObject("PB_Tarjeta.Image"), Image)
        PB_Tarjeta.Location = New Point(279, 29)
        PB_Tarjeta.Name = "PB_Tarjeta"
        PB_Tarjeta.Size = New Size(117, 77)
        PB_Tarjeta.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Tarjeta.TabIndex = 5
        PB_Tarjeta.TabStop = False
        ' 
        ' PB_Efectivo
        ' 
        PB_Efectivo.Image = My.Resources.Resources.money
        PB_Efectivo.Location = New Point(56, 29)
        PB_Efectivo.Name = "PB_Efectivo"
        PB_Efectivo.Size = New Size(117, 77)
        PB_Efectivo.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Efectivo.TabIndex = 6
        PB_Efectivo.TabStop = False
        ' 
        ' PB_Transferencia
        ' 
        PB_Transferencia.Image = My.Resources.Resources.money_transfer
        PB_Transferencia.Location = New Point(467, 26)
        PB_Transferencia.Name = "PB_Transferencia"
        PB_Transferencia.Size = New Size(117, 77)
        PB_Transferencia.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Transferencia.TabIndex = 7
        PB_Transferencia.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PB_Transferencia)
        GroupBox1.Controls.Add(Rb_Transferencia)
        GroupBox1.Controls.Add(PB_Tarjeta)
        GroupBox1.Controls.Add(PB_Efectivo)
        GroupBox1.Controls.Add(Rb_Tarjeta)
        GroupBox1.Controls.Add(Rb_efectivo)
        GroupBox1.Location = New Point(63, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(615, 163)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Metodos de pago"
        ' 
        ' Rb_Transferencia
        ' 
        Rb_Transferencia.AutoSize = True
        Rb_Transferencia.Depth = 0
        Rb_Transferencia.Location = New Point(478, 109)
        Rb_Transferencia.Margin = New Padding(0)
        Rb_Transferencia.MouseLocation = New Point(-1, -1)
        Rb_Transferencia.MouseState = MaterialSkin.MouseState.HOVER
        Rb_Transferencia.Name = "Rb_Transferencia"
        Rb_Transferencia.Ripple = True
        Rb_Transferencia.Size = New Size(92, 37)
        Rb_Transferencia.TabIndex = 2
        Rb_Transferencia.TabStop = True
        Rb_Transferencia.Text = "Efectivo"
        Rb_Transferencia.UseVisualStyleBackColor = True
        ' 
        ' Rb_Tarjeta
        ' 
        Rb_Tarjeta.AutoSize = True
        Rb_Tarjeta.Depth = 0
        Rb_Tarjeta.Location = New Point(289, 109)
        Rb_Tarjeta.Margin = New Padding(0)
        Rb_Tarjeta.MouseLocation = New Point(-1, -1)
        Rb_Tarjeta.MouseState = MaterialSkin.MouseState.HOVER
        Rb_Tarjeta.Name = "Rb_Tarjeta"
        Rb_Tarjeta.Ripple = True
        Rb_Tarjeta.Size = New Size(85, 37)
        Rb_Tarjeta.TabIndex = 1
        Rb_Tarjeta.TabStop = True
        Rb_Tarjeta.Text = "Tarjeta"
        Rb_Tarjeta.UseVisualStyleBackColor = True
        ' 
        ' Rb_efectivo
        ' 
        Rb_efectivo.AutoSize = True
        Rb_efectivo.Depth = 0
        Rb_efectivo.Location = New Point(67, 109)
        Rb_efectivo.Margin = New Padding(0)
        Rb_efectivo.MouseLocation = New Point(-1, -1)
        Rb_efectivo.MouseState = MaterialSkin.MouseState.HOVER
        Rb_efectivo.Name = "Rb_efectivo"
        Rb_efectivo.Ripple = True
        Rb_efectivo.Size = New Size(92, 37)
        Rb_efectivo.TabIndex = 0
        Rb_efectivo.TabStop = True
        Rb_efectivo.Text = "Efectivo"
        Rb_efectivo.UseVisualStyleBackColor = True
        ' 
        ' MaterialTextBox2
        ' 
        MaterialTextBox2.AnimateReadOnly = False
        MaterialTextBox2.BorderStyle = BorderStyle.None
        MaterialTextBox2.Depth = 0
        MaterialTextBox2.Font = New Font("Roboto", 9.6F)
        MaterialTextBox2.LeadingIcon = Nothing
        MaterialTextBox2.Location = New Point(241, 227)
        MaterialTextBox2.MaxLength = 50
        MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox2.Multiline = False
        MaterialTextBox2.Name = "MaterialTextBox2"
        MaterialTextBox2.Size = New Size(173, 50)
        MaterialTextBox2.TabIndex = 9
        MaterialTextBox2.Text = "$100.00"
        MaterialTextBox2.TrailingIcon = Nothing
        ' 
        ' MaterialTextBox3
        ' 
        MaterialTextBox3.AnimateReadOnly = False
        MaterialTextBox3.BorderStyle = BorderStyle.None
        MaterialTextBox3.Depth = 0
        MaterialTextBox3.Font = New Font("Roboto", 9.6F)
        MaterialTextBox3.LeadingIcon = Nothing
        MaterialTextBox3.Location = New Point(241, 377)
        MaterialTextBox3.MaxLength = 50
        MaterialTextBox3.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox3.Multiline = False
        MaterialTextBox3.Name = "MaterialTextBox3"
        MaterialTextBox3.Size = New Size(173, 50)
        MaterialTextBox3.TabIndex = 11
        MaterialTextBox3.Text = "$100.00"
        MaterialTextBox3.TrailingIcon = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(55, 258)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(42, 19)
        MaterialLabel1.TabIndex = 13
        MaterialLabel1.Text = "Total:"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(55, 408)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(60, 19)
        MaterialLabel2.TabIndex = 14
        MaterialLabel2.Text = "Cambio:"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(55, 340)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(42, 19)
        MaterialLabel3.TabIndex = 15
        MaterialLabel3.Text = "Pago:"
        ' 
        ' PB_Cobrar
        ' 
        PB_Cobrar.Image = My.Resources.Resources.right
        PB_Cobrar.Location = New Point(510, 267)
        PB_Cobrar.Name = "PB_Cobrar"
        PB_Cobrar.Size = New Size(168, 117)
        PB_Cobrar.SizeMode = PictureBoxSizeMode.StretchImage
        PB_Cobrar.TabIndex = 16
        PB_Cobrar.TabStop = False
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(562, 404)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(48, 19)
        MaterialLabel4.TabIndex = 17
        MaterialLabel4.Text = "Cobrar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(733, 450)
        Controls.Add(MaterialLabel4)
        Controls.Add(PB_Cobrar)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(MaterialTextBox3)
        Controls.Add(MaterialTextBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MaterialTextBox1)
        Name = "Form1"
        Text = "Pago"
        CType(PB_Tarjeta, ComponentModel.ISupportInitialize).EndInit()
        CType(PB_Efectivo, ComponentModel.ISupportInitialize).EndInit()
        CType(PB_Transferencia, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PB_Cobrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents PB_Tarjeta As PictureBox
    Friend WithEvents PB_Efectivo As PictureBox
    Friend WithEvents PB_Transferencia As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rb_efectivo As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rb_Transferencia As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Rb_Tarjeta As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox3 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PB_Cobrar As PictureBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel

End Class
