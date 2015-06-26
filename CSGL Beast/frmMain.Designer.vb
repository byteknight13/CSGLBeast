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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement12 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement13 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement14 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement15 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement16 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.tileViewAllMatches = New DevExpress.XtraEditors.TileItem()
        Me.tileResearchTeam = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.tileViewAllItems = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup4 = New DevExpress.XtraEditors.TileGroup()
        Me.tileLastRefresh = New DevExpress.XtraEditors.TileItem()
        Me.tileTotalMatches = New DevExpress.XtraEditors.TileItem()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis"
        Me.DefaultLookAndFeel1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
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
        Me.TileControl1.MaxId = 14
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.ShowGroupText = True
        Me.TileControl1.ShowText = True
        Me.TileControl1.Size = New System.Drawing.Size(913, 404)
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
        TileItemElement1.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement1.Appearance.Hovered.Options.UseFont = True
        TileItemElement1.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement1.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement1.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement1.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement1.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement1.Appearance.Selected.Options.UseFont = True
        TileItemElement1.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement1.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement1.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.MaxWidth = 160
        TileItemElement1.Text = "View All"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileItemElement1.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement2.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement2.Appearance.Hovered.Options.UseFont = True
        TileItemElement2.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement2.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement2.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement2.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement2.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement2.Appearance.Selected.Options.UseFont = True
        TileItemElement2.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement2.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement2.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement2.MaxWidth = 160
        TileItemElement2.Text = "View a list of all matches, both past and future."
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement2.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement3.Image = Global.CSGL_Beast.My.Resources.Resources.myapps
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement3.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement3.ImageSize = New System.Drawing.Size(64, 64)
        TileItemElement3.Text = ""
        Me.tileViewAllMatches.Elements.Add(TileItemElement1)
        Me.tileViewAllMatches.Elements.Add(TileItemElement2)
        Me.tileViewAllMatches.Elements.Add(TileItemElement3)
        Me.tileViewAllMatches.Id = 5
        Me.tileViewAllMatches.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileViewAllMatches.Name = "tileViewAllMatches"
        Me.tileViewAllMatches.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always
        '
        'tileResearchTeam
        '
        TileItemElement4.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement4.Appearance.Hovered.Options.UseFont = True
        TileItemElement4.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement4.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement4.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement4.Appearance.Normal.Options.UseFont = True
        TileItemElement4.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement4.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement4.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement4.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement4.Appearance.Selected.Options.UseFont = True
        TileItemElement4.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement4.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement4.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement4.MaxWidth = 160
        TileItemElement4.Text = "Research Team"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement4.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement5.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement5.Appearance.Hovered.Options.UseFont = True
        TileItemElement5.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement5.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement5.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement5.Appearance.Normal.Options.UseFont = True
        TileItemElement5.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement5.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement5.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement5.Appearance.Selected.Options.UseFont = True
        TileItemElement5.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement5.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement5.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement5.MaxWidth = 160
        TileItemElement5.Text = "Research an individual teams win/loss history."
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement5.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement6.Image = Global.CSGL_Beast.My.Resources.Resources.indexingoptions
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement6.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement6.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileResearchTeam.Elements.Add(TileItemElement4)
        Me.tileResearchTeam.Elements.Add(TileItemElement5)
        Me.tileResearchTeam.Elements.Add(TileItemElement6)
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
        TileItemElement7.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement7.Appearance.Hovered.Options.UseFont = True
        TileItemElement7.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement7.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement7.Appearance.Normal.Options.UseFont = True
        TileItemElement7.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement7.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement7.Appearance.Selected.Options.UseFont = True
        TileItemElement7.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement7.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement7.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement7.MaxWidth = 160
        TileItemElement7.Text = "View Items"
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement7.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement8.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement8.Appearance.Hovered.Options.UseFont = True
        TileItemElement8.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement8.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement8.Appearance.Normal.Options.UseFont = True
        TileItemElement8.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement8.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement8.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement8.Appearance.Selected.Options.UseFont = True
        TileItemElement8.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement8.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement8.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement8.MaxWidth = 160
        TileItemElement8.Text = "View all items that are available, and their current worth on CSGL."
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement8.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement9.Image = Global.CSGL_Beast.My.Resources.Resources.Groups
        TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement9.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement9.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileViewAllItems.Elements.Add(TileItemElement7)
        Me.tileViewAllItems.Elements.Add(TileItemElement8)
        Me.tileViewAllItems.Elements.Add(TileItemElement9)
        Me.tileViewAllItems.Id = 8
        Me.tileViewAllItems.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileViewAllItems.Name = "tileViewAllItems"
        '
        'TileGroup4
        '
        Me.TileGroup4.Items.Add(Me.tileLastRefresh)
        Me.TileGroup4.Items.Add(Me.tileTotalMatches)
        Me.TileGroup4.Name = "TileGroup4"
        Me.TileGroup4.Text = "CSGL Beast Status"
        '
        'tileLastRefresh
        '
        TileItemElement10.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement10.Appearance.Hovered.Options.UseFont = True
        TileItemElement10.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement10.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement10.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement10.Appearance.Normal.Options.UseFont = True
        TileItemElement10.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement10.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement10.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement10.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement10.Appearance.Selected.Options.UseFont = True
        TileItemElement10.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement10.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement10.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement10.MaxWidth = 160
        TileItemElement10.Text = "Last Refresh"
        TileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement10.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement11.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement11.Appearance.Hovered.Options.UseFont = True
        TileItemElement11.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement11.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement11.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement11.Appearance.Normal.Options.UseFont = True
        TileItemElement11.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement11.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement11.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement11.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement11.Appearance.Selected.Options.UseFont = True
        TileItemElement11.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement11.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement11.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement11.MaxWidth = 160
        TileItemElement11.Text = "INSERT DATE OF LAST REFRESH"
        TileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement11.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement12.Image = Global.CSGL_Beast.My.Resources.Resources.Update
        TileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement12.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement12.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement12.ImageSize = New System.Drawing.Size(64, 64)
        TileItemElement13.Text = "Click to refresh now"
        Me.tileLastRefresh.Elements.Add(TileItemElement10)
        Me.tileLastRefresh.Elements.Add(TileItemElement11)
        Me.tileLastRefresh.Elements.Add(TileItemElement12)
        Me.tileLastRefresh.Elements.Add(TileItemElement13)
        Me.tileLastRefresh.Id = 12
        Me.tileLastRefresh.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileLastRefresh.Name = "tileLastRefresh"
        '
        'tileTotalMatches
        '
        TileItemElement14.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement14.Appearance.Hovered.Options.UseFont = True
        TileItemElement14.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement14.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement14.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement14.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement14.Appearance.Normal.Options.UseFont = True
        TileItemElement14.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement14.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement14.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement14.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        TileItemElement14.Appearance.Selected.Options.UseFont = True
        TileItemElement14.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement14.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement14.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        TileItemElement14.MaxWidth = 160
        TileItemElement14.Text = "Matches In DB"
        TileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement14.TextLocation = New System.Drawing.Point(75, 0)
        TileItemElement15.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement15.Appearance.Hovered.Options.UseFont = True
        TileItemElement15.Appearance.Hovered.Options.UseTextOptions = True
        TileItemElement15.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement15.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement15.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement15.Appearance.Normal.Options.UseFont = True
        TileItemElement15.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement15.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement15.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement15.Appearance.Selected.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        TileItemElement15.Appearance.Selected.Options.UseFont = True
        TileItemElement15.Appearance.Selected.Options.UseTextOptions = True
        TileItemElement15.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
        TileItemElement15.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TileItemElement15.MaxWidth = 160
        TileItemElement15.Text = "INSERT TOTAL MATCHES"
        TileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement15.TextLocation = New System.Drawing.Point(85, 32)
        TileItemElement16.Image = Global.CSGL_Beast.My.Resources.Resources.searchalt
        TileItemElement16.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileItemElement16.ImageLocation = New System.Drawing.Point(4, 8)
        TileItemElement16.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileItemElement16.ImageSize = New System.Drawing.Size(64, 64)
        Me.tileTotalMatches.Elements.Add(TileItemElement14)
        Me.tileTotalMatches.Elements.Add(TileItemElement15)
        Me.tileTotalMatches.Elements.Add(TileItemElement16)
        Me.tileTotalMatches.Id = 13
        Me.tileTotalMatches.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileTotalMatches.Name = "tileTotalMatches"
        '
        'frmMain
        '
        Me.ActiveGlowColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(913, 404)
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

#End Region

End Class
