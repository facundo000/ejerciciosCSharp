using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Libro
    {
        private int isbn;
        private string titulo;
        private Autor autor;    //relacion 1 a 1 de Libro tiene un Autor
        private int paginas;
        
        public int pIsbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public Autor pAutor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int pPaginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public string MostrarLibro()
        {
            return "Libro con ISBN: " + isbn + " creado por: " +
                autor.MostrarAutor() + " tiene " + paginas + " páginas";
        }
        public Libro()
        {
            isbn = paginas = 0;
            titulo = string.Empty;
            autor = null; // relacion de 0 a 1
        }
        public Libro(int isbn, string titulo, Autor autor, int paginas)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }   
        public bool TieneAutorMujer()
        {
            bool aux = false;
            if (!autor.pSexo)
                aux= true;
            return aux;
        }
    }
}
