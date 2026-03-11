using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinForms.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carnet { get; set; }
        public int PrestamosRealizados { get; set; }

        public Usuario(int id, string nombre, string carnet)
        {
            Id = id;
            Nombre = nombre;
            Carnet = carnet;
            PrestamosRealizados = 0;
        }
    }
}