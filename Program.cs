using System;

class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

class Rectangulo
{
    private double largo;
    private double ancho;

    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    public double CalcularArea()
    {
        return largo * ancho;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("CÍRCULO");
        Console.WriteLine("Área: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

        Console.WriteLine("\n------------------\n");

        Rectangulo miRectangulo = new Rectangulo(8, 4);
        Console.WriteLine("RECTÁNGULO");
        Console.WriteLine("Área: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());

        Console.ReadKey();
    }
}

