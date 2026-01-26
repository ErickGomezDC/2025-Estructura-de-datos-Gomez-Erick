using System;
using System.Collections.Generic;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    public class Semana07_Pilas
    {
        public static void Ejecutar()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== SEMANA 07: PILAS (STACKS) ===");
                Console.WriteLine("1. Verificar paréntesis balanceados");
                Console.WriteLine("2. Torres de Hanoi con pilas");
                Console.WriteLine("0. Volver");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        VerificarBalance();
                        break;

                    case 2:
                        TorresDeHanoi();
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        
        // 1) verificación de paréntesis balanceados
    
        static void VerificarBalance()
        {
            Console.WriteLine("Ingrese una expresión matemática:");
            string expresion = Console.ReadLine()!;

            Stack<char> pila = new Stack<char>();
            bool balanceado = true;

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0)
                    {
                        balanceado = false;
                        break;
                    }

                    char ultimo = pila.Pop();

                    if (!EsPar(ultimo, c))
                    {
                        balanceado = false;
                        break;
                    }
                }
            }

            if (pila.Count != 0)
                balanceado = false;

            Console.WriteLine(balanceado
                ? "Fórmula balanceada."
                : "Fórmula NO balanceada.");
        }

        static bool EsPar(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }

       
        // 2) Torres de Hanoi
        
        static void TorresDeHanoi()
        {
            Console.Write("Ingrese número de discos: ");
            int n = int.Parse(Console.ReadLine()!);

            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            for (int i = n; i >= 1; i--)
                origen.Push(i);

            ResolverHanoi(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
        }

        static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                                  string nombreOrigen, string nombreDestino, string nombreAux)
        {
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
                return;
            }

            ResolverHanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAux, nombreDestino);

            int d = origen.Pop();
            destino.Push(d);
            Console.WriteLine($"Mover disco {d} de {nombreOrigen} a {nombreDestino}");

            ResolverHanoi(n - 1, auxiliar, destino, origen, nombreAux, nombreDestino, nombreOrigen);
        }
    }
}
