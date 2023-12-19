Imports System.Data.SqlClient
Public Class Musteri
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.Connection = connection
        SQLcommand.CommandText = "insert into Musteri values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
        SQLcommand.ExecuteNonQuery()
        If (TextBox1.Text <> "") Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            Dim sorgu = "Select * from Musteri"
            SQLcommand.Connection = connection
            Dim adaptor = New SqlDataAdapter(sorgu, connection)
            adaptor.Fill(dsv, "Musteriler")
            DataGridView1.DataSource = dsv.Tables("Musteriler")
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
        Dim sorgu = "Select * from Musteri"
        SQLcommand.Connection = connection
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "Musteriler")
        DataGridView1.DataSource = dsv.Tables("Musteriler")
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Dim connection As New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM Musteri where TcKimlikNo ='" + TextBox1.Text + "'"
        SQLcommand.Connection = connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from Musteri"
        SQLcommand.Connection = connection
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "Musteri")
        DataGridView1.DataSource = dsv.Tables("Musteri")
        connection.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.Connection = Connection

        If (TextBox2.Text <> " ") Then
            Dim sorgu = "Select * from Musteri where Ad='" + TextBox2.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Musteri")
            DataGridView1.DataSource = dsv.Tables("Musteri")
        End If
        If (TextBox3.Text <> " ") Then
            Dim sorgu = "Select * from Musteri where Soyad='" + TextBox3.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Musteri")
            DataGridView1.DataSource = dsv.Tables("Musteri")
        End If
        If (TextBox1.Text <> " ") Then
            Dim sorgu = "Select * from Musteri where TcKimlikNo='" + TextBox1.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Musteri")
            DataGridView1.DataSource = dsv.Tables("Musteri")
        End If
        If (TextBox4.Text <> " ") Then
            Dim sorgu = "Select * from Musteri where Telefon='" + TextBox4.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Musteri")
            DataGridView1.DataSource = dsv.Tables("Musteri")
        End If
        If (TextBox5.Text <> " ") Then
            Dim sorgu = "Select * from Musteri where Adres='" + TextBox5.Text + "'"
            Dim adaptor = New SqlDataAdapter(sorgu, Connection)
            adaptor.Fill(dsv, "Musteri")
            DataGridView1.DataSource = dsv.Tables("Musteri")
        End If
        If (TextBox1.Text = "" AndAlso TextBox2.Text = "" AndAlso TextBox3.Text = "" AndAlso TextBox4.Text = "" AndAlso TextBox5.Text = "") Then
            MessageBox.Show("Herhangi Bir Veri Girmediniz.", "Uyarı!")
        End If
        Connection.Close()
    End Sub

    ''' Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
    ''' If RadioButton1.Checked Then
    '''      TextBox6.ReadOnly = False
    '''   TextBox7.ReadOnly = False
    ''' Button5.Enabled = True

    '''    End If
    ''' End Sub
    ''' Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '''Dim Connection As New SqlConnection
    '''Dim dsv As New DataSet
    ''' Connection.ConnectionString = "Data Source=DESKTOP-P5BEV2M\SQLEXPRESS;Initial Catalog=PcMarket;User ID=sa;Password='mmyo'"
    '''Connection.Open()
    '''    Dim SQLcommand As New SqlCommand
    '''     SQLcommand.CommandText = "UPDATE Musteri set Ad ='" + TextBox7.Text + "' where Ad ='" + TextBox6.Text + "'"
    '''  SQLcommand.Connection = Connection
    '''SQLcommand.ExecuteNonQuery()
    '''    Dim sorgu = "Select * from Musteri"
    '''     SQLcommand.Connection = Connection
    '''Dim adaptor = New SqlDataAdapter(sorgu, Connection)
    '''   adaptor.Fill(dsv, "musteriler")
    ''' DataGridView1.DataSource = dsv.Tables("musteriler")
    '''Connection.Close()
    '''End Sub

End Class
