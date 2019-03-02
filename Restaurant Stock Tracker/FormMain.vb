'Restaurant Inventory Tracker
'Made by Jayden Zhang
'Last updated 12:25PM 7/09/2018
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection

Public Class FormMain

	'''need to declare this first
	'''<summary>Global settings dictionary.</summary>
	Public Settings As New Dictionary(Of String, String) From
	{
		{"varDirectory", "RestaurantTracker"},
		{"varSettings", "settings.txt"},
		{"varLocalTimeZone", ""},
		{"varProjectSelected", ""},
		{"varSelectedItem", ""}
	}

	'''<summary>Stores boolean on whether there are unsaved changes</summary>
	Public resultChanged As Boolean = False
	''' <summary>Stores number of edits without saving.</summary>
	Public editCount As Integer = 0

	'''<summary>Name of logDirectory (wow no way)</summary>
	Public logDirectoryName As String = "Logs"
	'''<summary>Global variable of the current save directory.</summary>
	Public saveDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & Settings("varDirectory") & "\"

	'''<summary>Temporary item list while being transfered into item list.</summary>
	Public tempItemList As New List(Of String)

	'''<summary>Variable for the date currently selected by the user. Only Year and Month are used for comparisons.</summary>
	Public varSelectedDate As Date = Date.Now

	'''<summary>Number of points in order for the graph to display</summary>
	Dim graphMinimumPointCount As Integer = 3

	'Used for 'last saved' 
	Dim startTime As Date
	''' <summary> endtime should always equal date.now</summary>
	Dim endTime As Date

	'''<summary>Contains item data from the currently selected item.</summary>
	Public dictItemData As New SortedDictionary(Of Date, ItemData)
	'''<summary>'value' of dictItemData.</summary>
	Public Class ItemData
		Public Property dataDate As Date
		Public Property dataCost As Decimal
		Public Property dataStart As Integer
		Public Property dataEnd As Integer
	End Class


	'SUB why are there so many  >_<
	''' <summary>Checks if input is a valid input. Returns boolean.</summary>
	''' <param name="strInputText">The input to check.</param>
	''' <returns>ischar as Boolean</returns>
	Public Function IsValidName(strInputText As String)
		Dim isChar As Boolean = False
		If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[a-zA-Z][a-zA-Z ]+[a-zA-Z]$") = True And
			System.Text.RegularExpressions.Regex.IsMatch(strInputText, "\s\s") = False And
			strInputText.Length > 30 = False Then
			isChar = True
		Else
			isChar = False
		End If
		Return isChar
	End Function

	''' <summary>Adds data to DictItemData.</summary>
	Public Sub DictItemDataAdd(inputDate As Date, inputCost As Decimal, inputStart As Integer, inputEnd As Integer)
		dictItemData(inputDate) = New ItemData With {.dataDate = inputDate, .dataCost = inputCost, .dataStart = inputStart, .dataEnd = inputEnd}
	End Sub

	'SUBS AS FOLLOWS
	'FILE <---> DICTIONARY/LIST ---> PROGRAM
	'DICTIONARY ---> FILE is the SAVE sub
	'FILE ---> DICTIONARY is the LOAD sub
	'DICTIONARY ---> PROGRAM is the REFRESH save sub
	'it cant go the other way 

	'DICTIONARY(Settings) ---> FILE(settings.txt)
	''' <summary>Writes all data from dictionary into file.</summary>
	Public Sub SaveSettings()
		File.WriteAllText(saveDirectory & Settings("varSettings"), "")
		Using itemFileWrite As StreamWriter = New StreamWriter(saveDirectory & Settings("varSettings"))
			For Each kvp In Settings
				itemFileWrite.Write(kvp.Key & "=" & kvp.Value & vbNewLine)
			Next
		End Using
	End Sub

	'DICTIONARY(dictItemData) ---> FILE(SelectedProject\item.txt)
	''' <summary>Gets dictionary data and saves it to item file.</summary>
	Public Sub SaveItemData()
		File.WriteAllText(saveDirectory & Settings("varProjectSelected") & "\" & lstItemList.Text & ".txt", String.Empty)
		For Each kvp In dictItemData
			Using itemFileWrite As StreamWriter = New StreamWriter(saveDirectory & Settings("varProjectSelected") & "\" & Settings("varSelectedItem") & ".txt")
				For Each pair In dictItemData
					itemFileWrite.Write(pair.Key & "," & pair.Value.dataCost & "," & pair.Value.dataStart & "," & pair.Value.dataEnd & vbNewLine)
				Next
			End Using
		Next
		resultChanged = False
		editCount = 0
	End Sub

	'FILE(settings.txt) ---> DICTIONARY(Settings)
	'''<summary>Gets data FROM the settings file and puts the data in the Settings dictionary.</summary>
	Public Sub LoadDictSettings()
		Using settingsRead As StreamReader = New StreamReader(saveDirectory & Settings("varSettings"))
			While settingsRead.Peek <> -1
				Dim keyValuePair() = Split(settingsRead.ReadLine, "=")
				Settings(keyValuePair(0)) = keyValuePair(1)
			End While
		End Using
	End Sub

	'FILE(datalist directory) ---> DICTIONARY(itemList)
	'''<summary>Gets list of items and syncs to dictionary</summary>
	Public Sub LoadItemList()
		tempItemList.Clear()
		Dim fileArray As Array = Directory.GetFiles(saveDirectory & Settings("varProjectSelected"))
		For Each arrayfile In fileArray
			Dim file As New DirectoryInfo(arrayfile)
			Dim result = file.Name.Split(".")
			tempItemList.Add(result(0))
		Next
	End Sub

	'FILE(SelectedProject\item.txt) ---> DICTIONARY(dictItemData)
	''' <summary>Gets item data from file and syncs it to dictionary.</summary>
	Public Sub LoadItemData()
		dictItemData.Clear()
		If lstItemList.SelectedIndex <> -1 Then
			Using itemFileRead As StreamReader = New StreamReader(saveDirectory & Settings("varProjectSelected") & "\" & lstItemList.Text & ".txt")
				While itemFileRead.Peek <> -1
					Dim lineSplitArray = itemFileRead.ReadLine().Split(",")
					DictItemDataAdd(lineSplitArray(0), lineSplitArray(1), lineSplitArray(2), lineSplitArray(3))
				End While
			End Using
		End If
	End Sub

	'DICTIONARY(itemlist) ---> PROGRAM(lstItemList)
	'''<summary>itemList dictionary to lstItemlis, and highlights selected item</summary>
	Public Sub RefreshItemList()
		lstItemList.Items.Clear()
		For Each item In tempItemList
			lstItemList.Items.Add(item)
		Next
		lstItemList.SelectedItem = Settings("varSelectedItem")
	End Sub

	'DICTIONARY(dictItemSet) ---> PROGRAM(datagrid)
	'''<summary>Populates the datagrid with all the days of the month, followed by data from dictItemData, sorted in descending order.</summary>
	Public Sub RefreshDataGrid()
		lblLoadedDataset.Text = Settings("varProjectSelected")
		dataMain.Rows.Clear()
		'Populate the datagrid with all the days in the selected month
		For dayIndex As Integer = 1 To DateTime.DaysInMonth(varSelectedDate.Year, varSelectedDate.Month)
			Dim listDate = New Date(varSelectedDate.Year, varSelectedDate.Month, dayIndex)
			If listDate <= Date.Today Then
				dataMain.Rows.Add(listDate)
			End If
		Next
		'Populate datagrid with values from dictItemData
		Dim totalcost As Decimal = 0
		For Each key In dictItemData
			If Convert.ToDateTime(key.Value.dataDate).Month = varSelectedDate.Month And Convert.ToDateTime(key.Value.dataDate).Year = varSelectedDate.Year Then
				'Removes each row where there is data
				dataMain.Sort(Column1, ListSortDirection.Ascending)
				Try
					dataMain.Rows.RemoveAt(key.Value.dataDate.Day - 1)
				Catch ex As Exception
				End Try

				dataMain.Rows.Add(key.Value.dataDate, key.Value.dataCost, key.Value.dataStart, key.Value.dataEnd)
				totalcost += key.Value.dataCost * (key.Value.dataStart - key.Value.dataEnd)
			End If
		Next
		dataMain.Sort(Column1, ListSortDirection.Descending)
		'If there is todays date, make it light cyan
		If varSelectedDate.Month = Date.Today.Month And varSelectedDate.Year = Date.Today.Year Then
			dataMain.Rows(0).DefaultCellStyle.BackColor = Color.LightCyan
		End If

		lblRevenue.Text = "Revenue (Monthly):" & vbNewLine & "$" & totalcost
	End Sub

	'DICTIONARY(dictItemSet) ---> PROGRAM(chartCost)
	'''<summary>Refreshes cost chart using values from dictItemSet.</summary>
	Public Sub RefreshChartCost()
		costChart.Series(0).Points.Clear()
		'Puts values into charts
		For Each key In dictItemData
			If Convert.ToDateTime(key.Value.dataDate).Month = varSelectedDate.Month And Convert.ToDateTime(key.Value.dataDate).Year = varSelectedDate.Year Then
				costChart.Series(0).Points.AddXY(key.Value.dataDate.Day, key.Value.dataCost)
			End If
		Next
		'Whether there are enough data points to show the graph
		Select Case costChart.Series(0).Points.Count
			Case < graphMinimumPointCount
				lblCostGraphMsg.Show()
				costChart.Hide()
			Case >= graphMinimumPointCount
				costChart.Show()
				lblCostGraphMsg.Hide()
		End Select
	End Sub

	'DICTIONARY(dictItemSet) ---> PROGRAM(chartConsumption)
	'''<summary>Refreshes consumption chart using values from dictItemSet.</summary>
	Public Sub RefreshChartConsumption()
		consumptionChart.Series(0).Points.Clear()
		For Each key In dictItemData
			If Convert.ToDateTime(key.Value.dataDate).Month = varSelectedDate.Month And Convert.ToDateTime(key.Value.dataDate).Year = varSelectedDate.Year Then
				consumptionChart.Series(0).Points.AddXY(key.Value.dataDate.Day, key.Value.dataStart - key.Value.dataEnd)
			End If
		Next
		Select Case consumptionChart.Series(0).Points.Count
			Case < graphMinimumPointCount
				lblConsumptionGraphMsg.Show()
				consumptionChart.Hide()
			Case >= graphMinimumPointCount
				lblConsumptionGraphMsg.Hide()
				consumptionChart.Show()
		End Select
	End Sub

	'DICTIONARY(dictItemSet) ---> PROGRAM(all 3)
	'''<summary>Refreshes the datagrid and the two charts. </summary>
	Public Sub RefreshTables()
		RefreshDataGrid()
		RefreshChartConsumption()
		RefreshChartCost()
	End Sub

	'''<summary>Run this if the directory does not exist in order to create the directory.</summary>
	Public Sub FirstRun()
		Directory.CreateDirectory(saveDirectory)
		If File.Exists(saveDirectory & Settings("varSettings")) = False Then
			File.CreateText(saveDirectory & Settings("varSettings")).Close()
		End If
		SaveSettings()
	End Sub

	'''<summary>Run this if the directory does not exist in order to create the directory.</summary>
	Public Function CheckProjectSelected() As Boolean
		Dim varReturn As Boolean = False
		Select Case FormDataListSelect.ShowDialog()
			Case DialogResult.OK
				varReturn = True
			Case DialogResult.Cancel
				varReturn = False
		End Select
		Return varReturn
	End Function

	''' <summary>Writes logs into selected inventory list directory.</summary>
	''' <param name="method"> Add, Edit</param>
	''' <param name="itemData">itemdata</param>
	''' <param name="itemName">item name</param>
	Public Function LogWriter(method As String, itemData As ItemData, itemName As String)
		Dim logfilename As String = saveDirectory & Settings("varProjectSelected") & "\" & logDirectoryName & "\" & itemName & ".txt"
		'Using writer As StreamWriter = File.AppendText(logfilename)
		If File.Exists(logfilename) = False Then
			File.Create(logfilename).Close()
		End If
		Select Case method
			Case "Add"
				File.AppendAllText(logfilename, vbNewLine & Date.Now & " - Added new data at date: " & itemData.dataDate & " with Cost as: " & itemData.dataCost & ", Start as: " & itemData.dataStart & ", End as: " & itemData.dataEnd)
			Case "Edit"
				File.AppendAllText(logfilename, vbNewLine & Date.Now & " - Edited data at date: " & itemData.dataDate & " with Cost as: " & itemData.dataCost & ", Start as: " & itemData.dataStart & ", End as: " & itemData.dataEnd)
		End Select
		Return Nothing
	End Function

	''' <summary>Checks for changes of the dictionary compared to the file, and calls log writer to write logs accordingly.</summary>
	Public Sub CheckLogs()
		'Putting all values from file into a new dictionary (to compare)
		Dim dictFromFile As New SortedDictionary(Of Date, ItemData)
		Using reader As StreamReader = New StreamReader(saveDirectory & Settings("varProjectSelected") & "\" & Settings("varSelectedItem") & ".txt")
			While reader.Peek <> -1
				Dim keyValuePair() = Split(reader.ReadLine, ",")
				dictFromFile(keyValuePair(0)) = New ItemData With {.dataDate = keyValuePair(0), .dataCost = keyValuePair(1), .dataStart = keyValuePair(2), .dataEnd = keyValuePair(3)}
			End While
		End Using

		Dim oldvalue As ItemData = Nothing
		Dim newvalue As ItemData = Nothing
		'Iterate through dictItemData to see if the key exists in the new dict
		For Each kvp In dictItemData
			'If key isnt found in the old dict, that means its a new value
			If dictFromFile.TryGetValue(kvp.Key, oldvalue) = False Then
				'Write log because it is a new listing
				LogWriter("Add", kvp.Value, Settings("varSelectedItem"))
				'If key IS found, it still could have been changed
			ElseIf dictFromFile.TryGetValue(kvp.Key, oldvalue) = True Then
				'Puts old data (from file) into oldlist
				'Puts new data (from dict) into newlist
				dictItemData.TryGetValue(kvp.Key, newvalue)
				Dim newdictProperties() = newvalue.GetType().GetProperties
				Dim olddictProperties() = oldvalue.GetType().GetProperties
				Dim newlist As New List(Of String)
				Dim oldlist As New List(Of String)
				For Each iproperty As PropertyInfo In newdictProperties
					newlist.Add(iproperty.GetValue(newvalue, Nothing))
				Next
				For Each iproperty As PropertyInfo In olddictProperties
					oldlist.Add(iproperty.GetValue(oldvalue, Nothing))
				Next

				'Compares oldlist and newlist for differences, if there is difference, put a changelog entry
				For iterate = 0 To newlist.Count - 1
					If newlist(iterate) <> oldlist(iterate) Then
						LogWriter("Edit", newvalue, Settings("varSelectedItem"))
					End If
				Next
			End If
		Next
	End Sub

	''' <summary>Checks if there is unsaved data, then asks user whether they want to save.</summary>
	Public Sub CheckIfSave()
		If resultChanged = True Then
			Dim result As DialogResult = MessageBox.Show("You have unsaved edits. Do you want to save?", "Save?", MessageBoxButtons.YesNo)
			Select Case result
				Case DialogResult.Yes
					CheckLogs()
					SaveItemData()
				Case DialogResult.No
					resultChanged = False
					editCount = 0
			End Select
		End If
	End Sub

	Public Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToScreen()

		'Creates directory and settings if one does not exist already
		If Directory.Exists(saveDirectory) = False Then
			Try
				FirstRun()
			Catch ex As Exception
				'Catching exception probably isnt good code :P
				MessageBox.Show("This program needs access to " & saveDirectory & " in order to run.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				End
			End Try
		End If

		LoadDictSettings()
		If Settings("varProjectSelected") = "" Then
			Select Case CheckProjectSelected()
				Case True
					Settings("varProjectSelected") = FormDataListSelect.lstDataList.Text
					SaveSettings()
					FormDataListSelect.Dispose()
				Case False
					FormDataListSelect.Close()
					FormDataListSelect.Dispose()
					End
			End Select
		End If
		LoadItemList()
		LoadItemData()
		RefreshItemList()
		RefreshTables()
		If Settings("varLocalTimeZone") = "" Then
			Settings("varLocalTimeZone") = TimeZoneInfo.Local.Id
			SaveSettings()
		End If
		lblDataDate.Text = varSelectedDate.ToString("MMMM yyyy")
		Timer1.Start()
	End Sub

	'Updates timer every 100 millisecond
	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		'Update display time 
		Dim systemDate As Date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Date.UtcNow, Settings("varLocalTimeZone"))
		lblDate.Text = systemDate.ToString("D")
		lblTime.Text = systemDate.ToString("T")

		'Limits user interaction with form if item is not selected
		Select Case lstItemList.SelectedIndex
			Case -1
				btnItemRemove.Enabled = False
				PanelMain.Enabled = False
				If lstItemList.Items.Count = 0 Then
					lblSelectedItem.Text = "Please add an item."
				Else
					lblSelectedItem.Text = "Please select an item."
				End If
			Case <> -1
				btnItemRemove.Enabled = True
				PanelMain.Enabled = True
		End Select
		'Updates last saved time
		endTime = Date.Now
		Dim duration As TimeSpan = endTime - startTime
		Select Case duration.TotalSeconds
			Case 0 To 2
				With lblLastSaved
					.ForeColor = Color.LimeGreen
					.Text = "Saved"
				End With
			Case 2 To 60
				With lblLastSaved
					.ForeColor = Color.Black
					.Text = duration.Seconds & " seconds ago"
				End With
			Case 60 To 120
				lblLastSaved.Text = duration.Minutes & " minute ago"
			Case 120 To 3600
				lblLastSaved.Text = duration.Minutes & " minutes ago"
			Case 3601 To 86400
				lblLastSaved.Text = duration.Hours & " hours ago"
			Case Else
				lblLastSaved.Text = ""
		End Select

		'Updates number of unsaved edits
		Select Case resultChanged
			Case True
				With lblUnsavedEdits
					.ForeColor = Color.Red
					.Text = "You have " & editCount & " unsaved edits."
				End With
				btnRevert.Enabled = True
				btnSave.Enabled = True
			Case False
				With lblUnsavedEdits
					.ForeColor = Color.LimeGreen
					.Text = "Up to date."
				End With
				btnRevert.Enabled = False
				btnSave.Enabled = False
		End Select
	End Sub

	Private Sub lstItemList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemList.SelectedIndexChanged
		'Updates the form with new item data from the newly selected item
		CheckIfSave()
		Settings("varSelectedItem") = lstItemList.Text
		SaveSettings()
		lblSelectedItem.Text = "Selected Item: " & lstItemList.Text
		LoadItemData()
		RefreshTables()
		startTime = Nothing
	End Sub

	Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
		CheckIfSave()
		Select Case FormSettings.ShowDialog()
			Case DialogResult.OK
				Dim value As String = ""
				If FormSettings.timezoneIDdict.TryGetValue(FormSettings.cmbTimeZone.SelectedItem, value) Then
					Settings("varLocalTimeZone") = value
					SaveSettings()
					Call MsgBox("Settings have been updated.")
				End If
			Case DialogResult.Cancel
				FormSettings.Close()
		End Select
		FormSettings.Dispose()
	End Sub

	Private Sub menuNewStockList_Click(sender As Object, e As EventArgs) Handles menuNewDataList.Click
		CheckIfSave()
		'Shows FormNewDataList and updates settings dict and itemlist on close
		Select Case FormDataListNew.ShowDialog()
			Case DialogResult.OK
				SaveSettings()
				LoadItemList()
				RefreshItemList()
				RefreshTables()
		End Select
		FormDataListNew.Dispose()
	End Sub

	Private Sub menuOpenDataList_Click(sender As Object, e As EventArgs) Handles menuOpenDataList.Click
		CheckIfSave()
		'Shows FormDataListSelect and updates settings dict and itemlist on close
		Select Case CheckProjectSelected()
			Case True
				Settings("varProjectSelected") = FormDataListSelect.lstDataList.Text
				SaveSettings()
				LoadItemList()
				RefreshItemList()
				RefreshTables()
			Case False
				FormDataListSelect.Close()
		End Select
		FormDataListSelect.Dispose()
	End Sub

	Private Sub btnDateBack_Click(sender As Object, e As EventArgs) Handles btnDateBack.Click
		'Move month back by one
		varSelectedDate = varSelectedDate.AddMonths(-1)
		lblDataDate.Text = varSelectedDate.ToString("MMMM yyyy")
		RefreshTables()
	End Sub

	Private Sub btnDateForward_Click(sender As Object, e As EventArgs) Handles btnDateForward.Click
		'Move month forward by one (if month is not in the future)
		If varSelectedDate.Year < Date.Now.Year Then
			varSelectedDate = varSelectedDate.AddMonths(1)
			lblDataDate.Text = varSelectedDate.ToString("MMMM yyyy")
			RefreshTables()
		ElseIf varSelectedDate.Month < Date.Now.Month Then
			varSelectedDate = varSelectedDate.AddMonths(1)
			lblDataDate.Text = varSelectedDate.ToString("MMMM yyyy")
			RefreshTables()
		End If
	End Sub

	Private Sub btnItemRemove_Click(sender As Object, e As EventArgs) Handles btnItemRemove.Click
		If lstItemList.SelectedIndex = -1 Then
			Call MsgBox("Please select an item to delete.")
		Else
			Select Case FormItemDelete.ShowDialog()
				Case DialogResult.OK
					My.Computer.FileSystem.DeleteFile(saveDirectory & Settings("varProjectSelected") & "\" & lstItemList.Text & ".txt")
					Dim logDir = saveDirectory & Settings("varProjectSelected") & "\" & logDirectoryName & "\" & lstItemList.Text & ".txt"
					If File.Exists(logDir) = True Then
						My.Computer.FileSystem.DeleteFile(logDir)
					End If
					LoadItemList()
					RefreshItemList()
					Call MsgBox("Item removed")
				Case DialogResult.Cancel
					With FormItemDelete
						.Close()
						.Dispose()
					End With
			End Select
		End If
	End Sub

	Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
		Select Case FormItemAdd.ShowDialog()
			Case DialogResult.OK
				FormItemAdd.Close()
			Case DialogResult.Cancel
				With FormItemAdd
					.Close()
					.Dispose()
				End With
		End Select
	End Sub

	Private Sub btnItemSettings_Click(sender As Object, e As EventArgs)
		If FormItemStats.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			LoadDictSettings()
			LoadItemList()
		End If
	End Sub

	Private Sub dataMain_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataMain.CellMouseDoubleClick
		Select Case FormItemEdit.ShowDialog()
			Case DialogResult.OK
				resultChanged = True
				editCount += 1
				RefreshTables()
			Case DialogResult.Cancel
				With FormItemEdit
					.Close()
					.Dispose()
				End With
		End Select
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		FormAbout.ShowDialog()
	End Sub

	Private Sub deleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuDeleteDataList.Click
		If FormDataListDelete.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
			Call MsgBox("Item removed")
		End If
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim result As DialogResult = MessageBox.Show("Are you sure you want to save? You previous save will be overwritten.", "Are you sure?", MessageBoxButtons.YesNo)
		Select Case result
			Case DialogResult.Yes
				CheckLogs()
				SaveItemData()
				startTime = Date.Now
		End Select
	End Sub

	'Graph type select for Consumption
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

	'Graph type select for cost
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

	Private Sub btnRevert_CLick(sender As Object, e As EventArgs) Handles btnRevert.Click
		Dim result As DialogResult = MessageBox.Show("Are you sure you want to revert all your changes? You recent changes will be overwritten.", "Are you sure?", MessageBoxButtons.YesNo)
		Select Case result
			Case DialogResult.Yes
				LoadItemData()
				RefreshTables()
				startTime = Date.Now
				resultChanged = False
				editCount = 0
		End Select
	End Sub

	Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		CheckIfSave()
	End Sub

	Private Sub btnItemStatistics_Click(sender As Object, e As EventArgs) Handles btnItemStatistics.Click
		FormItemStats.ShowDialog()
	End Sub
End Class


