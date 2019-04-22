Imports System

Module variables
    Sub Main(args As String())
        Dim nombre As String
        Dim apellido As String
        Dim fechaNacimiento As Date
        Console.WriteLine("Escriba su nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Escriba su apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("Escriba fecha de nacimiento (AAAA/MM/DD): ")
        fechaNacimiento = Console.ReadLine()
        Console.WriteLine(apellido & ", " & nombre & " nació el " & fechaNacimiento)


    End Sub
End Module
