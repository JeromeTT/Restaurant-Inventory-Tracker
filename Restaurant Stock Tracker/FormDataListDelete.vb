Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class FormDataListDelete

	Private Sub FormDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		lstDataList.Items.Clear()
		Dim folderArray As Array = Directory.GetDirectories(FormMain.saveDirectory)
		For Each folderdir In folderArray
			Dim folder As New DirectoryInfo(folderdir)
			lstDataList.Items.Add(folder.Name)
		Next
		lstDataList.Sorted = True
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If FormDataListDeleteConfirmation.ShowDialog() = DialogResult.OK Then
			My.Computer.FileSystem.DeleteDirectory(FormMain.saveDirectory & lstDataList.Text, DeleteDirectoryOption.DeleteAllContents)

			If lstDataList.Text = FormMain.Settings("varProjectSelected") Then
				With FormMain
					.resultChanged = False
					.editCount = 0
					.Settings("varProjectSelected") = ""
					.Settings("varSelectedItem") = ""
					.SaveSettings()
				End With
				Call MsgBox("Inventory list removed, please select a new data list to open.")
				Select Case FormMain.CheckProjectSelected()
					Case True
						With FormMain
							.Settings("varProjectSelected") = FormDataListSelect.lstDataList.Text
							.SaveSettings()
							.LoadItemList()
							.RefreshItemList()
							.RefreshTables()
						End With
						FormDataListSelect.Dispose()
					Case False
						FormDataListSelect.Close()
						FormDataListSelect.Dispose()
						FormMain.Close()
				End Select
			Else Call MsgBox("Inventory list has been removed.")
			End If
			Close()
		End If
		FormDataListDeleteConfirmation.Dispose()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
		If lstDataList.SelectedIndex = -1 Then
			btnDelete.Enabled = False
		Else btnDelete.Enabled = True
		End If
	End Sub
End Class