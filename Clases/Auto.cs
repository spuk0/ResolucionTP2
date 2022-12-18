using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Auto
    {
        public int modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public string estado { get; set; }
        public int velocidad { get; set; }
        public Persona Conductor;
        public int capacidad { get; set; }
        public Persona[] Pasajeros { get; set; }

        public Auto(int modelo, string marca, string color, int capacidad, Persona conductor) 
        {
            this.modelo = modelo;
            this.marca= marca;
            this.color = color;
            this.capacidad = capacidad;
            this.estado = "apagado";
            this.velocidad = 0;
            this.setConductor(conductor);
            Pasajeros = new Persona[capacidad];
            this.agregarPasajero(Conductor);
            
        }
        public Auto(int modelo, string marca, string color)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
            this.capacidad = 2;
            this.estado = "apagado";
            this.velocidad = 1;
            this.setConductor(null);
            Pasajeros = new Persona[4];
        }

        private void setConductor(Persona conductor)
        {
            if (conductor.calcularEdad() >= 18)
            {
                Conductor = conductor;
            }
            else
            {
                Conductor = null;
                Console.WriteLine("Menor de edad");
            }
        }


        public Persona getConductor()
        {
            return Conductor;
        }

        private bool hayLugar()
        {
            bool valor = false;
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                if (Pasajeros[i] == null)
                {
                    valor = true;
                    break;
                }
            }
            return valor;
        }

        public void agregarPasajero(Persona persona)
        {
            if (hayLugar())
            {
                for (int i = 0; i < Pasajeros.Length; i++)
                {
                    if (Pasajeros[i] == null)
                    {
                        Pasajeros[i] = persona;
                        Console.WriteLine($"Se agrego con exito a {Pasajeros[i].apellido}");
                        break;
                    }
                }
            }else
            {
                Console.WriteLine($"No hay lugar en el vehiculo para {persona.apellido}");
            } 
        }

        public void agregarMascota(Mascota mascota)
        {
            if(hayLugar() && mascota.tamanio == "grande" || mascota.tamanio == "mediano")
            {
                agregarPasajero(new Persona (mascota.nombre, mascota.tipo));
            }
            else if(mascota.tamanio == "pequeño")
            {
                foreach(Persona pasajero in Pasajeros)
                {
                    if(pasajero != Conductor)
                    {
                        pasajero.setMascota(mascota);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay lugar para la mascota");
            }
        }

        public void conQuienEstaMascota(Mascota mascota)
        {
            foreach (Persona pasajero in Pasajeros)
            {
                if(pasajero.getMascota() == mascota)
                {
                    Console.WriteLine($"La mascota esta con {pasajero.apellido}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nadie tiene a la mascota");
                }
            }
        }



        public void Encender()
        {
            if (this.getConductor() != null)
            {
                estado = "encendido";
            }else
            {
                Console.WriteLine("No hay conductor que pueda encender vehiculo");
            }
            
        }

        public void Apagar()
        {
            if (Conductor != null)
            {
                estado = "apagado";
            }
            else
            {
                Console.WriteLine("No hay conductor que pueda apagar vehiculo");
            }
        }


        public void Acelerar()
        {
            if(estado == "encendido")
            {
                velocidad += 10;
            }
            else
            {
                Console.WriteLine("El auto esta apagado");
            }
        }

        public void Frenar()
        {
            if (estado == "encendido" && velocidad != 0)
            {
                velocidad -= 20;
            }
            else
            {
                Console.WriteLine("El auto esta apagado, o ya no se puede frenar");
            }
        }

        public void bajarPasajeros()
        {
            if(velocidad == 0)
            {
                Apagar();
                for(int i=0;i<Pasajeros.Length;i++)
                {
                    Pasajeros[i] = null;
                }
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Tablero de {marca} {modelo}\nVelocidad: {velocidad} Estado: {estado}");
        }


    }
}
