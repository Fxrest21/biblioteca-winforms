using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinForms.Modelos
{
    internal class Prestamo
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public Prestamo(int id, int libro, int usuario
            {
            Id = id;
            IdLibro = libro;
            IdUsuario = usuario; 
            FechaPrestamo = DateTime.Now;

        }
    }
}
