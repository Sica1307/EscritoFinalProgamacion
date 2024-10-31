using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class VentasDatos
    {
        private Conexion conexion = new Conexion();

        public class Venta
        {
            public int Id { get; set; }
            public decimal Precio { get; set; }
            public decimal Iva { get; set; }
            public decimal Descuento { get; set; }
            public decimal PrecioTotal { get; set; }
            public int Id_Prop { get; set; }
        }

        public void InsertarVenta(Venta venta)
        {
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO Venta (Precio, Iva, Descuento, PrecioTotal, Id_Prop) VALUES (@Precio, @Iva, @Descuento, @PrecioTotal, @Id_Prop)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Precio", venta.Precio);
                    cmd.Parameters.AddWithValue("@Iva", venta.Iva);
                    cmd.Parameters.AddWithValue("@Descuento", venta.Descuento);
                    cmd.Parameters.AddWithValue("@PrecioTotal", venta.PrecioTotal);
                    cmd.Parameters.AddWithValue("@Id_Prop", venta.Id_Prop);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Venta> ObtenerTodasLasVentas()
        {
            List<Venta> listaVentas = new List<Venta>();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Venta";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta
                            {
                                Id = reader.GetInt32("Id"),
                                Precio = reader.GetDecimal("Precio"),
                                Iva = reader.GetDecimal("Iva"),
                                Descuento = reader.GetDecimal("Descuento"),
                                PrecioTotal = reader.GetDecimal("PrecioTotal"),
                                Id_Prop = reader.GetInt32("Id_Prop")
                            };
                            listaVentas.Add(venta);
                        }
                    }
                }
            }
            return listaVentas;
        }
    }
}
