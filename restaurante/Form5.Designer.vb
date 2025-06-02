<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        PictureBox1.Image = My.Resources.Resources.comedor
        PictureBox1.Location = New Point(46, 196)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Red
        PictureBox2.Image = My.Resources.Resources.comedor
        PictureBox2.Location = New Point(257, 79)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 54)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Red
        PictureBox3.Image = My.Resources.Resources.comedor
        PictureBox3.Location = New Point(151, 196)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(65, 54)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        PictureBox4.Image = My.Resources.Resources.comedor
        PictureBox4.Location = New Point(257, 305)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(65, 54)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        PictureBox5.Image = My.Resources.Resources.comedor
        PictureBox5.Location = New Point(151, 79)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(65, 54)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        PictureBox6.Image = My.Resources.Resources.comedor
        PictureBox6.Location = New Point(46, 79)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(65, 54)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        PictureBox7.Image = My.Resources.Resources.comedor
        PictureBox7.Location = New Point(151, 305)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(65, 54)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox5)
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Controls.Add(PictureBox7)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(PictureBox6)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Location = New Point(7, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(405, 459)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mesas"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(504, 522)
        Controls.Add(GroupBox1)
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
