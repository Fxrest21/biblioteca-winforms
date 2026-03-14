using System;

namespace BibliotecaWinForms.Modelos
{
    public class Prestamo
    {
        public string Usuario { get; set; }
        public string Libro { get; set; }
        public DateTime Fecha { get; set; }

        public Prestamo(string usuario, string libro)
        {
            Usuario = usuario;
            Libro = libro;
            Fecha = DateTime.Now;
        }
    }
}
