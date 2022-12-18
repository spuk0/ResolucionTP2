using Resolucion.Clases;
using Resolucion2.Clases;

class Program
{
    static void Main()
    {
        Ejercicio1 ejercicio = new Ejercicio1();
        Cuadrado cuadrado = new Cuadrado(2);
        Persona javier = new Persona("Javier", "Frias", 1997);
        Persona pasajero = new Persona("Pasajero", "Pasal", 2010);
        Persona pasajero2 = new Persona("Pasajerooo", "Pasaleo", 1982);
        Auto auto = new Auto(207, "Peugeot", "Rojo", 2, javier);
        Mascota mascota = new Mascota(200, "Camilo", "Gato", "pequeño");
        Estudiante estudiante = new Estudiante("Javiera", "Antonia");

        estudiante.mostrarDatos();
        auto.agregarPasajero(pasajero);
        auto.agregarPasajero(pasajero2);
        auto.Encender();
        auto.agregarMascota(mascota);
        auto.conQuienEstaMascota(mascota);
        auto.MostrarDatos();

        /*
        mascota.mostrarDatos();
        mascota.alimentar(1);
        mascota.mostrarDatos();
        mascota.correr();
        mascota.mostrarDatos();
        cuadrado.mostrarDatos();
        javier.mostrarDatos(); */

    }
}

