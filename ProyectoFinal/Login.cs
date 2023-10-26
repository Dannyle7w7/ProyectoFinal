using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Hola Justin Test
namespace ProyectoFinal
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrar.Checked == true)
            {
                txbContra.PasswordChar = Convert.ToChar(0);
            }else if (chbMostrar.Checked == false)
            {
                txbContra.PasswordChar = Convert.ToChar("*");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text.Length>0 && txbContra.Text.Length>0)
            {
                
            }
            else
            {
                //Mejorar mesagge box
                MessageBox.Show("Informacion incompelta");
            }
        }
    }
}
