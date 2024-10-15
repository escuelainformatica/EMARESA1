using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RectanguloDominio
    {
        public int alto;
        public int ancho;
        public int obtenerPerimetro()
        {
            return alto * 2 + ancho * 2;
        }
        public int obtenerArea()
        {
            return alto * ancho;
        }
        public double obtenerDiagonal()
        {
            return Math.Sqrt(alto * alto + ancho * ancho);
        }
    }
}
