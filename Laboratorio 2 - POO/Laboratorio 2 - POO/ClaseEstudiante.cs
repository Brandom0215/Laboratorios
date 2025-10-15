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
        private string nombre {  get; set; }
        private string id { get; set; }
        private string carrera { get; set; }
        //private List<Calificacion> calficaciones;

        //Cosntructor 
        public ClaseEstudiante(string nombre, string id, string carrera)
        { 
        
        }

        public ClaseEstudiante()
        {
            nombre = "Juan";
            id = "2";
            carrera = "Licenciatura en software";
        }
        
        //Metodo de calcular promedio
        public double CalcularPromedio(float nota)
        {
            return 0; 
        }

    }
}
