<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.lblSettingsHeader = New System.Windows.Forms.Label()
		Me.lblSettingsTimeZone = New System.Windows.Forms.Label()
		Me.cmbTimeZone = New System.Windows.Forms.ComboBox()
		Me.btnUseLocalTimeZone = New System.Windows.Forms.Button()
		Me.btnSettingCancel = New System.Windows.Forms.Button()
		Me.btnSettingsSave = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblSettingsHeader
		'
		Me.lblSettingsHeader.AutoSize = True
		Me.lblSettingsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSettingsHeader.Location = New System.Drawing.Point(12, 9)
		Me.lblSettingsHeader.Name = "lblSettingsHeader"
		Me.lblSettingsHeader.Size = New System.Drawing.Size(98, 25)
		Me.lblSettingsHeader.TabIndex = 1
		Me.lblSettingsHeader.Text = "Settings"
		'
		'lblSettingsTimeZone
		'
		Me.lblSettingsTimeZone.AutoSize = True
		Me.lblSettingsTimeZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSettingsTimeZone.Location = New System.Drawing.Point(34, 52)
		Me.lblSettingsTimeZone.Name = "lblSettingsTimeZone"
		Me.lblSettingsTimeZone.Size = New System.Drawing.Size(76, 16)
		Me.lblSettingsTimeZone.TabIndex = 2
		Me.lblSettingsTimeZone.Text = "Time Zone:"
		'
		'cmbTimeZone
		'
		Me.cmbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTimeZone.FormattingEnabled = True
		Me.cmbTimeZone.Location = New System.Drawing.Point(116, 51)
		Me.cmbTimeZone.Name = "cmbTimeZone"
		Me.cmbTimeZone.Size = New System.Drawing.Size(296, 21)
		Me.cmbTimeZone.TabIndex = 3
		'
		'btnUseLocalTimeZone
		'
		Me.btnUseLocalTimeZone.Location = New System.Drawing.Point(432, 52)
		Me.btnUseLocalTimeZone.Name = "btnUseLocalTimeZone"
		Me.btnUseLocalTimeZone.Size = New System.Drawing.Size(117, 21)
		Me.btnUseLocalTimeZone.TabIndex = 4
		Me.btnUseLocalTimeZone.Text = "Use Local Time Zone"
		Me.btnUseLocalTimeZone.UseVisualStyleBackColor = True
		'
		'btnSettingCancel
		'
		Me.btnSettingCancel.Location = New System.Drawing.Point(207, 101)
		Me.btnSettingCancel.Name = "btnSettingCancel"
		Me.btnSettingCancel.Size = New System.Drawing.Size(95, 26)
		Me.btnSettingCancel.TabIndex = 5
		Me.btnSettingCancel.Text = "Cancel"
		Me.btnSettingCancel.UseVisualStyleBackColor = True
		'
		'btnSettingsSave
		'
		Me.btnSettingsSave.Location = New System.Drawing.Point(337, 101)
		Me.btnSettingsSave.Name = "btnSettingsSave"
		Me.btnSettingsSave.Size = New System.Drawing.Size(95, 26)
		Me.btnSettingsSave.TabIndex = 6
		Me.btnSettingsSave.Text = "Save"
		Me.btnSettingsSave.UseVisualStyleBackColor = True
		'
		'FormSettings
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(634, 161)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnSettingsSave)
		Me.Controls.Add(Me.btnSettingCancel)
		Me.Controls.Add(Me.btnUseLocalTimeZone)
		Me.Controls.Add(Me.cmbTimeZone)
		Me.Controls.Add(Me.lblSettingsTimeZone)
		Me.Controls.Add(Me.lblSettingsHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "FormSettings"
		Me.Text = "Settings"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblSettingsHeader As Label
	Friend WithEvents lblSettingsTimeZone As Label
	Friend WithEvents cmbTimeZone As ComboBox
	Friend WithEvents btnUseLocalTimeZone As Button
	Friend WithEvents btnSettingCancel As Button
	Friend WithEvents btnSettingsSave As Button
End Class
