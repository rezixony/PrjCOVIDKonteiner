Public Class formCOVIDInfo
    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        
        If Guna2TextBox1.Size.Height > 85
            MsgBox("Ei saa enam suuremaks teha!")
            Exit Sub
        End If

        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width + 5, Guna2TextBox1.Size.Height + 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width + 5, Guna2TextBox2.Size.Height + 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Size.Width + 5, Guna2TextBox3.Size.Height + 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width + 5, Guna2TextBox4.Size.Height + 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Size.Width + 5, Guna2TextBox5.Size.Height + 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Size.Width + 5, Guna2TextBox6.Size.Height + 5)
        Guna2TextBox7.Size = New Size(Guna2TextBox7.Size.Width + 5, Guna2TextBox7.Size.Height + 5)
        Guna2TextBox8.Size = New Size(Guna2TextBox8.Size.Width + 5, Guna2TextBox8.Size.Height + 5)
        Guna2TextBox9.Size = New Size(Guna2TextBox8.Size.Width + 5, Guna2TextBox9.Size.Height + 5)
        Guna2TextBox10.Size = New Size(Guna2TextBox10.Size.Width + 5, Guna2TextBox10.Size.Height + 5)
        Guna2TextBox11.Size = New Size(Guna2TextBox11.Size.Width + 5, Guna2TextBox11.Size.Height + 5)
        Guna2TextBox12.Size = New Size(Guna2TextBox12.Size.Width + 5, Guna2TextBox12.Size.Height + 5)
        Guna2TextBox13.Size = New Size(Guna2TextBox13.Size.Width + 5, Guna2TextBox13.Size.Height + 5)
        Guna2TextBox14.Size = New Size(Guna2TextBox14.Size.Width + 5, Guna2TextBox14.Size.Height + 5)
        Guna2TextBox15.Size = New Size(Guna2TextBox15.Size.Width + 5, Guna2TextBox15.Size.Height + 5)
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        If Guna2TextBox1.Size.Height < 60
            MsgBox("Ei saa enam väiksemaks teha!")
            Exit Sub
        End If
        Guna2TextBox1.Size = New Size(Guna2TextBox1.Size.Width - 5, Guna2TextBox1.Size.Height - 5)
        Guna2TextBox2.Size = New Size(Guna2TextBox2.Size.Width - 5, Guna2TextBox2.Size.Height - 5)
        Guna2TextBox3.Size = New Size(Guna2TextBox3.Size.Width - 5, Guna2TextBox3.Size.Height - 5)
        Guna2TextBox4.Size = New Size(Guna2TextBox4.Size.Width - 5, Guna2TextBox4.Size.Height - 5)
        Guna2TextBox5.Size = New Size(Guna2TextBox5.Size.Width - 5, Guna2TextBox5.Size.Height - 5)
        Guna2TextBox6.Size = New Size(Guna2TextBox6.Size.Width - 5, Guna2TextBox6.Size.Height - 5)
        Guna2TextBox7.Size = New Size(Guna2TextBox7.Size.Width - 5, Guna2TextBox7.Size.Height - 5)
        Guna2TextBox8.Size = New Size(Guna2TextBox8.Size.Width - 5, Guna2TextBox8.Size.Height - 5)
        Guna2TextBox9.Size = New Size(Guna2TextBox8.Size.Width - 5, Guna2TextBox9.Size.Height - 5)
        Guna2TextBox10.Size = New Size(Guna2TextBox10.Size.Width - 5, Guna2TextBox10.Size.Height - 5)
        Guna2TextBox11.Size = New Size(Guna2TextBox11.Size.Width - 5, Guna2TextBox11.Size.Height - 5)
        Guna2TextBox12.Size = New Size(Guna2TextBox12.Size.Width - 5, Guna2TextBox12.Size.Height - 5)
        Guna2TextBox13.Size = New Size(Guna2TextBox13.Size.Width - 5, Guna2TextBox13.Size.Height - 5)
        Guna2TextBox14.Size = New Size(Guna2TextBox14.Size.Width - 5, Guna2TextBox14.Size.Height - 5)
        Guna2TextBox15.Size = New Size(Guna2TextBox15.Size.Width - 5, Guna2TextBox15.Size.Height - 5)

    End Sub
End Class