namespace WinFormsApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new ListaDeArticulos();
            f.ShowDialog(this);
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new ListaDeMarcas();
            f.ShowDialog(this);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new FrmCategorias();
            f.ShowDialog(this);
        }
    }
}
