<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemInfo
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
		Me.Item = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Item
		'
		Me.Item.AutoSize = True
		Me.Item.Location = New System.Drawing.Point(34, 40)
		Me.Item.Name = "Item"
		Me.Item.Size = New System.Drawing.Size(39, 13)
		Me.Item.TabIndex = 0
		Me.Item.Text = "Label1"
		'
		'FormItemInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(456, 450)
		Me.Controls.Add(Me.Item)
		Me.Name = "FormItemInfo"
		Me.Text = "Item Info"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Item As Label
End Class
