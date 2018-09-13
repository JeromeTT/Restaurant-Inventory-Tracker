Imports System.IO
Public Class FormDataListSelect
	''' <summary>Loads the name of each project into the selection list.</summary>
	Private Sub ListRefresh()
		lstDataList.Items.Clear()
		Dim folderArray As Array = Directory.GetDirectories(FormMain.saveDirectory)
		For Each folderdir In folderArray
			Dim folder As New DirectoryInfo(folderdir)
			lstDataList.Items.Add(folder.Name)
		Next
		lstDataList.Sorted = True
	End Sub

	Private Sub FormDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		ListRefresh()
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		Select Case FormDataListNew.ShowDialog()
			Case DialogResult.Cancel
				With FormDataListNew
					.Close()
					.Dispose()
				End With
			Case DialogResult.OK
				With FormDataListNew
					.Close()
					.Dispose()
				End With
		End Select
		ListRefresh()
	End Sub

	'1000 ms timer
	Private Sub Timer100_Tick(sender As Object, e As EventArgs) Handles Timer100.Tick
		Select Case lstDataList.SelectedIndex
			Case -1
				btnSelect.Enabled = False
			Case <> -1
				btnSelect.Enabled = True
		End Select
	End Sub
End Class