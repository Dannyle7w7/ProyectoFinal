﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinal
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle myRectangle = btnLogin.ClientRectangle;
            myRectangle.Inflate(0, 30);
            buttonPath.AddEllipse(myRectangle);
            btnLogin.Region = new Region(buttonPath);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked == true)
            {
                txtPass.PasswordChar = Convert.ToChar(0);
            }
            else if (chkMostrar.Checked == false)
            {
                txtPass.PasswordChar = Convert.ToChar("*");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0 && txtPass.Text.Length > 0)
            {
                BLTienda bl = new BLTienda();
                if ( bl.ConsultaAcceso(txtUser.Text,txtPass.Text)==1)
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show(this);
                }
                else
                {
                    MessageBox.Show("Lo siento, el nombre de usuario o la contraseña son incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                //Mejorar mesagge box
                MessageBox.Show("Lo siento, el nombre de usuario o la contraseña tienen algun campo vacio.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
