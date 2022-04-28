Imports System.Net
Imports System.IO
Imports LiveCharts.Helpers
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CCOVID
    Implements ICOVID

    Dim request As HttpWebRequest
    Dim response As HttpWebResponse = Nothing
    Dim reader As StreamReader
    Dim jsonString As String
    Private AntudDate As String 'mis kuupaeval andmeid kuvada
    Private AntudMaakond As String 'mis maakonnast andmeid kuvada
    Private AntudEuroopaRiik As String
   
    Private TotalCasesValue As Integer 'anname tegeliku vaartuse
    Private DailyCasesValue As Integer
    Private TotalCasesLast14DValue As Integer
    Private PerPopulationValue As Integer
    Private NextDayValue As Integer
    Private LocationValueEurope As String
    Private LastUpdatedDateEurope As String
    Private TotalCasesValueEurope As Double
    Private NewCasesValueEurope As Double
    Private TotalCasesPerMillionValueEurope As Double


    Public Property TotalCases As Integer Implements ICOVID.TotalCases
        Get
            Return TotalCasesValue 'atribuudi kusimusel tagasta see
        End Get
        Set(value As Integer)
            TotalCasesValue = value 'atribuudi vaartuse seadistamine
        End Set
    End Property


    Public Property DailyCases As Integer Implements ICOVID.DailyCases
        Get
            Return DailyCasesValue
        End Get
        Set(value As Integer)
            DailyCasesValue = value
        End Set
    End Property

    Public Property TotalCasesLast14D As Integer Implements ICOVID.TotalCasesLast14D
        Get
            Return TotalCasesLast14DValue
        End Get
        Set(value As Integer)
            TotalCasesLast14DValue = value
        End Set
    End Property

    Public Property PerPopulation As Double Implements ICOVID.PerPopulation
        Get
            Return PerPopulationValue
        End Get
        Set(value As Double)
            PerPopulationValue = value

        End Set
    End Property

    Public Property NextDay As Integer Implements ICOVID.NextDay
        Get
            Return NextDayValue
        End Get
        Set(value As Integer)
            NextDayValue = value
        End Set
    End Property

    Public Property location As String Implements ICOVID.location
        Get
            Return LocationValueEurope
        End Get
        Set(value As String)
            LocationValueEurope = value
        End Set
    End Property

    Public Property last_updated_date As String Implements ICOVID.last_updated_date
        Get
            Return LastUpdatedDateEurope
        End Get
        Set(value As String)
            LastUpdatedDateEurope = value
        End Set
    End Property

    Public Property total_cases As Double Implements ICOVID.total_cases
        Get
            Return TotalCasesValueEurope
        End Get
        Set(value As Double)
            TotalCasesValueEurope = value
        End Set
    End Property

    Public Property new_cases As Double Implements ICOVID.new_cases
        Get
            Return NewCasesValueEurope
        End Get
        Set(value As Double)
            NewCasesValueEurope = value
        End Set
    End Property

    Public Property total_cases_per_million As Double Implements ICOVID.total_cases_per_million
        Get
            Return TotalCasesPerMillionValueEurope
        End Get
        Set(value As Double)
            TotalCasesPerMillionValueEurope = value
        End Set
    End Property

    Public Sub leiaArvS(ByRef strSisendDate As String, ByRef strSisendMaakond As String) Implements ICOVID.leiaArvS
        AntudDate = strSisendDate
        AntudMaakond = strSisendMaakond

        'kui soovitakse andmeid Eesti kohta
        If strSisendMaakond = "Eesti" Then
            request = DirectCast(WebRequest.Create("https://opendata.digilugu.ee/opendata_covid19_tests_total.json"), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            jsonString = reader.ReadToEnd()

            Dim objectList = JsonConvert.DeserializeObject(Of List(Of Data))(jsonString)
            Dim foundItem = objectList.Where(Function(__) __.StatisticsDate = AntudDate).FirstOrDefault()
            TotalCasesValue = foundItem.TotalCases
            DailyCasesValue = foundItem.DailyCases
            TotalCasesLast14DValue = foundItem.TotalCasesLast14D
            PerPopulationValue = foundItem.PerPopulation

            NextDayValue = foundItem.TotalCasesLast14D / 14

            'kui soovitakse andmeid mingi maakonda kohta
        ElseIf strSisendMaakond IsNot "Eesti" Then
            request = DirectCast(WebRequest.Create("https://opendata.digilugu.ee/opendata_covid19_test_county_all.json"), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim jsonString As String
            jsonString = reader.ReadToEnd()

            Dim objectList = JsonConvert.DeserializeObject(Of List(Of Data))(jsonString)
            Dim foundItem = objectList.Where(Function(__) __.StatisticsDate = AntudDate And __.County = AntudMaakond And __.ResultValue = "P").FirstOrDefault
            TotalCasesValue = foundItem.TotalCases
            DailyCasesValue = foundItem.DailyCases
            TotalCasesLast14DValue = vbNull
            PerPopulation = vbNull
        End If

    End Sub

    'kui soovitakse andmeid teise riiki kohta
    Public Sub leiaArvMaailm(ByRef strSisendRiik As String) Implements ICOVID.leiaArvMaailm
        AntudEuroopaRiik = strSisendRiik

        request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/latest/owid-covid-latest.json"), HttpWebRequest)
        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())
        Dim jsonStringWorld As String
        jsonStringWorld = reader.ReadToEnd()

        'massiiv riikide nimetustega
        Dim WorldCountry() As String = {"Latvia", "Lithuania", "Poland", "Norway", "Finland", "Sweden", "Austria", "Belgium", "Bulgaria", "Croatia", "
Cyprus", "Czechia", "Denmark", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Luxembourg", "Malta", "Netherlands", "Portugal", "Romania", "Slovakia", "Slovenia", "Spain", "Russia", "Greenland", "Mexico", "United States", "Egypt", "Cyprus", "Turkey", "China", "Japan", "India", "Ukraine", "Brazil", "Chile", "United Arab Emirates", "United Kingdom"}
       'samas järjekorras nagu riikide massiivis nende riikide abbreviatuurid
        Dim WorldCountryAbbrev() As String = {"LVA", "LTU", "POL", "NOR", "FIN", "SWE", "AUT", "BEL", "BGR", "HRV", "CYP", "CZE", "DNK", "FRA", "DEU", "GRC", "HUN", "IRL", "ITA", "LUX", "MLT", "NLD", "PRT", "ROU", "SVK", "SVN", "ESP", "RUS", "GRL", "MEX", "USA", "EGY", "CYP", "TUR", "CHN", "JPN", "IND", "UKR", "BRA", "CHL", "ARE", "GBR"}
        
        'valitakse riiki massiivist, leitakse tema abbreviaatuur, selle järgi leiame andmed
        For i As Integer = 0 To 41
            If WorldCountry(i) = AntudEuroopaRiik Then
                Dim objectList = JObject.Parse(jsonStringWorld)
                Dim foundItem = JsonConvert.DeserializeObject(Of Data.JSON_result)(objectList(WorldCountryAbbrev(i)).ToString)
                TotalCasesValueEurope = foundItem.total_cases
                LastUpdatedDateEurope = foundItem.last_updated_date
                new_cases = foundItem.new_cases
                TotalCasesPerMillionValueEurope = foundItem.total_cases_per_million
            End If
        Next

    End Sub
End Class
