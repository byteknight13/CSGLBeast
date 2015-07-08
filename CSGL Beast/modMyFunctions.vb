Module modMyFunctions

    Public Sub LogMe(ByVal msg As String)
        'Dim method As String = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim stackframe As New Diagnostics.StackFrame(1)
        Dim method As String = stackframe.GetMethod.Name
        SetStatusText(msg)
        Debug.WriteLine(String.Format("{0}: {1}", method, msg))
    End Sub

    Private Delegate Sub SetStatusTextDelegate(ByVal text As String)
    Public Sub SetStatusText(ByVal text As String)
        If frmMatches.InvokeRequired Then
            Dim del As New SetStatusTextDelegate(AddressOf SetStatusText)
            frmMatches.Invoke(del, New Object() {text})
        Else
            frmMatches.lblStatus.Caption = String.Format("Status: {0}", text)
        End If
    End Sub

End Module
