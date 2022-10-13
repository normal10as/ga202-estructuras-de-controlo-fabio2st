Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Un n�mero primo es un n�mero natural mayor que 1 que tiene �nicamente dos divisores distintos: �l mismo y el 1")
        Dim divisor As UInteger
        Dim raiz As Single
        For x = 2 To 1000
            raiz = Math.Sqrt(x)
            divisor = 2
            Do While x Mod divisor <> 0 And divisor <= raiz
                divisor += 1
            Loop
            If x Mod divisor <> 0 Or divisor > raiz Then
                Console.Write(" " & x)
            End If
        Next
    End Sub
    Sub ObtenerProximoPrimo(ByRef valor As UInteger)
        Do
            valor += 1
        Loop Until isPrimo(valor)
    End Sub
    Function isPrimo(valor As UInteger) As Boolean
        Dim divisor, raizcuadrada As UInteger
        ' el m�ximo valor divisor sera equivalente a la ra�z cuadrada del valor
        ' esto reduce iteraciones innecesarias
        raizcuadrada = Math.Sqrt(valor)
        'Console.WriteLine("Raiz cuadrada: " & raizcuadrada)
        ' el primer valor divisor para descartar un numero primo es 2
        divisor = 2
        ' itera si el resto es distinto de cero y el divisor es menor o igual a la ra�z cuadrada
        ' si el primer calculo de resto da 0 no itera en absoluto
        Do While valor Mod divisor <> 0 And divisor <= raizcuadrada
            'Console.Write(" " & divisor)
            divisor += 1
        Loop
        'si el divisor es mayor a la ra�z cuadrada es primo
        Return divisor > raizcuadrada
    End Function
End Module
