using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaAppUDB.Models;
using BibliotecaAppUDB.Servicios;

namespace BibliotecaAppUDB.Forms
{
    public partial class LibrosForm : Form
    {
        BibliotecaService biblioteca;

        int idSeleccionado = 0;

        public LibrosForm(BibliotecaService servicio)
        {
            InitializeComponent();
            biblioteca = servicio;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un libro para actualizar");
                return;
            }

            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;

            int anio;
            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("Ingrese un año válido");
                return;
            }

            biblioteca.EditarLibro(idSeleccionado, titulo, autor, anio);

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = biblioteca.Libros;

            MessageBox.Show("Libro actualizado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar");
                return;
            }

            biblioteca.EliminarLibro(idSeleccionado);

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = biblioteca.Libros;

            MessageBox.Show("Libro eliminado");

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();

            idSeleccionado = 0;
        }
    }
}