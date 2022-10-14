using System;


namespace AnguloCs
{
    class Program
    {
        static void Main(string[] args)
        {
            short valorAngulo;
            Console.Write("Ingrese el valor del angulo (0° a 360°): ");
            valorAngulo = Convert.ToInt16( Console.ReadLine());
            switch (valorAngulo)
            {
                case 90:
                    Console.WriteLine("Es Recto");
                    break;
                case 180:
                    Console.WriteLine("Es Llano");
                    break;
                case var valor when valor < 0 || valor >= 360:
                    Console.WriteLine("Error");
                    break;
                case var valor when valor < 90:
                    Console.WriteLine("Es Agudo");
                    break;
                case var valor when valor < 180:
                    Console.WriteLine("Es Obtuso");
                    break;
                default:
                    Console.WriteLine("Es Cóncavo");
                    break;
            }
        }
    }
}
