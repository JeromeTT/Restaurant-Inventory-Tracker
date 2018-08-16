Imports System.ComponentModel
Imports System.IO
Public Class FormMain
	Dim projectItemList As New List(Of String)
	Dim dictItemData As New Dictionary(Of String, testData)
	Dim newDate As Date = Date.Now
	'Global Settings
	Public Settings As New Dictionary(Of String, String) From
	{
		{"varDirectory", "RestaurantTracker"},
		{"varSettings", "settings.txt"},
		{"varLocalTimeZone", "Eastern Standard Time"},
		{"varProjectsExist", ""},
		{"varProjectSelected", ""}
	}

	'testData is a value from dictionary dictItemData and contains several classes
	Public Class testData
		Public Property dataTestDate As Date
		Public Property dataTestCost As Decimal
		Public Property dataTestStart As Integer
		Public Property dataTestEnd As Integer
	End Class

	'dataTestAdd(inputDate, inputCost, inputStart, inputEnd)
	Private Sub dataTestAdd(inputDate, inputCost, inputStart, inputEnd)
		'Checks if dictionary already contains key and removes if it does
		If dictItemData.ContainsKey(inputDate) = True Then
			dictItemData.Remove(inputDate)
		End If
		'Add new dictonary listing
		dictItemData.Add(inputDate, New testData With {.dataTestDate = inputDate, .dataTestCost = inputCost, .dataTestStart = inputStart, .dataTestEnd = inputEnd})
	End Sub

	'FUNCTIONS (1)
	'Adds new key to settings dict and file
	Public Function addSettingsVariable(key, newvalue)
		'Replaces current dict listing with new key (if applicable)
		Dim Settings = Me.Settings
		Settings.Remove(key)
		Settings.Add(key, newvalue)
		'Updates settings file
		Using settingswrite As StreamWriter = New StreamWriter(Settings("varDirectory") & "\" & Settings("varSettings"))
			For Each array In Settings
				settingswrite.Write(array.Key & " = " & array.Value & vbNewLine)
			Next
			Return Nothing
		End Using
	End Function

	Private Sub monthDataReload()
		costChart.Series(0).Points.Clear()
		consumptionChart.Series(0).Points.Clear()
		dataMain.Rows.Clear()
		Dim countlol = 0
		Dim numDays = DateTime.DaysInMonth(newDate.Year, newDate.Month)
		For dayindex As Integer = 1 To numDays
			Dim listDate = New Date(newDate.Year, newDate.Month, dayindex)
			If listDate <= Date.Today Then
				dataMain.Rows.Add(listDate)
			End If
		Next
		For Each key In dictItemData
			With key
				If Convert.ToDateTime(key.Value.dataTestDate).Month = newDate.Month And Convert.ToDateTime(key.Value.dataTestDate).Year = newDate.Year Then
					For Each row In dataMain.Rows
						If row.Cells(0).Value.ToString = key.Value.dataTestDate Then
							dataMain.Rows.Remove(row)
						End If
					Next
					dataMain.Rows.Add(key.Value.dataTestDate, key.Value.dataTestCost, key.Value.dataTestStart, key.Value.dataTestEnd)

					costChart.Series(0).Points.AddXY(countlol, key.Value.dataTestCost)
					consumptionChart.Series(0).Points.AddXY(countlol, key.Value.dataTestStart - key.Value.dataTestEnd)
					countlol += 1
				End If
			End With
		Next
		For Each row In dataMain.Rows
			If row.Cells(0).Value = Date.Today Then
				row.DefaultCellStyle.BackColor = Color.LightCyan
			End If
		Next
		dataMain.Sort(Column1, ListSortDirection.Descending)
	End Sub

	'Updates settings dict WITH values from the file
	Public Sub dictSettingsRefresh()
		Using settingsRead As StreamReader = New StreamReader(Settings("varDirectory") & "\" & Settings("varSettings"))
			While settingsRead.Peek <> -1
				Dim testarray() = Strings.Split(settingsRead.ReadLine, " = ")
				If Settings.ContainsKey(testarray(0)) Then
					Settings.Remove(testarray(0))
					Settings.Add(testarray(0), testarray(1))
				Else
					Settings.Add(testarray(0), testarray(1))
				End If
			End While
		End Using
		lblLoadedDataset.Text = Settings("varProjectSelected")
	End Sub

	'Gets all files from selected Project directory and lists them in lstItemList
	Private Sub itemListRefresh()
		lstItemList.Items.Clear()
		Dim fileArray As Array = Directory.GetFiles(Settings("varDirectory") & "/" & Settings("varProjectSelected"))
		For Each arrayfile In fileArray
			Dim file As New DirectoryInfo(arrayfile)
			Dim result = file.Name.Split(".")
			lstItemList.Items.Add(result(0))
		Next
	End Sub

	Public Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToScreen()
		dictSettingsRefresh()
		itemListRefresh()
		lblDataDate.Text = newDate.ToString("MMMM yyyy")
		'Creates default directory if it doesn't exist
		If Directory.Exists(Settings("varDirectory")) = False Then
			Directory.CreateDirectory(Settings("varDirectory"))
			File.CreateText(Settings("varDirectory") & "/" & Settings("varSettings"))
		End If
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		'Updates timer every 100 millisecond
		Dim systemDate As Date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.UtcNow, Settings("varLocalTimeZone"))
		lblDate.Text = systemDate.ToString("D")
		lblTime.Text = systemDate.ToString("T")
	End Sub

	Private Sub lstItemList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemList.SelectedIndexChanged
		lblSelectedItem.Text = "Selected Item: " & lstItemList.Text
		dictItemData.Clear()
		costChart.Series(0).Points.Clear()
		Dim countlol = 0
		If lstItemList.SelectedIndex <> -1 Then
			Using itemFileRead As StreamReader = New StreamReader(Settings("varDirectory") & "\" & Settings("varProjectSelected") & "\" & lstItemList.Text & ".txt")
				Dim countX = 0
				Dim countY = 0
				While itemFileRead.Peek <> -1
					Dim lineSplitArray = itemFileRead.ReadLine().Split(",")
					dataTestAdd(lineSplitArray(0), lineSplitArray(1), lineSplitArray(2), lineSplitArray(3))
				End While
			End Using
			dataMain.Rows.Clear()
			monthDataReload()
		End If
	End Sub

	Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
		'Shows FormSettings and updates settings dict and itemlist on close
		If FormSettings.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictSettingsRefresh()
			itemListRefresh()
		End If
	End Sub

	Private Sub menuNewStockList_Click(sender As Object, e As EventArgs) Handles menuNewStockList.Click
		'Shows FormNewDataList and updates settings dict and itemlist on close
		If FormNewDataList.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictSettingsRefresh()
			itemListRefresh()
		End If
	End Sub
	Private Sub OpenDataSetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDataSetsToolStripMenuItem.Click
		'Shows FormDataListSelect and updates settings dict and itemlist on close
		If FormDataListSelect.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictSettingsRefresh()
			itemListRefresh()
		End If
	End Sub

	Private Sub btnDateBack_Click(sender As Object, e As EventArgs) Handles btnDateBack.Click
		newDate = newDate.AddMonths(-1)
		lblDataDate.Text = newDate.ToString("MMMM yyyy")
		monthDataReload()
	End Sub

	Private Sub btnDateForward_Click(sender As Object, e As EventArgs) Handles btnDateForward.Click
		If newDate.Year < Date.Now.Year Then
			newDate = newDate.AddMonths(1)
			lblDataDate.Text = newDate.ToString("MMMM yyyy")
			monthDataReload()
		ElseIf newDate.Month < Date.Now.Month Then
			newDate = newDate.AddMonths(1)
			lblDataDate.Text = newDate.ToString("MMMM yyyy")
			monthDataReload()
		End If
	End Sub

	Private Sub btnItemRemove_Click(sender As Object, e As EventArgs) Handles btnItemRemove.Click
		If lstItemList.SelectedIndex = -1 Then
			Call MsgBox("Please select an item to delete.")
		Else
			My.Computer.FileSystem.DeleteFile(Settings("varDirectory") & "\" & Settings("varProjectSelected") & "\" & lstItemList.Text & ".txt")
			lstItemList.Items.Remove(lstItemList.SelectedItem)
			Call MsgBox("Item removed")
		End If

	End Sub

	Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
		If FormAddItem.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictSettingsRefresh()
			itemListRefresh()
		End If
	End Sub

	Private Sub dataTest_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dataMain.CellValidating
		Select Case e.ColumnIndex
		End Select
	End Sub

	Private Sub cmbConsumption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsumption.SelectedIndexChanged
		Select Case cmbConsumption.Text
			Case "Dot"
				consumptionChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
			Case "Line"
				consumptionChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
			Case "Spline"
				consumptionChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
		End Select
	End Sub

	Private Sub cmbCost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCost.SelectedIndexChanged
		Select Case cmbCost.Text
			Case "Dot"
				costChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
			Case "Line"
				costChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
			Case "Spline"
				costChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
		End Select
	End Sub

	Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
		If FormItemInfo.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictSettingsRefresh()
			itemListRefresh()
		End If
	End Sub

	Private Sub dataMain_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataMain.CellMouseDoubleClick
		Dim index = dataMain.CurrentCell.RowIndex
		Call MsgBox(dataMain.Rows(index).Cells(0).Value)
	End Sub
End Class


