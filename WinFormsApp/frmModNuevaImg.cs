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
            if (string.IsNullOrWhiteSpace(txtUrlNuevaIMG.Text))
            {
                MessageBox.Show("Ingresa una URL valida.");
                return;
            }

            try
            {
                string ImagenUrl = txtUrlNuevaIMG.Text.Trim();
                var imagenNegocio = new ImagenNegocio();
                var imagen = new Imagen { ImagenUrl = ImagenUrl };

                imagenNegocio.AgregarImagen(imagen, articulo.Id);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la imagen: " + ex.Message);
            }
        }
    }
}
