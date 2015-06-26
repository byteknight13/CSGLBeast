Public Class frmSettings

    Private Sub frmSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.WindowState = FormWindowState.Normal
        frmMain.DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(My.Settings.UserSkin)
        Me.Dispose()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        frmMain.WindowState = FormWindowState.Minimized
        LoadSkins()
    End Sub
    Private Sub LoadSkins()
        For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
            lstSkinNames.Items.Add(skin.SkinName)
        Next
        lstSkinNames.SelectedIndex = Nothing
    End Sub

    Private Sub cmdSaveSettings_Click(sender As Object, e As EventArgs) Handles cmdSaveSettings.Click
        My.Settings.UserSkin = lstSkinNames.SelectedValue.ToString
        My.Settings.Save()
        LogMe(String.Format("The user select skin {0} hs been saved.", My.Settings.UserSkin))
    End Sub

    Private Sub lstSkinNames_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstSkinNames.SelectedIndexChanged
        If lstSkinNames.SelectedIndex >= 0 AndAlso Not (lstSkinNames.SelectedIndex = Nothing) Then
            frmMain.DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(lstSkinNames.Items(lstSkinNames.SelectedIndex).ToString)
        End If
    End Sub
End Class