using System.Collections.Generic;
using Datos;

namespace Logica
{
    public class VentasLog
    {
        private VentasDatos datosVentas = new VentasDatos();
        private PropiedadesLog propiedadesLog = new PropiedadesLog();

        public void InsertarVenta(int idPropiedad)
        {
            decimal precioBase = propiedadesLog.ObtenerPrecioPropiedadPorId(idPropiedad);
            string tipoPropiedad = propiedadesLog.ObtenerTipoPropiedadPorId(idPropiedad);

            decimal iva = precioBase * 0.22m;
            decimal descuento = tipoPropiedad == "Terreno" ? precioBase * 0.15m : 0;
            decimal precioTotal = precioBase + iva - descuento;

            datosVentas.InsertarVenta(new VentasDatos.Venta
            {
                Precio = precioBase,
                Iva = iva,
                Descuento = descuento,
                PrecioTotal = precioTotal,
                Id_Prop = idPropiedad
            });
        }

        public List<VentasDatos.Venta> ObtenerTodasLasVentas()
        {
            return datosVentas.ObtenerTodasLasVentas();
        }
    }
}
