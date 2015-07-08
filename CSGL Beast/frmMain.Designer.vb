Partial Public Class frmMain
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.CSGL_Beast.frmSplash), True, True)
        Dim TileItemElement39 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement40 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement41 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement42 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement43 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement44 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement45 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement46 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement47 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement48 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement49 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement50 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement51 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement52 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement53 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement54 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement55 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement56 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement57 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.tileViewAllMatches = New DevExpress.XtraEditors.TileItem()
        Me.tileResearchTeam = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.tileViewAllItems = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup4 = New DevExpress.XtraEditors.TileGroup()
        Me.tileLastRefresh = New DevExpress.XtraEditors.TileItem()
        Me.tileTotalMatches = New DevExpress.XtraEditors.TileItem()
        Me.tileSettings = New DevExpress.XtraEditors.TileItem()
        Me.tmrStyleWatcher = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Whiteprint"
        '
        'TileControl1
        '
        Me.TileControl1.AllowDrag = False
        Me.TileControl1.AllowDragTilesBetweenGroups = False
        Me.TileControl1.AllowItemHover = True
        Me.TileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.TileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gainsboro
        Me.TileControl1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.DimGray
        Me.TileControl1.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.TileControl1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseForeColor = True
        Me.TileControl1.BackColor = System.Drawing.Color.Transparent
        Me.TileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.Groups.Add(Me.TileGroup4)
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TileControl1.MaxId = 15
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.ShowGroupText = True
        Me.TileControl1.ShowText = True
        Me.TileControl1.Size = New System.Drawing.Size(906, 530)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "Dashboard"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.tileViewAllMatches)
        Me.TileGroup2.Items.Add(Me.tileResearchTeam)
        Me.TileGroup2.Name = "TileGroup2"
        Me.TileGroup2.Text = "Matches"
        '
        'tileViewAllMatches
        '
        Me.tileViewAllMatches.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade
        TileItemElement39.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement39.Appearance.Hovered.Options.UseFont = True
        TileItemElement39.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement39.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement39.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement39.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement39.Appearance.Normal.Options.UseFont = True
        TileItemElement39.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement39.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement39.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement39.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement39.Appearance.Selected.Options.UseFont = True
        TileItemElement39.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement39.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement39.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement39.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement39.MaxWidth = 160
        TileItemElement39.Text = "View All"
        TileItemElement39.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement39.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement40.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement40.Appearance.Hovered.Options.UseFont = True
        TileItemElement40.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement40.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement40.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement40.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement40.Appearance.Normal.Options.UseFont = True
        TileItemElement40.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement40.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement40.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement40.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement40.Appearance.Selected.Options.UseFont = True
        TileItemElement40.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement40.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement40.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement40.MaxWidth = 160
        TileItemElement40.Text = "View a list of all matches, both past and future."
        TileItemElement40.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement40.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement41.Image = Global.CSGL_Beast.My.Resources.Resources.myapps
        TileItemElement41.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement41.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement41.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement41.ImageSize = New System.Drawing.Size(64, 64)
        TileItemElement41.Text = ""
        Me.tileViewAllMatches.Elements.Add(TileItemElement39)
        Me.tileViewAllMatches.Elements.Add(TileItemElement40)
        Me.tileViewAllMatches.Elements.Add(TileItemElement41)
        Me.tileViewAllMatches.Id = 5
        Me.tileViewAllMatches.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileViewAllMatches.Name = "tileViewAllMatches"
        Me.tileViewAllMatches.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always
        '
        'tileResearchTeam
        '
        TileItemElement42.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement42.Appearance.Hovered.Options.UseFont = True
        TileItemElement42.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement42.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement42.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement42.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement42.Appearance.Normal.Options.UseFont = True
        TileItemElement42.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement42.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement42.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement42.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement42.Appearance.Selected.Options.UseFont = True
        TileItemElement42.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement42.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement42.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement42.MaxWidth = 160
        TileItemElement42.Text = "Research Team"
        TileItemElement42.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement42.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement43.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement43.Appearance.Hovered.Options.UseFont = True
        TileItemElement43.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement43.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement43.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement43.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement43.Appearance.Normal.Options.UseFont = True
        TileItemElement43.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement43.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement43.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement43.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement43.Appearance.Selected.Options.UseFont = True
        TileItemElement43.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement43.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement43.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement43.MaxWidth = 160
        TileItemElement43.Text = "Research an individual teams win/loss history."
        TileItemElement43.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement43.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement44.Image = Global.CSGL_Beast.My.Resources.Resources.indexingoptions
        TileItemElement44.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement44.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement44.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement44.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileResearchTeam.Elements.Add(TileItemElement42)
        Me.tileResearchTeam.Elements.Add(TileItemElement43)
        Me.tileResearchTeam.Elements.Add(TileItemElement44)
        Me.tileResearchTeam.Id = 10
        Me.tileResearchTeam.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileResearchTeam.Name = "tileResearchTeam"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.tileViewAllItems)
        Me.TileGroup3.Name = "TileGroup3"
        Me.TileGroup3.Text = "Items"
        '
        'tileViewAllItems
        '
        TileItemElement45.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement45.Appearance.Hovered.Options.UseFont = True
        TileItemElement45.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement45.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement45.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement45.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement45.Appearance.Normal.Options.UseFont = True
        TileItemElement45.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement45.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement45.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement45.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement45.Appearance.Selected.Options.UseFont = True
        TileItemElement45.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement45.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement45.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement45.MaxWidth = 160
        TileItemElement45.Text = "View Items"
        TileItemElement45.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement45.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement46.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement46.Appearance.Hovered.Options.UseFont = True
        TileItemElement46.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement46.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement46.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement46.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement46.Appearance.Normal.Options.UseFont = True
        TileItemElement46.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement46.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement46.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement46.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement46.Appearance.Selected.Options.UseFont = True
        TileItemElement46.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement46.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement46.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement46.MaxWidth = 160
        TileItemElement46.Text = "View all items that are available, and their current worth on CSGL."
        TileItemElement46.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement46.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement47.Image = Global.CSGL_Beast.My.Resources.Resources.Groups
        TileItemElement47.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement47.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement47.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement47.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileViewAllItems.Elements.Add(TileItemElement45)
        Me.tileViewAllItems.Elements.Add(TileItemElement46)
        Me.tileViewAllItems.Elements.Add(TileItemElement47)
        Me.tileViewAllItems.Id = 8
        Me.tileViewAllItems.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileViewAllItems.Name = "tileViewAllItems"
        '
        'TileGroup4
        '
        Me.TileGroup4.Items.Add(Me.tileLastRefresh)
        Me.TileGroup4.Items.Add(Me.tileTotalMatches)
        Me.TileGroup4.Items.Add(Me.tileSettings)
        Me.TileGroup4.Name = "TileGroup4"
        Me.TileGroup4.Text = "CSGL Beast Status"
        '
        'tileLastRefresh
        '
        TileItemElement48.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement48.Appearance.Hovered.Options.UseFont = True
        TileItemElement48.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement48.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement48.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement48.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement48.Appearance.Normal.Options.UseFont = True
        TileItemElement48.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement48.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement48.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement48.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement48.Appearance.Selected.Options.UseFont = True
        TileItemElement48.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement48.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement48.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement48.MaxWidth = 160
        TileItemElement48.Text = "Last Refresh"
        TileItemElement48.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement48.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement49.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement49.Appearance.Hovered.Options.UseFont = True
        TileItemElement49.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement49.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement49.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement49.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement49.Appearance.Normal.Options.UseFont = True
        TileItemElement49.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement49.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement49.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement49.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement49.Appearance.Selected.Options.UseFont = True
        TileItemElement49.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement49.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement49.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement49.MaxWidth = 160
        TileItemElement49.Text = "INSERT DATE OF LAST REFRESH"
        TileItemElement49.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement49.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement50.Image = Global.CSGL_Beast.My.Resources.Resources.Update
        TileItemElement50.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement50.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement50.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement50.ImageSize = New System.Drawing.Size(64, 64)
        TileItemElement51.Text = "Click to refresh now"
        Me.tileLastRefresh.Elements.Add(TileItemElement48)
        Me.tileLastRefresh.Elements.Add(TileItemElement49)
        Me.tileLastRefresh.Elements.Add(TileItemElement50)
        Me.tileLastRefresh.Elements.Add(TileItemElement51)
        Me.tileLastRefresh.Id = 12
        Me.tileLastRefresh.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileLastRefresh.Name = "tileLastRefresh"
        '
        'tileTotalMatches
        '
        TileItemElement52.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement52.Appearance.Hovered.Options.UseFont = True
        TileItemElement52.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement52.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement52.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement52.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement52.Appearance.Normal.Options.UseFont = True
        TileItemElement52.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement52.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement52.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement52.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement52.Appearance.Selected.Options.UseFont = True
        TileItemElement52.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement52.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement52.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement52.MaxWidth = 160
        TileItemElement52.Text = "Matches In DB"
        TileItemElement52.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement52.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement53.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement53.Appearance.Hovered.Options.UseFont = True
        TileItemElement53.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement53.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement53.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement53.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement53.Appearance.Normal.Options.UseFont = True
        TileItemElement53.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement53.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement53.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement53.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement53.Appearance.Selected.Options.UseFont = True
        TileItemElement53.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement53.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement53.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement53.MaxWidth = 160
        TileItemElement53.Text = "INSERT TOTAL MATCHES"
        TileItemElement53.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement53.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement54.Image = Global.CSGL_Beast.My.Resources.Resources.searchalt
        TileItemElement54.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement54.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement54.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement54.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileTotalMatches.Elements.Add(TileItemElement52)
        Me.tileTotalMatches.Elements.Add(TileItemElement53)
        Me.tileTotalMatches.Elements.Add(TileItemElement54)
        Me.tileTotalMatches.Id = 13
        Me.tileTotalMatches.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileTotalMatches.Name = "tileTotalMatches"
        '
        'tileSettings
        '
        TileItemElement55.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement55.Appearance.Hovered.Options.UseFont = True
        TileItemElement55.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement55.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement55.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement55.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement55.Appearance.Normal.Options.UseFont = True
        TileItemElement55.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement55.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement55.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement55.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement55.Appearance.Selected.Options.UseFont = True
        TileItemElement55.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement55.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement55.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement55.MaxWidth = 160
        TileItemElement55.Text = "Settings"
        TileItemElement55.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement55.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement56.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement56.Appearance.Hovered.Options.UseFont = True
        TileItemElement56.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement56.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement56.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement56.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement56.Appearance.Normal.Options.UseFont = True
        TileItemElement56.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement56.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement56.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement56.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement56.Appearance.Selected.Options.UseFont = True
        TileItemElement56.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement56.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement56.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement56.MaxWidth = 160
        TileItemElement56.Text = "Click here to change your application settings."
        TileItemElement56.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement56.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement57.Image = CType(resources.GetObject("TileItemElement57.Image"), System.Drawing.Image)
        TileItemElement57.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement57.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement57.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement57.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileSettings.Elements.Add(TileItemElement55)
        Me.tileSettings.Elements.Add(TileItemElement56)
        Me.tileSettings.Elements.Add(TileItemElement57)
        Me.tileSettings.Id = 14
        Me.tileSettings.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileSettings.Name = "tileSettings"
        '
        'tmrStyleWatcher
        '
        Me.tmrStyleWatcher.Enabled = True
        '
        'frmMain
        '
        Me.ActiveGlowColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(906, 530)
        Me.Controls.Add(Me.TileControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.InactiveGlowColor = System.Drawing.Color.WhiteSmoke
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSGL Beast"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents tileViewAllMatches As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents tileViewAllItems As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileResearchTeam As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup4 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents tileLastRefresh As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileTotalMatches As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileSettings As DevExpress.XtraEditors.TileItem
    Friend WithEvents tmrStyleWatcher As System.Windows.Forms.Timer

#End Region

End Class
