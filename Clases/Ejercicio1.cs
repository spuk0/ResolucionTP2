using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion.Clases
{
    internal class Ejercicio1
    {
        public Ejercicio1() { }

        public void compararCon100() {
            Console.WriteLine("Ingresar valor que sera comparado con 100: ");
            int p_numero = int.Parse(Console.ReadLine());
            if (p_numero > 100)
            {
                Console.WriteLine($"{p_numero} es mayor que 100");
            }
            else
            {
                Console.WriteLine($"{p_numero} es menor que 100");
            }
        }

        public void verParOImpar()
        {
            Console.WriteLine("Ingresar numero entero para ver si es par o impar");
            int p_numero = int.Parse(Console.ReadLine());
            if ((p_numero % 2) == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }

        public void dobleDeImpar()
        {
            Console.WriteLine("Ingresar valor entero");
            int p_numero = int.Parse(Console.ReadLine());
            int mitad = p_numero / 2;
            if ((p_numero % 2) == 0 && (mitad % 2) > 0)
            {
                Console.WriteLine("Cumple con la condicion");
            }
            else
            {
                Console.WriteLine("No cumple la condicion");
            }
        }

        public void pasarARomano()
        {
            Console.WriteLine("Ingresar valor entero para pasarlo a romano");
            int p_numero = int.Parse(Console.ReadLine());
            switch (p_numero)
            {
                case 0:
                    Console.WriteLine("No hay cero");
                    break;
                case 1:
                    Console.WriteLine($"{p_numero} en romano es I");
                    break;
                case 2:
                    Console.WriteLine($"{p_numero} en romano es II");
                    break;
                case 3:
                    Console.WriteLine($"{p_numero} en romano es III");
                    break;
                case 4:
                    Console.WriteLine($"{p_numero} en romano es IV");
                    break;
                case 5:
                    Console.WriteLine($"{p_numero} en romano es V");
                    break;
                case 6:
                    Console.WriteLine($"{p_numero} en romano es VI");
                    break;
                case 7:
                    Console.WriteLine($"{p_numero} en romano es VII");
                    break;
                case 8:
                    Console.WriteLine($"{p_numero} en romano es VIII");
                    break;
                case 9:
                    Console.WriteLine($"{p_numero} en romano es IX");
                    break;
                case 10:
                    Console.WriteLine($"{p_numero} en romano es X");
                    break;
            }
        }

        public void compararEdadDosPersonas()
        {
            Console.WriteLine("\n\nNombre de primer persona: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Edad de primer persona: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\nNombre de segunda persona: ");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Edad de segunda persona: ");
            int edad2 = int.Parse(Console.ReadLine());

            if (edad > edad2 && edad != edad2)
            {
                Console.WriteLine($"{nombre2} es el menor. Diferencia de edad: {edad - edad2}");
            }
            if (edad < edad2 && edad != edad2)
            {
                Console.WriteLine($"{nombre} es el menor. Diferencia de edad: {edad2 - edad}");
            }
            if (edad2 == edad)
            {
                Console.WriteLine("Tienen la misma edad");
            }
        }

        public void analizarTriangulo()
        {
            Console.WriteLine("Ingrese la base del triangulo: ");
            int basee = int.Parse(Console.ReadLine());
            Console.WriteLine("\nLado 2: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nLado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            int hipotenusa = (int)Math.Sqrt(Math.Pow(lado3, 2) + Math.Pow(lado2, 2));
            int area = (basee * hipotenusa) / 2;
            int perimetro = basee + lado2 + lado3;

            if (basee == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triangulo equilatero");

            }
            if (basee == lado2 || basee == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triangulo isoceles");
            }
            if (basee != lado2 && basee != lado3 && lado2 != lado3)
            {
                Console.WriteLine("Es un triangulo escaleno");
            }

            Console.WriteLine($"El perimetro es {perimetro}\nEl area es {area}\nLa hipotenusa es {hipotenusa}");
        }

        public void desglosarDinero()
        {
            Console.WriteLine("Ingrese cantidad a desglosar: ");
            int dinero = int.Parse(Console.ReadLine());
            int billete1000 = 0, billete500 = 0, billete100 = 0, billete50 = 0, billete20 = 0, billete10 = 0, billete5 = 0, billete2 = 0, billete1 = 0;

            while (dinero != 0)
            {
                billete1000 = (dinero - (dinero % 1000)) / 1000;
                dinero = dinero % 1000;
                billete500 = (dinero - (dinero % 500)) / 500;
                dinero = dinero % 500;
                billete100 = (dinero - (dinero % 100)) / 100;
                dinero = dinero % 100;
                billete50 = (dinero - (dinero % 50)) / 50;
                dinero = dinero % 50;
                billete20 = (dinero - (dinero % 20)) / 20;
                dinero = dinero % 20;
                billete10 = (dinero - (dinero % 10)) / 10;
                dinero = dinero % 10;
                billete5 = (dinero - (dinero % 5)) / 5;
                dinero = dinero % 5;
                billete1 = (dinero - (dinero % 1)) / 1;
                dinero = dinero % 1;
            }

            Console.WriteLine($"{billete1000} billetes de 1000\n{billete500} billetes de 500\n{billete100} billetes de 100" +
                $"\n{billete50} billetes de 50\n{billete20} billetes de 20\n{billete10} billetes de 10\n{billete5} billetes de 5" +
                $"\n{billete1} billetes de 1");
        }

        public string cadenaDesde1HastaElIngresado()
        {
            Console.WriteLine("Ingresar numero N");
            int numero = int.Parse(Console.ReadLine());
            string cadena = "";
            for (int i = 0; i < numero; i++)
            {
                cadena += (i + 1) + " ";
            }
            return cadena;
        }

        public int ingresarYSumar15Numeros()
        {
            int num = 0, suma = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingresar numero {i + 1}");
                num = int.Parse(Console.ReadLine());
                suma += num;
            }
            return suma;
        }

        private bool esMultiploDeTres(int p_num)
        {
            if (p_num % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void verificarMultiploDe3()
        {
            int num = 0;
            string multiplos = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingresar numero {i + 1}");
                num = int.Parse(Console.ReadLine());
                if (esMultiploDeTres(num))
                {
                    multiplos += $" - {num} - ";
                }
            }
            Console.WriteLine($"Multiplos de 3:\n{multiplos}");
        }

        public void userLogin()
        {
            string password = "inosuke";
            string passwordAIngresar = "";
            Console.WriteLine("Ingresar contraseña: ");
            passwordAIngresar = Console.ReadLine();

            while (passwordAIngresar != password)
            {
                Console.WriteLine("¡Incorrecto!. \nIngresar contraseña: ");
                passwordAIngresar = Console.ReadLine();
            }
            Console.WriteLine("\nBienvenido señor Stark");
        }

        public void userLogin2()
        {
            int limites = 0;
            string password = "inosuke";
            string passwordAIngresar = "";
            Console.WriteLine("Ingresar contraseña: ");
            passwordAIngresar = Console.ReadLine();

            while (passwordAIngresar != password)
            {
                if (limites < 2)
                {
                    Console.WriteLine($"¡Incorrecto! {limites + 1}/3. \nIngresar contraseña: ");
                    passwordAIngresar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Superaste el limite de intentos");
                    break;
                }

                limites++;
            }
            Console.WriteLine("\nBienvenido señor Stark");
        }

        public void adivinanza()
        {
            const int adivinanza = 3;
            Console.WriteLine("¡Adivine el numero que esta guardado en la memoria!. Escribir:");
            int adivinar = int.Parse(Console.ReadLine());

            while (adivinanza != adivinar)
            {
                Console.WriteLine("Ese no es el numero XD intenta de nuevo: ");
                adivinar = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"¡Bien ahi! la respuesta era {adivinanza}, le pegaste!");
        }

        public void adivinanza2()
        {
            const int adivinanza = 3;
            Console.WriteLine("¡Adivine el numero que esta guardado en la memoria!. Escribir:");
            int adivinar = int.Parse(Console.ReadLine());

            while (adivinanza != adivinar)
            {
                if (adivinar < adivinanza)
                {
                    Console.WriteLine($"Ese no es el numero XD, proba con uno mayor: ");
                    adivinar = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Ese no es el numero XD, proba con uno menor: ");
                    adivinar = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"¡Bien ahi! la respuesta era {adivinanza}, le pegaste!");
        }

        public void sumaDeNumerosIngresados()
        {
            string condicion = "";
            int suma = 0;
            Console.WriteLine("Ingrese un numero para empezar a sumar");
            suma = int.Parse(Console.ReadLine());

            while (condicion != "fin" && condicion != "Fin" && condicion != "FIN")
            {
                Console.WriteLine("Ingresa el siguiente numero a sumar: ");
                suma += int.Parse(Console.ReadLine());
                Console.WriteLine($"La suma es {suma}, quiere seguir sumando?\nEscribir 'si' para continuar o 'fin' para terminar:");
                condicion = Console.ReadLine();
            }
            Console.WriteLine($"El resultado final de todas las sumas fue {suma}, de nada c;");
        }


    }
}
