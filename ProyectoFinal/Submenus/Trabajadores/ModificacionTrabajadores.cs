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
    public partial class ModificacionTrabajadores : Form
    {
        public int ID=0;
      
        public ModificacionTrabajadores()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text!="Usuario" && txtNombre.Text != "Nombre" && txtContra.Text != "Cantraseña")
            {
                BLTienda bl = new BLTienda();
                System.Drawing.Image foto = pbFoto.Image;
                bl.GuardarEmpleado(txtUsuario.Text, txtContra.Text, txtNombre.Text, foto, rdActivo.Checked, cbNivel.SelectedIndex + 1);
                MessageBox.Show("Empleado guardado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Dato faltantes");

            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Filtrar solo archivos de imagen
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada
                pbFoto.Image = new Bitmap(openFileDialog1.FileName);

                // Establecer las dimensiones deseadas
                pbFoto.SizeMode = PictureBoxSizeMode.Zoom; // Opciones: Zoom, Stretch, etc.
                pbFoto.Size = new Size(150, 180); // Define el tamaño deseado
            }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjMostrar.Checked == true)
            {
                txtContra.PasswordChar = Convert.ToChar(0);
            }
            else if (rjMostrar.Checked == false)
            {
                txtContra.PasswordChar = Convert.ToChar("*");
            }
        }

        private void ModificacionTrabajadores_Load(object sender, EventArgs e)
        {
            //Este codigo es para que el tamaño de la fuente se ajuste al boton
            AjustarTextoBoton(btnAgregar);
            AjustarTextoBoton(btnFoto);
            AjustarTextoBoton(btnModificar);
            cbNivel.SelectedIndex=0;
            txtID.Text = Convert.ToString(ID);
            
        }

        private void AjustarTextoBoton(System.Windows.Forms.Button boton)
        {
            FontStyle estilo = boton.Font.Style;
            Size textSize = TextRenderer.MeasureText(boton.Text, boton.Font);
            float fontSize = boton.Font.SizeInPoints * (boton.Width / textSize.Width);
            Font newFont = new Font(boton.Font.FontFamily, fontSize, estilo);
            boton.Font = newFont;
        }

     

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                rjMostrar.Checked = false; 
                txtContra.ForeColor = Color.Black;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContra.Text))
            {
                txtContra.Text = "Contraseña"; 
                rjMostrar.Checked = true;
                txtContra.ForeColor = Color.Gray;

            }
        }

        private void rdActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdActivo.Checked == true)
            {
                lblActivo.Text = "Estado: Activo";
            }else if (rdActivo.Checked==false)
            {
                lblActivo.Text = "Estado:Inactivo";
            }
        }
    }
}
