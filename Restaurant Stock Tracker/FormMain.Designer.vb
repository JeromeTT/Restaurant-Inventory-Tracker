<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.mnuNavigation = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuOpenDataList = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuNewDataList = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuDeleteDataList = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblTime = New System.Windows.Forms.Label()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.lblLoadedDatasetHeader = New System.Windows.Forms.Label()
		Me.lblLoadedDataset = New System.Windows.Forms.Label()
		Me.lstItemList = New System.Windows.Forms.ListBox()
		Me.lblDataDate = New System.Windows.Forms.Label()
		Me.btnDateForward = New System.Windows.Forms.Button()
		Me.btnItemAdd = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnItemRemove = New System.Windows.Forms.Button()
		Me.lblSelectedItem = New System.Windows.Forms.Label()
		Me.btnDateBack = New System.Windows.Forms.Button()
		Me.PanelMain = New System.Windows.Forms.Panel()
		Me.btnItemStatistics = New System.Windows.Forms.Button()
		Me.TabControl = New System.Windows.Forms.TabControl()
		Me.TabData = New System.Windows.Forms.TabPage()
		Me.lblRevenue = New System.Windows.Forms.Label()
		Me.lblUnsavedEdits = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblLastSaved = New System.Windows.Forms.Label()
		Me.btnRevert = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.dataMain = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TabCost = New System.Windows.Forms.TabPage()
		Me.lblCostGraphMsg = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbCost = New System.Windows.Forms.ComboBox()
		Me.costChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.TabConsumption = New System.Windows.Forms.TabPage()
		Me.lblConsumptionGraphMsg = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cmbConsumption = New System.Windows.Forms.ComboBox()
		Me.consumptionChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.mnuNavigation.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelMain.SuspendLayout()
		Me.TabControl.SuspendLayout()
		Me.TabData.SuspendLayout()
		CType(Me.dataMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabCost.SuspendLayout()
		CType(Me.costChart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabConsumption.SuspendLayout()
		CType(Me.consumptionChart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'mnuNavigation
		'
		Me.mnuNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem})
		Me.mnuNavigation.Location = New System.Drawing.Point(0, 0)
		Me.mnuNavigation.Name = "mnuNavigation"
		Me.mnuNavigation.Size = New System.Drawing.Size(935, 24)
		Me.mnuNavigation.TabIndex = 0
		Me.mnuNavigation.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpenDataList, Me.menuNewDataList, Me.menuDeleteDataList})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'menuOpenDataList
		'
		Me.menuOpenDataList.Name = "menuOpenDataList"
		Me.menuOpenDataList.Size = New System.Drawing.Size(180, 22)
		Me.menuOpenDataList.Text = "Open Stock List"
		'
		'menuNewDataList
		'
		Me.menuNewDataList.Name = "menuNewDataList"
		Me.menuNewDataList.Size = New System.Drawing.Size(180, 22)
		Me.menuNewDataList.Text = "New Stock List"
		'
		'menuDeleteDataList
		'
		Me.menuDeleteDataList.Name = "menuDeleteDataList"
		Me.menuDeleteDataList.Size = New System.Drawing.Size(180, 22)
		Me.menuDeleteDataList.Text = "Delete Stock List"
		'
		'MenuToolStripMenuItem
		'
		Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
		Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.MenuToolStripMenuItem.Text = "Settings"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.AboutToolStripMenuItem.Text = "About"
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDate.Location = New System.Drawing.Point(27, 34)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(58, 20)
		Me.lblDate.TabIndex = 1
		Me.lblDate.Text = "[Date]"
		'
		'Timer1
		'
		'
		'lblTime
		'
		Me.lblTime.AutoSize = True
		Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTime.Location = New System.Drawing.Point(27, 66)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(57, 20)
		Me.lblTime.TabIndex = 2
		Me.lblTime.Text = "[Time]"
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'lblLoadedDatasetHeader
		'
		Me.lblLoadedDatasetHeader.AutoSize = True
		Me.lblLoadedDatasetHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoadedDatasetHeader.Location = New System.Drawing.Point(626, 29)
		Me.lblLoadedDatasetHeader.Name = "lblLoadedDatasetHeader"
		Me.lblLoadedDatasetHeader.Size = New System.Drawing.Size(295, 25)
		Me.lblLoadedDatasetHeader.TabIndex = 4
		Me.lblLoadedDatasetHeader.Text = "Currently Loaded Dataset: "
		'
		'lblLoadedDataset
		'
		Me.lblLoadedDataset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoadedDataset.Location = New System.Drawing.Point(398, 54)
		Me.lblLoadedDataset.Name = "lblLoadedDataset"
		Me.lblLoadedDataset.Size = New System.Drawing.Size(523, 25)
		Me.lblLoadedDataset.TabIndex = 5
		Me.lblLoadedDataset.Text = "Currently Loaded Dataset: "
		Me.lblLoadedDataset.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lstItemList
		'
		Me.lstItemList.FormattingEnabled = True
		Me.lstItemList.Location = New System.Drawing.Point(31, 132)
		Me.lstItemList.Name = "lstItemList"
		Me.lstItemList.Size = New System.Drawing.Size(187, 329)
		Me.lstItemList.TabIndex = 10
		'
		'lblDataDate
		'
		Me.lblDataDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDataDate.Location = New System.Drawing.Point(84, 9)
		Me.lblDataDate.Name = "lblDataDate"
		Me.lblDataDate.Size = New System.Drawing.Size(161, 20)
		Me.lblDataDate.TabIndex = 12
		Me.lblDataDate.Text = "wow coool!"
		Me.lblDataDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnDateForward
		'
		Me.btnDateForward.Location = New System.Drawing.Point(251, 9)
		Me.btnDateForward.Name = "btnDateForward"
		Me.btnDateForward.Size = New System.Drawing.Size(75, 23)
		Me.btnDateForward.TabIndex = 2
		Me.btnDateForward.Text = ">>>>>"
		Me.btnDateForward.UseVisualStyleBackColor = True
		'
		'btnItemAdd
		'
		Me.btnItemAdd.Location = New System.Drawing.Point(31, 467)
		Me.btnItemAdd.Name = "btnItemAdd"
		Me.btnItemAdd.Size = New System.Drawing.Size(187, 49)
		Me.btnItemAdd.TabIndex = 13
		Me.btnItemAdd.Text = "Add Item"
		Me.btnItemAdd.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(27, 103)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(86, 24)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Item List"
		'
		'btnItemRemove
		'
		Me.btnItemRemove.Location = New System.Drawing.Point(31, 522)
		Me.btnItemRemove.Name = "btnItemRemove"
		Me.btnItemRemove.Size = New System.Drawing.Size(187, 39)
		Me.btnItemRemove.TabIndex = 15
		Me.btnItemRemove.Text = "Remove Item"
		Me.btnItemRemove.UseVisualStyleBackColor = True
		'
		'lblSelectedItem
		'
		Me.lblSelectedItem.AutoSize = True
		Me.lblSelectedItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSelectedItem.Location = New System.Drawing.Point(224, 103)
		Me.lblSelectedItem.Name = "lblSelectedItem"
		Me.lblSelectedItem.Size = New System.Drawing.Size(143, 24)
		Me.lblSelectedItem.TabIndex = 16
		Me.lblSelectedItem.Text = "Selected Item:"
		'
		'btnDateBack
		'
		Me.btnDateBack.Location = New System.Drawing.Point(3, 6)
		Me.btnDateBack.Name = "btnDateBack"
		Me.btnDateBack.Size = New System.Drawing.Size(75, 23)
		Me.btnDateBack.TabIndex = 1
		Me.btnDateBack.Text = "<<<<<"
		Me.btnDateBack.UseVisualStyleBackColor = True
		'
		'PanelMain
		'
		Me.PanelMain.Controls.Add(Me.btnItemStatistics)
		Me.PanelMain.Controls.Add(Me.TabControl)
		Me.PanelMain.Controls.Add(Me.btnDateBack)
		Me.PanelMain.Controls.Add(Me.lblDataDate)
		Me.PanelMain.Controls.Add(Me.btnDateForward)
		Me.PanelMain.Location = New System.Drawing.Point(228, 132)
		Me.PanelMain.Name = "PanelMain"
		Me.PanelMain.Size = New System.Drawing.Size(700, 436)
		Me.PanelMain.TabIndex = 2
		'
		'btnItemStatistics
		'
		Me.btnItemStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnItemStatistics.Location = New System.Drawing.Point(536, 9)
		Me.btnItemStatistics.Name = "btnItemStatistics"
		Me.btnItemStatistics.Size = New System.Drawing.Size(157, 42)
		Me.btnItemStatistics.TabIndex = 0
		Me.btnItemStatistics.Text = "Item Statistics"
		Me.btnItemStatistics.UseVisualStyleBackColor = True
		'
		'TabControl
		'
		Me.TabControl.Controls.Add(Me.TabData)
		Me.TabControl.Controls.Add(Me.TabCost)
		Me.TabControl.Controls.Add(Me.TabConsumption)
		Me.TabControl.Location = New System.Drawing.Point(3, 38)
		Me.TabControl.Margin = New System.Windows.Forms.Padding(0)
		Me.TabControl.Name = "TabControl"
		Me.TabControl.SelectedIndex = 0
		Me.TabControl.Size = New System.Drawing.Size(697, 398)
		Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
		Me.TabControl.TabIndex = 8
		'
		'TabData
		'
		Me.TabData.Controls.Add(Me.lblRevenue)
		Me.TabData.Controls.Add(Me.lblUnsavedEdits)
		Me.TabData.Controls.Add(Me.Label6)
		Me.TabData.Controls.Add(Me.lblLastSaved)
		Me.TabData.Controls.Add(Me.btnRevert)
		Me.TabData.Controls.Add(Me.Label5)
		Me.TabData.Controls.Add(Me.btnSave)
		Me.TabData.Controls.Add(Me.dataMain)
		Me.TabData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabData.Location = New System.Drawing.Point(4, 22)
		Me.TabData.Name = "TabData"
		Me.TabData.Padding = New System.Windows.Forms.Padding(3)
		Me.TabData.Size = New System.Drawing.Size(689, 372)
		Me.TabData.TabIndex = 0
		Me.TabData.Text = "Data"
		Me.TabData.UseVisualStyleBackColor = True
		'
		'lblRevenue
		'
		Me.lblRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lblRevenue.Location = New System.Drawing.Point(3, 25)
		Me.lblRevenue.Name = "lblRevenue"
		Me.lblRevenue.Size = New System.Drawing.Size(279, 50)
		Me.lblRevenue.TabIndex = 13
		Me.lblRevenue.Text = "Revenue (Monthly) :"
		'
		'lblUnsavedEdits
		'
		Me.lblUnsavedEdits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUnsavedEdits.Location = New System.Drawing.Point(9, 65)
		Me.lblUnsavedEdits.Name = "lblUnsavedEdits"
		Me.lblUnsavedEdits.Size = New System.Drawing.Size(524, 25)
		Me.lblUnsavedEdits.TabIndex = 23
		Me.lblUnsavedEdits.Text = "-"
		Me.lblUnsavedEdits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(396, 8)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(137, 25)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Last saved:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblLastSaved
		'
		Me.lblLastSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLastSaved.Location = New System.Drawing.Point(9, 33)
		Me.lblLastSaved.Name = "lblLastSaved"
		Me.lblLastSaved.Size = New System.Drawing.Size(524, 25)
		Me.lblLastSaved.TabIndex = 18
		Me.lblLastSaved.Text = "Last saved:"
		Me.lblLastSaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnRevert
		'
		Me.btnRevert.Location = New System.Drawing.Point(539, 56)
		Me.btnRevert.Name = "btnRevert"
		Me.btnRevert.Size = New System.Drawing.Size(147, 42)
		Me.btnRevert.TabIndex = 20
		Me.btnRevert.Text = "Revert Changes"
		Me.btnRevert.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(6, 3)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(222, 18)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "Double click any row to edit."
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(539, 6)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(147, 42)
		Me.btnSave.TabIndex = 19
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'dataMain
		'
		Me.dataMain.AllowUserToAddRows = False
		Me.dataMain.AllowUserToDeleteRows = False
		Me.dataMain.AllowUserToResizeColumns = False
		Me.dataMain.AllowUserToResizeRows = False
		Me.dataMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dataMain.BackgroundColor = System.Drawing.Color.White
		Me.dataMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
		Me.dataMain.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.dataMain.Location = New System.Drawing.Point(3, 104)
		Me.dataMain.Name = "dataMain"
		Me.dataMain.ReadOnly = True
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle2.NullValue = Nothing
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.dataMain.RowHeadersVisible = False
		Me.dataMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataMain.Size = New System.Drawing.Size(683, 265)
		Me.dataMain.TabIndex = 0
		'
		'Column1
		'
		DataGridViewCellStyle1.Format = "d MMMM yyyy"
		DataGridViewCellStyle1.NullValue = Nothing
		Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
		Me.Column1.HeaderText = "Date"
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		Me.Column1.Width = 169
		'
		'Column2
		'
		Me.Column2.HeaderText = "Selling Cost ($)"
		Me.Column2.Name = "Column2"
		Me.Column2.ReadOnly = True
		Me.Column2.Width = 170
		'
		'Column3
		'
		Me.Column3.HeaderText = "Start Quantity"
		Me.Column3.Name = "Column3"
		Me.Column3.ReadOnly = True
		Me.Column3.Width = 169
		'
		'Column4
		'
		Me.Column4.HeaderText = "End Quantity"
		Me.Column4.Name = "Column4"
		Me.Column4.ReadOnly = True
		Me.Column4.Width = 169
		'
		'TabCost
		'
		Me.TabCost.Controls.Add(Me.lblCostGraphMsg)
		Me.TabCost.Controls.Add(Me.Label3)
		Me.TabCost.Controls.Add(Me.cmbCost)
		Me.TabCost.Controls.Add(Me.costChart)
		Me.TabCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabCost.Location = New System.Drawing.Point(4, 22)
		Me.TabCost.Name = "TabCost"
		Me.TabCost.Padding = New System.Windows.Forms.Padding(3)
		Me.TabCost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TabCost.Size = New System.Drawing.Size(689, 372)
		Me.TabCost.TabIndex = 1
		Me.TabCost.Text = "Cost"
		Me.TabCost.UseVisualStyleBackColor = True
		'
		'lblCostGraphMsg
		'
		Me.lblCostGraphMsg.AutoSize = True
		Me.lblCostGraphMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCostGraphMsg.Location = New System.Drawing.Point(6, 12)
		Me.lblCostGraphMsg.Name = "lblCostGraphMsg"
		Me.lblCostGraphMsg.Size = New System.Drawing.Size(431, 25)
		Me.lblCostGraphMsg.TabIndex = 19
		Me.lblCostGraphMsg.Text = "Not enough data points for visualization"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(559, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(85, 18)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Graph Type"
		'
		'cmbCost
		'
		Me.cmbCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCost.FormattingEnabled = True
		Me.cmbCost.Items.AddRange(New Object() {"Dot", "Line", "Spline"})
		Me.cmbCost.Location = New System.Drawing.Point(559, 53)
		Me.cmbCost.Name = "cmbCost"
		Me.cmbCost.Size = New System.Drawing.Size(121, 26)
		Me.cmbCost.TabIndex = 8
		'
		'costChart
		'
		ChartArea1.AxisX.IsMarginVisible = False
		ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisX.Title = "Day"
		ChartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisY.Title = "Selling Cost ($)"
		ChartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.Name = "CostChart"
		Me.costChart.ChartAreas.Add(ChartArea1)
		Me.costChart.Dock = System.Windows.Forms.DockStyle.Left
		Me.costChart.Location = New System.Drawing.Point(3, 3)
		Me.costChart.Name = "costChart"
		Me.costChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
		Series1.ChartArea = "CostChart"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
		Series1.MarkerColor = System.Drawing.Color.Red
		Series1.Name = "Cost"
		Me.costChart.Series.Add(Series1)
		Me.costChart.Size = New System.Drawing.Size(550, 366)
		Me.costChart.TabIndex = 7
		'
		'TabConsumption
		'
		Me.TabConsumption.Controls.Add(Me.lblConsumptionGraphMsg)
		Me.TabConsumption.Controls.Add(Me.Label4)
		Me.TabConsumption.Controls.Add(Me.cmbConsumption)
		Me.TabConsumption.Controls.Add(Me.consumptionChart)
		Me.TabConsumption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabConsumption.Location = New System.Drawing.Point(4, 22)
		Me.TabConsumption.Name = "TabConsumption"
		Me.TabConsumption.Size = New System.Drawing.Size(689, 372)
		Me.TabConsumption.TabIndex = 2
		Me.TabConsumption.Text = "Consumption"
		Me.TabConsumption.UseVisualStyleBackColor = True
		'
		'lblConsumptionGraphMsg
		'
		Me.lblConsumptionGraphMsg.AutoSize = True
		Me.lblConsumptionGraphMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConsumptionGraphMsg.Location = New System.Drawing.Point(3, 10)
		Me.lblConsumptionGraphMsg.Name = "lblConsumptionGraphMsg"
		Me.lblConsumptionGraphMsg.Size = New System.Drawing.Size(431, 25)
		Me.lblConsumptionGraphMsg.TabIndex = 20
		Me.lblConsumptionGraphMsg.Text = "Not enough data points for visualization"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(553, 28)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(85, 18)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Graph Type"
		'
		'cmbConsumption
		'
		Me.cmbConsumption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbConsumption.FormattingEnabled = True
		Me.cmbConsumption.Items.AddRange(New Object() {"Dot", "Line", "Spline"})
		Me.cmbConsumption.Location = New System.Drawing.Point(556, 49)
		Me.cmbConsumption.Name = "cmbConsumption"
		Me.cmbConsumption.Size = New System.Drawing.Size(121, 26)
		Me.cmbConsumption.TabIndex = 10
		'
		'consumptionChart
		'
		ChartArea2.AxisX.IsMarginVisible = False
		ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea2.AxisX.Title = "Day"
		ChartArea2.AxisX2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea2.AxisY.Title = "Quantity"
		ChartArea2.AxisY2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea2.Name = "CostChart"
		Me.consumptionChart.ChartAreas.Add(ChartArea2)
		Me.consumptionChart.Dock = System.Windows.Forms.DockStyle.Left
		Me.consumptionChart.Location = New System.Drawing.Point(0, 0)
		Me.consumptionChart.Name = "consumptionChart"
		Me.consumptionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
		Series2.ChartArea = "CostChart"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
		Series2.MarkerColor = System.Drawing.Color.Red
		Series2.MarkerImageTransparentColor = System.Drawing.Color.White
		Series2.Name = "Cost"
		Me.consumptionChart.Series.Add(Series2)
		Me.consumptionChart.Size = New System.Drawing.Size(550, 372)
		Me.consumptionChart.TabIndex = 8
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(935, 580)
		Me.Controls.Add(Me.PanelMain)
		Me.Controls.Add(Me.lblSelectedItem)
		Me.Controls.Add(Me.btnItemRemove)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnItemAdd)
		Me.Controls.Add(Me.lstItemList)
		Me.Controls.Add(Me.lblLoadedDataset)
		Me.Controls.Add(Me.lblLoadedDatasetHeader)
		Me.Controls.Add(Me.lblTime)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.mnuNavigation)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mnuNavigation
		Me.MaximizeBox = False
		Me.Name = "FormMain"
		Me.Text = "Restaurant Inventory Tracker"
		Me.mnuNavigation.ResumeLayout(False)
		Me.mnuNavigation.PerformLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelMain.ResumeLayout(False)
		Me.TabControl.ResumeLayout(False)
		Me.TabData.ResumeLayout(False)
		Me.TabData.PerformLayout()
		CType(Me.dataMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabCost.ResumeLayout(False)
		Me.TabCost.PerformLayout()
		CType(Me.costChart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabConsumption.ResumeLayout(False)
		Me.TabConsumption.PerformLayout()
		CType(Me.consumptionChart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents mnuNavigation As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents menuOpenDataList As ToolStripMenuItem
	Friend WithEvents menuNewDataList As ToolStripMenuItem
	Friend WithEvents menuDeleteDataList As ToolStripMenuItem
	Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblDate As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents lblTime As Label
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents lblLoadedDataset As Label
	Friend WithEvents lblLoadedDatasetHeader As Label
	Friend WithEvents lstItemList As ListBox
	Friend WithEvents lblDataDate As Label
	Friend WithEvents btnDateForward As Button
	Friend WithEvents btnItemRemove As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents btnItemAdd As Button
	Friend WithEvents lblSelectedItem As Label
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PanelMain As Panel
	Friend WithEvents btnDateBack As Button
	Friend WithEvents btnItemStatistics As Button
	Private WithEvents TabControl As TabControl
	Friend WithEvents TabData As TabPage
	Friend WithEvents lblRevenue As Label
	Friend WithEvents lblUnsavedEdits As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblLastSaved As Label
	Friend WithEvents btnRevert As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents dataMain As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents TabCost As TabPage
	Friend WithEvents lblCostGraphMsg As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents cmbCost As ComboBox
	Friend WithEvents costChart As DataVisualization.Charting.Chart
	Friend WithEvents TabConsumption As TabPage
	Friend WithEvents lblConsumptionGraphMsg As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents cmbConsumption As ComboBox
	Friend WithEvents consumptionChart As DataVisualization.Charting.Chart
End Class
