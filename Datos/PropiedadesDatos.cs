using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class PropiedadesDatos
    {
        private Conexion conexion = new Conexion();

        public class Propiedad
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
            public string Direccion { get; set; }
            public decimal MetrosCuadrados { get; set; }
            public decimal Precio { get; set; }
        }

        public void InsertarPropiedad(Propiedad propiedad)
        {
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO Propiedades (Tipo, Direccion, MetrosCuadrados, Precio) VALUES (@Tipo, @Direccion, @MetrosCuadrados, @Precio)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tipo", propiedad.Tipo);
                    cmd.Parameters.AddWithValue("@Direccion", propiedad.Direccion);
                    cmd.Parameters.AddWithValue("@MetrosCuadrados", propiedad.MetrosCuadrados);
                    cmd.Parameters.AddWithValue("@Precio", propiedad.Precio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ModificarPropiedad(Propiedad propiedad)
        {
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "UPDATE Propiedades SET Tipo = @Tipo, Direccion = @Direccion, MetrosCuadrados = @MetrosCuadrados, Precio = @Precio WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tipo", propiedad.Tipo);
                    cmd.Parameters.AddWithValue("@Direccion", propiedad.Direccion);
                    cmd.Parameters.AddWithValue("@MetrosCuadrados", propiedad.MetrosCuadrados);
                    cmd.Parameters.AddWithValue("@Precio", propiedad.Precio);
                    cmd.Parameters.AddWithValue("@Id", propiedad.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPropiedad(int id)
        {
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "DELETE FROM Propiedades WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Propiedad> ObtenerTodasLasPropiedades()
        {
            List<Propiedad> listaPropiedades = new List<Propiedad>();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Propiedades";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Propiedad propiedad = new Propiedad
                            {
                                Id = reader.GetInt32("Id"),
                                Tipo = reader.GetString("Tipo"),
                                Direccion = reader.GetString("Direccion"),
                                MetrosCuadrados = reader.GetDecimal("MetrosCuadrados"),
                                Precio = reader.GetDecimal("Precio")
                            };
                            listaPropiedades.Add(propiedad);
                        }
                    }
                }
            }
            return listaPropiedades;
        }

        public string ObtenerTipoPropiedadPorId(int idPropiedad)
        {
            string tipoPropiedad = string.Empty;
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "SELECT Tipo FROM Propiedades WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idPropiedad);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipoPropiedad = reader["Tipo"].ToString();
                        }
                    }
                }
            }
            return tipoPropiedad;
        }

        public decimal ObtenerPrecioPropiedadPorId(int idPropiedad)
        {
            decimal precio = 0;
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "SELECT Precio FROM Propiedades WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idPropiedad);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            precio = reader.GetDecimal("Precio");
                        }
                    }
                }
            }
            return precio;
        }
    }
}
