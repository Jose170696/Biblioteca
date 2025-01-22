using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();
        private List<Miembro> miembros = new List<Miembro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine("Libro agregado exitosamente.");
        }

        public void AgregarMiembro(Miembro miembro)
        {
            miembros.Add(miembro);
            Console.WriteLine("Miembro agregado exitosamente.");
        }

        public void MostrarLibros()
        {
            Console.WriteLine("\nLista de libros:");
            foreach (var libro in libros)
            {
                libro.MostrarInfo();
            }
        }

        public void MostrarMiembros()
        {
            Console.WriteLine("\nLista de miembros:");
            foreach (var miembro in miembros)
            {
                miembro.MostrarInfo();
            }
        }
    }
}
