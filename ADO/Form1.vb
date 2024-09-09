Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Form1
    ' Declare the connection and command objects
    Dim sqlconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30")
    Dim sqlcomm As New SqlCommand()
    Dim sqldaat As New SqlDataAdapter()
    Dim ds As New DataSet()

    ' Select Operation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sqlconn.Open()
            sqlcomm.Connection = sqlconn
            sqlcomm.CommandText = "SELECT * FROM ado WHERE regno = @regno"
            sqlcomm.Parameters.AddWithValue("@regno", TextBox2.Text)
            sqldaat.SelectCommand = sqlcomm
            ds.Clear()
            sqldaat.Fill(ds, "ado")
            If ds.Tables("ado").Rows.Count > 0 Then
                TextBox1.Text = ds.Tables("ado").Rows(0).Item("name").ToString()
                TextBox3.Text = ds.Tables("ado").Rows(0).Item("dept").ToString()
                MessageBox.Show("Record Found")
            Else
                MessageBox.Show("No Record Found")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlconn.Close()
            sqlcomm.Parameters.Clear()
        End Try
    End Sub

    ' Insert Operation
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            sqlconn.Open()
            sqlcomm.Connection = sqlconn
            sqlcomm.CommandText = "INSERT INTO ado (name, regno, dept) VALUES (@name, @regno, @dept)"
            sqlcomm.Parameters.AddWithValue("@name", TextBox1.Text)
            sqlcomm.Parameters.AddWithValue("@regno", TextBox2.Text)
            sqlcomm.Parameters.AddWithValue("@dept", TextBox3.Text)
            sqlcomm.ExecuteNonQuery()
            MessageBox.Show("Record Inserted")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlconn.Close()
            sqlcomm.Parameters.Clear()
        End Try
    End Sub

    ' Delete Operation
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            sqlconn.Open()
            sqlcomm.Connection = sqlconn
            sqlcomm.CommandText = "DELETE FROM ado WHERE regno = @regno"
            sqlcomm.Parameters.AddWithValue("@regno", TextBox2.Text)
            sqlcomm.ExecuteNonQuery()
            MessageBox.Show("Record Deleted")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlconn.Close()
            sqlcomm.Parameters.Clear()
        End Try
    End Sub

    ' Update Operation
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            sqlconn.Open()
            sqlcomm.Connection = sqlconn
            sqlcomm.CommandText = "UPDATE ado SET name = @name, dept = @dept WHERE regno = @regno"
            sqlcomm.Parameters.AddWithValue("@name", TextBox1.Text)
            sqlcomm.Parameters.AddWithValue("@regno", TextBox2.Text)
            sqlcomm.Parameters.AddWithValue("@dept", TextBox3.Text)
            sqlcomm.ExecuteNonQuery()
            MessageBox.Show("Record Updated")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlconn.Close()
            sqlcomm.Parameters.Clear()
        End Try
    End Sub

    ' Exit Application
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
