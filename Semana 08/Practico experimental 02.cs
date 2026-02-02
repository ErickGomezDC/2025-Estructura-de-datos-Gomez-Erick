using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class PracticoExperimental02
    {
        public static void Ejecutar()
        {
            Queue<string> cola = new Queue<string>();
            int capacidad = 30;
            int contador = 1;

            Console.WriteLine("=== ASIGNACIÓN DE 30 ASIENTOS (ORDEN DE LLEGADA) ===\n");

            // Simulación de llegada de personas
            while (cola.Count < capacidad)
            {
                string persona = "Persona " + contador;
                cola.Enqueue(persona);
                Console.WriteLine(persona + " entra a la fila.");
                contador++;
            }

            Console.WriteLine("\nTodos los asientos han sido vendidos.\n");
            Console.WriteLine("Personas subiendo a la atracción:\n");

            // Asignación de asientos en orden de llegada
            int asiento = 1;
            while (cola.Count > 0)
            {
                string persona = cola.Dequeue();
                Console.WriteLine(persona + " ocupa el asiento #" + asiento);
                asiento++;
            }

            Console.WriteLine("\nAtracción completa. Proceso finalizado.");
        }
    }
}
