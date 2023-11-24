using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ProyectoFinal
{
    internal class BLTienda
    {

        private int getConsultaAcceso(String usu, String pass)
        {
            string query = "SELECT COUNT(*) FROM Empleados WHERE Usuario = @nombreUsuario AND Contraseña = @contraseña And Estado=1";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreUsuario", usu),
                 new SqlParameter("@contraseña", pass)
             };
            DAL.DAL dal = new DAL.DAL();
            int resultado = Convert.ToInt32(dal.ConsultaEscalar(query, parametros));

            return resultado;
        }

        public int ConsultaAcceso(String usu, String pass)
        {
            return getConsultaAcceso(usu, pass);
        }
        public int UsuarioExistencia(String usu)
        {
            string query = "SELECT COUNT(*) FROM Empleados WHERE Usuario = @nombreUsuario ";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreUsuario", usu),
           
             };
            DAL.DAL dal = new DAL.DAL();
            int resultado = Convert.ToInt32(dal.ConsultaEscalar(query, parametros));

            return resultado;
        }

            private int getConsultaPuesto(String usu, String pass)
        {
            string query = "SELECT Puesto FROM Empleados WHERE Usuario = @nombreUsuario AND Contraseña = @contraseña";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreUsuario", usu),
                 new SqlParameter("@contraseña", pass)
             };
            DAL.DAL dal = new DAL.DAL();
            int resultado = Convert.ToInt32(dal.ConsultaEscalar(query, parametros));

            return resultado;
        }

        public int ConsultaPuesto(String usu, String pass)
        {
            return getConsultaPuesto(usu, pass);
        }

        private void GuardarEmpleado(string usuario, string contraseña, string nombre, byte[] imagen, bool estado, int puesto)
        {
            string query = "INSERT INTO Empleados (Usuario, Contraseña, Nombre, Foto, Estado,Puesto) VALUES (@usuario, @contraseña, @nombre, @foto, @estado,@puesto)";
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@usuario", usuario),
            new SqlParameter("@contraseña", contraseña),
            new SqlParameter("@nombre", nombre),
            new SqlParameter("@foto", SqlDbType.VarBinary) { Value = imagen },
            new SqlParameter("@estado", estado),
            new SqlParameter("@puesto", puesto)
            };
            DAL.DAL dal = new DAL.DAL();
            dal.Transaccion(query, parametros); // Utilizamos el método de transacción del DAL
        }

        public void GuardarEmpleado(string usuario, string contraseña, string nombre, System.Drawing.Image foto, bool estado, int puesto)
        {
            // Convertimos la imagen a un arreglo de bytes
            byte[] imagenBytes = ImageToByteArray(foto);

            GuardarEmpleado(usuario, contraseña, nombre, imagenBytes, estado, puesto);
        }

        private void ActualizarEmpleado(string id, string usuario, string contraseña, string nombre, byte[] imagen, bool estado, int puesto)
        {
            string query = "UPDATE Empleados SET Usuario = @usuario, Contraseña = @contraseña, Nombre = @nombre, Foto = @foto, Estado = @estado, Puesto = @puesto WHERE IdEmpleados = @id";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@usuario", usuario),
        new SqlParameter("@contraseña", contraseña),
        new SqlParameter("@nombre", nombre),
        new SqlParameter("@foto", SqlDbType.VarBinary) { Value = imagen },
        new SqlParameter("@estado", estado),
        new SqlParameter("@puesto", puesto),
        new SqlParameter("@id", id)
            };
            DAL.DAL dal = new DAL.DAL();
            dal.Transaccion(query, parametros); // Utilizamos el método de transacción del DAL
        }

        public void PushActualizarEmpleado(string id ,string usuario, string contraseña, string nombre, System.Drawing.Image foto, bool estado, int puesto)
        {
            // Convertimos la imagen a un arreglo de bytes
            byte[] imagenBytes = ImageToByteArray(foto);

            ActualizarEmpleado(id ,usuario, contraseña, nombre, imagenBytes, estado, puesto);
        }
        // Convierte una imagen a un arreglo de bytes
        private byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public int ConsultaultimoID() {
            string query = "SELECT MAX(IdEmpleados) FROM Empleados";
            DAL.DAL dal = new DAL.DAL();
            int resultado = Convert.ToInt32(dal.ConsultaEscalar(query));
            return resultado;
        }
        private System.Drawing.Image getFoto(String usu)
        {
            string query = "SELECT Foto FROM Empleados WHERE Usuario = @nombreUsuario ";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@nombreUsuario", usu)
             };
            DAL.DAL dal = new DAL.DAL();
            byte[] imagenBytes = dal.ConsultaEscalar(query, parametros) as byte[];

            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                // Ahora, convertimos el arreglo de bytes a una imagen
                System.Drawing.Image foto = ByteArrayToImage(imagenBytes);
                return foto;
            }
            else
            {
                // Si no se encontró ninguna imagen, puedes devolver null o algún valor predeterminado.
                return null;
            }
        }

        public System.Drawing.Image ConsulaFoto(String usu)
        {
            return getFoto(usu);
        }

        private System.Drawing.Image getIDFoto(String ID)
        {
            string query = "SELECT Foto FROM Empleados WHERE IdEmpleados = @id ";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@id", ID)
             };
            DAL.DAL dal = new DAL.DAL();
            byte[] imagenBytes = dal.ConsultaEscalar(query, parametros) as byte[];

            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                // Ahora, convertimos el arreglo de bytes a una imagen
                System.Drawing.Image foto = ByteArrayToImage(imagenBytes);
                return foto;
            }
            else
            {
                // Si no se encontró ninguna imagen, puedes devolver null o algún valor predeterminado.
                return null;
            }
        }

        public System.Drawing.Image ConsulaFotoID(String ID)
        {
            return getIDFoto(ID);
        }

        public System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArray);
            System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);
            return imagen;
        }


        ///Todo estos codigos es para el filtro de busqueda de la forma empleados

        public DataTable ObtenerTodosLosProveedores()
        {
            string query = "SELECT IdProveedores,Nombre,Dirrecion FROM Proveedores";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }

        public DataTable ObtenerTodosLosInventarios()
        {
            string query = "SELECT IdProductos,Cantidad,Nombre,Precio,Descuento,Descripcion,Marca FROM Productos";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }

        public DataTable ObtenerTodosLosClientes()
        {
            
            string query = "SELECT IdClientes,Nombre,RFC,[Razon Social],Calle,NumExt,NumInt,Colonia,Municipio,[Codigo Postal],Estado,[Regimen Fiscal],[Uso de CFDI],Telefono,Correo FROM Clientes";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }

        public DataTable ObtenerTodasLasVentas()
        {
            string query = "Select IdCompras,Fecha,Total,IdClientes,IdEmpleados,IdMetodoPago,IdDetalleCompras From Compras";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }
        public bool ExistenciaID(string ID)
        {
            string query = "SELECT COUNT(*) AS Existencia FROM Empleados WHERE IdEmpleados = @id ";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", ID)
             };
            DAL.DAL dal = new DAL.DAL();
            return Convert.ToBoolean(dal.ConsultaEscalar(query,parametros));
        }

        public DataTable ObtenerEmpleadoIDparaUPDATE(string ID)
        {
            string query = "Select  Usuario,Puesto,Nombre,Contraseña,Estado from Empleados where IdEmpleados=@id ";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", ID)
             };
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query,parametros);
        }
        //Estos son para todos sin buscar
        public DataTable ObtenerTodosLosEmpleados()
        {
            string query = "SELECT IdEmpleados,Usuario,Nombre,CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,CASE WHEN Puesto = 0 THEN 'Empleado' ELSE 'Jefe' END AS Puesto FROM Empleados";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }

        public DataTable ObtenerTodosLosEmpleadosActivos()
        {
            string query = "SELECT IdEmpleados, Usuario, Nombre, CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,CASE WHEN Puesto = 0 THEN 'Empleado' ELSE 'Jefe' END AS Puesto FROM Empleados WHERE Estado = 1";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }

        public DataTable ObtenerTodosLosEmpleadosInactivos()
        {
            string query = "SELECT IdEmpleados, Usuario, Nombre, CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,CASE WHEN Puesto = 0 THEN 'Empleado' ELSE 'Jefe' END AS Puesto FROM Empleados WHERE Estado =0";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }

        //Aqui seran para buscar

        public DataTable BuscarEmpleados(string searchText)
        {
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = @"
            DECLARE @searchText NVARCHAR(MAX);
            SET @searchText = @searchParam;

            IF @searchText IS NOT NULL AND @searchText <> ''
            BEGIN
                SELECT IdEmpleados, Usuario, Nombre, 
                       CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                       CASE WHEN Puesto = 0 THEN 'Empleado' ELSE 'Jefe' END AS Puesto
                FROM Empleados 
                WHERE Usuario LIKE '%' + @searchText + '%' 
                   OR Nombre LIKE '%' + @searchText + '%' 
                   OR CONVERT(NVARCHAR(MAX), IdEmpleados) LIKE '%' + @searchText + '%';
            END
            ELSE
                SELECT NULL AS Resultado;";

                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@searchParam", SqlDbType.NVarChar) { Value = searchText }
                };

                DAL.DAL dal = new DAL.DAL();
                return dal.Consulta(query, parametros);
            }

            return null; // Si el texto de búsqueda es vacío o nulo, retornamos null
        }

        public DataTable BuscarEmpleadosActivos(string searchText)
        {
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = @"
            DECLARE @searchText NVARCHAR(MAX);
            SET @searchText = @searchParam;

            IF @searchText IS NOT NULL AND @searchText <> ''
            BEGIN
                SELECT IdEmpleados, Usuario, Nombre,
                       CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado ,
                       CASE WHEN Puesto = 0 THEN 'Empleado' ELSE 'Jefe' END AS Puesto
                FROM Empleados 
                WHERE (Usuario LIKE '%' + @searchText + '%' 
                   OR Nombre LIKE '%' + @searchText + '%' 
                   OR CONVERT(NVARCHAR(MAX), IdEmpleados) LIKE '%' + @searchText + '%')
                   AND Estado = 1; -- Agregamos esta condición para filtrar por empleados activos.
            END
            ELSE
                SELECT NULL AS Resultado;";

                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@searchParam", SqlDbType.NVarChar) { Value = searchText }
                };

                DAL.DAL dal = new DAL.DAL();
                return dal.Consulta(query, parametros);
            }

            return null; // Si el texto de búsqueda es vacío o nulo, retornamos null
        }

        public DataTable BuscarEmpleadosInactivos(string searchText)
        {
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = @"
            DECLARE @searchText NVARCHAR(MAX);
            SET @searchText = @searchParam;

            IF @searchText IS NOT NULL AND @searchText <> ''
            BEGIN
                SELECT IdEmpleados, Usuario, Nombre,
                       CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado, 
CASE WHEN Puesto = 0 THEN 'Empleado' ELSE 'Jefe' END AS Puesto
                FROM Empleados 
                WHERE (Usuario LIKE '%' + @searchText + '%' 
                   OR Nombre LIKE '%' + @searchText + '%' 
                   OR CONVERT(NVARCHAR(MAX), IdEmpleados) LIKE '%' + @searchText + '%')
                   AND Estado = 0; -- Agregamos esta condición para filtrar por empleados activos.
            END
            ELSE
                SELECT NULL AS Resultado;";

                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@searchParam", SqlDbType.NVarChar) { Value = searchText }
                };

                DAL.DAL dal = new DAL.DAL();
                return dal.Consulta(query, parametros);
            }

            return null; // Si el texto de búsqueda es vacío o nulo, retornamos null
        }




        //ESTA PARTE ES PARA LA TABLA DE PROVEEDORES

        public DataTable ObtenerProveedores()
        {
            string query = "SELECT * FROM Proveedores";
            DAL.DAL dal = new DAL.DAL();
            return dal.Consulta(query);
        }


        public void AgregarProveedor(string nombre, string direccion)
        {
            string query = "INSERT INTO Proveedores (Nombre, Dirrecion) VALUES (@nombre, @direccion)";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@nombre", nombre),
        new SqlParameter("@direccion", direccion)
            };

            DAL.DAL dal = new DAL.DAL();
            dal.Transaccion(query, parametros);
        }

        public void EliminarProveedor(int idProveedor)
        {
            string query = "DELETE FROM Proveedores WHERE IdProveedores = @idProveedor";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@idProveedor", idProveedor)
            };

            DAL.DAL dal = new DAL.DAL();
            dal.Transaccion(query, parametros);
        }

        public void ModificarProveedor(int idProveedor, string nombre, string direccion)
        {
            string query = "UPDATE Proveedores SET Nombre = @nombre, Dirrecion = @direccion WHERE IdProveedores = @idProveedor";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@nombre", nombre),
        new SqlParameter("@direccion", direccion),
        new SqlParameter("@idProveedor", idProveedor)
            };

            DAL.DAL dal = new DAL.DAL();
            dal.Transaccion(query, parametros);
        }


        public DataRow ObtenerProveedorPorId(int idProveedor)
        {
            string query = "SELECT * FROM Proveedores WHERE IdProveedores = @idProveedor";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@idProveedor", idProveedor)
            };

            DAL.DAL dal = new DAL.DAL();
            DataTable resultado = dal.Consulta(query, parametros);

            // Verificar si se encontró algún proveedor
            if (resultado.Rows.Count > 0)
            {
                return resultado.Rows[0];
            }
            else
            {
                return null; // No se encontró ningún proveedor para el ID proporcionado
            }
        }

        public bool ExisteProveedor(int id)
        {
            // Lógica para verificar si el proveedor con el ID dado existe en la base de datos
            // Aquí asumimos que tienes un método ObtenerProveedorPorId en tu clase BLTienda
            DataRow proveedor = ObtenerProveedorPorId(id);

            // Devolver true si el proveedor existe, false en caso contrario
            return proveedor != null;
        }



    }

}
