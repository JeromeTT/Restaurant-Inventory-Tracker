Imports System.ComponentModel
Imports System.IO
Public Class FormNewDataList
	Private Function IsValidName(ByVal strInputText As String) As Boolean
		Dim isChar As Boolean = False
		If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[a-zA-Z][a-zA-Z ]+[a-zA-Z]$") = True And
			System.Text.RegularExpressions.Regex.IsMatch(strInputText, "\s\s") = False Then
			isChar = True
		Else

			isChar = False
		End If
		Return isChar
	End Function

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		If IsValidName(txtDLName.Text) = True Then
			If Directory.Exists("RestaurantTracker/" & txtDLName.Text) = False And File.Exists("RestaurantTracker/" & txtDLName.Text) = False Then
				Directory.CreateDirectory("RestaurantTracker/" & txtDLName.Text)
				Call MsgBox("File Created.")
				FormMain.addSettingsVariable("varProjectSelected", txtDLName.Text)
				Close()
			Else
				Call MsgBox("File name already exists.")
			End If
		Else
			Call MsgBox("Invalid Name.")
		End If
	End Sub

	Private Sub ErroTimer_Tick(sender As Object, e As EventArgs) Handles ErrorTimer.Tick
		If IsValidName(txtDLName.Text) = False Then
			datalistNameError.SetError(txtDLName, "Invalid datalist.")
		Else
			datalistNameError.Dispose()
		End If
	End Sub

	Private Sub txtDLName_TextChanged(sender As Object, e As EventArgs) Handles txtDLName.TextChanged
		ErrorTimer.Start()
	End Sub

	Private Sub btnCreateCancel_Click(sender As Object, e As EventArgs) Handles btnCreateCancel.Click
		Close()
	End Sub

	Private Sub FormNewDataList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub

	Private Sub FormNewDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub
End Class