Console.WriteLine("Un número primo es un número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1");
uint divisor;
double raiz;

for (ushort x = 2; x <= 1000; x++)
{
    raiz = Math.Sqrt(x);
    divisor = 2;
    while (x % divisor != 0 && divisor <= raiz)
        divisor++;
    if (x % divisor != 0 || divisor > raiz)
        Console.Write(" " + x);
}