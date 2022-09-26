using System;
using CorEscuela.Entidades;

namespace CorEscuela
{   
    
    internal class Program 
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Magister","VMT");
            escuela.Pais = "Peru";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);

        }
    }
}
