using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2___POO
{
    class ClaseEstudiante
    {
        private string nombre; 
        public string Nombre
        {
            get => nombre;
            set => nombre = value ?? throw new ArgumentException("Nombre no puede ser nulo");
        }
        private string id; 
        public string Id
        {
            get => id;
            set => value.Trim();
        }
        private string carrera; 
        public string Carrera
        {
            get => carrera; 
            set => set => carrera = value ?? throw new ArgumentException("Carrera no puede ser nula");
        }

        //private List<Calificacion> calficaciones;

        //Cosntructor 
        public ClaseEstudiante(string nombre, string id, string carrera)
        {
            nombre = nombre;
            id = id;
            carrera = carrera; 
        
        }

        public ClaseEstudiante()
        {
            nombre = "Juan";
            id = "2";
            carrera = "Licenciatura en software";
        }

        //Metodo de calcular promedio
        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
                return 0;

            double sumaPonderada = 0;
            int sumaCreditos = 0;

            foreach (var c in Calificaciones)
            {
                sumaPonderada += c.Nota * c.Materia.Creditos;
                sumaCreditos += c.Materia.Creditos;
            }

            return sumaCreditos == 0 ? 0 : sumaPonderada / sumaCreditos;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Estudiante: {Nombre} | ID: {Id} | Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
            Console.WriteLine("------------------------------------------");
        }

    }
}
