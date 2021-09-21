Imports System.Data.SqlClient

Public Class formInputBuku

	Sub RefreshDGVSampleEdu()
		Call konekINV()
		Da = New SqlDataAdapter("SELECT IsbnSample,KodeSample,Judul,Qty,Publisher FROM SampleEdu", ConnINV)
		Ds = New DataSet
		Da.Fill(Ds)
		dgvSampleEdu.DataSource = Ds.Tables(0)
		dgvSampleEdu.Refresh()
		ConnINV.Close()

	End Sub
	Private Sub formInputBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'INVDataSet.SampleEdu' table. You can move, or remove it, as needed.
		Me.SampleEduTableAdapter.Fill(Me.INVDataSet.SampleEdu)

		tbScanISBN.Focus()

		Call konekBRDJKT()
		Call konekINV()


		tbKodeSample.Enabled = False
		tbjudul.Enabled = False
		tbKodeJual.Enabled = False
		tbKodeSample.Enabled = False
		tbPublisher.Enabled = False
		Me.ActiveControl = tbScanISBN

		tbScanISBN.Text = ""
		lbScanIsbnTemp.Visible = False
	End Sub


	Private Sub tbScanISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbScanISBN.KeyPress

		If e.KeyChar = Chr(13) Then
			btScanIsbn.PerformClick()

		End If

	End Sub

	Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
		If e.KeyChar = Chr(13) Then
			btSimpan.PerformClick()

		End If

	End Sub

	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
		Me.Close()
	End Sub

	Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
		Call konekINV()
		Dim JudulBaru As String = tbjudul.Text
			JudulBaru = JudulBaru.Replace("'", "''")

			Dim Simpan As String = "INSERT INTO SampleEdu (IsbnAsli,IsbNSample,Judul,KodeJual,KodeSample,Qty,Publisher) VALUES ('" & tbScanISBN.Text & "','" & tbIsbnSample.Text & "','" & JudulBaru & "','" & tbKodeJual.Text & "','" & tbKodeSample.Text & "'," & tbQty.Text & ",'" & tbPublisher.Text & "')"
			Cmd = New SqlCommand(Simpan, ConnINV)
			Cmd.ExecuteNonQuery()
			tbScanISBN.Text = ""
			tbKodeSample.Text = ""
			tbjudul.Text = ""
			tbKodeJual.Text = ""
			tbKodeSample.Text = ""
			tbQty.Text = ""
			tbPublisher.Text = ""
			tbIsbnSample.Text = ""

			tbScanISBN.Focus()

			Call RefreshDGVSampleEdu()
		ConnINV.Close()






	End Sub

	Private Sub btScanIsbn_Click(sender As Object, e As EventArgs) Handles btScanIsbn.Click
		Call konekBRDJKT()
		Call konekINV()

		Call konekINV()
		Dim CmdCek As SqlCommand
		Dim DrCek As SqlDataReader
		CmdCek = New SqlCommand("SELECT IsbnAsli FROM SampleEdu WHERE IsbnAsli = '" & tbScanISBN.Text & "' ", ConnINV)
		DrCek = CmdCek.ExecuteReader
		If DrCek.HasRows Then
			'MsgBox("Maaf Kode Buku Sudah Ada, Lakukan Edit Data")

			lbScanIsbnTemp.Text = tbScanISBN.Text
			tbKodeSample.Text = ""
			tbjudul.Text = ""
			tbKodeJual.Text = ""
			tbKodeSample.Text = ""
			tbQty.Text = ""
			tbPublisher.Text = ""
			tbIsbnSample.Text = ""
			DrCek.Close()
			CmdCek.ExecuteReader.Close()
			ConnINV.Close()
			formEdit.Show()
			Me.Hide()
			tbScanISBN.Text = ""


		Else
			Dim DrBukuAda As SqlDataReader
			Dim CmdBukuAda As SqlCommand
			CmdBukuAda = New SqlCommand(" SELECT a.FMTITEMNO AS IsbnSample,b.ITEMNO AS IsbnAsli,a.[DESC] AS Judul,a.OPTFLD4 AS KodeSample,b.OPTFLD4 AS KodeJual,c.
								DATA AS Publisher
								FROM BRDJKT..ICITEM a
								JOIN BRDJKT..ICITEM b
								ON
								a.COMMENT1 = b.FMTITEMNO
								JOIN
								BRDJKT..CSOPT c
								ON
								b.OPTFLD5 = c.CODE WHERE a.COMMENT1 ='" & tbScanISBN.Text & "' ", ConnBRDJKT)
			DrBukuAda = CmdBukuAda.ExecuteReader
			DrBukuAda.Read()
			If DrBukuAda.HasRows Then
				tbKodeJual.Text = DrBukuAda.Item("KodeJual")
				tbIsbnSample.Text = DrBukuAda.Item("IsbnSample")
				tbjudul.Text = DrBukuAda.Item("Judul")
				tbKodeSample.Text = DrBukuAda.Item("KodeSample")
				tbPublisher.Text = DrBukuAda.Item("Publisher")
				tbQty.Focus()
				DrBukuAda.Close()
				CmdBukuAda.ExecuteReader.Close()
				ConnBRDJKT.Close()


			Else
				Dim ConnBukuSample As SqlConnection
				ConnBukuSample = New SqlConnection("Server = SRV4 ; Initial Catalog = BRDJKT ; User ID = sa; Password = ")
				ConnBukuSample.Open()
				Dim CmdBukuSample As SqlCommand
				Dim DrBukuSample As SqlDataReader
				CmdBukuSample = New SqlCommand(" SELECT a.FMTITEMNO AS IsbnSample,a.ITEMNO AS IsbnAsli,a.[DESC] AS Judul,a.OPTFLD4 AS KodeSample,a.OPTFLD4 AS KodeJual,b.
									DATA AS Publisher
									FROM BRDJKT..ICITEM a
									JOIN
									BRDJKT..CSOPT b
									ON
									a.OPTFLD5 = b.CODE
								    WHERE a.COMMENT1 ='" & tbScanISBN.Text & "' ", ConnBukuSample)
				DrBukuSample = CmdBukuSample.ExecuteReader()
				DrBukuSample.Read()
				If DrBukuSample.HasRows Then
					tbKodeJual.Text = DrBukuSample.Item("KodeJual")
					tbIsbnSample.Text = DrBukuSample.Item("IsbnSample")
					tbjudul.Text = DrBukuSample.Item("Judul")
					tbKodeSample.Text = DrBukuSample.Item("KodeSample")
					tbPublisher.Text = DrBukuSample.Item("Publisher")
					tbQty.Focus()
					DrBukuSample.Close()
					CmdBukuSample.ExecuteReader.Close()
					ConnBukuSample.Close()

				Else
					MsgBox("Buku Tidak Ada")
					tbScanISBN.Text = ""
					tbKodeSample.Text = ""
					tbjudul.Text = ""
					tbKodeJual.Text = ""
					tbKodeSample.Text = ""
					tbQty.Text = ""
					tbPublisher.Text = ""
					tbIsbnSample.Text = ""
				End If


			End If
		End If

	End Sub

	Private Sub btMaximize_Click(sender As Object, e As EventArgs) Handles btMaximize.Click
		If Me.WindowState = FormWindowState.Maximized Then
			Me.WindowState = FormWindowState.Normal
		Else
			Me.WindowState = FormWindowState.Maximized

		End If

	End Sub

	Private Sub btMininize_Click(sender As Object, e As EventArgs) Handles btMininize.Click
		Me.WindowState = FormWindowState.Minimized

	End Sub
End Class
