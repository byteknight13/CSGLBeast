<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatches
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatches))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCSGLDataSet1 = New CSGL_Beast.dbCSGLDataSet()
        Me.gviewMatches = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMatchID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMatchDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeam1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeam2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWinner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClosed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEvent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBestOf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.TblMatchesTableAdapter1 = New CSGL_Beast.dbCSGLDataSetTableAdapters.tblMatchesTableAdapter()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.LookUpTeamOne = New DevExpress.XtraBars.BarEditItem()
        Me.reposTeamOne = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LookUpTeamTwo = New DevExpress.XtraBars.BarEditItem()
        Me.reposTeamTwo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuClearFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuFilterBest1 = New DevExpress.XtraBars.BarCheckItem()
        Me.mnuFilterBest2 = New DevExpress.XtraBars.BarCheckItem()
        Me.mnuFilterBest3 = New DevExpress.XtraBars.BarCheckItem()
        Me.d = New DevExpress.XtraBars.BarSubItem()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuCheckShowFind = New DevExpress.XtraBars.BarCheckItem()
        Me.mnuRefreshMatches = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDateRange = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuCheckAutoFilter = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.bgWorkerRefreshMatches = New System.ComponentModel.BackgroundWorker()
        Me.tmrBgWorker = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSetFilterTeamList = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCSGLDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gviewMatches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reposTeamOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reposTeamTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 60)
        Me.GridControl1.LookAndFeel.SkinName = "Metropolis Dark"
        Me.GridControl1.MainView = Me.gviewMatches
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(948, 401)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gviewMatches, Me.LayoutView1})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblMatches"
        Me.BindingSource1.DataSource = Me.DbCSGLDataSet1
        Me.BindingSource1.Sort = "MatchID DESC"
        '
        'DbCSGLDataSet1
        '
        Me.DbCSGLDataSet1.DataSetName = "dbCSGLDataSet"
        Me.DbCSGLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gviewMatches
        '
        Me.gviewMatches.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gviewMatches.Appearance.EvenRow.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.gviewMatches.Appearance.EvenRow.BorderColor = System.Drawing.Color.Black
        Me.gviewMatches.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gviewMatches.Appearance.EvenRow.Options.UseBackColor = True
        Me.gviewMatches.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gviewMatches.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gviewMatches.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.gviewMatches.Appearance.OddRow.BorderColor = System.Drawing.Color.Black
        Me.gviewMatches.Appearance.OddRow.Options.UseBackColor = True
        Me.gviewMatches.Appearance.OddRow.Options.UseBorderColor = True
        Me.gviewMatches.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gviewMatches.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gviewMatches.Appearance.Row.Options.UseBackColor = True
        Me.gviewMatches.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray
        Me.gviewMatches.Appearance.VertLine.Options.UseBackColor = True
        Me.gviewMatches.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gviewMatches.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMatchID, Me.colMatchDate, Me.colTeam1, Me.colTeam2, Me.colWinner, Me.colClosed, Me.colEvent, Me.colBestOf})
        Me.gviewMatches.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gviewMatches.GridControl = Me.GridControl1
        Me.gviewMatches.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", Me.colMatchID, "Count: {0}")})
        Me.gviewMatches.Name = "gviewMatches"
        Me.gviewMatches.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gviewMatches.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gviewMatches.OptionsPrint.EnableAppearanceOddRow = True
        Me.gviewMatches.OptionsView.EnableAppearanceEvenRow = True
        Me.gviewMatches.OptionsView.EnableAppearanceOddRow = True
        Me.gviewMatches.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.gviewMatches.OptionsView.ShowAutoFilterRow = True
        Me.gviewMatches.OptionsView.ShowFooter = True
        Me.gviewMatches.PaintStyleName = "Skin"
        '
        'colMatchID
        '
        Me.colMatchID.FieldName = "MatchID"
        Me.colMatchID.Name = "colMatchID"
        Me.colMatchID.OptionsColumn.AllowEdit = False
        Me.colMatchID.Visible = True
        Me.colMatchID.VisibleIndex = 0
        '
        'colMatchDate
        '
        Me.colMatchDate.DisplayFormat.FormatString = "g"
        Me.colMatchDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMatchDate.FieldName = "MatchDate"
        Me.colMatchDate.Name = "colMatchDate"
        Me.colMatchDate.OptionsColumn.AllowEdit = False
        Me.colMatchDate.Visible = True
        Me.colMatchDate.VisibleIndex = 1
        '
        'colTeam1
        '
        Me.colTeam1.FieldName = "Team1"
        Me.colTeam1.Name = "colTeam1"
        Me.colTeam1.OptionsColumn.AllowEdit = False
        Me.colTeam1.Visible = True
        Me.colTeam1.VisibleIndex = 2
        '
        'colTeam2
        '
        Me.colTeam2.FieldName = "Team2"
        Me.colTeam2.Name = "colTeam2"
        Me.colTeam2.OptionsColumn.AllowEdit = False
        Me.colTeam2.Visible = True
        Me.colTeam2.VisibleIndex = 3
        '
        'colWinner
        '
        Me.colWinner.FieldName = "Winner"
        Me.colWinner.Name = "colWinner"
        Me.colWinner.OptionsColumn.AllowEdit = False
        Me.colWinner.Visible = True
        Me.colWinner.VisibleIndex = 5
        '
        'colClosed
        '
        Me.colClosed.FieldName = "Closed"
        Me.colClosed.Name = "colClosed"
        Me.colClosed.OptionsColumn.AllowEdit = False
        Me.colClosed.Visible = True
        Me.colClosed.VisibleIndex = 6
        '
        'colEvent
        '
        Me.colEvent.FieldName = "Event"
        Me.colEvent.Name = "colEvent"
        Me.colEvent.OptionsColumn.AllowEdit = False
        Me.colEvent.Visible = True
        Me.colEvent.VisibleIndex = 7
        '
        'colBestOf
        '
        Me.colBestOf.FieldName = "BestOf"
        Me.colBestOf.Name = "colBestOf"
        Me.colBestOf.OptionsColumn.AllowEdit = False
        Me.colBestOf.Visible = True
        Me.colBestOf.VisibleIndex = 4
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.GridControl1
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Nothing
        '
        'TblMatchesTableAdapter1
        '
        Me.TblMatchesTableAdapter1.ClearBeforeFill = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.LookUpTeamOne, Me.LookUpTeamTwo, Me.BarHeaderItem1, Me.mnuClearFilter, Me.BarSubItem1, Me.mnuFilterBest1, Me.mnuFilterBest2, Me.mnuFilterBest3, Me.BarSubItem2, Me.d, Me.mnuDateRange, Me.BarSubItem3, Me.BarLargeButtonItem1, Me.BarSubItem4, Me.mnuCheckShowFind, Me.mnuCheckAutoFilter, Me.mnuRefreshMatches, Me.BarButtonItem3, Me.lblStatus})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 22
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.reposTeamOne, Me.reposTeamTwo, Me.RepositoryItemDateEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.LookUpTeamOne, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.LookUpTeamTwo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuClearFilter, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "FILTER:"
        Me.BarHeaderItem1.Id = 4
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'LookUpTeamOne
        '
        Me.LookUpTeamOne.Caption = "Team:"
        Me.LookUpTeamOne.Edit = Me.reposTeamOne
        Me.LookUpTeamOne.Id = 2
        Me.LookUpTeamOne.Name = "LookUpTeamOne"
        Me.LookUpTeamOne.Width = 120
        '
        'reposTeamOne
        '
        Me.reposTeamOne.AutoHeight = False
        Me.reposTeamOne.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reposTeamOne.DropDownRows = 10
        Me.reposTeamOne.Name = "reposTeamOne"
        Me.reposTeamOne.NullText = "[SELECT A TEAM]"
        '
        'LookUpTeamTwo
        '
        Me.LookUpTeamTwo.Caption = "Team:"
        Me.LookUpTeamTwo.Edit = Me.reposTeamTwo
        Me.LookUpTeamTwo.Id = 3
        Me.LookUpTeamTwo.Name = "LookUpTeamTwo"
        Me.LookUpTeamTwo.Width = 120
        '
        'reposTeamTwo
        '
        Me.reposTeamTwo.AutoHeight = False
        Me.reposTeamTwo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reposTeamTwo.DropDownRows = 10
        Me.reposTeamTwo.Name = "reposTeamTwo"
        Me.reposTeamTwo.NullText = "[SELECT A TEAM]"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Advanced Filter"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'mnuClearFilter
        '
        Me.mnuClearFilter.Caption = "Clear Filter"
        Me.mnuClearFilter.Glyph = CType(resources.GetObject("mnuClearFilter.Glyph"), System.Drawing.Image)
        Me.mnuClearFilter.Id = 5
        Me.mnuClearFilter.LargeGlyph = CType(resources.GetObject("mnuClearFilter.LargeGlyph"), System.Drawing.Image)
        Me.mnuClearFilter.Name = "mnuClearFilter"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Filter Presets"
        Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.d)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Best of..."
        Me.BarSubItem2.Id = 11
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuFilterBest1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuFilterBest2), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuFilterBest3)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'mnuFilterBest1
        '
        Me.mnuFilterBest1.Caption = "Best of 1"
        Me.mnuFilterBest1.Id = 8
        Me.mnuFilterBest1.Name = "mnuFilterBest1"
        '
        'mnuFilterBest2
        '
        Me.mnuFilterBest2.Caption = "Best of 2"
        Me.mnuFilterBest2.Id = 9
        Me.mnuFilterBest2.Name = "mnuFilterBest2"
        '
        'mnuFilterBest3
        '
        Me.mnuFilterBest3.Caption = "Best of 3"
        Me.mnuFilterBest3.Id = 10
        Me.mnuFilterBest3.Name = "mnuFilterBest3"
        '
        'd
        '
        Me.d.Caption = "Dates"
        Me.d.Id = 12
        Me.d.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem1)})
        Me.d.Name = "d"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "Show Date Filters"
        Me.BarLargeButtonItem1.Id = 15
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuRefreshMatches)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Options"
        Me.BarSubItem4.Id = 16
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuCheckShowFind)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'mnuCheckShowFind
        '
        Me.mnuCheckShowFind.Caption = "Show Find Box"
        Me.mnuCheckShowFind.Id = 17
        Me.mnuCheckShowFind.Name = "mnuCheckShowFind"
        '
        'mnuRefreshMatches
        '
        Me.mnuRefreshMatches.Caption = "Refresh Matches"
        Me.mnuRefreshMatches.Id = 19
        Me.mnuRefreshMatches.Name = "mnuRefreshMatches"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lblStatus)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(948, 60)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 461)
        Me.barDockControlBottom.Size = New System.Drawing.Size(948, 28)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 60)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 401)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(948, 60)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 401)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'mnuDateRange
        '
        Me.mnuDateRange.Caption = "Select A Date"
        Me.mnuDateRange.Edit = Me.RepositoryItemDateEdit1
        Me.mnuDateRange.Id = 13
        Me.mnuDateRange.Name = "mnuDateRange"
        Me.mnuDateRange.Width = 150
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Specific Date"
        Me.BarSubItem3.Id = 14
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDateRange)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'mnuCheckAutoFilter
        '
        Me.mnuCheckAutoFilter.Caption = "Show Auto Filter Row"
        Me.mnuCheckAutoFilter.Id = 18
        Me.mnuCheckAutoFilter.Name = "mnuCheckAutoFilter"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 20
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'bgWorkerRefreshMatches
        '
        Me.bgWorkerRefreshMatches.WorkerReportsProgress = True
        Me.bgWorkerRefreshMatches.WorkerSupportsCancellation = True
        '
        'tmrBgWorker
        '
        '
        'tmrSetFilterTeamList
        '
        '
        'lblStatus
        '
        Me.lblStatus.Caption = "Status: "
        Me.lblStatus.Id = 21
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'frmMatches
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 489)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmMatches"
        Me.Text = "frmMatches"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCSGLDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gviewMatches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reposTeamOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reposTeamTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gviewMatches As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DbCSGLDataSet1 As CSGL_Beast.dbCSGLDataSet
    Friend WithEvents colMatchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMatchDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeam1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeam2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWinner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBestOf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TblMatchesTableAdapter1 As CSGL_Beast.dbCSGLDataSetTableAdapters.tblMatchesTableAdapter
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents LookUpTeamOne As DevExpress.XtraBars.BarEditItem
    Friend WithEvents reposTeamOne As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUpTeamTwo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents reposTeamTwo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents mnuClearFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuFilterBest1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents mnuFilterBest2 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents mnuFilterBest3 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents d As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuDateRange As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuCheckShowFind As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents mnuCheckAutoFilter As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents mnuRefreshMatches As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bgWorkerRefreshMatches As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrBgWorker As System.Windows.Forms.Timer
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tmrSetFilterTeamList As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As DevExpress.XtraBars.BarStaticItem
End Class
