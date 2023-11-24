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
            BLTienda bl = new BLTienda();
            dgvDatos.DataSource = bl.ObtenerTodosLosClientes();
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

                    //// Actualizar el DataGridView después de agregar un proveedor
                    //DataTable dtProveedores = tienda.ObtenerProveedores();
                    //DgvProv.DataSource = dtProveedores;

                    //// Limpiar los TextBox después de agregar un proveedor
                    //TxtID.Text = "";
                    //TxtNombre.Text = "";
                    //TxtDireccion.Text = "";

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
    
    }
}
