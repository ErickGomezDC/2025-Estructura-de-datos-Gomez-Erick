using System;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    // Clase Nodo: representa cada elemento de la lista enlazada
    class Nodo
    {
        // Dato que almacena el nodo
        public int Dato;

        // Referencia al siguiente nodo de la lista
        public Nodo Siguiente;

        // Constructor del nodo
        public Nodo(int dato)
        {
            Dato = dato;          // Se asigna el valor recibido al nodo
            Siguiente = null;     // Al crearse, el nodo no apunta a ningún otro
        }
    }

    // Clase ListaEnlazada: administra la lista de nodos
    class ListaEnlazada
    {
        // Referencia al primer nodo de la lista
        private Nodo cabeza;

        // Método para insertar un nuevo elemento al final de la lista
        public void Insertar(int dato)
        {
            // Se crea un nuevo nodo con el dato recibido
            Nodo nuevo = new Nodo(dato);

            // Si la lista está vacía, el nuevo nodo será la cabeza
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                // Se recorre la lista hasta llegar al último nodo
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;

                // El último nodo apunta al nuevo nodo
                actual.Siguiente = nuevo;
            }
        }

        // Método que cuenta cuántos elementos tiene la lista
        public int Contar()
        {
            int contador = 0;          // Variable para contar los nodos
            Nodo actual = cabeza;      // Se empieza desde la cabeza

            // Se recorre la lista nodo por nodo
            while (actual != null)
            {
                contador++;            // Se incrementa el contador por cada nodo
                actual = actual.Siguiente; // Se avanza al siguiente nodo
            }

            // Se devuelve la cantidad total de elementos
            return contador;
        }

        // Método para mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo actual = cabeza;

            // Se recorre la lista y se imprime cada dato
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }

            // Indica el final de la lista
            Console.WriteLine("null");
        }
    }

    // Clase principal del ejercicio
    class Semana06_Ejercicio01
    {
        // Método de prueba del ejercicio
        public static void Ejecutar()
        {
            // Se crea una nueva lista enlazada
            ListaEnlazada lista = new ListaEnlazada();

            // Se insertan varios elementos en la lista
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);
            lista.Insertar(40);

            // Se muestra la lista completa
            Console.WriteLine("Lista:");
            lista.Mostrar();

            // Se muestra la cantidad de elementos de la lista
            Console.WriteLine("Cantidad de elementos: " + lista.Contar());
        }
    }
}
