public class Punto
{
    private double coordX;
    private double coordY;

    public double proppCoordenadaX
    {
        set { coordX = value; }
        get { return coordX; }

    }

    public double proppCoordenadaY
    {
        set { coordY = value; }
        get { return coordY; }

    }

    public double CalcularDistancia()
    {
        double distancia = 0;
        distancia = Math.Sqrt((coordX * coordX) + (coordY * coordY));

        return distancia;
    }

    public string PuntoEnElPlano()
    {
        return "El punto en el plano es: " + "(" + coordX + "," + coordY + ")";
    }

    public Punto(double coordX, double coordY)
    {
        this.coordX = coordX;
        this.coordY = coordY;
    }
}

class Program
{
    static void Main(string[] args)
    {
        

        double x0, y0;
        Console.WriteLine("Ingrese un valor para la coordenada X:");
        x0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese un valor para la coordenada Y:");
        y0 = Convert.ToDouble(Console.ReadLine());
        //punto.proppCoordenadaX = x0;
        //punto.proppCoordenadaY = y0;
        
        Punto punto = new Punto(x0, y0);

        Console.WriteLine(punto.PuntoEnElPlano());
        Console.WriteLine("La distancia es:");
        Console.WriteLine(punto.CalcularDistancia());

    }
}