Public Class formMaakondadeStatistika
    Private Sub formMaakondadeStatistika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMaakond.SelectedIndex = 1
    End Sub

    'kui vahetatakse kuupäeva
    Private Sub clndrKuupaev_ValueChanged(sender As Object, e As EventArgs) Handles clndrKuupaev.ValueChanged
        Dim time As Date = clndrKuupaev.Value.AddDays(-1)  'eelmine paev
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        lblSeePaevMaakond.Text = pooraja.DailyCases
        lblTotalCasesMaakond.Text = pooraja.TotalCases
    End Sub

    'kui vahetatakse maakonda
    Private Sub btnLeiaMaakond_Click(sender As Object, e As EventArgs) Handles btnLeiaMaakond.Click
        Dim time As Date = clndrKuupaev.Value.AddDays(-1)  'eelmine paev
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        lblSeePaevMaakond.Text = pooraja.DailyCases
        lblTotalCasesMaakond.Text = pooraja.TotalCases
    End Sub
End Class