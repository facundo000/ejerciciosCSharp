using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Biblioteca
    {
        private Libro[] estante; // arreglo de libros
        private string nombre;
        private int siguiente;

        public Biblioteca(int cantidad, string nombre)
        {
            estante = new Libro[cantidad];
            this.nombre = nombre;
            siguiente = 0;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /*
        public bool RegistrarLibro(Libro oLibro)
        {
            bool resultado = false;
            for (int i = 0; i < estante.Length; i++)
            {
                if (estante[i] == null)
                {
                    estante[i] = oLibro;
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }
        */


        public bool RegistrarLibro(Libro oLibro)
        {
            bool resultado = false;
            if (siguiente < estante.Length)
            {
                estante[siguiente] = oLibro;//acceso directo
                siguiente++;
                resultado = true;
            }
            return resultado;
        }

        /*
         Permite consultar los datos completos de un libro de la biblioteca
         */
        public Libro ConsultarLibroPorAutor(int isbn)
        {
            foreach (Libro item in estante)
            {
                if(item.pIsbn == isbn)
                {
                    return item;
                }
            }
            return null;
        }

        /*
         * Permite generar un listado con los libros de la biblioteca solo
         * para aquellos cuyo autor es una mujer...
         */
        public string ListarLibroDeMujeres()
        {

        }

    }
}
