<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataListDeleteConfirmation
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtInput = New System.Windows.Forms.TextBox()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.timerCheck = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'txtInput
		'
		Me.txtInput.Location = New System.Drawing.Point(44, 96)
		Me.txtInput.Name = "txtInput"
		Me.txtInput.Size = New System.Drawing.Size(253, 20)
		Me.txtInput.TabIndex = 9
		'
		'lblDescription
		'
		Me.lblDescription.AutoSize = True
		Me.lblDescription.Location = New System.Drawing.Point(26, 69)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(286, 13)
		Me.lblDescription.TabIndex = 8
		Me.lblDescription.Text = "To delete this data list, please type the full item name below"
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(44, 133)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(101, 23)
		Me.btnCancel.TabIndex = 7
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnDelete.Location = New System.Drawing.Point(196, 133)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(101, 23)
		Me.btnDelete.TabIndex = 6
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'lblHeader
		'
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(4, 15)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(327, 54)
		Me.lblHeader.TabIndex = 5
		Me.lblHeader.Text = "Are you sure you want to delete this data list?"
		Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'timerCheck
		'
		Me.timerCheck.Enabled = True
		'
		'FormDataListDeleteConfirmation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(334, 171)
		Me.Controls.Add(Me.txtInput)
		Me.Controls.Add(Me.lblDescription)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.lblHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormDataListDeleteConfirmation"
		Me.Text = "Delete Confirmation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtInput As TextBox
	Friend WithEvents lblDescription As Label
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents lblHeader As Label
	Friend WithEvents timerCheck As Timer
End Class
