Imports System.ComponentModel
Imports System.IO
Public Class FormItemAdd
	Dim cancelClose As Boolean = False
	Dim Settings = FormMain.Settings
	'Input check using regex. Returns True/False depending if valid
	Private Sub FormAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub

	Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
		'If input is valid and item doesnt exist, create new item file
		If FormMain.IsValidName(txtItemName.Text) = True Then
			If File.Exists(FormMain.saveDirectory & Settings("varProjectSelected") & "\" & txtItemName.Text & ".txt") = False Then
				File.Create(FormMain.saveDirectory & Settings("varProjectSelected") & "\" & txtItemName.Text & ".txt").Close()
				With FormMain
					.Settings("varSelectedItem") = txtItemName.Text
					.SaveSettings()
					.LoadDictSettings()
					.LoadItemList()
					.RefreshItemList()
				End With
				Call MsgBox("Item Added.")
			Else
				Call MsgBox("Item already exists.")
				cancelClose = True
			End If
		Else
			Call MsgBox("Invalid Name.")
			cancelClose = True
		End If
	End Sub


	Private Sub FormAddItem_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If cancelClose = True Then
			e.Cancel = True
			cancelClose = False
		Else dispose()
		End If
	End Sub

End Class