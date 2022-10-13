Imports System

Module Program
    Sub Main(args As String())
        Dim radioBase, height As Double
        Console.Write("Ingrese el radio: ")
        radioBase = Console.ReadLine()
        Console.Write("Ingrese la altura: ")
        height = Console.ReadLine()
        Console.WriteLine("Volumen cilindro: " & GetVolume(radioBase, height))
    End Sub
    Function GetVolume(radioBase As Double, height As Double) As Double
        Dim volume As Double = Math.PI * Math.Pow(radioBase, 2) * height
        Return volume
    End Function
End Module
