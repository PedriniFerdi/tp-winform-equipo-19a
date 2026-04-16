using Dominio;
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
        }



        private void refrescarGrid()
        {
            DgvCategorias.DataSource = null;
            DgvCategorias.DataSource = listaCategorias;

            if (DgvCategorias.Columns["Id"] != null)
                DgvCategorias.Columns["Id"].Visible = false;

            if (DgvCategorias.Columns["Descripcion"] != null)
                DgvCategorias.Columns["Descripcion"].HeaderText = "Nombre de la Categoria";
        }


        private void DgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show("Escribe un nombre para la Categoria");
            }


            Categoria nueva = new Categoria();
            nueva.Id = listaCategorias.Count + 1;
            nueva.Descripcion = txtNombreCategoria.Text;

            listaCategorias.Add(nueva);

            txtNombreCategoria.Clear();
            refrescarGrid();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

            listaCategorias.Add(new Categoria { Id = 1, Descripcion = "prueba" });

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
