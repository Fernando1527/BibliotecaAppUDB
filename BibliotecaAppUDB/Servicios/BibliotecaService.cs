using BibliotecaAppUDB.Models;
using System.Linq;

namespace BibliotecaAppUDB.Servicios
{
    public class BibliotecaService
    {
        public List<Libro> Libros = new List<Libro>();
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Prestamo> Prestamos = new List<Prestamo>();

        int contadorLibros = 1;
        int contadorUsuarios = 1;
        int contadorPrestamos = 1;

        // Desarrollo del crud para los libros

        public void AgregarLibro(string titulo, string autor, int anio)
        {
            Libro libro = new Libro(contadorLibros++, titulo, autor, anio);
            Libros.Add(libro);
        }

        public void EliminarLibro(int id)
        {
            var libro = Libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
                Libros.Remove(libro);
        }

        public void EditarLibro(int id, string titulo, string autor, int anio)
        {
            var libro = Libros.FirstOrDefault(l => l.Id == id);

            if (libro != null)
            {
                libro.Titulo = titulo;
                libro.Autor = autor;
                libro.Anio = anio;
            }
        }

        // CRUD para los usarios

        public void AgregarUsuario(string nombre, string correo)
        {
            Usuario usuario = new Usuario(contadorUsuarios++, nombre, correo);
            Usuarios.Add(usuario);
        }
        public void EditarUsuario(int id, string nombre, string correo)
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                usuario.Nombre = nombre;
                usuario.Correo = correo;
            }
        }

        public void EliminarUsuario(int id)
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
                Usuarios.Remove(usuario);
        }


        // Aqui va prestamo

        public void RegistrarPrestamo(int idLibro, int idUsuario)
        {
            Libro libro = Libros.FirstOrDefault(l => l.Id == idLibro);
            Usuario usuario = Usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (libro != null && usuario != null && libro.Disponible)
            {
                Prestamo prestamo = new Prestamo(
                    Prestamos.Count + 1,
                    libro,
                    usuario
                );

                prestamo.FechaPrestamo = DateTime.Now;
                prestamo.Devuelto = false;

                libro.Disponible = false;

                Prestamos.Add(prestamo); // ESTA LÍNEA FALTABA
            }
        }
        public void RegistrarDevolucion(int idPrestamo)
        {
            var prestamo = Prestamos.FirstOrDefault(p => p.Id == idPrestamo);

            if (prestamo != null)
            {
                prestamo.Devuelto = true;
                prestamo.Libro.Disponible = true;
            }
        }

        public void DevolverLibro(int idPrestamo)
        {
            var prestamo = Prestamos.FirstOrDefault(p => p.Id == idPrestamo);

            if (prestamo != null && !prestamo.Devuelto)
            {
                prestamo.Devuelto = true;
                prestamo.Libro.Disponible = true;
            }
        }
    }
}