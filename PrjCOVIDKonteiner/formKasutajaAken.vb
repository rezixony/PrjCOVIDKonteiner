Public Class formKasutajaAken
    Private Sub btnLeia_Click(sender As Object, e As EventArgs) Handles btnLeia.Click
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS("2022-03-30")
        lblArv.Text = pooraja.DailyCases
    End Sub
End Class
