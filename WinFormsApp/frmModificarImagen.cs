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
    public partial class frmModificarImagen : Form
    {
        public Articulo articulo { get; set; } = new Articulo();
        public List<Imagen> imagenesAmodificar { get; set; } = new List<Imagen>();
        public Imagen imagen { get; set; } = new Imagen();
        bool modificar = false;
        public frmModificarImagen()
        {
            InitializeComponent();
        }
        public frmModificarImagen(Articulo articulo, bool modificar)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.modificar = modificar;
            this.imagen = imagen;

        }

        private void frmModificarImagen_Load(object sender, EventArgs e)
        {
            cargaDGVmodificarIMG();
        }
        public void cargaDGVmodificarIMG()
        {
            if (articulo.Id <= 0)
            {
                dgvModificarImg.DataSource = imagenesAmodificar;
                return;
            }

            var imagenNegocio = new ImagenNegocio();
            imagenesAmodificar = imagenNegocio.ListarPorIdArticulo(articulo.Id);
            dgvModificarImg.DataSource = null;
            dgvModificarImg.DataSource = imagenesAmodificar;
        }
        private void cargarImagen(string Urlimagen)
        {
            try
            {

                pbxModificarImg.Load(Urlimagen);

                return;

            }
            catch (Exception)
            {
                pbxModificarImg.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;

            }
        }

        private void dgvModificarImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModificarImg.CurrentRow != null)
            {
                Imagen seleccionada = (Imagen)dgvModificarImg.CurrentRow.DataBoundItem;

                cargarImagen(seleccionada.ImagenUrl);
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            frmModNuevaImg frmModNuevaImg = new frmModNuevaImg(articulo);
            frmModNuevaImg.ShowDialog();
            cargaDGVmodificarIMG();
        }

        private void btnModificarImg_Click(object sender, EventArgs e)
        {
            if (dgvModificarImg.CurrentRow?.DataBoundItem is not Imagen ImagenSeleccionada)
            {
                MessageBox.Show("Selecciona una imagen de la lista.");
                return;
            }

            using var dlg = new frmSobreescribirUrl(articulo, ImagenSeleccionada);
            dlg.ShowDialog();
            cargaDGVmodificarIMG();
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            if (dgvModificarImg.CurrentRow?.DataBoundItem is not Imagen imagenSeleccionada)
            {
                MessageBox.Show("Selecciona una imagen de la lista.");
                return;
            }

            if (MessageBox.Show("Eliminar esta imagen?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                var imagenNegocio = new ImagenNegocio();
                imagenNegocio.EliminarImagen(imagenSeleccionada, articulo.Id);
                cargaDGVmodificarIMG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la imagen: " + ex.Message);
            }
        }
    }
}
