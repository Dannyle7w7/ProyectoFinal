using ProyectoFinal.Submenus;
using ProyectoFinal.Submenus.Trabajadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        //Variables globales 
        public string Usuario;
        public System.Drawing.Image imagen;


        //Todas las variables de forma y su estado
        public bool EmpleadosAbierta = false;
        Trabajadores formEmpleados = new Trabajadores();

        public bool ProveedoresAbierta = false;
        Proveedores formProveedores = new Proveedores();

        public bool VentaAbierta = false;
        Carrito formVenta = new Carrito();

        public bool ClientesAbierta = false;
        Clientes formClientes = new Clientes();

        public bool InventarioAbierta = false;
        Inventario formInventario = new Inventario();

        public bool ComprasAbierta = false;
        CompraProveedores formCompras = new CompraProveedores();

        public bool ConfiguracionAbierta = false;
        Configuracion formConfiguracion = new Configuracion();


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pbUsuario.Image = imagen;
            lblUsuario.Text = Usuario;
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            formEmpleados.WindowState = FormWindowState.Maximized;  
            EsconderTodosLosMDIChildren();
            if (EmpleadosAbierta == false)
            {
                formEmpleados.MdiParent = this;
                EmpleadosAbierta = true;
                formEmpleados.Show();
            }
            else
            {
                formEmpleados.Show();
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            //Esta parte del codigo es para que al pulsar la teclas F
            //estando en el menu pueudas moverte atraves del menu
            //sin necisdad de hacer clic en algun boton
           //Necesita que el keypreview del form este activado
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnVenta.PerformClick();
                    break;

                case Keys.F2:
                    btnClientes.PerformClick();
                    break;
                case Keys.F3:
                    btnProveedores.PerformClick();
                    break;
                case Keys.F4:
                    btnInventario.PerformClick();
                    break;
                case Keys.F5:
                    btnCompras.PerformClick();
                    break;
                case Keys.F6:
                    btnConfiguracion.PerformClick();
                    break;
                case Keys.F7:
                    btnEquipo.PerformClick();
                    break;
            }
        }

        private void EsconderTodosLosMDIChildren()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Hide();
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        


        private void btnClientes_Click(object sender, EventArgs e)
        {
            formClientes.WindowState = FormWindowState.Maximized;
            EsconderTodosLosMDIChildren();
            if (ClientesAbierta == false)
            {
                formClientes.MdiParent = this;
                EmpleadosAbierta = true;
                formClientes.Show();
            }
            else
            {
                formClientes.Show();
            }

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            formVenta.WindowState = FormWindowState.Maximized;
            EsconderTodosLosMDIChildren();
            if (VentaAbierta == false)
            {
                formVenta.MdiParent = this;
                VentaAbierta = true;
                formVenta.Show();
            }
            else
            {
                formVenta.Show();
            }
        }
    }
}
