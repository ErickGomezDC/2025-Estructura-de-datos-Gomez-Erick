using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo de radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        Console.WriteLine(); // Línea en blanco

        // Crear un rectángulo de alto 4 y ancho 7
        Rectangulo r = new Rectangulo(4, 7);
        Console.WriteLine("=== RECTÁNGULO ===");
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
