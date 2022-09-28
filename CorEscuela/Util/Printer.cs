using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam=10)
        {
            var linea = "".PadLeft(tam, '=');
            Console.WriteLine(linea);
        }
        public static void WriteTitle(string titulo)
        {
            DibujarLinea(titulo.Length+4);
            WriteLine($"| {titulo} |");
            DibujarLinea(titulo.Length+4);

        }
        public static void Beep(int hz=2000, int tiempo=500, int cantidad=1)
        {
            for (int i = 0; i < cantidad; i++)
            {
                System.Console.Beep(hz, tiempo);
            }
            
        } 
    }
}
