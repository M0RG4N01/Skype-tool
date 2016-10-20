Public Class LoadingScreen
    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(3)

        If ProgressBar1.Value = 100 Then

            Form1.Show()
            Timer1.Stop()
            Me.Close()

        End If

    End Sub
End Class