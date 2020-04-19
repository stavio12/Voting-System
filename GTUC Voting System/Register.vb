Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class Register
    Private fcon As New FirebaseConfig() With
    {
  .AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
  .BasePath = "https://vbeng-25e59.firebaseio.com/"
    }

    Private client As IFirebaseClient





    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try     'Setting up Database Connection
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("There was a problem with the connection")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(IndexNO.Text) Or
         String.IsNullOrWhiteSpace(Session.Text) Or String.IsNullOrWhiteSpace(Email.Text) Then
            MsgBox("Please Fill All The Fields", MsgBoxStyle.Exclamation)

        Else

            Dim std As New Student() With
             {
                 .Fullname = Fullname.Text,
                 .IndexNO = IndexNO.Text,
                 .Session = Session.Text,
                 .Email = Email.Text,
                 .Password = Password.Text
               }
            MessageBox.Show("Welcome To GTUC" + Fullname.Text)
            Dim StudentDetail = client.Set("StudentList/" + IndexNO.Text, std)

        End If



    End Sub
End Class