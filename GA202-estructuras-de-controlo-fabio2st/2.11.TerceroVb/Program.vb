Imports System

Module Program
    Sub Main(args As String())
        Dim primerValor, segundoValor, tercerValor, cuartoValor, quintoValor As Int16
        primerValor = ingresarValor()
        segundoValor = ingresarValor()
        tercerValor = ingresarValor()
        cuartoValor = ingresarValor()
        quintoValor = ingresarValor()

        If primerValor > segundoValor And primerValor > tercerValor And primerValor > cuartoValor And primerValor > quintoValor Then
            Console.WriteLine("El primer valor es el mayor")
        ElseIf segundoValor > tercerValor And segundoValor > cuartoValor And segundoValor > quintoValor Then
            Console.WriteLine("El segundo valor es el mayor")
        ElseIf tercerValor > cuartoValor And tercerValor > quintoValor Then
            Console.WriteLine("El tercer valor es el mayor")
        ElseIf cuartoValor > quintoValor Then
            Console.WriteLine("El cuarto valor es el mayor")
        Else
            Console.WriteLine("El quinto valor es el mayor")
        End If
    End Sub
    Private Function ingresarValor() As Int16
        Console.Write("Ingrese un numero: ")
        Return Console.ReadLine()
    End Function
End Module
