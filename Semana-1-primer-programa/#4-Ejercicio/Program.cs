using System;

namespace facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una 
            // comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y 
            // que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
            int sueldo, totalFacturado;
            sueldo = 15000;
            Console.WriteLine("Porfavor, ingresá tu total facturado");
            totalFacturado = int.Parse(Console.ReadLine());
            double sueldoTotal = (totalFacturado * 0.05) + sueldo;
            Console.WriteLine("Tu sueldo es de $" + sueldoTotal);
        }
    }
}
