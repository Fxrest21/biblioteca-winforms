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
    public partial class FormUsuarios : Form
    {
        int indiceSeleccionado = -1;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        public void MostrarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            for (int i = 0; i < DatosBiblioteca.contadorUsuarios; i++)
            {
                dgvUsuarios.Rows.Add(
                    DatosBiblioteca.usuarios[i].Nombre,
                    DatosBiblioteca.usuarios[i].Carnet,
                    DatosBiblioteca.usuarios[i].PrestamosRealizados
                );
            }
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "")
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            int id = DatosBiblioteca.contadorUsuarios + 1;

            Usuario nuevo = new Usuario(id, txtNombre.Text, txtCarnet.Text);

            DatosBiblioteca.usuarios[DatosBiblioteca.contadorUsuarios] = nuevo;

            DatosBiblioteca.contadorUsuarios++;

            MostrarUsuarios();

            txtNombre.Clear();
            txtCarnet.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado < 0 || indiceSeleccionado >= DatosBiblioteca.contadorUsuarios)
            {
                MessageBox.Show("Seleccione un usuario para editar");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text))
            {
                MessageBox.Show("Complete los campos");
                return;
            }
            Usuario usuario = DatosBiblioteca.usuarios[indiceSeleccionado];
            usuario.Nombre = txtNombre.Text;
            usuario.Carnet = txtCarnet.Text;

            MostrarUsuarios();

            txtNombre.Clear();
            txtCarnet.Clear();
            indiceSeleccionado = -1;
            dgvUsuarios.ClearSelection();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado < 0 || indiceSeleccionado >= DatosBiblioteca.contadorUsuarios)
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
                return;
            }

            var confirm = MessageBox.Show("¿Desea eliminar al usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            for (int i = indiceSeleccionado; i < DatosBiblioteca.contadorUsuarios - 1; i++)
            {
                DatosBiblioteca.usuarios[i] = DatosBiblioteca.usuarios[i + 1];
            }

            DatosBiblioteca.usuarios[DatosBiblioteca.contadorUsuarios - 1] = null;
            DatosBiblioteca.contadorUsuarios--;

            MostrarUsuarios();

            txtNombre.Clear();
            txtCarnet.Clear();
            indiceSeleccionado = -1;
            dgvUsuarios.ClearSelection();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            indiceSeleccionado = e.RowIndex;

            txtNombre.Text = DatosBiblioteca.usuarios[indiceSeleccionado].Nombre;
            txtCarnet.Text = DatosBiblioteca.usuarios[indiceSeleccionado].Carnet;
        }

        
    }
}
