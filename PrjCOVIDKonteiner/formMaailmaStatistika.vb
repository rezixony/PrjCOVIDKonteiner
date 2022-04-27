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

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click

        If Guna2TextBox1.Size.Height > 85
            MsgBox("Ei saa enam suuremaks teha!")
            Exit Sub
        End If


        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width + 5, Guna2TextBox1.Size.Height + 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width + 5, Guna2TextBox2.Size.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width + 5, Guna2TextBox4.Size.Height + 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Size.Width + 5, Guna2TextBox5.Size.Height + 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Size.Width + 5, Guna2TextBox6.Size.Height + 5)

        kjlkj.Size = New Size(kjlkj.Size.Width + 5, kjlkj.Size.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width + 5, Guna2TextBox4.Height + 5)
        cbEurope.Size = New Size(cbEurope.Size.Width + 5, cbEurope.Size.Height + 5)
        lblDailyCasesEurope.Size = New Size(lblDailyCasesEurope.Size.Width + 5, lblDailyCasesEurope.Size.Height + 5)
        lblLastUpdatedDate.Size = New Size(lblLastUpdatedDate.Size.Width + 5, lblLastUpdatedDate.Size.Height + 5)
        lblNakatunudEuroopa.Size = New Size(lblNakatunudEuroopa.Size.Width + 5, lblNakatunudEuroopa.Size.Height + 5)
        lblPerMillionEurope.Size = New Size(lblPerMillionEurope.Size.Width + 5, lblPerMillionEurope.Size.Height + 5)

        btnLeiaEurope.Size = New Size(btnLeiaEurope.Size.Width + 5, btnLeiaEurope.Size.Height + 5)
        
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        If Guna2TextBox1.Size.Height < 60
            MsgBox("Ei saa enam väiksemaks teha!")
            Exit Sub
        End If


        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width - 5, Guna2TextBox1.Size.Height - 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width - 5, Guna2TextBox2.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Size.Height - 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Size.Width - 5, Guna2TextBox5.Size.Height - 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Size.Width - 5, Guna2TextBox6.Size.Height - 5)

        kjlkj.Size = New Size(kjlkj.Size.Width - 5, kjlkj.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Height - 5)
        cbEurope.Size = New Size(cbEurope.Size.Width - 5, cbEurope.Size.Height - 5)
        lblDailyCasesEurope.Size = New Size(lblDailyCasesEurope.Size.Width - 5, lblDailyCasesEurope.Size.Height - 5)
        lblLastUpdatedDate.Size = New Size(lblLastUpdatedDate.Size.Width - 5, lblLastUpdatedDate.Size.Height - 5)
        lblNakatunudEuroopa.Size = New Size(lblNakatunudEuroopa.Size.Width - 5, lblNakatunudEuroopa.Size.Height - 5)
        lblPerMillionEurope.Size = New Size(lblPerMillionEurope.Size.Width - 5, lblPerMillionEurope.Size.Height - 5)

        btnLeiaEurope.Size = New Size(btnLeiaEurope.Size.Width - 5, btnLeiaEurope.Size.Height - 5)
    End Sub
End Class