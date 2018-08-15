Imports System.IO
Public Class FormMain
	Dim projectItemList As New List(Of String)
	Dim countlol As Integer = 0
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


	Private Function monthDataReload()
		costChart.Series(0).Points.Clear()
		dataTest.Rows.Clear()
		countlol = 0
		For Each key In dictItemData
			With key
				If Convert.ToDateTime(key.Value.dataTestDate).Month = newDate.Month Then
					dataTest.Rows.Add(key.Value.dataTestDate.ToString("d MMMM yyyy"), key.Value.dataTestCost, key.Value.dataTestStart, key.Value.dataTestEnd)
					costChart.Series(0).Points.AddXY(countlol, key.Value.dataTestCost)
					countlol += 1
				End If
			End With
		Next

	End Function
	'Updates settings dict WITH values from the file
	Public Sub dictRefresh()
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
	Private Sub fileRefresh()
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
		dictRefresh()
		fileRefresh()
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
		dictItemData.Clear()
		costChart.Series(0).Points.Clear()
		countlol = 0
		If lstItemList.SelectedIndex <> -1 Then
			Using itemFileRead As StreamReader = New StreamReader(Settings("varDirectory") & "\" & Settings("varProjectSelected") & "\" & lstItemList.Text & ".txt")
				Dim countX = 0
				Dim countY = 0
				While itemFileRead.Peek <> -1
					Dim lineSplitArray = itemFileRead.ReadLine().Split(",")
					dataTestAdd(lineSplitArray(0), lineSplitArray(1), lineSplitArray(2), lineSplitArray(3))
				End While
			End Using
			dataTest.Rows.Clear()
		End If
	End Sub

	Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
		'Shows FormSettings and updates settings dict and itemlist on close
		If FormSettings.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictRefresh()
			fileRefresh()
		End If
	End Sub

	Private Sub menuNewStockList_Click(sender As Object, e As EventArgs) Handles menuNewStockList.Click
		'Shows FormNewDataList and updates settings dict and itemlist on close
		If FormNewDataList.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictRefresh()
			fileRefresh()
		End If
	End Sub
	Private Sub OpenDataSetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDataSetsToolStripMenuItem.Click
		'Shows FormDataListSelect and updates settings dict and itemlist on close
		If FormDataListSelect.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictRefresh()
			fileRefresh()
		End If
	End Sub

	Private Sub btnDateBack_Click(sender As Object, e As EventArgs) Handles btnDateBack.Click
		newDate = newDate.AddMonths(-1)
		lblDataDate.Text = newDate.ToString("MMMM yyyy")
		monthDataReload()
	End Sub

	Private Sub btnDateForward_Click(sender As Object, e As EventArgs) Handles btnDateForward.Click
		If newDate.Month < Date.Now.Month Then
			newDate = newDate.AddMonths(1)
			lblDataDate.Text = newDate.ToString("MMMM yyyy")
			monthDataReload()
		End If
	End Sub
End Class


