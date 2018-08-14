Imports System.IO
Public Class FormMain
	Dim projectItemList As New List(Of String)
	Dim listtesting() As Integer = {10, 20, 30, 35, 45, 65, 43, 32, 21, 10, 76, 76, 65, 67, 67, 67, 67, 43, 323, 4, 345, 6, 433, 3, 3}
	Dim testinglist As New List(Of Integer)(listtesting)
	Dim countlol As Integer = 0
	Dim dictItemData As New Dictionary(Of String, testData)

	'Global Settings OwO
	Public Settings As New Dictionary(Of String, String) From
	{
		{"varDirectory", "RestaurantTracker"},
		{"varSettings", "settings.txt"},
		{"varLocalTimeZone", "Eastern Standard Time"},
		{"varProjectsExist", ""},
		{"varProjectSelected", ""}
	}

	Public Class testData
		Public Property dataTestDate As Date
		Public Property dataTestCost As Decimal
		Public Property dataTestStart As Integer
		Public Property dataTestEnd As Integer
	End Class

	Private Sub dataTestAdd(inputDate, inputCost, inputStart, inputEnd)
		If dictItemData.ContainsKey(inputDate) = True Then
			dictItemData.Remove(inputDate)
		End If
		dictItemData.Add(inputDate, New testData With {.dataTestDate = inputDate, .dataTestCost = inputCost, .dataTestStart = inputStart, .dataTestEnd = inputEnd})
	End Sub

	'FUNCTIONS (1)
	'Add settings variables from other forms to main settings form
	Public Function addSettingsVariable(variable, newvalue)
		Dim Settings = Me.Settings
		Settings.Remove(variable)
		Settings.Add(variable, newvalue)
		Using settingswrite As StreamWriter = New StreamWriter(Settings("varDirectory") & "\" & Settings("varSettings"))
			For Each array In Settings
				settingswrite.Write(array.Key & " = " & array.Value & vbNewLine)
			Next
			Return Nothing
		End Using
	End Function

	'Updates settings dictionary
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
			For Each item In dictItemData
				With item
					dataTest.Rows.Add(item.Value.dataTestDate.ToString("d MMMM yyyy"), item.Value.dataTestCost, item.Value.dataTestStart, item.Value.dataTestEnd)
					costChart.Series(0).Points.AddXY(countlol, item.Value.dataTestCost)
					countlol += 1
				End With
			Next
		End If
	End Sub

	Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
		If FormSettings.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictRefresh()
			fileRefresh()
		End If
	End Sub

	Private Sub menuNewStockList_Click(sender As Object, e As EventArgs) Handles menuNewStockList.Click
		If FormNewDataList.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictRefresh()
			fileRefresh()
		End If
	End Sub
	Private Sub OpenDataSetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDataSetsToolStripMenuItem.Click
		If FormDataListSelect.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
			dictRefresh()
			fileRefresh()
		End If
	End Sub
End Class


