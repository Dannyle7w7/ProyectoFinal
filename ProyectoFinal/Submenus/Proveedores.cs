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
 // Verificar si el campo de ID está vacío antes de intentar asignar un valor
    if (string.IsNullOrEmpty(TxtID.Text))
    {
        string nombre = TxtNombre.Text;
        string direccion = TxtDireccion.Text;

        // Verificar que tanto el nombre como la dirección no estén en blanco
        if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion))
        {
            BLTienda tienda = new BLTienda();
            tienda.AgregarProveedor(nombre, direccion);

            // Actualizar el DataGridView después de agregar un proveedor
            DataTable dtProveedores = tienda.ObtenerProveedores();
            DgvProv.DataSource = dtProveedores;

            // Limpiar los TextBox después de agregar un proveedor
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";

            // Mostrar mensaje informativo sobre la asignación automática del ID
            MessageBox.Show("Proveedor agregado correctamente. El ID se asigna automáticamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Mostrar un mensaje indicando que tanto el nombre como la dirección deben ser ingresados
            MessageBox.Show("Por favor, ingrese un nombre y una dirección para el proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    else
    {
        // Mostrar un mensaje indicando que el ID se asigna automáticamente y no debe ser ingresado por el usuario
        MessageBox.Show("El ID se asigna automáticamente. Por favor, deje el campo ID vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id))
            {
                BLTienda tienda = new BLTienda();

                // Verificar si el ID existe antes de intentar eliminarlo
                if (tienda.ExisteProveedor(id))
                {
                    tienda.EliminarProveedor(id);

                    // Actualizar el DataGridView después de eliminar un proveedor
                    DataTable dtProveedores = tienda.ObtenerProveedores();
                    DgvProv.DataSource = dtProveedores;

                    // Limpiar los TextBox después de agregar un proveedor
                    TxtID.Text = "";
                    TxtNombre.Text = "";
                    TxtDireccion.Text = "";

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Proveedor eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido que exista en la base de datos para eliminar el proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                // Verificar si el proveedor con el ID dado existe antes de intentar modificarlo
                BLTienda tienda = new BLTienda();
                if (tienda.ExisteProveedor(id))
                {
                    string nombre = TxtNombre.Text;
                    string direccion = TxtDireccion.Text;

                    tienda.ModificarProveedor(id, nombre, direccion);

                    // Actualizar el DataGridView después de modificar un proveedor
                    DataTable dtProveedores = tienda.ObtenerProveedores();
                    DgvProv.DataSource = dtProveedores;

                    // Limpiar los TextBox después de modificar un proveedor
                    TxtID.Text = "";
                    TxtNombre.Text = "";
                    TxtDireccion.Text = "";

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Proveedor modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El proveedor con el ID proporcionado no existe. Ingresa un ID válido para modificar el proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
