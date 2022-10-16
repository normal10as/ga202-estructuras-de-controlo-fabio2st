Imports System

Module Program
    Enum OpcionesMenu
        AltaCliente = 1
        ModificacionCliente
        ListarClientes
    End Enum
    Sub Main(args As String())
        Dim eleccion As OpcionesMenu
        MostrarMenuOpciones()
        eleccion = IngresarOpcion()
        EjecutarOpcion(eleccion)
    End Sub

    Private Sub EjecutarOpcion(eleccion As OpcionesMenu)
        Const mensajeEleccion As String = "Ingresando al programa: "
        Select Case eleccion
            Case OpcionesMenu.AltaCliente
                Console.WriteLine(mensajeEleccion & OpcionesMenu.AltaCliente.ToString())
            Case OpcionesMenu.ModificacionCliente
                Console.WriteLine(mensajeEleccion & OpcionesMenu.ModificacionCliente.ToString())
            Case OpcionesMenu.ListarClientes
                Console.WriteLine(mensajeEleccion & OpcionesMenu.ListarClientes.ToString())
            Case Else
                Console.WriteLine("La opción no es valida.")
        End Select
    End Sub

    Private Function IngresarOpcion() As OpcionesMenu
        Dim eleccion As OpcionesMenu
        Console.Write("Ingrese el N° de su eleccion: ")
        eleccion = Console.ReadLine()
        Return eleccion
    End Function

    Private Sub MostrarMenuOpciones()
        Console.WriteLine(vbCrLf & "Los programas a elegir son:")
        Console.WriteLine("{0:d}) {0}", OpcionesMenu.AltaCliente)
        Console.WriteLine("{0:d}) {0}", OpcionesMenu.ModificacionCliente)
        Console.WriteLine("{0:d}) {0}", OpcionesMenu.ListarClientes)
    End Sub
End Module
