using System;

namespace _5_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar cuatro números 
            // y luego mostrar por pantalla cuáles son mayores a 100.

            int n1,n2,n3,n4;
            string mayor = "Los números mayores a 100 son:";
            
            Console.WriteLine("Ingresá el primer número");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresá el segundo número");
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresá el tercer número");
            n3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresá el cuarto número");
            n4 = int.Parse(Console.ReadLine());

            if(n1>100)
                mayor += " " + n1;
            
            if(n2>100)
                mayor += " " + n2;

            if(n3>100)
                mayor += " " + n3;

            if(n4>100)
                mayor += " " + n4;

            Console.WriteLine(mayor);
        }
    }
}
