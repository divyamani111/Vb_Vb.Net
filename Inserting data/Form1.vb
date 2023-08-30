Imports System.Data.SqlClient

Public Class Form1
    Dim connection As New SqlConnection("Data Source=DESKTOP-T4F5P7T\SQLEXPRESS; Initial Catalog=Student_detail; Integrated Security=True")
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim command As New SqlCommand("INSERT INTO table1(id2,name,tel,Age) VALUES(@id2,@name,@tel,@Age)", connection)
        command.Parameters.AddWithValue("@id2", txt_id2.Text)
        command.Parameters.AddWithValue("@name", txt_name.Text)
        command.Parameters.AddWithValue("@tel", txt_tel.Text)
        command.Parameters.AddWithValue("@Age", txt_Age.Text)
        connection.Open()
        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show("New user Added")
        Else
            MessageBox.Show("User Not Added")

        End If
        connection.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim command As New SqlCommand("UPDATE table1 SET id2=@id2,name=@name,tel=@tel,Age=@Age WHERE id=@id", connection)
        command.Parameters.AddWithValue("@id", txtbox_id.Text)
        command.Parameters.AddWithValue("@id2", txt_id2.Text)
        command.Parameters.AddWithValue("@name", txt_name.Text)
        command.Parameters.AddWithValue("@tel", txt_tel.Text)
        command.Parameters.AddWithValue("@Age", txt_Age.Text)
        connection.Open()
        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show("Updated successfully")
        Else
            MessageBox.Show("Not Updated")
        End If
        connection.Close()
    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtbox_id.Text = ""
        txt_id2.Text = ""
        txt_name.Text = ""
        txt_tel.Text = ""
        txt_Age.Text = ""


    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim command As New SqlCommand("DELETE FROM table1 WHERE id=@id", connection)
        command.Parameters.AddWithValue("@id", txtbox_id.Text)
        connection.Open()
        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show("Deleted Successfully")
        Else
            MessageBox.Show("Not Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim command As New SqlCommand("SELECT * FROM table1 WHERE id=@id", connection)
        command.Parameters.AddWithValue("@id", txtbox_id.Text)
        Dim adapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        txt_id2.Text = ""
        txt_name.Text = ""
        txt_tel.Text = ""
        txt_Age.Text = ""
        If datatable.Rows.Count() > 0 Then
            txt_id2.Text = datatable.Rows(0)(1).ToString()
            txt_name.Text = datatable.Rows(0)(2).ToString()
            txt_tel.Text = datatable.Rows(0)(3).ToString()
            txt_Age.Text = datatable.Rows(0)(4).ToString()
        Else
            MessageBox.Show("No data found")
        End If


    End Sub
End Class
