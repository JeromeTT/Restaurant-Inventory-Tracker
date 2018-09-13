<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemEdit
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
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.numCost = New System.Windows.Forms.NumericUpDown()
		Me.numEnd = New System.Windows.Forms.NumericUpDown()
		Me.numStart = New System.Windows.Forms.NumericUpDown()
		Me.lblCostHeader = New System.Windows.Forms.Label()
		Me.lblStartHeader = New System.Windows.Forms.Label()
		Me.lblEndHeader = New System.Windows.Forms.Label()
		Me.btnForward = New System.Windows.Forms.Button()
		Me.btnBack = New System.Windows.Forms.Button()
		CType(Me.numCost, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numStart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblHeader
		'
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(1, 9)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(324, 25)
		Me.lblHeader.TabIndex = 0
		Me.lblHeader.Text = "Editing Data from"
		Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblDate
		'
		Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDate.Location = New System.Drawing.Point(5, 35)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(320, 25)
		Me.lblDate.TabIndex = 1
		Me.lblDate.Text = "<Date>"
		Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(15, 140)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(132, 34)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnSave.Location = New System.Drawing.Point(184, 140)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(131, 34)
		Me.btnSave.TabIndex = 3
		Me.btnSave.Text = "Apply Changes"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'numCost
		'
		Me.numCost.DecimalPlaces = 2
		Me.numCost.Location = New System.Drawing.Point(169, 63)
		Me.numCost.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numCost.Name = "numCost"
		Me.numCost.Size = New System.Drawing.Size(146, 20)
		Me.numCost.TabIndex = 4
		'
		'numEnd
		'
		Me.numEnd.Location = New System.Drawing.Point(169, 114)
		Me.numEnd.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numEnd.Name = "numEnd"
		Me.numEnd.Size = New System.Drawing.Size(146, 20)
		Me.numEnd.TabIndex = 5
		'
		'numStart
		'
		Me.numStart.Location = New System.Drawing.Point(169, 88)
		Me.numStart.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numStart.Name = "numStart"
		Me.numStart.Size = New System.Drawing.Size(146, 20)
		Me.numStart.TabIndex = 6
		'
		'lblCostHeader
		'
		Me.lblCostHeader.Location = New System.Drawing.Point(13, 63)
		Me.lblCostHeader.Name = "lblCostHeader"
		Me.lblCostHeader.Size = New System.Drawing.Size(84, 15)
		Me.lblCostHeader.TabIndex = 7
		Me.lblCostHeader.Text = "Selling Cost ($) :"
		Me.lblCostHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblStartHeader
		'
		Me.lblStartHeader.Location = New System.Drawing.Point(13, 89)
		Me.lblStartHeader.Name = "lblStartHeader"
		Me.lblStartHeader.Size = New System.Drawing.Size(84, 15)
		Me.lblStartHeader.TabIndex = 8
		Me.lblStartHeader.Text = "Start Quantity :"
		Me.lblStartHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblEndHeader
		'
		Me.lblEndHeader.Location = New System.Drawing.Point(13, 115)
		Me.lblEndHeader.Name = "lblEndHeader"
		Me.lblEndHeader.Size = New System.Drawing.Size(84, 15)
		Me.lblEndHeader.TabIndex = 9
		Me.lblEndHeader.Text = "End Quantity :"
		Me.lblEndHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnForward
		'
		Me.btnForward.Location = New System.Drawing.Point(240, 34)
		Me.btnForward.Name = "btnForward"
		Me.btnForward.Size = New System.Drawing.Size(75, 23)
		Me.btnForward.TabIndex = 12
		Me.btnForward.Text = ">>>"
		Me.btnForward.UseVisualStyleBackColor = True
		'
		'btnBack
		'
		Me.btnBack.Location = New System.Drawing.Point(12, 34)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(75, 23)
		Me.btnBack.TabIndex = 13
		Me.btnBack.Text = "<<<"
		Me.btnBack.UseVisualStyleBackColor = True
		'
		'FormItemEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(327, 197)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.btnForward)
		Me.Controls.Add(Me.lblEndHeader)
		Me.Controls.Add(Me.lblStartHeader)
		Me.Controls.Add(Me.lblCostHeader)
		Me.Controls.Add(Me.numStart)
		Me.Controls.Add(Me.numEnd)
		Me.Controls.Add(Me.numCost)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.lblHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormItemEdit"
		Me.Text = "Edit Item"
		CType(Me.numCost, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numEnd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numStart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblHeader As Label
	Friend WithEvents lblDate As Label
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents numCost As NumericUpDown
	Friend WithEvents numEnd As NumericUpDown
	Friend WithEvents numStart As NumericUpDown
	Friend WithEvents lblCostHeader As Label
	Friend WithEvents lblStartHeader As Label
	Friend WithEvents lblEndHeader As Label
	Friend WithEvents btnForward As Button
	Friend WithEvents btnBack As Button
End Class
