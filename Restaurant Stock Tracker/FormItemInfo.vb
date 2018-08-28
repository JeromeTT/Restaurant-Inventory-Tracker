Imports System.ComponentModel

Public Class FormItemInfo
	Private Sub FormItemInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call MsgBox(FormMain.lstItemList.Text)
		CenterToParent()
	End Sub

	Private Sub FormItemInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub
End Class