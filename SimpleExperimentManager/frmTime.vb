
Public Class frmTime

    Public intCounter As Integer
    Public dblTime, dblExpTimeLeft As Double

    Private Sub tmrTimeUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTimeUpdate.Tick
        Dim objNow As Date = DateTime.Now, dblUsedTime As Double, strTime As String
        ' Determine computer time
        dblTime = Math.Round(objNow.Hour * 360000 + objNow.Minute * 6000 + objNow.Second * 100 + objNow.Millisecond / 10)
        dblExpTimeLeft = frmMain.numExpTime.Value - (dblTime - frmMain.dblTimeZero) / 100 + frmMain.intExtendTime
        ' Update experiment time if running
        If frmMain.bolRecord = True And frmMain.chbAutoStop.Checked = True Then
            frmMain.txtTimeLeft.Text = "Time left: " + FormatNumber(Math.Ceiling(dblExpTimeLeft), 0, TriState.True) + " s"
            If dblExpTimeLeft < 30 And dblExpTimeLeft >= 20 Then
                frmMain.txtTimeLeft.BackColor = Color.Yellow
            ElseIf dblExpTimeLeft < 20 And dblExpTimeLeft >= 10 Then
                frmMain.txtTimeLeft.BackColor = Color.Orange
            ElseIf dblExpTimeLeft < 10 Then
                frmMain.txtTimeLeft.BackColor = Color.Red
            Else
                frmMain.txtTimeLeft.BackColor = System.Drawing.SystemColors.Control
            End If
        End If
        ' Stop if necessary
        frmMain.intStopPlayTime = frmMain.intStopPlayTime + tmrTimeUpdate.Interval / 10
        If (frmMain.bolRecord = True And frmMain.chbAutoStop.Checked = True And dblExpTimeLeft < 0) Or (frmMain.bolStopAudioPlaying = True) Then
            frmMain.btnStartStop_Click(sender, Nothing)
        End If
        ' Display information in time display
        If frmMain.chbTimeExperimentMode.Checked = True And frmMain.bolRecord = True Then
            strTime = String.Format("{0:0000.00}", (dblTime - frmMain.dblTimeZero) / 100)
            lblName.Text = frmMain.txtName.Text
        Else
            strTime = Strings.Right(objNow, 8) + "." + Strings.Right(Str(dblTime), 2)
            lblName.Text = Strings.Left(objNow, 10)
        End If
        lblTime.Text = strTime
        ' Display time in main form
        If frmMain.bolRecord = True Then
            If frmMain.chbTimeExperimentMode.Checked = True Then
                frmMain.lblMainTime.Text = "Elapsed time: " + strTime + " s"
            Else
                frmMain.lblMainTime.Text = "PC time: " + strTime
            End If
        End If
        ' Play sound if required
        If frmMain.bolRecord = True And frmMain.bolStartAudioPlaying = False And frmMain.chbStartSound.Checked = True Then
            If frmMain.dblTimeZero - dblTime < frmMain.intSoundStart Then
                frmMain.cmbStartSound_SelectedIndexChanged(sender, Nothing)
                My.Computer.Audio.Play(frmMain.objStartSoundFile, AudioPlayMode.Background)
                frmMain.bolStartAudioPlaying = True
            End If
        End If
        ' Change color and text
        If frmMain.bolRecord = True Then
            dblUsedTime = dblTime - frmMain.dblTimeZero
        Else
            dblUsedTime = dblTime
        End If
        If Int(dblUsedTime / 100) Mod frmMain.numTimeChange.Value = 0 Then
            If intCounter = 0 Then
                If lblTime.BackColor = frmMain.objColor2 Then
                    lblTime.BackColor = frmMain.objColor1
                    lblTime.ForeColor = frmMain.objColor2
                Else
                    lblTime.BackColor = frmMain.objColor2
                    lblTime.ForeColor = frmMain.objColor1
                End If
            End If
            intCounter = intCounter + 1
        Else
            intCounter = 0
        End If
        ' Update color if changed
        If lblTime.BackColor = frmMain.objColor2 Then
            lblTime.BackColor = frmMain.objColor2
            lblTime.ForeColor = frmMain.objColor1
        Else
            lblTime.BackColor = frmMain.objColor1
            lblTime.ForeColor = frmMain.objColor2
        End If
        lblName.BackColor = lblTime.BackColor
        lblName.ForeColor = lblTime.ForeColor
        ' Show final text
        lblTime.Font = New Font(New FontFamily("Microsoft Sans Serif"), frmMain.numTimeSize.Value, FontStyle.Bold)
        lblName.Font = New Font(New FontFamily("Microsoft Sans Serif"), frmMain.numTimeSize.Value, FontStyle.Bold)
    End Sub

    Private Sub frmTime_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        AdaptToScreen()
        frmTime_Resize(sender, Nothing)
    End Sub

    Public Sub frmTime_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        lblTime.Height = Me.Size.Height / 2
        lblTime.Width = Me.Size.Width
        lblTime.Location = New Point(0, 0)
        lblName.Height = Me.Size.Height / 2
        lblName.Width = Me.Size.Width
        lblName.Location = New Point(0, Me.Size.Height / 2)
    End Sub

    Public Sub AdaptToScreen()
        Dim CurrentScreen
        ' Define border and maximized prorperty
        If screen.AllScreens.Length = 2 Then
            CurrentScreen = screen.AllScreens(1)
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.Location = CurrentScreen.Bounds.Location + New Point(100, 100)
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.WindowState = FormWindowState.Normal
            Me.Location = New Point(frmMain.Location.X + frmMain.Size.Width + 15, frmMain.Location.Y)
            Me.Size = New Size(800, frmMain.Size.Height)
        End If
    End Sub

End Class