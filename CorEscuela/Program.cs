using System;
using System.Linq.Expressions;
using CorEscuela.Entidades;

namespace CorEscuela
{   
    
    internal class Program 
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Magister","VMT");
            var escuela2 = new Escuela("Nazareno", 2000, TiposEscuela.Secundaria,
                    pais: "Mexico", ciudad: "SJm"
                ) ;
            Console.WriteLine(escuela);
            Console.WriteLine(escuela2);

        }
    }
}
