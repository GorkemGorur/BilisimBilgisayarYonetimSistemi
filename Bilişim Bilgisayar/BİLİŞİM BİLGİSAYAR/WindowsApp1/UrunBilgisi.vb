Imports System.Data.SqlClient
Public Class Urun
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.Connection = connection
        SQLcommand.CommandText = "insert into Urun values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"
        SQLcommand.ExecuteNonQuery()
        If (TextBox1.Text <> "") Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            Dim sorgu = "Select * from Urun"
            SQLcommand.Connection = connection
            Dim adaptor = New SqlDataAdapter(sorgu, connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
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
        Dim sorgu As String = "SELECT Urun.Marka, Urun.Model, Urun.BirimFiyati, Urun.GarantiSuresi, Urun.StokAdedi, UrunGrubu.UrunGrubuAd " &
                      "FROM Urun " &
                      "INNER JOIN UrunGrubu ON Urun.UrunGrubuNo = UrunGrubu.UrunGrubuNo;"
        SQLcommand.Connection = connection
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "Urun")
        DataGridView1.DataSource = dsv.Tables("Urun")
        connection.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password='mmyo'"
        connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.Connection = Connection

        If (TextBox1.Text <> " ") Then
            Dim sorgu = "Select * from Urun where UrunNo='" + TextBox1.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox2.Text <> " ") Then
            Dim sorgu = "Select * from Urun where Marka='" + TextBox2.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox3.Text <> " ") Then
            Dim sorgu = "Select * from Urun where Model='" + TextBox3.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox4.Text <> " ") Then
            Dim sorgu = "Select * from Urun where BirimFiyati='" + TextBox4.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox5.Text <> " ") Then
            Dim sorgu = "Select * from Urun where GarantiSuresi='" + TextBox5.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox6.Text <> " ") Then
            Dim sorgu = "Select * from Urun where StokAdedi='" + TextBox6.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox7.Text <> " ") Then
            Dim sorgu = "Select * from Urun where UrunGrubuNo='" + TextBox7.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Urun")
            DataGridView1.DataSource = dsv.Tables("Urun")
        End If
        If (TextBox1.Text = "" AndAlso TextBox2.Text = "" AndAlso TextBox3.Text = "" AndAlso TextBox4.Text = "" AndAlso TextBox5.Text = "" AndAlso TextBox6.Text = "" AndAlso TextBox7.Text = "") Then
            MessageBox.Show("Herhangi Bir Veri Girmediniz.", "Uyarı!")
        End If
        Connection.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox8.ReadOnly = False
            TextBox9.ReadOnly = False
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "UPDATE Urun set StokAdedi ='" + TextBox9.Text + "' where UrunNo ='" + TextBox8.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from Urun"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "Urunler")
        DataGridView1.DataSource = dsv.Tables("Urunler")
        Connection.Close()
    End Sub
End Class
