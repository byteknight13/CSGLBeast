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
        lstSkinNames.SortOrder = SortOrder.Ascending
        lstSkinNames.SelectedIndex = Nothing
    End Sub

    Private Sub cmdSaveSettings_Click(sender As Object, e As EventArgs) Handles cmdSaveSettings.Click
        My.Settings.UserSkin = lstSkinNames.SelectedValue.ToString
        My.Settings.Save()
        LogMe(String.Format("The user select skin {0} hs been saved.", My.Settings.UserSkin))
    End Sub

    Private Sub lstSkinNames_Click(sender As Object, e As EventArgs) Handles lstSkinNames.Click
        'If lstSkinNames.SelectedIndex >= 0 AndAlso Not (lstSkinNames.SelectedIndex = Nothing) Then
        frmMain.DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(lstSkinNames.SelectedItem.ToString)
        'End If
    End Sub

    Private Sub cmdSetToDefaults_Click(sender As Object, e As EventArgs) Handles cmdSetToDefaults.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Are You Sure?") = MsgBoxResult.Yes Then
            frmMain.DefaultLookAndFeel1.LookAndFeel.SetSkinStyle("Whiteprint")
            My.Settings.UserSkin = "Whiteprint"
            My.Settings.Save()
        End If
    End Sub
End Class