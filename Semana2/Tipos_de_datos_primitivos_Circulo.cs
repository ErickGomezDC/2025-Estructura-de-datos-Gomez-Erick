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
