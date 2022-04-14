﻿Imports System.Windows.Forms.DataVisualization.Charting
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


        If clndrKuupaev.Value = Today Then
            MsgBox("Pole veel andmeid saadaval")

        End If

        Dim time As Date = clndrKuupaev.Value

        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)


        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, "Eesti")
        'esimese päringu tulemuse(just selle päeva) saadame tekstina välja
        lblDailyCases.Text = pooraja.DailyCases
        lblTotalCases.Text = pooraja.TotalCases
        lbl14p.Text = pooraja.TotalCasesLast14D
        lblPerPopulation.Text = pooraja.PerPopulation
        lblNextDay.Text = pooraja.NextDay

        'ülejäänud päringu tulemused saadame vaid graafikule
        Dim time2 = time.AddDays(-1).ToString(format)
        Dim pooraja2 As PrjCOVID.ICOVID
        pooraja2 = New PrjCOVID.CCOVID
        pooraja2.leiaArvS(time2, "Eesti")

        Dim time3 = time.AddDays(-2).ToString(format)
        Dim pooraja3 As PrjCOVID.ICOVID
        pooraja3 = New PrjCOVID.CCOVID
        pooraja3.leiaArvS(time3, "Eesti")

        Dim time4 = time.AddDays(-3).ToString(format)
        Dim pooraja4 As PrjCOVID.ICOVID
        pooraja4 = New PrjCOVID.CCOVID
        pooraja4.leiaArvS(time4, "Eesti")

        Dim time5 = time.AddDays(-4).ToString(format)
        Dim pooraja5 As PrjCOVID.ICOVID
        pooraja5 = New PrjCOVID.CCOVID
        pooraja5.leiaArvS(time5, "Eesti")

        Dim time6 = time.AddDays(-5).ToString(format)
        Dim pooraja6 As PrjCOVID.ICOVID
        pooraja6 = New PrjCOVID.CCOVID
        pooraja6.leiaArvS(time6, "Eesti")

        CartesianChart1.Series = New LiveCharts.SeriesCollection From {
            New LineSeries With {
                .Title = "Nakatunud",
                .Values = New ChartValues(Of Integer) From {
                    pooraja6.DailyCases,
                    pooraja5.DailyCases,
                    pooraja4.DailyCases,
                    pooraja3.DailyCases,
                    pooraja2.DailyCases,
                    pooraja.DailyCases
                    }
                }
            }
        CartesianChart1.AxisX.Add(New Wpf.Axis With {
                                     .Title = "Kuupäev",
                                     .Labels = {time6, time5, time4, time3, time2, kuupaev}
                                     })
        CartesianChart1.AxisY.Add(New Wpf.Axis With {
                                     .Title = "Nakatunute arv",
                                     .LabelFormatter = Function(value) value.ToString
                                     })
    End Sub

End Class