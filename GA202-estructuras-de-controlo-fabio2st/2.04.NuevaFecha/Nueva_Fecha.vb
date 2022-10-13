Imports System.DateTime

Module Nueva_Fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim dias As UShort
        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar: ")
        dias = Console.ReadLine()
        Console.WriteLine("La nueva fecha es: " & fecha.AddDays(dias))
    End Sub
End Module
