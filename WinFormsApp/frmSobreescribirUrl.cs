using Dominio;
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
            /*
            string ImagenUrl = txtSobreescribirUrl.Text;
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Imagen imagen = new Imagen();

            imagen.ImagenUrl = ImagenUrl;
            imagenNegocio.eliminarImagen(imagenSeleccionada, articulo.Id);
            imagenNegocio.agregarImagen(imagen, articulo.Id);
            this.Close();
            */
        }
    }
}
