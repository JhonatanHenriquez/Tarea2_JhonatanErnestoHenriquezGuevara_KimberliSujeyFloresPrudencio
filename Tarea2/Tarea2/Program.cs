using System;
using Tarea2.Entidades;
using Tarea2.Negocios;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            Palabra palabra = new Palabra();
            palabra.palabra = Console.ReadLine();

            ClsPersona contar = new ClsPersona();

            Console.WriteLine("La palabra " + palabra.palabra + " tiene " + contar.contarPalabra(palabra) + " letras");
            Console.ReadKey();

        }
    }
}
