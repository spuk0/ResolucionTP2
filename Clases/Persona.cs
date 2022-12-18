using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Persona
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public int fechaNacimiento { get; private set; }
        public Smartphone celular { get; private set; }

        public Mascota Mascota;

        public DateTime thisDate = DateTime.Today; //Obtiene la fecha de hoy.

        public Persona (string p_nombre, string p_apellido, int fechaNacimiento, Smartphone celular)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.celular = celular;
        }

        public Persona (string p_nombre, string p_apellido)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.fechaNacimiento = 0;
        }

        public Persona(string p_nombre, string p_apellido, int fechaNacimiento)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.fechaNacimiento = fechaNacimiento;
        }

        private string nombreYApellido()
        {
            return $"{nombre} {apellido}";
        }

        public int calcularEdad()
        {
            return GetDateOfBirth() - this.fechaNacimiento;
        }

        public int GetDateOfBirth()
        {
            return thisDate.Year;
        }

        public void setMascota(Mascota mascota){ Mascota= mascota; }

        public Mascota getMascota() { return Mascota; }

        public void mostrarDatos()
        {
            Console.WriteLine(this.nombreYApellido() + "\nEdad: " + this.calcularEdad());
        }
    }
}
