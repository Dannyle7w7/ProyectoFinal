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
                string NumeroInterior = txtNumInt.Text;
                string Colonia = txtColonia.Text;
                string Municipio = txtMunicipio.Text;
                string CP = txtCP.Text;
                string Estado = txtEstado.Text;
                string RegimenFiscal = txtRegimenFiscal.Text;
                string CFDI = txtCFDI.Text;
                string Telefono = txtTelefono.Text;
                string Correo = txtCorreo.Text;

                // Verificar que tanto el nombre como la dirección no estén en blanco
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(RazonSocial) && !string.IsNullOrEmpty(Calle)&& !string.IsNullOrEmpty(Calle) && !string.IsNullOrEmpty(NumeroExterior) && !string.IsNullOrEmpty(NumeroInterior) && !string.IsNullOrEmpty(Colonia) && !string.IsNullOrEmpty(Municipio) && !string.IsNullOrEmpty(CP) && !string.IsNullOrEmpty(Estado) && !string.IsNullOrEmpty(RegimenFiscal) && !string.IsNullOrEmpty(Telefono) && !string.IsNullOrEmpty(Correo))
                {
                    BLTienda tienda = new BLTienda();
                    tienda.GuardarCliente(nombre, direccion,RazonSocial,Calle,NumeroExterior,NumeroInterior,Colonia,Municipio,CP,CFDI,Estado,RegimenFiscal,Telefono,Correo);

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
            if (int.TryParse(TxtID.Text, out int id) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtRfc.Text) && !string.IsNullOrEmpty(txtRaSocial.Text) && !string.IsNullOrEmpty(txtCalle.Text) && !string.IsNullOrEmpty(txtNumExt.Text) && !string.IsNullOrEmpty(txtNumInt.Text) && !string.IsNullOrEmpty(txtColonia.Text) && !string.IsNullOrEmpty(txtMunicipio.Text) && !string.IsNullOrEmpty(txtCP.Text) && !string.IsNullOrEmpty(txtEstado.Text) && !string.IsNullOrEmpty(txtRegimenFiscal.Text) && !string.IsNullOrEmpty(txtCFDI.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtCorreo.Text))
           {
                // Verificar si el proveedor con el ID dado existe antes de intentar modificarlo
                BLTienda tienda = new BLTienda();
                if (tienda.ExisteCliente(id))
                {
                    string nombre = txtNombre.Text;
                    string Rfc = txtRfc.Text;
                    string RazonSocial = txtRaSocial.Text;
                    string Calle = txtCalle.Text;
                    string NumeroExterior = txtNumExt.Text;
                    string NumeroInterior = txtNumInt.Text;
                    string Colonia = txtColonia.Text;
                    string Municipio = txtMunicipio.Text;
                    string CP = txtCP.Text;
                    string Estado = txtEstado.Text;
                    string RegimenFiscal = txtRegimenFiscal.Text;
                    string CFDI = txtCFDI.Text;
                    string Telefono = txtTelefono.Text;
                    string Correo = txtCorreo.Text;


                    tienda.ModificarCliente(id, nombre, Rfc, RazonSocial, Calle, NumeroExterior, NumeroInterior, Colonia, Municipio, CP, Estado, RegimenFiscal, CFDI, Telefono, Correo);

                    // Actualizar el DataGridView después de modificar un proveedor
                    DataTable dtClientes = tienda.ObtenerProveedores();
                    dgvDatos.DataSource = dtClientes;

                    // Limpiar los TextBox después de modificar un proveedor
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
                    MessageBox.Show("El Cliente con el ID proporcionado no existe. Ingresa un ID válido para modificar el Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa datos validos para modificar el cliente.");
            }
        }
    }
    }
    

