Imports System

Module Program
    Enum Meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main(args As String())
        Dim mes As Meses
        Dim anio As UShort
        Console.Write("Ingrese un mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case Meses.Febrero
                Console.Write("Indique el año: ")
                anio = Console.ReadLine()
                'If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
                If isMultiplo(anio, 4) And Not isMultiplo(anio, 100) Or isMultiplo(anio, 400) Then
                    Console.WriteLine("El mes tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
            Case Meses.Enero, Meses.Marzo, Meses.Mayo, Meses.Julio, Meses.Agosto, Meses.Octubre, Meses.Diciembre
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.Abril, Meses.Junio, Meses.Septiembre, Meses.Noviembre
                Console.WriteLine("El mes tiene 30 dias")
            Case Else
                Console.WriteLine("mes incorrecto.")
        End Select
    End Sub

    Function isMultiplo(valor As UShort, divisor As UShort) As Boolean
        Return valor Mod divisor = 0
    End Function
End Module
