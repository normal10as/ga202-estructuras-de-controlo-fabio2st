Imports System
Imports System.Globalization
Imports System.Threading

Module Program
    Sub Main(args As String())
        Thread.CurrentThread.CurrentCulture = New CultureInfo("sp-Ar", False)

        Const tasaMensual As Decimal = 36 / 100 / 12
        Dim capital_inicial, montoInteresMensual, saldo As Decimal
        Dim cantidadMeses As Byte

        Console.Write("Ingrese capital a depositar: ")
        capital_inicial = Console.ReadLine()
        Console.Write("Ingrese meses a depositar: ")
        cantidadMeses = Console.ReadLine()

        saldo = capital_inicial
        Console.WriteLine("Mes | Capital       | Interes      | Saldo")
        For mes As Byte = 1 To cantidadMeses
            montoInteresMensual = tasaMensual * saldo
            Console.Write($" {mes,2} |  {saldo,12:c} | {montoInteresMensual,12:c} | ")
            saldo += montoInteresMensual
            Console.WriteLine($"{saldo,12:c}")
        Next
        Console.WriteLine("Total Interes ganado: {0,12:c}", saldo - capital_inicial)
    End Sub
End Module