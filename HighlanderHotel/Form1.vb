Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubTotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        Try
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            decSubTotal = decRoomCharges + decAddCharges
            lblSubTotal.Text = decSubTotal.ToString("c")

            'calculate and display the tax
            decTax = decSubTotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            decTotal = decSubTotal + decTax
            lblTotal.ForeColor = Color.Red
            lblTotal.Text = decTotal.ToString("c")


        Catch ex As Exception
            MessageBox.Show("All inputs must be numeric values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNightlyCharge.Clear()
        txtNights.Clear()

        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        lblAddCharges.Text = String.Empty
        lblRoomCharges.Text = String.Empty
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")

        txtNights.Focus()
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
