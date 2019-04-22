Imports System

Module semanas
    Sub Main(args As String())
        Const diasAnho As Integer = 365
        Const diasLaborales As Integer = 247
        Const diasSemana As Integer = 7
        Console.WriteLine("Semanas del Año: " & diasAnho / diasSemana)
        Console.WriteLine("Semanas laborales del año: " & diasLaborales / diasSemana)
    End Sub
End Module
