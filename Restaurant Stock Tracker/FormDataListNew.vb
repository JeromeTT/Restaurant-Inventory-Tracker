Imports System.ComponentModel
Imports System.IO
Public Class FormDataListNew
	Dim varClosing = True
	Private Sub FormNewDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		If FormMain.IsValidName(txtInvName.Text) = True Then
			Dim dirName = FormMain.saveDirectory & StrConv(txtInvName.Text, VbStrConv.ProperCase)
			If Directory.Exists(dirName) = False And File.Exists(dirName) = False Then
				Directory.CreateDirectory(dirName)
				Directory.CreateDirectory(dirName & "\" & FormMain.logDirectoryName)
				FormMain.Settings("varProjectSelected") = StrConv(txtInvName.Text, VbStrConv.ProperCase)
				Call MsgBox("File Created.")
			Else
				Call MsgBox("File name already exists.")
				varClosing = False
			End If
		Else
			Call MsgBox("Invalid Name.")
			varClosing = False
		End If
	End Sub

	Private Sub ErrorTimer_Tick(sender As Object, e As EventArgs) Handles tmrError.Tick
		If FormMain.IsValidName(txtInvName.Text) = False Then
			datalistNameError.SetError(txtInvName, "Invalid datalist.")
		Else
			datalistNameError.Dispose()
		End If
	End Sub

	Private Sub txtDLName_TextChanged(sender As Object, e As EventArgs) Handles txtInvName.TextChanged
		tmrError.Start()
	End Sub

	Private Sub FormDataListNew_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If varClosing = False Then
			e.Cancel = True
			varClosing = True
		End If
	End Sub
End Class