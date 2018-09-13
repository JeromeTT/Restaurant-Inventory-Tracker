<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemDelete
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
		Me.components = New System.ComponentModel.Container()
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.txtInput = New System.Windows.Forms.TextBox()
		Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'lblHeader
		'
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(3, 9)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(327, 54)
		Me.lblHeader.TabIndex = 0
		Me.lblHeader.Text = "Are you sure you want to delete this item?"
		Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnDelete
		'
		Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnDelete.Location = New System.Drawing.Point(195, 127)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(101, 23)
		Me.btnDelete.TabIndex = 1
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(43, 127)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(101, 23)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'lblDescription
		'
		Me.lblDescription.AutoSize = True
		Me.lblDescription.Location = New System.Drawing.Point(40, 63)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(268, 13)
		Me.lblDescription.TabIndex = 3
		Me.lblDescription.Text = "To delete the item, please type the full item name below"
		'
		'txtInput
		'
		Me.txtInput.Location = New System.Drawing.Point(43, 90)
		Me.txtInput.Name = "txtInput"
		Me.txtInput.Size = New System.Drawing.Size(253, 20)
		Me.txtInput.TabIndex = 4
		'
		'tmrCheck
		'
		Me.tmrCheck.Enabled = True
		'
		'FormItemDelete
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
		Me.Name = "FormItemDelete"
		Me.Text = "Delete Confirmation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblHeader As Label
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents lblDescription As Label
	Friend WithEvents txtInput As TextBox
	Friend WithEvents tmrCheck As Timer
End Class
