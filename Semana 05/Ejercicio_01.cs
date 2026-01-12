using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class Semana05_Ejercicio01
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

            // Apartado para mostrar las asignaturas
            Console.WriteLine("Asignaturas del curso:\n");

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }
}
