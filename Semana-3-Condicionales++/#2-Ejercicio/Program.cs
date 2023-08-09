using System;

namespace _2_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros 
            // vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            
            // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos 
            // y calcule y emita el importe con el descuento

            float importeTotal, cantidadLitros, importeFinal = 0;

            Console.WriteLine("Ingresá el importe total de la venta");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá la cantidad total de litros vendidos");
            cantidadLitros = float.Parse(Console.ReadLine());

            if(cantidadLitros < 100)
                importeFinal = importeTotal;

            if(cantidadLitros > 100 && cantidadLitros < 300)
                importeFinal = (importeTotal * 0.90F);

            if(cantidadLitros > 300 && cantidadLitros < 500)
                importeFinal = importeTotal * 0.85F;

            if(cantidadLitros > 500)
                importeFinal = importeTotal * 0.75F;

            Console.WriteLine("El importe final a pagar es: " + importeFinal);
        }
    }
}
