Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain

    ' Variables used for timing control
    Public Shared objColor1, objColor2 As Color
    Public Shared objStartSoundFile, objStopSoundFile
    Public Shared bolTime, bolStartAudioPlaying, bolStopAudioPlaying As Boolean
    Public Shared intExtendTime, intSoundStart, intSoundStop, intStopPlayTime As Integer
    Public Shared dblTimeZero As Double
    Public objStartTime As Date

    ' Variable used for UDP communication
    Public netUDPSenderTime(0 To 0)
    Public bolUDPSendingTime As Boolean

    ' General variables
    Private Const strKeyLocation As String = "HKEY_CURRENT_USER\"
    Private Const strKeyName As String = "Software\SimpleExperimentManager"
    Private Const intWindowHeight As Integer = 480
    Public bolRecord As Boolean, strFolderLocation As String = ""
    Public ioWriting As System.IO.StreamWriter

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Try loading settings
        If Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strKeyName) Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey(strKeyName)
            cmbTimeColor1.SelectedIndex = 0
            cmbTimeColor2.SelectedIndex = 1
            cmbStartSound.SelectedIndex = 0
            cmbStopSound.SelectedIndex = 0
        Else
            ReadFromRegistry()
        End If
        ' Open time window if required
        If bolTime = True Then
            btnTimeShow.Text = "Hide time"
            frmTime.Show()
            frmTime.tmrTimeUpdate.Interval = 1000 / numTimeFrequency.Value
        Else
            btnTimeShow.Text = "Show time"
        End If
        ' Perform click emulation
        Call chbAutoStop_CheckedChanged(sender, Nothing)
        Call btnIP_Click(sender, Nothing)
        ' Make sure it is the top most
        Me.TopMost = True
        Me.Size = New Size(550, intWindowHeight)
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Save general configuration
        WriteToRegistry()
        ' Close time window
        If bolTime = True Then frmTime.Close()
    End Sub

    Private Sub ReadFromRegistry()
        Dim strIPAddressList, strCurrentIP As String
        numTimeFrequency.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numTimeFrequency", 30))
        numTimeSize.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numTimeSize", 100))
        numTimeChange.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numTimeChange", 10))
        cmbTimeColor1.SelectedIndex = CInt(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "cmbTimeColor1", 0))
        cmbTimeColor2.SelectedIndex = CInt(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "cmbTimeColor2", 1))
        chbTimeExperimentMode.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbTimeExperimentMode", False))
        strIPAddressList = My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "lstRemoteIP", "")
        While strIPAddressList <> ""
            strCurrentIP = Strings.Left(strIPAddressList, InStr(strIPAddressList, ",") - 1)
            strIPAddressList = Strings.Right(strIPAddressList, Len(strIPAddressList) - InStr(strIPAddressList, ","))
            lstRemoteIP.Items.Add(strCurrentIP)
        End While
        chbRemoteDisplay.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbRemoteDisplay", False))
        chbSaveOverwrite.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbSaveOverwrite", False))
        txtName.Text = My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "txtName", "EXP00")
        chbStartSound.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbStartSound", False))
        cmbStartSound.SelectedIndex = CInt(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "cmbStartSound", 0))
        chbStopSound.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbStopSound", False))
        cmbStopSound.SelectedIndex = CInt(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "cmbStopSound", 0))
        chbAutoStop.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbAutoStop", False))
        numCountdown.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numCountdown", 5))
        numExpTime.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numExpTime", 180))
        numExtend.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numExtend", 15))
        strFolderLocation = My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "strFolderLocation", "")
        bolTime = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "bolTime", False))
    End Sub

    Private Sub WriteToRegistry()
        Dim strIPAddressList As String = ""
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numTimeFrequency", numTimeFrequency.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numTimeSize", numTimeSize.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numTimeChange", numTimeChange.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "cmbTimeColor1", CDec(cmbTimeColor1.SelectedIndex))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "cmbTimeColor2", CDec(cmbTimeColor2.SelectedIndex))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbTimeExperimentMode", CDec(chbTimeExperimentMode.Checked))
        For intRemoteDevice As Integer = 0 To lstRemoteIP.Items.Count - 1
            strIPAddressList = strIPAddressList + lstRemoteIP.Items(intRemoteDevice).ToString + ","
        Next
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbRemoteDisplay", CDec(chbRemoteDisplay.Checked))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "lstRemoteIP", strIPAddressList)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbSaveOverwrite", CDec(chbSaveOverwrite.Checked))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "txtName", txtName.Text)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbStartSound", CDec(chbStartSound.Checked))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "cmbStartSound", CDec(cmbStartSound.SelectedIndex))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbStopSound", CDec(chbStopSound.Checked))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "cmbStopSound", CDec(cmbStopSound.SelectedIndex))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbAutoStop", CDec(chbAutoStop.Checked))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numCountdown", numCountdown.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numExpTime", numExpTime.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numExtend", numExtend.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "strFolderLocation", strFolderLocation)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "bolTime", CDec(bolTime))
    End Sub

    Private Function IsPortOpen(ByVal PortNumber As Integer) As Boolean
        Dim Client As UdpClient = Nothing
        Try
            Client = New UdpClient(PortNumber)
            Return True
        Catch ex As SocketException
            Return False
        Finally
            If Not Client Is Nothing Then Client.Close()
        End Try
    End Function

    Public Sub btnStartStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStartStop.Click
        Dim objNow As Date = DateTime.Now, strFilename As String
        If bolRecord = False Then
            ' Start recording
            If My.Computer.FileSystem.DirectoryExists(strFolderLocation) = False Then
                btnBrowse_Click(sender, Nothing)
                Exit Sub
            End If
            ' Write initial information
            If strFolderLocation <> "" Then
                ' Check if file already exists and overwrite if needed
                strFilename = txtName.Text
                If IO.File.Exists(strFolderLocation + "\" + strFilename + ".txt") = True Then
                    If chbSaveOverwrite.Checked = False Then
                        While IO.File.Exists(strFolderLocation + "\" + strFilename + ".txt") = True
                            strFilename = strFilename + "-copy"
                        End While
                    Else
                        IO.File.Delete(strFolderLocation + "\" + strFilename + ".txt")
                    End If
                End If
                ' Initialize basic file
                Try
                    ioWriting = System.IO.File.CreateText(strFolderLocation + "\" + strFilename + ".txt")
                    lblComment.Text = txtName.Text
                    btnComment.Enabled = True
                Catch
                    MsgBox("History file is open by another program, close file to continue!", MsgBoxStyle.Critical, "File in use")
                    Exit Sub
                End Try
            End If
            ' Start recording and perform initial operations
            objStartTime = DateTime.Now
            bolRecord = True
            intExtendTime = 0
            dblTimeZero = frmTime.dblTime + numCountdown.Value * 100
            My.Computer.Audio.Stop()
            ' Change window appearance
            ControlOnOff(False)
            Me.ControlBox = False
            btnStartStop.Text = "STOP"
            btnStartStop.BackColor = Color.Red
            cmbStartSound.Enabled = False
            cmbStopSound.Enabled = False
            lstRemoteIP.Enabled = False
            txtComment.Text = ""
        Else
            ' Check for stop audio selection
            If chbStartSound.Checked = True And bolStopAudioPlaying = False Then My.Computer.Audio.Stop()
            If chbStopSound.Checked = True Then
                ' First play stop sound
                If bolStopAudioPlaying = False Then
                    cmbStopSound_SelectedIndexChanged(sender, Nothing)
                    My.Computer.Audio.Play(objStopSoundFile, AudioPlayMode.Background)
                    bolStopAudioPlaying = True
                    intStopPlayTime = 0
                    btnStartStop.Enabled = False
                    numExtend.Enabled = False
                    btnExtend.Enabled = False
                    Exit Sub
                End If
                ' When finished proceed
                If intStopPlayTime > Math.Max(intSoundStop, 150) And bolStopAudioPlaying = True Then
                    btnStartStop.Enabled = True
                    numExtend.Enabled = chbAutoStop.Checked
                    btnExtend.Enabled = chbAutoStop.Checked
                Else
                    Exit Sub
                End If
            End If
            ' Stop recording and save basic file
            bolRecord = False
            btnSaveComment_Click(sender, Nothing)
            ioWriting.WriteLine("********************* INFORMATION *********************")
            ioWriting.WriteLine("Start Time: " + objStartTime)
            ioWriting.WriteLine("End Time: " + objNow)
            ioWriting.WriteLine("Original name: " + txtName.Text)
            If txtComment.Text <> "" Then
                ioWriting.WriteLine("********************** COMMENTS ***********************")
                ioWriting.WriteLine(txtComment.Text)
            End If
            ioWriting.Close()
            ' Change window appearance
            ControlOnOff(True)
            Me.ControlBox = True
            btnStartStop.Text = "START"
            btnStartStop.BackColor = System.Drawing.SystemColors.ControlLight
            cmbStartSound.Enabled = chbStartSound.Checked
            cmbStopSound.Enabled = chbStopSound.Checked
            btnComment.Enabled = False
            bolStartAudioPlaying = False
            bolStopAudioPlaying = False
            lblMainTime.Text = ""
            txtTimeLeft.Text = ""
            txtTimeLeft.BackColor = System.Drawing.SystemColors.Control
            lstRemoteIP.Enabled = Not chbRemoteDisplay.Checked
            ' Final operations
            UpdateExpName()
        End If
    End Sub

    Public Sub ControlOnOff(ByVal bolStatus As Boolean)
        txtName.Enabled = bolStatus
        chbStartSound.Enabled = bolStatus
        chbStopSound.Enabled = bolStatus
        chbAutoStop.Enabled = bolStatus
        numCountdown.Enabled = bolStatus
        numExpTime.Enabled = bolStatus
        btnTimeShow.Enabled = bolStatus
        chbSaveOverwrite.Enabled = bolStatus
        btnBrowse.Enabled = bolStatus
        btnAbout.Enabled = bolStatus
        btnIP.Enabled = bolStatus
        chbRemoteDisplay.Enabled = bolStatus
    End Sub

    Public Sub UpdateExpName()
        Dim strExpName, strNumber As String
        ' Update name for next experiment
        strExpName = txtName.Text
        If Len(strExpName) > 2 Then
            strNumber = Strings.Right(strExpName, 2)
            If IsNumeric(strNumber) And strNumber <> "99" Then
                strExpName = Strings.Left(strExpName, Len(strExpName) - 2) + (Convert.ToInt32(strNumber) + 1).ToString("D2")
                txtName.Text = strExpName
            End If
        End If
    End Sub

    Private Sub btnIP_Click(sender As System.Object, e As System.EventArgs) Handles btnIP.Click
        Dim strIPAddress As String
        strIPAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(Function(a As IPAddress) Not a.IsIPv6LinkLocal AndAlso Not a.IsIPv6Multicast AndAlso Not a.IsIPv6SiteLocal).First().ToString()
        txtLocalIP.Text = strIPAddress
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strIPAddress As String = InputBox("Provide a valid IP address for the remote display", "IP address", "")
        If strIPAddress = "" Then Exit Sub
        If IsValidIPAddress(strIPAddress) = False Then
            MsgBox("Invalid IP address", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        Else
            lstRemoteIP.Items.Add(strIPAddress)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstRemoteIP.Items.RemoveAt(lstRemoteIP.SelectedIndex)
    End Sub

    Function IsValidIPAddress(ByVal ipAddress As String) As Boolean
        Dim pattern As String = "^(\d{1,3}\.){3}\d{1,3}$"
        Return RegularExpressions.Regex.IsMatch(ipAddress, pattern)
    End Function

    Private Sub cmbTimeColor1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTimeColor1.SelectedIndexChanged
        objColor1 = SetColor(cmbTimeColor1.SelectedIndex)
    End Sub

    Private Sub cmbTimeColor2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTimeColor2.SelectedIndexChanged
        objColor2 = SetColor(cmbTimeColor2.SelectedIndex)
    End Sub

    Private Function SetColor(ByVal intValue As Integer) As Color
        Dim objColor As Color
        Select Case intValue
            Case 0
                objColor = Color.White
            Case 1
                objColor = Color.Black
            Case 2
                objColor = Color.Red
            Case 3
                objColor = Color.Green
            Case 4
                objColor = Color.Blue
            Case 5
                objColor = Color.Yellow
            Case 6
                objColor = Color.Orange
            Case 7
                objColor = Color.Purple
        End Select
        Return objColor
    End Function

    Private Function GetColor(ByVal objColor As Color) As Integer
        Dim intIndex As Integer
        Select Case objColor
            Case Color.White
                intIndex = 0
            Case Color.Black
                intIndex = 1
            Case Color.Red
                intIndex = 2
            Case Color.Green
                intIndex = 3
            Case Color.Blue
                intIndex = 4
            Case Color.Yellow
                intIndex = 5
            Case Color.Orange
                intIndex = 6
            Case Color.Purple
                intIndex = 7
        End Select
        Return intIndex
    End Function

    Private Sub btnCloseTime_Click(sender As System.Object, e As System.EventArgs) Handles btnTimeShow.Click
        If btnTimeShow.Text = "Hide time" Then
            frmTime.Close()
            bolTime = False
            btnTimeShow.Text = "Show time"
        Else
            frmTime.Show()
            frmTime.tmrTimeUpdate.Interval = 1000 / numTimeFrequency.Value
            bolTime = True
            btnTimeShow.Text = "Hide time"
        End If
    End Sub

    Private Sub chbRemoteDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles chbRemoteDisplay.CheckedChanged
        Dim strCurrentIP As String
        ' Check whether option has been checked
        If chbRemoteDisplay.Checked = True Then
            ' Connect all IP addresses
            If lstRemoteIP.Items.Count > 0 Then
                ReDim netUDPSenderTime(0 To lstRemoteIP.Items.Count - 1)
                For intRemoteDevice As Integer = 0 To lstRemoteIP.Items.Count - 1
                    ' Check if port is open
                    strCurrentIP = lstRemoteIP.Items(intRemoteDevice)
                    If IsPortOpen(5555 + intRemoteDevice) = False Then
                        MsgBox("Port " + Str(5555 + intRemoteDevice) + " is not available. Close port and try again." + vbCrLf +
                               "You may need to set up an exception in the firewall." + vbCrLf +
                               "Connection will be aborted for " + strCurrentIP, MsgBoxStyle.Critical, "Remote display connection error")
                        Exit Sub
                    End If
                    ' Start connection
                    netUDPSenderTime(intRemoteDevice) = New UdpClient(CInt(5555 + intRemoteDevice))
                    netUDPSenderTime(intRemoteDevice).Connect(strCurrentIP, 5555)
                Next
                ' Set connection ON
                bolUDPSendingTime = True
                tmrRemoteDisplay.Interval = 1000 / numTimeFrequency.Value
                tmrRemoteDisplay.Enabled = True
            End If
        Else
            For intRemoteDevice As Integer = 0 To netUDPSenderTime.Length - 1
                If Not IsNothing(netUDPSenderTime(intRemoteDevice)) Then netUDPSenderTime(intRemoteDevice).close()
            Next
            tmrRemoteDisplay.Enabled = False
            bolUDPSendingTime = False
        End If
        lstRemoteIP.Enabled = Not chbRemoteDisplay.Checked
        btnAdd.Enabled = Not chbRemoteDisplay.Checked
        btnRemove.Enabled = Not chbRemoteDisplay.Checked
    End Sub

    Private Sub tmrRemoteDisplay_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRemoteDisplay.Tick
        Dim strMessage, strColors As String, dblTime As Double, objNow As Date = DateTime.Now
        ' Determine main part of the message
        If bolRecord = False Or chbTimeExperimentMode.Checked = False Then
            strMessage = "0," + objNow.ToString("dd/MM/yyyy") + "," + Date.Now.ToString("HH:mm:ss.ff")
        Else
            dblTime = Math.Round(objNow.Hour * 360000 + objNow.Minute * 6000 + objNow.Second * 100 + objNow.Millisecond / 10)
            strMessage = "1," + txtName.Text + "," + String.Format("{0:0000.00}", (dblTime - frmMain.dblTimeZero) / 100)
        End If
        ' Add format information and send
        strColors = CStr(GetColor(frmTime.lblTime.BackColor)) + "," + CStr(GetColor(frmTime.lblTime.ForeColor))
        strMessage = strMessage + "," + CStr(numTimeSize.Value) + "," + CStr(numTimeChange.Value) + "," + strColors
        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(strMessage)
        For intRemoteDevice As Integer = 0 To netUDPSenderTime.Length - 1
            netUDPSenderTime(intRemoteDevice).Send(sendBytes, sendBytes.Length)
        Next
    End Sub

    Private Sub btnExtend_Click(sender As System.Object, e As System.EventArgs) Handles btnExtend.Click
        intExtendTime = intExtendTime + numExtend.Value
    End Sub

    Private Sub chbAutoStop_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbAutoStop.Click
        numExtend.Enabled = chbAutoStop.Checked
        btnExtend.Enabled = chbAutoStop.Checked
    End Sub

    Private Sub chbStartSound_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbStartSound.CheckedChanged
        If bolRecord = False Then cmbStartSound.Enabled = chbStartSound.Checked
        If numCountdown.Value < Math.Ceiling(intSoundStart / 100) Then numCountdown.Value = Math.Ceiling(intSoundStart / 100)
        If chbStartSound.Checked = True Then
            numCountdown.Minimum = Math.Ceiling(intSoundStart / 100)
        Else
            numCountdown.Minimum = 0
        End If
    End Sub

    Public Sub cmbStartSound_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbStartSound.SelectedIndexChanged
        If cmbStartSound.SelectedIndex Mod 2 = 0 Then intSoundStart = 250
        If cmbStartSound.SelectedIndex Mod 2 = 1 Then intSoundStart = 500
        Select Case cmbStartSound.SelectedIndex
            Case 0
                objStartSoundFile = My.Resources.EN_A
            Case 1
                objStartSoundFile = My.Resources.EN_B
            Case 2
                objStartSoundFile = My.Resources.JP_A
            Case 3
                objStartSoundFile = My.Resources.JP_B
            Case 4
                objStartSoundFile = My.Resources.CN_A
            Case 5
                objStartSoundFile = My.Resources.CN_B
            Case 6
                objStartSoundFile = My.Resources.DE_A
            Case 7
                objStartSoundFile = My.Resources.DE_B
            Case 8
                objStartSoundFile = My.Resources.FR_A
            Case 9
                objStartSoundFile = My.Resources.FR_B
            Case 10
                objStartSoundFile = My.Resources.ES_A
            Case 11
                objStartSoundFile = My.Resources.ES_B
            Case 12
                objStartSoundFile = My.Resources.IT_A
            Case 13
                objStartSoundFile = My.Resources.IT_B
        End Select
            chbStartSound_CheckedChanged(Me, Nothing)
    End Sub

    Private Sub chbStopSound_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbStopSound.CheckedChanged
        cmbStopSound.Enabled = chbStopSound.Checked
    End Sub

    Public Sub cmbStopSound_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbStopSound.SelectedIndexChanged
        intSoundStop = 100
        Select Case cmbStopSound.SelectedIndex
            Case 0
                objStopSoundFile = My.Resources.EN_C
            Case 1
                objStopSoundFile = My.Resources.JP_C
            Case 2
                objStopSoundFile = My.Resources.CN_C
            Case 3
                objStopSoundFile = My.Resources.DE_C
            Case 4
                objStopSoundFile = My.Resources.FR_C
            Case 5
                objStopSoundFile = My.Resources.ES_C
            Case 6
                objStopSoundFile = My.Resources.IT_C
        End Select
    End Sub

    Private Sub numTimeFrequency_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numTimeFrequency.ValueChanged
        frmTime.tmrTimeUpdate.Interval = 1000 / numTimeFrequency.Value
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim dlgSelectFolder As FolderBrowserDialog = New FolderBrowserDialog
        dlgSelectFolder.Description = "Select folder location for saving experiment data"
        dlgSelectFolder.SelectedPath = strFolderLocation
        Dim intUserAction As Integer = dlgSelectFolder.ShowDialog
        If (intUserAction <> DialogResult.Cancel) Then strFolderLocation = dlgSelectFolder.SelectedPath
    End Sub

    Private Sub chbTimeExperimentMode_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbTimeExperimentMode.CheckedChanged
        If bolRecord = True Then frmTime.frmTime_Resize(sender, Nothing)
    End Sub

    Private Sub btnComment_Click(sender As System.Object, e As System.EventArgs) Handles btnComment.Click
        Me.Size = New Size(550, 655)
        btnComment.Enabled = False
    End Sub

    Private Sub btnSaveComment_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveComment.Click
        Me.Size = New Size(550, intWindowHeight)
        If bolRecord = True Then btnComment.Enabled = True
    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click
        MsgBox("Time keeper and synchronizer for video recorded experiments" + vbCrLf +
               "Use '[experiment name]00' to update experiment number." + vbCrLf +
               "(C) Claudio Feliciani 2024", MsgBoxStyle.Information, "Information")
    End Sub

End Class