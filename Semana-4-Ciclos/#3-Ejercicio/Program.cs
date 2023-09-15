using System;

namespace _3_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int suma = 0, personas = 0;

            for(int x = 1; x < 21; x++){
                Console.WriteLine("Ingrese la edad " + x);
                int edad = int.Parse(Console.ReadLine());
                
                if(edad >= 18){
                    suma += edad;
                    personas++;
                }
            }
            int promedio = suma/personas;
            Console.WriteLine("El promedio de edad es: " + promedio);
        }
    }
}
