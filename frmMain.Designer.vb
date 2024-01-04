<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.chbSaveOverwrite = New System.Windows.Forms.CheckBox()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.grbClock = New System.Windows.Forms.GroupBox()
        Me.btnTimeShow = New System.Windows.Forms.Button()
        Me.chbTimeExperimentMode = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.numTimeSize = New System.Windows.Forms.NumericUpDown()
        Me.numTimeFrequency = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.numTimeChange = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbTimeColor1 = New System.Windows.Forms.ComboBox()
        Me.cmbTimeColor2 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.grbStart = New System.Windows.Forms.GroupBox()
        Me.txtTimeLeft = New System.Windows.Forms.TextBox()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.chbAutoStop = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numExtend = New System.Windows.Forms.NumericUpDown()
        Me.numExpTime = New System.Windows.Forms.NumericUpDown()
        Me.cmbStopSound = New System.Windows.Forms.ComboBox()
        Me.chbStopSound = New System.Windows.Forms.CheckBox()
        Me.cmbStartSound = New System.Windows.Forms.ComboBox()
        Me.chbStartSound = New System.Windows.Forms.CheckBox()
        Me.numCountdown = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.btnSaveComment = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblMainTime = New System.Windows.Forms.Label()
        Me.grbOther = New System.Windows.Forms.GroupBox()
        Me.lstRemoteIP = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.chbRemoteDisplay = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIP = New System.Windows.Forms.Button()
        Me.txtLocalIP = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.grbData = New System.Windows.Forms.GroupBox()
        Me.tmrRemoteDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.grbClock.SuspendLayout()
        CType(Me.numTimeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimeFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimeChange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbStart.SuspendLayout()
        CType(Me.numExtend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCountdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbOther.SuspendLayout()
        Me.grbData.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(293, 89)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 22)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = "experiment"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(430, 122)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(83, 34)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Folder..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.Location = New System.Drawing.Point(293, 16)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(220, 39)
        Me.btnStartStop.TabIndex = 2
        Me.btnStartStop.Text = "START"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'chbSaveOverwrite
        '
        Me.chbSaveOverwrite.AutoSize = True
        Me.chbSaveOverwrite.Location = New System.Drawing.Point(14, 14)
        Me.chbSaveOverwrite.Name = "chbSaveOverwrite"
        Me.chbSaveOverwrite.Size = New System.Drawing.Size(217, 17)
        Me.chbSaveOverwrite.TabIndex = 0
        Me.chbSaveOverwrite.Text = "Overwrite file with experiment information"
        Me.chbSaveOverwrite.UseVisualStyleBackColor = True
        '
        'btnComment
        '
        Me.btnComment.Enabled = False
        Me.btnComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComment.Location = New System.Drawing.Point(293, 122)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(131, 34)
        Me.btnComment.TabIndex = 3
        Me.btnComment.Text = "Add comment"
        Me.btnComment.UseVisualStyleBackColor = True
        '
        'grbClock
        '
        Me.grbClock.Controls.Add(Me.btnTimeShow)
        Me.grbClock.Controls.Add(Me.chbTimeExperimentMode)
        Me.grbClock.Controls.Add(Me.Label14)
        Me.grbClock.Controls.Add(Me.numTimeSize)
        Me.grbClock.Controls.Add(Me.numTimeFrequency)
        Me.grbClock.Controls.Add(Me.Label15)
        Me.grbClock.Controls.Add(Me.numTimeChange)
        Me.grbClock.Controls.Add(Me.Label17)
        Me.grbClock.Controls.Add(Me.cmbTimeColor1)
        Me.grbClock.Controls.Add(Me.cmbTimeColor2)
        Me.grbClock.Controls.Add(Me.Label18)
        Me.grbClock.Controls.Add(Me.Label19)
        Me.grbClock.Location = New System.Drawing.Point(12, 12)
        Me.grbClock.Name = "grbClock"
        Me.grbClock.Size = New System.Drawing.Size(265, 200)
        Me.grbClock.TabIndex = 0
        Me.grbClock.TabStop = False
        Me.grbClock.Text = "Time settings"
        '
        'btnTimeShow
        '
        Me.btnTimeShow.Location = New System.Drawing.Point(148, 163)
        Me.btnTimeShow.Name = "btnTimeShow"
        Me.btnTimeShow.Size = New System.Drawing.Size(102, 23)
        Me.btnTimeShow.TabIndex = 9
        Me.btnTimeShow.Text = "Hide time"
        Me.btnTimeShow.UseVisualStyleBackColor = True
        '
        'chbTimeExperimentMode
        '
        Me.chbTimeExperimentMode.AutoSize = True
        Me.chbTimeExperimentMode.Location = New System.Drawing.Point(14, 167)
        Me.chbTimeExperimentMode.Name = "chbTimeExperimentMode"
        Me.chbTimeExperimentMode.Size = New System.Drawing.Size(107, 17)
        Me.chbTimeExperimentMode.TabIndex = 8
        Me.chbTimeExperimentMode.Text = "Experiment mode"
        Me.chbTimeExperimentMode.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Frequency (Hz)"
        '
        'numTimeSize
        '
        Me.numTimeSize.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTimeSize.Location = New System.Drawing.Point(148, 49)
        Me.numTimeSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTimeSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTimeSize.Name = "numTimeSize"
        Me.numTimeSize.Size = New System.Drawing.Size(102, 20)
        Me.numTimeSize.TabIndex = 1
        Me.numTimeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numTimeSize.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numTimeFrequency
        '
        Me.numTimeFrequency.Location = New System.Drawing.Point(148, 23)
        Me.numTimeFrequency.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTimeFrequency.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numTimeFrequency.Name = "numTimeFrequency"
        Me.numTimeFrequency.Size = New System.Drawing.Size(102, 20)
        Me.numTimeFrequency.TabIndex = 0
        Me.numTimeFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numTimeFrequency.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Text size"
        '
        'numTimeChange
        '
        Me.numTimeChange.Location = New System.Drawing.Point(148, 75)
        Me.numTimeChange.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTimeChange.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numTimeChange.Name = "numTimeChange"
        Me.numTimeChange.Size = New System.Drawing.Size(102, 20)
        Me.numTimeChange.TabIndex = 2
        Me.numTimeChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numTimeChange.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Interval (s)"
        '
        'cmbTimeColor1
        '
        Me.cmbTimeColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeColor1.FormattingEnabled = True
        Me.cmbTimeColor1.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue", "Yellow", "Orange", "Purple"})
        Me.cmbTimeColor1.Location = New System.Drawing.Point(148, 105)
        Me.cmbTimeColor1.Name = "cmbTimeColor1"
        Me.cmbTimeColor1.Size = New System.Drawing.Size(102, 21)
        Me.cmbTimeColor1.TabIndex = 4
        '
        'cmbTimeColor2
        '
        Me.cmbTimeColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeColor2.FormattingEnabled = True
        Me.cmbTimeColor2.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue", "Yellow", "Orange", "Purple"})
        Me.cmbTimeColor2.Location = New System.Drawing.Point(148, 132)
        Me.cmbTimeColor2.Name = "cmbTimeColor2"
        Me.cmbTimeColor2.Size = New System.Drawing.Size(102, 21)
        Me.cmbTimeColor2.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Color 1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Color 2"
        '
        'grbStart
        '
        Me.grbStart.Controls.Add(Me.txtTimeLeft)
        Me.grbStart.Controls.Add(Me.btnExtend)
        Me.grbStart.Controls.Add(Me.chbAutoStop)
        Me.grbStart.Controls.Add(Me.Label11)
        Me.grbStart.Controls.Add(Me.Label12)
        Me.grbStart.Controls.Add(Me.numExtend)
        Me.grbStart.Controls.Add(Me.numExpTime)
        Me.grbStart.Controls.Add(Me.cmbStopSound)
        Me.grbStart.Controls.Add(Me.chbStopSound)
        Me.grbStart.Controls.Add(Me.cmbStartSound)
        Me.grbStart.Controls.Add(Me.chbStartSound)
        Me.grbStart.Controls.Add(Me.numCountdown)
        Me.grbStart.Controls.Add(Me.Label13)
        Me.grbStart.Location = New System.Drawing.Point(293, 162)
        Me.grbStart.Name = "grbStart"
        Me.grbStart.Size = New System.Drawing.Size(220, 228)
        Me.grbStart.TabIndex = 4
        Me.grbStart.TabStop = False
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeLeft.Location = New System.Drawing.Point(6, 190)
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.ReadOnly = True
        Me.txtTimeLeft.Size = New System.Drawing.Size(208, 22)
        Me.txtTimeLeft.TabIndex = 10
        Me.txtTimeLeft.TabStop = False
        Me.txtTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExtend
        '
        Me.btnExtend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtend.Location = New System.Drawing.Point(155, 106)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(59, 72)
        Me.btnExtend.TabIndex = 9
        Me.btnExtend.Text = "Extend"
        Me.btnExtend.UseVisualStyleBackColor = True
        '
        'chbAutoStop
        '
        Me.chbAutoStop.AutoSize = True
        Me.chbAutoStop.Location = New System.Drawing.Point(6, 71)
        Me.chbAutoStop.Name = "chbAutoStop"
        Me.chbAutoStop.Size = New System.Drawing.Size(71, 17)
        Me.chbAutoStop.TabIndex = 5
        Me.chbAutoStop.Text = "Auto stop"
        Me.chbAutoStop.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Entend (s)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Total time (s)"
        '
        'numExtend
        '
        Me.numExtend.Location = New System.Drawing.Point(88, 158)
        Me.numExtend.Maximum = New Decimal(New Integer() {36000, 0, 0, 0})
        Me.numExtend.Name = "numExtend"
        Me.numExtend.Size = New System.Drawing.Size(61, 20)
        Me.numExtend.TabIndex = 8
        Me.numExtend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numExtend.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'numExpTime
        '
        Me.numExpTime.Location = New System.Drawing.Point(88, 132)
        Me.numExpTime.Maximum = New Decimal(New Integer() {36000, 0, 0, 0})
        Me.numExpTime.Name = "numExpTime"
        Me.numExpTime.Size = New System.Drawing.Size(61, 20)
        Me.numExpTime.TabIndex = 7
        Me.numExpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numExpTime.Value = New Decimal(New Integer() {180, 0, 0, 0})
        '
        'cmbStopSound
        '
        Me.cmbStopSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStopSound.Enabled = False
        Me.cmbStopSound.FormattingEnabled = True
        Me.cmbStopSound.Items.AddRange(New Object() {"English", "Japanese", "Chinese", "German", "French", "Spanish", "Italian"})
        Me.cmbStopSound.Location = New System.Drawing.Point(88, 44)
        Me.cmbStopSound.Name = "cmbStopSound"
        Me.cmbStopSound.Size = New System.Drawing.Size(126, 21)
        Me.cmbStopSound.TabIndex = 4
        '
        'chbStopSound
        '
        Me.chbStopSound.AutoSize = True
        Me.chbStopSound.Location = New System.Drawing.Point(6, 46)
        Me.chbStopSound.Name = "chbStopSound"
        Me.chbStopSound.Size = New System.Drawing.Size(80, 17)
        Me.chbStopSound.TabIndex = 3
        Me.chbStopSound.Text = "Stop sound"
        Me.chbStopSound.UseVisualStyleBackColor = True
        '
        'cmbStartSound
        '
        Me.cmbStartSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStartSound.Enabled = False
        Me.cmbStartSound.FormattingEnabled = True
        Me.cmbStartSound.Items.AddRange(New Object() {"EN simple", "EN countdown", "JP simple", "JP countdown", "CN simple", "CN countdown", "DE simple", "DE countdown", "FR simple", "FR countdown", "ES simple", "ES countdown", "IT simple", "IT countdown"})
        Me.cmbStartSound.Location = New System.Drawing.Point(88, 17)
        Me.cmbStartSound.Name = "cmbStartSound"
        Me.cmbStartSound.Size = New System.Drawing.Size(126, 21)
        Me.cmbStartSound.TabIndex = 2
        '
        'chbStartSound
        '
        Me.chbStartSound.AutoSize = True
        Me.chbStartSound.Location = New System.Drawing.Point(6, 19)
        Me.chbStartSound.Name = "chbStartSound"
        Me.chbStartSound.Size = New System.Drawing.Size(80, 17)
        Me.chbStartSound.TabIndex = 1
        Me.chbStartSound.Text = "Start sound"
        Me.chbStartSound.UseVisualStyleBackColor = True
        '
        'numCountdown
        '
        Me.numCountdown.Location = New System.Drawing.Point(88, 106)
        Me.numCountdown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numCountdown.Name = "numCountdown"
        Me.numCountdown.Size = New System.Drawing.Size(61, 20)
        Me.numCountdown.TabIndex = 6
        Me.numCountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numCountdown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Countdown (s)"
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(12, 466)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(504, 110)
        Me.txtComment.TabIndex = 42
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(129, 589)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(86, 13)
        Me.lblComment.TabIndex = 43
        Me.lblComment.Text = "oldExperiment"
        '
        'btnSaveComment
        '
        Me.btnSaveComment.Location = New System.Drawing.Point(395, 585)
        Me.btnSaveComment.Name = "btnSaveComment"
        Me.btnSaveComment.Size = New System.Drawing.Size(121, 20)
        Me.btnSaveComment.TabIndex = 3
        Me.btnSaveComment.Text = "Save and close"
        Me.btnSaveComment.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(12, 589)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(111, 13)
        Me.Label38.TabIndex = 44
        Me.Label38.Text = "Comments relative to: "
        '
        'lblMainTime
        '
        Me.lblMainTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTime.Location = New System.Drawing.Point(293, 62)
        Me.lblMainTime.Name = "lblMainTime"
        Me.lblMainTime.Size = New System.Drawing.Size(220, 19)
        Me.lblMainTime.TabIndex = 35
        Me.lblMainTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbOther
        '
        Me.grbOther.Controls.Add(Me.lstRemoteIP)
        Me.grbOther.Controls.Add(Me.btnRemove)
        Me.grbOther.Controls.Add(Me.btnAdd)
        Me.grbOther.Controls.Add(Me.chbRemoteDisplay)
        Me.grbOther.Controls.Add(Me.Label2)
        Me.grbOther.Controls.Add(Me.btnIP)
        Me.grbOther.Controls.Add(Me.txtLocalIP)
        Me.grbOther.Location = New System.Drawing.Point(12, 218)
        Me.grbOther.Name = "grbOther"
        Me.grbOther.Size = New System.Drawing.Size(265, 127)
        Me.grbOther.TabIndex = 3
        Me.grbOther.TabStop = False
        Me.grbOther.Text = "Remote display"
        '
        'lstRemoteIP
        '
        Me.lstRemoteIP.FormattingEnabled = True
        Me.lstRemoteIP.Location = New System.Drawing.Point(148, 23)
        Me.lstRemoteIP.Name = "lstRemoteIP"
        Me.lstRemoteIP.Size = New System.Drawing.Size(102, 43)
        Me.lstRemoteIP.TabIndex = 49
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(75, 50)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(55, 23)
        Me.btnRemove.TabIndex = 48
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 23)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'chbRemoteDisplay
        '
        Me.chbRemoteDisplay.AutoSize = True
        Me.chbRemoteDisplay.Location = New System.Drawing.Point(148, 72)
        Me.chbRemoteDisplay.Name = "chbRemoteDisplay"
        Me.chbRemoteDisplay.Size = New System.Drawing.Size(105, 17)
        Me.chbRemoteDisplay.TabIndex = 46
        Me.chbRemoteDisplay.Text = "Enable display(s)"
        Me.chbRemoteDisplay.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Remote IP addresses"
        '
        'btnIP
        '
        Me.btnIP.Location = New System.Drawing.Point(16, 94)
        Me.btnIP.Name = "btnIP"
        Me.btnIP.Size = New System.Drawing.Size(114, 23)
        Me.btnIP.TabIndex = 1
        Me.btnIP.Text = "Refresh IP"
        Me.btnIP.UseVisualStyleBackColor = True
        '
        'txtLocalIP
        '
        Me.txtLocalIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalIP.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtLocalIP.Location = New System.Drawing.Point(148, 98)
        Me.txtLocalIP.Name = "txtLocalIP"
        Me.txtLocalIP.Size = New System.Drawing.Size(102, 15)
        Me.txtLocalIP.TabIndex = 0
        Me.txtLocalIP.Text = "IP address"
        Me.txtLocalIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(12, 408)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(504, 29)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'grbData
        '
        Me.grbData.Controls.Add(Me.chbSaveOverwrite)
        Me.grbData.Location = New System.Drawing.Point(12, 351)
        Me.grbData.Name = "grbData"
        Me.grbData.Size = New System.Drawing.Size(265, 39)
        Me.grbData.TabIndex = 45
        Me.grbData.TabStop = False
        '
        'tmrRemoteDisplay
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 451)
        Me.Controls.Add(Me.grbData)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnComment)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.grbOther)
        Me.Controls.Add(Me.lblMainTime)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnSaveComment)
        Me.Controls.Add(Me.grbClock)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.grbStart)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Simple Experiment Manager"
        Me.TopMost = True
        Me.grbClock.ResumeLayout(False)
        Me.grbClock.PerformLayout()
        CType(Me.numTimeSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimeFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimeChange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbStart.ResumeLayout(False)
        Me.grbStart.PerformLayout()
        CType(Me.numExtend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCountdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbOther.ResumeLayout(False)
        Me.grbOther.PerformLayout()
        Me.grbData.ResumeLayout(False)
        Me.grbData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents chbSaveOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents grbClock As System.Windows.Forms.GroupBox
    Friend WithEvents btnTimeShow As System.Windows.Forms.Button
    Friend WithEvents chbTimeExperimentMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents numTimeSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents numTimeFrequency As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents numTimeChange As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbTimeColor1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTimeColor2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents grbStart As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimeLeft As System.Windows.Forms.TextBox
    Friend WithEvents btnExtend As System.Windows.Forms.Button
    Friend WithEvents chbAutoStop As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numExtend As System.Windows.Forms.NumericUpDown
    Friend WithEvents numExpTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbStopSound As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStartSound As System.Windows.Forms.ComboBox
    Friend WithEvents numCountdown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chbStopSound As System.Windows.Forms.CheckBox
    Friend WithEvents chbStartSound As System.Windows.Forms.CheckBox
    Friend WithEvents btnComment As System.Windows.Forms.Button
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents btnSaveComment As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblMainTime As System.Windows.Forms.Label
    Friend WithEvents grbOther As GroupBox
    Friend WithEvents txtLocalIP As Label
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnIP As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents grbData As GroupBox
    Friend WithEvents chbRemoteDisplay As CheckBox
    Friend WithEvents tmrRemoteDisplay As Timer
    Friend WithEvents lstRemoteIP As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
End Class
