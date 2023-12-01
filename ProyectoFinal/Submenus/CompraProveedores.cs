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
    public partial class CompraProveedores : Form
    {
        public CompraProveedores()
        {
            InitializeComponent();
        }

        private void CompraProveedores_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            dgvDatos.DataSource = bl.ObtenerCompraProvedores();
        }

        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si el campo de ID está vacío antes de intentar asignar un valor
            if (string.IsNullOrEmpty(TxtID.Text))
            {
                string id = TxtID.Text;
                string idproducto = TxtIdProducto.Text;
                string idprovedor = TxtIdProveedor.Text;
                string cantidad = TxtCantidad.Text;
                string costo = TxtCosto.Text;

                // Verificar que los campos no estén en blanco
                if (!string.IsNullOrEmpty(idproducto) && !string.IsNullOrEmpty(idprovedor) && !string.IsNullOrEmpty(cantidad) && !string.IsNullOrEmpty(costo))
                {
                    BLTienda tienda = new BLTienda();
                    tienda.AgregarCompraProvedor(idproducto, idprovedor, cantidad, costo);

                    // Actualizar el DataGridView después de agregar un inventario
                    DataTable dtProveedores = tienda.ObtenerCompraProvedores();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de agregar un inventario
                    TxtID.Text = "";
                    TxtIdProducto.Text = "";
                    TxtIdProveedor.Text = "";
                    TxtCantidad.Text = "";
                    TxtCosto.Text = "";

                    // Mostrar mensaje informativo sobre la asignación automática del ID
                    MessageBox.Show("Compra agregado correctamente. El ID se asigna automáticamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar un mensaje indicando que tanto el nombre como la dirección deben ser ingresados
                    MessageBox.Show("Por favor, ingrese todos los campos para la compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                DataRow proveedor = tienda.ObtenerDetalleCompraPorID(id);

                if (proveedor != null)
                {
                    // Rellenar los campos con los datos del proveedor
                    TxtIdProveedor.Text = proveedor["IdProveedores"].ToString();
                    TxtIdProducto.Text = proveedor["IdProducto"].ToString();
                    TxtCantidad.Text = proveedor["Cantidad"].ToString();
                    TxtCosto.Text = proveedor["Costo"].ToString();
                }
                else
                {
                    MessageBox.Show("Compra no encontrado para el ID proporcionado.");
                }


            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para cargar el Inventario.");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int id))
            {
                BLTienda tienda = new BLTienda();

                // Verificar si el ID existe antes de intentar eliminarlo
                if (tienda.ExisteDetalleProveedor(id))
                {
                    tienda.EliminarCompraProvedor(id);

                    // Actualizar el DataGridView después de eliminar un proveedor
                    DataTable dtProveedores = tienda.ObtenerCompraProvedores();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de agregar un proveedor

                    TxtID.Text = "";
                    TxtIdProducto.Text = "";
                    TxtIdProveedor.Text = "";
                    TxtCantidad.Text = "";
                    TxtCosto.Text = "";

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Compra eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido que exista en la base de datos para eliminar la Compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para eliminar la Compra.");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //
            if (int.TryParse(TxtID.Text, out int id) && !string.IsNullOrEmpty(TxtIdProducto.Text) && !string.IsNullOrEmpty(TxtIdProveedor.Text) && !string.IsNullOrEmpty(TxtCosto.Text) && !string.IsNullOrEmpty(TxtCantidad.Text))
            {
                // Verificar si el proveedor con el ID dado existe antes de intentar modificarlo
                BLTienda tienda = new BLTienda();
                if (tienda.ExisteDetalleProveedor(id))
                {
                    string iddetalle = TxtID.Text;
                    string idproducto = TxtIdProducto.Text;
                    string idprovedor = TxtIdProveedor.Text;
                    string cantidad = TxtCantidad.Text;
                    string costo = TxtCosto.Text;

                    tienda.ModificarCompraProveedor(iddetalle, idproducto, idprovedor, cantidad, costo);

                    // Actualizar el DataGridView después de modificar un proveedor
                    DataTable dtProveedores = tienda.ObtenerCompraProvedores();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de modificar un proveedor
                    TxtID.Text = "";
                    TxtIdProducto.Text = "";
                    TxtIdProveedor.Text = "";
                    TxtCantidad.Text = "";
                    TxtCosto.Text = "";

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Compra modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El Compra con el ID proporcionado no existe. Ingresa un ID válido para modificar la Compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido, nombre y dirección para modificar la Compra.");
            }
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

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }
}
    