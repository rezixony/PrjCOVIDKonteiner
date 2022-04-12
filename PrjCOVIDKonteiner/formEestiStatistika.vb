Imports System.Windows.Forms.DataVisualization.Charting
Imports Bunifu.Charts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults


Public Class formEestiStatistika
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Guna2Panel1.Left = (Me.Width - Guna2Panel1.Width)
    End Sub

    Private Sub clndrKuupaev_ValueChanged(sender As Object, e As EventArgs) Handles clndrKuupaev.ValueChanged
        CartesianChart1.AxisX.Clear()
        CartesianChart1.AxisY.Clear()
        Dim time As Date = clndrKuupaev.Value.AddDays(-1)  'Your date
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)
        Dim time2 = time.AddDays(-1)
        Dim kuupaev2 = time2.ToString(format)
        Dim time3 = time2.AddDays(-1)
        Dim kuupaev3 = time3.ToString(format)

        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, "Eesti")

        lblSeePaev.Text = pooraja.DailyCases
        lblTotalCases.Text = pooraja.TotalCases
        lbl14p.Text = pooraja.TotalCasesLast14D
        lblPerPopulation.Text = pooraja.PerPopulation
        lblNextDay.Text = pooraja.NextDay

        Dim pooraja2 As PrjCOVID.ICOVID
        pooraja2 = New PrjCOVID.CCOVID
        pooraja2.leiaArvS(kuupaev2, "Eesti")
        Dim pooraja3 As PrjCOVID.ICOVID
        pooraja3 = New PrjCOVID.CCOVID
        pooraja3.leiaArvS(kuupaev3, "Eesti")
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