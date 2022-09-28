using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CorEscuela.Entidades;
using CorEscuela.Util;
using static System.Console;
namespace CorEscuela
{   
    
    internal class Program 
    {
        static void Prueba()
        {
            var escuela = new Escuela("Nazareno", 2000, TiposEscuela.Secundaria,
                    pais: "Mexico", ciudad: "SJm"
                ) ;
            escuela.cursos= new List<Curso>()
            {
                new Curso { Nombre="101"},
                new Curso { Nombre="201"},
                new Curso { Nombre="301"}
            };
            escuela.cursos.Add(new Curso { Nombre = "401",
                                          Jornada = TiposJornada.Mañana});
        
            escuela.cursos.Add(new Curso { Nombre = "501",
                                          Jornada = TiposJornada.Tarde });

            var cursos = new List<Curso>()
            {
                new Curso {Nombre="601", Jornada=TiposJornada.Mañana },
                new Curso{Nombre="701",Jornada=TiposJornada.Tarde}
            };
            //añade un lista dentro de una lista
            escuela.cursos.AddRange(cursos);

            var cursos2 = new Curso[]
            {
                new Curso{Nombre="Prueba",Jornada=TiposJornada.Mañana},
                new Curso{Nombre="Prueba2", Jornada=TiposJornada.Mañana}
            };
            escuela.cursos.AddRange(cursos2);

           //escuela.cursos = new Curso[]
           //{
           //    new Curso(){Nombre = "101",},
           //    new Curso() { Nombre = "201" },
           //    new Curso{Nombre = "301"}
           //};

            ImprimirCursosEscuela(escuela);
            var ElimCurso = escuela.cursos[3];
            escuela.cursos.Remove  (ElimCurso);
            ImprimirCursosEscuela(escuela);

            //Remover 101
            escuela.cursos.RemoveAll(match);
            ImprimirCursosEscuela(escuela);
            //RemoveAll 2DA FORMA
            escuela.cursos.RemoveAll(delegate(Curso cur)
            {
                return cur.Nombre == "501" && cur.Jornada==TiposJornada.Tarde;
            });
            //RemoveAll 3ra Forma
            escuela.cursos.RemoveAll((Curso cu) => cu.Nombre == "601");

            ImprimirCursosEscuela(escuela);
        }

        private static bool match(Curso obj)
        {
            return obj.Nombre == "201";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela:");

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
