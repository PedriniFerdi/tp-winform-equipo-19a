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
    public partial class frmSobreescribirUrl : Form
    {
        public Articulo articulo { get; set; } = new Articulo();
        public Imagen imagenSeleccionada { get; set; } = new Imagen();

        public frmSobreescribirUrl()
        {
            InitializeComponent();
        }
        public frmSobreescribirUrl(Articulo articuloEntrante, Imagen ImagenSeleccionadaEntrante)
        {
            articulo = articuloEntrante;
            imagenSeleccionada = ImagenSeleccionadaEntrante;
            InitializeComponent();
        }

        private void btnSobreescribirUrl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSobreescribirUrl.Text))
            {
                MessageBox.Show("Ingresa una URL valida.");
                return;
            }

            try
            {
                string ImagenUrl = txtSobreescribirUrl.Text.Trim();
                var imagenNegocio = new ImagenNegocio();
                var imagen = new Imagen { ImagenUrl = ImagenUrl };

                imagenNegocio.EliminarImagen(imagenSeleccionada, articulo.Id);
                imagenNegocio.AgregarImagen(imagen, articulo.Id);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la imagen: " + ex.Message);
            }
        }
    }
}
