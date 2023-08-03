using System;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometros,velocidad,tiempo;

            Console.WriteLine("Ingresá la distancia en km:");
            kilometros = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá la velocidad promedio:");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = kilometros/velocidad;

            Console.WriteLine("El tiempo será de " + tiempo.ToString("0.00") + " horas..");
        }
    }
}
