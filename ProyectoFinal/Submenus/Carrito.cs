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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            dgvclientes.DataSource = bl.ObtenerTodasLasVentas();
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            dgvclientes.DataSource = bl.ObtenerTodosLosClientes();
        }
        private void BtnCobrar_Click(object sender, EventArgs e)
        {

        }

        private void Dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            dgvclientes.DataSource = bl.ObtenerTodosLosClientes();
        }
        private void BtnCobrar_Click(object sender, EventArgs e)
        {

        }
    }
}
