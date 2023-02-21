Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCost.Text = ""
        txtNumberOfNights.Clear()
        txtNumberOfNights.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotalCost.Text = ""
        txtNumberOfNights.Clear()
        txtNumberOfNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Const _cdecCostPerNight As Decimal = 79D
        Dim strNumNights As String = txtNumberOfNights.Text
        Dim intNumNights As Integer = Convert.ToInt32(strNumNights)
        Dim decTotalCost As Decimal = _cdecCostPerNight * intNumNights
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub
End Class
