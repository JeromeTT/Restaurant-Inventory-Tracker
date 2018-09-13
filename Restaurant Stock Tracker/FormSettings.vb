Public Class FormSettings

	Public timezones As IReadOnlyCollection(Of TimeZoneInfo) = TimeZoneInfo.GetSystemTimeZones()
	Public timezoneIDdict As New Dictionary(Of String, String)
	Dim displayname

	Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CenterToParent()
		'Add each time zone into Dict
		For Each timezone As TimeZoneInfo In timezones
			If timezoneIDdict.ContainsKey(timezone.DisplayName) <> True Then
				timezoneIDdict.Add(timezone.DisplayName, timezone.Id)
			End If
			If timezone.Id = FormMain.Settings("varLocalTimeZone") Then
				displayname = timezone.DisplayName
			End If
		Next
		'Add each time zone to combo box
		For Each item In timezoneIDdict.Keys
			cmbTimeZone.Items.Add(item)
		Next
		cmbTimeZone.Text = displayname
	End Sub

	Private Sub btnUseLocalTimeZone_Click(sender As Object, e As EventArgs) Handles btnUseLocalTimeZone.Click
		Dim timezoneLocal As TimeZoneInfo = TimeZoneInfo.Local
		cmbTimeZone.SelectedIndex = cmbTimeZone.FindString(timezoneLocal.DisplayName)
	End Sub


End Class