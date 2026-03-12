using BibliotecaWinForms.Datos;
using BibliotecaWinForms.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BibliotecaWinForms
{
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
        {
            InitializeComponent();
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarLibros();
        }

        public void CargarUsuarios()
        {
            cmbUsuario.Items.Clear();

            for (int i = 0; i < DatosBiblioteca.contadorUsuarios; i++)
            {
                var u = DatosBiblioteca.usuarios[i];
                if (u == null) continue;
                cmbUsuario.Items.Add(u.Nombre);
            }

            if (cmbUsuario.Items.Count > 0) cmbUsuario.SelectedIndex = -1;
        }

        public void CargarLibros()
        {
            cmbLibros.Items.Clear();

            for (int i = 0; i < DatosBiblioteca.contadorLibros; i++)
            {
                var b = DatosBiblioteca.libros[i];
                if (b == null) continue;
                cmbLibros.Items.Add(b.Titulo);
            }

            if (cmbLibros.Items.Count > 0) cmbLibros.SelectedIndex = -1;
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex == -1 || cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione usuario y libro");
                return;
            }

            int usuarioIndex = cmbUsuario.SelectedIndex;
            int libroIndex = cmbLibros.SelectedIndex;

            string usuario = DatosBiblioteca.usuarios[usuarioIndex].Nombre;
            string libro = DatosBiblioteca.libros[libroIndex].Titulo;

            Prestamo nuevo = new Prestamo(usuario, libro);

            DatosBiblioteca.prestamos[DatosBiblioteca.contadorPrestamos] = nuevo;
            DatosBiblioteca.contadorPrestamos++;

            // ACTUALIZAR ESTADÍSTICAS
            DatosBiblioteca.libros[libroIndex].VecesPrestado++;
            DatosBiblioteca.usuarios[usuarioIndex].PrestamosRealizados++;

            MessageBox.Show("Préstamo registrado");

            this.Close();
        }
    }
}
