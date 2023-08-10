using System;

namespace _5_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los 
            // mismos se encuentran ordenados de forma decreciente .

            int n1, n2, n3, n4;

            Console.WriteLine("Ingresá el primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el segundo número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el tercer número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el cuarto número"); 
            n4 = int.Parse(Console.ReadLine());

            if((n1 > n2) && (n2 > n3) && (n3 > n4))
                Console.WriteLine("Estan ordenados de forma decreciente");
        }
    }
}
