Imports System

Module Program
    Sub Main(args As String())
        Dim ValorAngulo As Short
        Console.Write("Ingrese el valor del angulo (0° a 360°): ")
        ValorAngulo = Console.ReadLine
        Select Case ValorAngulo
            Case < 0, >= 360
                Console.WriteLine("Error")
            Case < 90
                Console.WriteLine("Es Agudo")
            Case = 90
                Console.WriteLine("Es Recto")
            Case < 180
                Console.WriteLine("Es Obtuso")
            Case = 180
                Console.WriteLine("Es Llano")
            Case Else
                Console.WriteLine("Es Cóncavo")
        End Select
    End Sub
End Module
