using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Estudiante : Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List <Libro> Libros { get; set; }

        public Estudiante(string nombre, string apellido, List <Libro> libros) : base(nombre, apellido)
        {
            Libros = libros;
        }

        public Estudiante(string nombre, string apellido) : base (nombre, apellido)
        {

        }

        public void agregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void quitarLibro(Libro libro)
        {
            Libros.Remove(libro);
        }

        public void leerLibroLista(Libro libro)
        {
            if (Libros.Contains(libro))
            {
                libro.wasRead = true;
            }
            else
            {
                Console.WriteLine("El alumno debe agregar el libro a su lista antes de leerlo");
            }
        }

        public string mostrarLibrosLeidos()
        {
            string listaLeidos = "";
            foreach(Libro libro in Libros)
            {
                if(libro.wasRead)
                {
                    listaLeidos += libro.nombre + "\n";
                }
            }
            return listaLeidos;
        }

        public int cantidadDePaginasLeidas()
        {
            int paginasLeidas = 0;
            foreach (Libro libro in Libros)
            {
                if (libro.wasRead)
                {
                    paginasLeidas += libro.cantidadDePaginas;
                }
            }

            return paginasLeidas;
        }

        public int librosSinLeer()
        {
            int contador = 0;
            foreach (Libro libro in Libros)
            {
                if (!libro.wasRead)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}
