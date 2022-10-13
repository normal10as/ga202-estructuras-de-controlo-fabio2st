// See https://aka.ms/new-console-template for more information
DateNow();
TimeSpan dateNow = TimeNow();
Console.WriteLine("Hora: " + dateNow.ToString(@"hh\:mm"));

static void DateNow()
{
    Console.WriteLine("Fecha: " + DateTime.Now.Date.ToShortDateString());
}
static TimeSpan TimeNow()
{
    return DateTime.Now.TimeOfDay;
}