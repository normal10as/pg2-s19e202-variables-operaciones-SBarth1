Imports System

Module sumatoria_media
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Console.Write("Ingrese un numero: ")
        a = Console.ReadLine()
        Console.Write("Ingrese otro numero: ")
        b = Console.ReadLine()
        Console.Write("Ingrese otro numero mas: ")
        c = Console.ReadLine()
        Console.Write("Ingrese un ultimo numero: ")
        d = Console.ReadLine()

        Console.WriteLine("Sumatoria de todos los numeros: " & a + b + c + d)
        Console.WriteLine("Media de los numeros ingresados: " & (a + b + c + d) / 4)


    End Sub
End Module
