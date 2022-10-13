using System;

namespace HipotenusaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA,ladoB;
            Console.Write("Ingrese el lado A: ");
            ladoA = Convert.ToDouble( Console.ReadLine());
            Console.Write("Ingrese el lado B: ");
            ladoB  = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Hipotenusa: " + CalcularHipotenusa(ladoA, ladoB));
        }
        static double CalcularHipotenusa(double ladoA , double ladoB)
        {
            var ladoC = Math.Sqrt( Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2));
            return ladoC;
        }
    }
}
