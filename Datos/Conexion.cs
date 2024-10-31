using MySql.Data.MySqlClient;

public class Conexion
{
    private string connectionString = "server=localhost;database=escrito;uid=root;pwd=almi1323;";
    private MySqlConnection connection;

    public MySqlConnection Conectarse()
    {
        if (connection == null)
        {
            connection = new MySqlConnection(connectionString);
        }

        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }

        return connection;
    }

    public void Desconectarse()
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}
