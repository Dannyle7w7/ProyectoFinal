﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }
    }
}
