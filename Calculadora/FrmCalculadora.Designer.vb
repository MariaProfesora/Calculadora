<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnLimpiarDatos = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOperaciones = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDivision.Location = New System.Drawing.Point(193, 156)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(38, 38)
        Me.btnDivision.TabIndex = 42
        Me.btnDivision.Text = "/"
        '
        'btnProducto
        '
        Me.btnProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProducto.Location = New System.Drawing.Point(153, 156)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(38, 38)
        Me.btnProducto.TabIndex = 46
        Me.btnProducto.Text = "x"
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIgual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnIgual.Location = New System.Drawing.Point(153, 202)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(78, 32)
        Me.btnIgual.TabIndex = 47
        Me.btnIgual.Text = "="
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnResta.Location = New System.Drawing.Point(193, 112)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(38, 38)
        Me.btnResta.TabIndex = 45
        Me.btnResta.Text = "-"
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSuma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSuma.Location = New System.Drawing.Point(153, 112)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(38, 38)
        Me.btnSuma.TabIndex = 43
        Me.btnSuma.Text = "+"
        '
        'btnLimpiarDatos
        '
        Me.btnLimpiarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiarDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiarDatos.Location = New System.Drawing.Point(100, 214)
        Me.btnLimpiarDatos.Name = "btnLimpiarDatos"
        Me.btnLimpiarDatos.Size = New System.Drawing.Size(38, 38)
        Me.btnLimpiarDatos.TabIndex = 44
        Me.btnLimpiarDatos.Text = "CE"
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn0.Location = New System.Drawing.Point(60, 214)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(38, 38)
        Me.btn0.TabIndex = 29
        Me.btn0.Text = "0"
        '
        'btnComa
        '
        Me.btnComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnComa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnComa.Location = New System.Drawing.Point(20, 214)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(38, 38)
        Me.btnComa.TabIndex = 30
        Me.btnComa.Text = ","
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn9.Location = New System.Drawing.Point(100, 174)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(38, 38)
        Me.btn9.TabIndex = 28
        Me.btn9.Text = "9"
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn8.Location = New System.Drawing.Point(60, 174)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(38, 38)
        Me.btn8.TabIndex = 26
        Me.btn8.Text = "8"
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn7.Location = New System.Drawing.Point(20, 174)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(38, 38)
        Me.btn7.TabIndex = 27
        Me.btn7.Text = "7"
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn6.Location = New System.Drawing.Point(100, 134)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(38, 38)
        Me.btn6.TabIndex = 31
        Me.btn6.Text = "6"
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn5.Location = New System.Drawing.Point(60, 134)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(38, 38)
        Me.btn5.TabIndex = 35
        Me.btn5.Text = "5"
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn4.Location = New System.Drawing.Point(20, 134)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(38, 38)
        Me.btn4.TabIndex = 36
        Me.btn4.Text = "4"
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn3.Location = New System.Drawing.Point(100, 94)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(38, 38)
        Me.btn3.TabIndex = 34
        Me.btn3.Text = "3"
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn2.Location = New System.Drawing.Point(60, 94)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(38, 38)
        Me.btn2.TabIndex = 32
        Me.btn2.Text = "2"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn1.Location = New System.Drawing.Point(20, 94)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(38, 38)
        Me.btn1.TabIndex = 33
        Me.btn1.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Operaciones"
        '
        'lblOperaciones
        '
        Me.lblOperaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperaciones.Location = New System.Drawing.Point(95, 15)
        Me.lblOperaciones.Name = "lblOperaciones"
        Me.lblOperaciones.Size = New System.Drawing.Size(146, 25)
        Me.lblOperaciones.TabIndex = 49
        Me.lblOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(45, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Valor "
        '
        'lblNumero
        '
        Me.lblNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(97, 53)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(75, 25)
        Me.lblNumero.TabIndex = 51
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 278)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOperaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnLimpiarDatos)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnComa)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnLimpiarDatos As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnComa As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOperaciones As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumero As Label
End Class
