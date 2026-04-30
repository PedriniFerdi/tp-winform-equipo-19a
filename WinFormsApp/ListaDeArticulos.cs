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
            actualizarContadorImagen(listaArticulos[0]);
        }

        private void dgvListaProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaProd.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
                index = 0;
                cargarImagen(seleccionado.FirstImage());
                actualizarContadorImagen(seleccionado);
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

        

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCampo.SelectedItem == null)
                return;

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

                if (MessageBox.Show("Esta seguro que desea eliminar el articulo de manera permanente?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                negocio.Eliminar(seleccionado.Id);
                negocio.EliminarImagenPorId(seleccionado.Id);
                cargaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            navegarImagen(-1);
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            navegarImagen(1);
        }
        private void navegarImagen(int direccion)
        {
            if (dgvListaProd.CurrentRow == null)
                return;

            Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
            Imagen UrlError = new Imagen();
            UrlError.ImagenUrl = "https://st2.depositphotos.com/1560768/6162/i/450/depositphotos_61621057-stock-photo-no-image-available.jpg";

            if (seleccionado.Imagenes.Count == 0)
            {
                cargarImagen(UrlError.ImagenUrl);
                actualizarContadorImagen(seleccionado);
                return;
            }


            index += direccion;
            if (index >= seleccionado.Imagenes.Count)
                index = 0;
            if (index < 0)
                index = seleccionado.Imagenes.Count - 1;

            cargarImagen(seleccionado.Imagenes[index].ImagenUrl);
            actualizarContadorImagen(seleccionado);
        }
        private void actualizarContadorImagen(Articulo articulo)
        {
           
            if (articulo.Imagenes.Count == 0)
            {
                label1.Text = "Imagen 0/0";
                return;
            }

            label1.Text = $"Imagen {index + 1}/{articulo.Imagenes.Count}";
        }
    }
}
