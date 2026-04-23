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
    public partial class frmAgregarImagen : Form
    {
        public List<Imagen> listaImagen = new List<Imagen>();
        public List<Imagen> listaImagen2 = new List<Imagen>();
        public Articulo articulo = new Articulo();
        public bool modificar = false;
        public frmAgregarImagen()
        {
            InitializeComponent();
        }
        public frmAgregarImagen(Articulo articuloEntrante, bool modificarEntrante)
        {

            modificar = modificarEntrante;
            articulo = articuloEntrante;

            InitializeComponent();

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MemoriaArticulo.Instance().ReinicarMemoria();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ImagenUrl = txtUrl.Text;
            Imagen imagen = new Imagen();
          
            imagen.ImagenUrl = ImagenUrl;

            listaImagen2.Add(imagen);

            articulo.Imagenes = listaImagen2;
            MemoriaArticulo.Instance().Articulo = articulo;

            MessageBox.Show("Imagen agregada con exito");
            txtUrl.Text = "";
            cargaDataGridView();
        }
        public void cargaDataGridView()
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();


            if (modificar)
            {
                listaImagen = imagenNegocio.ListarPorIdArticulo(articulo.Id);
                dgvAgregarImg.DataSource = listaImagen;

            }
            else
            {
                listaImagen = imagenNegocio.Listar();
                dgvAgregarImg.DataSource = MemoriaArticulo.Instance().Articulo.Imagenes;
            }

        }

        private void dgvAgregarImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAgregarImg.CurrentRow != null)
            {
                Imagen seleccionado = (Imagen)dgvAgregarImg.CurrentRow.DataBoundItem;

                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void cargarImagen(string Urlimagen)
        {
            try
            {

                pbxAgregarImg.Load(Urlimagen);

                return;

            }
            catch (Exception)
            {
                pbxAgregarImg.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;

            }


        }
    }
}
