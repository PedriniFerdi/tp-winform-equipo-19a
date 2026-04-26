using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp
{
    public partial class FrmModificarCategoria : Form
    {
        public FrmModificarCategoria()
        {
            InitializeComponent();
        }

        private void FrmModificarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
                txtNombre.Text = categoria.Descripcion;
        }

        private Categoria categoria = null;


        public FrmModificarCategoria(Categoria seleccionado)
        {
            InitializeComponent();
            this.categoria = seleccionado;
            this.Text = "Modificar Categoría";
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {

                categoria.Descripcion = txtNombre.Text;


                negocio.modificar(categoria);

                MessageBox.Show("¡Modificado correctamente!");
               this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error: " + ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
