Imports System

Module Program
    Enum DiasSemana
        Lunes = 1
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
        Domingo
    End Enum
    Sub Main(args As String())
        Dim diaIngresado As DiasSemana
        Console.WriteLine("Ingrese un numero del 0 al 6:  ")
        diaIngresado = Console.ReadLine()

        Select Case (diaIngresado)
            Case DiasSemana.Lunes, DiasSemana.Martes, DiasSemana.Domingo, DiasSemana.Miercoles, DiasSemana.Jueves, DiasSemana.Viernes, DiasSemana.Sabado
                'Case DiasSemana.Lunes To DiasSemana.Domingo
                Console.WriteLine("Corresponde al dia " & (diaIngresado).ToString)
            Case Else
                Console.WriteLine("El valor ingresado no es correcto.")
        End Select
    End Sub
End Module
