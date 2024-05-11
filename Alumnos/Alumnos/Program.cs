//Alumnos.Dados el nombre, legajo, DNI, teléfono y tres notas de alumnos,
//calcular su promedio y mostrar todos sus datos.

class Persona
{
    protected string Nombre;
    protected int Legajo;
    protected int Dni;
    protected int Telefono;

    public Persona(string nombre, int legajo, int dni, int telefono)
    {
        Nombre = nombre;
        Legajo = legajo;
        Dni = dni;
        Telefono = telefono;
    }

}
class Alumno : Persona
{
    double[] NotasAlumnos = new double[3];

    public Alumno(string nombre, int legajo, int dni, int telefono, double[] notasAlumnos) : base(nombre, legajo, dni, telefono)
    {
        NotasAlumnos = notasAlumnos;
    }
    public double CargarNotas()
    {
        double promedio = 0;
        double sumarNota = 0;

        for (int i = 0; i < NotasAlumnos.Length; i++)
        {
            sumarNota += NotasAlumnos[i];
        }
        promedio = sumarNota / NotasAlumnos.Length;
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Legajo: " + Legajo);
        Console.WriteLine("Dni: " + Dni);
        Console.WriteLine("Teléfono: " + Telefono);
        return promedio;
    }
}

public class Program
{
    public static void Main()
    {
        double[] notasAlumnos = { 6, 7, 8 };
        Alumno alumno = new Alumno("Facundo", 0022, 22554666, 35469768, notasAlumnos);
        alumno.CargarNotas();
    }
}
