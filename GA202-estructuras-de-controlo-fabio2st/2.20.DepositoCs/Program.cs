namespace DepositoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal capitalInicial, interesAnual, interesPesos;
            Console.Write("Ingrese Capital: ");
            capitalInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese Interés anual: ");
            interesAnual = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("MES  CAPITAL $  INTERES $       SALDO $");
            interesPesos = CalcularInteresEnPesos(capitalInicial, interesAnual);
            Reporte(1, capitalInicial, interesPesos);
            capitalInicial += interesPesos;
            interesPesos = CalcularInteresEnPesos(capitalInicial, interesAnual);
            Reporte(2, capitalInicial, interesPesos);
            capitalInicial += interesPesos;
            interesPesos = CalcularInteresEnPesos(capitalInicial, interesAnual);
            Reporte(3, capitalInicial, interesPesos);
            capitalInicial += interesPesos;
            interesPesos = CalcularInteresEnPesos(capitalInicial, interesAnual);
            Reporte(4, capitalInicial, interesPesos);
            capitalInicial += interesPesos;
            interesPesos = CalcularInteresEnPesos(capitalInicial, interesAnual);
            Reporte(5, capitalInicial, interesPesos);
            capitalInicial += interesPesos;
            interesPesos = CalcularInteresEnPesos(capitalInicial, interesAnual);
            Reporte(6, capitalInicial, interesPesos);
        }
        static decimal CalcularInteresEnPesos(decimal capital, decimal interesAnual)
        {
            return capital * interesAnual / 12 / 100;
        }
        static void Reporte(ushort mes, decimal capital, decimal interesPesos)
        {
            Console.WriteLine($"{mes}    {capital:N2}     {interesPesos:N2}     {capital+interesPesos:N2}");
        }
    }
}