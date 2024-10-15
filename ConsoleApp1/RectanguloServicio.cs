using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RectanguloServicio
    {
        public int obtenerPerimetro(Rectangulo rect)
        {
            return rect.alto * 2 + rect.ancho * 2;
        }
        public int obtenerArea(Rectangulo rect)
        {
            return rect.alto * rect.ancho;
        }
        public double obtenerDiagonal(Rectangulo rect)
        {
            return Math.Sqrt(rect.alto * rect.alto + rect.ancho * rect.ancho);
        }
    }
}
