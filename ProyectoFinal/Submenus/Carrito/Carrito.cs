using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using ProyectoFinal.Submenus.Carrito;

namespace ProyectoFinal.Submenus.Trabajadores
{
    public partial class Carrito : Form
    {
        private System.Timers.Timer timerEliminarContenido;
        private Tarjeta ventanaTarjeta;
        Productos ventanaProductos;
        private double sumaTotal = 0.0;
        private double sumaCyan = 0.0;
        private double sumaMagenta = 0.0;
        private double sumaYellow = 0.0;
        private double sumaBlack = 0.0;
        private bool ventanaProductosAbierta = false;
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
            Txtingdinero.TextChanged += Txtingdinero_TextChanged;
            RbTarjeta.CheckedChanged += RbTarjeta_CheckedChanged;


        }

        private void EliminarArchivoExcel()
        {
            // Obtén la ruta al archivo Excel
            string rutaDeCaja = ObtenerRutaDeCaja();

            try
            {
                // Verifica si el archivo existe antes de intentar eliminarlo
                if (File.Exists(rutaDeCaja))
                {
                    // Elimina el archivo Excel "Carrito"
                    File.Delete(rutaDeCaja);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el archivo Excel 'Carrito': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerRutaDeCaja()
        {
            // Obtén la ruta al directorio del ejecutable actual
            string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;

            // Construye la ruta completa al archivo Excel "Carrito"
            return Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "Carrito.xlsx");
        }
        private void Txtingdinero_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el contenido de Txtingdinero es vacío
            if (string.IsNullOrWhiteSpace(Txtingdinero.Text))
            {
                // Limpiar lblCambio si Txtingdinero está vacío
                lblCambio.Text = "0.00 ";
                return;
            }

            // Verificar si el contenido de Txtingdinero es un número válido
            if (double.TryParse(Txtingdinero.Text, out double dineroIngresado))
            {
                // Restar el dinero ingresado al total y mostrar la diferencia en lblCambio
                double cambio = dineroIngresado - sumaTotal;

                // Actualizar el texto de lblCambio
                lblCambio.Text = $" {cambio}";
            }
            else
            {
                // Mostrar un mensaje de error si el contenido no es un número válido
                // También podrías simplemente no hacer nada en este caso, según tus preferencias.
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txtingdinero.Text = ""; // Limpiar el TextBox si no es un número válido
            }
        }
        private void RbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTarjeta.Checked)
            {
                // Obtener el texto de lblTotalPag y eliminar el símbolo de dólar
                string totalPagText = lblTotalPag.Text.TrimStart('$');

                // Convertir el texto a un número decimal
                if (decimal.TryParse(totalPagText, out decimal totalPagDecimal))
                {
                    // Asignar el valor a Txtingdinero
                    Txtingdinero.Text = totalPagDecimal.ToString("F2");
                }
                else
                {
                    // Manejar el caso en el que no se pueda convertir a decimal
                    MessageBox.Show("Error al convertir el total a número decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarDatosDesdeExcel()
        {
            // Obtén la ruta al archivo Excel
            string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDeCaja = Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "Carrito.xlsx");

            sumaTotal = 0.0;
            sumaCyan = 0.0;
            sumaMagenta = 0.0;
            sumaYellow = 0.0;
            sumaBlack = 0.0;

            try
            {
                // Crear una aplicación Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(rutaDeCaja);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Asume que los datos están en la primera hoja

                // Obtén el rango de celdas con datos
                Excel.Range usedRange = worksheet.UsedRange;

                // Crear un DataTable
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Agregar solo las columnas "Producto", "Cantidad" y "Total" al DataTable
                foreach (var columnName in new[] { "Producto", "Cantidad", "Total" })
                {
                    // Asegurarse de que el nombre de la columna existe en la primera fila
                    int colIndex = FindColumnIndex(usedRange, columnName);
                    if (colIndex != -1)
                    {
                        dataTable.Columns.Add(columnName);
                    }
                    else
                    {
                        // Si la columna no se encuentra, agregar una columna con el nombre especificado
                        dataTable.Columns.Add(columnName);
                    }
                }

                // Comenzar desde la segunda fila para agregar las filas al DataTable
                for (int row = 2; row <= usedRange.Rows.Count; row++)
                {
                    // Crear una nueva fila
                    System.Data.DataRow dataRow = dataTable.NewRow();

                    // Obtener índices de las columnas "Producto", "Cantidad" y "Total"
                    int colProducto = FindColumnIndex(usedRange, "Producto");
                    int colCantidad = FindColumnIndex(usedRange, "Cantidad");
                    int colTotal = FindColumnIndex(usedRange, "Total");
                    int colCyan = FindColumnIndex(usedRange, "Cyan");
                    int colMagenta = FindColumnIndex(usedRange, "Magenta");
                    int colYellow = FindColumnIndex(usedRange, "Yellow");
                    int colBlack = FindColumnIndex(usedRange, "Black");

                    // Agregar los valores correspondientes a la fila del DataTable
                    dataRow["Producto"] = usedRange.Cells[row, colProducto].Value;
                    dataRow["Cantidad"] = usedRange.Cells[row, colCantidad].Value;
                    dataRow["Total"] = usedRange.Cells[row, colTotal].Value;

                    // Actualizar la suma total solo con el nuevo valor
                    sumaTotal += Convert.ToDouble(usedRange.Cells[row, colTotal].Value);
                    sumaCyan += (usedRange.Cells[row, colCyan].Value != null) ? Convert.ToDouble(usedRange.Cells[row, colCyan].Value) : 0.0;
                    sumaMagenta += (usedRange.Cells[row, colMagenta].Value != null) ? Convert.ToDouble(usedRange.Cells[row, colMagenta].Value) : 0.0;
                    sumaYellow += (usedRange.Cells[row, colYellow].Value != null) ? Convert.ToDouble(usedRange.Cells[row, colYellow].Value) : 0.0;
                    sumaBlack += (usedRange.Cells[row, colBlack].Value != null) ? Convert.ToDouble(usedRange.Cells[row, colBlack].Value) : 0.0;

                    // Agregar la fila al DataTable
                    dataTable.Rows.Add(dataRow);
                }

                ActualizarLabelSumaTotal();
                // Asignar el DataTable como DataSource del DataGridView usando Invoke para garantizar que se haga en el hilo principal
                this.Invoke((MethodInvoker)delegate
                {
                    DvgAcomulacioncarrito.DataSource = dataTable;
                });

                // Cierra la aplicación Excel
                excelApp.Quit();
            }
            catch (Exception ex)
            {

            }
        }
        private void ActualizarLabelSumaTotal()
        {
            // Asegúrate de realizar esta operación en el hilo principal
            this.Invoke((MethodInvoker)delegate
            {
                // Actualiza el texto del Label con la suma total
                lblTotalPag.Text = $" {sumaTotal}"; // Puedes ajustar el formato según tus necesidades
            });
        }

        private int FindColumnIndex(Excel.Range usedRange, string columnName)
        {
            // Buscar el índice de la columna por nombre en la primera fila
            for (int col = 1; col <= usedRange.Columns.Count; col++)
            {
                if (usedRange.Cells[1, col].Value?.ToString() == columnName)
                {
                    return col;
                }
            }
            return -1; // Devolver -1 si no se encuentra la columna
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            EliminarArchivoExcel();
            BLTienda bl = new BLTienda();
            DvgClientesLista.DataSource = bl.ObtenerTodosLosClientes();
            CargarDatosDesdeExcel();

        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Método llamado cuando el temporizador alcanza su intervalo
            // Puedes poner aquí el código para eliminar el contenido del archivo
            // Obtén la ruta al directorio del ejecutable actual
            string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "codigot.txt");

            try
            {
                // Elimina el contenido del archivo
                File.WriteAllText(rutaArchivo, string.Empty);

                // Recargar datos desde Excel después de cerrar el programa CMYK.exe
                CargarDatosDesdeExcel();
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
                    // Crear el proceso CMYK
                    Process procesoCMYK = new Process();
                    procesoCMYK.StartInfo.FileName = rutaAlEjecutable;

                    // Suscribirse al evento Exited para saber cuando se cierra la aplicación CMYK
                    procesoCMYK.EnableRaisingEvents = true;
                    procesoCMYK.Exited += (s, args) =>
                    {
                        // Llamar a la función CargarDatosDesdeExcel cuando CMYK se cierra
                        CargarDatosDesdeExcel();


                    };

                    // Iniciar el proceso del otro programa
                    procesoCMYK.Start();
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
                Process procesoCMYK = new Process();
                procesoCMYK.StartInfo.FileName = rutaAlEjecutable;

                // Suscribirse al evento Exited para saber cuando se cierra la aplicación CMYK
                procesoCMYK.EnableRaisingEvents = true;
                procesoCMYK.Exited += (s, args) =>
                {
                    // Llamar a la función CargarDatosDesdeExcel cuando CMYK se cierra
                    CargarDatosDesdeExcel();


                };

                // Iniciar el proceso del otro programa
                procesoCMYK.Start();
                // Verificar si el archivo ejecutable existe
                if (File.Exists(rutaAlEjecutable))
                {
                    // Iniciar el proceso del otro programa
                   
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
            // Verifica si el total es mayor a 0
            if (sumaTotal > 0)
            {
                // Validar que lblCambio sea mayor o igual a 0
                if (lblCambio.Text != "" && Convert.ToDouble(lblCambio.Text) >= 0)
                {
                    // Validar si está seleccionado RbTarjeta
                    if (RbTarjeta.Checked)
                    {
                        AbrirVentanaTarjeta();
                    }
                    else if (RbEfectivo.Checked)
                    {
                        // Aquí puedes agregar la lógica para el caso de RbEfectivo
                        // Por ejemplo, podrías abrir otro formulario o realizar alguna acción específica.
                        // ...
                    }
                    else
                    {
                        // Mostrar un mensaje indicando que se debe seleccionar una opción
                        MessageBox.Show("Por favor, selecciona un método de pago.");
                    }
                }
                else
                {
                    // Mostrar un mensaje indicando que el cambio debe ser mayor a 0
                    MessageBox.Show("El cambio debe ser mayor o igual a 0 para realizar la transacción.");
                }
            }
            else
            {
                // Mostrar un mensaje indicando que el total debe ser mayor a 0
                MessageBox.Show("El total debe ser mayor a 0 para realizar la transacción.");
            }
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


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Llama al método para restablecer los campos a sus valores iniciales
            RestablecerCampos();
            EliminarArchivoExcel();
        }

        private void RestablecerCampos()
        {
            // Restablece el contenido de los campos a cero o valores predeterminados
            txtClientes.Text = "";
            TxtCodigo.Text = "";
            lblTotalPag.Text = "0.00";
            TxtCodigo.Text = "";
            Txtingdinero.Text = "";
            lblCambio.Text = "0.00";
            DvgAcomulacioncarrito.DataSource = null;
            DvgAcomulacioncarrito.Rows.Clear();
            RbTarjeta.Checked = false;
            RbEfectivo.Checked = false;
            MessageBox.Show("La compra ha sido cancelada.", "Cancelación de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void AbrirVentanaProductos()
        {
            if (!ventanaProductosAbierta)
            {
                // Deshabilitar todos los botones en el formulario Carrito
                DeshabilitarBotones();

                // Crear una nueva instancia de la ventana Productos
                ventanaProductos = new Productos();

                // Suscribirse al evento Closed para saber cuando se cierra la ventana
                ventanaProductos.FormClosed += ProductosClosed;

                // Mostrar la ventana
                ventanaProductos.Show();

                ventanaProductosAbierta = true;
            }
            else
            {
                // La ventana ya está abierta, puedes realizar alguna acción adicional si es necesario
                MessageBox.Show("La ventana Productos ya está abierta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductosClosed(object sender, FormClosedEventArgs e)
        {
            // Este método se ejecutará cuando la ventana Productos se cierre

            // Realizar acciones adicionales aquí, por ejemplo, recargar datos o habilitar ciertos controles
            CargarDatosDesdeExcel();

            // Asignar null a la instancia de ventanaProductos
            ventanaProductos = null;

            // Indicar que la ventana ya no está abierta
            ventanaProductosAbierta = false;

            // Habilitar todos los botones en el formulario Carrito al cerrar la ventana
            HabilitarBotones();
        }


        // ... (Resto de tu código)

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            // Llamar al método para abrir la ventana de productos
            AbrirVentanaProductos();
        }

    }
}

