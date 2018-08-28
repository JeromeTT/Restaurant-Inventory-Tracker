Imports System.ComponentModel
Imports System.IO
Public Class FormSettings

	'Declare
	Dim timezones As IReadOnlyCollection(Of TimeZoneInfo) = TimeZoneInfo.GetSystemTimeZones()
	Dim timezoneIDdict As New Dictionary(Of String, String)
	Dim displayname

	'Form load
	Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		Dim Settings = FormMain.Settings
		'Add each time zone into Dict
		For Each timezone As TimeZoneInfo In timezones
			If timezoneIDdict.ContainsKey(timezone.DisplayName) <> True Then
				timezoneIDdict.Add(timezone.DisplayName, timezone.Id)
			End If
			If timezone.Id = Settings("varLocalTimeZone") Then
				displayname = timezone.DisplayName
			End If
		Next

		For Each item In timezoneIDdict.Keys
			cmbTimeZone.Items.Add(item)
		Next
		cmbTimeZone.Text = displayname
	End Sub

	Private Sub btnUseLocalTimeZone_Click(sender As Object, e As EventArgs) Handles btnUseLocalTimeZone.Click
		Dim timezoneLocal As TimeZoneInfo = TimeZoneInfo.Local
		cmbTimeZone.SelectedIndex = cmbTimeZone.FindString(timezoneLocal.DisplayName)
	End Sub

	Private Sub btnSettingsSave_Click(sender As Object, e As EventArgs) Handles btnSettingsSave.Click
		Dim value As String = ""
		If timezoneIDdict.TryGetValue(cmbTimeZone.SelectedItem, value) Then
			FormMain.addSettingsVariable("varLocalTimeZone", value)
			Call MsgBox("Settings have been updated.")
			Hide()
		End If
	End Sub
	Private Sub btnSettingCancel_Click(sender As Object, e As EventArgs) Handles btnSettingCancel.Click
		Hide()
	End Sub

	Private Sub FormSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dispose()
	End Sub
End Class