using System;

namespace _1_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int n, primos = 0, flag = 0;

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                
                for(int i = 1; i <= n; i++){
                    if(n%i == 0)
                        flag++;
                }
                
                if(flag == 2)
                        primos++;

                flag = 0;
            }
            Console.WriteLine("En el programa se ingresaron: " + primos + " numeros primos.");
        }
    }
}
