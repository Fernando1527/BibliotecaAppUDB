using BibliotecaAppUDB.Forms;
using BibliotecaAppUDB.Servicios;
namespace BibliotecaAppUDB

{
    public partial class MainForm : Form
    {
        BibliotecaService biblioteca = new BibliotecaService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            LibrosForm libros = new LibrosForm(biblioteca);
            libros.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosForm form = new UsuariosForm(biblioteca);
            form.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PrestamosForm prestamos = new PrestamosForm(biblioteca);
            prestamos.ShowDialog();
        }
    }
}
