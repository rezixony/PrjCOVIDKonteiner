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

        If txtPaevadeArv.Text = Nothing  Then
            MsgBox("Sisestage kuupäevade arv!")
            Exit Sub
        End If

        If IsNumeric(txtPaevadeArv.Text) = False  Then
            MsgBox("Sisestage kuupäevade arv!")
            Exit Sub
        End If

        If clndrKuupaev.Value >= Today Or clndrKuupaev.Value < ("04/04/2020")  Then
            MsgBox("Pole veel andmeid saadaval")
            lblDailyCases.Visible = False
            lblTotalCases.Visible = False
            lbl14p.Visible = False
            lblNextDay.Visible = False
            lblPerPopulation.Visible = False
            CartesianChart1.Visible = False
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

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        If Guna2TextBox1.Size.Height > 85
            MsgBox("Ei saa enam suuremaks teha!")
            Exit Sub
        End If


        txtPaevadeArv.Size = New Size(txtPaevadeArv.Size.Width + 5, txtPaevadeArv.Size.Height + 5)
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width + 5, Guna2TextBox1.Size.Height + 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width + 5, Guna2TextBox2.Height + 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Width + 5, Guna2TextBox3.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Width + 5, Guna2TextBox4.Height + 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Width + 5, Guna2TextBox5.Height + 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Width + 5, Guna2TextBox6.Height + 5)
        Guna2TextBox7.Size = New Size(Guna2TextBox7.Width + 5, Guna2TextBox7.Height + 5)

        kjlkj.Size = New Size(kjlkj.Size.Width + 5, kjlkj.Size.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width + 5, Guna2TextBox4.Height + 5)
        clndrKuupaev.Size = New Size(clndrKuupaev.Size.Width + 5, clndrKuupaev.Size.Height + 5)
        lblDailyCases.Size = New Size(lblDailyCases.Size.Width + 5, lblDailyCases.Size.Height + 5)
        lblTotalCases.Size = New Size(lblTotalCases.Size.Width + 5, lblTotalCases.Size.Height + 5)
        lbl14p.Size = New Size(lbl14p.Size.Width + 5, lbl14p.Size.Height + 5)
        lblPerPopulation.Size = New Size(lblPerPopulation.Size.Width + 5, lblPerPopulation.Size.Height + 5)
        lblNextDay.Size = New Size(lblNextDay.Size.Width + 5, lblNextDay.Size.Height + 5)

        btnLeiaEesti.Size = New Size(btnLeiaEesti.Size.Width + 5, btnLeiaEesti.Size.Height + 5)
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click

        If Guna2TextBox1.Size.Height < 60
            MsgBox("Ei saa enam väiksemaks teha!")
            Exit Sub
        End If


        txtPaevadeArv.Size = New Size(txtPaevadeArv.Size.Width - 5, txtPaevadeArv.Size.Height - 5)
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width - 5, Guna2TextBox1.Size.Height - 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width - 5, Guna2TextBox2.Height - 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Width - 5, Guna2TextBox3.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Width - 5, Guna2TextBox4.Height - 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Width - 5, Guna2TextBox5.Height - 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Width - 5, Guna2TextBox6.Height - 5)
        Guna2TextBox7.Size = New Size(Guna2TextBox7.Width - 5, Guna2TextBox7.Height - 5)

        kjlkj.Size = New Size(kjlkj.Size.Width - 5, kjlkj.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Height - 5)
        clndrKuupaev.Size = New Size(clndrKuupaev.Size.Width - 5, clndrKuupaev.Size.Height - 5)
        lblDailyCases.Size = New Size(lblDailyCases.Size.Width - 5, lblDailyCases.Size.Height - 5)
        lblTotalCases.Size = New Size(lblTotalCases.Size.Width - 5, lblTotalCases.Size.Height - 5)
        lbl14p.Size = New Size(lbl14p.Size.Width - 5, lbl14p.Size.Height - 5)
        lblPerPopulation.Size = New Size(lblPerPopulation.Size.Width - 5, lblPerPopulation.Size.Height - 5)
        lblNextDay.Size = New Size(lblNextDay.Size.Width - 5, lblNextDay.Size.Height - 5)

        btnLeiaEesti.Size = New Size(btnLeiaEesti.Size.Width - 5, btnLeiaEesti.Size.Height - 5)


    End Sub
End Class