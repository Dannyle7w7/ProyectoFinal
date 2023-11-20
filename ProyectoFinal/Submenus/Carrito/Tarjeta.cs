using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoFinal.Submenus
{
    public partial class Tarjeta : Form
    {
        private string directorioImagenes;


        public Tarjeta()
        {
            InitializeComponent();
            txtNumeroTarjeta.TextChanged += TxtNumeroTarjeta_TextChanged;

            // Obtener el directorio de imágenes relativo al directorio de ejecución
            directorioImagenes = Path.Combine("Submenus", "Carrito");
            TopMost = true;
        }

        private void TxtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            ActualizarInformacionTarjeta(txtNumeroTarjeta.Text);
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            string numeroTarjeta = txtNumeroTarjeta.Text;
            string fechaVencimiento = txtFechaVencimiento.Text;
            string codigoSeguridad = txtCodigoSeguridad.Text;

            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(numeroTarjeta) || string.IsNullOrEmpty(fechaVencimiento) || string.IsNullOrEmpty(codigoSeguridad))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la longitud del número de tarjeta
            if (!ValidarLongitudNumeroTarjeta(numeroTarjeta))
            {
                MessageBox.Show("Longitud del número de tarjeta no válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la longitud del CVV según el tipo de tarjeta y que solo contenga dígitos
            if (!ValidarCVV(codigoSeguridad, numeroTarjeta))
            {
                MessageBox.Show("CVV no válido. Asegúrese de que sea numérico y tenga la longitud correcta.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Continuar con la compra si pasa todas las validaciones
            if (ValidarInformacionTarjeta(numeroTarjeta, fechaVencimiento, codigoSeguridad))
            {
                MessageBox.Show("Compra realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Información de tarjeta no válida", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCVV(string codigoSeguridad, string numeroTarjeta)
        {
            // Verificar que el CVV sea numérico
            if (!int.TryParse(codigoSeguridad, out _))
            {
                return false;
            }

            // Obtener el tipo de tarjeta
            string tipoTarjeta = ObtenerTipoTarjeta(numeroTarjeta);

            // Establecer límites de longitud del CVV según el tipo de tarjeta
            int longitudVisa = 3;
            int longitudMasterCard = 3;
            int longitudAmericanExpress = 4;

            // Validar la longitud del CVV según el tipo
            switch (tipoTarjeta)
            {
                case "Visa":
                    return codigoSeguridad.Length == longitudVisa;
                case "MasterCard":
                    return codigoSeguridad.Length == longitudMasterCard;
                case "American Express":
                    return codigoSeguridad.Length == longitudAmericanExpress;
                // Agrega más tipos de tarjeta según sea necesario
                default:
                    return false;
            }
        }

        private bool ValidarLongitudNumeroTarjeta(string numeroTarjeta)
        {
            // Establecer límites de longitud del número de tarjeta
            int longitudVisa = 16;
            int longitudMasterCard = 16;
            int longitudAmericanExpress = 15;

            // Obtener el tipo de tarjeta
            string tipoTarjeta = ObtenerTipoTarjeta(numeroTarjeta);

            // Validar la longitud del número de tarjeta según el tipo
            switch (tipoTarjeta)
            {
                case "Visa":
                    return numeroTarjeta.Length == longitudVisa;
                case "MasterCard":
                    return numeroTarjeta.Length == longitudMasterCard;
                case "American Express":
                    return numeroTarjeta.Length == longitudAmericanExpress;
                // Agrega más tipos de tarjeta según sea necesario
                default:
                    return false;
            }
        }
        private string ObtenerTipoTarjeta(string numeroTarjeta)
        {
            if (EsVisa(numeroTarjeta))
            {
                return "Visa";
            }
            else if (EsMasterCard(numeroTarjeta))
            {
                return "MasterCard";
            }
            else if (EsAmericanExpress(numeroTarjeta))
            {
                return "American Express";
            }
            // Agrega más tipos de tarjeta según sea necesario
            else
            {
                return "Desconocido";
            }
        }

        private bool ValidarLongitudCVV(string numeroTarjeta, string codigoSeguridad)
        {
            // Obtener el tipo de tarjeta
            string tipoTarjeta = ObtenerTipoTarjeta(numeroTarjeta);

            // Establecer límites de longitud del CVV según el tipo de tarjeta
            int longitudVisa = 3;
            int longitudMasterCard = 3;
            int longitudAmericanExpress = 4;

            // Validar la longitud del CVV según el tipo
            switch (tipoTarjeta)
            {
                case "Visa":
                    return codigoSeguridad.Length == longitudVisa;
                case "MasterCard":
                    return codigoSeguridad.Length == longitudMasterCard;
                case "American Express":
                    return codigoSeguridad.Length == longitudAmericanExpress;
                // Agrega más tipos de tarjeta según sea necesario
                default:
                    return false;
            }
        }

        private void ActualizarInformacionTarjeta(string numeroTarjeta)
        {
            numeroTarjeta = Regex.Replace(numeroTarjeta, @"\s|-", "");

            if (EsVisa(numeroTarjeta))
            {
                CargarImagenYActualizarLabel("VISA.PNG", "VISA");
            }
            else if (EsMasterCard(numeroTarjeta))
            {
                CargarImagenYActualizarLabel("MASTERCARD.PNG", "MasterCard");
            }
            else if (EsAmericanExpress(numeroTarjeta))
            {
                CargarImagenYActualizarLabel("American Express Card.PNG", "American Express Card");
            }
            else if (EsPayPal(numeroTarjeta))
            {
                CargarImagenYActualizarLabel("PayPal.PNG", "PayPal");
            }
            else
            {
                LimpiarInformacionTarjeta();
            }
        }

        private bool ValidarInformacionTarjeta(string numero, string fechaVencimiento, string codigoSeguridad)
        {
            // Tu lógica de validación aquí
            return true; // O false, según tu lógica
        }

        private void LimpiarInformacionTarjeta()
        {
            PbTar.Image = null;
            Tarjet1.Text = string.Empty;
        }

        private void CargarImagenYActualizarLabel(string nombreImagen, string tipoTarjeta)
        {
            try
            {
                string rutaImagen = ObtenerRutaImagen(nombreImagen);

                // Mostrar la ruta real para propósitos de depuración
                Console.WriteLine("Ruta de la imagen: " + rutaImagen);

                // Verificar si la imagen existe
                if (File.Exists(rutaImagen))
                {
                    PbTar.Image = Image.FromFile(rutaImagen);
                    Tarjet1.Text = tipoTarjeta;
                }
                else
                {
                    MessageBox.Show($"La imagen en la ruta '{rutaImagen}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarInformacionTarjeta();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen: " + ex.Message);
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarInformacionTarjeta();
            }
        }

        private string ObtenerRutaImagen(string nombreImagen)
        {
            // Obtén el directorio de ejecución de la aplicación
            string directorioEjecucion = Path.GetDirectoryName(Application.ExecutablePath);

            // Carpeta donde se busca la imagen
            string carpetaImagenes = Path.Combine(directorioEjecucion, directorioImagenes);

            // Rutas posibles
            string[] rutasPosibles = {
                Path.Combine(carpetaImagenes, nombreImagen),
                Path.Combine(directorioEjecucion, "Submenus", directorioImagenes, nombreImagen)
            };

            // Busca en las rutas posibles y devuelve la primera existente
            foreach (string ruta in rutasPosibles)
            {
                if (File.Exists(ruta))
                {
                    return ruta;
                }
            }

            // Si no se encuentra en ninguna de las rutas, devuelve la ruta original
            return Path.Combine(carpetaImagenes, nombreImagen);
        }

        private bool EsVisa(string numero)
        {
            return Regex.IsMatch(numero, @"^4[0-9]{12}(?:[0-9]{3})?$");
        }

        private bool EsMasterCard(string numero)
        {
            return Regex.IsMatch(numero, @"^5[1-5][0-9]{14}$");
        }

        private bool EsAmericanExpress(string numero)
        {
            return Regex.IsMatch(numero, @"^3[47][0-9]{13}$");

        }
        private bool EsPayPal(string numero)
        {
            // Asumiendo que los números de tarjeta de PayPal comienzan con "4" (Visa) o "5" (MasterCard)
            return Regex.IsMatch(numero, @"^(4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$");
        }

        private void BtnCancelarcom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
