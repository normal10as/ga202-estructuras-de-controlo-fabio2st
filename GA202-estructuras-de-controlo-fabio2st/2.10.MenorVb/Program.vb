Imports System

Module Program
    Sub Main(args As String())
        Dim numero1, numero2, numero3 As Single

        Console.Write("Ingrese 1� n�mero: ")
        numero1 = Console.ReadLine()
        Console.Write("Ingrese 2� n�mero: ")
        numero2 = Console.ReadLine()
        Console.Write("Ingrese 3� n�mero: ")
        numero3 = Console.ReadLine()

        If numero1 < numero2 And numero1 < numero3 Then ' se ver9ifica el primer valor
            Console.Write("el menor es: " & numero1)
        ElseIf numero2 < numero3 Then ' descartado el primero se verifica el segundo
            Console.Write("el menor es:" & numero2)
        Else    ' descartado el primero y el segundo solo resta el tercero
            Console.Write("el menor es: " & numero3)
        End If
    End Sub
End Module
