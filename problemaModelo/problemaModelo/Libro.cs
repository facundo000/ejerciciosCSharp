using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaModelo
{
    public class Libro
    {
        private string isbn, titulo, autor;
        private int paginas;

        public Libro(string isbn, string titulo, string autor, int paginas)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        public string pIsbn
        {
            get { return isbn; } 
            set { isbn = value; }
        }

        public string pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string pAutor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int pPaginas
        {
            get { return paginas; }
            set {  paginas = value; }
        }

        public string MostrarLibro()
        {
            string info = $"El libro {titulo} con isbn '{isbn}' creado por el autor '{autor}' tiene '{paginas}' páginas";
            string datos = $"\n Libro: {titulo} \n isbn: {isbn} \n Autor: {autor} \n Paginas: {paginas}";
            return info + datos;
        }
    }
}
