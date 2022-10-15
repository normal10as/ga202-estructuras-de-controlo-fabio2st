using System;
using System.Globalization;
using System.Threading;

namespace DepositoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sp-Ar", false);
            const decimal tasaMensual = (decimal)(36.0 / 100 / 12);
            decimal capital_inicial, montoInteresMensual, saldo;
            byte cantidadMeses;
            Console.Write("Ingrese capital a depositar: ");
            capital_inicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese meses a depositar: ");
            cantidadMeses = Convert.ToByte(Console.ReadLine());
            saldo = capital_inicial;
            Console.WriteLine("Mes | Capital       | Interes      | Saldo");
            for (byte mes = 1; mes <= cantidadMeses; mes++)
            {
                montoInteresMensual = tasaMensual * saldo;
                Console.Write($" {mes,2} |  {saldo,12:c} | {montoInteresMensual,12:c} | ");
                saldo += montoInteresMensual;
                Console.WriteLine($"{saldo,12:c}");
            }

            Console.WriteLine("Total Interes ganado: {0,12:c}", saldo - capital_inicial);
        }
    }
}