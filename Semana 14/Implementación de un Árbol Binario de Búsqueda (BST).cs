using System;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    public class NodoBST
    {
        public int Valor;
        public NodoBST Izquierdo;
        public NodoBST Derecho;

        public NodoBST(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }

    // Clase Árbol Binario de Búsqueda
    public class BST
    {
        private NodoBST raiz;

        // Insertar
        public void Insertar(int valor)
        {
            raiz = InsertarRec(raiz, valor);
        }

        private NodoBST InsertarRec(NodoBST nodo, int valor)
        {
            if (nodo == null)
                return new NodoBST(valor);

            if (valor < nodo.Valor)
                nodo.Izquierdo = InsertarRec(nodo.Izquierdo, valor);
            else if (valor > nodo.Valor)
                nodo.Derecho = InsertarRec(nodo.Derecho, valor);

            return nodo;
        }

        // Buscar
        public bool Buscar(int valor)
        {
            return BuscarRec(raiz, valor);
        }

        private bool BuscarRec(NodoBST nodo, int valor)
        {
            if (nodo == null)
                return false;

            if (valor == nodo.Valor)
                return true;

            if (valor < nodo.Valor)
                return BuscarRec(nodo.Izquierdo, valor);
            else
                return BuscarRec(nodo.Derecho, valor);
        }

        // Eliminar 
        public void Eliminar(int valor)
        {
            raiz = EliminarRec(raiz, valor);
        }

        private NodoBST EliminarRec(NodoBST nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Valor)
                nodo.Izquierdo = EliminarRec(nodo.Izquierdo, valor);
            else if (valor > nodo.Valor)
                nodo.Derecho = EliminarRec(nodo.Derecho, valor);
            else
            {
                // Caso 1 y 2
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                // Caso 3 (dos hijos)
                nodo.Valor = Minimo(nodo.Derecho);
                nodo.Derecho = EliminarRec(nodo.Derecho, nodo.Valor);
            }

            return nodo;
        }

        // Recorridos 
        public void Inorden()
        {
            InordenRec(raiz);
            Console.WriteLine();
        }

        private void InordenRec(NodoBST nodo)
        {
            if (nodo != null)
            {
                InordenRec(nodo.Izquierdo);
                Console.Write(nodo.Valor + " ");
                InordenRec(nodo.Derecho);
            }
        }

        public void Preorden()
        {
            PreordenRec(raiz);
            Console.WriteLine();
        }

        private void PreordenRec(NodoBST nodo)
        {
            if (nodo != null)
            {
                Console.Write(nodo.Valor + " ");
                PreordenRec(nodo.Izquierdo);
                PreordenRec(nodo.Derecho);
            }
        }

        public void Postorden()
        {
            PostordenRec(raiz);
            Console.WriteLine();
        }

        private void PostordenRec(NodoBST nodo)
        {
            if (nodo != null)
            {
                PostordenRec(nodo.Izquierdo);
                PostordenRec(nodo.Derecho);
                Console.Write(nodo.Valor + " ");
            }
        }

        // Mínimo 
        public int Minimo()
        {
            return Minimo(raiz);
        }

        private int Minimo(NodoBST nodo)
        {
            while (nodo.Izquierdo != null)
                nodo = nodo.Izquierdo;

            return nodo.Valor;
        }

        // Máximo 
        public int Maximo()
        {
            NodoBST nodo = raiz;
            while (nodo.Derecho != null)
                nodo = nodo.Derecho;

            return nodo.Valor;
        }

        // Altura del árbol
        public int Altura()
        {
            return AlturaRec(raiz);
        }

        private int AlturaRec(NodoBST nodo)
        {
            if (nodo == null) return -1;
            return 1 + Math.Max(AlturaRec(nodo.Izquierdo), AlturaRec(nodo.Derecho));
        }

        // Limpiar el árbol
        public void Limpiar()
        {
            raiz = null;
        }
    }

    // Menú para interactuar con el BST
    public static class BST_Menu
    {
        public static void Ejecutar()
        {
            BST arbol = new BST();
            int opcion, valor;

            do
            {
                Console.WriteLine("\n=== ÁRBOL BINARIO DE BÚSQUEDA ===");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Recorrido Inorden");
                Console.WriteLine("5. Recorrido Preorden");
                Console.WriteLine("6. Recorrido Postorden");
                Console.WriteLine("7. Mínimo y Máximo");
                Console.WriteLine("8. Altura");
                Console.WriteLine("9. Limpiar árbol");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Valor: ");
                        valor = int.Parse(Console.ReadLine());
                        arbol.Insertar(valor);
                        break;

                    case 2:
                        Console.Write("Valor a buscar: ");
                        valor = int.Parse(Console.ReadLine());
                        Console.WriteLine(arbol.Buscar(valor) ? "Encontrado" : "No encontrado");
                        break;

                    case 3:
                        Console.Write("Valor a eliminar: ");
                        valor = int.Parse(Console.ReadLine());
                        arbol.Eliminar(valor);
                        break;

                    case 4:
                        arbol.Inorden();
                        break;

                    case 5:
                        arbol.Preorden();
                        break;

                    case 6:
                        arbol.Postorden();
                        break;

                    case 7:
                        Console.WriteLine("Mínimo: " + arbol.Minimo());
                        Console.WriteLine("Máximo: " + arbol.Maximo());
                        break;

                    case 8:
                        Console.WriteLine("Altura: " + arbol.Altura());
                        break;

                    case 9:
                        arbol.Limpiar();
                        Console.WriteLine("Árbol limpiado");
                        break;
                }

            } while (opcion != 0);
        }
    }
}