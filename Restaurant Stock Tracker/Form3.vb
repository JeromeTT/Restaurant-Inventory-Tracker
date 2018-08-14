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

	Private Sub FormNewDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		If IsValidName(txtDLName.Text) = True Then
			Call MsgBox("True")
		Else
			Call MsgBox("Read the instructions big boi. Regex ^[a-zA-Z][a-zA-Z ]+[a-zA-Z]$ and \s\s if you want to break my shet")
		End If
	End Sub

	Private Sub btnCreateCancel_Click(sender As Object, e As EventArgs) Handles btnCreateCancel.Click
		Close()
	End Sub
End Class