<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblBirthDay65 = New System.Windows.Forms.Label()
        Me.LblBirthDay70 = New System.Windows.Forms.Label()
        Me.LblBirthDay75 = New System.Windows.Forms.Label()
        Me.LblBirthDay80 = New System.Windows.Forms.Label()
        Me.LblBirthDay85 = New System.Windows.Forms.Label()
        Me.LblBirthDay90 = New System.Windows.Forms.Label()
        Me.LblBirthDay95 = New System.Windows.Forms.Label()
        Me.LblBirthDay100 = New System.Windows.Forms.Label()
        Me.LblRankFM = New System.Windows.Forms.Label()
        Me.LblRankOFM = New System.Windows.Forms.Label()
        Me.LblRankHFM = New System.Windows.Forms.Label()
        Me.LblRankLM = New System.Windows.Forms.Label()
        Me.LblRankOLM = New System.Windows.Forms.Label()
        Me.LblRankHLM = New System.Windows.Forms.Label()
        Me.LblRankBM = New System.Windows.Forms.Label()
        Me.LblRankOBM = New System.Windows.Forms.Label()
        Me.LblRankHBM = New System.Windows.Forms.Label()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnRankUp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBirthday = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblActivityHours = New System.Windows.Forms.Label()
        Me.LblAmountActivityTotal = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblTrainingsZug = New System.Windows.Forms.Label()
        Me.LblAmountTrainingsOperator = New System.Windows.Forms.Label()
        Me.LblAmountTrainingsGroups = New System.Windows.Forms.Label()
        Me.lblAmountTrainingsScuba = New System.Windows.Forms.Label()
        Me.LblAmountTrainingsTotal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblAmountCrewYouth = New System.Windows.Forms.Label()
        Me.LblAmountCrewReserve = New System.Windows.Forms.Label()
        Me.LblAmountCrewActive = New System.Windows.Forms.Label()
        Me.LblAmountCrewAll = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblEmergencyHours = New System.Windows.Forms.Label()
        Me.lblAmountEmergencyAll = New System.Windows.Forms.Label()
        Me.LblAmountEmergencyOther = New System.Windows.Forms.Label()
        Me.LblAmountTecAccidents = New System.Windows.Forms.Label()
        Me.LblAmountFire = New System.Windows.Forms.Label()
        Me.FbdDirectory = New System.Windows.Forms.FolderBrowserDialog()
        Me.LblTrainingsHours = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblEmergencyHours2 = New System.Windows.Forms.Label()
        Me.LblTrainingHours2 = New System.Windows.Forms.Label()
        Me.LblActivityHours2 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LblTrainingsYouthAll = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(955, 587)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.BtnExport)
        Me.TabPage1.Controls.Add(Me.LblTitle)
        Me.TabPage1.Controls.Add(Me.BtnRankUp)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.BtnBirthday)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(947, 561)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FW-Daten"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay65)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay70)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay75)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay80)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay85)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay90)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay95)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBirthDay100)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankFM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankOFM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankHFM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankLM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankOLM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankHLM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankBM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankOBM)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblRankHBM)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 521)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(809, 34)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'LblBirthDay65
        '
        Me.LblBirthDay65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay65.Location = New System.Drawing.Point(3, 0)
        Me.LblBirthDay65.Name = "LblBirthDay65"
        Me.LblBirthDay65.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay65.TabIndex = 0
        Me.LblBirthDay65.Text = "65er: 5"
        Me.LblBirthDay65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay65.Visible = False
        '
        'LblBirthDay70
        '
        Me.LblBirthDay70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay70.Location = New System.Drawing.Point(71, 0)
        Me.LblBirthDay70.Name = "LblBirthDay70"
        Me.LblBirthDay70.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay70.TabIndex = 2
        Me.LblBirthDay70.Text = "65er: 5"
        Me.LblBirthDay70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay70.Visible = False
        '
        'LblBirthDay75
        '
        Me.LblBirthDay75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay75.Location = New System.Drawing.Point(139, 0)
        Me.LblBirthDay75.Name = "LblBirthDay75"
        Me.LblBirthDay75.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay75.TabIndex = 1
        Me.LblBirthDay75.Text = "65er: 5"
        Me.LblBirthDay75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay75.Visible = False
        '
        'LblBirthDay80
        '
        Me.LblBirthDay80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay80.Location = New System.Drawing.Point(207, 0)
        Me.LblBirthDay80.Name = "LblBirthDay80"
        Me.LblBirthDay80.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay80.TabIndex = 3
        Me.LblBirthDay80.Text = "65er: 5"
        Me.LblBirthDay80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay80.Visible = False
        '
        'LblBirthDay85
        '
        Me.LblBirthDay85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay85.Location = New System.Drawing.Point(275, 0)
        Me.LblBirthDay85.Name = "LblBirthDay85"
        Me.LblBirthDay85.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay85.TabIndex = 4
        Me.LblBirthDay85.Text = "65er: 5"
        Me.LblBirthDay85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay85.Visible = False
        '
        'LblBirthDay90
        '
        Me.LblBirthDay90.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay90.Location = New System.Drawing.Point(343, 0)
        Me.LblBirthDay90.Name = "LblBirthDay90"
        Me.LblBirthDay90.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay90.TabIndex = 5
        Me.LblBirthDay90.Text = "65er: 5"
        Me.LblBirthDay90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay90.Visible = False
        '
        'LblBirthDay95
        '
        Me.LblBirthDay95.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay95.Location = New System.Drawing.Point(411, 0)
        Me.LblBirthDay95.Name = "LblBirthDay95"
        Me.LblBirthDay95.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay95.TabIndex = 6
        Me.LblBirthDay95.Text = "65er: 5"
        Me.LblBirthDay95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay95.Visible = False
        '
        'LblBirthDay100
        '
        Me.LblBirthDay100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBirthDay100.Location = New System.Drawing.Point(479, 0)
        Me.LblBirthDay100.Name = "LblBirthDay100"
        Me.LblBirthDay100.Size = New System.Drawing.Size(62, 23)
        Me.LblBirthDay100.TabIndex = 7
        Me.LblBirthDay100.Text = "65er: 5"
        Me.LblBirthDay100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBirthDay100.Visible = False
        '
        'LblRankFM
        '
        Me.LblRankFM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankFM.Location = New System.Drawing.Point(547, 0)
        Me.LblRankFM.Name = "LblRankFM"
        Me.LblRankFM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankFM.TabIndex = 8
        Me.LblRankFM.Text = "FM: 6"
        Me.LblRankFM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankFM.Visible = False
        '
        'LblRankOFM
        '
        Me.LblRankOFM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankOFM.Location = New System.Drawing.Point(615, 0)
        Me.LblRankOFM.Name = "LblRankOFM"
        Me.LblRankOFM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankOFM.TabIndex = 9
        Me.LblRankOFM.Text = "FM: 6"
        Me.LblRankOFM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankOFM.Visible = False
        '
        'LblRankHFM
        '
        Me.LblRankHFM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankHFM.Location = New System.Drawing.Point(683, 0)
        Me.LblRankHFM.Name = "LblRankHFM"
        Me.LblRankHFM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankHFM.TabIndex = 10
        Me.LblRankHFM.Text = "FM: 6"
        Me.LblRankHFM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankHFM.Visible = False
        '
        'LblRankLM
        '
        Me.LblRankLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankLM.Location = New System.Drawing.Point(3, 23)
        Me.LblRankLM.Name = "LblRankLM"
        Me.LblRankLM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankLM.TabIndex = 11
        Me.LblRankLM.Text = "FM: 6"
        Me.LblRankLM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankLM.Visible = False
        '
        'LblRankOLM
        '
        Me.LblRankOLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankOLM.Location = New System.Drawing.Point(71, 23)
        Me.LblRankOLM.Name = "LblRankOLM"
        Me.LblRankOLM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankOLM.TabIndex = 12
        Me.LblRankOLM.Text = "FM: 6"
        Me.LblRankOLM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankOLM.Visible = False
        '
        'LblRankHLM
        '
        Me.LblRankHLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankHLM.Location = New System.Drawing.Point(139, 23)
        Me.LblRankHLM.Name = "LblRankHLM"
        Me.LblRankHLM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankHLM.TabIndex = 13
        Me.LblRankHLM.Text = "FM: 6"
        Me.LblRankHLM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankHLM.Visible = False
        '
        'LblRankBM
        '
        Me.LblRankBM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankBM.Location = New System.Drawing.Point(207, 23)
        Me.LblRankBM.Name = "LblRankBM"
        Me.LblRankBM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankBM.TabIndex = 14
        Me.LblRankBM.Text = "FM: 6"
        Me.LblRankBM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankBM.Visible = False
        '
        'LblRankOBM
        '
        Me.LblRankOBM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankOBM.Location = New System.Drawing.Point(275, 23)
        Me.LblRankOBM.Name = "LblRankOBM"
        Me.LblRankOBM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankOBM.TabIndex = 15
        Me.LblRankOBM.Text = "FM: 6"
        Me.LblRankOBM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankOBM.Visible = False
        '
        'LblRankHBM
        '
        Me.LblRankHBM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankHBM.Location = New System.Drawing.Point(343, 23)
        Me.LblRankHBM.Name = "LblRankHBM"
        Me.LblRankHBM.Size = New System.Drawing.Size(62, 23)
        Me.LblRankHBM.TabIndex = 16
        Me.LblRankHBM.Text = "FM: 6"
        Me.LblRankHBM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblRankHBM.Visible = False
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(826, 521)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(115, 34)
        Me.BtnExport.TabIndex = 2
        Me.BtnExport.Text = "Exportieren"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(6, 11)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(497, 29)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "Title"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnRankUp
        '
        Me.BtnRankUp.Location = New System.Drawing.Point(826, 6)
        Me.BtnRankUp.Name = "BtnRankUp"
        Me.BtnRankUp.Size = New System.Drawing.Size(115, 34)
        Me.BtnRankUp.TabIndex = 1
        Me.BtnRankUp.Text = "Beförderungen"
        Me.BtnRankUp.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(935, 469)
        Me.DataGridView1.TabIndex = 1
        '
        'BtnBirthday
        '
        Me.BtnBirthday.Location = New System.Drawing.Point(705, 6)
        Me.BtnBirthday.Name = "BtnBirthday"
        Me.BtnBirthday.Size = New System.Drawing.Size(115, 34)
        Me.BtnBirthday.TabIndex = 0
        Me.BtnBirthday.Text = "Geburtstage"
        Me.BtnBirthday.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(947, 561)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Einsatz-Daten"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblActivityHours)
        Me.GroupBox4.Controls.Add(Me.LblAmountActivityTotal)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(572, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 153)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tätigkeitsdaten"
        '
        'lblActivityHours
        '
        Me.lblActivityHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityHours.Location = New System.Drawing.Point(6, 48)
        Me.lblActivityHours.Name = "lblActivityHours"
        Me.lblActivityHours.Size = New System.Drawing.Size(215, 21)
        Me.lblActivityHours.TabIndex = 1
        Me.lblActivityHours.Text = "Gesamttätigkeitsstunden:"
        '
        'LblAmountActivityTotal
        '
        Me.LblAmountActivityTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountActivityTotal.Location = New System.Drawing.Point(6, 27)
        Me.LblAmountActivityTotal.Name = "LblAmountActivityTotal"
        Me.LblAmountActivityTotal.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountActivityTotal.TabIndex = 0
        Me.LblAmountActivityTotal.Text = "Anzahl Tätigkeiten Gesamt:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblTrainingsHours)
        Me.GroupBox3.Controls.Add(Me.LblTrainingsZug)
        Me.GroupBox3.Controls.Add(Me.LblAmountTrainingsOperator)
        Me.GroupBox3.Controls.Add(Me.LblAmountTrainingsGroups)
        Me.GroupBox3.Controls.Add(Me.lblAmountTrainingsScuba)
        Me.GroupBox3.Controls.Add(Me.LblAmountTrainingsTotal)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(18, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 163)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Übungsdaten"
        '
        'LblTrainingsZug
        '
        Me.LblTrainingsZug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrainingsZug.Location = New System.Drawing.Point(6, 111)
        Me.LblTrainingsZug.Name = "LblTrainingsZug"
        Me.LblTrainingsZug.Size = New System.Drawing.Size(215, 21)
        Me.LblTrainingsZug.TabIndex = 4
        Me.LblTrainingsZug.Text = "Anzahl Zugsübungen:"
        '
        'LblAmountTrainingsOperator
        '
        Me.LblAmountTrainingsOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountTrainingsOperator.Location = New System.Drawing.Point(6, 90)
        Me.LblAmountTrainingsOperator.Name = "LblAmountTrainingsOperator"
        Me.LblAmountTrainingsOperator.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountTrainingsOperator.TabIndex = 3
        Me.LblAmountTrainingsOperator.Text = "Anzahl Maschinisten:"
        '
        'LblAmountTrainingsGroups
        '
        Me.LblAmountTrainingsGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountTrainingsGroups.Location = New System.Drawing.Point(6, 69)
        Me.LblAmountTrainingsGroups.Name = "LblAmountTrainingsGroups"
        Me.LblAmountTrainingsGroups.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountTrainingsGroups.TabIndex = 2
        Me.LblAmountTrainingsGroups.Text = "Anzahl Gruppenübungen:"
        '
        'lblAmountTrainingsScuba
        '
        Me.lblAmountTrainingsScuba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountTrainingsScuba.Location = New System.Drawing.Point(6, 48)
        Me.lblAmountTrainingsScuba.Name = "lblAmountTrainingsScuba"
        Me.lblAmountTrainingsScuba.Size = New System.Drawing.Size(215, 21)
        Me.lblAmountTrainingsScuba.TabIndex = 1
        Me.lblAmountTrainingsScuba.Text = "Anzahl ATS:"
        '
        'LblAmountTrainingsTotal
        '
        Me.LblAmountTrainingsTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountTrainingsTotal.Location = New System.Drawing.Point(6, 27)
        Me.LblAmountTrainingsTotal.Name = "LblAmountTrainingsTotal"
        Me.LblAmountTrainingsTotal.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountTrainingsTotal.TabIndex = 0
        Me.LblAmountTrainingsTotal.Text = "Anzahl Übungen Gesamt:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblAmountCrewYouth)
        Me.GroupBox2.Controls.Add(Me.LblAmountCrewReserve)
        Me.GroupBox2.Controls.Add(Me.LblAmountCrewActive)
        Me.GroupBox2.Controls.Add(Me.LblAmountCrewAll)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(295, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 153)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mannschaftsdaten"
        '
        'LblAmountCrewYouth
        '
        Me.LblAmountCrewYouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountCrewYouth.Location = New System.Drawing.Point(6, 90)
        Me.LblAmountCrewYouth.Name = "LblAmountCrewYouth"
        Me.LblAmountCrewYouth.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountCrewYouth.TabIndex = 3
        Me.LblAmountCrewYouth.Text = "Anzahl Jugend:"
        '
        'LblAmountCrewReserve
        '
        Me.LblAmountCrewReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountCrewReserve.Location = New System.Drawing.Point(6, 69)
        Me.LblAmountCrewReserve.Name = "LblAmountCrewReserve"
        Me.LblAmountCrewReserve.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountCrewReserve.TabIndex = 2
        Me.LblAmountCrewReserve.Text = "Anzahl Reservisten:"
        '
        'LblAmountCrewActive
        '
        Me.LblAmountCrewActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountCrewActive.Location = New System.Drawing.Point(6, 48)
        Me.LblAmountCrewActive.Name = "LblAmountCrewActive"
        Me.LblAmountCrewActive.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountCrewActive.TabIndex = 1
        Me.LblAmountCrewActive.Text = "Anzahl Aktive:"
        '
        'LblAmountCrewAll
        '
        Me.LblAmountCrewAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountCrewAll.Location = New System.Drawing.Point(6, 27)
        Me.LblAmountCrewAll.Name = "LblAmountCrewAll"
        Me.LblAmountCrewAll.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountCrewAll.TabIndex = 0
        Me.LblAmountCrewAll.Text = "Anzahl Mannschaft Gesamt:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblEmergencyHours)
        Me.GroupBox1.Controls.Add(Me.lblAmountEmergencyAll)
        Me.GroupBox1.Controls.Add(Me.LblAmountEmergencyOther)
        Me.GroupBox1.Controls.Add(Me.LblAmountTecAccidents)
        Me.GroupBox1.Controls.Add(Me.LblAmountFire)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Einsatzdaten"
        '
        'LblEmergencyHours
        '
        Me.LblEmergencyHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmergencyHours.Location = New System.Drawing.Point(6, 111)
        Me.LblEmergencyHours.Name = "LblEmergencyHours"
        Me.LblEmergencyHours.Size = New System.Drawing.Size(215, 21)
        Me.LblEmergencyHours.TabIndex = 4
        Me.LblEmergencyHours.Text = "Gesamteinsatzstunden:"
        '
        'lblAmountEmergencyAll
        '
        Me.lblAmountEmergencyAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountEmergencyAll.Location = New System.Drawing.Point(6, 90)
        Me.lblAmountEmergencyAll.Name = "lblAmountEmergencyAll"
        Me.lblAmountEmergencyAll.Size = New System.Drawing.Size(215, 21)
        Me.lblAmountEmergencyAll.TabIndex = 3
        Me.lblAmountEmergencyAll.Text = "Anzahl Einsätze Gesamt:"
        '
        'LblAmountEmergencyOther
        '
        Me.LblAmountEmergencyOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountEmergencyOther.Location = New System.Drawing.Point(6, 69)
        Me.LblAmountEmergencyOther.Name = "LblAmountEmergencyOther"
        Me.LblAmountEmergencyOther.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountEmergencyOther.TabIndex = 2
        Me.LblAmountEmergencyOther.Text = "Anzahl Sonstige-Einsätze:"
        '
        'LblAmountTecAccidents
        '
        Me.LblAmountTecAccidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountTecAccidents.Location = New System.Drawing.Point(6, 48)
        Me.LblAmountTecAccidents.Name = "LblAmountTecAccidents"
        Me.LblAmountTecAccidents.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountTecAccidents.TabIndex = 1
        Me.LblAmountTecAccidents.Text = "Anzahl Technische-Einsätze:"
        '
        'LblAmountFire
        '
        Me.LblAmountFire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountFire.Location = New System.Drawing.Point(6, 27)
        Me.LblAmountFire.Name = "LblAmountFire"
        Me.LblAmountFire.Size = New System.Drawing.Size(215, 21)
        Me.LblAmountFire.TabIndex = 0
        Me.LblAmountFire.Text = "Anzahl Brand-Einsätze:"
        '
        'LblTrainingsHours
        '
        Me.LblTrainingsHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrainingsHours.Location = New System.Drawing.Point(6, 132)
        Me.LblTrainingsHours.Name = "LblTrainingsHours"
        Me.LblTrainingsHours.Size = New System.Drawing.Size(215, 21)
        Me.LblTrainingsHours.TabIndex = 5
        Me.LblTrainingsHours.Text = "Gesamtübungsstunden:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblActivityHours2)
        Me.GroupBox5.Controls.Add(Me.LblTrainingHours2)
        Me.GroupBox5.Controls.Add(Me.LblEmergencyHours2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(572, 202)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 153)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Zeitaufstellung"
        '
        'LblEmergencyHours2
        '
        Me.LblEmergencyHours2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmergencyHours2.Location = New System.Drawing.Point(6, 27)
        Me.LblEmergencyHours2.Name = "LblEmergencyHours2"
        Me.LblEmergencyHours2.Size = New System.Drawing.Size(215, 21)
        Me.LblEmergencyHours2.TabIndex = 0
        Me.LblEmergencyHours2.Text = "Gesamteinsatzstunden:"
        '
        'LblTrainingHours2
        '
        Me.LblTrainingHours2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrainingHours2.Location = New System.Drawing.Point(6, 48)
        Me.LblTrainingHours2.Name = "LblTrainingHours2"
        Me.LblTrainingHours2.Size = New System.Drawing.Size(215, 21)
        Me.LblTrainingHours2.TabIndex = 6
        Me.LblTrainingHours2.Text = "Gesamtübungsstunden:"
        '
        'LblActivityHours2
        '
        Me.LblActivityHours2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActivityHours2.Location = New System.Drawing.Point(6, 69)
        Me.LblActivityHours2.Name = "LblActivityHours2"
        Me.LblActivityHours2.Size = New System.Drawing.Size(215, 21)
        Me.LblActivityHours2.TabIndex = 7
        Me.LblActivityHours2.Text = "Gesamttätigkeitsstunden:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblTrainingsYouthAll)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(291, 192)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(245, 163)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Jugend"
        '
        'LblTrainingsYouthAll
        '
        Me.LblTrainingsYouthAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrainingsYouthAll.Location = New System.Drawing.Point(6, 27)
        Me.LblTrainingsYouthAll.Name = "LblTrainingsYouthAll"
        Me.LblTrainingsYouthAll.Size = New System.Drawing.Size(215, 21)
        Me.LblTrainingsYouthAll.TabIndex = 0
        Me.LblTrainingsYouthAll.Text = "Anzahl Übungen Gesamt:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 611)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnBirthday As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FbdDirectory As FolderBrowserDialog
    Friend WithEvents BtnRankUp As Button
    Friend WithEvents BtnExport As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LblBirthDay65 As Label
    Friend WithEvents LblBirthDay75 As Label
    Friend WithEvents LblBirthDay70 As Label
    Friend WithEvents LblBirthDay80 As Label
    Friend WithEvents LblBirthDay85 As Label
    Friend WithEvents LblBirthDay90 As Label
    Friend WithEvents LblBirthDay95 As Label
    Friend WithEvents LblBirthDay100 As Label
    Friend WithEvents LblRankFM As Label
    Friend WithEvents LblRankOFM As Label
    Friend WithEvents LblRankHFM As Label
    Friend WithEvents LblRankLM As Label
    Friend WithEvents LblRankOLM As Label
    Friend WithEvents LblRankHLM As Label
    Friend WithEvents LblRankBM As Label
    Friend WithEvents LblRankOBM As Label
    Friend WithEvents LblRankHBM As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblActivityHours As Label
    Friend WithEvents LblAmountActivityTotal As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblTrainingsZug As Label
    Friend WithEvents LblAmountTrainingsOperator As Label
    Friend WithEvents LblAmountTrainingsGroups As Label
    Friend WithEvents lblAmountTrainingsScuba As Label
    Friend WithEvents LblAmountTrainingsTotal As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblAmountCrewYouth As Label
    Friend WithEvents LblAmountCrewReserve As Label
    Friend WithEvents LblAmountCrewActive As Label
    Friend WithEvents LblAmountCrewAll As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblEmergencyHours As Label
    Friend WithEvents lblAmountEmergencyAll As Label
    Friend WithEvents LblAmountEmergencyOther As Label
    Friend WithEvents LblAmountTecAccidents As Label
    Friend WithEvents LblAmountFire As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblActivityHours2 As Label
    Friend WithEvents LblTrainingHours2 As Label
    Friend WithEvents LblEmergencyHours2 As Label
    Friend WithEvents LblTrainingsHours As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblTrainingsYouthAll As Label
End Class
