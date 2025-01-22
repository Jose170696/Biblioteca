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


            // Interfaz interctiva
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Sistema de Biblioteca ---");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Agregar Miembro");
                Console.WriteLine("3. Mostrar Libros");
                Console.WriteLine("4. Mostrar Miembros");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Agregar libro
                        Console.WriteLine("\n--- Agregar Nuevo Libro ---");
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Fecha de Publicación (YYYY-MM-DD): ");
                        DateTime fechaPublicacion = DateTime.Parse(Console.ReadLine());

                        Libro libro = new Libro
                        {
                            Titulo = titulo,
                            Autor = autor,
                            ISBN = isbn,
                            FechaPublicacion = fechaPublicacion
                        };
                        biblioteca.AgregarLibro(libro);
                        Console.WriteLine("Libro agregado correctamente.");
                        break;

                    case "2":
                        // Agregar miembro
                        Console.WriteLine("\n--- Agregar Nuevo Miembro ---");
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Fecha de Registro (YYYY-MM-DD): ");
                        DateTime fechaRegistro = DateTime.Parse(Console.ReadLine());

                        Miembro miembro = new Miembro
                        {
                            Nombre = nombre,
                            ID = id,
                            FechaRegistro = fechaRegistro
                        };
                        biblioteca.AgregarMiembro(miembro);
                        Console.WriteLine("Miembro agregado correctamente.");
                        break;

                    case "3":
                        // Mostrar libros
                        Console.WriteLine("\n--- Libros Registrados ---");
                        biblioteca.MostrarLibros();
                        break;

                    case "4":
                        // Mostrar miembros
                        Console.WriteLine("\n--- Miembros Registrados ---");
                        biblioteca.MostrarMiembros();
                        break;

                    case "5":
                        // Salir
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

    }
}

