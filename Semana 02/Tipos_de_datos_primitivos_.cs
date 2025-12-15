using System;

// Clase para representar un Círculo
public class Circulo
{
    // Atributo privado: almacena el radio del círculo
    private double radio;

    // Constructor: para crear un nuevo círculo con un radio dado
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Calculamos el área del círculo usando su fórmula: π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Calculamos el perímetro del círculo usando la fórmula: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para representar un Rectángulo
public class Rectangulo
{
    // Atributos privados que almacenan el alto y ancho del rectángulo
    private double alto;
    private double ancho;

    // Constructor: este permite crear un rectángulo con un alto y ancho específicos
    public Rectangulo(double alto, double ancho)
    {
        this.alto = alto;
        this.ancho = ancho;
    }

    // Se calcula el área del rectángulo
    public double CalcularArea()
    {
        return alto * ancho;
    }

    // Calculamos el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (alto + ancho);
    }
}

// Clase que ejecuta el ejemplo de las figuras geométricas
public class FigurasGeometricas
{
    public static void Ejecutar()
    {
        // Ejemplo 1: Círculo
        Console.WriteLine("=== CÍRCULO ===");
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        Console.WriteLine(); // Línea en blanco

        // Ejemplo 2: Rectángulo
        Console.WriteLine("=== RECTÁNGULO ===");
        Rectangulo r = new Rectangulo(4, 7);
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
