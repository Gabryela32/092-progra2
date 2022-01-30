<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtazucar = New System.Windows.Forms.TextBox()
        Me.txtFrijol = New System.Windows.Forms.TextBox()
        Me.txtArroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Res1 = New System.Windows.Forms.Label()
        Me.Res2 = New System.Windows.Forms.Label()
        Me.Res3 = New System.Windows.Forms.Label()
        Me.Res4 = New System.Windows.Forms.Label()
        Me.Res5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtazucar)
        Me.GroupBox1.Controls.Add(Me.txtFrijol)
        Me.GroupBox1.Controls.Add(Me.txtArroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de ingreso"
        '
        'Txtazucar
        '
        Me.Txtazucar.Location = New System.Drawing.Point(147, 138)
        Me.Txtazucar.Name = "Txtazucar"
        Me.Txtazucar.Size = New System.Drawing.Size(150, 22)
        Me.Txtazucar.TabIndex = 5
        Me.Txtazucar.Text = "0"
        '
        'txtFrijol
        '
        Me.txtFrijol.Location = New System.Drawing.Point(146, 82)
        Me.txtFrijol.Name = "txtFrijol"
        Me.txtFrijol.Size = New System.Drawing.Size(150, 22)
        Me.txtFrijol.TabIndex = 4
        Me.txtFrijol.Text = "0"
        '
        'txtArroz
        '
        Me.txtArroz.Location = New System.Drawing.Point(146, 35)
        Me.txtArroz.Name = "txtArroz"
        Me.txtArroz.Size = New System.Drawing.Size(151, 22)
        Me.txtArroz.TabIndex = 3
        Me.txtArroz.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libras de azucar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras de frijol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libras de arroz"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Aceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(434, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 186)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(99, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(99, 21)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(114, 33)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pago antes del IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Valor del IVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Pago con IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Descuento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total"
        '
        'Res1
        '
        Me.Res1.AutoSize = True
        Me.Res1.Location = New System.Drawing.Point(144, 32)
        Me.Res1.Name = "Res1"
        Me.Res1.Size = New System.Drawing.Size(24, 16)
        Me.Res1.TabIndex = 7
        Me.Res1.Text = "0,0"
        '
        'Res2
        '
        Me.Res2.AutoSize = True
        Me.Res2.Location = New System.Drawing.Point(144, 75)
        Me.Res2.Name = "Res2"
        Me.Res2.Size = New System.Drawing.Size(24, 16)
        Me.Res2.TabIndex = 8
        Me.Res2.Text = "0,0"
        '
        'Res3
        '
        Me.Res3.AutoSize = True
        Me.Res3.Location = New System.Drawing.Point(144, 121)
        Me.Res3.Name = "Res3"
        Me.Res3.Size = New System.Drawing.Size(24, 16)
        Me.Res3.TabIndex = 9
        Me.Res3.Text = "0,0"
        '
        'Res4
        '
        Me.Res4.AutoSize = True
        Me.Res4.Location = New System.Drawing.Point(144, 169)
        Me.Res4.Name = "Res4"
        Me.Res4.Size = New System.Drawing.Size(24, 16)
        Me.Res4.TabIndex = 10
        Me.Res4.Text = "0,0"
        '
        'Res5
        '
        Me.Res5.AutoSize = True
        Me.Res5.Location = New System.Drawing.Point(384, 169)
        Me.Res5.Name = "Res5"
        Me.Res5.Size = New System.Drawing.Size(24, 16)
        Me.Res5.TabIndex = 11
        Me.Res5.Text = "0,0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Res5)
        Me.GroupBox3.Controls.Add(Me.Res1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Res4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Res3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Res2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(141, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(534, 211)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtazucar As TextBox
    Friend WithEvents txtFrijol As TextBox
    Friend WithEvents txtArroz As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Res1 As Label
    Friend WithEvents Res2 As Label
    Friend WithEvents Res3 As Label
    Friend WithEvents Res4 As Label
    Friend WithEvents Res5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Aceptar As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
