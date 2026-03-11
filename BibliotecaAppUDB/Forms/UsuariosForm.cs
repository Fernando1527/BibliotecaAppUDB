using System;
using System.Windows.Forms;
using BibliotecaAppUDB.Models;
using BibliotecaAppUDB.Servicios;

namespace BibliotecaAppUDB.Forms
{
    public partial class UsuariosForm : Form
    {
        BibliotecaService biblioteca;
        int idSeleccionado = 0;

        public UsuariosForm(BibliotecaService servicio)
        {
            InitializeComponent();
            biblioteca = servicio;
            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;

            biblioteca.AgregarUsuario(nombre, correo);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = biblioteca.Usuarios;

            txtNombre.Clear();
            txtCorreo.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;

            biblioteca.EditarUsuario(idSeleccionado, nombre, correo);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = biblioteca.Usuarios;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            biblioteca.EliminarUsuario(idSeleccionado);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = biblioteca.Usuarios;

            txtNombre.Clear();
            txtCorreo.Clear();
            idSeleccionado = 0;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            }
        }

      
    }
}