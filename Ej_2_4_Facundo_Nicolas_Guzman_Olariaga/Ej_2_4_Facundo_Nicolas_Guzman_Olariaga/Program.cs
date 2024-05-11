class Persona
{
    private string nombre;
    private int edad;
    private string sexo;
    private int peso;
    private int altura;

    public Persona(string nombre, int edad, string sexo, int peso, int altura)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public int calcularIMC()
    {
        int alturaEnMetro = altura / 100;
        int pesoIdeal = peso / (alturaEnMetro * alturaEnMetro);

        if (pesoIdeal < 20)
        {
            return -1;
        }
        if (pesoIdeal >= 20 && pesoIdeal <= 25)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public bool esMayorDeEdad()
    {
        if(edad > 21)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("ingrese nombre");
        string nombre = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese su edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su sexo");
        string sexo = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingrese su peso (en entero)");
        int peso = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su altura (en cm)");
        int altura = Convert.ToInt32(Console.ReadLine());

        Persona persona = new Persona(nombre, edad, sexo, peso, altura);

        int IMC = persona.calcularIMC();
        bool esMayor = persona.esMayorDeEdad();

        Console.WriteLine("nombre: " + nombre);
        Console.WriteLine("edad: " + edad);
        Console.WriteLine("sexo: " + sexo);
        Console.WriteLine("peso: " + peso);
        Console.WriteLine("altura: " + altura);

        Console.WriteLine("si IMC es -1 = peso ideal, 1 = sobrepeso , 0 = delgado:");
        Console.WriteLine("IMC: " + IMC);

        Console.WriteLine("Es mayor: " + esMayor);

    }
}