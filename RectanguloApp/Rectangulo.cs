using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanguloApp
{
    internal class Rectangulo
    {
        private double ancho;
        private double alto;

        public double pAncho
        { 
            get { return ancho; } 
            set { ancho = value; } 
        }
        public double pAlto
        { 
            get { return alto; }
            set { alto= value; }
        }
        public double calcularPerimetro()
        {
            double perimetro = 0;
            perimetro = 2 * ancho + 2 * alto;
            return perimetro;
        }
        public double calcularSuperficie()
        {
            return ancho * alto;
        }
        public Rectangulo()
        {
            this.ancho = this.alto = 0.0;
        }
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }   
    }
}
