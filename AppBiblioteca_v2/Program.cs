using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro l1, l2;
            Autor a1, a2;

            a1 = new Autor();
            a1.pAlias = "Messi";
            a1.pNombre = "Lionel";
            a1.pDocumento = 123456;
            a1.pSexo = true;
            
            l1= new Libro();
            l1.pIsbn = 1234;
            l1.pTitulo = "La Biblia";
            l1.pAutor = a1;
            l1.pPaginas = 500;

            a2 = new Autor("Bonelli", "Juana", 987654, false);

            l2 = new Libro(5678, "Harry", a2, 600);

            Console.WriteLine(l1.MostrarLibro());
            Console.WriteLine(l2.MostrarLibro());

            //Libro que tiene mas páginas...
            if (l1.pPaginas > l2.pPaginas)
                Console.WriteLine("El libro " + l1.pTitulo + " es el mayor");
            else
                Console.WriteLine("El libro " + l2.pTitulo + " es el mayor");

            //Libro con autor mujer...
            if (!l1.pAutor.pSexo)  //==false
                Console.WriteLine(l1.pAutor.pDocumento);
            if (!l2.pAutor.pSexo)  //==false
                Console.WriteLine(l2.pAutor.pDocumento);

            //otra versión...
            if(l1.TieneAutorMujer())
                Console.WriteLine(l1.pAutor.pDocumento);

            //Crear una biblioteca:
            Biblioteca oBiblioteca = new Biblioteca(100, "Biblioteca TEST");
            if (oBiblioteca.RegistrarLibro(l2))
                Console.WriteLine("Libro registrado!!!");

            if (oBiblioteca.RegistrarLibro(l1))
                Console.WriteLine("Libro registrado!!!");

            int libroBuscado = Convert.ToInt32(Console.ReadLine());

            Libro buscado = oBiblioteca.ConsultarLibroPorAutor(libroBuscado);
            if(buscado == null)
                Console.WriteLine("Libro NO encontrado!!!");
            else
                Console.WriteLine(buscado.MostrarLibro());

            Console.Read();
        }
    }
}
