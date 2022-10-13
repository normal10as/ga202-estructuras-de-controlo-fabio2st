// See https://aka.ms/new-console-template for more information
namespace HipotenusaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ObtenerFecha(20));
            Console.WriteLine(ObtenerFecha(20, 6));
            Console.WriteLine( ObtenerFecha(20,6,2023));
        }

        private static DateTime ObtenerFecha(int day, int month, int year)
        {
            return new DateTime(year, month, day);
        }
        static DateTime ObtenerFecha(int day, int month)
        {
            return new DateTime(DateTime.Now.Year, month, day);
        }
        static DateTime ObtenerFecha(int day)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);
        }
    }
}
