using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAppUDB.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }

        public Libro(int id, string titulo, string autor, int anio)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Disponible = true;
        }
    }
}
