Imports System.Data.SqlClient


Module ModuleKoneksi
	Public ConnBRDJKT As SqlConnection
	Public ConnINV As SqlConnection
	Public Cmd As SqlCommand
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet

	Sub konekBRDJKT()
		Try
			ConnBRDJKT = New SqlConnection("Server = SRV4 ; Initial Catalog = BRDJKT ; User ID = sa; Password = ")
			ConnBRDJKT.Open()
			formInputBuku.Label1.Text = "BRDJKT Connect"
		Catch ex As Exception
			formInputBuku.Label1.Text = "BRDJKT Not Connect"

		End Try
	End Sub
	Sub konekINV()
		Try
			ConnINV = New SqlConnection("Server = SRV4 ; Initial Catalog = INV ; User ID = sa; Password = ")
			ConnINV.Open()
			formInputBuku.Label2.Text = "INV Connect"
		Catch ex As Exception
			formInputBuku.Label2.Text = "INV Not Connect"
		End Try
	End Sub


End Module
