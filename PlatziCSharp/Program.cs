using System;

namespace PlatziCSharp
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo = "Freddy Vega";

        public void Timbrar()
        {
            //Todo
            Console.Beep(2000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi";
            miEscuela.direccion = "Cr 9 calle 72";
            miEscuela.añoFundacion = 2012;
            Console.WriteLine("Timbre");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
