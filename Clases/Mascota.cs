using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Mascota
    {
        public int energia { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string tamanio { get; set; }

        public Mascota (int energia, string nombre, string tipo, string tamanio)
        {
            this.energia = energia;
            this.nombre = nombre;
            this.tipo = tipo;
            this.tamanio = tamanio;
        }

        public Mascota (string nombre, string tipo, string tamanio) 
        { 
            this.nombre = nombre; 
            this.tipo= tipo;
            this.energia = 100;
            this.tamanio = tamanio;
        }

        private int porcentajeDeEnergia(int porcentaje)
        {
            return (energia * porcentaje) / 100;
        }

        public void alimentar(int alimento)
        {
            energia += (int)(alimento * porcentajeDeEnergia(30));
        }

        public void correr()
        {
            if(energia > porcentajeDeEnergia(20))
            {
                energia = energia - porcentajeDeEnergia(10);
            }else
            {
                Console.WriteLine("No puede correr, tiene poca energia");
            }
        }

        public void mostrarDatos()
        {
            Console.WriteLine($"Nombre : {nombre} Especie: {tipo} Energia: {energia}");
        }
    }
}
