Imports System

Module semanas
    Sub Main(args As String())
        Const diasAnho As Integer = 365
        Const diasLaborales As Integer = 247
        Const diasSemana As Integer = 7
        Console.WriteLine("Semanas del A�o: " & diasAnho / diasSemana)
        Console.WriteLine("Semanas laborales del a�o: " & diasLaborales / diasSemana)
    End Sub
End Module
