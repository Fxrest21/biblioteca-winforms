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
        public static Prestamo[] prestamos = new Prestamo[100];

        public static int contadorPrestamos = 0;
        public static int contadorLibros = 0;
        public static int contadorUsuarios = 0;

        public static bool IncrementarPrestamosPorId(int usuarioId, int cantidad = 1)
        {
            for (int i = 0; i < contadorUsuarios; i++)
            {
                var u = usuarios[i];
                if (u != null && u.Id == usuarioId)
                {
                    u.PrestamosRealizados += cantidad;
                    return true;
                }
            }
            return false;
        }

        public static bool IncrementarPrestamosPorIndice(int indice, int cantidad = 1)
        {
            if (indice < 0 || indice >= contadorUsuarios) return false;
            var u = usuarios[indice];
            if (u == null) return false;
            u.PrestamosRealizados += cantidad;
            return true;
        }
    }
}
