using System;

namespace kilometros_entre_ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            int km,velocidad,tiempo;
            Console.WriteLine("Ingresá los kilometros a recorrer");
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá la velocidad promedio");
            velocidad = int.Parse(Console.ReadLine());
            tiempo = km/velocidad;
            Console.WriteLine("Te demandará un total de " + tiempo + " hora/s llegar");
        }
    }
}
