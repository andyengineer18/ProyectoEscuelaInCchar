using CorEscuela.Entidades;
using CorEscuela.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;

namespace CorEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public List<Evaluaciones> evaluaciones { get; set; }
        public EscuelaEngine()
        {
           
        }
        public void Inicializar()
        {
            Escuela = new Escuela("Magister", 2022, TiposEscuela.PreEscolar,
                           "Peru", "Lima");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
            //ImprimirEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            List<Evaluaciones>evaluaciones = new List<Evaluaciones>();
            var listaCursos = Escuela.cursos;

            foreach (var curso in listaCursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        Random rnd = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            var nota = rnd.NextDouble()*(5.0)+(0.0);
                            var eva =new Evaluaciones
                            {
                                Alumno = alumno,
                                Asignatura = asignatura,
                                Nota = (float)nota
                            };
                            alumno.Evaluaciones.Add(eva);
                        }
                        
                    }
                }
            }
        }
        private void ImprimirEvaluaciones()
        {
            Printer.WriteTitle("EVALUACIONES: ");
            foreach (var eva in this.evaluaciones)
            {
                Console.WriteLine($"Alumno: {eva.Alumno.Nombre} Asignatura: {eva.Asignatura.Nombre} Nota: {eva.Nota}");
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre="Comunicacion"},
                    new Asignatura{Nombre="Matematica"},
                    new Asignatura{Nombre="Computacion"},
                    new Asignatura{Nombre="Ingles"},
                    new Asignatura{Nombre="R.Verbal"}

                };
                curso.Asignaturas = listaAsignaturas;   
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var ListaAlumnos = from n1 in nombre1
                         from n2 in nombre2
                         from a1 in apellido1
                         select new Alumno { Nombre = $"{n1}{n2}{a1}" };

            return ListaAlumnos.OrderBy((a)=>a.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.cursos = new List<Curso>()
            {
                new Curso{Nombre="101", Jornada=TiposJornada.Mañana },
                new Curso{Nombre="201", Jornada=TiposJornada.Tarde},
                new Curso{Nombre="301",Jornada=TiposJornada.Noche },
                new Curso{Nombre="401",Jornada=TiposJornada.Mañana},
                new Curso{Nombre="501",Jornada=TiposJornada.Mañana}
            };
            Random rnd = new Random();
            int cantRandom = rnd.Next(1,3);
            foreach (var curso in Escuela.cursos)
            {
                curso.Alumnos = GenerarAlumnosAlAzar(2);
            }
        }
    }
}
 