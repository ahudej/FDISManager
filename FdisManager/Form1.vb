Imports System.IO
Imports System.Reflection


Public Class Form1

    Private _Path As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FbdDirectory.Description = "Ordner auswählen, in dem die beiden Export Ordner sind."
        Dim result As DialogResult = FbdDirectory.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            _Path = FbdDirectory.SelectedPath
        End If
    End Sub

    Private Sub BtnBirthday_Click(sender As Object, e As EventArgs) Handles BtnBirthday.Click
        Dim Path As String = _Path & "\Daten\mitglieder.csv"
        Dim Lines = IO.File.ReadAllLines(Path, System.Text.Encoding.UTF8)
        Dim Data = New DataTable
        Dim ShowData = New DataTable
        Dim ColoumCount = Lines.First.Split(";"c).Length
        Dim Coloum() As String

        Dim Mitglied As Mitglied
        Dim BirthDayList65 = New List(Of Mitglied)
        Dim BirthDayList70 = New List(Of Mitglied)
        Dim BirthDayList75 = New List(Of Mitglied)
        Dim BirthDayList80 = New List(Of Mitglied)
        Dim BirthDayList85 = New List(Of Mitglied)
        Dim BirthDayList90 = New List(Of Mitglied)
        Dim BirthDayList95 = New List(Of Mitglied)
        Dim BirthDayList100 = New List(Of Mitglied)

        For i As Integer = 0 To Lines.Count - 1
            Lines(i) = Lines(i).Replace(Chr(34), String.Empty)
        Next

        Coloum = Lines(0).Split(";"c)

        For i As Int32 = 1 To ColoumCount
            Data.Columns.Add(New DataColumn(Coloum(i - 1), GetType(String)))
        Next

        For i = 1 To UBound(Lines)
            Lines(i - 1) = Lines(i)
        Next i
        ReDim Preserve Lines(UBound(Lines) - 1)

        For Each line In Lines
            Dim objFields = From field In line.Split(";"c)
                            Select CType(field, Object)
            Dim newRow = Data.Rows.Add()
            newRow.ItemArray = objFields.ToArray()
        Next

        For i As Integer = 0 To Data.Rows.Count - 1
            Dim YearStr As String = Data.Rows(i).Item("geburtsdatum").ToString.Substring(Data.Rows(i).Item("geburtsdatum").ToString.Length - 4)
            Dim YearInt As Integer = CInt(YearStr)
            Dim ThisYearInt As Integer = CInt(Date.Now.Year)
            Dim CheckYear As Integer = ThisYearInt - YearInt
            Mitglied = New Mitglied

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
        Next

        ShowData.Columns.Add(New DataColumn("Runder", GetType(String)))

        For i As Int32 = 1 To ColoumCount
            ShowData.Columns.Add(New DataColumn(Coloum(i - 1), GetType(String)))
        Next

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


        'ShowData = Data
        ShowData.Columns.Remove("nummer")
        ShowData.Columns.Remove("titel")
        ShowData.Columns.Remove("amtstitel")
        ShowData.Columns.Remove("geschlecht")
        ShowData.Columns.Remove("id_mitgliedschaften")
        ShowData.Columns.Remove("id_personen")
        ShowData.Columns.Remove("ausstellungsdatum_fw_pass")
        ShowData.Columns.Remove("angelobungsdatum")
        ShowData.Columns.Remove("datum_aktiv")
        ShowData.Columns.Remove("datum_in_reserve")
        ShowData.Columns.Remove("datum_von_jugend")
        ShowData.Columns.Remove("datum_ehrenmitglied")
        ShowData.Columns.Remove("abmeldungsdatum")
        ShowData.Columns.Remove("Column1")
        ShowData.Columns.Remove("eintrittsdatum")


        DataGridView1.DataSource = ShowData


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

    Private Sub BtnRankUp_Click(sender As Object, e As EventArgs) Handles BtnRankUp.Click
        Dim Path As String = _Path & "\Daten\funktionen_mitglieder.csv"
        Dim Lines = IO.File.ReadAllLines(Path, System.Text.Encoding.UTF8)
        Dim Data = New DataTable
        Dim ShowData = New DataTable
        Dim ColoumCount = Lines.First.Split(";"c).Length
        Dim Coloum() As String
        Dim Mitglied As Mitglied

        For i As Integer = 0 To Lines.Count - 1
            Lines(i) = Lines(i).Replace(Chr(34), String.Empty)
        Next

        Coloum = Lines(0).Split(";"c)

        For i As Int32 = 1 To ColoumCount
            Data.Columns.Add(New DataColumn(Coloum(i - 1), GetType(String)))
        Next

        For i = 1 To UBound(Lines)
            Lines(i - 1) = Lines(i)
        Next i
        ReDim Preserve Lines(UBound(Lines) - 1)

        For Each line In Lines
            Dim objFields = From field In line.Split(";"c)
                            Select CType(field, Object)
            Dim newRow = Data.Rows.Add()
            newRow.ItemArray = objFields.ToArray()
        Next
    End Sub
End Class
