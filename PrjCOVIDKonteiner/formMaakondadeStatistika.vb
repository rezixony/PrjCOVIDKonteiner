Imports System.Windows.Forms.DataVisualization.Charting
Imports Bunifu.Charts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults
Imports LiveCharts.Helpers


Public Class formMaakondadeStatistika
    Private Sub formMaakondadeStatistika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'esialgu vormi käivitamisel pole näha graafikut ja nakatanute arvu, kuna kuupäev pole veel valitud
        cbMaakond.SelectedIndex = 1
        lblDailyCasesMaakond.Visible = False
        _lblTotalCasesMaakond.Visible = False
        CartesianChartMaakond.Visible = False
    End Sub



    Private Sub btnLeiaMaakond_Click(sender As Object, e As EventArgs) Handles btnLeiaMaakond.Click
        'tühjendame graafikut uue päringu esitamisel
        CartesianChartMaakond.AxisX.Clear()
        CartesianChartMaakond.AxisY.Clear()
        CartesianChartMaakond.Visible = False

        If txtPaevadeArv.Text = Nothing Or IsNumeric(txtPaevadeArv.Text) = False  Then
            MsgBox("Sisestage kuupäevade arv!")
            Exit Sub
        End If

        Dim arvutus As Date
        arvutus = clndrKuupaev.Value.AddDays(CInt(txtPaevadeArv.Text))
        'kui valitakse tänase või tuleviku kuupäeva, mille jaoks andmeid veel pole või soovitatakse kuvada andmeid perioodil, millal seda statistikat polnud veel 
        'statistika esimene päev on 26. veebruar 2020
        If clndrKuupaev.Value >= Today Or arvutus < ("27/02/2020")  Then
            MsgBox("Pole veel andmeid saadaval")
            lblDailyCasesMaakond.Visible = False
            lblTotalCasesMaakond.Visible = False
            Exit Sub
        End If



        Dim time As Date = clndrKuupaev.Value
        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)

        Dim pooraja As PrjCOVID.ICOVID
        pooraja = New PrjCOVID.CCOVID
        pooraja.leiaArvS(kuupaev, cbMaakond.Text)
        'esimese päringu tulemuse(just selle päeva) saadame tekstina välja

        lblDailyCasesMaakond.Text = pooraja.DailyCases
        lblTotalCasesMaakond.Text = pooraja.TotalCases

        'kui õige kuupäev ja andmed on käes, võib kuvada statistikat ja graafikut
        CartesianChartMaakond.Visible = True
        lblDailyCasesMaakond.Visible = True
        lblTotalCasesMaakond.Visible = True

        'kasutaja sisestab, mitme paeva jaoks soovib graafikut kuvada
        Dim arv = CInt(txtPaevadeArv.Text)
        Dim times(arv) As String
        Dim j As Integer
        'massiiv kuupäevadega
        For j = 0 To arv
            times(j) = time.AddDays(-j).ToString(format)
        Next j

        Dim k As Integer
        Dim saadud(arv) As Integer
        'massiiv nakatanute arvuga
        For k = 0 To arv
            pooraja.leiaArvS(times(k), cbMaakond.Text)
            saadud(k) = pooraja.DailyCases
        Next k

        'pöörame ümber, et graafikule saata õiges järjekorras
        Dim saadudGraafikule = saadud.Reverse()
        Dim timesGraafikule = times.Reverse()

        'graafiku moodustamine
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

    'kui vajutatakse nuppu teksti suurendamiseks
    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        'kui tekstiväljade suurus on liiga suur, enam suuremaks teha ei saa
        If Guna2TextBox1.Size.Height > 85
            MsgBox("Ei saa enam suuremaks teha!")
            Exit Sub
        End If

        'suurendame iga tekstivälja dimensioonid
        lblDailyCasesMaakond.Size = New Size(lblDailyCasesMaakond.Size.Width + 5, lblDailyCasesMaakond.Size.Height + 5)
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width + 5, Guna2TextBox1.Size.Height + 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width + 5, Guna2TextBox2.Height + 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Width + 5, Guna2TextBox3.Height + 5)
        kjlkj.Size = New Size(kjlkj.Size.Width + 5, kjlkj.Size.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width + 5, Guna2TextBox4.Height + 5)
        lblTotalCasesMaakond.Size = New Size(lblTotalCasesMaakond.Size.Width + 5, lblDailyCasesMaakond.Size.Height + 5)
        btnLeiaMaakond.Size = New Size(btnLeiaMaakond.Size.Width + 5, btnLeiaMaakond.Size.Height + 5)
        cbMaakond.Size = New Size(cbMaakond.Size.Width + 5, cbMaakond.Size.Height + 5)

    End Sub

    'kui vajutatakse nuppu teksti väiksemaks tegemiseks
    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        'kui tekstiväljade suurus on liiga väike, enam väiksemaks teha ei saa
        If Guna2TextBox1.Size.Height < 60
            MsgBox("Ei saa enam väiksemaks teha!")
            Exit Sub
        End If

        'vähendame iga tekstivälja dimensioonid
        lblDailyCasesMaakond.Size = New Size(lblDailyCasesMaakond.Size.Width - 5, lblDailyCasesMaakond.Size.Height - 5)
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width - 5, Guna2TextBox1.Size.Height - 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width - 5, Guna2TextBox2.Height - 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Width - 5, Guna2TextBox3.Height - 5)
        kjlkj.Size = New Size(kjlkj.Size.Width - 5, kjlkj.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Height - 5)
        lblTotalCasesMaakond.Size = New Size(lblTotalCasesMaakond.Size.Width - 5, lblDailyCasesMaakond.Size.Height - 5)
        btnLeiaMaakond.Size = New Size(btnLeiaMaakond.Size.Width - 5, btnLeiaMaakond.Size.Height - 5)
        cbMaakond.Size = New Size(cbMaakond.Size.Width - 5, cbMaakond.Size.Height - 5)


    End Sub
End Class