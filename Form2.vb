Public Class Form2
    Private Sub btnPapar_Click(sender As Object, e As EventArgs) Handles btnPapar.Click
        Dim strKelas(5, 3) As String
        Dim strResult As String
        Dim x As Integer
        Dim y As Integer

        strKelas(0, 0) = "DDT1A"
        strKelas(0, 1) = "DDT1B"
        strKelas(1, 0) = "DDT2A"
        strKelas(1, 1) = "DDT2B"
        strKelas(1, 2) = "DDT2C"
        strKelas(1, 3) = "DDT2D"
        strKelas(2, 0) = "DDT3A"
        strKelas(2, 1) = "DDT3B"
        strKelas(2, 2) = "DDT3C"
        strKelas(2, 3) = "DDT3D"
        strKelas(3, 0) = "DDT4A"
        strKelas(3, 1) = "DDT4B"
        strKelas(3, 2) = "DDT4C"
        strKelas(3, 3) = "DDT4D"
        strKelas(4, 0) = "DDT5A"
        strKelas(4, 1) = "DDT5B"
        strKelas(5, 0) = "DDT6A"
        strKelas(5, 1) = "DDT6B"


        For x = 0 To 5
            For y = 0 To 3
                strResult &= strKelas(x, y) & vbCrLf
            Next
            lblResult.Text = strResult
        Next

    End Sub
End Class