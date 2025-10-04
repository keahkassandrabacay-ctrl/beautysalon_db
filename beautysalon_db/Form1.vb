Imports System.Data.Common
Imports System.Data.Odbc

Public Class Form1
    Dim lst As ListViewItem
    Dim customerID As String

    Public Sub LoadAP()
        sql = "SELECT * FROM customers_tbl"
        cmd = New OdbcCommand(sql, connection)
        dr = cmd.ExecuteReader
        LaVp.Items.Clear()
        Dim counter As Integer = 0
        While dr.Read
            counter = counter + 1
            lst = LaVp.Items.Add(dr.Item("id"))
            lst.SubItems.Add(counter)
            lst.SubItems.Add(dr.Item("name"))
            lst.SubItems.Add(dr.Item("contact_number"))
            lst.SubItems.Add(dr.Item("age"))
            lst.SubItems.Add(dr.Item("gender"))

        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MyConnection()
        LoadAP()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MsgBox("Your name is required!", vbExclamation, "Salon Message!")
            txtName.Focus()
        ElseIf txtContactNumber.Text = "" Then
            MsgBox("Your contact number is required!", vbExclamation, "Salon Message!")
            txtContactNumber.Focus()
        ElseIf txtAge.Text = "" Then
            MsgBox("Your age is required!", vbExclamation, "Salon Message!")
            txtAge.Focus()
        ElseIf txtGender.Text = "" Then
            MsgBox("Your gender is required!", vbExclamation, "Salon Message!")
            txtGender.Focus()
        Else
            sql = "INSERT INTO customers_tbl (name, contact_number, age, gender) VALUES ('" & txtName.Text & "', '" & txtContactNumber.Text & "', '" & txtAge.Text & "', '" & txtGender.Text & "')"
            cmd = New OdbcCommand(sql, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Saved!", vbExclamation, "Salon Message!")
            LoadAP()
            txtName.Text = ""
            txtContactNumber.Text = ""
            txtAge.Text = ""
            txtGender.Text = ""
            txtName.Focus()
        End If

    End Sub

    Private Sub LaVp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LaVp.SelectedIndexChanged

    End Sub

    Private Sub LaVp_Click(sender As Object, e As EventArgs) Handles LaVp.Click
        customerID = LaVp.SelectedItems(0).SubItems(0).Text
        txtName.Text = LaVp.SelectedItems(0).SubItems(2).Text
        txtContactNumber.Text = LaVp.SelectedItems(0).SubItems(3).Text
        txtAge.Text = LaVp.SelectedItems(0).SubItems(4).Text
        txtGender.Text = LaVp.SelectedItems(0).SubItems(5).Text
        btnSave.Enabled = False
        btnSaveChanges.Enabled = True
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If txtName.Text = "" Then
            MsgBox("Your name is required!", vbExclamation, "Salon Message!")
            txtName.Focus()
        ElseIf txtContactNumber.Text = "" Then
            MsgBox("Your contact number is required!", vbExclamation, "Salon Message!")
            txtContactNumber.Focus()
        ElseIf txtAge.Text = "" Then
            MsgBox("Your age is required!", vbExclamation, "Salon Message!")
            txtAge.Focus()
        ElseIf txtGender.Text = "" Then
            MsgBox("Your gender is required!", vbExclamation, "Salon Message!")
            txtGender.Focus()
        Else
            sql = "UPDATE customers_tbl SET name = '" & txtName.Text & "', contact_number = '" & txtContactNumber.Text & "', age = '" & txtAge.Text & "', gender = '" & txtGender.Text & "' WHERE id = '" & customerID & "' "
            cmd = New OdbcCommand(sql, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Changes successfully saved!", vbExclamation, "Salon Message!")
            LoadAP()
            btnSaveChanges.Enabled = False
            btnSave.Enabled = True
            txtName.Text = ""
            txtContactNumber.Text = ""
            txtAge.Text = ""
            txtGender.Text = ""
            txtName.Focus()
        End If

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
