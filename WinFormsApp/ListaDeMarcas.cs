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
    public partial class ListaDeMarcas : Form
    {
        private List<Marca> listaMarcas = new List<Marca>();

        public ListaDeMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreMarca.Text))
            {
                MessageBox.Show("Por favor, escribí el nombre de la marca.");
                return;
            }


            Marca nueva = new Marca();
            nueva.Id = listaMarcas.Count + 1;
            nueva.Descripcion = txtNombreMarca.Text;


            listaMarcas.Add(nueva);


            txtNombreMarca.Clear();


            refrescarGrid();

        }

        private void ListaDeMarcas_Load(object sender, EventArgs e)
        {

            listaMarcas.Add(new Marca { Id = 1, Descripcion = "prueba" });



            refrescarGrid();
        }

        private void refrescarGrid()
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaMarcas;

           
            if (dgvMarcas.Columns["Id"] != null)
                dgvMarcas.Columns["Id"].Visible = false;

            if (dgvMarcas.Columns["Descripcion"] != null)
                dgvMarcas.Columns["Descripcion"].HeaderText = "Nombre de la Marca";
        }





        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
