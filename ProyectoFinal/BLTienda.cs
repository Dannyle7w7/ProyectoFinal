using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class BLTienda
    {
        int ID;
        private DataTable getUsuarioByID()
        {
            String Query = "select * from Usuario where ID='" + ID + "'";
            DAL.DAL objDAL = new DAL.DAL();
            return (objDAL.Consulta(Query));
        }

        public DataTable ConsultaUsuario()
        {
            return getUsuarioByID();
        }
    }
}
