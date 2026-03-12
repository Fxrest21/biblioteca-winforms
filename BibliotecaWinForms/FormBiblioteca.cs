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
using System.Windows.Forms.DataVisualization.Charting;
using BibliotecaWinForms.Modelos;

namespace BibliotecaWinForms
{
    public partial class FormBiblioteca : Form
    {
        int indiceSeleccionado = -1;
        public FormBiblioteca()
        {
            InitializeComponent();

            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnPrestamo.Click += btnPrestamo_Click;
            dgvLibros.CellClick += dgvLibros_CellClick;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.ReadOnly = true;

            dgvLibros.ClearSelection();

            if (chartLibros.ChartAreas.Count == 0)
            {
                chartLibros.ChartAreas.Add(new ChartArea("Default"));
            }
            if (chartLibros.Legends.Count == 0)
            {
                chartLibros.Legends.Add(new Legend("Legend1"));
            }
        }

        public void MostrarLibros()
        {
            if (dgvLibros.Columns.Count == 0)
            {
                dgvLibros.Columns.Add("colTitulo", "Título");
                dgvLibros.Columns.Add("colAutor", "Autor");
                dgvLibros.Columns.Add("colAnio", "Año");
                dgvLibros.Columns.Add("colVeces", "Veces prestado");
            }

            dgvLibros.Rows.Clear();

            for (int i = 0; i < DatosBiblioteca.contadorLibros; i++)
            {
                int rowIndex = dgvLibros.Rows.Add(
                    DatosBiblioteca.libros[i].Titulo,
                    DatosBiblioteca.libros[i].Autor,
                    DatosBiblioteca.libros[i].Anio,
                    DatosBiblioteca.libros[i].VecesPrestado
                );

                dgvLibros.Rows[rowIndex].Tag = DatosBiblioteca.libros[i];
            }

            indiceSeleccionado = -1;
            dgvLibros.ClearSelection();

            ActualizarGraficaLibros();
        }

        public void ActualizarGraficaLibros()
        {
            chartLibros.Series[0].Points.Clear();

            for (int i = 0; i < DatosBiblioteca.contadorLibros; i++)
            {
                chartLibros.Series[0].Points.AddXY(
                    DatosBiblioteca.libros[i].Titulo,
                    DatosBiblioteca.libros[i].VecesPrestado
                );
            }
        }
        private void FormBiblioteca_Load(object sender, EventArgs e)
        {
            MostrarLibros();
            ActualizarGraficaLibros();
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
            if (e.RowIndex < 0) return;

            indiceSeleccionado = e.RowIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < DatosBiblioteca.contadorLibros &&
                DatosBiblioteca.libros[indiceSeleccionado] != null)
            {
                txtTitulo.Text = DatosBiblioteca.libros[indiceSeleccionado].Titulo;
                txtAutor.Text = DatosBiblioteca.libros[indiceSeleccionado].Autor;
                txtAnio.Text = DatosBiblioteca.libros[indiceSeleccionado].Anio.ToString();

                dgvLibros.ClearSelection();
                dgvLibros.Rows[indiceSeleccionado].Selected = true;
            }
            else
            {
                indiceSeleccionado = -1;
            }
        }

        private int ObtenerIndiceSeleccionadoSeguro()
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int idx = dgvLibros.SelectedRows[0].Index;
                if (idx >= 0 && idx < DatosBiblioteca.contadorLibros) return idx;
            }

            if (dgvLibros.CurrentCell != null)
            {
                int idx = dgvLibros.CurrentCell.RowIndex;
                if (idx >= 0 && idx < DatosBiblioteca.contadorLibros) return idx;
            }

            if (indiceSeleccionado >= 0 && indiceSeleccionado < DatosBiblioteca.contadorLibros) return indiceSeleccionado;

            return -1;
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            FormPrestamo form = new FormPrestamo();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idx = ObtenerIndiceSeleccionadoSeguro();

            if (idx < 0 || DatosBiblioteca.libros[idx] == null)
            {
                MessageBox.Show("Seleccione un libro de la tabla");
                return;
            }

            int anio;
            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("El año debe ser numérico");
                return;
            }

            DatosBiblioteca.libros[idx].Titulo = txtTitulo.Text;
            DatosBiblioteca.libros[idx].Autor = txtAutor.Text;
            DatosBiblioteca.libros[idx].Anio = anio;

            MostrarLibros();

            if (idx >= 0 && idx < dgvLibros.Rows.Count)
            {
                dgvLibros.Rows[idx].Selected = true;
                indiceSeleccionado = idx;
            }

            MessageBox.Show("Libro editado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idx = ObtenerIndiceSeleccionadoSeguro();

            if (idx < 0 || DatosBiblioteca.libros[idx] == null)
            {
                MessageBox.Show("Seleccione un libro para eliminar");
                return;
            }

            var resp = MessageBox.Show("¿Eliminar el libro seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            for (int i = idx; i < DatosBiblioteca.contadorLibros - 1; i++)
            {
                DatosBiblioteca.libros[i] = DatosBiblioteca.libros[i + 1];
            }

            DatosBiblioteca.libros[DatosBiblioteca.contadorLibros - 1] = null;
            DatosBiblioteca.contadorLibros--;

            indiceSeleccionado = -1;
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();

            MostrarLibros();

            MessageBox.Show("Libro eliminado");
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLibros_CellClick(sender, e);
        }
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            using (var f = new FormUsuarios())
            {
                f.ShowDialog(this);
            }
        }

        
    }
}