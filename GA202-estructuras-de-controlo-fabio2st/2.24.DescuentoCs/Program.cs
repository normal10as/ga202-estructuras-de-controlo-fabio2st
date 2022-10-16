using System;

static class Program
{
    public static void Main(string[] args)
    {
        decimal totalDescuento = 0, total = 0;
        Process(ref totalDescuento, ref total);
        OutputTotal(totalDescuento, total);
    }
    private static void Process(ref decimal totalDescuento, ref decimal totalMonto)
    {
        Int16 cantidad;
        decimal precio, descuentoPorcentaje, subtotal, montoDescontado, totalArticulo;
        cantidad = LeerCantidad();
        while (cantidad != 0)
        {
            precio = LeerPrecio();
            subtotal = cantidad * precio;
            descuentoPorcentaje = CalcularPorcentajeDescuento(cantidad);
            montoDescontado = subtotal * descuentoPorcentaje / 100;
            totalArticulo = subtotal - montoDescontado;
            OutputDetalle(descuentoPorcentaje, subtotal, montoDescontado, totalArticulo);
            totalDescuento += montoDescontado;
            totalMonto += totalArticulo;
            cantidad = LeerCantidad();
        }
    }
    private static short LeerCantidad()
    {
        short cantidad;
        Console.Write("Cantidad : ");
        cantidad = Convert.ToInt16( Console.ReadLine());
        return cantidad;
    }
    private static decimal LeerPrecio()
    {
        decimal monto;
        Console.Write("Precio: ");
        monto = Convert.ToDecimal( Console.ReadLine());
        return monto;
    }
    private static decimal CalcularPorcentajeDescuento(short cantidad)
    {
        switch (cantidad)
        {
            case short _ when 10 <= cantidad && cantidad <= 50:
                return 5;
            case short _ when 51 <= cantidad && cantidad <= 250:
                return 10;
            case short _ when cantidad >= 251:
                return 20;
            default:
                return 0;
        }
    }
    private static void OutputDetalle(decimal descuentoPorcentaje, decimal subtotal, decimal montoDescontado, decimal totalArticulo)
    {
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine($"Descuento {descuentoPorcentaje}%: $-{montoDescontado}");
        Console.WriteLine("Total: " + totalArticulo);
    }
    private static void OutputTotal(decimal totalDescuento, decimal total)
    {
        Console.WriteLine("Total descuentos: " + totalDescuento);
        Console.WriteLine("Total a cobrar:   " + total);
    }
}