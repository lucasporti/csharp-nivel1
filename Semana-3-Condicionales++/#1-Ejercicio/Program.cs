using System;

namespace _1_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n1, n2;
            int resultado = 0;

            Console.WriteLine("Ingresá el primer número");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresá el segundo número");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2)
                resultado = n1 - n2;
            if(n1 == n2)
                resultado = n1 + n2;
            if(n1 < n2)
                resultado = n1 * n2;
            
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
