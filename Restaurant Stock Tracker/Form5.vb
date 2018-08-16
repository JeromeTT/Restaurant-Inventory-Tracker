Imports System.ComponentModel
Imports System.IO
Public Class FormAddItem
	Dim Settings = FormMain.Settings
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
	Private Sub FormAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub

	Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
		If IsValidName(txtItemName.Text) = True Then
			If File.Exists("RestaurantTracker\" & txtItemName.Text & ".txt") = False Then
				Using File.Create("RestaurantTracker\" & Settings("varProjectSelected") & "\" & txtItemName.Text & ".txt")
				End Using
				Call MsgBox("Item Added.")
			Else
				Call MsgBox("Item already exists.")
			End If
		Else
			Call MsgBox("Invalid Name.")
		End If
		Close()
	End Sub

	Private Sub btnAddCancel_Click(sender As Object, e As EventArgs) Handles btnAddCancel.Click
		Close()
	End Sub

	Private Sub FormAddItem_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub
End Class