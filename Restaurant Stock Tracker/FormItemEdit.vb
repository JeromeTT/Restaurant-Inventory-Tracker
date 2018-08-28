Imports System.ComponentModel

Public Class FormItemEdit
	Dim datagridValues = FormMain.dataGridValues
	Private Sub FormItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		lblDate.Text = datagridValues(0)
		numCost.Value = datagridValues(1)
		numStart.Value = datagridValues(2)
		numEnd.Value = datagridValues(3)
	End Sub

	Private Sub FormItemEdit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Close()
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If numStart.Value >= numEnd.Value Then
			FormMain.dataTestAdd(datagridValues(0), numCost.Value, numStart.Value, numEnd.Value)
			Close()
		End If
	End Sub
End Class