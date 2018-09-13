<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataListNew
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataListNew))
		Me.lblNewDataHeader = New System.Windows.Forms.Label()
		Me.lblCreateNewInstructions = New System.Windows.Forms.Label()
		Me.lblCreateName = New System.Windows.Forms.Label()
		Me.txtInvName = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.datalistNameError = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.tmrError = New System.Windows.Forms.Timer(Me.components)
		Me.eprCheckValidName = New System.Windows.Forms.ErrorProvider(Me.components)
		CType(Me.datalistNameError, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.eprCheckValidName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblNewDataHeader
		'
		Me.lblNewDataHeader.AutoSize = True
		Me.lblNewDataHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewDataHeader.Location = New System.Drawing.Point(52, 9)
		Me.lblNewDataHeader.Name = "lblNewDataHeader"
		Me.lblNewDataHeader.Size = New System.Drawing.Size(283, 25)
		Me.lblNewDataHeader.TabIndex = 0
		Me.lblNewDataHeader.Text = "Create New Inventory List"
		'
		'lblCreateNewInstructions
		'
		Me.lblCreateNewInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreateNewInstructions.Location = New System.Drawing.Point(28, 43)
		Me.lblCreateNewInstructions.Name = "lblCreateNewInstructions"
		Me.lblCreateNewInstructions.Size = New System.Drawing.Size(338, 112)
		Me.lblCreateNewInstructions.TabIndex = 1
		Me.lblCreateNewInstructions.Text = resources.GetString("lblCreateNewInstructions.Text")
		'
		'lblCreateName
		'
		Me.lblCreateName.AutoSize = True
		Me.lblCreateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreateName.Location = New System.Drawing.Point(115, 172)
		Me.lblCreateName.Name = "lblCreateName"
		Me.lblCreateName.Size = New System.Drawing.Size(153, 20)
		Me.lblCreateName.TabIndex = 2
		Me.lblCreateName.Text = "Inventory List Name:"
		'
		'txtInvName
		'
		Me.txtInvName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInvName.Location = New System.Drawing.Point(91, 195)
		Me.txtInvName.Name = "txtInvName"
		Me.txtInvName.Size = New System.Drawing.Size(202, 26)
		Me.txtInvName.TabIndex = 3
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(23, 237)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(153, 35)
		Me.btnCancel.TabIndex = 4
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnCreate
		'
		Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCreate.Location = New System.Drawing.Point(203, 237)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(153, 35)
		Me.btnCreate.TabIndex = 5
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = True
		'
		'datalistNameError
		'
		Me.datalistNameError.ContainerControl = Me
		'
		'tmrError
		'
		Me.tmrError.Interval = 1000
		'
		'eprCheckValidName
		'
		Me.eprCheckValidName.ContainerControl = Me
		'
		'FormDataListNew
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(380, 296)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnCreate)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.txtInvName)
		Me.Controls.Add(Me.lblCreateName)
		Me.Controls.Add(Me.lblCreateNewInstructions)
		Me.Controls.Add(Me.lblNewDataHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormDataListNew"
		Me.Text = "Create New Inventory List"
		CType(Me.datalistNameError, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.eprCheckValidName, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblNewDataHeader As Label
	Friend WithEvents lblCreateNewInstructions As Label
	Friend WithEvents lblCreateName As Label
	Friend WithEvents txtInvName As TextBox
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnCreate As Button
	Friend WithEvents datalistNameError As ErrorProvider
	Friend WithEvents tmrError As Timer
	Friend WithEvents eprCheckValidName As ErrorProvider
End Class
