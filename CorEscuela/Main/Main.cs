using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CorEscuela.Entidades;
using static System.Console;
using CorEscuela.App;
using CorEscuela.Util;

namespace CorEscuela.Main
{
    class Central
    {
         static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarLinea(20);
            WriteLine("Cursos de la escuela:");
            Printer.DibujarLinea(20);
            if (escuela !=null && escuela.cursos!=null)
            {
                foreach (Curso curso in escuela.cursos)
                {
                    WriteLine($"NOMBRE: {curso.Nombre}, ID: {curso.UniqueId}");
                }
            }
        }
    }
}
