using System;
using System.Collections.Generic;
using System.Linq;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    // Clase pública estática que contiene toda la lógica del traductor
    public static class TraductorBasico
    {
        // Método principal que será llamado desde Program.cs
        public static void Ejecutar()
        {
            // Diccionario que almacena palabras en español y su traducción al inglés
            // Se usa StringComparer.OrdinalIgnoreCase para evitar problemas con mayúsculas/minúsculas
            Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"tiempo", "time"},
                {"persona", "person"},
                {"año", "year"},
                {"camino", "way"},
                {"día", "day"},
                {"cosa", "thing"},
                {"hombre", "man"},
                {"mundo", "world"},
                {"vida", "life"},
                {"mano", "hand"},
                {"parte", "part"},
                {"niño", "child"},
                {"ojo", "eye"},
                {"mujer", "woman"},
                {"lugar", "place"},
                {"trabajo", "work"},
                {"semana", "week"},
                {"caso", "case"},
                {"punto", "point"},
                {"gobierno", "government"},
                {"empresa", "company"}
            };

            int opcion;

            // Ciclo que mantiene activo el menú hasta que el usuario elija salir
            do
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        TraducirFrase(diccionario);
                        break;

                    case 2:
                        AgregarPalabra(diccionario);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del traductor...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
        }

        // Método que recibe una frase y traduce únicamente
        // las palabras que existen en el diccionario
        private static void TraducirFrase(Dictionary<string, string> diccionario)
        {
            Console.Write("\nIngrese una frase: ");
            string frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');
            List<string> traduccion = new List<string>();

            foreach (string palabra in palabras)
            {
                string palabraLimpia = palabra
                    .ToLower()
                    .Replace(".", "")
                    .Replace(",", "")
                    .Replace(";", "")
                    .Replace(":", "");

                if (diccionario.ContainsKey(palabraLimpia))
                {
                    traduccion.Add(diccionario[palabraLimpia]);
                }
                else
                {
                    traduccion.Add(palabra);
                }
            }

            Console.WriteLine("\nTraducción:");
            Console.WriteLine(string.Join(" ", traduccion));
        }

        // Método corregido: ahora agrega palabras en Español -> Inglés
        private static void AgregarPalabra(Dictionary<string, string> diccionario)
        {
            Console.Write("\nIngrese la palabra en español: ");
            string espanol = Console.ReadLine().ToLower();

            Console.Write("Ingrese la traducción en inglés: ");
            string ingles = Console.ReadLine().ToLower();

            if (!diccionario.ContainsKey(espanol))
            {
                diccionario.Add(espanol, ingles);
                Console.WriteLine("Palabra agregada correctamente.");
            }
            else
            {
                Console.WriteLine("Esa palabra ya existe en el diccionario.");
            }
        }
    }
}