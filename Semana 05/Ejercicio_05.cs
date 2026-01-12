using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class Semana05_Ejercicio05
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int>();

            // Almacenar números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            // Invertir el orden de la lista
            numeros.Reverse();

            Console.WriteLine("Números del 1 al 10 en orden inverso:\n");

            // Mostrar separados por comas
            for (int i = 0; i < numeros.Count; i++)
            {
                if (i < numeros.Count - 1)
                    Console.Write(numeros[i] + ", ");
                else
                    Console.Write(numeros[i]);
            }
        }
    }
}
