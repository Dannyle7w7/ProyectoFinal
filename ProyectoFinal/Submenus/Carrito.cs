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

       
        private void Clientes_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            DvgClientesLista.DataSource = bl.ObtenerTodosLosClientes();

            BLTienda bl1 = new BLTienda();
            DvgAcomulacioncarrito.DataSource = bl.ObtenerTodasLasVentas();
        }

        private void DvgAcomulacioncarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
