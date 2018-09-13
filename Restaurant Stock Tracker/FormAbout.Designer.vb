<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
		Me.lblMadeBy = New System.Windows.Forms.Label()
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.lnkHyperLink = New System.Windows.Forms.LinkLabel()
		Me.SuspendLayout()
		'
		'lblMadeBy
		'
		Me.lblMadeBy.AutoSize = True
		Me.lblMadeBy.Location = New System.Drawing.Point(176, 85)
		Me.lblMadeBy.Name = "lblMadeBy"
		Me.lblMadeBy.Size = New System.Drawing.Size(119, 13)
		Me.lblMadeBy.TabIndex = 0
		Me.lblMadeBy.Text = "Made by Jayden Zhang"
		'
		'lblHeader
		'
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(12, 18)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(452, 31)
		Me.lblHeader.TabIndex = 1
		Me.lblHeader.Text = "Restaurant Inventory Tracker"
		Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lnkHyperLink
		'
		Me.lnkHyperLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lnkHyperLink.Location = New System.Drawing.Point(14, 49)
		Me.lnkHyperLink.Name = "lnkHyperLink"
		Me.lnkHyperLink.Size = New System.Drawing.Size(452, 23)
		Me.lnkHyperLink.TabIndex = 3
		Me.lnkHyperLink.TabStop = True
		Me.lnkHyperLink.Text = "kxrie.me"
		Me.lnkHyperLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'FormAbout
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(476, 118)
		Me.Controls.Add(Me.lnkHyperLink)
		Me.Controls.Add(Me.lblHeader)
		Me.Controls.Add(Me.lblMadeBy)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormAbout"
		Me.Text = "About"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblMadeBy As Label
	Friend WithEvents lblHeader As Label
	Friend WithEvents lnkHyperLink As LinkLabel
End Class
