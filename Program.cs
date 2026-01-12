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
                Console.WriteLine("3. Semana 04: Practico Experimental 01 (Agenda Telefónica)");
                Console.WriteLine("4. Semana 05: Listas Enlazadas (5Ejercicios)");
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

                    case 3:
                        AgendaTelefonica.Ejecutar();
                        break;

                    case 4:
                        MenuSemana05();
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

        static void MenuSemana05()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== SEMANA 05: LISTAS ===");
                Console.WriteLine("1. Ejercicio 1: Lista de asignaturas");
                Console.WriteLine("2. Ejercicio 2: Yo estudio <asignatura>");
                Console.WriteLine("3. Ejercicio 3: Asignaturas y notas");
                Console.WriteLine("4. Ejercicio 4: Lotería ordenada");
                Console.WriteLine("5. Ejercicio 5: Lista inversa");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Semana05_Ejercicio01.Ejecutar();
                        break;

                    case 2:
                        Semana05_Ejercicio02.Ejecutar();
                        break;

                    case 3:
                        Semana05_Ejercicio03.Ejecutar();
                        break;

                    case 4:
                        Semana05_Ejercicio04.Ejecutar();
                        break;

                    case 5:
                        Semana05_Ejercicio05.Ejecutar();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
