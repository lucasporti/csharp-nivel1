using System;

namespace _3_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra 
            // realizada según los siguientes valores:

            // Si el importe es menor a ARS 1000, no hay descuento.
            // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            // Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            float importe, descuento, precioFinal;
            Console.WriteLine("Ingrese el importe de la compra");
            importe = float.Parse(Console.ReadLine());
            if(importe>5000)
                descuento = 0.18F;
            else if(importe>1000)
                descuento = 0.10F;
            else
                descuento = 0;
            
            precioFinal = importe - (importe*descuento);
            Console.WriteLine("El precio final a pagar es: " + precioFinal);
        }
    }
}
