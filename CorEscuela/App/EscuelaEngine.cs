using CorEscuela.Entidades;
using System.Collections.Generic;

namespace CorEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
           
        }
        public void Inicializar()
        {
            Escuela = new Escuela("Magister", 2022, TiposEscuela.PreEscolar,
                           "Peru", "Lima");
            Escuela.cursos = new List<Curso>()
            {
                new Curso{Nombre="Comunicacion", Jornada=TiposJornada.Mañana },
                new Curso{Nombre="Computacion", Jornada=TiposJornada.Tarde},
                new Curso{Nombre="R.Verbal",Jornada=TiposJornada.Noche },
                new Curso{Nombre="Personal.S",Jornada=TiposJornada.Mañana},
                new Curso{Nombre="Arte",Jornada=TiposJornada.Mañana}
            };  
        }
    }
}
