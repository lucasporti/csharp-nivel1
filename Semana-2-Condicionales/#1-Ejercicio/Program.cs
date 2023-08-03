using System;

namespace _1_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita por pantalla un cartel 
            //aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            
            Console.WriteLine("Ingrese un número");
            
            int numero = int.Parse(Console.ReadLine());
            const int mayor=10;

            if(numero>mayor)
                Console.WriteLine("Es mayor a " + mayor);
            else
                Console.WriteLine("No es mayor a " + mayor);
            
        }
    }
}
