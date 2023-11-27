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
        public string Puesto;


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
        Perfil formConfiguracion = new Perfil();


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pbUsuario.Image = imagen;
            lblUsuario.Text = Usuario;
            lblPuesto.Text = Puesto;

            if (lblPuesto.Text=="Empleado")
            {
                btnEquipo.Enabled = false;
                btnEquipo.Visible= false;   
            }
            else
            {

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
                    btnInventario.PerformClick();
                    break;
                case Keys.F4:
                    btnConfiguracion.PerformClick();
                    break;
                case Keys.F5:
                    btnCerrarsesion.PerformClick();
                    break;
                case Keys.F6:
                    btnCompras.PerformClick();
                    break;
                case Keys.F7:
                    btnProveedores.PerformClick();
                    break;
                case Keys.F8:
                    btnEquipo.PerformClick();
                    break;
            }
        }

       

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        


      
        //Este código define los botones F que abren formularios
        //hijos dentro del formulario principal. También define la
        //función EsconderTodosLosMDIChildren, que oculta los formularios hijos que no
        //están activos. Cada botón F verifica si el formulario hijo correspondiente está abierto
        //o no, y lo muestra en estado maximizado.

        private void EsconderTodosLosMDIChildren()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Hide();
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            formVenta.WindowState = FormWindowState.Maximized;
            EsconderTodosLosMDIChildren();
            if (VentaAbierta == false)
            {
                formVenta.MdiParent = this;
                formVenta.WindowState = FormWindowState.Maximized;
                VentaAbierta = true;
                formVenta.Show();
            }
            else
            {
                formVenta.Show();
            }
        }


        private void btnEquipo_Click(object sender, EventArgs e)
        {
            
            EsconderTodosLosMDIChildren();
            if (EmpleadosAbierta == false)
            {
                formEmpleados.MdiParent = this;
                formEmpleados.WindowState = FormWindowState.Maximized;
                EmpleadosAbierta = true;
                formEmpleados.Show();
            }
            else
            {
                formEmpleados.Show();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
            EsconderTodosLosMDIChildren();
            if (ClientesAbierta == false)
            {
                formClientes.MdiParent = this;
                ClientesAbierta = true;
                formClientes.WindowState = FormWindowState.Maximized;
                formClientes.Show();
            }
            else
            {
                formClientes.Show();
            }

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            EsconderTodosLosMDIChildren();
            if (InventarioAbierta == false)
            {
                formInventario.MdiParent = this;
                formInventario.WindowState = FormWindowState.Maximized;
                InventarioAbierta = true;
                formInventario.Show();
            }
            else
            {
                formInventario.Show();
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
      
            EsconderTodosLosMDIChildren();
            if (ComprasAbierta == false)
            {
                formCompras.MdiParent = this;
                formCompras.WindowState = FormWindowState.Maximized;
                ComprasAbierta = true;
                formCompras.Show();
            }
            else
            {
                formCompras.Show();
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            formConfiguracion.txtUsuario.Text =lblUsuario.Text;
            formConfiguracion.ShowDialog();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            EsconderTodosLosMDIChildren();
            if (ProveedoresAbierta == false)
            {
                formProveedores.MdiParent = this;
                formProveedores.WindowState = FormWindowState.Maximized;
                ProveedoresAbierta = true;
                formProveedores.Show();
            }
            else
            {
                formProveedores.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();   
            form.Show();
        }

        ///AQUI TERMINAN LOS BOTONES
    }
}
