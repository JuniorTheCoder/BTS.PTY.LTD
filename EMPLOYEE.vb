Imports System.Data.OleDb
Public Class Employee
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Junior\Desktop\Portfolio Projects\Company\CompanyDB.mdb"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
    End Sub

    Private Sub LoadEmployees()
        Dim query As String = "SELECT * FROM Employees"
        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Sub Add()
        Dim query As String = "INSERT INTO Employees (FirstName, LastName, Position, Salary) VALUES (@FirstName, @LastName, @Position, @Salary)"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("@FirstName", txtFullName.Text)
        command.Parameters.AddWithValue("@LastName", txtSurname.Text)
        command.Parameters.AddWithValue("@Position", txtPosition.Text)
        command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text))

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        LoadEmployees()
    End Sub

    Sub Update()
        Dim query As String = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Position = @Position, Salary = @Salary WHERE EmployeeID = @EmployeeID"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("@FirstName", txtFullName.Text)
        command.Parameters.AddWithValue("@LastName", txtSurname.Text)
        command.Parameters.AddWithValue("@Position", txtPosition.Text)
        command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text))
        command.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value))

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        LoadEmployees()
    End Sub

    Sub Delete()
        Dim query As String = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value))

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        LoadEmployees()
    End Sub

    Sub Search()
        Dim query As String = "SELECT * FROM Employees WHERE FirstName LIKE @Search OR LastName LIKE @Search"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()

        connection.Open()
        adapter.SelectCommand = command
        adapter.Fill(table)
        connection.Close()
        DataGridView1.DataSource = table
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class