Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.XtraEditors

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
        Dim CSGLAPI As New CSGLAPI
        CSGLAPI.SetUserSkin()
        frmMatches.TblMatchesTableAdapter1.Fill(dtMatches) 'Just for counting rows
        tileLastRefresh.Elements(1).Text = My.Settings.LastRefresh.ToString 'Set the last refresh tile to the last refresh date/time
        tileTotalMatches.Elements(1).Text = String.Format("Total: {0}", dtMatches.Rows.Count.ToString) 'Count total number of rows in dtMatches
    End Sub

    Private Sub tileViewAllMatches_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileViewAllMatches.ItemClick
        frmMatches.Show() 'Show frmMatches, and set frmMain (me) as the owner.
        frmMatches.WindowState = FormWindowState.Normal
    End Sub

    Private Sub tileViewAllItems_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileViewAllItems.ItemClick
        frmItems.Show() 'Show frmItems, and set frmMain (me) as the owner.
        frmItems.WindowState = FormWindowState.Normal
    End Sub

    Private Sub tileSettings_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileSettings.ItemClick
        frmSettings.Show() 'Show frmItems, and set frmMain (me) as the owner.
        frmSettings.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmMain_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged
        Dim currentSkin As DevExpress.Skins.Skin = CommonSkins.GetSkin(DefaultLookAndFeel1.LookAndFeel.ActiveLookAndFeel)

        Dim c1 As Color = currentSkin.Colors("HideSelection")
        Dim c2 As Color = currentSkin.Colors("Highlight")
        Dim c3 As Color = currentSkin.Colors("MenuText")

        For Each tile As TileControl In Me.Controls
            TileControl1.AppearanceItem.Normal.BackColor = c1
            TileControl1.AppearanceItem.Normal.BackColor2 = c2
            TileControl1.AppearanceItem.Normal.BorderColor = c3
            TileControl1.AppearanceItem.Normal.ForeColor = c3
        Next
    End Sub
End Class
