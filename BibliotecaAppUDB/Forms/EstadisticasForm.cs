using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaAppUDB.Servicios;

namespace BibliotecaAppUDB.Forms
{
    public partial class EstadisticasForm : Form
    {
        BibliotecaService biblioteca;

        public EstadisticasForm(BibliotecaService servicio)
        {
            InitializeComponent();
            biblioteca = servicio;
            this.Load += EstadisticasForm_Load;
        }

        private void EstadisticasForm_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            dgvEstadisticas.Rows.Clear();

            foreach (var libro in biblioteca.Libros)
            {
                int cantidad = biblioteca.Prestamos.Count(p => p.Libro.Id == libro.Id);

                dgvEstadisticas.Rows.Add(libro.Titulo, cantidad);
            }
        }

        private void EstadisticasForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}