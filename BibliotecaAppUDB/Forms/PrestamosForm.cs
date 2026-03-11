using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaAppUDB.Servicios;

namespace BibliotecaAppUDB.Forms
{
    public partial class PrestamosForm : Form
    {
        BibliotecaService biblioteca;

        public PrestamosForm(BibliotecaService servicio)
        {
            InitializeComponent();
            biblioteca = servicio;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void PrestamosForm_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = biblioteca.Usuarios;
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "Id";

            cmbLibros.DataSource = biblioteca.Libros.Where(l => l.Disponible).ToList();
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "Id";
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            int idUsuario = (int)cmbUsuarios.SelectedValue;
            int idLibro = (int)cmbLibros.SelectedValue;

            biblioteca.RegistrarPrestamo(idLibro, idUsuario);

            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = biblioteca.Prestamos;
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo");
                return;
            }

            int idPrestamo = (int)dgvPrestamos.CurrentRow.Cells["Id"].Value;

            biblioteca.RegistrarDevolucion(idPrestamo);

            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = biblioteca.Prestamos;
        }
    }
}