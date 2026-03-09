using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    public static class Practico_experimental_03
    {
        public static void Ejecutar()
        {
            // Mapa: ID del libro -> Título
            Dictionary<int, string> libros = new Dictionary<int, string>();

            // Conjunto: para evitar títulos repetidos
            HashSet<string> titulos = new HashSet<string>();

            int opcion;

            do
            {
                Console.WriteLine("\n=== REGISTRO DE LIBROS EN BIBLIOTECA ===");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Mostrar libros");
                Console.WriteLine("3. Buscar libro por ID");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese ID del libro: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese título del libro: ");
                        string titulo = Console.ReadLine();

                        if (titulos.Contains(titulo))
                        {
                            Console.WriteLine("Ese libro ya está registrado.");
                        }
                        else
                        {
                            libros[id] = titulo;
                            titulos.Add(titulo);
                            Console.WriteLine("Libro registrado correctamente.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nLista de libros:");
                        foreach (var libro in libros)
                        {
                            Console.WriteLine("ID: " + libro.Key + " - Título: " + libro.Value);
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese ID a buscar: ");
                        int buscarId = int.Parse(Console.ReadLine());

                        if (libros.ContainsKey(buscarId))
                        {
                            Console.WriteLine("Libro encontrado: " + libros[buscarId]);
                        }
                        else
                        {
                            Console.WriteLine("Libro no encontrado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
