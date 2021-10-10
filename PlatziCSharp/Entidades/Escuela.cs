using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziCSharp.Entidades
{
    class Escuela
    {
        string nombre;
        
        public string Nombre
        {
            get { return "copia: " + nombre;}
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion { get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string TipoEscuela { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

    }
}
