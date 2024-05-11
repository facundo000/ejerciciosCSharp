using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaModelo
{
	public class Biblioteca
	{
		private Libro[] estanteria;
		private int contador;

		public Biblioteca(int tamanio)
		{
			estanteria = new Libro[tamanio];
			contador = 0;
		}

        public bool AgregarLibro(Libro unLibro)
		{
			if (contador < estanteria.Length)
			{
				estanteria[contador] = unLibro;
				contador++;

				return true;
			}
		}

    }
}
