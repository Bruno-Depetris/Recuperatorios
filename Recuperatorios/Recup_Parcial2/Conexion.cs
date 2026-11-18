using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial2 {
    public class Conexion {

        private static string connectionString =
            "Data Source=DESKTOP-OANB4MT;" +
            "Integrated Security=True;" +
            "Persist Security Info=False;" +
            "Pooling=False;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;" +
            "Application Name=Recuperatorios";

        SqlConnection conn = new SqlConnection(connectionString);

        private void AbrirConexion() {
            if(conn.State == System.Data.ConnectionState.Closed) {
                conn.Open();
            }
        }

        private void CerrarConexion() {
            if (conn.State == System.Data.ConnectionState.Open) {
                conn.Close();
            }
           
        }

        public SqlDataReader Leer(string consulta) {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public bool Ejecutar(string consulta) {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand(consulta, conn);
            int filasAfectadas = cmd.ExecuteNonQuery();
            CerrarConexion();
            return filasAfectadas > 0;
        }

    }
}
