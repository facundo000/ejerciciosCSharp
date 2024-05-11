using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto p;            // variable p = null
            p = new Punto();    // objeto p

            double xx, yy;
            xx = Convert.ToDouble( Console.ReadLine());
            yy = Convert.ToDouble( Console.ReadLine());

            p.pCoordenadaX = xx;
            p.pCoordenadaY = yy;

            Console.WriteLine(p.mostrarPunto());
            Console.WriteLine(p.calcularDistanciaEje());

            Punto p1 = new Punto(2.5, 9.7);
            Console.WriteLine(p1.mostrarPunto());
            Console.WriteLine(p1.calcularDistanciaEje());

            Console.Read();
        }
    }
  /*  class Punto
    {

    }
  */
}
