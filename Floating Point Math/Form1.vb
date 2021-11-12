Public Class Form1

    Private Sub btnFloatMath_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnFloatMath.Click
        'Delcare variable
        Dim dblNumber As Double

        'Set number, multiply numbers, and display results
        dblNumber = 45.34
        dblNumber *= 4.333
        MessageBox.Show("Multiplication test.. " & dblNumber.ToString, _
            "Floating Points")

        'Set number, divide numbers, and display results
        dblNumber = 12
        dblNumber /= 7

        'Display the results without formatting
        MessageBox.Show("Division test without formatting.. " & _
            dblNumber.ToString, "Floating Points")

        'Display the results with formatting
        MessageBox.Show("Division test with formatting.. " & _
            String.Format("{0:n3}", dblNumber), "Floating Points")
    End Sub
End Class
