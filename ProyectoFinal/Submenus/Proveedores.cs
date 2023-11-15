using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Submenus
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }


        private void Proveedores_Load(object sender, EventArgs e)
        {
            BLTienda tienda = new BLTienda();
            DataTable dtProveedores = tienda.ObtenerProveedores();

            // Asigna el DataTable al DataSource del DataGridView
            DgvProv.DataSource = dtProveedores;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string direccion = TxtDireccion.Text;

            BLTienda tienda = new BLTienda();
            tienda.AgregarProveedor(nombre, direccion);

            // Actualizar el DataGridView después de agregar un proveedor
            DataTable dtProveedores = tienda.ObtenerProveedores();
            DgvProv.DataSource = dtProveedores;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id))
            {
                BLTienda tienda = new BLTienda();
                tienda.EliminarProveedor(id);

                // Actualizar el DataGridView después de eliminar un proveedor
                DataTable dtProveedores = tienda.ObtenerProveedores();
                DgvProv.DataSource = dtProveedores;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para eliminar el proveedor.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id) && !string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtDireccion.Text))
            {
                string nombre = TxtNombre.Text;
                string direccion = TxtDireccion.Text;

                BLTienda tienda = new BLTienda();
                tienda.ModificarProveedor(id, nombre, direccion);

                // Actualizar el DataGridView después de modificar un proveedor
                DataTable dtProveedores = tienda.ObtenerProveedores();
                DgvProv.DataSource = dtProveedores;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido, nombre y dirección para modificar el proveedor.");
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id))
            {
                BLTienda tienda = new BLTienda();
                DataRow proveedor = tienda.ObtenerProveedorPorId(id);

                if (proveedor != null)
                {
                    // Rellenar los campos con los datos del proveedor
                    TxtNombre.Text = proveedor["Nombre"].ToString();
                    TxtDireccion.Text = proveedor["Dirrecion"].ToString();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado para el ID proporcionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para cargar el proveedor.");
            }
        }



        private void DgvDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DgvProv.SelectedRows.Count == 1)
            {
                TxtID.Text = DgvProv.Rows[DgvProv.SelectedRows[0].Index].Cells[0].Value.ToString();
                btnCargar_Click(sender, e);
            }
        }






        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
