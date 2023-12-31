﻿using System;

namespace Ejercicio_4_resolución_maxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una 
            // comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y 
            // que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
            float totalFacturado, comision, sueldoFinal;
            const float sueldoFijo = 15000;
            const float porcentajeComision = 0.05F;

            Console.WriteLine("Ingrese el total facturado:");
            totalFacturado = float.Parse(Console.ReadLine());

            comision = totalFacturado * porcentajeComision;
            sueldoFinal = comision + sueldoFijo;

            Console.WriteLine("El sueldo total a pagar es: " + sueldoFinal);


        }
    }
}
