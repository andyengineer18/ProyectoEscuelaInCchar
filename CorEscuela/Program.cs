using System;
using System.Linq.Expressions;
using CorEscuela.Entidades;
using static System.Console;
namespace CorEscuela
{   
    
    internal class Program 
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Nazareno", 2000, TiposEscuela.Secundaria,
                    pais: "Mexico", ciudad: "SJm"
                ) ;

            escuela.cursos = new Curso[]
            {
                new Curso(){Nombre = "101",},
                new Curso() { Nombre = "201" },
                new Curso{Nombre = "301"}
            };

            ImprimirCursosEscuela(escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {   
            WriteLine("===============");
            WriteLine("Cursos de la Escuela");
            WriteLine("===============");

            if (escuela.cursos != null && escuela!=null) // es igual escuela?.cursos !=null
            {
                foreach (var curso in escuela.cursos)
                {
                    WriteLine($"NOMBRE: {curso.Nombre}, ID: {curso.UniqueId}");
                }
            }
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            foreach(var curso in arregloCursos)
            {
                WriteLine($"NOMBRE: {curso.Nombre}, ID: {curso.UniqueId}");
                
            }
        }
    }
}
