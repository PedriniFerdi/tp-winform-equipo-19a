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
    public partial class ListaDeArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private int index = 0;
        public ListaDeArticulos()
        {
            InitializeComponent();
        }

        private void ListaDeArticulos_Load(object sender, EventArgs e)
        {
            cargaDataGrid();
            cbCampo.Items.Add("Codigo");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Descripcion");
        }
        public void cargaDataGrid()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            listaArticulos = articuloNegocio.Listar();
            dgvListaProd.DataSource = listaArticulos;
            ocultarColumnas();
            cargarImagen(listaArticulos[0].FirstImage());
        }

        private void dgvListaProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaProd.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.FirstImage());
            }
        }

        private void cargarImagen(string Urlimagen)
        {
            try
            {

                pbxArt.Load(Urlimagen);

                return;

            }
            catch (Exception)
            {
                pbxArt.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;

            }


        }

        private void ocultarColumnas()
        {
           dgvListaProd.Columns["Id"].Visible = false;

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarProducto alta = new frmAgregarProducto();
            alta.ShowDialog();
            int index = dgvListaProd.TabIndex;
            if (index == 0)
            {
                dgvListaProd.TabIndex++;
            }
            else
            {
                dgvListaProd.TabIndex--;
            }
            cargaDataGrid();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            bool modificar = true;

            Articulo seleccionado;
            seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;

            frmAgregarProducto frmmodificar = new frmAgregarProducto(seleccionado, modificar);

            frmmodificar.ShowDialog();
            cargaDataGrid();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.Trim().ToUpper();
            List<Articulo> listaFiltrada;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(y =>
                    y.CodigoArticulo.ToUpper().Contains(filtro) ||
                    y.Nombre.ToUpper().Contains(filtro) ||
                    y.Descripcion.ToUpper().Contains(filtro) ||
                    y.Categoria.Descripcion.ToUpper().Contains(filtro) ||
                    y.Marca.Descripcion.ToUpper().Contains(filtro) 
                );
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvListaProd.DataSource = null;
            dgvListaProd.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void pbxArt_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
            bool hayFoto = false;
            int cantidad = seleccionado.Imagenes.Count;
            Imagen UrlError = new Imagen();
            UrlError.ImagenUrl = "https://st2.depositphotos.com/1560768/6162/i/450/depositphotos_61621057-stock-photo-no-image-available.jpg";
            if (cantidad > 0)
            {
                hayFoto = true;
            }

            if (seleccionado.Imagenes.Count < index)
            {
                index = 0;
            }
            if (hayFoto && index < seleccionado.Imagenes.Count)
            {
                string segunda_imagen = seleccionado.Imagenes[index].ImagenUrl;
                cargarImagen(segunda_imagen);
            }
            else
            {
                cargarImagen(UrlError.ImagenUrl);
            }
            if (seleccionado.Imagenes.Count > index)
            {
                index++;

            }
            else
            {
                index = 0;
            }

            hayFoto = false;
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Codigo")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                if (cbCampo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un criterio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo filtro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

               dgvListaProd.DataSource = negocio.Fitrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargaDataGrid();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
                negocio.Eliminar(seleccionado.Id);
                negocio.EliminarImagenPorId(seleccionado.Id);
                cargaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
