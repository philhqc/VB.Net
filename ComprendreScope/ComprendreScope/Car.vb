Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String


    Public Sub FaitQuelqueChoseImportant()
        Console.WriteLine(methodeAide())
    End Sub


    Private Function methodeAide() As String
        Return "Salut partenaire"
    End Function


End Class
