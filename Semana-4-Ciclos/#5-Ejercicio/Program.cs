using System;

namespace _5_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números y luego emitir por 
            // pantalla el máximo de los números pares y el mínimo de los números impares.
            
            int mayor = 0, menor = 0;
            for(int x = 0; x < 20; x++){
                Console.WriteLine("Ingresá un número");
                int n = int.Parse(Console.ReadLine());
                if(x == 0){
                    mayor = n;
                    menor = n;
                }
                if(n%2 == 0 && n>mayor){
                    mayor = n;
                }
                else if (n < menor){
                    menor = n;
                }
            }
            Console.WriteLine("Máximo de los mayores: " + mayor);
            Console.WriteLine("Mínimo de los menores: " + menor);
        }
    }
}
