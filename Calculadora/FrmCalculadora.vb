Public Class FrmCalculadora
    Dim limpiarValor, limpiarOperaciones As Boolean
    Dim Operando1 As Double, Operando2 As Double
    Dim Operador As String

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Dim resultado As Double
        If lblNumero.Text = "" Then Exit Sub
        Operando2 = lblNumero.Text
        Try
            Select Case Operador
                Case "+"
                    resultado = Operando1 + Operando2
                Case "-"
                    resultado = Operando1 - Operando2
                Case "x"
                    resultado = Operando1 * Operando2
                Case "/"
                    If Operando2 <> "0" Then
                        resultado = Operando1 / Operando2
                    End If
            End Select
            lblNumero.Text = resultado
        Catch exc As Exception
            MsgBox(exc.Message)
            resultado = "ERROR"
        End Try
        lblNumero.Text = resultado
        limpiarValor = True
        limpiarOperaciones = True
    End Sub

    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        If limpiarValor Then
            lblNumero.Text = ""
            limpiarValor = False
        End If
        If limpiarOperaciones Then
            lblOperaciones.Text = ""
            limpiarOperaciones = False
        End If
        Dim numero As Byte = TryCast(sender, Button).Text
        Dim numeroEti As Integer

        If numero = 0 AndAlso Integer.TryParse(lblOperaciones.Text, numeroEti) Then Exit Sub
        lblNumero.Text &= numero
        lblOperaciones.Text &= numero
    End Sub
    Function HayOperador() As Boolean
        Const operadores As String = "+-x/"
        For i = 0 To operadores.Length - 1
            If lblOperaciones.Text.Contains(operadores.Chars(i).ToString) Then Return True
        Next
        Return False
    End Function
    Private Sub btnOperador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuma.Click, btnDivision.Click, btnResta.Click, btnProducto.Click
        If lblOperaciones.Text = "" Then Exit Sub ' Si no hay dato, no se admite operador
        If HayOperador() OrElse limpiarOperaciones Then
            If limpiarOperaciones Then
                MessageBox.Show("Ya has acabado con la operación, debes pulsar CE o un número para comenzar de nuevo")
            Else
                MessageBox.Show("Ya hay un operador, solo puedes pulsar el =")
            End If

            Exit Sub ' Si hay operador se ignora
        End If
        lblOperaciones.Text &= TryCast(sender, Button).Text
        Operando1 = lblNumero.Text
        Operador = TryCast(sender, Button).Text
        limpiarValor = True
    End Sub


    Private Sub btnbtnCambiarSigno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNumeric(Me.lblNumero.Text) Then Exit Sub
        lblNumero.Text = -lblNumero.Text
        limpiarValor = True
    End Sub
    Private Sub btnLimpiarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarDatos.Click
        lblNumero.Text = ""
        lblOperaciones.Text = ""
    End Sub
End Class
