Imports System

Module Program
    Sub Main(args As String())
        Dim pares, impares As UShort
        Process(pares, impares)
        Output(pares, impares)
    End Sub
    Private Sub Process(ByRef pares As UShort, ByRef impares As UShort)
        Dim valor As UInteger
        Do
            Console.Write("Ingrese un numero positivo (0-Para Salir): ")
            valor = Console.ReadLine()
            If isPar(valor) Then
                If valor > 0 Then   'Evita el Cero ya que es considerado par, porque 0 Mod 2 -> 0
                    pares += 1
                End If
            Else
                impares += 1
            End If
        Loop Until valor = 0
    End Sub
    Private Function isPar(valor As UInteger) As Boolean
        Return valor Mod 2 = 0
    End Function
    Private Sub Output(pares As UShort, impares As UShort)
        If pares + impares > 0 Then
            If impares = 0 Then
                Console.WriteLine("Son todos pares")
            ElseIf pares = 0 Then
                Console.WriteLine("Son todos impares")
            Else
                Console.WriteLine("El total de numero pares es de: " & pares)
                Console.WriteLine("El total de numeros impares es de: " & impares)
            End If
        End If
    End Sub
End Module
