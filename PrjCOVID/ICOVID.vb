Public Interface ICOVID

    Property TotalCases As Integer
    Property DailyCases As Integer
    Property TotalCasesLast14D As Integer
    Property PerPopulation As Double
    Property NextDay As Integer

    Sub leiaArvS(ByRef strSisendDate As String, ByRef strSisendMaakond As String)
    Sub leiaArvEurope(ByRef strSisendRiik As String)

    Property location As String
    Property last_updated_date As String
    Property total_cases As Double
    Property new_cases As Double
    Property total_cases_per_million As Double

End Interface
