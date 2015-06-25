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
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCSGLDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gviewMatches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 55)
        Me.GridControl1.MainView = Me.gviewMatches
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(815, 340)
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
        Me.gviewMatches.OptionsFind.AlwaysVisible = True
        Me.gviewMatches.OptionsPrint.EnableAppearanceOddRow = True
        Me.gviewMatches.OptionsView.EnableAppearanceEvenRow = True
        Me.gviewMatches.OptionsView.EnableAppearanceOddRow = True
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Advanced Filter"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
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
        Me.barDockControlTop.Size = New System.Drawing.Size(815, 55)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 395)
        Me.barDockControlBottom.Size = New System.Drawing.Size(815, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 55)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 340)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(815, 55)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 340)
        '
        'frmMatches
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 417)
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
End Class
