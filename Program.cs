using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Agregar libros
            Libro libro1 = new Libro
            {
                Titulo = "The Nature of Space and Time",
                Autor = "Roger Penrose",
                ISBN = "978-8499921563",
                FechaPublicacion = new DateTime(2012, 2, 16)
            };

            Libro libro2 = new Libro
            {
                Titulo = "The Grand Design",
                Autor = "Stephen Hawking",
                ISBN = "978-8491991700",
                FechaPublicacion = new DateTime(2010, 9, 9)
            };
            

            LibroPrestado libroPrestado = new LibroPrestado
            {
                Titulo = "The Future of the Mind",
                Autor = "Michio Kaku",
                ISBN = "978-8499923925",
                FechaPublicacion = new DateTime(2014, 2, 25),
                FechaPrestamo = DateTime.Now
            };
            

            // Agregar miembros
            Miembro miembro1 = new Miembro
            {
                Nombre = "Esteban Chaverri",
                ID = "M001",
                FechaRegistro = DateTime.Now
            };

            Miembro miembro2 = new Miembro
            {
                Nombre = "Jose Hernández",
                ID = "M002",
                FechaRegistro = DateTime.Now
            };

            // Agregar libros y miembros a la biblioteca
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libroPrestado);

            biblioteca.AgregarMiembro(miembro1);
            biblioteca.AgregarMiembro(miembro2);

            // Mostrar información de libros y miembros
            biblioteca.MostrarLibros();
            biblioteca.MostrarMiembros();

        }
    }
}
