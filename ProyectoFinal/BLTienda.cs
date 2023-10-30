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
            string query= "SELECT COUNT(*) FROM Empleados WHERE Usuario = @nombreUsuario AND Contraseña = @contraseña";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreUsuario", usu),
                 new SqlParameter("@contraseña", pass)
             };
            DAL.DAL dal = new DAL.DAL();
            int resultado = Convert.ToInt32( dal.ConsultaEscalar(query, parametros));

            return resultado;
        }

        public int ConsultaAcceso(String usu, String pass)
        {
            return getConsultaAcceso(usu, pass);
        }
    }
}
