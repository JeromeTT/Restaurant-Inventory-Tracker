<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataListDelete
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
		Me.lstDataList = New System.Windows.Forms.ListBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'lstDataList
		'
		Me.lstDataList.FormattingEnabled = True
		Me.lstDataList.Location = New System.Drawing.Point(22, 35)
		Me.lstDataList.Name = "lstDataList"
		Me.lstDataList.Size = New System.Drawing.Size(243, 212)
		Me.lstDataList.TabIndex = 1
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(22, 253)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(243, 54)
		Me.btnDelete.TabIndex = 2
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'lblHeader
		'
		Me.lblHeader.AutoSize = True
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(36, 9)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(217, 20)
		Me.lblHeader.TabIndex = 3
		Me.lblHeader.Text = "Select Data List to Delete"
		'
		'tmrMain
		'
		Me.tmrMain.Enabled = True
		'
		'FormDataListDelete
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(288, 320)
		Me.Controls.Add(Me.lblHeader)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.lstDataList)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormDataListDelete"
		Me.Text = "Select data list to delete"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lstDataList As ListBox
	Friend WithEvents btnDelete As Button
	Friend WithEvents lblHeader As Label
	Friend WithEvents tmrMain As Timer
End Class
