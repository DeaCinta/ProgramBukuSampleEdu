<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInputBuku
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lbScanISBN = New System.Windows.Forms.Label()
		Me.tbScanISBN = New System.Windows.Forms.TextBox()
		Me.tbjudul = New System.Windows.Forms.TextBox()
		Me.lbjudul = New System.Windows.Forms.Label()
		Me.tbIsbnSample = New System.Windows.Forms.TextBox()
		Me.lbIsbnSample = New System.Windows.Forms.Label()
		Me.tbKodeJual = New System.Windows.Forms.TextBox()
		Me.lbKodeAsli = New System.Windows.Forms.Label()
		Me.tbKodeSample = New System.Windows.Forms.TextBox()
		Me.lbKodeSample = New System.Windows.Forms.Label()
		Me.tbQty = New System.Windows.Forms.TextBox()
		Me.lbQty = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.tbPublisher = New System.Windows.Forms.TextBox()
		Me.lbPublisher = New System.Windows.Forms.Label()
		Me.gbScanIsbn = New System.Windows.Forms.GroupBox()
		Me.gbDataBuku = New System.Windows.Forms.GroupBox()
		Me.gbDataSample = New System.Windows.Forms.GroupBox()
		Me.gbStatusKoneksi = New System.Windows.Forms.GroupBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.dgvSampleEdu = New System.Windows.Forms.DataGridView()
		Me.SampleEduBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.INVDataSet = New ProgramBukuSampleEdu.INVDataSet()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.SampleEduTableAdapter = New ProgramBukuSampleEdu.INVDataSetTableAdapters.SampleEduTableAdapter()
		Me.btMininize = New System.Windows.Forms.Button()
		Me.btMaximize = New System.Windows.Forms.Button()
		Me.btEdit = New System.Windows.Forms.Button()
		Me.btClose = New System.Windows.Forms.Button()
		Me.btScanIsbn = New System.Windows.Forms.Button()
		Me.btSimpan = New System.Windows.Forms.Button()
		Me.IsbnSampleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KodeSampleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.lbScanIsbnTemp = New System.Windows.Forms.Label()
		Me.gbScanIsbn.SuspendLayout()
		Me.gbDataBuku.SuspendLayout()
		Me.gbDataSample.SuspendLayout()
		Me.gbStatusKoneksi.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.dgvSampleEdu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SampleEduBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lbScanISBN
		'
		Me.lbScanISBN.AutoSize = True
		Me.lbScanISBN.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbScanISBN.Location = New System.Drawing.Point(11, 32)
		Me.lbScanISBN.Name = "lbScanISBN"
		Me.lbScanISBN.Size = New System.Drawing.Size(83, 15)
		Me.lbScanISBN.TabIndex = 0
		Me.lbScanISBN.Text = "Scan ISBN    : "
		'
		'tbScanISBN
		'
		Me.tbScanISBN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbScanISBN.BackColor = System.Drawing.Color.AliceBlue
		Me.tbScanISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbScanISBN.Location = New System.Drawing.Point(100, 29)
		Me.tbScanISBN.Name = "tbScanISBN"
		Me.tbScanISBN.Size = New System.Drawing.Size(220, 20)
		Me.tbScanISBN.TabIndex = 1
		'
		'tbjudul
		'
		Me.tbjudul.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbjudul.BackColor = System.Drawing.Color.AliceBlue
		Me.tbjudul.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbjudul.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbjudul.Location = New System.Drawing.Point(125, 67)
		Me.tbjudul.Name = "tbjudul"
		Me.tbjudul.Size = New System.Drawing.Size(238, 19)
		Me.tbjudul.TabIndex = 3
		'
		'lbjudul
		'
		Me.lbjudul.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbjudul.AutoSize = True
		Me.lbjudul.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbjudul.Location = New System.Drawing.Point(25, 67)
		Me.lbjudul.Name = "lbjudul"
		Me.lbjudul.Size = New System.Drawing.Size(92, 18)
		Me.lbjudul.TabIndex = 2
		Me.lbjudul.Text = "Judul          : "
		'
		'tbIsbnSample
		'
		Me.tbIsbnSample.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbIsbnSample.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbIsbnSample.Location = New System.Drawing.Point(133, 14)
		Me.tbIsbnSample.Name = "tbIsbnSample"
		Me.tbIsbnSample.Size = New System.Drawing.Size(179, 20)
		Me.tbIsbnSample.TabIndex = 5
		'
		'lbIsbnSample
		'
		Me.lbIsbnSample.AutoSize = True
		Me.lbIsbnSample.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbIsbnSample.Location = New System.Drawing.Point(19, 16)
		Me.lbIsbnSample.Name = "lbIsbnSample"
		Me.lbIsbnSample.Size = New System.Drawing.Size(103, 19)
		Me.lbIsbnSample.TabIndex = 4
		Me.lbIsbnSample.Text = "ISBN Sample: "
		'
		'tbKodeJual
		'
		Me.tbKodeJual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbKodeJual.BackColor = System.Drawing.Color.AliceBlue
		Me.tbKodeJual.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbKodeJual.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbKodeJual.Location = New System.Drawing.Point(125, 40)
		Me.tbKodeJual.Name = "tbKodeJual"
		Me.tbKodeJual.Size = New System.Drawing.Size(100, 19)
		Me.tbKodeJual.TabIndex = 7
		'
		'lbKodeAsli
		'
		Me.lbKodeAsli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbKodeAsli.AutoSize = True
		Me.lbKodeAsli.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbKodeAsli.Location = New System.Drawing.Point(25, 41)
		Me.lbKodeAsli.Name = "lbKodeAsli"
		Me.lbKodeAsli.Size = New System.Drawing.Size(91, 18)
		Me.lbKodeAsli.TabIndex = 6
		Me.lbKodeAsli.Text = "Kode Jual   : "
		'
		'tbKodeSample
		'
		Me.tbKodeSample.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbKodeSample.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbKodeSample.Location = New System.Drawing.Point(133, 42)
		Me.tbKodeSample.Name = "tbKodeSample"
		Me.tbKodeSample.Size = New System.Drawing.Size(100, 20)
		Me.tbKodeSample.TabIndex = 9
		'
		'lbKodeSample
		'
		Me.lbKodeSample.AutoSize = True
		Me.lbKodeSample.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbKodeSample.Location = New System.Drawing.Point(19, 43)
		Me.lbKodeSample.Name = "lbKodeSample"
		Me.lbKodeSample.Size = New System.Drawing.Size(102, 19)
		Me.lbKodeSample.TabIndex = 8
		Me.lbKodeSample.Text = "Kode Sample: "
		'
		'tbQty
		'
		Me.tbQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbQty.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbQty.Location = New System.Drawing.Point(326, 145)
		Me.tbQty.Name = "tbQty"
		Me.tbQty.Size = New System.Drawing.Size(54, 24)
		Me.tbQty.TabIndex = 11
		'
		'lbQty
		'
		Me.lbQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbQty.AutoSize = True
		Me.lbQty.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbQty.Location = New System.Drawing.Point(251, 145)
		Me.lbQty.Name = "lbQty"
		Me.lbQty.Size = New System.Drawing.Size(71, 23)
		Me.lbQty.TabIndex = 10
		Me.lbQty.Text = "Qty    : "
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 13)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Label1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 30)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Label2"
		'
		'tbPublisher
		'
		Me.tbPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbPublisher.BackColor = System.Drawing.Color.AliceBlue
		Me.tbPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbPublisher.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbPublisher.Location = New System.Drawing.Point(125, 94)
		Me.tbPublisher.Name = "tbPublisher"
		Me.tbPublisher.Size = New System.Drawing.Size(132, 19)
		Me.tbPublisher.TabIndex = 16
		'
		'lbPublisher
		'
		Me.lbPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbPublisher.AutoSize = True
		Me.lbPublisher.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbPublisher.Location = New System.Drawing.Point(25, 94)
		Me.lbPublisher.Name = "lbPublisher"
		Me.lbPublisher.Size = New System.Drawing.Size(93, 18)
		Me.lbPublisher.TabIndex = 15
		Me.lbPublisher.Text = "Publisher    : "
		'
		'gbScanIsbn
		'
		Me.gbScanIsbn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbScanIsbn.Controls.Add(Me.btScanIsbn)
		Me.gbScanIsbn.Controls.Add(Me.tbScanISBN)
		Me.gbScanIsbn.Controls.Add(Me.lbScanISBN)
		Me.gbScanIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbScanIsbn.Font = New System.Drawing.Font("Constantia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbScanIsbn.Location = New System.Drawing.Point(12, 52)
		Me.gbScanIsbn.Name = "gbScanIsbn"
		Me.gbScanIsbn.Size = New System.Drawing.Size(391, 68)
		Me.gbScanIsbn.TabIndex = 17
		Me.gbScanIsbn.TabStop = False
		Me.gbScanIsbn.Text = "Scan ISBN"
		'
		'gbDataBuku
		'
		Me.gbDataBuku.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbDataBuku.Controls.Add(Me.tbKodeJual)
		Me.gbDataBuku.Controls.Add(Me.lbjudul)
		Me.gbDataBuku.Controls.Add(Me.tbPublisher)
		Me.gbDataBuku.Controls.Add(Me.tbjudul)
		Me.gbDataBuku.Controls.Add(Me.lbPublisher)
		Me.gbDataBuku.Controls.Add(Me.lbKodeAsli)
		Me.gbDataBuku.Controls.Add(Me.lbQty)
		Me.gbDataBuku.Controls.Add(Me.tbQty)
		Me.gbDataBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbDataBuku.Location = New System.Drawing.Point(10, 126)
		Me.gbDataBuku.Name = "gbDataBuku"
		Me.gbDataBuku.Size = New System.Drawing.Size(393, 189)
		Me.gbDataBuku.TabIndex = 18
		Me.gbDataBuku.TabStop = False
		Me.gbDataBuku.Text = "Data Buku"
		'
		'gbDataSample
		'
		Me.gbDataSample.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbDataSample.Controls.Add(Me.lbIsbnSample)
		Me.gbDataSample.Controls.Add(Me.tbIsbnSample)
		Me.gbDataSample.Controls.Add(Me.lbKodeSample)
		Me.gbDataSample.Controls.Add(Me.tbKodeSample)
		Me.gbDataSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbDataSample.Location = New System.Drawing.Point(447, 52)
		Me.gbDataSample.Name = "gbDataSample"
		Me.gbDataSample.Size = New System.Drawing.Size(388, 68)
		Me.gbDataSample.TabIndex = 19
		Me.gbDataSample.TabStop = False
		Me.gbDataSample.Text = "Data Sample"
		'
		'gbStatusKoneksi
		'
		Me.gbStatusKoneksi.Controls.Add(Me.Label1)
		Me.gbStatusKoneksi.Controls.Add(Me.Label2)
		Me.gbStatusKoneksi.Location = New System.Drawing.Point(764, 485)
		Me.gbStatusKoneksi.Name = "gbStatusKoneksi"
		Me.gbStatusKoneksi.Size = New System.Drawing.Size(152, 45)
		Me.gbStatusKoneksi.TabIndex = 20
		Me.gbStatusKoneksi.TabStop = False
		Me.gbStatusKoneksi.Text = "Status Koneksi"
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.dgvSampleEdu)
		Me.GroupBox1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(12, 332)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(904, 147)
		Me.GroupBox1.TabIndex = 22
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "List Buku Sample"
		'
		'dgvSampleEdu
		'
		Me.dgvSampleEdu.AllowUserToAddRows = False
		Me.dgvSampleEdu.AllowUserToDeleteRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
		Me.dgvSampleEdu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvSampleEdu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
		Me.dgvSampleEdu.AutoGenerateColumns = False
		Me.dgvSampleEdu.BackgroundColor = System.Drawing.Color.AliceBlue
		Me.dgvSampleEdu.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvSampleEdu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvSampleEdu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
		Me.dgvSampleEdu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PaleTurquoise
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvSampleEdu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.dgvSampleEdu.ColumnHeadersHeight = 25
		Me.dgvSampleEdu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsbnSampleDataGridViewTextBoxColumn, Me.KodeSampleDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn})
		Me.dgvSampleEdu.DataSource = Me.SampleEduBindingSource
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.Aquamarine
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SkyBlue
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvSampleEdu.DefaultCellStyle = DataGridViewCellStyle3
		Me.dgvSampleEdu.GridColor = System.Drawing.Color.MidnightBlue
		Me.dgvSampleEdu.Location = New System.Drawing.Point(10, 30)
		Me.dgvSampleEdu.Name = "dgvSampleEdu"
		Me.dgvSampleEdu.ReadOnly = True
		Me.dgvSampleEdu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvSampleEdu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvSampleEdu.RowHeadersVisible = False
		Me.dgvSampleEdu.RowHeadersWidth = 75
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
		Me.dgvSampleEdu.RowsDefaultCellStyle = DataGridViewCellStyle5
		Me.dgvSampleEdu.Size = New System.Drawing.Size(888, 111)
		Me.dgvSampleEdu.TabIndex = 0
		'
		'SampleEduBindingSource
		'
		Me.SampleEduBindingSource.DataMember = "SampleEdu"
		Me.SampleEduBindingSource.DataSource = Me.INVDataSet
		'
		'INVDataSet
		'
		Me.INVDataSet.DataSetName = "INVDataSet"
		Me.INVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SampleEduTableAdapter
		'
		Me.SampleEduTableAdapter.ClearBeforeFill = True
		'
		'btMininize
		'
		Me.btMininize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btMininize.BackColor = System.Drawing.Color.Transparent
		Me.btMininize.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.minimize_window_30px
		Me.btMininize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btMininize.FlatAppearance.BorderSize = 0
		Me.btMininize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMininize.Location = New System.Drawing.Point(802, 12)
		Me.btMininize.Name = "btMininize"
		Me.btMininize.Size = New System.Drawing.Size(34, 30)
		Me.btMininize.TabIndex = 25
		Me.btMininize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btMininize.UseVisualStyleBackColor = False
		'
		'btMaximize
		'
		Me.btMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btMaximize.BackColor = System.Drawing.Color.Transparent
		Me.btMaximize.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.maximize_window_30px
		Me.btMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btMaximize.FlatAppearance.BorderSize = 0
		Me.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMaximize.Location = New System.Drawing.Point(842, 12)
		Me.btMaximize.Name = "btMaximize"
		Me.btMaximize.Size = New System.Drawing.Size(34, 30)
		Me.btMaximize.TabIndex = 24
		Me.btMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btMaximize.UseVisualStyleBackColor = False
		'
		'btEdit
		'
		Me.btEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btEdit.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.edit_property_30px
		Me.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btEdit.FlatAppearance.BorderSize = 0
		Me.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btEdit.Location = New System.Drawing.Point(531, 126)
		Me.btEdit.Name = "btEdit"
		Me.btEdit.Size = New System.Drawing.Size(75, 32)
		Me.btEdit.TabIndex = 23
		Me.btEdit.Text = "Edit"
		Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btEdit.UseVisualStyleBackColor = True
		'
		'btClose
		'
		Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btClose.BackColor = System.Drawing.Color.Transparent
		Me.btClose.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.close_window_26px
		Me.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btClose.FlatAppearance.BorderSize = 0
		Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btClose.Location = New System.Drawing.Point(882, 12)
		Me.btClose.Name = "btClose"
		Me.btClose.Size = New System.Drawing.Size(34, 30)
		Me.btClose.TabIndex = 21
		Me.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btClose.UseVisualStyleBackColor = False
		'
		'btScanIsbn
		'
		Me.btScanIsbn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btScanIsbn.BackColor = System.Drawing.Color.Transparent
		Me.btScanIsbn.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.search_database_30px
		Me.btScanIsbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btScanIsbn.FlatAppearance.BorderSize = 0
		Me.btScanIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btScanIsbn.Location = New System.Drawing.Point(346, 23)
		Me.btScanIsbn.Name = "btScanIsbn"
		Me.btScanIsbn.Size = New System.Drawing.Size(34, 30)
		Me.btScanIsbn.TabIndex = 22
		Me.btScanIsbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btScanIsbn.UseVisualStyleBackColor = False
		'
		'btSimpan
		'
		Me.btSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btSimpan.BackgroundImage = Global.ProgramBukuSampleEdu.My.Resources.Resources.save_30px
		Me.btSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btSimpan.FlatAppearance.BorderSize = 0
		Me.btSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btSimpan.Location = New System.Drawing.Point(447, 126)
		Me.btSimpan.Name = "btSimpan"
		Me.btSimpan.Size = New System.Drawing.Size(78, 32)
		Me.btSimpan.TabIndex = 12
		Me.btSimpan.Text = "Simpan"
		Me.btSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btSimpan.UseVisualStyleBackColor = True
		'
		'IsbnSampleDataGridViewTextBoxColumn
		'
		Me.IsbnSampleDataGridViewTextBoxColumn.DataPropertyName = "IsbnSample"
		Me.IsbnSampleDataGridViewTextBoxColumn.FillWeight = 449.2386!
		Me.IsbnSampleDataGridViewTextBoxColumn.HeaderText = "IsbnSample"
		Me.IsbnSampleDataGridViewTextBoxColumn.Name = "IsbnSampleDataGridViewTextBoxColumn"
		Me.IsbnSampleDataGridViewTextBoxColumn.ReadOnly = True
		Me.IsbnSampleDataGridViewTextBoxColumn.Width = 150
		'
		'KodeSampleDataGridViewTextBoxColumn
		'
		Me.KodeSampleDataGridViewTextBoxColumn.DataPropertyName = "KodeSample"
		Me.KodeSampleDataGridViewTextBoxColumn.FillWeight = 12.69035!
		Me.KodeSampleDataGridViewTextBoxColumn.HeaderText = "KodeSample"
		Me.KodeSampleDataGridViewTextBoxColumn.Name = "KodeSampleDataGridViewTextBoxColumn"
		Me.KodeSampleDataGridViewTextBoxColumn.ReadOnly = True
		Me.KodeSampleDataGridViewTextBoxColumn.Width = 130
		'
		'JudulDataGridViewTextBoxColumn
		'
		Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "Judul"
		Me.JudulDataGridViewTextBoxColumn.FillWeight = 12.69035!
		Me.JudulDataGridViewTextBoxColumn.HeaderText = "Judul"
		Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
		Me.JudulDataGridViewTextBoxColumn.ReadOnly = True
		Me.JudulDataGridViewTextBoxColumn.Width = 350
		'
		'QtyDataGridViewTextBoxColumn
		'
		Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
		Me.QtyDataGridViewTextBoxColumn.FillWeight = 12.69035!
		Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
		Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
		Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
		Me.QtyDataGridViewTextBoxColumn.Width = 75
		'
		'PublisherDataGridViewTextBoxColumn
		'
		Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
		Me.PublisherDataGridViewTextBoxColumn.FillWeight = 12.69035!
		Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
		Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
		Me.PublisherDataGridViewTextBoxColumn.ReadOnly = True
		Me.PublisherDataGridViewTextBoxColumn.Width = 183
		'
		'lbScanIsbnTemp
		'
		Me.lbScanIsbnTemp.AutoSize = True
		Me.lbScanIsbnTemp.Location = New System.Drawing.Point(13, 486)
		Me.lbScanIsbnTemp.Name = "lbScanIsbnTemp"
		Me.lbScanIsbnTemp.Size = New System.Drawing.Size(10, 13)
		Me.lbScanIsbnTemp.TabIndex = 26
		Me.lbScanIsbnTemp.Text = "."
		'
		'formInputBuku
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Violet
		Me.ClientSize = New System.Drawing.Size(928, 542)
		Me.Controls.Add(Me.lbScanIsbnTemp)
		Me.Controls.Add(Me.btMininize)
		Me.Controls.Add(Me.btMaximize)
		Me.Controls.Add(Me.btEdit)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btClose)
		Me.Controls.Add(Me.gbStatusKoneksi)
		Me.Controls.Add(Me.gbDataSample)
		Me.Controls.Add(Me.gbDataBuku)
		Me.Controls.Add(Me.gbScanIsbn)
		Me.Controls.Add(Me.btSimpan)
		Me.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "formInputBuku"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formBukuSample"
		Me.gbScanIsbn.ResumeLayout(False)
		Me.gbScanIsbn.PerformLayout()
		Me.gbDataBuku.ResumeLayout(False)
		Me.gbDataBuku.PerformLayout()
		Me.gbDataSample.ResumeLayout(False)
		Me.gbDataSample.PerformLayout()
		Me.gbStatusKoneksi.ResumeLayout(False)
		Me.gbStatusKoneksi.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.dgvSampleEdu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SampleEduBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbScanISBN As Label
	Friend WithEvents tbjudul As TextBox
	Friend WithEvents lbjudul As Label
	Friend WithEvents tbIsbnSample As TextBox
	Friend WithEvents lbIsbnSample As Label
	Friend WithEvents tbKodeJual As TextBox
	Friend WithEvents lbKodeAsli As Label
	Friend WithEvents tbKodeSample As TextBox
	Friend WithEvents lbKodeSample As Label
	Friend WithEvents tbQty As TextBox
	Friend WithEvents lbQty As Label
	Friend WithEvents btSimpan As Button
	Public WithEvents Label1 As Label
	Public WithEvents Label2 As Label
	Friend WithEvents tbPublisher As TextBox
	Friend WithEvents lbPublisher As Label
	Friend WithEvents gbScanIsbn As GroupBox
	Friend WithEvents gbDataBuku As GroupBox
	Friend WithEvents gbDataSample As GroupBox
	Friend WithEvents gbStatusKoneksi As GroupBox
	Friend WithEvents btClose As Button
	Friend WithEvents btScanIsbn As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents INVDataSet As INVDataSet
	Friend WithEvents SampleEduBindingSource As BindingSource
	Friend WithEvents SampleEduTableAdapter As INVDataSetTableAdapters.SampleEduTableAdapter
	Friend WithEvents btEdit As Button
	Friend WithEvents btMaximize As Button
	Friend WithEvents btMininize As Button
	Friend WithEvents IsbnSampleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents KodeSampleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Public WithEvents dgvSampleEdu As DataGridView
	Public WithEvents tbScanISBN As TextBox
	Public WithEvents lbScanIsbnTemp As Label
End Class
