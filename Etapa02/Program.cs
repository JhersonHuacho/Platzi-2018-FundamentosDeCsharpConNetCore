using System;
using CoreEscuela.Entidades;

namespace Etapa01
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Huacho Acadamy", 2012, TiposEscuela.Primaria,
                ciudad: "Loreto", pais: "Perú");
            escuela.Pais = "Perú";
            escuela.Ciudad = "Iquitos";

            var curso1 = new Curso()
            {
                Nombre = "101"
            };
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            var curso3 = new Curso()
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("=====================");
            Console.WriteLine(curso1.Nombre + " , " + curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            Console.WriteLine(curso3);
        }
    }
}
