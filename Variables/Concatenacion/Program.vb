Imports System

Module concatenacion
    Sub Main(args As String())
        Dim nombreEmpresa As String
        nombreEmpresa = "MasterBranch"
        Dim nombreCalle As String
        nombreCalle = "San Martin"
        Dim alturaCalle As UShort
        alturaCalle = 6573
        Dim fechaInicioActividades As Date
        fechaInicioActividades = #2000/09/23 8:00:00#

        Console.WriteLine("Conversion Implicita: " & nombreEmpresa & " " & nombreCalle & " " & alturaCalle & " " & fechaInicioActividades)

        Console.WriteLine("Conversion explicita: " + nombreEmpresa + " " + nombreCalle + " " + Convert.ToString(alturaCalle) + " " + Convert.ToString(fechaInicioActividades))

    End Sub
End Module
