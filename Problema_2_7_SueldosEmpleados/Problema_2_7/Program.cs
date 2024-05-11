// Capturar en una lista los sueldos de 5 empleados y desplegarlos en una
//segunda lista aumentados en un 30%. 

class SueldosEmpleados
{
    private double[] sueldos;

    public SueldosEmpleados()
    {
        sueldos = new double[5];
    }

    public void CapturarSueldos()
    {
        for(int i = 0; i < sueldos.Length; i++)
        {
            sueldos[i] = double.Parse(Console.ReadLine());
        }
    }

    public double[] ObtenerSueldosOriginales()
    {
        return sueldos;
    }

    public double[] SueldosAumentados()
    {
        double[] sueldosAumentados = new double[sueldos.Length];
        for(int i = 0;i < sueldos.Length; i++)
        {
            sueldosAumentados[i] = sueldos[i] * 1.3;
        }

        return sueldosAumentados;
    }
}
static class Program
{
    static void Main()
    {
        SueldosEmpleados sueldosEmpleados = new SueldosEmpleados();

        Console.WriteLine("Ingrese los sueldos de los 5 empleados: ");
        sueldosEmpleados.CapturarSueldos();

        double[] sueldosOriginales = sueldosEmpleados.ObtenerSueldosOriginales();
        double[] sueldosAumentados = sueldosEmpleados.SueldosAumentados();

        Console.WriteLine("\nSueldos originales: ");
        for(int i = 0; i< sueldosOriginales.Length; i++)
        {
            Console.WriteLine($"Empleado {i + 1}: {sueldosOriginales[i]}");
        }

        Console.WriteLine("\nSueldos aumentados un 30%: ");
        for (int i = 0; i < sueldosAumentados.Length; i++)
        {
            Console.WriteLine($"Empleado {i + 1}: {sueldosAumentados[i]}");
        }
    }
}