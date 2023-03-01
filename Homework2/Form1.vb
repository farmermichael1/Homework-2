Public Class Homework2
    Private Sub Homework2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub clear()
        txtPay.Text = ""
        lbFICAPay.Text = ""
        lbftPay.Text = ""
        lbstPay.Text = ""
        lbIncome.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Const cdecFica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        strIncome = txtPay.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState
        decNet = decIncome - (decFica + decFederal + decState)
        lbFICAPay.Text = FormatCurrency(decFica.ToString())
        lbftPay.Text = FormatCurrency(decFederal.ToString())
        lbstPay.Text = FormatCurrency(decState.ToString())
        lbIncome.Text = FormatCurrency(decNet.ToString())
    End Sub
End Class
