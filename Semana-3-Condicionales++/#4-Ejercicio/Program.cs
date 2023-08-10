using System;

namespace _4_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si 
            // la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int n1,n2,n3;
            Console.WriteLine("Ingresá el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el tercer número: ");
            n3 = int.Parse(Console.ReadLine());

            if((n1+n2) > (n2*n3))
                Console.WriteLine("La suma del primer y segundo número es mayor al producto del segundo y tercer número");
        }
    }
}
