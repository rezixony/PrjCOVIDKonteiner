
Public Class formKasutajaAken




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEestiStatistika_Click(sender As Object, e As EventArgs) Handles btnEestiStatistika.Click
        With formEestiStatistika
            .TopLevel = False
            Guna2Panel2.Controls.Add(formEestiStatistika)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMaakondadeStatistika_Click(sender As Object, e As EventArgs) Handles btnMaakondadeStatistika.Click
        With formMaakondadeStatistika
            .TopLevel = False
            Guna2Panel2.Controls.Add(formMaakondadeStatistika)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMaailmaStatistika_Click(sender As Object, e As EventArgs) Handles btnMaailmaStatistika.Click
        With formMaailmaStatistika
            .TopLevel = False
            Guna2Panel2.Controls.Add(formMaailmaStatistika)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCOVIDInfo_Click(sender As Object, e As EventArgs) Handles btnCOVIDInfo.Click
        With formCOVIDInfo
            .TopLevel = False
            Guna2Panel2.Controls.Add(formCOVIDInfo)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
