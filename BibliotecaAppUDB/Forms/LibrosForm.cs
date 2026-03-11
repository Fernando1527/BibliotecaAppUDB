using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BibliotecaAppUDB.Models;

namespace BibliotecaAppUDB.Forms
{
    public partial class LibrosForm : Form
    {
        List<Libro> listaLibros = new List<Libro>();
        int idActual = 1;

        public LibrosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int anio = int.Parse(txtAnio.Text);

            Libro nuevoLibro = new Libro()
            {
                Id = idActual,
                Titulo = titulo,
                Autor = autor,
                Anio = anio
            };

            listaLibros.Add(nuevoLibro);

            dgvLibros.Rows.Add(nuevoLibro.Id, nuevoLibro.Titulo, nuevoLibro.Autor, nuevoLibro.Anio);

            idActual++;

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
        }
    }
}