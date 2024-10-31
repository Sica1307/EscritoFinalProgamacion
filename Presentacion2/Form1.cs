using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPropiedades_Click(object sender, EventArgs e)
        {
            PropiedadesPres propiedadesForm = new PropiedadesPres();
            propiedadesForm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentasPres ventasForm = new VentasPres();
            ventasForm.Show();
        }
    }
}
