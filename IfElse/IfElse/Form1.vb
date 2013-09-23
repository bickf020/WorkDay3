Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then

            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            If (num1 > num2) Then
                txtResult.Text = "Larger Number Is " & num1
            ElseIf (num2 > num1) Then
                txtResult.Text = "Larger Number Is " & num2
            Else
                txtResult.Text = "The Two Are Equal"
            End If
        Else
            MessageBox.Show("Error: please type a number")
        End If




    End Sub
End Class
