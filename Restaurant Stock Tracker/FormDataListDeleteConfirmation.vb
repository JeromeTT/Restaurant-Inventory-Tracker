Public Class FormDataListDeleteConfirmation
	Private Sub FormDataListDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub

	Private Sub timerCheck_Tick(sender As Object, e As EventArgs) Handles timerCheck.Tick
		If FormDataListDelete.lstDataList.Text = StrConv(txtInput.Text, VbStrConv.ProperCase) Then
			btnDelete.Enabled = True
		Else btnDelete.Enabled = False
		End If
	End Sub
End Class