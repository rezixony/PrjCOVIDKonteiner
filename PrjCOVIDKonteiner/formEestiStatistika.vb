Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Interop
Imports Bunifu.Charts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults
Imports LiveCharts.Helpers


Public Class formEestiStatistika
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CartesianChart1.Visible = False
        lblDailyCases.Visible = False
        lblTotalCases.Visible = False
        lbl14p.Visible = False
        lblNextDay.Visible = False
        lblPerPopulation.Visible = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Guna2Panel1.Left = (Me.Width - Guna2Panel1.Width)
    End Sub

    Private Sub btnLeiaEesti_Click(sender As Object, e As EventArgs) Handles btnLeiaEesti.Click
        CartesianChart1.AxisX.Clear()
        CartesianChart1.AxisY.Clear()

        If txtPaevadeArv.Text = Nothing Then
            MsgBox("Sisestage kuupäevade arv!")
            Exit Sub
        End If

        If clndrKuupaev.Value >= Today Then
            MsgBox("Pole veel andmeid saadaval")
            lblDailyCases.Visible = False
            lblTotalCases.Visible = False
            lbl14p.Visible = False
            lblNextDay.Visible = False
            lblPerPopulation.Visible = False
            Exit Sub
        End If

        Dim time As Date = clndrKuupaev.Value

        CartesianChart1.Visible = True
        lblDailyCases.Visible = True
        lblTotalCases.Visible = True
        lbl14p.Visible = True
        lblNextDay.Visible = True
        lblPerPopulation.Visible = True

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

        Dim arv = CInt(txtPaevadeArv.Text)
        Dim times(arv) As String
        Dim j As Integer
        For j = 0 To arv
            times(j) = time.AddDays(-j).ToString(format)
        Next j

        Dim k As Integer
        Dim saadud(arv) As Integer
        For k = 0 To arv
            pooraja.leiaArvS(times(k), "Eesti")
            saadud(k) = pooraja.DailyCases
        Next k

        Dim saadudGraafikule = saadud.Reverse()
        Dim timesGraafikule = times.Reverse()

        CartesianChart1.Series = New LiveCharts.SeriesCollection From {
            New LineSeries With {
                .Title = "Nakatunud",
                .Values = saadudGraafikule.AsChartValues()
                }
            }
        CartesianChart1.AxisX.Add(New Wpf.Axis With {
                                     .Title = "Kuupäev",
                                     .Labels = timesGraafikule.AsChartValues()
                                     })
        CartesianChart1.AxisY.Add(New Wpf.Axis With {
                                     .Title = "Nakatunute arv",
                                     .LabelFormatter = Function(value) value.ToString
                                     })
    End Sub
End Class