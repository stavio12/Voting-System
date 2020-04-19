Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces



Public Class LoginForm
    Private fcon As New FirebaseConfig() With
      {
    .AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
    .BasePath = "https://vbeng-25e59.firebaseio.com/"
      }

    Private client As IFirebaseClient


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try     'Setting up Database Connection
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("There was a problem with the connection")
        End Try
    End Sub


    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'Validate Login Input
        Dim res = client.Get("StudentList/" + indexText.Text)
        Dim User As New Student()
        User = res.ResultAs(Of Student)() 'Getting Database result

        If indexText.Text = Nothing Or PasswordText.Text = Nothing Then
            MsgBox("Please Fill All The Fields", MsgBoxStyle.Exclamation)
            indexText.Clear()
            PasswordText.Clear()
            indexText.Focus()
        ElseIf indexText.Text <> User.IndexNO Or PasswordText.Text <> User.Password Then
            MsgBox("Email or Password Is Incorrect", MsgBoxStyle.Exclamation)
            indexText.Clear()
            PasswordText.Clear()
            indexText.Focus()
        Else
            Vote.Show()


        End If
    End Sub

    Private Sub usernameText_TextChanged(sender As Object, e As EventArgs) Handles indexText.TextChanged

    End Sub

    Private Sub PasswordText_TextChanged(sender As Object, e As EventArgs) Handles PasswordText.TextChanged

    End Sub
End Class
