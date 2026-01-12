using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class Semana05_Ejercicio03
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

            // Lista para almacenar las notas
            List<double> notas = new List<double>();

            Console.WriteLine("Ingreso de notas por asignatura:\n");

            // Apartado para pedir los datos al usuario
            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Ingrese la nota de {asignatura}: ");
                double nota = double.Parse(Console.ReadLine()!);
                notas.Add(nota);
            }

            Console.Clear();
            Console.WriteLine("Resultados:\n");

            // Muestra resultados
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
            }
        }
    }
}
