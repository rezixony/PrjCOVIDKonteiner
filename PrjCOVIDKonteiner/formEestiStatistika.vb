Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Interop
Imports Bunifu.Charts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults
Imports LiveCharts.Helpers


Public Class formEestiStatistika
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'esialgu vormi käivitamisel pole näha graafikut ja nakatanute arvu, kuna kuupäev pole veel valitud
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
    
    'väärtuste seadistamine, graafiku kuvamine
    Private Sub btnLeiaEesti_Click(sender As Object, e As EventArgs) Handles btnLeiaEesti.Click
        'tühjendame graafikut uue päringu esitamisel
        CartesianChart1.AxisX.Clear()
        CartesianChart1.AxisY.Clear()

        'kui kuupäevade arv pole määratud, visatakse funktsioonist välja
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
            lblDailyCases.Visible = False
            lblTotalCases.Visible = False
            lbl14p.Visible = False
            lblNextDay.Visible = False
            lblPerPopulation.Visible = False
            CartesianChart1.Visible = False
            Exit Sub
        End If

        Dim time As Date = clndrKuupaev.Value
        'kui õige kuupäev on käes, võib kuvada statistikat ja graafikut
        CartesianChart1.Visible = True
        lblDailyCases.Visible = True
        lblTotalCases.Visible = True
        lbl14p.Visible = True
        lblNextDay.Visible = True
        lblPerPopulation.Visible = True

        Dim format As String = "yyyy-MM-dd"
        Dim kuupaev = time.ToString(format)

        'esitame päringu andmete kättesaamiseks Eesti kohta
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
        'massiiv kuupäevadega
        For j = 0 To arv
            times(j) = time.AddDays(-j).ToString(format)
        Next j

        Dim k As Integer
        Dim saadud(arv) As Integer
        'massiiv nakatanute arvuga
        For k = 0 To arv
            pooraja.leiaArvS(times(k), "Eesti")
            saadud(k) = pooraja.DailyCases
        Next k

        'pöörame ümber, et graafikule saata õiges järjekorras
        Dim saadudGraafikule = saadud.Reverse()
        Dim timesGraafikule = times.Reverse()

        'graafiku moodustamine
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
    'kui vajutatakse nuppu teksti suurendamiseks
    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        'kui tekstiväljade suurus on liiga suur, enam suuremaks teha ei saa
        If Guna2TextBox1.Size.Height > 85
            MsgBox("Ei saa enam suuremaks teha!")
            Exit Sub
        End If

        'suurendame iga tekstivälja dimensioonid
        txtPaevadeArv.Size = New Size(txtPaevadeArv.Size.Width + 5, txtPaevadeArv.Size.Height + 5)
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width + 5, Guna2TextBox1.Size.Height + 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width + 5, Guna2TextBox2.Height + 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Size.Width + 5, Guna2TextBox3.Size.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width + 5, Guna2TextBox4.Size.Height + 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Size.Width + 5, Guna2TextBox5.Size.Height + 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Size.Width + 5, Guna2TextBox6.Size.Height + 5)
        Guna2TextBox7.Size = New Size(Guna2TextBox7.Size.Width + 5, Guna2TextBox7.Size.Height + 5)

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

    'kui vajutatakse nuppu teksti väiksemaks tegemiseks
    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        'kui tekstiväljade suurus on liiga väike, enam väiksemaks teha ei saa
        If Guna2TextBox1.Size.Height < 60
            MsgBox("Ei saa enam väiksemaks teha!")
            Exit Sub
        End If

        'vähendame iga tekstivälja dimensioonid
        txtPaevadeArv.Size = New Size(txtPaevadeArv.Size.Width - 5, txtPaevadeArv.Size.Height - 5)
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width - 5, Guna2TextBox1.Size.Height - 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width - 5, Guna2TextBox2.Size.Height - 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Size.Width - 5, Guna2TextBox3.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Size.Height - 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Size.Width - 5, Guna2TextBox5.Size.Height - 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Size.Width - 5, Guna2TextBox6.Size.Height - 5)
        Guna2TextBox7.Size = New Size(Guna2TextBox7.Size.Width - 5, Guna2TextBox7.Size.Height - 5)

        kjlkj.Size = New Size(kjlkj.Size.Width - 5, kjlkj.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Size.Height - 5)
        clndrKuupaev.Size = New Size(clndrKuupaev.Size.Width - 5, clndrKuupaev.Size.Height - 5)
        lblDailyCases.Size = New Size(lblDailyCases.Size.Width - 5, lblDailyCases.Size.Height - 5)
        lblTotalCases.Size = New Size(lblTotalCases.Size.Width - 5, lblTotalCases.Size.Height - 5)
        lbl14p.Size = New Size(lbl14p.Size.Width - 5, lbl14p.Size.Height - 5)
        lblPerPopulation.Size = New Size(lblPerPopulation.Size.Width - 5, lblPerPopulation.Size.Height - 5)
        lblNextDay.Size = New Size(lblNextDay.Size.Width - 5, lblNextDay.Size.Height - 5)

        btnLeiaEesti.Size = New Size(btnLeiaEesti.Size.Width - 5, btnLeiaEesti.Size.Height - 5)


    End Sub
End Class