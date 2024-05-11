namespace problemaModelo
{
    static class Program
    {
        static void Main()
        {
            Libro libro1, libro2;
            libro1 = new Libro( "222.33.4", "Este es el titulo", "Estes es el autor", 50);
            libro2 = new Libro("333.002.5", "Juan Segundo Sombra", "Octavio", 300);

                            

            Console.WriteLine(libro1.MostrarLibro());
            Console.WriteLine(libro2.MostrarLibro());

            if (libro1.pPaginas > libro2.pPaginas){
                Console.WriteLine($"\nlibro '{libro1.pTitulo}' tiene mas páginas");
            }
            else if (libro1.pPaginas < libro2.pPaginas){
                Console.WriteLine($"\nlibro {libro2.pTitulo} tiene mas páginas");
            }

            else{
                Console.WriteLine($"\nLos libros tienen las mismas cantidad de páginas");
            }

            Biblioteca oBlioteca = new Biblioteca(2);
            oBlioteca.MostrarLibro(libro1);
            oBlioteca.MostrarLibro(libro2);
            //Console.WriteLine("Ingrese el tamaño de la estantería: ");


        }
    }
}