Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(Multiplicar(2, 3))
        Console.WriteLine(Multiplicar(2, 3, 7))
        Console.WriteLine(Multiplicar(2, 3, 7, 5))
    End Sub

    Private Function Multiplicar(v1 As Integer, v2 As Integer, v3 As Integer, v4 As Integer) As Integer
        Return Multiplicar(Multiplicar(v1, v2, v3), v4)
    End Function

    Private Function Multiplicar(v1 As Integer, v2 As Integer, v3 As Integer) As Integer
        Return Multiplicar(Multiplicar(v1, v2), v3)
    End Function

    Private Function Multiplicar(v1 As Integer, v2 As Integer) As Integer
        Return v1 * v2
    End Function
End Module
