Public Class Einsatz

    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _Type As String
    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property


    Structure EinsatzMitglied
        Dim StartTime As DateTime
        Dim EndTime As DateTime
        Dim Hours As Integer
        Dim Minutes As Integer
        Dim FullTime As Integer
    End Structure
    ''' <summary>
    ''' Die Einsatzzeit in Minuten berechnen.
    ''' </summary>
    ''' <param name="startTime"></param>
    ''' <param name="endTime"></param>
    ''' <returns></returns>
    Public Shared Function CalculateEmergencyTimeSpanPerMember(ByVal startTime As DateTime, ByVal endTime As DateTime) As Integer
        'Dim Member As New EinsatzMitglied
        Dim Span As TimeSpan
        Dim FullTime As Integer = 0
        Dim HoursTemp As Integer = 0

        Span = endTime.Subtract(startTime)

        If Span.Hours <> 0 Then
            HoursTemp = Span.Hours * 60
        End If

        FullTime = Span.Minutes + HoursTemp

        Return FullTime
    End Function

End Class
