using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmCategorias : Form
    {

        private List<Categoria> listaCategorias = new List<Categoria>();


        public FrmCategorias()
        {
            InitializeComponent();
            refrescarGrid();

            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnModificar.Click += new EventHandler(btnModificar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }



        private void refrescarGrid()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                listaCategorias = negocio.Listar();
                DgvCategorias.DataSource = listaCategorias;
                configurarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos" + ex.ToString());

            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show("Escribe un nombre para la Categoria");
            }

            
            Categoria nueva = new Categoria();
            nueva.Descripcion = txtNombreCategoria.Text;

            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                negocio.Agregar(nueva);
                MessageBox.Show("Categoria Guardada Exitosamente!");

                txtNombreCategoria.Clear();
                refrescarGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("La Categoria no se ha podido guardar:" + ex.Message);
            }
          

        }

        private void configurarGrilla()
        {

            if (DgvCategorias.Columns["Id"] != null)
                DgvCategorias.Columns["Id"].Visible = false;


            if (DgvCategorias.Columns["Descripcion"] != null)
                DgvCategorias.Columns["Descripcion"].HeaderText = "Nombre de la Categoría";

            DgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCategorias.ReadOnly = true;
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {



            if (DgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una categoria para modificar");
                return;
            }

           
            Categoria seleccionado = (Categoria)DgvCategorias.CurrentRow.DataBoundItem;
          

            FrmModificarCategoria ventanaModificar = new FrmModificarCategoria(seleccionado);
            ventanaModificar.ShowDialog();
            refrescarGrid();
            


        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (DgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una categoria para eliminar");
                return;
            }

            Categoria seleccionado = (Categoria)DgvCategorias.CurrentRow.DataBoundItem;
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show
                    ("Estas seguro de eliminar la categoria:" + seleccionado.Descripcion + "?",
                     "Confirmar Eliminacion " ,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                if (respuesta == DialogResult.Yes)
                {
                      negocio.Eliminar(seleccionado.Id);
                    MessageBox.Show("Categoria eliminada exitosamente!");
                    refrescarGrid();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar la categoria:" + ex.Message);

            }

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
         
            refrescarGrid();

        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
