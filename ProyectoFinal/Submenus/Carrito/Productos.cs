using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProyectoFinal.Submenus.Carrito
{
    public partial class Productos : Form
    {
        private DataView _dvProductos; // Variable para almacenar la vista filtrada de los productos

        public Productos()
        {
            InitializeComponent();

            // Asociar eventos en el constructor
            DvgProductos.CellDoubleClick += DvgProductos_CellDoubleClick;
            TxtCantidad.TextChanged += TxtCantidad_TextChanged;
            TopMost = true;
        }
        private DataTable ObtenerTodosLosInventarios()
        {
            string query = "SELECT IdProductos, Cantidad, Nombre, Precio, Descuento, Descripcion, Marca FROM Productos";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            BLTienda bl = new BLTienda();
            DataTable dtProductos = bl.ObtenerTodosLosInventarios();
            _dvProductos = new DataView(dtProductos);

            DvgProductos.DataSource = _dvProductos;
            TxtProducto.TextChanged += TxtProducto_TextChanged;
            DvgProductos.CellDoubleClick += DvgProductos_CellDoubleClick;
        }

        private void TxtProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = TxtProducto.Text.Trim();
            if (!string.IsNullOrEmpty(filtro))
            {
                _dvProductos.RowFilter = $"Nombre LIKE '%{filtro}%'";
            }
            else
            {
                _dvProductos.RowFilter = string.Empty;
            }
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ActualizarArchivoExcel(string nombreProducto, decimal cantidad, decimal precioUnitario)
        {
            // Obtener la ruta del archivo Excel
            string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDeCaja = Path.Combine(directorioEjecutable, "..", "..", "..", "CMYK", "CMYK", "bin", "Debug", "net6.0-windows", "Carrito.xlsx");

            // Crear o abrir el archivo Excel
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Verificar si ya existe una instancia de Excel en ejecución
                try
                {
                    excelApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
                }
                catch (Exception)
                {
                    // No hay una instancia de Excel en ejecución, crear una nueva
                    excelApp = new Excel.Application();
                }

                // Crear o abrir el libro de trabajo
                workbook = excelApp.Workbooks.Open(rutaDeCaja);
                worksheet = workbook.Worksheets[1];

                // Resto del código...

                // Llenar las celdas con la información del producto
                int lastRow = worksheet.Cells[worksheet.Rows.Count, 1].End[Excel.XlDirection.xlUp].Row + 1;
                worksheet.Cells[lastRow, 1].NumberFormat = "@";
                worksheet.Cells[lastRow, 1].Value = nombreProducto;
                worksheet.Cells[lastRow, 2].Value = cantidad;
                worksheet.Cells[lastRow, 3].Value = precioUnitario;
                worksheet.Cells[lastRow, 4].Value = cantidad * precioUnitario;

                // Guardar y cerrar el libro de trabajo
                workbook.Save();
            }
            catch (Exception ex)
            {
                // Manejar excepciones...
                MessageBox.Show("Error al actualizar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Liberar objetos COM
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) workbook.Close(false); // Especifica false para no guardar cambios
                if (excelApp != null) excelApp.Quit();

                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }

            // Mostrar mensaje de éxito fuera del bloque try-finally
            MessageBox.Show("Información enviada a Excel correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    

        private void DvgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DvgProductos.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = DvgProductos.Rows[e.RowIndex];
                string nombreProducto = filaSeleccionada.Cells["Nombre"].Value.ToString();
                lblNombre.Text = nombreProducto;
                TxtCantidad.Clear();
                TxtCantidad.Enabled = true;
                TxtCantidad.Focus();
            }
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (DvgProductos.SelectedCells.Count > 0)
            {
                int rowIndex = DvgProductos.SelectedCells[0].RowIndex;
                if (DvgProductos.Rows[rowIndex].Cells["Precio"].Value != null)
                {
                    decimal precioUnitario = Convert.ToDecimal(DvgProductos.Rows[rowIndex].Cells["Precio"].Value);

                    if (decimal.TryParse(TxtCantidad.Text, out decimal cantidad))
                    {
                        decimal cantidadTotal = cantidad * precioUnitario;
                        lblCantidadtotal.Text = $" {cantidadTotal}";
                    }
                    else
                    {
                        lblCantidadtotal.Text = "Cantidad Total: N/A";
                    }
                }
            }
        }

        private void btnEnviaAcarrito_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblNombre.Text) && !string.IsNullOrEmpty(TxtCantidad.Text))
            {
                if (decimal.TryParse(TxtCantidad.Text, out decimal cantidad))
                {
                    // Obtener el precio de la fila seleccionada en dtProductos
                    int rowIndex = DvgProductos.SelectedCells[0].RowIndex;
                    decimal precioUnitario = Convert.ToDecimal(_dvProductos[rowIndex]["Precio"]);

                    // Llamar a ActualizarArchivoExcel con el precioUnitario
                    ActualizarArchivoExcel(lblNombre.Text, cantidad, precioUnitario);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de que todos los campos estén llenos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
