Imports System

Module Program
    Sub Main(args As String())
        Dim valorMenor, valorMayor As UShort
        ' los dos primeros valores son asignados por definición
        valorMayor = 1
        mostrar(1, valorMenor)
        mostrar(2, valorMayor)
        ' los siguientes valores son calculados
        For x = 3 To 20
            Dim nuevoValor = valorMenor + valorMayor
            mostrar(x, nuevoValor)
            valorMenor = valorMayor
            valorMayor = nuevoValor
        Next
    End Sub
    Private Sub mostrar(indice As UShort, valor As UShort)
        Console.WriteLine("{0}) {1}", indice, valor)
    End Sub
End Module
