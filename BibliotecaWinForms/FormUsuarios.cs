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
    }
}
