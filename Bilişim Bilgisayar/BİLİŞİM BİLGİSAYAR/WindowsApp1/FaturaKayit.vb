Imports System.Data.SqlClient
Public Class Fatura
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.Connection = connection
        SQLcommand.CommandText = "insert into Fatura values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
        SQLcommand.ExecuteNonQuery()
        If (TextBox1.Text <> "") Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Dim sorgu = "Select * from Fatura"
            SQLcommand.Connection = connection
            Dim adaptor = New SqlDataAdapter(sorgu, connection)
            adaptor.Fill(dsv, "Fatura")
            DataGridView1.DataSource = dsv.Tables("Fatura")
            connection.Close()
        Else
            MessageBox.Show("Textler hatalı.")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu As String = "SELECT Fatura.FaturaNo, Musteri.Ad, Musteri.Soyad, Fatura.Tarih, Bulunur.SatisFiyati, Personel.PersonelAdi " &
                     "FROM ((Fatura " &
                     "INNER JOIN Musteri ON Fatura.TcKimlikNo = Musteri.TcKimlikNo) " &
                     "INNER JOIN Bulunur ON Fatura.FaturaNo = Bulunur.FaturaNo) " &
                     "INNER JOIN Personel ON Fatura.PersonelNo = Personel.PersonelNo;"

        SQLcommand.Connection = connection
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "Fatura")
        DataGridView1.DataSource = dsv.Tables("Fatura")
        connection.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim connection As New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM Fatura where FaturaNo ='" + TextBox1.Text + "'"
        SQLcommand.Connection = connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from Fatura"
        SQLcommand.Connection = connection
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "Fatura")
        DataGridView1.DataSource = dsv.Tables("Fatura")
        connection.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.Connection = Connection

        If (TextBox1.Text <> " ") Then
            Dim sorgu = "Select * from Fatura where FaturaNo='" + TextBox1.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Fatura")
            DataGridView1.DataSource = dsv.Tables("Fatura")
        End If
        If (TextBox2.Text <> " ") Then
            Dim sorgu = "Select * from Fatura where Tarih='" + TextBox2.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Fatura")
            DataGridView1.DataSource = dsv.Tables("Fatura")
        End If
        If (TextBox3.Text <> " ") Then
            Dim sorgu = "Select * from Fatura where TcKimlikNo='" + TextBox3.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Fatura")
            DataGridView1.DataSource = dsv.Tables("Fatura")
        End If
        If (TextBox1.Text = "" AndAlso TextBox2.Text = "" AndAlso TextBox3.Text = "") Then
            MessageBox.Show("Herhangi Bir Veri Girmediniz.", "Uyarı!")
        End If
        Connection.Close()
    End Sub

End Class
