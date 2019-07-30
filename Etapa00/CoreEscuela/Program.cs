using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int anioFundacion;
        public string ceo;
        public void Timbrar()
        {
            //Todo
            Console.Beep(10000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Huacho Academy";
            miEscuela.direccion = "Calle 890";
            miEscuela.anioFundacion = 2012;
            Console.WriteLine("TIMBRE");
            miEscuela.Timbrar();
            // Console.WriteLine("Hello World!");
        }
    }
}
