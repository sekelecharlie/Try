Public Class Form1
    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        Dim isNumber As String
        isNumber = txtImput.Text

        Try

            Dim numericValue As Double
            numericValue = CObj(isNumber)
            MsgBox("That is a Valid Number You have entered " & numericValue)


        Catch

            MsgBox("Incorrect: " & isNumber & "  is not a number!!!")

        End Try
    End Sub
End Class
