Imports CSGL_Beast.CSGLAPI
Imports DevExpress.XtraSplashScreen
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class frmSplash
    Inherits SplashScreen
    Public statusid As Integer = 0
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        'Dim command As SplashScreenCommand = CType(cmd, SplashScreenCommand)
        'If command = SplashScreenCommand.SetSkin Then
        '    LogMe("Setting Skins")
        '    SetSkin()
        'End If
    End Sub

    Public Sub SetSkin()
        Dim CSGLAPI As New CSGLAPI
        CSGLAPI.SetUserSkin()
    End Sub

    Public Enum SplashScreenCommand
        SetSkin
    End Enum

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = String.Format("Current Version: {0}", Me.ProductVersion.ToString)
    End Sub

    Public Sub changestatus()
        Select Case statusid
            Case 0
                lblStatus.Text = "Loading components..."
            Case 1
                lblStatus.Text = "Initializing connection with database..."
            Case 2
                lblStatus.Text = "Verifying integrity of database..."
            Case 3
                lblStatus.Text = "Loading GUI..."
            Case 4
                Me.Hide()
                frmMain.Show()
        End Select
        statusid += 1
    End Sub


    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        changestatus()
        Dim rnd As New Random
        Dim interval As Integer = rnd.Next(1000, 2000)
        tmrLoad.Interval = interval
    End Sub


    Private Sub pictureEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles pictureEdit2.EditValueChanged

    End Sub
End Class
