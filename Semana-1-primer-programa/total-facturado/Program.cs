using System;

namespace total_facturado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión 
            //del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total 
            //facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar 
            //por el mismo.
            int sueldo_fijo = 15000;
            Console.WriteLine("Ingresá tu total facturado");
            int total_facturado = int.Parse(Console.ReadLine());
            float sueldo_a_cobrar = (float)sueldo_fijo + (total_facturado*(float)0.05);
            Console.WriteLine("El sueldo total a cobrar es: " + sueldo_a_cobrar + " ARS");
        }
    }
}
