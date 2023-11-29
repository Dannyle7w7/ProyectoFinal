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
                string idproducto = CmbIdProducto.Text;
                string idprovedor = CmbIdProvedor.Text;
                string cantidad = TxtCantidad.Text;
                string costo = TxtCosto.Text;

                // Verificar que los campos no estén en blanco
                if (!string.IsNullOrEmpty(idproducto) && !string.IsNullOrEmpty(idprovedor) && !string.IsNullOrEmpty(cantidad) && !string.IsNullOrEmpty(costo))
                {
                    BLTienda tienda = new BLTienda();
                    //tienda.AgregarCompra(idproducto, idprovedor, cantidad, costo);

                    // Actualizar el DataGridView después de agregar un inventario
                    DataTable dtProveedores = tienda.ObtenerTodosLosInventarios();
                    dgvDatos.DataSource = dtProveedores;

                    // Limpiar los TextBox después de agregar un inventario
                    TxtID.Text = "";
                    TxtCantidad.Text = "";
                    TxtCosto.Text = "";

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

        }

        private void dgvDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

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
    