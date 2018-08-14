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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.mnuNavigation = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenDataSetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuNewStockList = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblTime = New System.Windows.Forms.Label()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.lblLoadedDatasetHeader = New System.Windows.Forms.Label()
		Me.lblLoadedDataset = New System.Windows.Forms.Label()
		Me.costChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.TabControl = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.dataTest = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.testinglol = New System.Windows.Forms.TabPage()
		Me.btnTest = New System.Windows.Forms.Button()
		Me.lstItemList = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.mnuNavigation.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.costChart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		CType(Me.dataTest, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage2.SuspendLayout()
		Me.SuspendLayout()
		'
		'mnuNavigation
		'
		Me.mnuNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.mnuNavigation.Location = New System.Drawing.Point(0, 0)
		Me.mnuNavigation.Name = "mnuNavigation"
		Me.mnuNavigation.Size = New System.Drawing.Size(1048, 24)
		Me.mnuNavigation.TabIndex = 0
		Me.mnuNavigation.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDataSetsToolStripMenuItem, Me.menuNewStockList, Me.SaveToolStripMenuItem, Me.QuitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'OpenDataSetsToolStripMenuItem
		'
		Me.OpenDataSetsToolStripMenuItem.Name = "OpenDataSetsToolStripMenuItem"
		Me.OpenDataSetsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
		Me.OpenDataSetsToolStripMenuItem.Text = "Open Stock List"
		'
		'menuNewStockList
		'
		Me.menuNewStockList.Name = "menuNewStockList"
		Me.menuNewStockList.Size = New System.Drawing.Size(156, 22)
		Me.menuNewStockList.Text = "New Stock List"
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
		Me.SaveToolStripMenuItem.Text = "Save"
		'
		'QuitToolStripMenuItem
		'
		Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
		Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
		Me.QuitToolStripMenuItem.Text = "Save and Quit"
		'
		'MenuToolStripMenuItem
		'
		Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
		Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.MenuToolStripMenuItem.Text = "Settings"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "Help"
		'
		'DocumentationToolStripMenuItem
		'
		Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
		Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.DocumentationToolStripMenuItem.Text = "Documentation"
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
		Me.Timer1.Enabled = True
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
		Me.lblLoadedDatasetHeader.Location = New System.Drawing.Point(741, 30)
		Me.lblLoadedDatasetHeader.Name = "lblLoadedDatasetHeader"
		Me.lblLoadedDatasetHeader.Size = New System.Drawing.Size(295, 25)
		Me.lblLoadedDatasetHeader.TabIndex = 4
		Me.lblLoadedDatasetHeader.Text = "Currently Loaded Dataset: "
		'
		'lblLoadedDataset
		'
		Me.lblLoadedDataset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoadedDataset.Location = New System.Drawing.Point(513, 62)
		Me.lblLoadedDataset.Name = "lblLoadedDataset"
		Me.lblLoadedDataset.Size = New System.Drawing.Size(523, 25)
		Me.lblLoadedDataset.TabIndex = 5
		Me.lblLoadedDataset.Text = "Currently Loaded Dataset: "
		Me.lblLoadedDataset.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'costChart
		'
		ChartArea1.AxisX.IsMarginVisible = False
		ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisX.Title = "Day"
		ChartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisY.Title = "Cost ($)"
		ChartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.Name = "CostChart"
		Me.costChart.ChartAreas.Add(ChartArea1)
		Legend1.BackColor = System.Drawing.Color.White
		Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Legend1.IsTextAutoFit = False
		Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
		Legend1.Name = "Legend1"
		Me.costChart.Legends.Add(Legend1)
		Me.costChart.Location = New System.Drawing.Point(6, 25)
		Me.costChart.Name = "costChart"
		Me.costChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
		Series1.ChartArea = "CostChart"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series1.Legend = "Legend1"
		Series1.Name = "Cost"
		Me.costChart.Series.Add(Series1)
		Me.costChart.Size = New System.Drawing.Size(593, 393)
		Me.costChart.TabIndex = 7
		'
		'TabControl
		'
		Me.TabControl.Controls.Add(Me.TabPage1)
		Me.TabControl.Controls.Add(Me.TabPage2)
		Me.TabControl.Controls.Add(Me.testinglol)
		Me.TabControl.Location = New System.Drawing.Point(289, 114)
		Me.TabControl.Name = "TabControl"
		Me.TabControl.SelectedIndex = 0
		Me.TabControl.Size = New System.Drawing.Size(622, 466)
		Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
		Me.TabControl.TabIndex = 8
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.dataTest)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(614, 440)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Data"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'dataTest
		'
		Me.dataTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataTest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
		Me.dataTest.Location = New System.Drawing.Point(3, 3)
		Me.dataTest.Name = "dataTest"
		Me.dataTest.Size = New System.Drawing.Size(590, 431)
		Me.dataTest.TabIndex = 0
		'
		'Column1
		'
		Me.Column1.HeaderText = "Date"
		Me.Column1.Name = "Column1"
		'
		'Column2
		'
		Me.Column2.HeaderText = "Cost"
		Me.Column2.Name = "Column2"
		'
		'Column3
		'
		Me.Column3.HeaderText = "Start Quantity"
		Me.Column3.Name = "Column3"
		'
		'Column4
		'
		Me.Column4.HeaderText = "End Quantity"
		Me.Column4.Name = "Column4"
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.costChart)
		Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TabPage2.Size = New System.Drawing.Size(614, 440)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Cost"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'testinglol
		'
		Me.testinglol.Location = New System.Drawing.Point(4, 22)
		Me.testinglol.Name = "testinglol"
		Me.testinglol.Size = New System.Drawing.Size(614, 440)
		Me.testinglol.TabIndex = 2
		Me.testinglol.Text = "TabPage3"
		Me.testinglol.UseVisualStyleBackColor = True
		'
		'btnTest
		'
		Me.btnTest.Location = New System.Drawing.Point(48, 142)
		Me.btnTest.Name = "btnTest"
		Me.btnTest.Size = New System.Drawing.Size(187, 23)
		Me.btnTest.TabIndex = 9
		Me.btnTest.Text = "btnTest"
		Me.btnTest.UseVisualStyleBackColor = True
		'
		'lstItemList
		'
		Me.lstItemList.FormattingEnabled = True
		Me.lstItemList.Location = New System.Drawing.Point(48, 171)
		Me.lstItemList.Name = "lstItemList"
		Me.lstItemList.Size = New System.Drawing.Size(187, 394)
		Me.lstItemList.TabIndex = 10
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(917, 587)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(119, 13)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Made by Jayden Zhang"
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1048, 657)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lstItemList)
		Me.Controls.Add(Me.btnTest)
		Me.Controls.Add(Me.lblLoadedDataset)
		Me.Controls.Add(Me.lblLoadedDatasetHeader)
		Me.Controls.Add(Me.lblTime)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.mnuNavigation)
		Me.Controls.Add(Me.TabControl)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.mnuNavigation
		Me.Name = "FormMain"
		Me.Text = "Restaurant Inventory Tracker"
		Me.mnuNavigation.ResumeLayout(False)
		Me.mnuNavigation.PerformLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.costChart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		CType(Me.dataTest, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents mnuNavigation As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenDataSetsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents menuNewStockList As ToolStripMenuItem
	Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblDate As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents lblTime As Label
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents lblLoadedDataset As Label
	Friend WithEvents lblLoadedDatasetHeader As Label
	Friend WithEvents costChart As DataVisualization.Charting.Chart
	Friend WithEvents Timer2 As Timer
	Friend WithEvents TabControl As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents btnTest As Button
	Friend WithEvents lstItemList As ListBox
	Friend WithEvents testinglol As TabPage
	Friend WithEvents dataTest As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents Label1 As Label
End Class
