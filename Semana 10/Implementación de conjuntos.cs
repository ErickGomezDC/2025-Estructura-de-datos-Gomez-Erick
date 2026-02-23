using System;
using System.Collections.Generic;
using System.Linq;

namespace _2026_Estructura_de_datos_Gomez_Erick
{
    class ImplementacionDeConjuntos
    {
        public static void Ejecutar()
        {

            // 1. CREACIÓN DEL CONJUNTO UNIVERSAL DE CIUDADANOS

            // HashSet se usa porque representa matemáticamente un conjunto:
            // no permite duplicados y permite operaciones de teoría de conjuntos.
            HashSet<string> ciudadanos = new HashSet<string>();

            // Generamos 500 ciudadanos ficticios
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add("Ciudadano " + i);
            }

            // 2. CONJUNTO VACUNADOS PFIZER

            HashSet<string> pfizer = new HashSet<string>();

            // Se agregan 75 ciudadanos
            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add("Ciudadano " + i);
            }

            // 3. CONJUNTO VACUNADOS ASTRAZENECA
            
            HashSet<string> astra = new HashSet<string>();

            // Se agregan 75 ciudadanos (con rango superpuesto
            // para que existan ciudadanos con ambas dosis)
            for (int i = 51; i <= 125; i++)
            {
                astra.Add("Ciudadano " + i);
            }

            // OPERACIONES DE CONJUNTOS

            // INTERSECCIÓN → ciudadanos que están en ambos conjuntos
            HashSet<string> ambas = new HashSet<string>(pfizer);
            ambas.IntersectWith(astra);

            // DIFERENCIA → ciudadanos solo vacunados con Pfizer
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astra);

            // DIFERENCIA → ciudadanos solo vacunados con AstraZeneca
            HashSet<string> soloAstra = new HashSet<string>(astra);
            soloAstra.ExceptWith(pfizer);

            // UNIÓN → todos los ciudadanos vacunados con cualquier vacuna
            HashSet<string> vacunados = new HashSet<string>(pfizer);
            vacunados.UnionWith(astra);

            // COMPLEMENTO → ciudadanos que NO están vacunados
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // -------------------------------------------------
            // IMPRESIÓN DE RESULTADOS
            // -------------------------------------------------
            Mostrar("Ciudadanos NO vacunados", noVacunados);
            Mostrar("Ciudadanos con ambas dosis", ambas);
            Mostrar("Ciudadanos solo con Pfizer", soloPfizer);
            Mostrar("Ciudadanos solo con AstraZeneca", soloAstra);
        }

        // Método reutilizable para mostrar cualquier conjunto
        static void Mostrar(string titulo, HashSet<string> conjunto)
        {
            Console.WriteLine("\n--- " + titulo + " (" + conjunto.Count + ") ---");

            foreach (var ciudadano in conjunto)
                Console.WriteLine(ciudadano);
        }
    }
}