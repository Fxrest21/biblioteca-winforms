using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinForms.Modelos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Carnet { get; set; }

        public int Prestamos { get; set; }

        public Usuario(string nombre, string carnet)
        {
            Prestamos = 0;
            Nombre = nombre;
            Carnet = carnet;
        }
    }
}
