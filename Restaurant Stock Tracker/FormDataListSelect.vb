Imports System.ComponentModel
Imports System.IO
Public Class FormDataListSelect
	Private Sub FormDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		Dim Settings = FormMain.Settings
		Dim folderArray As Array = Directory.GetDirectories(Settings("varDirectory"))
		For Each folderdir In folderArray
			Dim folder As New DirectoryInfo(folderdir)
			lstDataList.Items.Add(folder.Name)
		Next
		lstDataList.Sorted = True
	End Sub

	Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
		FormMain.addSettingsVariable("varProjectSelected", lstDataList.SelectedItem)
		Close()
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Close()
	End Sub

	Private Sub FormDataListSelect_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub

End Class