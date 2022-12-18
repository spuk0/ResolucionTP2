using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion2.Clases
{
    internal class Smartphone
    {
        public string estado { get; set; }
        public int volumen { get; set; }
        public int brilloPantalla { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public Smartphone(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.estado = "apagado";
            this.volumen = 100;
            this.brilloPantalla = 50;
        }

        public void Ancender()
        {
            estado = "encendido";
        }

        public void Apagar()
        {
            estado = "apagado";
        }

        public void BajarVolumen(int cantidad)
        {
            volumen = volumen - cantidad;
        }

        public void SubirVolumen (int cantidad)
        {
            volumen += cantidad;
        }

        public void Silenciar()
        {
            volumen = 0;
        }

        public void SubirBrillo (int cantidad)
        {
            brilloPantalla += cantidad;
        }

        public void BajarBrillo (int cantidad)
        {
            brilloPantalla -= cantidad;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nEstado: {estado}\nNivel de volumen: {volumen}\nNivel de brillo en pantalla: {brilloPantalla}");
        }


    }
}
