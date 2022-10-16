using System;

static class Program
{
    public static void Main(string[] args)
    {
        ushort pares = 0, impares = 0;
        Process(ref pares, ref impares);
        Output(pares, impares);
    }
    private static void Process(ref ushort pares, ref ushort impares)
    {
        uint valor;
        do
        {
            Console.Write("Ingrese un numero positivo (0-Para Salir): ");
            valor = Convert.ToUInt32( Console.ReadLine());
            if (isPar(valor))
            {
                if (valor > 0)
                    pares++;
            }
            else
                impares++;
        }
        while (valor != 0);
    }
    private static bool isPar(uint valor)
    {
        return valor % 2 == 0;
    }
    private static void Output(ushort pares, ushort impares)
    {
        if (pares + impares > 0)
        {
            if (impares == 0)
                Console.WriteLine("Son todos pares");
            else if (pares == 0)
                Console.WriteLine("Son todos impares");
            else
            {
                Console.WriteLine("El total de numero pares es de: " + pares);
                Console.WriteLine("El total de numeros impares es de: " + impares);
            }
        }
    }
}
