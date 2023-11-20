using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ProyectoFinal.Submenus.Trabajadores
{
    public partial class Carrito : Form
    {
        private System.Timers.Timer timerEliminarContenido;
        private Tarjeta ventanaTarjeta;
        public Carrito()
        {
            InitializeComponent();
            // Inicializar el temporizador
            timerEliminarContenido = new System.Timers.Timer();
            timerEliminarContenido.Elapsed += OnTimerElapsed;
            timerEliminarContenido.Interval = 2000; // Intervalo en milisegundos (2 segundos)
            timerEliminarContenido.AutoReset = false; // Solo se dispara una vez
            // Configurar el evento TextChanged para el control TxtCodigo
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
            
        }

       

        private void Clientes_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            DvgClientesLista.DataSource = bl.ObtenerTodosLosClientes();

            BLTienda bl1 = new BLTienda();
            DvgAcomulacioncarrito.DataSource = bl.ObtenerTodasLasVentas();
        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Método llamado cuando el temporizador alcanza su intervalo
            // Puedes poner aquí el código para eliminar el contenido del archivo
            // Obtén la ruta al directorio del ejecutable actual
            string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows","codigot.txt");


            try
            {
                // Elimina el contenido del archivo
                File.WriteAllText(rutaArchivo, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el contenido del archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            // Validar la longitud del texto en TxtCodigo
            if (TxtCodigo.Text.Length > 6)
            {
                MessageBox.Show("No se permiten más de 6 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Text = TxtCodigo.Text.Substring(0, 6); // Truncar el texto a 6 caracteres
            }
        }


        private void DvgAcomulacioncarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén la ruta al directorio del ejecutable actual
                string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;

                // Construye la ruta completa al ejecutable del otro programa
                string rutaAlEjecutable = Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "CMYK.exe");

                // Verificar si el archivo ejecutable existe
                if (File.Exists(rutaAlEjecutable))
                {
                    // Iniciar el proceso del otro programa
                    Process.Start(rutaAlEjecutable);
                }
                else
                {
                    MessageBox.Show("El archivo ejecutable no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            // Obtén el texto de TxtCodigo
            string codigo = TxtCodigo.Text;

            // Verificar la longitud del código
            if (codigo.Length != 6)
            {
                MessageBox.Show("El código debe ser de 6 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ruta del archivo donde se guardará el código

            string directorioTXT = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(directorioTXT, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "codigot.txt");

            try
            {
                // Escribe el código en el archivo
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    // Empieza con la palabra "codigo" seguido del código
                    sw.WriteLine("codigo" + Environment.NewLine + codigo);
                }
                // Inicia el temporizador para eliminar el contenido después de 2 segundos
                timerEliminarContenido.Start();


                /// Obtén la ruta al directorio del ejecutable actual
                string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;

                // Construye la ruta completa al ejecutable del otro programa
                string rutaAlEjecutable = Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "CMYK.exe");

                // Verificar si el archivo ejecutable existe
                if (File.Exists(rutaAlEjecutable))
                {
                    // Iniciar el proceso del otro programa
                    Process.Start(rutaAlEjecutable);
                }
                else
                {
                    MessageBox.Show("El archivo ejecutable no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Tarjeta
          
            AbrirVentanaTarjeta();

            // Mostrar el formulario
            
        }
        
        private void AbrirVentanaTarjeta()
        {
            // Verificar si la ventana ya está abierta
            if (ventanaTarjeta == null || ventanaTarjeta.IsDisposed)
            {
                // Deshabilitar todos los botones en el formulario Carrito
                DeshabilitarBotones();

                // Crear una nueva instancia de la ventana
                ventanaTarjeta = new Tarjeta();

                // Suscribirse al evento Closed para saber cuando se cierra la ventana
                ventanaTarjeta.FormClosed += (s, e) =>
                {
                    ventanaTarjeta = null;
                    // Habilitar todos los botones en el formulario Carrito al cerrar la ventana
                    HabilitarBotones();
                };

                // Mostrar la ventana
                ventanaTarjeta.Show();
            }
            else
            {
                // La ventana ya está abierta, puedes realizar alguna acción adicional si es necesario
                MessageBox.Show("La ventana Tarjeta ya está abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeshabilitarBotones()
        {
            // Iterar a través de todos los controles en el formulario Carrito
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    // Deshabilitar los botones
                    ((Button)control).Enabled = false;
                }
            }
        }

        private void HabilitarBotones()
        {
            // Iterar a través de todos los controles en el formulario Carrito
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    // Habilitar los botones
                    ((Button)control).Enabled = true;
                }
            }
        }

    }
}
