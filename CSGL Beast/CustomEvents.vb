Imports System.ComponentModel
Imports System.Collections

Public Class CustomEvents
    Inherits CollectionBase

#Region " Fields "

    Private _events As EventHandlerList = Nothing

#End Region

#Region " Properties "

    Protected ReadOnly Property Events() As EventHandlerList
        Get
            If _events Is Nothing Then
                _events = New EventHandlerList()
            End If
            Return _events
        End Get
    End Property

#End Region

#Region " Methods "
    Protected Overridable Sub OnThemeChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim handler As EventHandler = CType(Me.Events("ThemeChangedEvent"), EventHandler)
        If (handler IsNot Nothing) Then
            RaiseEvent ThemeChanged(sender, e)
        End If
    End Sub
#End Region

#Region " Events "

    Public Custom Event ThemeChanged As EventHandler
        AddHandler(ByVal value As EventHandler)
            Me.Events.AddHandler("ThemeChangedEvent", value)
        End AddHandler

        RemoveHandler(ByVal value As EventHandler)
            Me.Events.RemoveHandler("ThemeChangedEvent", value)
        End RemoveHandler

        RaiseEvent(ByVal sender As Object, ByVal e As System.EventArgs)
            CType(Me.Events("ThemeChangedEvent"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

#End Region

End Class
