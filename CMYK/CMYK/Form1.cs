using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DAL;
using System.Data;

namespace CMYK
{
    public partial class Form1 : Form
    {
        private Dictionary<char, double> cmykToMlRatio;
        private System.Windows.Forms.Timer timerSimulacionClic;
        private static Mutex mutex = new Mutex(true, "{F47B8362-E150-4F52-B82A-17C8EF6D9078}");
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private string rutaCompleta;



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
            txtCantidadTotalLitros.SelectedIndexChanged += (s, args) => btnCalcular.PerformClick();
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

            if (txtCantidadTotalLitros.SelectedIndex >= 0)
            {
                // Simular un clic en el botón btnCalcular
                btnCalcular.PerformClick();
            }
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
            if (txtCantidadTotalLitros.SelectedIndex >= 0)
            {
                // Simular un clic en el botón btnCalcular
                btnCalcular.PerformClick();
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
            if (txtCantidadTotalLitros.SelectedIndex >= 0)
            {
                // Simular un clic en el botón btnCalcular
                btnCalcular.PerformClick();
            }

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            // Obtener los valores de los controles NumericUpDown
            double cyan = (double)NupCyan.Value;
            double magenta = (double)NupMagenta.Value;
            double yellow = (double)NupYellow.Value;
            double black = (double)NupBlack.Value;
            if (txtCantidadTotalLitros.SelectedIndex >= 0)
            {
                string selectedValue = txtCantidadTotalLitros.SelectedItem.ToString();
            }

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
            if (txtCantidadTotalLitros.SelectedIndex >= 0)
            {
                // Simular un clic en el botón btnCalcular
                btnCalcular.PerformClick();
            }




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
        public DataTable ObtenerTodosLosInventarios()
        {
            string query = "SELECT  Nombre='Lata', precio FROM Productos";
            DAL.DAL dal = new();
            return dal.Consulta(query);
        }

        private void BtnEnviaraCarrito_Click(object sender, EventArgs e)
        {
            if (EsNumeroMayorACero(txtCantidadTotalLitros.Text))
            {

                // Obtener los datos necesarios
                string producto = lbcodigo.Text;
                decimal cantidad = Convert.ToDecimal(txtCantidadTotalLitros.Text);

                // Obtener el precio desde la base de datos
                DataTable dt = ObtenerTodosLosInventarios();

                // Obtener la ruta del archivo en la carpeta del ejecutable
                string nombreArchivo = "Carrito.xlsx";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);

                // Actualizar el archivo Excel existente o crear uno nuevo si no existe
                ActualizarArchivoExcel(producto, cantidad, dt, rutaCompleta);
                Application.Exit();
            }
            else
            {
                // Mostrar un mensaje de error o tomar alguna otra acción si la validación falla
                MessageBox.Show("Ingrese un numero de litros mayor a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // También puedes deshabilitar el botón si la validación falla (opcional)
                // BtnEnviaraCarrito.Enabled = false;
            }
        }
        private bool EsNumeroMayorACero(string input)
        {
            // Verificar si la cadena es un número y si ese número es mayor a 0
            if (int.TryParse(input, out int numero) && numero > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ActualizarArchivoExcel(string producto, decimal cantidad, DataTable dt, string rutaCompleta)
        {
            Excel.Application excelApp = new Excel.Application();

            // Establecer Visible a false para que Excel no se abra en pantalla
            excelApp.Visible = false;


            // Intentar abrir un archivo existente
            Excel.Workbook workbook = null;
            try
            {
                workbook = excelApp.Workbooks.Open(rutaCompleta);
            }
            catch
            {
                // Si el archivo no existe, crear uno nuevo
                workbook = excelApp.Workbooks.Add();
                workbook.SaveAs(rutaCompleta); // Guardar el archivo para asegurar que esté disponible
            }

            Excel.Worksheet worksheet = workbook.Worksheets[1];


            // Verificar si el archivo es nuevo antes de agregar las nuevas columnas
            if (worksheet.Cells[1, 5].Value == null)
            {
                // Agregar nuevas columnas solo si no existen
                worksheet.Cells[1, 1] = "Producto"; // Añadir o reafirmar el título
                worksheet.Cells[1, 2] = "Cantidad"; // Añadir o reafirmar el título
                worksheet.Cells[1, 3] = "Precio";   // Añadir o reafirmar el título
                worksheet.Cells[1, 4] = "Total";    // Añadir o reafirmar el título
                worksheet.Cells[1, 5] = "Cyan";    // Nueva columna
                worksheet.Cells[1, 6] = "Magenta"; // Nueva columna
                worksheet.Cells[1, 7] = "Yellow";  // Nueva columna
                worksheet.Cells[1, 8] = "Black";   // Nueva columna
            }

            // Encontrar la última fila ocupada en la columna A
            int lastRow = worksheet.Cells[worksheet.Rows.Count, 1].End[Excel.XlDirection.xlUp].Row;

            // Iterar sobre las filas de la DataTable
            int rowIndex = lastRow + 1; // Comenzar desde la próxima fila disponible
            foreach (DataRow row in dt.Rows)
            {
                // Obtener el precio de la fila actual
                decimal precio = Convert.ToDecimal(row["precio"]);

                // Realizar el cálculo
                decimal total = cantidad * precio;
                // Configurar el formato de celda para la columna "Producto" como texto
                producto = producto.TrimStart(':'); // Eliminar ":" al principio, si existe
                worksheet.Cells[rowIndex, 1].NumberFormat = "@"; // Establecer formato de celda como texto
                worksheet.Cells[rowIndex, 1].Value = producto;

                // Obtener valores de las etiquetas y agregar a las nuevas columnas
                decimal valorCyan;
                if (decimal.TryParse(QuitarUnidades(lblResultadoCyan.Text), out valorCyan))
                {
                    worksheet.Cells[rowIndex, 5].NumberFormat = "0.00"; // Formato de celda para Cyan
                    worksheet.Cells[rowIndex, 5] = valorCyan;
                }
                else
                {
                    // Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("El valor en lblResultadoCyan no es válido para la conversión a decimal.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                decimal valorMagenta;
                if (decimal.TryParse(QuitarUnidades(lblResultadoMagenta.Text), out valorMagenta))
                {
                    worksheet.Cells[rowIndex, 6].NumberFormat = "0.00"; // Formato de celda para Magenta
                    worksheet.Cells[rowIndex, 6] = valorMagenta;
                }
                else
                {
                    // Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("El valor en lblResultadoMagenta no es válido para la conversión a decimal.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                decimal valorYellow;
                if (decimal.TryParse(QuitarUnidades(lblResultadoYellow.Text), out valorYellow))
                {
                    worksheet.Cells[rowIndex, 7].NumberFormat = "0.00"; // Formato de celda para Yellow
                    worksheet.Cells[rowIndex, 7] = valorYellow;
                }
                else
                {
                    // Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("El valor en lblResultadoYellow no es válido para la conversión a decimal.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                decimal valorBlack;
                if (decimal.TryParse(QuitarUnidades(lblResultadoBlack.Text), out valorBlack))
                {
                    worksheet.Cells[rowIndex, 8].NumberFormat = "0.00"; // Formato de celda para Black
                    worksheet.Cells[rowIndex, 8] = valorBlack;
                }
                else
                {
                    // Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("El valor en lblResultadoBlack no es válido para la conversión a decimal.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Agregar datos restantes
                worksheet.Cells[rowIndex, 1].NumberFormat = "000000"; // Formato de celda para productos con 6 dígitos y ceros iniciales
                worksheet.Cells[rowIndex, 1] = producto;

                // Formatear cantidad como cadena con 6 dígitos
                string cantidadFormateada = cantidad.ToString("0.00").PadLeft(6, '0');

                worksheet.Cells[rowIndex, 2].NumberFormat = "0.00"; // Formato de celda para cantidad
                worksheet.Cells[rowIndex, 2] = cantidadFormateada;

                worksheet.Cells[rowIndex, 3].NumberFormat = "0.00"; // Formato de celda para precio
                worksheet.Cells[rowIndex, 3] = precio;

                worksheet.Cells[rowIndex, 4].NumberFormat = "0.00"; // Formato de celda para total
                worksheet.Cells[rowIndex, 4] = total;

                // Incrementar el índice de fila
                rowIndex++;
            }
            excelApp.DisplayAlerts = false;
            workbook.Save();
            excelApp.DisplayAlerts = true;

            workbook.Close();
            CerrarExcel();
        }
        private string QuitarUnidades(string input)
        {
            // Mantener solo caracteres numéricos y un punto decimal
            return new string(input.Where(c => char.IsDigit(c) || c == '.').ToArray());
        }

        private void CerrarExcel()
        {
            try
            {
                // Guardar los cambios en el archivo
                workbook?.SaveAs(rutaCompleta);

                // Cerrar el libro de trabajo y la aplicación de Excel
                workbook?.Close();
                excelApp?.Quit();

                // Liberar los objetos de Excel para evitar la acumulación de instancias
                if (worksheet != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }

                if (workbook != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }

                if (excelApp != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }

                // Forzar la recolección de basura para liberar inmediatamente los recursos
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrar un mensaje de error
                MessageBox.Show($"Error al cerrar Excel: {ex.Message}");
            }
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