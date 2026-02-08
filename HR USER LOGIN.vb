Imports System.Data.OleDb
Public Class HR_USER_LOGIN
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Junior\Desktop\Portfolio Projects\Company\CompanyDBHR.mdb"
    Dim connection As New OleDbConnection(connectionString)

    Sub LoginDetails()
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("@Username", username)
        command.Parameters.AddWithValue("@Password", password)

        Try
            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            If count > 0 Then
                Dim employeeForm As New Employee()
                employeeForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid credentials. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while logging in: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginDetails()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registrationForm As New Form1()
        registrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class