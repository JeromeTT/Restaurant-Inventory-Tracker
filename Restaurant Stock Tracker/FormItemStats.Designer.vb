<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemStats
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
		Me.lblItemName = New System.Windows.Forms.Label()
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.btnBack = New System.Windows.Forms.Button()
		Me.btnForward = New System.Windows.Forms.Button()
		Me.lblDayOfWeek = New System.Windows.Forms.Label()
		Me.lblConsumptionHeader = New System.Windows.Forms.Label()
		Me.lblConsumption = New System.Windows.Forms.Label()
		Me.lblRevenueHeader = New System.Windows.Forms.Label()
		Me.lblRevenue = New System.Windows.Forms.Label()
		Me.cmbMode = New System.Windows.Forms.ComboBox()
		Me.lblModeHeader = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblItemName
		'
		Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItemName.Location = New System.Drawing.Point(2, 34)
		Me.lblItemName.Name = "lblItemName"
		Me.lblItemName.Size = New System.Drawing.Size(307, 33)
		Me.lblItemName.TabIndex = 0
		Me.lblItemName.Text = "lblItemName"
		Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblHeader
		'
		Me.lblHeader.AutoSize = True
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(79, 9)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(160, 25)
		Me.lblHeader.TabIndex = 1
		Me.lblHeader.Text = "Item Statistics"
		'
		'btnBack
		'
		Me.btnBack.Location = New System.Drawing.Point(15, 66)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(75, 23)
		Me.btnBack.TabIndex = 4
		Me.btnBack.Text = "<<<"
		Me.btnBack.UseVisualStyleBackColor = True
		'
		'btnForward
		'
		Me.btnForward.Location = New System.Drawing.Point(224, 66)
		Me.btnForward.Name = "btnForward"
		Me.btnForward.Size = New System.Drawing.Size(75, 23)
		Me.btnForward.TabIndex = 5
		Me.btnForward.Text = ">>>"
		Me.btnForward.UseVisualStyleBackColor = True
		'
		'lblDayOfWeek
		'
		Me.lblDayOfWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDayOfWeek.Location = New System.Drawing.Point(96, 67)
		Me.lblDayOfWeek.Name = "lblDayOfWeek"
		Me.lblDayOfWeek.Size = New System.Drawing.Size(122, 18)
		Me.lblDayOfWeek.TabIndex = 6
		Me.lblDayOfWeek.Text = "Wednesday"
		Me.lblDayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblConsumptionHeader
		'
		Me.lblConsumptionHeader.Location = New System.Drawing.Point(3, 119)
		Me.lblConsumptionHeader.Name = "lblConsumptionHeader"
		Me.lblConsumptionHeader.Size = New System.Drawing.Size(303, 23)
		Me.lblConsumptionHeader.TabIndex = 7
		Me.lblConsumptionHeader.Text = "Average Consumption:"
		Me.lblConsumptionHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblConsumption
		'
		Me.lblConsumption.Location = New System.Drawing.Point(3, 142)
		Me.lblConsumption.Name = "lblConsumption"
		Me.lblConsumption.Size = New System.Drawing.Size(303, 19)
		Me.lblConsumption.TabIndex = 8
		Me.lblConsumption.Text = "-"
		Me.lblConsumption.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblRevenueHeader
		'
		Me.lblRevenueHeader.Location = New System.Drawing.Point(3, 161)
		Me.lblRevenueHeader.Name = "lblRevenueHeader"
		Me.lblRevenueHeader.Size = New System.Drawing.Size(303, 24)
		Me.lblRevenueHeader.TabIndex = 11
		Me.lblRevenueHeader.Text = "Average Consumption:"
		Me.lblRevenueHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblRevenue
		'
		Me.lblRevenue.Location = New System.Drawing.Point(3, 185)
		Me.lblRevenue.Name = "lblRevenue"
		Me.lblRevenue.Size = New System.Drawing.Size(303, 19)
		Me.lblRevenue.TabIndex = 12
		Me.lblRevenue.Text = "-"
		Me.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmbMode
		'
		Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMode.FormattingEnabled = True
		Me.cmbMode.Location = New System.Drawing.Point(167, 95)
		Me.cmbMode.Name = "cmbMode"
		Me.cmbMode.Size = New System.Drawing.Size(121, 21)
		Me.cmbMode.TabIndex = 13
		'
		'lblModeHeader
		'
		Me.lblModeHeader.AutoSize = True
		Me.lblModeHeader.Location = New System.Drawing.Point(40, 98)
		Me.lblModeHeader.Name = "lblModeHeader"
		Me.lblModeHeader.Size = New System.Drawing.Size(99, 13)
		Me.lblModeHeader.TabIndex = 14
		Me.lblModeHeader.Text = "Show averages for:"
		'
		'FormItemStats
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(311, 214)
		Me.Controls.Add(Me.lblModeHeader)
		Me.Controls.Add(Me.cmbMode)
		Me.Controls.Add(Me.lblRevenue)
		Me.Controls.Add(Me.lblRevenueHeader)
		Me.Controls.Add(Me.lblConsumption)
		Me.Controls.Add(Me.lblConsumptionHeader)
		Me.Controls.Add(Me.lblDayOfWeek)
		Me.Controls.Add(Me.btnForward)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.lblHeader)
		Me.Controls.Add(Me.lblItemName)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormItemStats"
		Me.Text = "Item Stats"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblItemName As Label
	Friend WithEvents lblHeader As Label
	Friend WithEvents btnBack As Button
	Friend WithEvents btnForward As Button
	Friend WithEvents lblDayOfWeek As Label
	Friend WithEvents lblConsumptionHeader As Label
	Friend WithEvents lblConsumption As Label
	Friend WithEvents lblRevenueHeader As Label
	Friend WithEvents lblRevenue As Label
	Friend WithEvents cmbMode As ComboBox
	Friend WithEvents lblModeHeader As Label
End Class
