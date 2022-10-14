Imports System

Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim precioUnitario, descuentoPorcentaje, descuentoMonto, subTotal As Decimal

        Console.Write("Ingrese el precio del articulo: ")
        precioUnitario = Console.ReadLine()
        Console.Write("Ingrese la cantidad del articulo: ")
        cantidad = Console.ReadLine()
        If cantidad > 250 Then
            descuentoPorcentaje = 0.2
        ElseIf cantidad > 50 Then
            descuentoPorcentaje = 0.1
        ElseIf cantidad >= 10 Then
            descuentoPorcentaje = 0.05
        End If
        subTotal = cantidad * precioUnitario
        Console.WriteLine("el sub total es: " & subTotal)
        descuentoMonto = subTotal * descuentoPorcentaje
        Console.WriteLine("el descuento es {0}%: {1}", descuentoPorcentaje * 100, descuentoMonto)
        Console.WriteLine("el total es: " & subTotal - descuentoMonto)
    End Sub
End Module
