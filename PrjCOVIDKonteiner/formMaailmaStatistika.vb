Public Class formMaailmaStatistika
    Private Sub btnLeiaEurope_Click(sender As Object, e As EventArgs) Handles btnLeiaEurope.Click

        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID

        pooraja.leiaArvEurope(cbEurope.SelectedItem)

        lblDailyCasesEurope.Text = pooraja.total_cases
        lblLastUpdatedDate.Text = pooraja.last_updated_date
        lblNakatunudEuroopa.Text = pooraja.new_cases
        lblPerMillionEurope.Text = pooraja.total_cases_per_million
    End Sub

End Class