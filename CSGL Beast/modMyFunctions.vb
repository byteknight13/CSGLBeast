Module modMyFunctions

    Public Sub LogMe(ByVal msg As String)
        'Dim method As String = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim stackframe As New Diagnostics.StackFrame(1)
        Dim method As String = stackframe.GetMethod.Name
        Debug.WriteLine(String.Format("{0}: {1}", method, msg))
    End Sub

End Module
