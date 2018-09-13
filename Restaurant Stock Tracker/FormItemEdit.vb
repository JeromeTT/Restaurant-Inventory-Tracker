Imports System.ComponentModel
Public Class FormItemEdit
	Dim varClosing As Boolean = False
	'selectedDate is the date of the selected row from datagrid
	Dim selectedDate = Convert.ToDateTime(FormMain.dataMain.SelectedRows(0).Cells(0).Value.ToString)

	''' <summary>
	''' Update display with new dictionary values from date
	''' </summary>
	Public Sub DisplayUpdate()
		Dim itemData As New FormMain.ItemData
		If FormMain.dictItemData.TryGetValue(selectedDate, itemData) Then
			lblDate.Text = itemData.dataDate
			numCost.Value = itemData.dataCost
			numStart.Value = itemData.dataStart
			numEnd.Value = itemData.dataEnd
		Else
			lblDate.Text = selectedDate
			numCost.Value = 0
			numStart.Value = 0
			numEnd.Value = 0
		End If
	End Sub
	''' <summary>Checks if date is valid to go to.</summary>
	''' <param name="int">How many days to add.</param>
	''' <returns>Boolean</returns>
	Public Function CheckIfDateValid(int As Integer) As Boolean
		Dim oldDate = selectedDate
		Dim newDate = selectedDate.AddDays(int)
		Dim oldYearMonth As New DateTime(oldDate.year, oldDate.Month, 1)
		Dim newYearMonth As New DateTime(newDate.year, newDate.Month, 1)
		If newDate > Date.Now Or newYearMonth <> oldYearMonth Then
			Return False
		Else Return True
		End If
	End Function

	Private Sub FormItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		DisplayUpdate()
	End Sub

	Private Sub FormItemEdit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If varClosing = True Then
			e.Cancel = True
			varClosing = False
		Else
			Dispose()
		End If
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If numStart.Value >= numEnd.Value Then
			FormMain.DictItemDataAdd(Convert.ToDateTime(lblDate.Text), numCost.Value, numStart.Value, numEnd.Value)
		Else
			Call MsgBox("Start value must be bigger than the end value.")
			varClosing = True
		End If

	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		If CheckIfDateValid(-1) = True Then
			selectedDate = selectedDate.AddDays(-1)
			DisplayUpdate()
		End If
	End Sub

	Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
		If CheckIfDateValid(1) = True Then
			selectedDate = selectedDate.AddDays(1)
			DisplayUpdate()
		End If
	End Sub
End Class