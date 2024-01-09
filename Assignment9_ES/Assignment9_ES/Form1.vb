Public Class frmSalesPrice


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Declare Variables
        Dim dblOriginalPrice As Double
        Dim dblPercentOff As Double
        Dim dblSalesPrice As Double


        ' Get and Validate Inputs
        ' Original Price & Percent Off must Exist, The Data Type must be numeric, and The Range must be greater than 0


        If txtOriginalPrice.Text = String.Empty Then
            MessageBox.Show("Original Price Must be Entered")
            txtOriginalPrice.Focus()
            Exit Sub
        End If

        If txtPercentOff.Text = "" Then
            MessageBox.Show("Percent Off Must be Entered")
            txtPercentOff.Focus()
            Exit Sub
        End If

        If IsNumeric(txtOriginalPrice.Text) Then
            dblOriginalPrice = txtOriginalPrice.Text
        Else
            MessageBox.Show("Original Price Must be Numeric")
            txtOriginalPrice.Focus()
            Exit Sub
        End If

        If (dblOriginalPrice > 0) Then
            dblOriginalPrice = txtOriginalPrice.Text
        Else
            MessageBox.Show("Original Price Must be Greater than 0")
            Exit Sub
        End If

        If IsNumeric(txtPercentOff.Text) Then
            dblPercentOff = txtPercentOff.Text
        Else
            MessageBox.Show("Percent Off Must be Numeric")
            Exit Sub
        End If

        If (dblPercentOff > 0) Then
            dblPercentOff = txtPercentOff.Text
        Else
            MessageBox.Show("Percent Off Must be Greater than 0")
            Exit Sub
        End If

        ' Do Calculations
        dblSalesPrice = dblOriginalPrice - ((dblOriginalPrice / 100) * dblPercentOff)


        ' Display Results
        lblSalesPrice.Text = FormatCurrency(dblSalesPrice)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOriginalPrice.Clear()
        txtPercentOff.Clear()
        txtOriginalPrice.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
