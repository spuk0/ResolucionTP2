using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Cuadrado
    {
        public double lado { get; private set; }

        public Cuadrado(double p_lado) {
            lado = p_lado;
        }

        public double area()
        {
            return lado * lado;
        }

        public void mostrarDatos()
        {
            Console.WriteLine($"Es un cuadrado donde cada lado mide {lado}cm y su area es de {this.area()} centimetros cuadrados");
        }
    }
}
