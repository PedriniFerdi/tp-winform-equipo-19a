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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void DgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            List<Categoria> listaPrueba = new List<Categoria>();
            listaPrueba.Add(new Categoria { Id = 1, Descripcion = "prueba" });
            listaPrueba.Add(new Categoria { Id = 2, Descripcion = "prueba 2" });
            listaPrueba.Add(new Categoria { Id = 3, Descripcion = "prueba 3" });
            listaPrueba.Add(new Categoria { Id = 4, Descripcion = "prueba 4" });
            listaPrueba.Add(new Categoria { Id = 5, Descripcion = "prueba 5" });
            listaPrueba.Add(new Categoria { Id = 6, Descripcion = "prueba 6" });
            listaPrueba.Add(new Categoria { Id = 7, Descripcion = "prueba 7" });

            DgvCategorias.DataSource = listaPrueba;

            DgvCategorias.Columns["Id"].Visible = true;
            DgvCategorias.Columns["Descripcion"].HeaderText = "Nombre de la Categoria";
        }
    }
}
