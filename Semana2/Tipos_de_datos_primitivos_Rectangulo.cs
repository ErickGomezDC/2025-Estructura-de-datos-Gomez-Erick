// Clase para representar un Rectángulo
public class Rectangulo
{
    // Atributos privados que almacenan el alto y ancho del rectangulo
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
