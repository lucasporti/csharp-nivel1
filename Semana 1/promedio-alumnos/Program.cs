using System;

namespace promedio_alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            float promedio;
            Console.WriteLine("A continuación ingresá la 1er nota");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("A continuación ingresá la 2da nota");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A continuación ingresá la 3er nota");
            n3 = int.Parse(Console.ReadLine());
            promedio = (n1+n2+n3)/3;
            Console.WriteLine("El promedio de notas es: " + promedio);
        }
    }
}
