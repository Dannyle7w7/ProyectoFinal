using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL
    {
        private string CadenaConexion= "Persist Security Info=False;User ID=sa;Password=Alecota;Initial Catalog=UACHFINAL;Server=DannyleZephyrus";

        public DataTable Consulta(string query, SqlParameter[] parametros = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    new SqlDataAdapter(cmd).Fill(dataTable);
                }
            }
            return dataTable;
        }

        public object ConsultaEscalar(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        public bool Transaccion(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
