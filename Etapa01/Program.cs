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

            Console.WriteLine(escuela);
        }
    }
}
