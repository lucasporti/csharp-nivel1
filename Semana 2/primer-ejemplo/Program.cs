using System;

namespace primer_ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLOQUE IF CONDICIONALES
            //
            //if(edad>18){
            //  Console.WriteLine("Sos mayor a 18");
            //}else{
            //  Console.WriteLine("Sos menor a 18");
            //}

            int edad = 18;

            if(edad>=18)
            if(edad>30)
            Console.WriteLine("Podes entrar al bar y tenes 30% OFF");
            else
            Console.WriteLine("Podes entrar al bar");
            else
            Console.WriteLine("No podes entrar al bar");


            //ACUMULADORES Y CONTADORES;
            int contador = 0, e1 = 40, e2 = 40, e3 = 25;
            int acumulador = 0, promedio;

            if(e1>18){
                contador++;
                acumulador+=e1;
            }
            if(e2>18){
                contador++;
                acumulador+=e2;
            }
            if(e3>18){
                contador++;
                acumulador+=e3;
            }
            promedio = acumulador/contador;

            Console.WriteLine("El promedio de edades es: " + promedio);
        }
    }
}
