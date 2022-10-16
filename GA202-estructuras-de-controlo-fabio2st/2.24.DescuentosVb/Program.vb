Imports System
Module Program
    Sub Main(args As String())
        Dim totalDescuento, total As Decimal
        Process(totalDescuento, total)
        OutputTotal(totalDescuento, total)
    End Sub
    Private Sub Process(ByRef totalDescuento As Decimal, ByRef totalMonto As Decimal)
        Dim cantidad As Int16
        Dim precio, descuentoPorcentaje, subtotal, montoDescontado, totalArticulo As Decimal
        cantidad = LeerCantidad()
        Do Until cantidad = 0
            precio = LeerPrecio()
            subtotal = cantidad * precio
            descuentoPorcentaje = CalcularPorcentajeDescuento(cantidad)
            montoDescontado = subtotal * descuentoPorcentaje / 100
            totalArticulo = subtotal - montoDescontado
            OutputDetalle(descuentoPorcentaje, subtotal, montoDescontado, totalArticulo)
            totalDescuento += montoDescontado
            totalMonto += totalArticulo
            cantidad = LeerCantidad()
        Loop
    End Sub
    Private Function LeerCantidad() As Short
        Dim cantidad As Short
        Console.Write(vbCrLf & "Cantidad : ")
        cantidad = Console.ReadLine()
        Return cantidad
    End Function
    Private Function LeerPrecio() As Decimal
        Dim monto As Decimal
        Console.Write("Precio: ")
        monto = Console.ReadLine()
        Return monto
    End Function
    Private Function CalcularPorcentajeDescuento(cantidad As Short) As Decimal
        Select Case cantidad
            Case 10 To 50
                Return 5
            Case 51 To 250
                Return 10
            Case >= 251
                Return 20
            Case Else
                Return 0
        End Select
    End Function
    Private Sub OutputDetalle(descuentoPorcentaje As Decimal, subtotal As Decimal, montoDescontado As Decimal, totalArticulo As Decimal)
        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine($"Descuento {descuentoPorcentaje}%: ${montoDescontado}")
        Console.WriteLine("Total: " & totalArticulo)
    End Sub
    Private Sub OutputTotal(totalDescuento As Decimal, total As Decimal)
        Console.WriteLine("Total descuentos: " & totalDescuento)
        Console.WriteLine("Total a cobrar:   " & total)
    End Sub
End Module
