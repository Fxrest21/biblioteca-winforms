using BibliotecaWinForms.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaWinForms.Modelos;

namespace BibliotecaWinForms
{
    public partial class FormBiblioteca : Form
    {
        public FormBiblioteca()
        {
            InitializeComponent();
        }

        public void MostrarLibros()
        {
            dgvLibros.Rows.Clear();

            for (int i = 0; i < DatosBiblioteca.contadorLibros; i++)
            {
                dgvLibros.Rows.Add(
                    DatosBiblioteca.libros[i].Titulo,
                    DatosBiblioteca.libros[i].Autor,
                    DatosBiblioteca.libros[i].Anio,
                    DatosBiblioteca.libros[i].VecesPrestado
                );
            }
        }

        private void FormBiblioteca_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtAutor.Text == "" || txtAnio.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int anio;

            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("El año debe ser un número");
                return;
            }

            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;

            int nuevoId = DatosBiblioteca.contadorLibros + 1;

            Libro nuevo = new Libro(nuevoId, titulo, autor, anio);

            DatosBiblioteca.libros[DatosBiblioteca.contadorLibros] = nuevo;
            DatosBiblioteca.contadorLibros++;

            MostrarLibros();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0)
            {
                txtTitulo.Text = DatosBiblioteca.libros[fila].Titulo;
                txtAutor.Text = DatosBiblioteca.libros[fila].Autor;
                txtAnio.Text = DatosBiblioteca.libros[fila].Anio.ToString();
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}