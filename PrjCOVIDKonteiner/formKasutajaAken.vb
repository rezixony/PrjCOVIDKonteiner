Public Class formKasutajaAken
    Private Sub btnLeia_Click(sender As Object, e As EventArgs) Handles btnLeia.Click
        Dim time As Date = txtKuupaev.Text  'Your date
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)
        Dim time2 = time.AddDays(-1)
        Dim kuupaev2 = time2.ToString(format)
        lblEelmine.Text = kuupaev2
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        Dim pooraja2 As PrjCOVID.ICOVID
        pooraja2 = New PrjCOVID.CCOVID
        pooraja2.leiaArvS(kuupaev2, cbMaakond.Text)
        lblSeePaev.Text = pooraja.DailyCases
        lblTotalCases.Text = pooraja.TotalCases
        lbl14p.Text = pooraja.TotalCasesLast14D
        lblPerPopulation.Text = pooraja.PerPopulation
        lblNextDay.Text = pooraja.NextDay
        If pooraja.PerPopulation = vbNull And pooraja.TotalCasesLast14D = vbNull Then
            lblPerPopulation.Visible = False
            lbl14p.Visible = False
        End If

        Me.chrtNakatunud.Series("Nakatunud").Points.AddXY(kuupaev, pooraja.DailyCases)
        Me.chrtNakatunud.Series("Nakatunud").Points.AddXY(kuupaev2, pooraja2.DailyCases)
    End Sub
End Class
