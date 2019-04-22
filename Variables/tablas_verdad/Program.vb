Imports System

Module tablas_verdad
    Sub Main(args As String())
        Dim exp1 As Boolean = True
        Dim exp2 As Boolean = False
        Dim control As Boolean
        Console.WriteLine("Negacion")
        control = Not exp1
        Console.WriteLine("Not " & exp1 & " = " & control)
        control = Not exp2
        Console.WriteLine("Not " & exp2 & " = " & control)

        Console.WriteLine("***************************")

        Console.WriteLine("Conjuncion")
        control = exp1 And exp1
        Console.WriteLine(exp1 & " And " & exp1 & " = " & control)
        control = exp1 And exp2
        Console.WriteLine(exp1 & " And " & exp2 & " = " & control)
        control = exp2 And exp1
        Console.WriteLine(exp2 & " And " & exp1 & " = " & control)
        control = exp2 And exp2
        Console.WriteLine(exp2 & " And " & exp2 & " = " & control)

        Console.WriteLine("***************************")

        Console.WriteLine("Disyuncion inclusiva")
        control = exp1 Or exp1
        Console.WriteLine(exp1 & " Or " & exp1 & " = " & control)
        control = exp1 Or exp2
        Console.WriteLine(exp1 & " Or " & exp2 & " = " & control)
        control = exp2 Or exp1
        Console.WriteLine(exp2 & " Or " & exp1 & " = " & control)
        control = exp2 Or exp2
        Console.WriteLine(exp2 & " Or " & exp2 & " = " & control)

        Console.WriteLine("***************************")

        Console.WriteLine("Disyuncion exclusiva")
        control = exp1 Xor exp1
        Console.WriteLine(exp1 & " Xor " & exp1 & " = " & control)
        control = exp1 Xor exp2
        Console.WriteLine(exp1 & " Xor " & exp2 & " = " & control)
        control = exp2 Xor exp1
        Console.WriteLine(exp2 & " Xor " & exp1 & " = " & control)
        control = exp2 Xor exp2
        Console.WriteLine(exp2 & " Xor " & exp2 & " = " & control)
    End Sub
End Module
