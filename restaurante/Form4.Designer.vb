<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        SuspendLayout()
        ' 
        ' MaterialTextBox21
        ' 
        MaterialTextBox21.AnimateReadOnly = False
        MaterialTextBox21.BackgroundImageLayout = ImageLayout.None
        MaterialTextBox21.CharacterCasing = CharacterCasing.Normal
        MaterialTextBox21.Depth = 0
        MaterialTextBox21.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox21.HideSelection = True
        MaterialTextBox21.LeadingIcon = Nothing
        MaterialTextBox21.Location = New Point(29, 94)
        MaterialTextBox21.MaxLength = 32767
        MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox21.Name = "MaterialTextBox21"
        MaterialTextBox21.PasswordChar = ChrW(0)
        MaterialTextBox21.PrefixSuffixText = Nothing
        MaterialTextBox21.ReadOnly = False
        MaterialTextBox21.RightToLeft = RightToLeft.No
        MaterialTextBox21.SelectedText = ""
        MaterialTextBox21.SelectionLength = 0
        MaterialTextBox21.SelectionStart = 0
        MaterialTextBox21.ShortcutsEnabled = True
        MaterialTextBox21.Size = New Size(201, 48)
        MaterialTextBox21.TabIndex = 0
        MaterialTextBox21.TabStop = False
        MaterialTextBox21.Text = "$1500.00"
        MaterialTextBox21.TextAlign = HorizontalAlignment.Left
        MaterialTextBox21.TrailingIcon = Nothing
        MaterialTextBox21.UseSystemPasswordChar = False
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(83, 151)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(86, 36)
        MaterialButton1.TabIndex = 1
        MaterialButton1.Text = "Aceptar"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(29, 52)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(96, 19)
        MaterialLabel1.TabIndex = 2
        MaterialLabel1.Text = "Fondo inicial:"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(273, 220)
        Controls.Add(MaterialLabel1)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialTextBox21)
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
