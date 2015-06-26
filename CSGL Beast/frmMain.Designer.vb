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
        Dim TileItemElement20 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement21 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement22 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement23 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement24 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement25 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement26 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement27 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement28 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement29 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement30 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement31 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement32 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement33 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement34 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement35 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement36 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement37 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement38 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
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
        TileItemElement20.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement20.Appearance.Hovered.Options.UseFont = True
        TileItemElement20.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement20.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement20.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement20.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement20.Appearance.Normal.Options.UseFont = True
        TileItemElement20.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement20.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement20.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement20.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement20.Appearance.Selected.Options.UseFont = True
        TileItemElement20.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement20.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement20.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement20.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement20.MaxWidth = 160
        TileItemElement20.Text = "View All"
        TileItemElement20.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement20.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement21.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement21.Appearance.Hovered.Options.UseFont = True
        TileItemElement21.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement21.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement21.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement21.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement21.Appearance.Normal.Options.UseFont = True
        TileItemElement21.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement21.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement21.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement21.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement21.Appearance.Selected.Options.UseFont = True
        TileItemElement21.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement21.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement21.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement21.MaxWidth = 160
        TileItemElement21.Text = "View a list of all matches, both past and future."
        TileItemElement21.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement21.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement22.Image = Global.CSGL_Beast.My.Resources.Resources.myapps
        TileItemElement22.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement22.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement22.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement22.ImageSize = New System.Drawing.Size(64, 64)
        TileItemElement22.Text = ""
        Me.tileViewAllMatches.Elements.Add(TileItemElement20)
        Me.tileViewAllMatches.Elements.Add(TileItemElement21)
        Me.tileViewAllMatches.Elements.Add(TileItemElement22)
        Me.tileViewAllMatches.Id = 5
        Me.tileViewAllMatches.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileViewAllMatches.Name = "tileViewAllMatches"
        Me.tileViewAllMatches.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always
        '
        'tileResearchTeam
        '
        TileItemElement23.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement23.Appearance.Hovered.Options.UseFont = True
        TileItemElement23.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement23.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement23.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement23.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement23.Appearance.Normal.Options.UseFont = True
        TileItemElement23.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement23.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement23.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement23.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement23.Appearance.Selected.Options.UseFont = True
        TileItemElement23.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement23.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement23.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement23.MaxWidth = 160
        TileItemElement23.Text = "Research Team"
        TileItemElement23.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement23.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement24.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement24.Appearance.Hovered.Options.UseFont = True
        TileItemElement24.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement24.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement24.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement24.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement24.Appearance.Normal.Options.UseFont = True
        TileItemElement24.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement24.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement24.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement24.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement24.Appearance.Selected.Options.UseFont = True
        TileItemElement24.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement24.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement24.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement24.MaxWidth = 160
        TileItemElement24.Text = "Research an individual teams win/loss history."
        TileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement24.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement25.Image = Global.CSGL_Beast.My.Resources.Resources.indexingoptions
        TileItemElement25.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement25.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement25.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement25.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileResearchTeam.Elements.Add(TileItemElement23)
        Me.tileResearchTeam.Elements.Add(TileItemElement24)
        Me.tileResearchTeam.Elements.Add(TileItemElement25)
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
        TileItemElement26.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement26.Appearance.Hovered.Options.UseFont = True
        TileItemElement26.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement26.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement26.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement26.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement26.Appearance.Normal.Options.UseFont = True
        TileItemElement26.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement26.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement26.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement26.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement26.Appearance.Selected.Options.UseFont = True
        TileItemElement26.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement26.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement26.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement26.MaxWidth = 160
        TileItemElement26.Text = "View Items"
        TileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement26.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement27.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement27.Appearance.Hovered.Options.UseFont = True
        TileItemElement27.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement27.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement27.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement27.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement27.Appearance.Normal.Options.UseFont = True
        TileItemElement27.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement27.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement27.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement27.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement27.Appearance.Selected.Options.UseFont = True
        TileItemElement27.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement27.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement27.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement27.MaxWidth = 160
        TileItemElement27.Text = "View all items that are available, and their current worth on CSGL."
        TileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement27.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement28.Image = Global.CSGL_Beast.My.Resources.Resources.Groups
        TileItemElement28.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement28.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement28.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement28.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileViewAllItems.Elements.Add(TileItemElement26)
        Me.tileViewAllItems.Elements.Add(TileItemElement27)
        Me.tileViewAllItems.Elements.Add(TileItemElement28)
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
        TileItemElement29.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement29.Appearance.Hovered.Options.UseFont = True
        TileItemElement29.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement29.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement29.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement29.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement29.Appearance.Normal.Options.UseFont = True
        TileItemElement29.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement29.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement29.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement29.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement29.Appearance.Selected.Options.UseFont = True
        TileItemElement29.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement29.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement29.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement29.MaxWidth = 160
        TileItemElement29.Text = "Last Refresh"
        TileItemElement29.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement29.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement30.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement30.Appearance.Hovered.Options.UseFont = True
        TileItemElement30.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement30.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement30.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement30.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement30.Appearance.Normal.Options.UseFont = True
        TileItemElement30.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement30.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement30.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement30.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement30.Appearance.Selected.Options.UseFont = True
        TileItemElement30.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement30.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement30.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement30.MaxWidth = 160
        TileItemElement30.Text = "INSERT DATE OF LAST REFRESH"
        TileItemElement30.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement30.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement31.Image = Global.CSGL_Beast.My.Resources.Resources.Update
        TileItemElement31.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement31.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement31.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement31.ImageSize = New System.Drawing.Size(64, 64)
        TileItemElement32.Text = "Click to refresh now"
        Me.tileLastRefresh.Elements.Add(TileItemElement29)
        Me.tileLastRefresh.Elements.Add(TileItemElement30)
        Me.tileLastRefresh.Elements.Add(TileItemElement31)
        Me.tileLastRefresh.Elements.Add(TileItemElement32)
        Me.tileLastRefresh.Id = 12
        Me.tileLastRefresh.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileLastRefresh.Name = "tileLastRefresh"
        '
        'tileTotalMatches
        '
        TileItemElement33.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement33.Appearance.Hovered.Options.UseFont = True
        TileItemElement33.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement33.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement33.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement33.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement33.Appearance.Normal.Options.UseFont = True
        TileItemElement33.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement33.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement33.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement33.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement33.Appearance.Selected.Options.UseFont = True
        TileItemElement33.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement33.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement33.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement33.MaxWidth = 160
        TileItemElement33.Text = "Matches In DB"
        TileItemElement33.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement33.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement34.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement34.Appearance.Hovered.Options.UseFont = True
        TileItemElement34.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement34.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement34.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement34.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement34.Appearance.Normal.Options.UseFont = True
        TileItemElement34.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement34.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement34.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement34.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement34.Appearance.Selected.Options.UseFont = True
        TileItemElement34.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement34.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement34.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement34.MaxWidth = 160
        TileItemElement34.Text = "INSERT TOTAL MATCHES"
        TileItemElement34.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement34.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement35.Image = Global.CSGL_Beast.My.Resources.Resources.searchalt
        TileItemElement35.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement35.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement35.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement35.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileTotalMatches.Elements.Add(TileItemElement33)
        Me.tileTotalMatches.Elements.Add(TileItemElement34)
        Me.tileTotalMatches.Elements.Add(TileItemElement35)
        Me.tileTotalMatches.Id = 13
        Me.tileTotalMatches.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileTotalMatches.Name = "tileTotalMatches"
        '
        'tileSettings
        '
        TileItemElement36.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement36.Appearance.Hovered.Options.UseFont = True
        TileItemElement36.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement36.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement36.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement36.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement36.Appearance.Normal.Options.UseFont = True
        TileItemElement36.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement36.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement36.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement36.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement36.Appearance.Selected.Options.UseFont = True
        TileItemElement36.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement36.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement36.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement36.MaxWidth = 160
        TileItemElement36.Text = "Settings"
        TileItemElement36.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement36.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement37.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement37.Appearance.Hovered.Options.UseFont = True
        TileItemElement37.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement37.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement37.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement37.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement37.Appearance.Normal.Options.UseFont = True
        TileItemElement37.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement37.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement37.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement37.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement37.Appearance.Selected.Options.UseFont = True
        TileItemElement37.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement37.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement37.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement37.MaxWidth = 160
        TileItemElement37.Text = "Click here to change your application settings."
        TileItemElement37.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement37.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement38.Image = CType(resources.GetObject("TileItemElement38.Image"), System.Drawing.Image)
        TileItemElement38.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement38.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement38.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement38.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileSettings.Elements.Add(TileItemElement36)
        Me.tileSettings.Elements.Add(TileItemElement37)
        Me.tileSettings.Elements.Add(TileItemElement38)
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
