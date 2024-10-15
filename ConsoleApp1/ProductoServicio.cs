using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductoServicio
    {
        public void mostrar(Producto prod)
        {
            Console.WriteLine(prod.nombre);
            Console.WriteLine(prod.precio);
            Console.WriteLine(prod.envase);
        }
    }
}
