Imports Newtonsoft.Json
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

    ''' <summary>
    ''' Gets inventory for specified user.
    ''' </summary>
    ''' <returns>DataTable with ID and Class IDs</returns>
    Public Shared Function GetMyInventoryOLD() As DataTable
        Try
            Dim ClassID As New List(Of String)
            Dim InstanceID As New List(Of String)
            Dim ID As New List(Of String)
            Dim web As System.Net.WebClient = New System.Net.WebClient
            LogMe(String.Format("Requesting JSON from: {0}", urlSteamInventory))
            Dim jsonString As String = web.DownloadString(urlSteamInventory)
            Dim match As MatchCollection
            LogMe(String.Format("ClassIDs: {0} | IDs: {1}", String.Format("{0}id{0}:{0}\d{1}9{2}{0}", Chr(34), Chr(123), Chr(125)), String.Format("{0}id{0}:{0}\d{1}10{2}{0}", Chr(34), Chr(123), Chr(125))))
            match = (New Regex(String.Format("{0}classid{0}:{0}\d{1}9{2}{0}", Chr(34), Chr(123), Chr(125)))).Matches(jsonString) 'ClassIDs
            If match.Count <> 0 Then
                LogMe("Adding Class IDs to list...")
                For Each sClassID As Match In match
                    ClassID.Add(sClassID.Value.Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("classid", String.Empty).Trim)
                Next

                match = (New Regex(String.Format("{0}instanceid{0}:{0}(0|\d{1}9{2})", Chr(34), Chr(123), Chr(125)) & Chr(34))).Matches(jsonString) 'Instance IDs
                If match.Count <> 0 Then
                    For Each sInstanceID As Match In match
                        InstanceID.Add(sInstanceID.Value.Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("instanceid", String.Empty).Trim)
                    Next

                    match = (New Regex(String.Format("{0}id{0}:{0}\d{1}10{2}{0}", Chr(34), Chr(123), Chr(125)))).Matches(jsonString) 'IDs
                    If match.Count <> 0 Then
                        LogMe("Adding IDs to list...")
                        For Each sID As Match In match
                            ID.Add(sID.Value.Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("id", String.Empty).Trim)
                        Next

                        Dim dt As New DataTable
                        LogMe("Created new DT. Adding ows...")
                        With dt
                            .Columns.Add("ID")
                            .Columns.Add("Class ID")
                            .Columns.Add("Instance ID")
                        End With
                        For i = 0 To ID.Count - 1
                            With dt
                                .Rows.Add({ID(i), ClassID(i), InstanceID(i)})
                            End With
                        Next
                        LogMe("Rows added... Returning DT.")
                        Return dt
                    End If
                End If
            End If
        Catch ex As Exception
            LogMe(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Shared Function GetMyInventory() As DataTable
        Dim retDT As New DataTable
        With retDT
            .Columns.Add("Name")
            .Columns.Add("Description")
            .Columns.Add("Collection")
        End With
        Dim Items As New List(Of InventoryItems)
        Dim web As System.Net.WebClient = New System.Net.WebClient
        LogMe(String.Format("Requesting JSON from: {0}", urlSteamInventory))
        Dim jsonString As String = web.DownloadString(urlSteamInventory)
        Dim regItems As New Regex("(?is-mnx:\d{9,10}_\d{1,9}.*?].*?})")
        Dim regName As New Regex(String.Format("{0}market_hash_name{0}:{0}.*?{0}", Chr(34)))
        Dim regDescription As New Regex(String.Format("{0}type{0}:{0}.*?{0}", Chr(34)))
        Dim regCollection As New Regex(String.Format("{0}The .{1}3,30{2}? Collection{0}", Chr(34), "{", "}"))
        Dim colRegAll As MatchCollection
        Dim matchItemName As MatchCollection
        Dim matchDescription As MatchCollection
        Dim matchCollection As MatchCollection

        colRegAll = regItems.Matches(jsonString)
        If colRegAll.Count <> 0 Then
            For Each listing As Match In colRegAll
                Dim InventoryItems As New InventoryItems
                matchItemName = regName.Matches(listing.Value)
                If matchItemName.Count <> 0 Then InventoryItems.Name = matchItemName.Item(0).Value.Replace("market_hash_name", String.Empty).Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("\u2122", "™")
                matchDescription = regDescription.Matches(listing.Value)
                If matchDescription.Count <> 0 Then InventoryItems.Description = matchDescription.Item(0).Value.Replace("type", String.Empty).Replace(Chr(34), String.Empty).Replace(":", String.Empty).Replace("\u2122", "™")
                matchCollection = regCollection.Matches(listing.Value)
                If matchCollection.Count <> 0 Then InventoryItems.Collection = matchCollection.Item(0).Value.Replace(Chr(34), String.Empty)
                Items.Add(InventoryItems)
            Next
            For Each item In Items
                retDT.Rows.Add({item.Name, item.Description, item.Collection})
            Next
            Return retDT
        End If
        Return Nothing
    End Function

End Class

Public Class InventoryItems
    Public Property Name As String
    Public Property Description As String
    Public Property Collection As String
End Class
