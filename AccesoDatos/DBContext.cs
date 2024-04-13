using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class DBContext
    {
        private SqlConnection conn;
        public string? connectionString;

        public DBContext()
        {
            Configurar();
        }

        private void Configurar()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public DataTable Consultar(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    SqlDataReader dr;
                    conn.Open();
                    cmd.Connection = conn;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }

        public void Ejecutar(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); 
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }
    }
}
