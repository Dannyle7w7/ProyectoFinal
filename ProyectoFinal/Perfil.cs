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
    public partial class Perfil : Form
    {
        String usuario;
        public Perfil()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            System.Drawing.Image foto = pbFoto.Image;
            bl.PushActualizarEmpleadousu( txtID.Text,txtContra.Text,  foto);
            MessageBox.Show("Empleado Actualizado correctamente.");
            this.Close();
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

        private void Perfil_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            System.Drawing.Image imagen = bl.ConsulaFotousu(txtUsuario.Text);
            if (imagen != null)
            {
                pbFoto.Image = imagen;
            }
            else
            {
                pbFoto.Image = pbFoto.InitialImage;
            }
            DataTable empleadoData = bl.ObtenerEmpleadousuDparaUPDATE(txtUsuario.Text);
            txtID.Text = Convert.ToString(empleadoData.Rows[0]["Idempleados"]);
            txtContra.Text = Convert.ToString(empleadoData.Rows[0]["Contraseña"]);
            txtNombre.Text = Convert.ToString(empleadoData.Rows[0]["Nombre"]);

        }
    }
}
