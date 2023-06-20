using System;

namespace facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo, totalFacturado;
            sueldo = 15000;
            Console.WriteLine("Porfavor, ingresá tu total facturado");
            totalFacturado = int.Parse(Console.ReadLine());
            double sueldoTotal = (totalFacturado * 0.05) + sueldo;
            Console.WriteLine("Tu sueldo es de $" + sueldoTotal);
        }
    }
}
