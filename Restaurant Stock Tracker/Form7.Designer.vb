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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.numCost = New System.Windows.Forms.NumericUpDown()
		Me.numEnd = New System.Windows.Forms.NumericUpDown()
		Me.numStart = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		CType(Me.numCost, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numStart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(1, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(248, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Editing Data from"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblDate
		'
		Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDate.Location = New System.Drawing.Point(-2, 34)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(251, 25)
		Me.lblDate.TabIndex = 1
		Me.lblDate.Text = "<Date>"
		Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(15, 140)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(109, 34)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(140, 140)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(109, 34)
		Me.btnSave.TabIndex = 3
		Me.btnSave.Text = "Apply Changes"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'numCost
		'
		Me.numCost.DecimalPlaces = 2
		Me.numCost.Location = New System.Drawing.Point(103, 62)
		Me.numCost.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numCost.Name = "numCost"
		Me.numCost.Size = New System.Drawing.Size(146, 20)
		Me.numCost.TabIndex = 4
		'
		'numEnd
		'
		Me.numEnd.Location = New System.Drawing.Point(103, 114)
		Me.numEnd.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numEnd.Name = "numEnd"
		Me.numEnd.Size = New System.Drawing.Size(146, 20)
		Me.numEnd.TabIndex = 5
		'
		'numStart
		'
		Me.numStart.Location = New System.Drawing.Point(103, 88)
		Me.numStart.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numStart.Name = "numStart"
		Me.numStart.Size = New System.Drawing.Size(146, 20)
		Me.numStart.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(13, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(84, 15)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Cost ($) :"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(13, 89)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(84, 15)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Start Quantity :"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(13, 115)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(84, 15)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "End Quantity :"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FormItemEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(265, 197)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.numStart)
		Me.Controls.Add(Me.numEnd)
		Me.Controls.Add(Me.numCost)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FormItemEdit"
		Me.Text = "Edit Item"
		CType(Me.numCost, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numEnd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numStart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents lblDate As Label
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents numCost As NumericUpDown
	Friend WithEvents numEnd As NumericUpDown
	Friend WithEvents numStart As NumericUpDown
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
End Class
