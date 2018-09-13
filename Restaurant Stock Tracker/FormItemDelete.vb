Imports System.ComponentModel
Public Class FormItemDelete
	Private Sub FormItemDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub

	Private Sub timerCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
		If FormMain.lstItemList.Text = txtInput.Text Then
			btnDelete.Enabled = True
		Else
			btnDelete.Enabled = False
		End If
	End Sub

	Private Sub FormItemDelete_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub
End Class