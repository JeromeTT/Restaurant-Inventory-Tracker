<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewDataList
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewDataList))
		Me.lblNewDataHeader = New System.Windows.Forms.Label()
		Me.lblCreateNewInstructions = New System.Windows.Forms.Label()
		Me.lblCreateName = New System.Windows.Forms.Label()
		Me.txtDLName = New System.Windows.Forms.TextBox()
		Me.btnCreateCancel = New System.Windows.Forms.Button()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblNewDataHeader
		'
		Me.lblNewDataHeader.AutoSize = True
		Me.lblNewDataHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewDataHeader.Location = New System.Drawing.Point(80, 9)
		Me.lblNewDataHeader.Name = "lblNewDataHeader"
		Me.lblNewDataHeader.Size = New System.Drawing.Size(235, 25)
		Me.lblNewDataHeader.TabIndex = 0
		Me.lblNewDataHeader.Text = "Create New Data List"
		'
		'lblCreateNewInstructions
		'
		Me.lblCreateNewInstructions.AutoSize = True
		Me.lblCreateNewInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreateNewInstructions.Location = New System.Drawing.Point(33, 52)
		Me.lblCreateNewInstructions.Name = "lblCreateNewInstructions"
		Me.lblCreateNewInstructions.Size = New System.Drawing.Size(323, 112)
		Me.lblCreateNewInstructions.TabIndex = 1
		Me.lblCreateNewInstructions.Text = resources.GetString("lblCreateNewInstructions.Text")
		'
		'lblCreateName
		'
		Me.lblCreateName.AutoSize = True
		Me.lblCreateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreateName.Location = New System.Drawing.Point(25, 198)
		Me.lblCreateName.Name = "lblCreateName"
		Me.lblCreateName.Size = New System.Drawing.Size(123, 20)
		Me.lblCreateName.TabIndex = 2
		Me.lblCreateName.Text = "Data List Name:"
		'
		'txtDLName
		'
		Me.txtDLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDLName.Location = New System.Drawing.Point(154, 195)
		Me.txtDLName.Name = "txtDLName"
		Me.txtDLName.Size = New System.Drawing.Size(202, 26)
		Me.txtDLName.TabIndex = 3
		'
		'btnCreateCancel
		'
		Me.btnCreateCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCreateCancel.Location = New System.Drawing.Point(54, 254)
		Me.btnCreateCancel.Name = "btnCreateCancel"
		Me.btnCreateCancel.Size = New System.Drawing.Size(104, 35)
		Me.btnCreateCancel.TabIndex = 4
		Me.btnCreateCancel.Text = "Cancel"
		Me.btnCreateCancel.UseVisualStyleBackColor = True
		'
		'btnCreate
		'
		Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCreate.Location = New System.Drawing.Point(225, 254)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(104, 35)
		Me.btnCreate.TabIndex = 5
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = True
		'
		'FormNewDataList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(385, 319)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnCreate)
		Me.Controls.Add(Me.btnCreateCancel)
		Me.Controls.Add(Me.txtDLName)
		Me.Controls.Add(Me.lblCreateName)
		Me.Controls.Add(Me.lblCreateNewInstructions)
		Me.Controls.Add(Me.lblNewDataHeader)
		Me.Name = "FormNewDataList"
		Me.Text = "Create New Data List"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblNewDataHeader As Label
	Friend WithEvents lblCreateNewInstructions As Label
	Friend WithEvents lblCreateName As Label
	Friend WithEvents txtDLName As TextBox
	Friend WithEvents btnCreateCancel As Button
	Friend WithEvents btnCreate As Button
End Class
