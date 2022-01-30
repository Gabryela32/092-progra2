Public Class Form1
    Const precioarroz As Double = 2.0
    Const precifrijol As Double = 1.75
    Const precioazucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagosiniva As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoconiva As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Res1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        pagosiniva = Val(txtArroz.Text) * precioarroz + Val(txtFrijol.Text) * precifrijol + Val(Txtazucar.Text) * precioazucar

        valorIVA = pagosiniva * IVA
        pagoconiva = pagosiniva + valorIVA
        descuento = pagoconiva * 0.025
        pagofinal = pagoconiva - descuento

        Res1.Text = pagosiniva
        Res2.Text = valorIVA
        Res3.Text = pagoconiva
        Res4.Text = descuento
        Res5.Text = pagofinal














    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtArroz.Text = ""
        txtFrijol.Text = ""
        Txtazucar.Text = ""
        Res1.Text = ""
        Res2.Text = ""
        Res3.Text = ""
        Res4.Text = ""
        Res5.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub txtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txtazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtazucar.KeyPress
        'para que solo acepte numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
