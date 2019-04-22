Imports System

Module aritmética
    Sub Main(args As String())
        Dim e1 As Integer
        Dim e2 As Integer
        Dim f1 As Single
        Dim f2 As Single
        e1 = 7
        e2 = 5
        f1 = 3.5
        f2 = 2.7
        Console.WriteLine("Suma entero con entero: " & e1 & " + " & e2 & " = " & e1 + e2)
        Console.WriteLine("Suma flotante con entero: " & f1 & " + " & e2 & " = " & f1 + e2)
        Console.WriteLine("Suma flotante con flotante: " & f1 & " + " & f2 & " = " & f1 + f2)

        Console.WriteLine("***************************************************")

        Console.WriteLine("Resta entero con entero: " & e1 & " - " & e2 & " = " & e1 - e2)
        Console.WriteLine("Resta flotante con entero: " & f1 & " - " & e2 & " = " & f1 - e2)
        Console.WriteLine("Resta flotante con flotante: " & f1 & " - " & f2 & " = " & f1 - f2)

        Console.WriteLine("***************************************************")

        Console.WriteLine("Multiplicacion entero con entero: " & e1 & " * " & e2 & " = " & e1 * e2)
        Console.WriteLine("Multiplicacion flotante con entero: " & f1 & " * " & e2 & " = " & f1 * e2)
        Console.WriteLine("Multiplicacion flotante con flotante: " & f1 & " * " & f2 & " = " & f1 * f2)

        Console.WriteLine("***************************************************")

        Console.WriteLine("Division entera entero con entero: " & e1 & " \ " & e2 & " = " & e1 \ e2)
        Console.WriteLine("Division entera flotante con entero: " & f1 & " \ " & e2 & " = " & f1 \ e2)
        Console.WriteLine("Division entera flotante con flotante: " & f1 & " \ " & f2 & " = " & f1 \ f2)

        Console.WriteLine("***************************************************")

        Console.WriteLine("Division real entero con entero: " & e1 & " / " & e2 & " = " & e1 / e2)
        Console.WriteLine("Division real flotante con entero: " & f1 & " / " & e2 & " = " & f1 / e2)
        Console.WriteLine("Division real flotante con flotante: " & f1 & " / " & f2 & " = " & f1 / f2)
    End Sub
End Module
