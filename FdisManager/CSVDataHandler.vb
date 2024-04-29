Imports System.IO

Public Class CSVDataHandler

    Public Shared Function CSVToDataTable(ByVal path As String) As DataTable
        Dim Lines = IO.File.ReadAllLines(path, System.Text.Encoding.Default)
        Dim ColoumCount = Lines.First.Split(";"c).Length
        Dim Coloum() As String
        Dim Data As New DataTable

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

        Return Data

    End Function

    Public Shared Sub DataTableToCsv(dt As DataTable, filePath As String)
        Try
            Using writer As New StreamWriter(filePath)
                Dim header As String = String.Join(";", dt.Columns.Cast(Of DataColumn)().Select(Function(column) column.ColumnName))
                writer.WriteLine(header)

                For Each row As DataRow In dt.Rows
                    Dim values As String = String.Join(";", row.ItemArray.Select(Function(value) value.ToString()))
                    writer.WriteLine(values)
                Next
            End Using

            MessageBox.Show("Export wurde durchgeführt und in den Downloads Ordner gespeichert.")
        Catch ex As Exception
            MessageBox.Show("Es gab einem Fehler, beim Daten Export - vermutlich ist die Datei noch geöffnet oder wird gerade verwendet.")
        End Try

    End Sub

End Class
