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
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCSGLDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gviewMatches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(12, 34)
        Me.GridControl1.MainView = Me.gviewMatches
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(791, 371)
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
        Me.gviewMatches.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gviewMatches.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMatchID, Me.colMatchDate, Me.colTeam1, Me.colTeam2, Me.colWinner, Me.colClosed, Me.colEvent, Me.colBestOf})
        Me.gviewMatches.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gviewMatches.GridControl = Me.GridControl1
        Me.gviewMatches.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", Me.colMatchID, "Total Matches In List: {0}")})
        Me.gviewMatches.Name = "gviewMatches"
        Me.gviewMatches.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gviewMatches.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gviewMatches.OptionsPrint.EnableAppearanceOddRow = True
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
        'frmMatches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 417)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmMatches"
        Me.Text = "frmMatches"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCSGLDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gviewMatches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
