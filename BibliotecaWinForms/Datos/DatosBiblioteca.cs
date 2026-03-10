using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaWinForms.Modelos;

namespace BibliotecaWinForms.Datos
{
    public static class DatosBiblioteca
    {
        public static Libro[] libros = new Libro[100];
        public static Usuario[] usuarios = new Usuario[100];

        public static int contadorLibros = 0;
        public static int contadorUsuarios = 0;
    }

}
