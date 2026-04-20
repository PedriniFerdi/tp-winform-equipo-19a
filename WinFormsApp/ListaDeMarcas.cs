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
using Negocio;

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

            if (string.IsNullOrWhiteSpace(txtNombreMarca.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }


            if (string.IsNullOrEmpty(txtNombreMarca.Text))
            {
                MessageBox.Show("Por favor, escribi el nombre de la marca.");
                return;
            }

            Marca nueva = new Marca();
            nueva.Descripcion = txtNombreMarca.Text;


            MarcaNegocio negocio = new MarcaNegocio();
            try
            {

               // negocio.agregar(nueva);

                MessageBox.Show("Marca guardada exitosamente!");

                txtNombreMarca.Clear();
                refrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Marca no se ha podido guardar: " + ex.Message);
            }

   

        }

        private void ListaDeMarcas_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }


        private void refrescarGrid()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {

                listaMarcas = negocio.Listar();
                dgvMarcas.DataSource = listaMarcas;
                configurarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.ToString());
            }
        }


        private void configurarGrilla()
        {
            if (dgvMarcas.Columns["Id"] != null)
                dgvMarcas.Columns["Id"].Visible = false;

            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.ReadOnly = true;
        }




        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreMarca.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }


            if (dgvMarcas.SelectedRows == null)
            {
                MessageBox.Show("selecciona una marca para modificar");
                return;
            }
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            //txtNombreMarca.Text = seleccionado.Descripcion;

            MarcaNegocio negocio = new MarcaNegocio();

            try
            {

                //seleccionado.Descripcion =txtNombreMarca.Text;
                //negocio.modificar(seleccionado);

                MessageBox.Show("Marca modificada exitosamente!");
                refrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La marca ingresada no se ha podido modificar;" + ex.ToString());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("selecciona una marca para eliminar");
                return;
            }
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show
                    ("Estas seguro de eliminar esta marca:" + seleccionado.Descripcion + "?",
                    "Confirmar eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning

                    );

                if(respuesta == DialogResult.Yes)
                {
                    //Negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Marca eliminada correctamente!");
                    refrescarGrid();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar la marca :" + ex.Message);
            }

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMarcas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
