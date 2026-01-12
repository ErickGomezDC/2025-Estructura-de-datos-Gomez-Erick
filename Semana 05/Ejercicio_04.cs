using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class Semana05_Ejercicio04
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int>();
            int cantidad = 6; // Cantidad típica de números en la lotería primitiva

            Console.WriteLine("Ingreso de números ganadores de la lotería:\n");

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número ganador #{i}: ");
                int numero = int.Parse(Console.ReadLine()!);
                numeros.Add(numero);
            }

            // Ordenar la lista de menor a mayor
            numeros.Sort();

            Console.Clear();
            Console.WriteLine("Números ganadores ordenados de menor a mayor:\n");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
