Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization
Imports System.Text.RegularExpressions

Public Class CSGLAPI
    Public Shared CSGOAppID As String = "730"
    Public Shared filepathMatches As String = Application.StartupPath & "\data\matches.csg"
    Public Shared SteamProfileID As String = My.Settings.SteamProfileID
    Public Shared urlItemList As String = "http://csgolounge.com/api/schema.php"
    Public Shared urlMatchList As String = "http://csgolounge.com/api/matches.php"
    Public Shared urlSteamInventory As String = String.Format("http://steamcommunity.com/profiles/{0}/inventory/json/{1}/2", SteamProfileID, CSGOAppID)

    ''' <summary>
    ''' JSON to data table.
    ''' </summary>
    ''' <param name="url">The URL of the API.</param>
    ''' <param name="local">Is the data local?</param>
    ''' <returns></returns>
    Public Shared Function JSONToDataTable(ByVal url As String, ByVal local As Boolean) As DataTable
        Try
            Dim web As System.Net.WebClient = New System.Net.WebClient()
            If Not local Then 'If local is NOT selected
                Dim src As String = web.DownloadString(url).ToString
                Dim dtValue As DataTable = DirectCast(JsonConvert.DeserializeObject(src.Trim, (GetType(DataTable))), DataTable)
                If dtValue.Rows.Count <> 0 Then LogMe("DT Contains Data. Returning dtValue as DataTable.")
                Return dtValue
            ElseIf local Then 'If local is selected
                LogMe("Loading from text file...")
                Dim src As String = System.IO.File.ReadAllText(filepathMatches)
                LogMe("Loaded...")
                Dim dtValue As DataTable = DirectCast(JsonConvert.DeserializeObject(src, (GetType(DataTable))), DataTable)
                LogMe("Returning dtValue as DataTable.")
                Return dtValue
            Else 'If something happened
                LogMe("Something failed while casting JSON to DataTable... Returning NOTHING.")
                Return Nothing
            End If
        Catch ex As System.Net.WebException
            LogMe(ex.Message)
            Return Nothing
        Catch ex As Exception
            LogMe(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GetWeaponList(ByVal url As String) As DataTable
        Try
            Dim web As System.Net.WebClient = New System.Net.WebClient()
            Dim jsonString As String = web.DownloadString(url)
            Dim jsSerializer As New System.Web.Script.Serialization.JavaScriptSerializer() 'read json into a string
            Dim dict As Dictionary(Of String, Object) = jsSerializer.Deserialize(Of Dictionary(Of String, Object))(jsonString)
            Dim dt As DataTable = GetDTForItems()
            For Each row As Dictionary(Of String, Object) In dict.Values
                Dim dr As DataRow = dt.NewRow
                For Each kvp As KeyValuePair(Of String, Object) In row
                    dr.Item(kvp.Key) = kvp.Value
                Next
                dt.Rows.Add(dr)
            Next
            web.Dispose()
            Return dt
        Catch ex As Exception
            Debug.WriteLine(String.Format("GetWeaponList: {0}", ex.Message))
            Return Nothing
        End Try
    End Function

    Private Shared Function GetDTForItems() As DataTable
        Dim dt As New DataTable
        With dt ' set the column types as you see fit
            .Columns.Add("name", GetType(String))
            .Columns.Add("stattrak", GetType(Object))
            .Columns.Add("star", GetType(Object))
            .Columns.Add("souvenir", GetType(Object))
            .Columns.Add("sort", GetType(Object))
            .Columns.Add("exterior", GetType(Object))
            .Columns.Add("quality", GetType(Object))
            .Columns.Add("icon", GetType(Object))
            .Columns.Add("worth", GetType(Double))
            .Columns.Add("betable", GetType(Object))
            '.Columns.Add("binary", GetType(Byte()))
        End With
        Return dt
    End Function

    Public Shared Function GetMyInventory() As DataTable
        'Try
        Dim ClassID As New List(Of String)
        Dim ID As New List(Of String)
        Dim web As System.Net.WebClient = New System.Net.WebClient
        LogMe(String.Format("Requesting JSON from: {0}", urlSteamInventory))
        Dim jsonString As String = web.DownloadString(urlSteamInventory)
        Dim regClassIDs As New Regex(String.Format("{0}classid{0}:{0}\d{1}9{2}{0}", Chr(34), Chr(123), Chr(125)))
        Dim regIDs As New Regex(String.Format("{0}id{0}:{0}\d{1}10{2}{0}", Chr(34), Chr(123), Chr(125)))
        LogMe(String.Format("ClassIDs: {0} | IDs: {1}", String.Format("{0}id{0}:{0}\d{1}9{2}{0}", Chr(34), Chr(123), Chr(125)), String.Format("{0}id{0}:{0}\d{1}10{2}{0}", Chr(34), Chr(123), Chr(125))))
        Dim match As MatchCollection = regClassIDs.Matches(jsonString)
        If match.Count <> 0 Then
            LogMe("Adding Class IDs to list...")
            For Each sClassID As Match In match
                ClassID.Add(sClassID.Value)
            Next
            match = regIDs.Matches(jsonString)
            If match.Count <> 0 Then
                LogMe("Adding IDs to list...")
                For Each sID As Match In match
                    ID.Add(sID.Value)
                Next
                Dim dt As New DataTable
                LogMe("Created new DT. Adding ows...")
                With dt
                    .Columns.Add("ID")
                    .Columns.Add("ClassID")
                End With
                For i = 0 To ID.Count - 1
                    With dt
                        .Rows.Add({ID(i).Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("id", String.Empty), ClassID(i).Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("classid", String.Empty)})
                    End With
                Next
                LogMe("Rows added... Returning DT.")
                Return dt
            End If
        End If
        'Catch ex As Exception
        '    LogMe(ex.Message)
        'End Try
    End Function
End Class
