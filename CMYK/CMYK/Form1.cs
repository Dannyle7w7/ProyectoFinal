using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CMYK
{
    public partial class Form1 : Form
    {
        private Dictionary<char, double> cmykToMlRatio;
        private System.Windows.Forms.Timer timerSimulacionClic;
        private static Mutex mutex = new Mutex(true, "{F47B8362-E150-4F52-B82A-17C8EF6D9078}");



        public Form1()
        {
            InitializeComponent();
            timerSimulacionClic = new System.Windows.Forms.Timer();
            timerSimulacionClic.Interval = 100; // Puedes ajustar el intervalo según tus necesidades
            timerSimulacionClic.Tick += TimerSimulacionClic_Tick;
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("La aplicación ya está en ejecución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            LeerCodigoDesdeArchivo();
            TopMost = true;

            // Inicializar la relación entre el código CMYK y la cantidad de pintura en mililitros
            cmykToMlRatio = new Dictionary<char, double>
            {
                { 'C', 0.01 },  // Porcentaje de cian convertido a mililitros
                { 'M', 0.01 },  // Porcentaje de magenta convertido a mililitros
                { 'Y', 0.01 },  // Porcentaje de amarillo convertido a mililitros
                { 'K', 0.01 }   // Porcentaje de negro convertido a mililitros
            };
        }

        private void TimerSimulacionClic_Tick(object sender, EventArgs e)
        {
            // Detener el temporizador
            timerSimulacionClic.Stop();

            // Simular clic en BtnBuscar
            BtnBuscar.PerformClick();
        }

        private void LeerCodigoDesdeArchivo()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "codigot.txt");

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    // Leer todas las líneas del archivo
                    string[] lineas = File.ReadAllLines(rutaArchivo);

                    if (lineas.Length >= 2)
                    {
                        // Obtener el valor de la segunda línea (índice 1)
                        string valorHexadecimal = lineas[1].Trim();

                        // Validar que sea un valor hexadecimal de 6 caracteres
                        if (valorHexadecimal.Length == 6 && int.TryParse(valorHexadecimal, System.Globalization.NumberStyles.HexNumber, null, out int valorDecimal))
                        {
                            // Mostrar el valor en el TextBox Decimal
                            Decimal.Text = valorHexadecimal;

                            // Iniciar el temporizador
                            timerSimulacionClic.Start();
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnGenerateColor_Click(object sender, EventArgs e)
        {
            int cyan = (int)NupCyan.Value;
            int magenta = (int)NupMagenta.Value;
            int yellow = (int)NupYellow.Value;
            int black = (int)NupBlack.Value;

            // Convertir valores CMYK a un rango de 0 a 1
            float c = cyan / 100f;
            float m = magenta / 100f;
            float y = yellow / 100f;
            float k = black / 100f;

            // Calcular valores RGB usando la fórmula CMYK a RGB
            int r = (int)((1 - Math.Min(1, c * (1 - k) + k)) * 255);
            int g = (int)((1 - Math.Min(1, m * (1 - k) + k)) * 255);
            int b = (int)((1 - Math.Min(1, y * (1 - k) + k)) * 255);

            // Actualizar los valores de los componentes RGB en los NumericUpDown
            NupRed.Value = r;
            NupGreen.Value = g;
            NupBlue.Value = b;

            // Calcular y mostrar el valor hexadecimal en el TextBox
            string valorHexadecimal = $"{r:X2}{g:X2}{b:X2}";
            Decimal.Text = valorHexadecimal;

            // Crear color a partir de los valores RGB
            Color generatedColor = Color.FromArgb(r, g, b);

            // Mostrar el color en el Panel
            PanelColor.BackColor = generatedColor;
            PanelColordef.BackColor = PanelColor.BackColor;
        }




        private void btnConvertirHexadecimal_Click(object sender, EventArgs e)
        {
            // Obtener el valor hexadecimal del TextBox y convertirlo a un color RGB
            string valorHexadecimal = Decimal.Text.Trim('#');
            if (valorHexadecimal.Length == 6 && int.TryParse(valorHexadecimal, System.Globalization.NumberStyles.HexNumber, null, out int valorDecimal))
            {
                Color colorRGB = Color.FromArgb(valorDecimal);

                // Calcular valores CMYK
                float c, m, y, k;
                ColorToCMYK(colorRGB, out c, out m, out y, out k);

                // Calcular valores RGB
                int red = colorRGB.R;
                int green = colorRGB.G;
                int blue = colorRGB.B;

                // Mostrar el color en el Panel
                PanelColor.BackColor = colorRGB;

                // Llenar los NumericUpDown con valores CMYK
                NupCyan.Value = (decimal)(c * 100);
                NupMagenta.Value = (decimal)(m * 100);
                NupYellow.Value = (decimal)(y * 100);
                NupBlack.Value = (decimal)(k * 100);

                // Llenar los NumericUpDown con valores RGB
                NupRed.Value = red;
                NupGreen.Value = green;
                NupBlue.Value = blue;

                BtnGenerar.PerformClick();
                PanelColordef.BackColor = PanelColor.BackColor;
                lbcodigo.Text = $": {Decimal.Text}";
            }

            else
            {
                MessageBox.Show("Por favor, ingrese un valor hexadecimal válido", "Error");
            }
        }

        private void ColorToCMYK(Color color, out float c, out float m, out float y, out float k)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            k = 1 - Math.Max(r, Math.Max(g, b));
            c = (1 - r - k) / (1 - k);
            m = (1 - g - k) / (1 - k);
            y = (1 - b - k) / (1 - k);
        }



        private void btnConvertirRGB_Click(object sender, EventArgs e)
        {
            int red = (int)NupRed.Value;
            int green = (int)NupGreen.Value;
            int blue = (int)NupBlue.Value;

            // Verificar que los valores estén en el rango 0-255
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
            {
                MessageBox.Show("Los valores de RGB deben estar en el rango de 0 a 255.", "Error");
                return;
            }

            // Convertir valores RGB a un rango de 0 a 1
            float r = red / 255f;
            float g = green / 255f;
            float b = blue / 255f;

            // Calcular valores CMYK usando la fórmula CMYK a RGB
            float k = 1 - Math.Max(r, Math.Max(g, b));
            float c = (1 - r - k) / (1 - k);
            float m = (1 - g - k) / (1 - k);
            float y = (1 - b - k) / (1 - k);

            // Llenar los NumericUpDown con valores CMYK
            NupCyan.Value = (decimal)(c * 100);
            NupMagenta.Value = (decimal)(m * 100);
            NupYellow.Value = (decimal)(y * 100);
            NupBlack.Value = (decimal)(k * 100);

            // Calcular y mostrar el valor hexadecimal en el TextBox
            string valorHexadecimal = $"{red:X2}{green:X2}{blue:X2}";
            Decimal.Text = valorHexadecimal;

            // Mostrar el color en el Panel
            PanelColor.BackColor = Color.FromArgb(red, green, blue);

            BtnGenerar.PerformClick();

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles NumericUpDown
            double cyan = (double)NupCyan.Value;
            double magenta = (double)NupMagenta.Value;
            double yellow = (double)NupYellow.Value;
            double black = (double)NupBlack.Value;

            // Obtener la cantidad total de litros desde el TextBox
            double cantidadTotalLitros;

            if (!double.TryParse(txtCantidadTotalLitros.Text, out cantidadTotalLitros))
            {
                MessageBox.Show("Ingrese una cantidad válida de litros.");
                return;
            }

            // Calcular las cantidades necesarias de los colores primarios
            double cantidadCyan = cmykToMlRatio['C'] * (cantidadTotalLitros * cyan);
            double cantidadMagenta = cmykToMlRatio['M'] * (cantidadTotalLitros * magenta);
            double cantidadYellow = cmykToMlRatio['Y'] * (cantidadTotalLitros * yellow);
            double cantidadBlack = cmykToMlRatio['K'] * (cantidadTotalLitros * black);

            // Normalizar las cantidades para que sumen 1 litro en total
            double totalMl = cantidadCyan + cantidadMagenta + cantidadYellow + cantidadBlack;

            cantidadCyan /= totalMl;
            cantidadMagenta /= totalMl;
            cantidadYellow /= totalMl;
            cantidadBlack /= totalMl;

            int numeroDecimales = 2; // Puedes ajustar este valor según tus necesidades

            // Mostrar los resultados en Labels con un formato limitado de decimales
            lblResultadoCyan.Text = $"Cyan: {(cantidadCyan * (1000 * cantidadTotalLitros)).ToString($"F{numeroDecimales}")} ml";
            lblResultadoMagenta.Text = $"Magenta: {(cantidadMagenta * (1000 * cantidadTotalLitros)).ToString($"F{numeroDecimales}")} ml";
            lblResultadoYellow.Text = $"Yellow: {(cantidadYellow * (1000 * cantidadTotalLitros)).ToString($"F{numeroDecimales}")} ml";
            lblResultadoBlack.Text = $"Black: {(cantidadBlack * (1000 * cantidadTotalLitros)).ToString($"F{numeroDecimales}")} ml";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //click y toma automatica del color CMYK, Codigo y transforma imagen a mapa de bits

        {

            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            NupRed.Text = clr.R.ToString();
            NupGreen.Text = clr.G.ToString();
            NupBlue.Text = clr.B.ToString();
            BtnRGB.PerformClick();
            PanelColordef.BackColor = clr;
            lbcodigo.Text = $": {Decimal.Text}";




        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //Toma de color automatica RGB y transforma imagen a mapa de bits
        {
            int red = (int)NupRed.Value;
            int green = (int)NupGreen.Value;
            int blue = (int)NupBlue.Value;
            string valorHexadecimal = $"{red:X2}{green:X2}{blue:X2}";
            Decimal.Text = valorHexadecimal;
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            PanelColor.BackColor = clr;
            NupRed.Text = clr.R.ToString();
            NupGreen.Text = clr.G.ToString();
            NupBlue.Text = clr.B.ToString();


        }







        private void txtCantidadTotalMl_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtHexa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PanelColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NupBlue_ValueChanged(object sender, EventArgs e)
        {

        }

    }

}