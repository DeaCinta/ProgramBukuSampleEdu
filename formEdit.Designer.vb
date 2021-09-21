<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEdit
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
		Me.lbJudul = New System.Windows.Forms.Label()
		Me.tbJudul = New System.Windows.Forms.TextBox()
		Me.tbIsbnSample = New System.Windows.Forms.TextBox()
		Me.lbIsbnSample = New System.Windows.Forms.Label()
		Me.tbKodeSample = New System.Windows.Forms.TextBox()
		Me.lbSample = New System.Windows.Forms.Label()
		Me.tbQty = New System.Windows.Forms.TextBox()
		Me.lbQty = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.tbQtyTambah = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btClose = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lbJudul
		'
		Me.lbJudul.AutoSize = True
		Me.lbJudul.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbJudul.Location = New System.Drawing.Point(8, 40)
		Me.lbJudul.Name = "lbJudul"
		Me.lbJudul.Size = New System.Drawing.Size(134, 23)
		Me.lbJudul.TabIndex = 1
		Me.lbJudul.Text = "Judul                  : "
		'
		'tbJudul
		'
		Me.tbJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbJudul.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbJudul.Location = New System.Drawing.Point(144, 39)
		Me.tbJudul.Name = "tbJudul"
		Me.tbJudul.Size = New System.Drawing.Size(275, 24)
		Me.tbJudul.TabIndex = 2
		'
		'tbIsbnSample
		'
		Me.tbIsbnSample.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbIsbnSample.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbIsbnSample.Location = New System.Drawing.Point(144, 72)
		Me.tbIsbnSample.Name = "tbIsbnSample"
		Me.tbIsbnSample.Size = New System.Drawing.Size(200, 24)
		Me.tbIsbnSample.TabIndex = 4
		'
		'lbIsbnSample
		'
		Me.lbIsbnSample.AutoSize = True
		Me.lbIsbnSample.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbIsbnSample.Location = New System.Drawing.Point(7, 73)
		Me.lbIsbnSample.Name = "lbIsbnSample"
		Me.lbIsbnSample.Size = New System.Drawing.Size(134, 23)
		Me.lbIsbnSample.TabIndex = 3
		Me.lbIsbnSample.Text = "Isbn Sample    : "
		'
		'tbKodeSample
		'
		Me.tbKodeSample.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbKodeSample.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbKodeSample.Location = New System.Drawing.Point(144, 107)
		Me.tbKodeSample.Name = "tbKodeSample"
		Me.tbKodeSample.Size = New System.Drawing.Size(142, 24)
		Me.tbKodeSample.TabIndex = 6
		'
		'lbSample
		'
		Me.lbSample.AutoSize = True
		Me.lbSample.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbSample.Location = New System.Drawing.Point(7, 108)
		Me.lbSample.Name = "lbSample"
		Me.lbSample.Size = New System.Drawing.Size(135, 23)
		Me.lbSample.TabIndex = 5
		Me.lbSample.Text = "Kode Sample   : "
		'
		'tbQty
		'
		Me.tbQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbQty.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbQty.Location = New System.Drawing.Point(145, 142)
		Me.tbQty.Name = "tbQty"
		Me.tbQty.Size = New System.Drawing.Size(78, 24)
		Me.tbQty.TabIndex = 8
		'
		'lbQty
		'
		Me.lbQty.AutoSize = True
		Me.lbQty.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbQty.Location = New System.Drawing.Point(8, 143)
		Me.lbQty.Name = "lbQty"
		Me.lbQty.Size = New System.Drawing.Size(130, 23)
		Me.lbQty.TabIndex = 7
		Me.lbQty.Text = "Qty                    : "
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.tbJudul)
		Me.GroupBox1.Controls.Add(Me.tbQty)
		Me.GroupBox1.Controls.Add(Me.lbJudul)
		Me.GroupBox1.Controls.Add(Me.lbQty)
		Me.GroupBox1.Controls.Add(Me.lbIsbnSample)
		Me.GroupBox1.Controls.Add(Me.tbKodeSample)
		Me.GroupBox1.Controls.Add(Me.tbIsbnSample)
		Me.GroupBox1.Controls.Add(Me.lbSample)
		Me.GroupBox1.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(9, 48)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(433, 204)
		Me.GroupBox1.TabIndex = 9
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Data Sample"
		'
		'tbQtyTambah
		'
		Me.tbQtyTambah.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbQtyTambah.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbQtyTambah.Location = New System.Drawing.Point(360, 268)
		Me.tbQtyTambah.Name = "tbQtyTambah"
		Me.tbQtyTambah.Size = New System.Drawing.Size(78, 24)
		Me.tbQtyTambah.TabIndex = 11
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(260, 269)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 23)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Tambah  : "
		'
		'btClose
		'
		Me.btClose.BackColor = System.Drawing.Color.Transparent
		Me.btClose.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.close_window_26px
		Me.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btClose.FlatAppearance.BorderSize = 0
		Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btClose.Location = New System.Drawing.Point(396, 3)
		Me.btClose.Name = "btClose"
		Me.btClose.Size = New System.Drawing.Size(35, 39)
		Me.btClose.TabIndex = 0
		Me.btClose.UseVisualStyleBackColor = False
		'
		'formEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CornflowerBlue
		Me.ClientSize = New System.Drawing.Size(448, 450)
		Me.Controls.Add(Me.tbQtyTambah)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btClose)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "formEdit"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formEdit"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btClose As Button
	Friend WithEvents lbJudul As Label
	Friend WithEvents tbJudul As TextBox
	Friend WithEvents tbIsbnSample As TextBox
	Friend WithEvents lbIsbnSample As Label
	Friend WithEvents tbKodeSample As TextBox
	Friend WithEvents lbSample As Label
	Friend WithEvents tbQty As TextBox
	Friend WithEvents lbQty As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents tbQtyTambah As TextBox
	Friend WithEvents Label1 As Label
End Class
