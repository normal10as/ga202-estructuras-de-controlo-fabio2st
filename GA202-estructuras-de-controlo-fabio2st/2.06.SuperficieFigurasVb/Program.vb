Imports System

Module Program
    Sub Main(args As String())
        'Falta ingresar los valores por consola
        Console.WriteLine(CalcularSuperficie(10))
        Console.WriteLine(CalcularSuperficie(10, 15))
        Console.WriteLine(CalcularSuperficie(10, 15, 20))
    End Sub

    Private Function CalcularSuperficie(baseMenor As Integer, baseMayor As Integer, altura As Integer) As Single
        Return CalcularSuperficie((baseMenor + baseMayor) / 2, altura)
    End Function
    Private Function CalcularSuperficie(base As Integer, altura As Integer) As Single
        Return base * altura
    End Function
    Private Function CalcularSuperficie(lado As Integer) As Single
        Return CalcularSuperficie(lado, lado)
    End Function
End Module
