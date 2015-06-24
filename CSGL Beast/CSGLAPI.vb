Imports Newtonsoft.Json
Public Class CSGLAPI
    Const urlItemList As String = "http://csgolounge.com/api/schema.php"
    Const urlMatchList As String = "http://csgolounge.com/api/matches.php"
    Public filepathMatches As String = Application.StartupPath & "\data\matches.csg"

    Public Function JSONToDataTable(ByVal url As String, ByVal local As Boolean) As DataTable
        Dim method As String = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim web As System.Net.WebClient = New System.Net.WebClient()
        If local = False Then
            Dim src As String = web.DownloadString(url).ToString
            Dim dtValue As DataTable = DirectCast(JsonConvert.DeserializeObject(src.Trim, (GetType(DataTable))), DataTable)
            If dtValue.Rows.Count <> 0 Then LogMe("DT Contains Data. Returning dtValue as DataTable.")
            Return dtValue

        ElseIf local = True Then
            LogMe("Loading from text file...")
            Dim src As String = System.IO.File.ReadAllText(filepathMatches)
            LogMe("Loaded...")
            Dim dtValue As DataTable = DirectCast(JsonConvert.DeserializeObject(src, (GetType(DataTable))), DataTable)
            LogMe("Returning dtValue as DataTable.")
            Return dtValue
        Else
            LogMe("Something failed while casting JSON to DataTable... Returning NOTHING.")
            Return Nothing
        End If

    End Function

End Class
