using System.Collections.Generic;
using Datos;

namespace Logica
{
    public class PropiedadesLog
    {
        private PropiedadesDatos datosPropiedades = new PropiedadesDatos();

        public void InsertarPropiedad(string tipo, string direccion, decimal metrosCuadrados, decimal precio)
        {
            datosPropiedades.InsertarPropiedad(new PropiedadesDatos.Propiedad
            {
                Tipo = tipo,
                Direccion = direccion,
                MetrosCuadrados = metrosCuadrados,
                Precio = precio
            });
        }

        public void ModificarPropiedad(int id, string tipo, string direccion, decimal metrosCuadrados, decimal precio)
        {
            datosPropiedades.ModificarPropiedad(new PropiedadesDatos.Propiedad
            {
                Id = id,
                Tipo = tipo,
                Direccion = direccion,
                MetrosCuadrados = metrosCuadrados,
                Precio = precio
            });
        }

        public void EliminarPropiedad(int id)
        {
            datosPropiedades.EliminarPropiedad(id);
        }

        public List<PropiedadesDatos.Propiedad> ObtenerTodasLasPropiedades()
        {
            return datosPropiedades.ObtenerTodasLasPropiedades();
        }

        public string ObtenerTipoPropiedadPorId(int idPropiedad)
        {
            return datosPropiedades.ObtenerTipoPropiedadPorId(idPropiedad);
        }

        public decimal ObtenerPrecioPropiedadPorId(int idPropiedad)
        {
            return datosPropiedades.ObtenerPrecioPropiedadPorId(idPropiedad);
        }
    }
}
