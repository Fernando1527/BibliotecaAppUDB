using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaAppUDB.Models;
using BibliotecaAppUDB.Servicios;

namespace BibliotecaAppUDB.Forms
{
    public partial class LibrosForm : Form
    {
        BibliotecaService biblioteca = new BibliotecaService();

        int idSeleccionado = 0;

        public LibrosForm()
        {
            InitializeComponent();
            dgvLibros.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;

            int anio;

            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("Ingrese un año válido");
                return;
            }

            biblioteca.AgregarLibro(titulo, autor, anio);

            MessageBox.Show("Libro agregado");

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = biblioteca.Libros;

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = int.Parse(dgvLibros.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                txtAutor.Text = dgvLibros.Rows[e.RowIndex].Cells["Autor"].Value.ToString();
                txtAnio.Text = dgvLibros.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
            }
        }
    }
}