<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddItem
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddItem))
		Me.lblCreateNewInstructions = New System.Windows.Forms.Label()
		Me.lblNewDataHeader = New System.Windows.Forms.Label()
		Me.btnItemAdd = New System.Windows.Forms.Button()
		Me.btnAddCancel = New System.Windows.Forms.Button()
		Me.txtItemName = New System.Windows.Forms.TextBox()
		Me.lblCreateName = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblCreateNewInstructions
		'
		Me.lblCreateNewInstructions.AutoSize = True
		Me.lblCreateNewInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreateNewInstructions.Location = New System.Drawing.Point(12, 57)
		Me.lblCreateNewInstructions.Name = "lblCreateNewInstructions"
		Me.lblCreateNewInstructions.Size = New System.Drawing.Size(323, 112)
		Me.lblCreateNewInstructions.TabIndex = 2
		Me.lblCreateNewInstructions.Text = resources.GetString("lblCreateNewInstructions.Text")
		'
		'lblNewDataHeader
		'
		Me.lblNewDataHeader.AutoSize = True
		Me.lblNewDataHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewDataHeader.Location = New System.Drawing.Point(114, 20)
		Me.lblNewDataHeader.Name = "lblNewDataHeader"
		Me.lblNewDataHeader.Size = New System.Drawing.Size(104, 25)
		Me.lblNewDataHeader.TabIndex = 3
		Me.lblNewDataHeader.Text = "Add Item"
		'
		'btnItemAdd
		'
		Me.btnItemAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnItemAdd.Location = New System.Drawing.Point(207, 236)
		Me.btnItemAdd.Name = "btnItemAdd"
		Me.btnItemAdd.Size = New System.Drawing.Size(104, 35)
		Me.btnItemAdd.TabIndex = 9
		Me.btnItemAdd.Text = "Create"
		Me.btnItemAdd.UseVisualStyleBackColor = True
		'
		'btnAddCancel
		'
		Me.btnAddCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddCancel.Location = New System.Drawing.Point(40, 236)
		Me.btnAddCancel.Name = "btnAddCancel"
		Me.btnAddCancel.Size = New System.Drawing.Size(104, 35)
		Me.btnAddCancel.TabIndex = 8
		Me.btnAddCancel.Text = "Cancel"
		Me.btnAddCancel.UseVisualStyleBackColor = True
		'
		'txtItemName
		'
		Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItemName.Location = New System.Drawing.Point(119, 180)
		Me.txtItemName.Name = "txtItemName"
		Me.txtItemName.Size = New System.Drawing.Size(202, 26)
		Me.txtItemName.TabIndex = 7
		'
		'lblCreateName
		'
		Me.lblCreateName.AutoSize = True
		Me.lblCreateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreateName.Location = New System.Drawing.Point(22, 186)
		Me.lblCreateName.Name = "lblCreateName"
		Me.lblCreateName.Size = New System.Drawing.Size(91, 20)
		Me.lblCreateName.TabIndex = 6
		Me.lblCreateName.Text = "Item Name:"
		'
		'FormAddItem
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(345, 298)
		Me.Controls.Add(Me.btnItemAdd)
		Me.Controls.Add(Me.btnAddCancel)
		Me.Controls.Add(Me.txtItemName)
		Me.Controls.Add(Me.lblCreateName)
		Me.Controls.Add(Me.lblNewDataHeader)
		Me.Controls.Add(Me.lblCreateNewInstructions)
		Me.Name = "FormAddItem"
		Me.Text = "Add Item"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblCreateNewInstructions As Label
	Friend WithEvents lblNewDataHeader As Label
	Friend WithEvents btnItemAdd As Button
	Friend WithEvents btnAddCancel As Button
	Friend WithEvents txtItemName As TextBox
	Friend WithEvents lblCreateName As Label
End Class
