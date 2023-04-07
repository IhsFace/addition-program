Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dblFirstNumber As Double
        Dim dblSecondNumber As Double
        Dim dblSumOfNumbers As Double

        Try
            dblFirstNumber = CDbl(txt1stNumber.Text)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter a Numerical Value for the First Number", "Input Error")
        End Try

        Try
            dblSecondNumber = CDbl(txt2ndNumber.Text)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter a Numerical Value for the Second Number", "Input Error")
        End Try

        dblSumOfNumbers = dblFirstNumber + dblSecondNumber
        lblAnswer.Text = dblSumOfNumbers
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1stNumber.Text = Nothing
        txt2ndNumber.Text = Nothing
        lblAnswer.Text = Nothing
    End Sub
End Class
