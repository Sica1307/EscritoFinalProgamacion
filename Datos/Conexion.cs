using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        private string connectionString = "server=localhost;database=escrito;uid=root;pwd=almi1323;";

        public MySqlConnection CrearConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
