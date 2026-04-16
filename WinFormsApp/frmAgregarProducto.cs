
using Dominio;
using System.ComponentModel;



namespace WinFormsApp
{
    public partial class frmAgregarProducto : Form
    {

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public Articulo Articulo { get; set; } = new Articulo();
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public List<Imagen> ImagenesBuffer { get; set; } = new List<Imagen>();
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public Imagen imagen { get; set; } = new Imagen();
        //public bool modificar = false;

        //public static frmAgregarIMG instance;

        //public frmAgregarProducto()
        //{
        //    InitializeComponent();
        //}


        //public frmAgregarProducto(Articulo articulo, bool modificar)
        //{
        //    InitializeComponent();
        //    this.Articulo = articulo;
        //    this.modificar = modificar;
        //    Text = "Modificar Articulo";
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    ArticuloService articuloService = new ArticuloService();
        //    Articulo articulo = new Articulo();

        //    try
        //    {
        //        if (!ValidarCamposObligatorios())
        //        {
        //            MessageBox.Show("Todos los campos son obligatorios y no pueden contener solo espacios.");
        //            return;
        //        }

        //        if (!decimal.TryParse(textPrecio.Text, out decimal precio) || precio < 0)
        //        {
        //            MessageBox.Show("Ingrese un precio válido.");
        //            return;
        //        }

        //        articulo.CodigoArticulo = textCodigo.Text.Trim();
        //        articulo.Nombre = textNombre.Text.Trim();
        //        articulo.Descripcion = textDescripcion.Text.Trim();
        //        articulo.Precio = precio;
        //        articulo.Marca = (Marca)cbMarca.SelectedItem;
        //        articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
        //        articulo.Imagenes = MemoriaArticulo.Instance().Articulo.Imagenes;

        //        if (modificar)
        //        {
        //            articulo.Id = this.Articulo.Id;
        //            articuloService.modificar(articulo);
        //            MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
        //        }
        //        else
        //        {
        //            int idArt = articuloService.agregarProducto(articulo);
        //            MessageBox.Show("PRODUCTO AGREGADO CON ÉXITO");
        //            MemoriaArticulo.Instance().ReinicarMemoria();
        //        }

        //        Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ocurrió un error: {ex.Message}");
        //    }
        //}
        //private bool ValidarCamposObligatorios()
        //{
        //    return !string.IsNullOrWhiteSpace(textCodigo.Text) &&
        //           !string.IsNullOrWhiteSpace(textNombre.Text) &&
        //           !string.IsNullOrWhiteSpace(textDescripcion.Text) &&
        //           cbMarca.SelectedItem != null &&
        //           cbCategoria.SelectedItem != null;
        //}

    }
}
