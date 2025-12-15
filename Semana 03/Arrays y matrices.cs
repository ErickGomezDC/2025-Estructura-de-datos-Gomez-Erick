using System;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    // Clase que permite registrar y mostrar los datos de un estudiante
    public class RegistroEstudiante
    {
        // Método principal que ejecuta el proceso de registro
        public static void Ejecutar()
        {
            // Declaración de variables para los datos del estudiante
            int id;
            string nombres;
            string apellidos;
            string direccion;

            // Array para almacenar tres números de teléfono
            string[] telefonos = new string[3];

            Console.WriteLine("=== REGISTRO DE ESTUDIANTE ===");

            // Ingreso del ID del estudiante
            Console.Write("Ingrese el ID del estudiante: ");
            id = int.Parse(Console.ReadLine()!);

            // Ingreso de los nombres del estudiante
            Console.Write("Ingrese los nombres del estudiante: ");
            nombres = Console.ReadLine()!;

            // Ingreso de los apellidos del estudiante
            Console.Write("Ingrese los apellidos del estudiante: ");
            apellidos = Console.ReadLine()!;

            // Ingreso de la dirección del estudiante
            Console.Write("Ingrese la dirección del estudiante: ");
            direccion = Console.ReadLine()!;

            // Ingreso de los números de teléfono usando un ciclo
            Console.WriteLine("Ingrese los números de teléfono:");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write("Teléfono " + (i + 1) + ": ");
                telefonos[i] = Console.ReadLine()!;
            }

            // Mostrar los datos registrados del estudiante
            Console.WriteLine("\n=== DATOS DEL ESTUDIANTE REGISTRADO ===");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Dirección: " + direccion);

            // Mostrar los teléfonos almacenados en el array
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine("- " + telefonos[i]);
            }
        }
    }
}
