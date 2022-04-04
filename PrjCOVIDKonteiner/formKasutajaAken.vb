Public Class formKasutajaAken
    Private Sub btnLeia_Click(sender As Object, e As EventArgs) Handles btnLeia.Click
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(txtKuupaev.Text, cbMaakond.Text)
        lblSeePaev.Text = pooraja.DailyCases
        lblTotalCases.Text = pooraja.TotalCases
        lbl14p.Text = pooraja.TotalCasesLast14D
        lblPerPopulation.Text = pooraja.PerPopulation
        lblNextDay.Text = pooraja.NextDay
        If pooraja.PerPopulation = vbNull And pooraja.TotalCasesLast14D = vbNull Then
            lblPerPopulation.Visible = False
            lbl14p.Visible = False
        End If
    End Sub
End Class
