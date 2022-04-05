Imports System.Windows.Forms.DataVisualization.Charting
Imports Bunifu.Charts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults

Public Class formKasutajaAken



    Private Sub formKasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMaakond.SelectedIndex = 0
        Nakatunud()
    End Sub

    Private Sub btnLeia_Click_1(sender As Object, e As EventArgs) Handles btnLeia.Click
        Dim time As Date = clndrKuupaev.Value  'Your date
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)
        Dim time2 = time.AddDays(-1)
        Dim kuupaev2 = time2.ToString(format)
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        '   Dim pooraja2 As PrjCOVID.ICOVID
        '   pooraja2 = New PrjCOVID.CCOVID
        '    pooraja2.leiaArvS(kuupaev2, cbMaakond.Text)
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

    Private Sub Nakatunud()
        Dim time As Date = clndrKuupaev.Value.AddDays(-1)  'Your date
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)
        Dim time2 = time.AddDays(-1)
        Dim kuupaev2 = time2.ToString(format)
        Dim time3 = time2.AddDays(-1)
        Dim kuupaev3 = time3.ToString(format)
        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        Dim pooraja2 As PrjCOVID.ICOVID
        pooraja2 = New PrjCOVID.CCOVID
        pooraja2.leiaArvS(kuupaev2, cbMaakond.Text)
        Dim pooraja3 As PrjCOVID.ICOVID
        pooraja3 = New PrjCOVID.CCOVID
        pooraja3.leiaArvS(kuupaev3, cbMaakond.Text)
        CartesianChart1.Series = New LiveCharts.SeriesCollection From {
            New LineSeries With {
                            .Title = "Nakatunud",
                                            .Values = New ChartValues(Of Integer) From {
                                                pooraja3.DailyCases,
                                                pooraja2.DailyCases,
                                                pooraja.DailyCases
                                                                }
                }
            }
        CartesianChart1.AxisX.Add(New Wpf.Axis With {
                                     .Title = "Day",
                                     .Labels = {kuupaev3, kuupaev2, kuupaev}
                                  })
        CartesianChart1.AxisY.Add(New Wpf.Axis With {
                                     .Title = "Arv",
                                     .LabelFormatter = Function(value) value.ToString
                                                                          })

    End Sub


End Class
