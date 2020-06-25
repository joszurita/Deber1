using System;

namespace Deber1
{
    class Program
    {
        static void Main(string[] argumentoss)
        {
            if (argumentoss.Length > 0){
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(argumentoss[0]);
            }

            //Declarar variables donde se almacena los datos que se ingresan y las constantes a usar 
            string titulo = "Edad";
            string nombre = "";
            string apellido = "";
            int añoNacimiento = 0;
            int añoActual = 2020;
            //Console.Title: Es el titulo de la consola
            Console.Title = titulo;
            //Console.BackgroundColor: Establece el color de fondo de la consola
            Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor: Color de fuente o letra
            Console.ForegroundColor = ConsoleColor.White;
            //onsole.WriteLine:  Escribe en una sola linea y el cursor pasa a otra linea
            Console.WriteLine("Hola, Ingresa tu nombre:");
            //Console.ReadLine: Lee la linea siguiente al WriteLine, guarda en la variable asiganada y pasa a otra linea
            nombre = Console.ReadLine();
            Console.WriteLine("Ahora, Ingresa tu apellido:");
            apellido = Console.ReadLine();
            //$: Es ùn simbolo para concatenar cadenas de texto
            Console.WriteLine($"Hola {nombre} {apellido}");
            Console.WriteLine("Ahora, Ingresa tu año de Nacimiento:");
            añoNacimiento = Convert.ToInt32(Console.ReadLine());
            //Convert.ToInt32=Convierte un texto en numero entero
            Console.WriteLine($"{nombre} {apellido}, tu edad es: " + (añoActual - añoNacimiento));
            //Console.ReadKey: Lee la tecla presioanada
            Console.ReadKey();
        }
    }
}
