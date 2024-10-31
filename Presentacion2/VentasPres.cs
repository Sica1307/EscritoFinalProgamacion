using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Datos;
using iTextSharp.text; 
using iTextSharp.text.pdf; 
using Logica;

namespace Presentacion
{
    public partial class VentasPres : Form
    {
        private VentasLog logicaVentas = new VentasLog();

        public VentasPres()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPropiedad = int.Parse(txtIdPropiedad.Text);
                logicaVentas.InsertarVenta(idPropiedad);
                MessageBox.Show("Venta guardada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdPropiedad.Clear();
        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            List<VentasDatos.Venta> ventas = logicaVentas.ObtenerTodasLasVentas();
            dataGridViewVentas.DataSource = ventas;
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPropiedad.Text, out int idVenta))
            {
                GenerarBoletaVenta(idVenta);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de venta válido.");
            }
        }

        private void GenerarBoletaVenta(int idVenta)
        {
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BoletaVenta.pdf");

                using (FileStream fs = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document(); // Usar Document de iTextSharp
                    PdfWriter.GetInstance(document, fs);
                    document.Open();

                    // Obtener información de la venta
                    var venta = logicaVentas.ObtenerTodasLasVentas().Find(v => v.Id == idVenta);

                    // Crear el contenido del PDF
                    document.Add(new Paragraph("Boleta de Venta"));
                    document.Add(new Paragraph("ID de Venta: " + venta.Id));
                    document.Add(new Paragraph("Precio: " + venta.Precio));
                    document.Add(new Paragraph("IVA: " + venta.Iva));
                    document.Add(new Paragraph("Descuento: " + venta.Descuento));
                    document.Add(new Paragraph("Precio Total: " + venta.PrecioTotal));
                    document.Add(new Paragraph("ID Propiedad: " + venta.Id_Prop));

                    document.Close();
                }

                MessageBox.Show("Boleta generada correctamente en el escritorio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la boleta: " + ex.Message);
            }
        }
    }
}
