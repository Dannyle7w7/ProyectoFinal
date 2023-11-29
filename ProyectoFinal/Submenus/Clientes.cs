using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Submenus.Trabajadores
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

            txtNumExt.KeyPress += TextBoxNumerico_KeyPress;
            txtNumInt.KeyPress += TextBoxNumerico_KeyPress;
            txtCP.KeyPress += TextBoxNumerico_KeyPress;
            txtTelefono.KeyPress += TextBoxNumerico_KeyPress;
        }

        private void TextBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite la entrada del carácter
            }
        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            BLTienda tienda = new BLTienda();
            DataTable dtClientes = tienda.ObtenerClientes();

            // Asigna el DataTable al DataSource del DataGridView
            dgvDatos.DataSource = dtClientes;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtID.Text))
    {
        string nombre = txtNombre.Text;
        string direccion = txtRfc.Text;
        string RazonSocial = txtRaSocial.Text;
        string Calle = txtCalle.Text;
        string NumeroExterior = txtNumExt.Text;
        string NumeroInterior = txtNumInt.Text;  // Campo que puede estar vacío
        string Colonia = txtColonia.Text;
        string Municipio = txtMunicipio.Text;
        string CP = txtCP.Text;
        string Estado = txtEstado.Text;
        string RegimenFiscal = txtRegimenFiscal.Text;
        string CFDI = txtCFDI.Text;
        string Telefono = txtTelefono.Text;
        string Correo = txtCorreo.Text;

        // Verificar que tanto el nombre como la dirección no estén en blanco
        if (nombre.Length != 0 && direccion.Length != 0 && RazonSocial.Length != 0 && Calle.Length != 0 && NumeroExterior.Length != 0 && Colonia.Length != 0 && Municipio.Length != 0 && CP.Length != 0 && Estado.Length != 0 && RegimenFiscal.Length != 0)
        {
            BLTienda tienda = new BLTienda();
            tienda.GuardarCliente(nombre, direccion, RazonSocial, Calle, NumeroExterior, NumeroInterior, Colonia, Municipio, CP, CFDI, Estado, RegimenFiscal, Telefono, Correo);

            // Actualizar el DataGridView después de agregar un proveedor
            DataTable dtClientes = tienda.ObtenerClientes();
            dgvDatos.DataSource = dtClientes;

            // Limpiar los TextBox después de agregar un proveedor
            TxtID.Text = "";
            txtNombre.Text = "";
            txtRfc.Text = "";
            txtRaSocial.Text = "";
            txtCalle.Text = "";
            txtNumExt.Text = "";
            txtNumInt.Text = "";
            txtColonia.Text = "";
            txtMunicipio.Text = "";
            txtCP.Text = "";
            txtEstado.Text = "";
            txtRegimenFiscal.Text = "";
            txtCFDI.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            // Mostrar mensaje informativo sobre la asignación automática del ID
            MessageBox.Show("Cliente agregado correctamente. El ID se asigna automáticamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Mostrar un mensaje indicando que tanto el nombre como la dirección deben ser ingresados
            MessageBox.Show("Por favor, ingrese datos correctos en clientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    else
    {
        // Mostrar un mensaje indicando que el ID se asigna automáticamente y no debe ser ingresado por el usuario
        MessageBox.Show("El ID se asigna automáticamente. Por favor, deje el campo ID vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
        }

        private void Button2_Click(object sender, EventArgs e)
            {
                if (int.TryParse(TxtID.Text, out int id))
                {
                    BLTienda tienda = new BLTienda();

                    // Verificar si el ID existe antes de intentar eliminarlo
                    if (tienda.ExisteCliente(id))
                    {
                        tienda.EliminarCliente(id);

                        // Actualizar el DataGridView después de eliminar un proveedor
                        DataTable dtClientes = tienda.ObtenerClientes();
                        dgvDatos.DataSource = dtClientes;

                    // Limpiar los TextBox después de agregar un proveedor
                    TxtID.Text = "";
                    txtNombre.Text = "";
                    txtRfc.Text = "";
                    txtRaSocial.Text = "";
                    txtCalle.Text = "";
                    txtNumExt.Text = "";
                    txtNumInt.Text = "";
                    txtColonia.Text = "";
                    txtMunicipio.Text = "";
                    txtCP.Text = "";
                    txtEstado.Text = "";
                    txtRegimenFiscal.Text = "";
                    txtCFDI.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingresa un ID válido que exista en la base de datos para eliminar el Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido para eliminar el Cliente.");
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int idClientes))
            {
                // Verificar si el cliente con el ID dado existe antes de intentar modificarlo
                BLTienda tienda = new BLTienda();
                if (tienda.ExisteCliente(idClientes))
                {
                    // Obtener los datos actuales del cliente
                    DataRow clienteActual = tienda.ObtenerClientePorId(idClientes);

                    // Verificar si se encontró el cliente
                    if (clienteActual != null)
                    {
                        // Obtener los valores actuales
                        string nombreActual = clienteActual["Nombre"].ToString();
                        string rfcActual = clienteActual["RFC"].ToString();
                        string razonSocialActual = clienteActual["Razon Social"].ToString();
                        string calleActual = clienteActual["Calle"].ToString();
                        string numeroExtActual = clienteActual["NumExt"].ToString();
                        string numeroIntActual = clienteActual["NumInt"].ToString();
                        string coloniaActual = clienteActual["Colonia"].ToString();
                        string municipioActual = clienteActual["Municipio"].ToString();
                        string cpActual = clienteActual["Codigo Postal"].ToString();
                        string estadoActual = clienteActual["Estado"].ToString();
                        string regimenFiscalActual = clienteActual["Regimen Fiscal"].ToString();
                        string cfdiActual = clienteActual["Uso de CFDI"].ToString();
                        string telefonoActual = clienteActual["Telefono"].ToString();
                        string correoActual = clienteActual["Correo"].ToString();

                        // Obtener los nuevos datos de los TextBox
                        string nuevoNombre = string.IsNullOrEmpty(txtNombre.Text) ? nombreActual : txtNombre.Text;
                        string nuevoRFC = string.IsNullOrEmpty(txtRfc.Text) ? rfcActual : txtRfc.Text;
                        string nuevaRazonSocial = string.IsNullOrEmpty(txtRaSocial.Text) ? razonSocialActual : txtRaSocial.Text;
                        string nuevaCalle = string.IsNullOrEmpty(txtCalle.Text) ? calleActual : txtCalle.Text;
                        string nuevoNumeroExt = string.IsNullOrEmpty(txtNumExt.Text) ? numeroExtActual : txtNumExt.Text;
                        string nuevoNumeroInt = string.IsNullOrEmpty(txtNumInt.Text) ? numeroIntActual : txtNumInt.Text;
                        string nuevaColonia = string.IsNullOrEmpty(txtColonia.Text) ? coloniaActual : txtColonia.Text;
                        string nuevoMunicipio = string.IsNullOrEmpty(txtMunicipio.Text) ? municipioActual : txtMunicipio.Text;
                        string nuevoCP = string.IsNullOrEmpty(txtCP.Text) ? cpActual : txtCP.Text;
                        string nuevoEstado = string.IsNullOrEmpty(txtEstado.Text) ? estadoActual : txtEstado.Text;
                        string nuevoRegimenFiscal = string.IsNullOrEmpty(txtRegimenFiscal.Text) ? regimenFiscalActual : txtRegimenFiscal.Text;
                        string nuevoCFDI = string.IsNullOrEmpty(txtCFDI.Text) ? cfdiActual : txtCFDI.Text;
                        string nuevoTelefono = string.IsNullOrEmpty(txtTelefono.Text) ? telefonoActual : txtTelefono.Text;
                        string nuevoCorreo = string.IsNullOrEmpty(txtCorreo.Text) ? correoActual : txtCorreo.Text;

                        // Llamar al método para modificar el cliente
                        tienda.ModificarCliente(idClientes,nuevoNombre, nuevoRFC, nuevaRazonSocial, nuevaCalle, nuevoNumeroExt, nuevoNumeroInt,
                            nuevaColonia, nuevoMunicipio, nuevoCP, nuevoEstado, nuevoRegimenFiscal, nuevoCFDI, nuevoTelefono, nuevoCorreo);

                        // Actualizar el DataGridView después de modificar un cliente
                        DataTable dtClientes = tienda.ObtenerClientes();
                        dgvDatos.DataSource = dtClientes;

                        // Limpiar los TextBox después de modificar un cliente
                        TxtID.Text = "";
                        txtNombre.Text = "";
                        txtRfc.Text = "";
                        txtRaSocial.Text = "";
                        txtCalle.Text = "";
                        txtNumExt.Text = "";
                        txtNumInt.Text = "";
                        txtColonia.Text = "";
                        txtMunicipio.Text = "";
                        txtCP.Text = "";
                        txtEstado.Text = "";
                        txtRegimenFiscal.Text = "";
                        txtCFDI.Text = "";
                        txtTelefono.Text = "";
                        txtCorreo.Text = "";

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Cliente modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre el cliente
                        MessageBox.Show("No se pudo obtener la información del cliente. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El cliente con el ID proporcionado no existe. Ingresa un ID válido para modificar el cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para modificar el cliente.");
            }
        }

        private void txtNumExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

