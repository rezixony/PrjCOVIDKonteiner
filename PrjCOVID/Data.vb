Public Class Data

    Property TotalCases As Integer
    Property LastStatisticsDate As String
    Property DailyCases As Integer
    Property TotalCasesLast14D As Integer
    Property PerPopulation As Double
    '------------------------------------------------------[ Maakond ]------------------------------------------------------
    Property StatisticsDate As String
    Property Country As String
    Property County As String
    Property ResultValue As String

    Public Class JSON_result
        Public Property location As String
        Public Property continent As String
        Public Property last_updated_date As String
        Public Property total_cases As Double
        Public Property new_cases As Double
        Public Property total_cases_per_million As Double

    End Class

End Class
