Imports System.IO
Imports System.Reflection
Imports System.Data
Imports GemBox.Spreadsheet
Imports System.Text

Public Class Form1

    Private _Path As String
    Private _ExportData As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FbdDirectory.Description = "Ordner auswählen oder neuen Ordner mit Jahr erstellen."
        'Dim result As DialogResult = FbdDirectory.ShowDialog()

        'If result = Windows.Forms.DialogResult.OK Then
        '    _Path = FbdDirectory.SelectedPath

        '    If Not Directory.Exists(_Path & "\FWDaten") Then
        '        Directory.CreateDirectory(_Path & "\FWDaten")
        '    End If

        '    If Not Directory.Exists(_Path & "\EinsatzDaten") Then
        '        Directory.CreateDirectory(_Path & "\EinsatzDaten")
        '    End If
        'End If

        getDirectory()
    End Sub

    Private Sub BtnBirthday_Click(sender As Object, e As EventArgs) Handles BtnBirthday.Click
        Dim Path As String = _Path & "\FWDaten\mitglieder.csv"

        If Not File.Exists(Path) Then
            MessageBox.Show("Die auszulesenden Dateien fehlen in dem angegeben Verzeichnis.", "FDIS-Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim Data = New DataTable
            Dim ShowData = New DataTable
            Dim Coloum() As String
            Dim Handler As New CSVDataHandler

            Dim Mitglied As Mitglied
            Dim BirthDayList65 = New List(Of Mitglied)
            Dim BirthDayList70 = New List(Of Mitglied)
            Dim BirthDayList75 = New List(Of Mitglied)
            Dim BirthDayList80 = New List(Of Mitglied)
            Dim BirthDayList85 = New List(Of Mitglied)
            Dim BirthDayList90 = New List(Of Mitglied)
            Dim BirthDayList95 = New List(Of Mitglied)
            Dim BirthDayList100 = New List(Of Mitglied)

            Data = Handler.CSV2DataTable(Path)

            For i As Integer = 0 To Data.Rows.Count - 1
                Dim YearStr As String = Data.Rows(i).Item("geburtsdatum").ToString.Substring(Data.Rows(i).Item("geburtsdatum").ToString.Length - 4)
                Dim YearInt As Integer = CInt(YearStr)
                Dim ThisYearInt As Integer = CInt(Date.Now.Year)
                Dim CheckYear As Integer = ThisYearInt - YearInt
                Mitglied = New Mitglied

                If Data.Rows(i).Item("Status").ToString <> "abgemeldet" Then

                    Select Case CheckYear
                        Case 65
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList65.Add(Mitglied)

                        Case 70
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList70.Add(Mitglied)

                        Case 75
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList75.Add(Mitglied)

                        Case 80
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList80.Add(Mitglied)

                        Case 85
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList85.Add(Mitglied)

                        Case 90
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList90.Add(Mitglied)

                        Case 95
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList95.Add(Mitglied)

                        Case 100
                            Mitglied.Id = CInt(Data.Rows(i).Item("standesbuchnummer"))
                            Mitglied.FirstName = Data.Rows(i).Item("vorname")
                            Mitglied.SecondName = Data.Rows(i).Item("zuname")
                            Mitglied.BirthDate = Convert.ToDateTime(Data.Rows(i).Item("geburtsdatum"))
                            Mitglied.Rank = Data.Rows(i).Item("dienstgrad")
                            Mitglied.Status = Data.Rows(i).Item("status")

                            BirthDayList100.Add(Mitglied)
                        Case Else

                    End Select
                End If
        Next

        ShowData.Columns.Add(New DataColumn("Runder", GetType(String)))
            ShowData.Columns.Add(New DataColumn(Data.Columns(1).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(Data.Columns(2).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(Data.Columns(3).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(Data.Columns(4).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(Data.Columns(5).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(Data.Columns(9).ColumnName, GetType(String)))

            AddBirthdayYear(ShowData, "65")
            AddBirthDayData(ShowData, BirthDayList65)

            AddBirthdayYear(ShowData, "70")
            AddBirthDayData(ShowData, BirthDayList70)

            AddBirthdayYear(ShowData, "75")
            AddBirthDayData(ShowData, BirthDayList75)

            AddBirthdayYear(ShowData, "80")
            AddBirthDayData(ShowData, BirthDayList80)

            AddBirthdayYear(ShowData, "85")
            AddBirthDayData(ShowData, BirthDayList85)

            AddBirthdayYear(ShowData, "90")
            AddBirthDayData(ShowData, BirthDayList90)

            AddBirthdayYear(ShowData, "95")
            AddBirthDayData(ShowData, BirthDayList95)

            AddBirthdayYear(ShowData, "100")
            AddBirthDayData(ShowData, BirthDayList100)

            DataGridView1.DataSource = ShowData

            _ExportData = New DataTable
            _ExportData = ShowData

            LblTitle.Text = "Geburtstage"
            ShowBirthDayStats(True)
            ShowRankStats(False)

            LblBirthDay65.Text = "65er: " & BirthDayList65.Count
            LblBirthDay70.Text = "70er: " & BirthDayList70.Count
            LblBirthDay75.Text = "75er: " & BirthDayList75.Count
            LblBirthDay80.Text = "80er: " & BirthDayList80.Count
            LblBirthDay85.Text = "85er: " & BirthDayList85.Count
            LblBirthDay90.Text = "90er: " & BirthDayList90.Count
            LblBirthDay95.Text = "95er: " & BirthDayList95.Count
            LblBirthDay100.Text = "100er: " & BirthDayList100.Count
        End If
    End Sub

    Private Sub BtnRankUp_Click(sender As Object, e As EventArgs) Handles BtnRankUp.Click
        Dim Path As String = _Path & "\FWDaten\mitglieder.csv"

        If Not File.Exists(Path) Then
            MessageBox.Show("Die auszulesenden Dateien fehlen in dem angegeben Verzeichnis.", "FDIS-Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else

            Dim DataMembers = New DataTable
            Dim DataFunktions = New DataTable
            Dim ShowData = New DataTable
            Dim Mitglied As New Mitglied
            Dim Handler As New CSVDataHandler
            Dim RankUpListOFM = New List(Of Mitglied)
            Dim RankUpListHFM = New List(Of Mitglied)
            Dim RankUpListLM = New List(Of Mitglied)
            Dim RankUpListOLM = New List(Of Mitglied)
            Dim RankUpListHLM = New List(Of Mitglied)



            DataMembers = CSVDataHandler.CSV2DataTable(Path)

            Path = String.Empty
            Path = _Path & "\FWDaten\funktionen_mitglieder.csv"
            DataFunktions = CSVDataHandler.CSV2DataTable(Path)

            For i As Integer = 0 To DataMembers.Rows.Count - 1
                If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("datum_aktiv")) Then
                    Dim YearDiff As Integer = 0

                    Mitglied = New Mitglied
                    If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("standesbuchnummer")) Then
                        Mitglied.Id = CInt(DataMembers.Rows(i).Item("standesbuchnummer"))
                    End If

                    If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("vorname")) Then
                        Mitglied.FirstName = DataMembers.Rows(i).Item("vorname")
                    End If

                    If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("zuname")) Then
                        Mitglied.SecondName = DataMembers.Rows(i).Item("zuname")
                    End If

                    Mitglied.BirthDate = Nothing

                    If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("dienstgrad")) Then
                        Mitglied.Rank = DataMembers.Rows(i).Item("dienstgrad")
                    End If

                    If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("status")) Then
                        Mitglied.Status = DataMembers.Rows(i).Item("status")
                    End If

                    If Not String.IsNullOrEmpty(DataMembers.Rows(i).Item("datum_aktiv")) Then
                        Mitglied.DateActive = Convert.ToDateTime(DataMembers.Rows(i).Item("datum_aktiv"))
                    End If

                    YearDiff = CInt(Date.Now.Year) - CInt(Mitglied.DateActive.Year)

                    If YearDiff >= 6 AndAlso YearDiff < 12 AndAlso Mitglied.Status <> "abgemeldet" AndAlso Mitglied.Rank = "FM" Then
                        RankUpListOFM.Add(Mitglied)
                    ElseIf YearDiff >= 12 AndAlso YearDiff < 18 AndAlso Mitglied.Status <> "abgemeldet" AndAlso Mitglied.Rank = "OFM" Then
                        RankUpListHFM.Add(Mitglied)
                    End If
                End If
            Next

            For i As Integer = 0 To DataFunktions.Rows.Count - 1
                Dim YearDiff As Integer = 0

                If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("bez")) AndAlso String.IsNullOrEmpty(DataFunktions.Rows(i).Item("bis")) Then
                    Mitglied = New Mitglied

                    If DataFunktions.Rows(i).Item("bez") = "Gruppenkommandant" Or DataFunktions.Rows(i).Item("bez") = "Zugskommandant" Or DataFunktions.Rows(i).Item("bez") = "Beauftragter Atemschutz" Or DataFunktions.Rows(i).Item("bez") = "Beauftragter Funk" Or DataFunktions.Rows(i).Item("bez") = "Gerätewart" Or DataFunktions.Rows(i).Item("bez") = "Obermaschinist" Then

                        If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("standesbuchnummer")) Then
                            Mitglied.Id = CInt(DataFunktions.Rows(i).Item("standesbuchnummer"))
                        End If

                        If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("vorname")) Then
                            Mitglied.FirstName = DataFunktions.Rows(i).Item("vorname")
                        End If

                        If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("zuname")) Then
                            Mitglied.SecondName = DataFunktions.Rows(i).Item("zuname")
                        End If

                        If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("dienstgrad")) Then
                            Mitglied.Rank = DataFunktions.Rows(i).Item("dienstgrad")
                        End If

                        If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("bez")) Then
                            Mitglied.Funktion = DataFunktions.Rows(i).Item("bez")
                        End If

                        If Not String.IsNullOrEmpty(DataFunktions.Rows(i).Item("von")) Then
                            Mitglied.FunktionBeginn = Convert.ToDateTime(DataFunktions.Rows(i).Item("von"))
                        End If


                        YearDiff = CInt(Date.Now.Year) - CInt(Mitglied.FunktionBeginn.Year)

                        If Mitglied.Rank = "FM" Then
                            RankUpListLM.Add(Mitglied)
                        ElseIf Mitglied.Rank = "LM" AndAlso YearDiff >= 6 AndAlso YearDiff < 12 Then
                            RankUpListOLM.Add(Mitglied)
                        ElseIf Mitglied.Rank = "OLM" AndAlso YearDiff >= 12 AndAlso YearDiff < 18 Then
                            RankUpListHLM.Add(Mitglied)
                        End If
                    End If
                End If
            Next

            ShowData.Columns.Add(New DataColumn("Rang", GetType(String)))
            ShowData.Columns.Add(New DataColumn(DataMembers.Columns(1).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(DataMembers.Columns(2).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(DataMembers.Columns(3).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(DataMembers.Columns(5).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(DataMembers.Columns(9).ColumnName, GetType(String)))
            ShowData.Columns.Add(New DataColumn(DataMembers.Columns(15).ColumnName, GetType(String)))

            AddRankUpRank(ShowData, "OFM")
            AddRankUpData(ShowData, RankUpListOFM)
            AddRankUpRank(ShowData, "HFM")
            AddRankUpData(ShowData, RankUpListHFM)
            AddRankUpRank(ShowData, "LM")
            AddRankUpData(ShowData, RankUpListLM, True)
            AddRankUpRank(ShowData, "OLM")
            AddRankUpData(ShowData, RankUpListOLM, True)
            AddRankUpRank(ShowData, "HLM")
            AddRankUpData(ShowData, RankUpListHLM, True)



            DataGridView1.DataSource = ShowData

            _ExportData = New DataTable
            _ExportData = ShowData

            LblTitle.Text = "Beförderungen"
            ShowBirthDayStats(False)
            ShowRankStats(True)

            LblRankOFM.Text = "OFM: " & RankUpListOFM.Count
            LblRankHFM.Text = "HFM: " & RankUpListHFM.Count
            LblRankLM.Text = "LM: " & RankUpListLM.Count
            LblRankOLM.Text = "OLM: " & RankUpListOLM.Count
            LblRankHLM.Text = "HLM: " & RankUpListHLM.Count
        End If
    End Sub

    Public Shared Function ConvertToDataTable(Of Mitglied)(ByVal list As IList(Of Mitglied)) As DataTable
        Dim table As New DataTable()
        Dim fields() As FieldInfo = GetType(Mitglied).GetFields()
        For Each field As FieldInfo In fields
            table.Columns.Add(field.Name, field.FieldType)
        Next
        For Each item As Mitglied In list
            Dim row As DataRow = table.NewRow()
            For Each field As FieldInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    Public Sub AddBirthdayYear(ByVal data As DataTable, ByVal year As String)
        Dim R As DataRow = data.NewRow
        R("Runder") = year
        R("standesbuchnummer") = ""
        R("vorname") = ""
        R("zuname") = ""
        R("geburtsdatum") = ""
        R("dienstgrad") = ""
        R("status") = ""
        data.Rows.Add(R)
    End Sub

    Public Sub AddBirthDayData(ByVal data As DataTable, ByVal list As List(Of Mitglied))
        For i As Integer = 0 To list.Count - 1

            Dim Mitglied2 = New Mitglied
            Mitglied2 = list(i)

            Dim Row As DataRow = data.NewRow
            Row("Runder") = ""
            Row("standesbuchnummer") = Mitglied2.Id
            Row("vorname") = Mitglied2.FirstName
            Row("zuname") = Mitglied2.SecondName
            Row("geburtsdatum") = Mitglied2.BirthDate
            Row("dienstgrad") = Mitglied2.Rank
            Row("status") = Mitglied2.Status
            data.Rows.Add(Row)
        Next
    End Sub

    Public Sub AddRankUpRank(ByVal data As DataTable, ByVal rank As String)
        Dim R As DataRow = data.NewRow
        R("Rang") = rank
        R("standesbuchnummer") = ""
        R("vorname") = ""
        R("zuname") = ""
        R("dienstgrad") = ""
        R("status") = ""
        R("datum_aktiv") = ""
        data.Rows.Add(R)
    End Sub

    Public Sub AddRankUpData(ByVal data As DataTable, ByVal list As List(Of Mitglied), Optional ByVal funktion As Boolean = False)
        For i As Integer = 0 To list.Count - 1

            Dim Mitglied2 As New Mitglied
            Mitglied2 = list(i)

            Dim Row As DataRow = data.NewRow
            Row("Rang") = ""
            Row("standesbuchnummer") = Mitglied2.Id
            Row("vorname") = Mitglied2.FirstName
            Row("zuname") = Mitglied2.SecondName
            Row("dienstgrad") = Mitglied2.Rank

            If Not funktion Then
                Row("status") = Mitglied2.Status
            Else
                Row("status") = Mitglied2.Funktion
            End If


            If Not funktion Then
                Row("datum_aktiv") = Mitglied2.DateActive
            Else
                Row("datum_aktiv") = Mitglied2.FunktionBeginn
            End If

            data.Rows.Add(Row)
        Next
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        MessageBox.Show(_ExportData.Rows(1).Item("Zuname").ToString)
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            getDirectory()
        End If
    End Sub

    Private Sub getDirectory()
        FbdDirectory.Description = "Ordner auswählen oder neuen Ordner mit Jahr erstellen."
        Dim result As DialogResult = FbdDirectory.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            _Path = String.Empty
            _Path = FbdDirectory.SelectedPath

            If Not Directory.Exists(_Path & "\FWDaten") Then
                Directory.CreateDirectory(_Path & "\FWDaten")
            End If

            If Not Directory.Exists(_Path & "\EinsatzDaten") Then
                Directory.CreateDirectory(_Path & "\EinsatzDaten")
            End If
        End If
    End Sub

    Private Sub ShowBirthDayStats(ByVal show As Boolean)
        If show Then
            LblBirthDay65.Visible = True
            LblBirthDay70.Visible = True
            LblBirthDay75.Visible = True
            LblBirthDay80.Visible = True
            LblBirthDay85.Visible = True
            LblBirthDay90.Visible = True
            LblBirthDay95.Visible = True
            LblBirthDay100.Visible = True
        Else
            LblBirthDay65.Visible = False
            LblBirthDay70.Visible = False
            LblBirthDay75.Visible = False
            LblBirthDay80.Visible = False
            LblBirthDay85.Visible = False
            LblBirthDay90.Visible = False
            LblBirthDay95.Visible = False
            LblBirthDay100.Visible = False
        End If
    End Sub

    Private Sub ShowRankStats(ByVal show As Boolean)
        If show Then
            'LblRankFM.Visible = True
            LblRankOFM.Visible = True
            LblRankHFM.Visible = True
            LblRankLM.Visible = True
            LblRankOLM.Visible = True
            LblRankHLM.Visible = True
            'LblRankBM.Visible = True
            'LblRankOBM.Visible = True
            'LblRankHBM.Visible = True
        Else
            LblRankFM.Visible = False
            LblRankOFM.Visible = False
            LblRankHFM.Visible = False
            LblRankLM.Visible = False
            LblRankOLM.Visible = False
            LblRankHLM.Visible = False
            LblRankBM.Visible = False
            LblRankOBM.Visible = False
            LblRankHBM.Visible = False
        End If
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected

        If TabControl1.SelectedIndex = 1 Then
            Dim Path As String = _Path & "\EinsatzDaten\einsatzberichte.csv"

            If Not File.Exists(Path) Then
                MessageBox.Show("Die auszulesenden Dateien fehlen in dem angegeben Verzeichnis.", "FDIS-Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim Data = New DataTable
                Dim ShowData = New DataTable
                Dim Coloum() As String
                Dim Handler As New CSVDataHandler

                Dim EmergencyTemp As Einsatz
                Dim EmergencyListFire = New List(Of Einsatz)
                Dim EmergencyListTec = New List(Of Einsatz)
                Dim EmergencyListOther = New List(Of Mitglied)

                Dim CounterFire As Integer = 0
                Dim CounterTec As Integer = 0
                Dim CounterOther As Integer = 0
                Dim CounterAll As Integer = 0

                Data = Handler.CSV2DataTable(Path)

                For i As Integer = 0 To Data.Rows.Count - 1

                    EmergencyTemp = New Einsatz

                    Select Case Data.Rows(i).Item("einsatzart")
                        Case "Brandeinsatz"
                            CounterFire += 1
                        Case "Technischer Einsatz"
                            CounterTec += 1
                        Case "Brandsicherheitswache bei Veranstaltung(Zirkus, Theater...)"
                            CounterOther += 1
                        Case Else
                    End Select

                    CounterAll += 1
                Next

                LblAmountFire.Text = "Anzahl Brand-Einsätze: " & CounterFire.ToString
                LblAmountTecAccidents.Text = "Anzahl Technische-Einsätze: " & CounterTec.ToString
                LblAmountEmergencyOther.Text = "Anzahl Sonstige-Einsätze: " & CounterOther.ToString
                lblAmountEmergencyAll.Text = "Anzahl Einsätze-Gesamt: " & CounterAll.ToString

                getEmergencyWorkTime()
                CalculateMemberAllTogether(_Path)
                CalculateTrainings(_Path)
                CalculateActivity(_Path)
            End If
        End If


    End Sub


    Public Function getEmergencyWorkTime() As Integer
        Dim Path As String = _Path & "\EinsatzDaten\einsatzberichte_mitglieder.csv"
        Dim Data = New DataTable
        Dim Handler As New CSVDataHandler
        Dim WorkMinutes As Integer = 0

        Data = Handler.CSV2DataTable(Path)

        For i As Integer = 0 To Data.Rows.Count - 1

            Dim startTime As DateTime = Convert.ToDateTime(Data.Rows(i).Item("einsatzzeit_von").ToString)
            Dim endTime As DateTime = Convert.ToDateTime(Data.Rows(i).Item("einsatzzeit_bis").ToString)

            WorkMinutes += Einsatz.CalculateEmergencyTimeSpanPerMember(startTime, endTime)
        Next

        LblEmergencyHours.Text = "Gesamteinsatzzeit: " & MinutesToHours(WorkMinutes).ToString
    End Function

    Public Function MinutesToHours(ByVal minutes As Integer) As Integer
        Return minutes / 60
    End Function

    Public Sub CalculateMemberAllTogether(ByVal DirectoryPath As String)
        Dim Path As String = DirectoryPath & "\FWDaten\mitglieder.csv"
        Dim Data = New DataTable
        Dim Handler As New CSVDataHandler
        Dim CounterMemberActive As Integer = 0
        Dim CounterMemberReserve As Integer = 0
        Dim CounterMemberYouth As Integer = 0
        Dim CounterMember As Integer = 0

        Data = Handler.CSV2DataTable(Path)

        For i As Integer = 0 To Data.Rows.Count - 1
            If Data.Rows(i).Item("status").ToString <> "abgemeldet" Then

                Select Case Data.Rows(i).Item("status").ToString
                    Case "aktiv"
                        CounterMemberActive += 1
                    Case "reserve"
                        CounterMemberReserve += 1
                    Case "jugend"
                        CounterMemberYouth += 1
                    Case Else

                End Select

                CounterMember += 1
            End If
        Next

        LblAmountCrewActive.Text = "Anzahl Aktive: " & CounterMemberActive.ToString
        LblAmountCrewAll.Text = "Anzahl Mannschaft: " & CounterMember.ToString
        LblAmountCrewReserve.Text = "Anzahl Reserve: " & CounterMemberReserve.ToString
        LblAmountCrewYouth.Text = "Anzahl Jugend: " & CounterMemberYouth.ToString
    End Sub

    Public Sub CalculateTrainings(ByVal DirectoryPath As String)
        Dim Path As String = DirectoryPath & "\EinsatzDaten\uebungsberichte.csv"
        Dim Data = New DataTable
        Dim Handler As New CSVDataHandler
        Dim CounterScuba As Integer = 0
        Dim CounterGroup As Integer = 0
        Dim CounterTrain As Integer = 0
        Dim CounterOperator As Integer = 0
        Dim CounterTrainings As Integer = 0

        Data = Handler.CSV2DataTable(Path)

        For i As Integer = 0 To Data.Rows.Count - 1
            Select Case Data.Rows(i).Item("uebungsart").ToString
                Case "Maschinistenübung", "Kraftfahrübung", "Maschinisten- und Kraftfahrübung"
                    CounterOperator += 1
                Case "Gruppenübungen", "Technische Übung", "Gruppenübung"
                    CounterGroup += 1
                Case "Zugsübung"
                    CounterTrain += 1
                Case "Atemschutzübung"
                    CounterScuba += 1
                Case Else

            End Select
            CounterTrainings += 1
        Next

        LblTrainingsZug.Text = "Zugsübungen: " & CounterTrain.ToString
        LblAmountTrainingsGroups.Text = "Gruppenübungen: " & CounterGroup.ToString
        lblAmountTrainingsScuba.Text = "Atemschutzübungen: " & CounterScuba.ToString
        LblAmountTrainingsOperator.Text = "Maschinistenübungen: " & CounterOperator.ToString
        LblAmountTrainingsTotal.Text = "Übungen gesamt: " & CounterTrainings.ToString

        getTrainingsWorkTime()
    End Sub
    Public Function getTrainingsWorkTime() As Integer
        Dim Path As String = _Path & "\EinsatzDaten\uebungsberichte_mitglieder.csv"
        Dim Data = New DataTable
        Dim Handler As New CSVDataHandler
        Dim WorkMinutes As Integer = 0

        Data = Handler.CSV2DataTable(Path)

        For i As Integer = 0 To Data.Rows.Count - 1

            Dim startTime As DateTime = Convert.ToDateTime(Data.Rows(i).Item("einsatzzeit_von").ToString)
            Dim endTime As DateTime = Convert.ToDateTime(Data.Rows(i).Item("einsatzzeit_bis").ToString)

            WorkMinutes += Einsatz.CalculateEmergencyTimeSpanPerMember(startTime, endTime)
        Next

        LblTrainingsHours.Text = "Gesatzübungszeit: " & MinutesToHours(WorkMinutes).ToString
    End Function

    Public Sub CalculateActivity(ByVal directoryPath As String)
        Dim Path As String = directoryPath & "\EinsatzDaten\taetigkeitsberichte.csv"
        Dim Data = New DataTable
        Dim Handler As New CSVDataHandler
        Dim CounterYouth As Integer = 0
        Dim CounterAll As Integer = 0

        Data = Handler.CSV2DataTable(Path)

        For i As Integer = 0 To Data.Rows.Count - 1
            Select Case True
                Case Data.Rows(i).Item("taetigkeitsart").ToString.Contains("FJ")
                    CounterYouth += 1
                Case Else

            End Select
            CounterAll += 1
        Next

        LblAmountActivityTotal.Text = "Anzahl Tätigkeiten Gesamt: " & CounterAll.ToString
        LblTrainingsYouthAll.Text = "Gesamt Übungen: " & CounterYouth.ToString
        getActivityWorkTime()
    End Sub

    Public Function getActivityWorkTime() As Integer
        Dim Path As String = _Path & "\EinsatzDaten\taetigkeitsberichte_mitglieder.csv"
        Dim Data = New DataTable
        Dim Handler As New CSVDataHandler
        Dim WorkMinutes As Integer = 0

        Data = Handler.CSV2DataTable(Path)

        For i As Integer = 0 To Data.Rows.Count - 1

            Dim startTime As DateTime = Convert.ToDateTime(Data.Rows(i).Item("einsatzzeit_von").ToString)
            Dim endTime As DateTime = Convert.ToDateTime(Data.Rows(i).Item("einsatzzeit_bis").ToString)

            WorkMinutes += Einsatz.CalculateEmergencyTimeSpanPerMember(startTime, endTime)
        Next

        lblActivityHours.Text = "Gesamttätigkeitsstunden: " & MinutesToHours(WorkMinutes).ToString
    End Function

End Class
