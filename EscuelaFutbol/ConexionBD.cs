using System;
using System.Data.SqlClient;

namespace EscuelaFutbol
{
    public class ConexionBD
    {
        public static SqlConnection obtenerConexion()
        {
            // Reemplazar con la cadena de conexión correcta
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EscuelaFutbol;Data Source=SPARKS-PC\\SQLEXPRESS";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}