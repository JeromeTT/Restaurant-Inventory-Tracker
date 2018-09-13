Imports System.ComponentModel

Public Class FormItemStats
	'Just a data of a random Monday
	Dim varDate As DateTime = Convert.ToDateTime("3/9/2018")
	'Date Format
	Dim varDayOfWeek = varDate.ToString("dddd")

	Public Function updateAllWeeks(val As Integer)
		varDate = varDate.AddDays(val)
		varDayOfWeek = varDate.ToString("dddd")
		lblDayOfWeek.Text = varDayOfWeek
		lblConsumptionHeader.Text = "Average Consumption (" & varDayOfWeek & "):"
		lblRevenueHeader.Text = "Average Revenue (" & varDayOfWeek & "):"
		Dim totalconsumption As Integer = 0
		Dim numberconsumption As Integer = 0
		Dim averageconsumption As Decimal

		Dim totalrevenue As Decimal = 0
		Dim numberrevenue As Integer = 0
		Dim averagerevenue As Decimal
		Select Case cmbMode.SelectedIndex
			Case -1
				Call MsgBox("Please selected a time period from the dropdown box.")
			Case 0
				For Each kvp In FormMain.dictItemData
					If kvp.Key.ToString("dddd") = varDayOfWeek And kvp.Key.Year = Date.Now.Year And kvp.Key.Month = Date.Now.Month Then
						Dim consumption = kvp.Value.dataStart - kvp.Value.dataEnd
						totalconsumption += consumption
						numberconsumption += 1

						totalrevenue += consumption * kvp.Value.dataCost
						numberrevenue += 1
					End If
				Next
			Case 1
				For Each kvp In FormMain.dictItemData
					If kvp.Key.ToString("dddd") = varDayOfWeek And kvp.Key.Year = Date.Now.Year Then
						Dim consumption = kvp.Value.dataStart - kvp.Value.dataEnd
						totalconsumption += consumption
						numberconsumption += 1

						totalrevenue += consumption * kvp.Value.dataCost
						numberrevenue += 1
					End If
				Next
			Case 2
				For Each kvp In FormMain.dictItemData
					If kvp.Key.ToString("dddd") = varDayOfWeek Then
						Dim consumption = kvp.Value.dataStart - kvp.Value.dataEnd
						totalconsumption += consumption
						numberconsumption += 1

						totalrevenue += consumption * kvp.Value.dataCost
						numberrevenue += 1
					End If
				Next
		End Select
		If numberconsumption <> 0 Then
			averageconsumption = Math.Round(totalconsumption / numberconsumption, 2)
		Else averageconsumption = 0
		End If
		If numberrevenue <> 0 Then
			averagerevenue = Math.Round(totalrevenue / numberrevenue, 2)
		Else averagerevenue = 0
		End If

		lblConsumption.Text = averageconsumption.ToString & " units"
		lblRevenue.Text = "$" & averagerevenue.ToString
		Return Nothing
	End Function

	Private Sub FormItemInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cmbMode.Items.Add("current month(" & Date.Now.Month & "/" & Date.Now.Year & ")")
		cmbMode.Items.Add("current year(" & Date.Now.Year & ")")
		cmbMode.Items.Add("all time")
		cmbMode.SelectedIndex = 2
		updateAllWeeks(0)
		CenterToParent()
		lblItemName.Text = FormMain.lstItemList.Text
	End Sub

	Private Sub FormItemInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub

	Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
		updateAllWeeks(1)
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		updateAllWeeks(-1)
	End Sub

	Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
		updateAllWeeks(0)
	End Sub
End Class