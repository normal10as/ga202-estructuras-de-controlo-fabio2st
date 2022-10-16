Imports System

Module Program
    Enum OpcionesMenu
        AltaCliente = 1
        ModificacionCliente
        ListarClientes
        Salir = 0
    End Enum
    Sub Main(args As String())
        Dim eleccion As OpcionesMenu
        Do
            MostrarMenuOpciones()
            eleccion = IngresarOpcion()
            EjecutarOpcion(eleccion)
        Loop Until eleccion = OpcionesMenu.Salir
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
            Case OpcionesMenu.Salir
                Console.WriteLine("Saliendo del programa...")
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
        Console.WriteLine("{0:d}) {0}", OpcionesMenu.Salir)
    End Sub
End Module
