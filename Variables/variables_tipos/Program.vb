Imports System

Module variables_tipos
    Sub Main(args As String())
        Dim nombrePersona As String
        nombrePersona = "Miguel alvarez"
        Console.WriteLine("nombrePersona: " & nombrePersona)
        Dim numeroDocumento As UInteger
        numeroDocumento = 36024571
        Console.WriteLine("numeroDocumento: " & numeroDocumento)
        Dim lugarNacimiento As String
        lugarNacimiento = "Posadas, Misiones, Republica Argentina"
        Console.WriteLine("lugarNacimiento: " & lugarNacimiento)
        Dim fechaNacimiento As Date
        fechaNacimiento = #1983/05/01#
        Console.WriteLine("fechaNacimiento: " & fechaNacimiento)
        Dim altura As Byte
        altura = 183
        Console.WriteLine("altura: " & altura & " cm.")
        Dim argentinidad As Boolean
        argentinidad = True
        Console.WriteLine("argentinidad: " & argentinidad)
        Dim temperaturaAmbiente As Byte
        temperaturaAmbiente = 27
        Console.WriteLine("temperaturaAmbiente: " & temperaturaAmbiente)
        Dim nombreCalle As String
        nombreCalle = "Av. Areco"
        Console.WriteLine("nombreCalle: " & nombreCalle)
        Dim alturaCalle As UShort
        alturaCalle = 2970
        Console.WriteLine("alturaCalle: " & alturaCalle)
        Dim distanciaPosadasUshuaia As Single
        distanciaPosadasUshuaia = 4063.5
        Console.WriteLine("distanciaPosadasUshuaia: " & distanciaPosadasUshuaia & " km.")
        Dim profundidadMar As UShort
        profundidadMar = 11034
        Console.WriteLine("profundidadMar: " & profundidadMar & " m.")
        Dim habitantesTerritorioNacional As UInteger
        habitantesTerritorioNacional = 45022953
        Console.WriteLine("habitantesTerritorioNacional: " & habitantesTerritorioNacional)
        Dim pesoEnKilogramos As Single
        pesoEnKilogramos = 2.15
        Console.WriteLine("pesoEnKilogramos: " & pesoEnKilogramos & " kg.")
        Dim precioProducto As Single
        precioProducto = 44.75
        Console.WriteLine("precioProducto: $" & precioProducto)

    End Sub
End Module
