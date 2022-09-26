using System;

namespace CorEscuela
{   
    class escuela
    {
        string nombre;
        salon[] salones;
        public escuela(string nombre, salon[] salones)
        {
            this.nombre = nombre;
            this.salones = salones;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void mostrarSalones()
        {
            Console.WriteLine("SALONES: ");
            for (int i = 0; i < salones.Length; i++)
            {
                Console.WriteLine($"SALON {i + 1}");
                alumno[] alumnos = salones[i].GetAlumnos();
                Console.WriteLine("ALUMNOS:\n");
                for (int j = 0; j < alumnos.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {alumnos[j].getNombre()}");
                    Console.WriteLine("ASIGNATURAS: ");
                    calificacion[] asignaturas = alumnos[j].GetAsignaturas();
                    for (int y = 0; y < asignaturas.Length; y++)
                    {
                        Console.WriteLine($"{y + 1}.{asignaturas[y].getNota()} - NOTA: {asignaturas[y].getNota()}");
                    }
                }
            }
        }
    }
    class salon
    {
        int grado;
        alumno[] alumnos;
        public salon(int grado, alumno[] alumnos)
        {
            this.grado = grado;
            this.alumnos = alumnos;
        }

        public alumno[] GetAlumnos()
        {
            return this.alumnos;
        }
    }
    class alumno
    {
        string nombre;
        calificacion[] asignaturas;

        public alumno(string nombre, calificacion[] asignaturas)
        {
            this.nombre = nombre;
            this.asignaturas = asignaturas;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public calificacion[] GetAsignaturas()
        {
            return this.asignaturas;
        }
    }
    class calificacion 
    {
        asignatura asignatura;
        double nota;
        public calificacion(string nombre, double nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public double getNota()
        {
            return this.nota;
        }
    }
    class asignatura
    {
        string nombre;
        
        public asignatura()
        {

        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            
        }
    }
}
