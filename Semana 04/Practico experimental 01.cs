using System;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    // ============================
    // CLASE CONTACTO
    // Aquí se guardan los datos de los usuarios
    // ============================
    class Contacto
    {
        // Datos básicos del contacto
        public string nombre;
        public string telefono;
        public string correo;
    }

    // ============================
    // CLASE AGENDA TELEFONICA
    // Aquí se manejan las operaciones de la agenda
    // ============================
    class AgendaTelefonica
    {
        // Método principal que será llamado desde Program.cs
        public static void Ejecutar()
        {
            // Vector (arreglo) para guardar los contactos
           
            Contacto[] agenda = new Contacto[10];

            // Variable para saber cuántos contactos hay guardados
            int cantidad = 0;

            // Variable para el menú
            int opcion = 0;

            // Ciclo para que el menú se repita
            do
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFÓNICA ===");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Reporte en matriz");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine()!);
                Console.Clear();

                // ============================
                // OPCIÓN 1: AGREGAR CONTACTO
                // ============================
                if (opcion == 1)
                {
                    // Se valida que todavía haya espacio en el arreglo
                    if (cantidad < agenda.Length)
                    {
                        // Se crea un nuevo contacto
                        Contacto nuevo = new Contacto();

                        // Se piden los datos al usuario
                        Console.Write("Ingrese el nombre: ");
                        nuevo.nombre = Console.ReadLine()!;

                        Console.Write("Ingrese el teléfono: ");
                        nuevo.telefono = Console.ReadLine()!;

                        Console.Write("Ingrese el correo: ");
                        nuevo.correo = Console.ReadLine()!;

                        // Se guarda el contacto en el arreglo
                        agenda[cantidad] = nuevo;
                        cantidad++;

                        Console.WriteLine("\nContacto agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("La agenda está llena, no se pueden agregar más contactos.");
                    }
                }

                // ============================
                // OPCIÓN 2: MOSTRAR CONTACTOS
                // ============================
                else if (opcion == 2)
                {
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay contactos registrados.");
                    }
                    else
                    {
                        Console.WriteLine("LISTA DE CONTACTOS:\n");

                        // Se recorren los contactos guardados
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(
                                (i + 1) + ". " +
                                agenda[i].nombre + " - " +
                                agenda[i].telefono + " - " +
                                agenda[i].correo
                            );
                        }
                    }
                }

                // ============================
                // OPCIÓN 3: BUSCAR CONTACTO
                // ============================
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine()!;
                    bool encontrado = false;

                    // Búsqueda secuencial en el arreglo
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (agenda[i].nombre.ToLower() == buscar.ToLower())
                        {
                            Console.WriteLine("\nContacto encontrado:");
                            Console.WriteLine("Nombre: " + agenda[i].nombre);
                            Console.WriteLine("Teléfono: " + agenda[i].telefono);
                            Console.WriteLine("Correo: " + agenda[i].correo);

                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Contacto no encontrado.");
                    }
                }

                // ============================
                // OPCIÓN 4: REPORTE EN MATRIZ
                // ============================
                else if (opcion == 4)
                {
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay datos para generar el reporte.");
                    }
                    else
                    {
                        // Se crea una matriz para organizar los datos
                        string[,] reporte = new string[cantidad, 3];

                        // Se llena la matriz con los datos del arreglo
                        for (int i = 0; i < cantidad; i++)
                        {
                            reporte[i, 0] = agenda[i].nombre;
                            reporte[i, 1] = agenda[i].telefono;
                            reporte[i, 2] = agenda[i].correo;
                        }

                        // Se muestran los datos de la matriz
                        Console.WriteLine("REPORTE DE CONTACTOS:\n");
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(
                                "Nombre: " + reporte[i, 0] +
                                " | Teléfono: " + reporte[i, 1] +
                                " | Correo: " + reporte[i, 2]
                            );
                        }
                    }
                }

                // ============================
                // OPCIÓN 0: SALIR
                // ============================
                else if (opcion == 0)
                {
                    Console.WriteLine("Regresando al menú principal...");
                }

                // ============================
                // OPCIÓN INCORRECTA
                // ============================
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                // Pausa antes de volver al menú
                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
