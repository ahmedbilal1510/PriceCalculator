Public Class Form1
    Private Sub lblSubTotal_Click(sender As Object, e As EventArgs) Handles lblSubTotal.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim productName As String
        Dim price As Double
        Dim quantity As Integer
        Dim subTotal, tax, total As Double
        Const taxRate As Double = 0.08

        productName = txtPrdctName.Text
        price = txtPrice.Text
        quantity = txtQuantity.Text

        subTotal = quantity * price
        tax = subTotal * taxRate
        total = subTotal + tax

        Dim myFormat As String = "$#,##0.00"

        lblSubTotalAns.Text = Format(subTotal, myFormat)
        lblTaxAns.Text = Format(tax, myFormat)
        lblTotalAns.Text = Format(total, myFormat)





    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
