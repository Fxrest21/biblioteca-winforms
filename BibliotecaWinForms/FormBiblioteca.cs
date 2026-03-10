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
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int anio = int.Parse(txtAnio.Text);

    
            int nuevoId = DatosBiblioteca.contadorLibros + 1; 

    Libro nuevo = new Libro(nuevoId, titulo, autor, anio);

    DatosBiblioteca.libros[DatosBiblioteca.contadorLibros] = nuevo;
    DatosBiblioteca.contadorLibros++;

    MostrarLibros();
        }
    }
}
