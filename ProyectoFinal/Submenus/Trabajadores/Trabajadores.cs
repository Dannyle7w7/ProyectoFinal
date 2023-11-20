using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal.Submenus.Trabajadores
{
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
          
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            dgvDatos.DataSource = bl.ObtenerTodosLosEmpleados();
            rdTodos.Checked = true;

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            BLTienda bl =new BLTienda();
            ModificacionTrabajadores form =new ModificacionTrabajadores();
            form.ID = bl.ConsultaultimoID()+1;
            form.ShowDialog();
            if (txtBusqueda.Text == "Búsqueda")
            {
                if (rdTodos.Checked == true)
                {
                    dgvDatos.DataSource = bl.ObtenerTodosLosEmpleados();


                }
                else if (rdActivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.ObtenerTodosLosEmpleadosActivos();

                }
                else if (rdInactivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.ObtenerTodosLosEmpleadosInactivos();
                }
            }
            else if (txtBusqueda.Text != "Búsqueda" && txtBusqueda.Text.Length > 0)
            {
                if (rdTodos.Checked == true)
                {
                    dgvDatos.DataSource = bl.BuscarEmpleados(txtBusqueda.Text);
                }
                else if (rdActivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.BuscarEmpleadosActivos(txtBusqueda.Text);
                }
                else if (rdInactivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.BuscarEmpleadosInactivos(txtBusqueda.Text);

                }
            }

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            if (txtBusqueda.Text=="Búsqueda")
            {
                if (rdTodos.Checked==true) {
                    dgvDatos.DataSource = bl.ObtenerTodosLosEmpleados();


                }
                else if (rdActivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.ObtenerTodosLosEmpleadosActivos();

                }
                else if (rdInactivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.ObtenerTodosLosEmpleadosInactivos();
                }
            }
            else if(txtBusqueda.Text!= "Búsqueda" && txtBusqueda.Text.Length>0)
            {
                if (rdTodos.Checked == true)
                {
                    dgvDatos.DataSource = bl.BuscarEmpleados(txtBusqueda.Text);
                }
                else if (rdActivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.BuscarEmpleadosActivos(txtBusqueda.Text);
                }
                else if (rdInactivo.Checked == true)
                {
                    dgvDatos.DataSource = bl.BuscarEmpleadosInactivos(txtBusqueda.Text);

                }
            }
        }

        private void rdTodos_CheckedChanged(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            if (txtBusqueda.Text!="Búsqueda" && txtBusqueda.Text.Length>0)
            {
                dgvDatos.DataSource =bl.BuscarEmpleados(txtBusqueda.Text);
            }
            else if(rdTodos.Checked==true)
            {
                
                dgvDatos.DataSource = bl.ObtenerTodosLosEmpleados();
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            if (txtBusqueda.Text != "Búsqueda" && txtBusqueda.Text.Length > 0)
            {
                dgvDatos.DataSource = bl.BuscarEmpleadosActivos(txtBusqueda.Text);
            }
            else if (rdActivo.Checked == true)
            {

                dgvDatos.DataSource = bl.ObtenerTodosLosEmpleadosActivos();
            }
        }

        private void rdInactivo_CheckedChanged(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            if (txtBusqueda.Text != "Búsqueda" && txtBusqueda.Text.Length > 0)
            {
                dgvDatos.DataSource = bl.BuscarEmpleadosInactivos(txtBusqueda.Text);
            }
            else if (rdInactivo.Checked == true)
            {

                dgvDatos.DataSource = bl.ObtenerTodosLosEmpleadosInactivos();
            }
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Búsqueda")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic se hizo en una celda y no en el encabezado de la columna
            if (e.RowIndex >= 0)
            {
                // Obtiene el valor de la primera celda de la fila seleccionada (supongamos que el ID está en la primera columna)
                DataGridViewRow row =dgvDatos.Rows[e.RowIndex];
                string idValue = row.Cells[0].Value.ToString();

                BLTienda bl = new BLTienda();
                ModificacionTrabajadores form = new ModificacionTrabajadores();
                form.ID = Convert.ToInt32(idValue);
                
                form.ShowDialog();
            }

        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {

                BLTienda bl = new BLTienda();
                System.Drawing.Image imagen = bl.ConsulaFotoID(Convert.ToString(dgvDatos.SelectedRows[0].Cells["IDEmpleados"].Value));
                if (imagen != null)
                {
                    pbTrabajadores.Image = imagen;
                }
                else
                {
                    pbTrabajadores.Image = pbTrabajadores.InitialImage;
                }

            }
            else
            {
                // En caso de que no haya filas seleccionadas este mas de una, se mostrara la imagen de inicio
                pbTrabajadores.Image=pbTrabajadores.InitialImage;
            }
        }
    }
}
