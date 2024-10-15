using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LibroSrv
    {
        public void MostrarLibro(Libro libro)
        {
            Console.WriteLine("\x1b[31mHello World\x1b[0m");
            Console.WriteLine($"\x1b[01mTitulo     :\x1b[22m{libro.Titulo}");
            Console.WriteLine($"\u001b[01mAutor      :\u001b[22m{libro.Autor}");
            Console.WriteLine($"\u001b[01mPrecio     :\u001b[22m{libro.precio}");
            Console.WriteLine($"\u001b[01mNumPaginas :\u001b[22m{libro.numPaginas}");

            Console.WriteLine("");
            Console.WriteLine($"Titulo:{libro.Titulo}, autor:{libro.Autor}, precio:${libro.precio}, num:{libro.numPaginas}");

            //var linea=Console.ReadLine();
        }
        public Libro CrearLibro()
        {
            Libro libro = new Libro();
            Console.Write("Ingrese titulo : ");
            libro.Titulo = Console.ReadLine();
            Console.Write("Ingrese autor : ");
            libro.Autor = Console.ReadLine();
            return libro;
        }
    }
}
