using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AnioDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Curso[] Cursos { get; set; }
        public List<Curso> CursosList { get; set; }
        public Escuela(string nombre, int anio)
        {
            //this.nombre = nombre;
            Nombre = nombre;
            AnioDeCreacion = anio;
        }
        public Escuela(string nombre, int anio, TiposEscuela tipos, string pais = "", string ciudad = "")
        {
            (Nombre, AnioDeCreacion) = (nombre, anio);
            Pais = pais;
            Ciudad = ciudad;
        }
        // El constructor lo podemos escribir de una manera mas corta.
        // Mediante igualación por tuplas. Que es una caracteristica muy comun en los lenaguajes funcionales.
        public Escuela(string nombre, int anio, string pais) => (Nombre, AnioDeCreacion, Pais) = (nombre, anio, pais);

        public override string ToString()
        {
            // return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}