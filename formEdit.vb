Imports System.Data.SqlClient
Public Class formEdit
	Sub RefreshDGVSampleEdu()
		Call konekINV()
		Da = New SqlDataAdapter("SELECT IsbnSample,KodeSample,Judul,Qty,Publisher FROM SampleEdu", ConnINV)
		Ds = New DataSet
		Da.Fill(Ds)
		formInputBuku.dgvSampleEdu.DataSource = Ds.Tables(0)
		formInputBuku.dgvSampleEdu.Refresh()
		ConnINV.Close()

	End Sub
	Private Sub formEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call konekINV()
		Me.ActiveControl = tbQtyTambah
		Cmd = New SqlCommand("SELECT * FROM SampleEdu WHERE IsbnAsli = '" & formInputBuku.lbScanIsbnTemp.Text & "' ", ConnINV)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			tbJudul.Text = Dr.Item("Judul")
			tbIsbnSample.Text = Dr.Item("IsbnSample")
			tbKodeSample.Text = Dr.Item("kodeSample")
			tbQty.Text = Dr.Item("Qty")
		End If

	End Sub
	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
		Me.Close()
		formInputBuku.Show()
	End Sub

	Private Sub tbQtyTambah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQtyTambah.KeyPress
		If e.KeyChar = Chr(13) Then
			Call konekINV()
			Dim JumlahBaru As Integer = Convert.ToInt32(tbQty.Text) + Convert.ToInt32(tbQtyTambah.Text)
			Dim Update As String = ("UPDATE SampleEdu SET Qty =  " & JumlahBaru & " WHERE IsbnSample = '" & tbIsbnSample.Text & "'")
			Cmd = New SqlCommand(Update, ConnINV)
			Cmd.ExecuteNonQuery()
			Me.Close()
			'formInputBuku.tbQty.Text = ""
			formInputBuku.Show()
			Call RefreshDGVSampleEdu()
		End If


	End Sub
End Class