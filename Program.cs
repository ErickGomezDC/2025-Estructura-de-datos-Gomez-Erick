using System;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("Aqui se encontraran los codigos de cada semana correspondiente eliga que semana quiere ejecutar:");
                Console.WriteLine("1. Semana 02: Figuras Geometricas (datos primitivos)");
                Console.WriteLine("2. Semana 03: Registro de Estudiantes (Arrays y Matrices)");
                Console.WriteLine("3. Semana 04: Proxima tarea...");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        FigurasGeometricas.Ejecutar();
                        break;

                    case 2:
                        RegistroEstudiante.Ejecutar();
                        break;
                    

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
