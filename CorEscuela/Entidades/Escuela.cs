using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        //public Curso[] cursos { get; set; }
        public List<Curso> cursos { get; set;  }
        
        public Escuela(String nombre, string ciudad) => (Nombre, Ciudad) = (nombre, ciudad);
        public Escuela(string nombre, int añoDeCreacion, TiposEscuela tipoEscuela,
                        string pais = "", string ciudad="") //colocar "" significa que es opcional
                         
        {
            (Nombre, Ciudad) = (nombre, ciudad);
            AñoDeCreacion = añoDeCreacion;
            Pais = pais;
            TipoEscuela = tipoEscuela;
        }

        public override string ToString()
        {
            //  esto -> \"  se utiliza para colocar en el texto comillas
            return $"Nombre: \"{Nombre}\", AñoCreacion: {AñoDeCreacion}, Tipo: {TipoEscuela}," +
                    $" \nPais: {Pais}, Ciudad: {Ciudad}";

        }
    }
}
