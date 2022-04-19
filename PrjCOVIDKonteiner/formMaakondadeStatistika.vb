Imports System.Windows.Forms.DataVisualization.Charting
Imports Bunifu.Charts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults
Imports LiveCharts.Helpers


Public Class formMaakondadeStatistika
    Private Sub formMaakondadeStatistika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMaakond.SelectedIndex = 1
        lblDailyCasesMaakond.Visible = False
        _lblTotalCasesMaakond.Visible = False
        CartesianChartMaakond.Visible = False
    End Sub



    Private Sub btnLeiaMaakond_Click(sender As Object, e As EventArgs) Handles btnLeiaMaakond.Click

        CartesianChartMaakond.AxisX.Clear()
        CartesianChartMaakond.AxisY.Clear()
        CartesianChartMaakond.Visible = False

        If txtPaevadeArv.Text = Nothing Then
            MsgBox("Sisestage kuupäevade arv!")
            Exit Sub
        End If

        If clndrKuupaev.Value >= Today Then
            MsgBox("Pole veel andmeid saadaval")
            lblDailyCasesMaakond.Visible = False
            lblTotalCasesMaakond.Visible = False
            Exit Sub
        End If

        CartesianChartMaakond.Visible = True

        Dim time As Date = clndrKuupaev.Value
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)

        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        'esimese päringu tulemuse(just selle päeva) saadame tekstina välja
        lblDailyCasesMaakond.Visible = True
        lblTotalCasesMaakond.Visible = True
        lblDailyCasesMaakond.Text = pooraja.DailyCases
        lblTotalCasesMaakond.Text = pooraja.TotalCases

        'kasutaja sisestab, mitme paeva jaoks soovib graafikut kuvada
        Dim arv = CInt(txtPaevadeArv.Text)
        Dim times(arv) As String
        Dim j As Integer
        For j = 0 To arv
            times(j) = time.AddDays(-j).ToString(format)
        Next j

        Dim k As Integer
        Dim saadud(arv) As Integer
        For k = 0 To arv
            pooraja.leiaArvS(times(k), cbMaakond.Text)
            saadud(k) = pooraja.DailyCases
        Next k

        Dim saadudGraafikule = saadud.Reverse()
        Dim timesGraafikule = times.Reverse()


        CartesianChartMaakond.Series = New LiveCharts.SeriesCollection From {
            New LineSeries With {
                .Title = "Nakatunud",
                .Values = saadudGraafikule.AsChartValues()
                }
            }
        CartesianChartMaakond.AxisX.Add(New Wpf.Axis With {
                                     .Title = "Kuupäev",
                                     .Labels = timesGraafikule.AsChartValues()
                                     })
        CartesianChartMaakond.AxisY.Add(New Wpf.Axis With {
                                     .Title = "Nakatunute arv",
                                     .LabelFormatter = Function(value) value.ToString
                                     })
    End Sub
End Class