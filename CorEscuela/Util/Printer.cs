using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam=10)
        {
            var linea = "".PadLeft(tam, '=');
            Console.WriteLine(linea);
        }
    }
}
