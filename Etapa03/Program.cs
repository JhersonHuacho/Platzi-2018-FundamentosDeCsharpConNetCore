using System;
using CoreEscuela.Entidades;
using static System.Console;

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
            escuela.Cursos = new Curso[]
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };

            var arregloCursos = new Curso[3]
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };

            Curso[] arregloCursosDos =
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };


            Console.WriteLine(escuela);
            ImprimirCursosEscuela(escuela);

            System.Console.WriteLine("");
            System.Console.WriteLine("========= Imprimir Usando While ============");
            ImprimirCursosUsandoWhile(arregloCursos);
            System.Console.WriteLine("========= Imprimir Usando Do While =========");
            ImprimirCursosUsandoDoWhile(arregloCursos);
            System.Console.WriteLine("========= Imprimir Usando For ==============");
            ImprimirCursosUsandoFor(arregloCursos);
            System.Console.WriteLine("========= Imprimir Usando ForEach ==========");
            ImprimirCursosUsandoForEach(arregloCursos);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            // if (escuela != null && escuela.Cursos != null)
            // {
            //     foreach (var curso in escuela.Cursos)
            //     {
            //         WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            //     }
            // }

            // una forma mas corta de evaluar si es null, y acorde a las nuevas versiones de C#.
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
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
