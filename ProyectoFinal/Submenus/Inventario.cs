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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }


        private void Inventario_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            dgvDatos.DataSource = bl.ObtenerTodosLosInventarios();
        }


        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si el campo de ID está vacío antes de intentar asignar un valor
            if (string.IsNullOrEmpty(TxtID.Text))
            {
                string id = TxtID.Text;
                string cantidad = TxtCantidad.Text;
                string nombre = TxtNombre.Text;
                string precio = TxtPrecio.Text;
                string descuento = TxtDescuento.Text;
                string descripcion = TxtDescripcion.Text;
                string marca = TxtMarca.Text;

                // Verificar que los campos no estén en blanco
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(cantidad) && !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(descuento) && !string.IsNullOrEmpty(descripcion) && !string.IsNullOrEmpty(marca))
                {
                    BLTienda tienda = new BLTienda();
                    tienda.AgregarInventario(cantidad, nombre, precio, descuento, descripcion, marca);

                    // Actualizar el DataGridView después de agregar un inventario
                    DataTable dtProveedores = tienda.ObtenerTodosLosInventarios();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de agregar un inventario
                    TxtID.Text = "";
                    TxtCantidad.Text = "";
                    TxtNombre.Text = "";
                    TxtPrecio.Text = "";
                    TxtDescuento.Text = "";
                    TxtDescripcion.Text = "";
                    TxtMarca.Text = "";

                    // Mostrar mensaje informativo sobre la asignación automática del ID
                    MessageBox.Show("Inventario agregado correctamente. El ID se asigna automáticamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje indicando que tanto el nombre como la dirección deben ser ingresados
                    MessageBox.Show("Por favor, ingrese todos los campos para el inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Mostrar un mensaje indicando que el ID se asigna automáticamente y no debe ser ingresado por el usuario
                MessageBox.Show("El ID se asigna automáticamente. Por favor, deje el campo ID vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id))
            {
                BLTienda tienda = new BLTienda();
                DataRow proveedor = tienda.ObtenerInventarioPorID(id);

                if (proveedor != null)
                {
                    // Rellenar los campos con los datos del proveedor
                    TxtCantidad.Text = proveedor["Cantidad"].ToString();
                    TxtNombre.Text = proveedor["Nombre"].ToString();
                    TxtPrecio.Text = proveedor["Precio"].ToString();
                    TxtDescuento.Text = proveedor["Descuento"].ToString();
                    TxtDescripcion.Text = proveedor["Descripcion"].ToString();
                    TxtMarca.Text = proveedor["Marca"].ToString();
                }
                else
                {
                    MessageBox.Show("Inventario no encontrado para el ID proporcionado.");
                }


            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para cargar el Inventario.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id))
            {
                BLTienda tienda = new BLTienda();

                // Verificar si el ID existe antes de intentar eliminarlo
                if (tienda.ExisteInventario(id))
                {
                    tienda.EliminarInvenario(id);

                    // Actualizar el DataGridView después de eliminar un proveedor
                    DataTable dtProveedores = tienda.ObtenerTodosLosInventarios();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de agregar un proveedor

                    TxtID.Text = "";
                    TxtCantidad.Text = "";
                    TxtNombre.Text = "";
                    TxtPrecio.Text = "";
                    TxtDescuento.Text = "";
                    TxtDescripcion.Text = "";
                    TxtMarca.Text = "";

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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //
            if (int.TryParse(TxtID.Text, out int id) && !string.IsNullOrEmpty(TxtCantidad.Text) && !string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtPrecio.Text) && !string.IsNullOrEmpty(TxtDescuento.Text) && !string.IsNullOrEmpty(TxtDescripcion.Text) && !string.IsNullOrEmpty(TxtMarca.Text))
            {
                // Verificar si el proveedor con el ID dado existe antes de intentar modificarlo
                BLTienda tienda = new BLTienda();
                if (tienda.ExisteInventario(id))
                {
                    string cantidad = TxtCantidad.Text;
                    string nombre = TxtNombre.Text;
                    string precio = TxtPrecio.Text;
                    string descuento = TxtDescuento.Text;
                    string descripcion = TxtDescripcion.Text;
                    string marca = TxtMarca.Text;

                    tienda.ModificarInventario(id,cantidad, nombre, precio, descuento, descripcion, marca);

                    // Actualizar el DataGridView después de modificar un proveedor
                    DataTable dtProveedores = tienda.ObtenerTodosLosInventarios();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de modificar un proveedor
                    TxtID.Text = "";
                    TxtCantidad.Text = "";
                    TxtNombre.Text = "";
                    TxtPrecio.Text = "";
                    TxtDescuento.Text = "";
                    TxtDescripcion.Text = "";
                    TxtMarca.Text = "";

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Inventario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El Inventario con el ID proporcionado no existe. Ingresa un ID válido para modificar el Inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido, nombre y dirección para modificar el Inventario.");
            }
        }

        private void dgvDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 1)
            {
                TxtID.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells[0].Value.ToString();
                BtnCargar_Click(sender, e);
            }
        }
    }
}
