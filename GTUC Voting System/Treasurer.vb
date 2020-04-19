Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces


Public Class Treasurer
    Private fcon As New FirebaseConfig() With
{
.AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
.BasePath = "https://vbeng-25e59.firebaseio.com/"
}

    Private client As IFirebaseClient


    Private Sub Treasurer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try     'Setting up Database Connection
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("There was a problem with the connection")
        End Try


    End Sub


    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        Dim candidate As String

        If C1.Checked = True Then
            candidate = "Kwame & Esi"
        ElseIf C2.Checked = True Then
            candidate = "Kofi & Esi"

        ElseIf C3.Checked = True Then
            candidate = "Ama & Esi"

        ElseIf C4.Checked = True Then
            candidate = "Kobla & Esi"
        ElseIf C5.Checked = True Then

            candidate = "Ekow & Esi"
        ElseIf C6.Checked = True Then

            candidate = "Fifi & Esi"
        ElseIf C7.Checked = True Then

            candidate = "Kofi & Kobla"
        ElseIf C8.Checked = True Then

            candidate = "Love & Esi"
        ElseIf C9.Checked = True Then

            candidate = "Adjoa & Esi"
        Else
            MessageBox.Show("Please Choose a Presidential Candidate")

        End If


        Dim results As String
        results = MsgBox("DO You Choose To Vote " + candidate + " As Your Treasurer?", MsgBoxStyle.YesNo)
        If results = vbYes Then

            Dim res = client.Get("StudentList/" + indexNo.Text)

            Dim voted = res.ResultAs(Of Voter)()

            Dim voter = client.Set(("Voter/" + indexNo.Text + "/Treasurer"), candidate)

            PRO.Show()
            Me.Hide()
        End If
    End Sub
End Class