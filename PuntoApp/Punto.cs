using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoApp
{
    public class Punto
    {
        private double coordenadaX;
        private double coordenadaY;

        public double pCoordenadaX
        {
            set { coordenadaX = value; }
            get { return coordenadaX; }
        }
        public double pCoordenadaY
        {
            set { coordenadaY = value; }
            get { return coordenadaY; }
        }
        public double calcularDistanciaEje()
        {
            double distancia = 0;
            distancia= Math.Sqrt((coordenadaX*coordenadaX)+(coordenadaY*coordenadaY));
            return distancia;
        }
        public string mostrarPunto()
        {
            return "El punto existe en el plano x,y --> (" + coordenadaX + ";" + coordenadaY + ")";
        }
        public Punto()
        {
            coordenadaX = coordenadaY = 0.0;
        }
        public Punto(double coordenadaX, double coordenadaY)
        {
            this.coordenadaX = coordenadaX;
            this.coordenadaY = coordenadaY;
        }
        public Punto(double coordenada)
        {
            this.coordenadaX = coordenada;
            this.coordenadaY = coordenada;
        }
    }
}
