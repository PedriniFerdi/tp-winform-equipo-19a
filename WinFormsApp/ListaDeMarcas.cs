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
        public ListaDeMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // frmAltaMarca alta = new frmAltaMarca();

            //  alta.ShowDialog();
        }

        private void ListaDeMarcas_Load(object sender, EventArgs e)
        {

            List<Marca> listaPrueba = new List<Marca>();
            listaPrueba.Add(new Marca { Id = 1, Descripcion = "prueba" });
            listaPrueba.Add(new Marca { Id = 2, Descripcion = "prueba 2" });
            listaPrueba.Add(new Marca { Id = 3, Descripcion = "prueba 3" });
            listaPrueba.Add(new Marca { Id = 4, Descripcion = "prueba 4" });
            listaPrueba.Add(new Marca { Id = 5, Descripcion = "prueba 5" });
            listaPrueba.Add(new Marca { Id = 6, Descripcion = "prueba 6" });
            listaPrueba.Add(new Marca { Id = 7, Descripcion = "prueba 7" });

            dgvMarcas.DataSource = listaPrueba;

            dgvMarcas.Columns["Id"].Visible = false;
            dgvMarcas.Columns["Descripcion"].HeaderText = "Nombre de la Marca";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
