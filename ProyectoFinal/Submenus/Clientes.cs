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

        }
    }
}
