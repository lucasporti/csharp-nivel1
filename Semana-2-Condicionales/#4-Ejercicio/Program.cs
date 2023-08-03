using System;

namespace _4_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar cuatro números distintos 
            // y luego mostrar por pantalla el menor de ellos.
            
            int n1,n2,n3,n4,menor;
            Console.WriteLine("Ingresá el primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el segundo número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el tercer número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresá el cuarto número");
            n4 = int.Parse(Console.ReadLine());
            if(n1<n2)
                menor=n1;
            else
                menor=n2;
            
            if(n3<menor)
                menor = n3;
            
            if(n4<menor)
                menor=n4;

            Console.WriteLine("El número menor es: " + menor);
        }
    }
}
