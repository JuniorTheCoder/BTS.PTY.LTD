Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Form1
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Junior\Desktop\Portfolio Projects\Company\CompanyDBHR.mdb"
    Dim connection As New OleDbConnection(connectionString)

    Sub RegisterHR()
        Dim regFullName As String = txtRegFullName.Text
        Dim regSurname As String = txtRegSurname.Text
        Dim regEmail As String = txtRegEmail.Text
        Dim regPhone As String = txtRegPhone.Text
        Dim regIDNumber As String = txtRegIDNumber.Text
        Dim regHRID As String = txtRegHRID.Text
        Dim regUsername As String = txtRegUsername.Text
        Dim regPassword As String = txtRegPassword.Text

        ' Basic validation
        If String.IsNullOrWhiteSpace(regFullName) OrElse String.IsNullOrWhiteSpace(regUsername) OrElse String.IsNullOrWhiteSpace(regPassword) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim query As String = "INSERT INTO Users (FullName, Surname, Email, Phone, IDNumber, HREmployeeID, Username, Password) VALUES (@FullName, @Surname, @Email, @Phone, @IDNumber, @HREmployeeID, @Username, @Password)"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("@FullName", regFullName)
        command.Parameters.AddWithValue("@Surname", regSurname)
        command.Parameters.AddWithValue("@Email", regEmail)
        command.Parameters.AddWithValue("@Phone", regPhone)
        command.Parameters.AddWithValue("@IDNumber", regIDNumber)
        command.Parameters.AddWithValue("@HREmployeeID", regHRID)
        command.Parameters.AddWithValue("@Username", regUsername)
        command.Parameters.AddWithValue("@Password", regPassword)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Registration successful! You can now log in.")
            ' Clear fields after successful registration
            txtRegFullName.Clear()
            txtRegSurname.Clear()
            txtRegEmail.Clear()
            txtRegPhone.Clear()
            txtRegIDNumber.Clear()
            txtRegHRID.Clear()
            txtRegUsername.Clear()
            txtRegPassword.Clear()
        Catch ex As OleDbException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

        ' Validate email
        If Not IsValidEmail(regEmail) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        If Not IsStrongPassword(regPassword) Then
            MessageBox.Show("Password must be at least 8 characters long and contain both letters and numbers.")
            Return
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Function IsStrongPassword(password As String) As Boolean
        Return password.Length >= 8 AndAlso password.Any(AddressOf Char.IsDigit) AndAlso password.Any(AddressOf Char.IsLetter)
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterHR()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New HR_USER_LOGIN()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
