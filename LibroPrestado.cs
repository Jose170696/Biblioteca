using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class LibroPrestado : Libro
    {
        public DateTime FechaPrestamo { get; set; }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Fecha de Préstamo: {FechaPrestamo.ToShortDateString()}");
        }
    }
}
