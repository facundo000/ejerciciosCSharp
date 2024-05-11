using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanguloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Rectangulo!!!");
            
            Rectangulo r;
            r = new Rectangulo();

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Rectangulo r1 = new Rectangulo(x, y);

            r.pAncho = 3;
            r.pAlto = 5;

            Console.WriteLine("El perimetro de r es: " + r.calcularPerimetro());
            Console.WriteLine("La superficie de r es: " + r.calcularSuperficie());
            
            Console.WriteLine("El perimetro de r1 es: " + r1.calcularPerimetro());
            Console.WriteLine("La superficie de r1 es: " + r1.calcularSuperficie());


            Console.Read();

        }
    }

}
