Imports System.ComponentModel
Imports System.Text


Partial Public Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm

    Public dtMatches As New dbCSGLDataSet.tblMatchesDataTable 'Just for counting rows

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogMe("frmMain Loading...")
        frmMatches.TblMatchesTableAdapter1.Fill(dtMatches) 'Just for counting rows
        tileLastRefresh.Elements(1).Text = My.Settings.LastRefresh.ToString 'Set the last refresh tile to the last refresh date/time
        tileTotalMatches.Elements(1).Text = String.Format("Total: {0}", dtMatches.Rows.Count.ToString) 'Count total number of rows in dtMatches
        LogMe("frmMain Loaded!")
    End Sub

    Private Sub tileViewAllMatches_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileViewAllMatches.ItemClick
        frmMatches.Show() 'Show frmMatches, and set frmMain (me) as the owner.
        frmMatches.WindowState = FormWindowState.Normal
        'Me.WindowState = FormWindowState.Minimized 'Minimize the form when frmMatches is brought up.
    End Sub
End Class
