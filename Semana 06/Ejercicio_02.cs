using System;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    // Clase ListaEnlazadaInversa: representa una lista enlazada simple
    class ListaEnlazadaInversa
    {
        // Referencia al primer nodo de la lista
        private Nodo cabeza;

        // Método para insertar un nuevo elemento al final de la lista
        public void Insertar(int dato)
        {
            // Se crea un nuevo nodo con el valor recibido
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

        // Método que invierte el orden de los elementos de la lista enlazada
        public void Invertir()
        {
            Nodo anterior = null;    // Nodo que irá quedando detrás del actual
            Nodo actual = cabeza;    // Se empieza desde el primer nodo
            Nodo siguiente;          // Nodo auxiliar para no perder la referencia

            // Se recorre la lista mientras existan nodos
            while (actual != null)
            {
                // Se guarda la referencia al siguiente nodo
                siguiente = actual.Siguiente;

                // Se invierte el enlace del nodo actual
                actual.Siguiente = anterior;

                // Se avanza un nodo hacia adelante
                anterior = actual;
                actual = siguiente;
            }

            // Al finalizar, el último nodo recorrido pasa a ser la nueva cabeza
            cabeza = anterior;
        }

        // Método para mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo actual = cabeza;

            // Se recorren los nodos y se imprime su contenido
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }

            // Indica el final de la lista
            Console.WriteLine("null");
        }
    }

    // Clase principal del segundo ejercicio
    class Semana06_Ejercicio02
    {
        // Método de prueba del ejercicio
        public static void Ejecutar()
        {
            // Se crea una nueva lista enlazada
            ListaEnlazadaInversa lista = new ListaEnlazadaInversa();

            // Se insertan varios elementos en la lista
            lista.Insertar(1);
            lista.Insertar(2);
            lista.Insertar(3);
            lista.Insertar(4);
            lista.Insertar(5);

            // Se muestra la lista antes de invertirla
            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Se invierte el orden de la lista
            lista.Invertir();

            // Se muestra la lista después de invertirla
            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}
