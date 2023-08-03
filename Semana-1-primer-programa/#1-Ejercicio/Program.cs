using System;

namespace calcular_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2, resultado;
            Console.WriteLine("Porfavor, ingresá el primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor, ingresá el segundo número");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1+n2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
