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
            Trabajadores form = new Trabajadores();
            form.Size = MaximumSize;
            form.Show();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            //Esta parte del codigo es para que al pulsar la teclas F
            //estando en el menu pueudas moverte atraves del menu
            //sin necisdad de hacer clic en algun boton
           //Necesita que el keypreview del form este activado
            switch (e.KeyCode)
            {
                case Keys.F12:
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
           

        }
    }
}
