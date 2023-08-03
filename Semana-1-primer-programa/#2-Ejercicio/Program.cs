using System;

namespace elevar_al_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,elevado;
            Console.WriteLine("Ingresá el número que séra elevado al cubo");
            n = int.Parse(Console.ReadLine());
            elevado = n*n*n;
            Console.WriteLine("El número elevado al cubo es: " + elevado);
        }
    }
}
