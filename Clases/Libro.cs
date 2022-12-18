using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Libro
    {
        public string nombre { get; set; }
        public string autor { get; set; }
        public int cantidadDePaginas { get; set; }
        public bool wasRead { get; set; }

        public Libro (string nombre, string autor, int cantidadDePaginas, bool wasRead)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.cantidadDePaginas = cantidadDePaginas;
            this.wasRead = wasRead;
        }


    }
}
