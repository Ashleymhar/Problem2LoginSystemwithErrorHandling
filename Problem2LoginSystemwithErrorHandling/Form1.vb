Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text.Trim()

            If String.IsNullOrEmpty(username) Then
                Throw New LoginFieldEmptyException("Username cannot be empty.")
            End If

            If String.IsNullOrEmpty(password) Then
                Throw New LoginFieldEmptyException("Password cannot be empty.")
            End If
            lblResult.Text = $"Welcome, {username}!"

        Catch ex As LoginFieldEmptyException
            lblResult.Text = ex.Message
        End Try
    End Sub

End Class

' 🔐 Custom Exception for Login System
Public Class LoginFieldEmptyException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

End Class
