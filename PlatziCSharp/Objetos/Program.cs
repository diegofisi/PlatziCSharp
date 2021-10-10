using PlatziCSharp.Entidades;
using System;

namespace PlatziCSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi ",2012); ;
            escuela.Nombre = "Platzi ";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
