using System;
using System.Collections.Generic;
using System.Text;

using BibliotecaAppUDB.Models;

namespace BibliotecaAppUDB.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }

        public Prestamo(int id, Libro libro, Usuario usuario)
        {
            Id = id;
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now;
            Devuelto = false;
        }
    }
}
