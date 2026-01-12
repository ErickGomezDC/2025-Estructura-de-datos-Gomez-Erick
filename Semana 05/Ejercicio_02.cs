using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class Semana05_Ejercicio02
    {
        public static void Ejecutar()
        {
            // Lista de asignaturas
            List<string> asignaturas = new List<string>()
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };

            // Mensaje por cada asignatura
            Console.WriteLine("Asignaturas de estudio:\n");

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}
