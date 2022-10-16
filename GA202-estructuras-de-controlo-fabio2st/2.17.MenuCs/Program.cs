using System;

namespace MenuCs
{
    class Program
    {
        public enum OpcionesMenu
        {
            AltaCliente = 1,
            Modificacioncliente,
            OpcionTres,
        }

        static void Main(string[] args)
        {
            OpcionesMenu eleccion;
            MostrarMenu();
            eleccion = IngresarOpcion();
            ejecutarOpcion(eleccion);
        }

        private static void ejecutarOpcion(OpcionesMenu eleccion)
        {
            const string mensajeEleccion = "Ingresando al programa: ";
            switch (eleccion)
            {
                case OpcionesMenu.AltaCliente:
                    {
                        Console.WriteLine(mensajeEleccion + OpcionesMenu.AltaCliente.ToString());
                        break;
                    }

                case OpcionesMenu.Modificacioncliente:
                    {
                        Console.WriteLine(mensajeEleccion + OpcionesMenu.Modificacioncliente.ToString());
                        break;
                    }

                case OpcionesMenu.OpcionTres:
                    {
                        Console.WriteLine(mensajeEleccion + OpcionesMenu.OpcionTres.ToString());
                        break;
                    }

                default:
                    {
                        Console.WriteLine("La opción no es valida.");
                        break;
                    }
            }
        }

        private static OpcionesMenu IngresarOpcion()
        {
            OpcionesMenu eleccion;
            Console.Write("Ingrese el N° de su eleccion: ");
            eleccion = (OpcionesMenu)Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Los programas a elegir son:");
            Console.WriteLine("{0:d}) {0}", OpcionesMenu.AltaCliente);
            Console.WriteLine("{0:d}) {0}", OpcionesMenu.Modificacioncliente);
            Console.WriteLine("{0:d}) {0}", OpcionesMenu.OpcionTres);
        }
    }
}