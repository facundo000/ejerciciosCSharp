using System;

class Silo
{
    private double algo;
    private double otra;
    public Silo(double algo, double otra)
    {
        this.algo = algo;
        this.otra = otra;
    }
    public double calcularRadio()
    {
        double radio = 0;
        return radio;
    }
    public double calcularAltura()
    {
        double altura = 0;
        return altura;
    }
}

class Program
{
    static void Main()
    {
        Silo silo = new Silo(2, 3);

        double radio = silo.calcularRadio();
        Console.WriteLine("El radio del silo es: ",radio);
        double altura = silo.calcularAltura();
        Console.WriteLine("La altura del silo es: ", altura);
    }
}