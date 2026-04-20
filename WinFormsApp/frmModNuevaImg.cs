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
    public partial class frmModNuevaImg : Form
    {
        public Articulo articulo { get; set; } = new Articulo();
        public frmModNuevaImg()
        {
            InitializeComponent();
        }
        public frmModNuevaImg(Articulo articuloEntrante)
        {
            articulo = articuloEntrante;
            InitializeComponent();
        }

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {
            /*
            string ImagenUrl = txtUrlNuevaIMG.Text;
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Imagen imagen = new Imagen();

            imagen.ImagenUrl = ImagenUrl;
            imagenNegocio.agregarImagen(imagen, articulo.Id);
            this.Close();
            */
        }
    }
}
