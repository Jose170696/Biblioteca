using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Miembro
    {
        public string Nombre { get; set; }
        public string ID { get; set; }
        public DateTime FechaRegistro { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, ID: {ID}, Fecha de Registro: {FechaRegistro.ToShortDateString()}");
        }
    }
}
