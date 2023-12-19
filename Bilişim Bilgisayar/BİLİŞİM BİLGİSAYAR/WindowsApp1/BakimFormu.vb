Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BakimFormu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.Connection = connection
        SQLcommand.CommandText = "insert into BakimOnarim values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
        SQLcommand.ExecuteNonQuery()
        If (TextBox1.Text <> "") Then
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Clear()
            TextBox4.Clear()
            Dim sorgu = "Select * from BakimOnarim"
            SQLcommand.Connection = connection
            Dim adaptor = New SqlDataAdapter(sorgu, connection)
            adaptor.Fill(dsv, "BakimOnarim")
            DataGridView1.DataSource = dsv.Tables("BakimOnarim")
            connection.Close()
        Else
            MessageBox.Show("Textler hatalı.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from BakimOnarim"
        SQLcommand.Connection = connection
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "BakimOnarim")
        DataGridView1.DataSource = dsv.Tables("BakimOnarim")
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.Connection = Connection

        If (TextBox2.Text <> " ") Then
            Dim sorgu = "Select * from BakimOnarim where BakimNo='" + TextBox1.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "BakimOnarim")
            DataGridView1.DataSource = dsv.Tables("BakimOnarim")
        End If
        If (TextBox3.Text <> " ") Then
            Dim sorgu = "Select * from BakimOnarim where TcKimlikNo='" + TextBox2.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "BakimOnarim")
            DataGridView1.DataSource = dsv.Tables("BakimOnarim")
        End If
        If (TextBox1.Text <> " ") Then
            Dim sorgu = "Select * from BakimOnarim where Drum='" + TextBox3.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "BakimOnarim")
            DataGridView1.DataSource = dsv.Tables("BakimOnarim")
        End If
        If (TextBox4.Text <> " ") Then
            Dim sorgu = "Select * from BakimOnarim where Ucret='" + TextBox4.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "BakimOnarim")
            DataGridView1.DataSource = dsv.Tables("BakimOnarim")
        End If
        If (TextBox5.Text <> " ") Then
            Dim sorgu = "Select * from BakimOnarim where PersonelNo='" + TextBox5.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "BakimOnarim")
            DataGridView1.DataSource = dsv.Tables("BakimOnarim")
        End If
        If (TextBox2.Text = "" AndAlso TextBox3.Text = "" AndAlso TextBox1.Text = "" AndAlso TextBox4.Text = "" AndAlso TextBox5.Text = "") Then
            MessageBox.Show("Herhangi Bir Veri Girmediniz.", "Uyarı!")
        End If
        Connection.Close()
    End Sub


End Class