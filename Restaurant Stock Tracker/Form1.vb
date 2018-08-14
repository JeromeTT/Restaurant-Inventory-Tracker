Imports System.IO

Public Class FormMain
	'Global Variable package OwO
	Public Settings As New Dictionary(Of String, String) From
	{
		{"varDirectory", "RestaurantTracker"},
		{"varSettings", "settings.txt"},
		{"varLocalTimeZone", "Eastern Standard Time"}
	}

	'dictItemset Classes
	Public Class inputData
		Public Property inputDate As Date
		Public Property inputName As String
		Public Property inputCost As Integer
		Public Property inputQuantity As Integer
	End Class

	'dictItemset - Dictionary for items
	Dim dictItemset As New Dictionary(Of String, inputData) From
{
		{"Cheese", New inputData With {.inputDate = #5/31/1993#, .inputName = "Cheese", .inputQuantity = 67}},
		{"Toast", New inputData With {.inputDate = #5/31/1993#, .inputName = "Toast", .inputQuantity = 67}},
		{"Bacon", New inputData With {.inputDate = #5/31/1993#, .inputName = "Bacon", .inputQuantity = 67}},
		{"Eggs", New inputData With {.inputDate = #5/31/1993#, .inputName = "Eggs", .inputQuantity = 67}},
		{"Lettuce", New inputData With {.inputDate = #5/31/1993#, .inputName = "Lettuce", .inputQuantity = 67}},
		{"Tomato", New inputData With {.inputDate = #5/31/1993#, .inputName = "Tomato", .inputQuantity = 67}},
		{"Burger", New inputData With {.inputDate = #5/31/1993#, .inputName = "Burger", .inputQuantity = 67}}
}

	'dataAdd(inputDate, inputName, inputQuantity, inputCost) to dictItemset
	Private Sub dataAdd(inputDate, inputName, inputQuantity, inputCost)
		dictItemset.Add(inputName, New inputData With {.inputDate = inputDate, .inputName = inputName, .inputQuantity = inputQuantity, .inputCost = inputCost})
	End Sub

	'CONTAINERS (2)
	'Reload itemset into table
	'Private Sub loadDataset()
	'dgdRawData.Rows.Clear()
	'For each value in itemset add values to the table
	'For Each item In dictItemset
	'With item
	'	dgdRawData.Rows.Add(item.Value.inputName, item.Value.inputCost, item.Value.inputQuantity, item.Value.inputDate)
	'End With
	'Next
	'End Sub

	'Save (NOT USED ATM)
	Private Sub saveDataset()
		'For each value in itemset append it to the text file
		For Each value In dictItemset
			With value
				Using writefile As StreamWriter = File.AppendText(Settings("varDirectory") & "\" & Settings("varSettings") & ".txt")
					'writefile.WriteLine(.inputDate & ", " & .inputName & ", " & .inputQuantity & ", " & .inputCost)
				End Using
			End With
		Next
	End Sub

	'allUpdate() updates 
	Public Sub allUpdate()
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
	End Sub

	'FUNCTIONS (1)
	'Checks if it is correct IsValidName(string) returns boolean


	Public Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToScreen()
		'Creates default directory if it doesn't exist
		allUpdate()
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

	Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
		FormSettings.ShowDialog()
	End Sub



	Private Sub menuNewStockList_Click(sender As Object, e As EventArgs) Handles menuNewStockList.Click
		FormNewDataList.ShowDialog()
	End Sub

	Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		allUpdate()
	End Sub
End Class
