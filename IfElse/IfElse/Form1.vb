Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        If num1 > num2 Then
            largerNum = (num1)

        ElseIf num2 > num1 Then
            largerNum = (num2)

        Else : txtResult.Text = "Both Nmbers are equal"
        End If

        txtResult.Text = "The Larger number is " & CStr(largerNum)

    End Sub

End Class
