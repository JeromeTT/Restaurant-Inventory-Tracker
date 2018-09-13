Public Class FormAbout
	Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
	End Sub

	Private Sub lnkHyperLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHyperLink.LinkClicked
		Process.Start("http://kxrie.me")
	End Sub
End Class