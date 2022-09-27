using System;
using System.Linq.Expressions;
using CorEscuela.Entidades;

namespace CorEscuela
{   
    
    internal class Program 
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Nazareno", 2000, TiposEscuela.Secundaria,
                    pais: "Mexico", ciudad: "SJm"
                ) ;
            var arregloCursos = new Curso[3]
            {
                new Curso(){Nombre = "101",},
                new Curso() { Nombre = "201" },
                new Curso{Nombre = "301"}
            };
            arregloCursos = new Curso[]
            {
                new Curso(){Nombre = "101",},
                new Curso() { Nombre = "201" },
                new Curso{Nombre = "301"}
            };
            Curso[] arregloCursos2 = 
            {
                new Curso(){Nombre = "101",},
                new Curso() { Nombre = "201" },
                new Curso{Nombre = "301"}
            };
            escuela.cursos = arregloCursos;

            Console.WriteLine(escuela);
            Console.WriteLine("===============");
            ImprimirCursos(arregloCursos);

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            foreach(var curso in arregloCursos)
            {
                Console.WriteLine($"NOMBRE: {curso.Nombre}, ID: {curso.UniqueId}");
                
            }
        }
    }
}
