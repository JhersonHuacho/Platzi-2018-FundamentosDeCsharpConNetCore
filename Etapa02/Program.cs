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

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
            {
                Nombre = "101"
            };

            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("========= Imprimir Usando While ============");
            ImprimirCursosUsandoWhile(arregloCursos);
            System.Console.WriteLine("========= Imprimir Usando Do While =========");
            ImprimirCursosUsandoDoWhile(arregloCursos);
            System.Console.WriteLine("========= Imprimir Usando For ==============");
            ImprimirCursosUsandoFor(arregloCursos);
            System.Console.WriteLine("========= Imprimir Usando ForEach ==========");
            ImprimirCursosUsandoForEach(arregloCursos);
        }

        private static void ImprimirCursosUsandoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
        private static void ImprimirCursosUsandoDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;

            do
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosUsandoFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");
            }
        }
        private static void ImprimirCursosUsandoForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            }
        }
    }
}
