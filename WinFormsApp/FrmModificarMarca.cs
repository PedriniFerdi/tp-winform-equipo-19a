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
    public partial class FrmModificarMarca : Form
    {
        private Marca marca = null;
        public FrmModificarMarca()
        {
            InitializeComponent();
        }

        public FrmModificarMarca(Marca seleccionado)
        {
            InitializeComponent();
            this.marca = seleccionado;
            this.Text = "Modificar Marca";
        }

        private void FrmModificarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                    txtNombre.Text = marca.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
               
                marca.Descripcion = txtNombre.Text;

               
                negocio.modificar(marca);

                MessageBox.Show("¡Marca modificada con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.ToString());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }


    }
}
