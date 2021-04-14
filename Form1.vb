Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNamaHari(6) As String
        Dim y As Integer
        'week 6 array

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"
        y = 0

        Array.Reverse(strNamaHari)
        For y = 0 To 6
            lstResult.Items.Add(strNamaHari(y))
        Next
    End Sub

    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        Form2.Show()
    End Sub
End Class
