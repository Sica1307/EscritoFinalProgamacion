using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Datos;
using Logica;

namespace Presentacion
{
    public partial class PropiedadesPres : Form
    {
        private PropiedadesLog logicaPropiedades = new PropiedadesLog();

        public PropiedadesPres()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = comboBoxTipo.SelectedItem.ToString();
                string direccion = txtDireccion.Text;
                decimal metrosCuadrados = decimal.Parse(txtMetrosCuadrados.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);

                logicaPropiedades.InsertarPropiedad(tipo, direccion, metrosCuadrados, precio);
                MessageBox.Show("Propiedad guardada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la propiedad: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string tipo = comboBoxTipo.SelectedItem.ToString();
                string direccion = txtDireccion.Text;
                decimal metrosCuadrados = decimal.Parse(txtMetrosCuadrados.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);

                logicaPropiedades.ModificarPropiedad(id, tipo, direccion, metrosCuadrados, precio);
                MessageBox.Show("Propiedad modificada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la propiedad: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                logicaPropiedades.EliminarPropiedad(id);
                MessageBox.Show("Propiedad eliminada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la propiedad: " + ex.Message);
            }
        }

        private void btnCargarPropiedades_Click(object sender, EventArgs e)
        {
            List<PropiedadesDatos.Propiedad> propiedades = logicaPropiedades.ObtenerTodasLasPropiedades();
            dataGridViewPropiedades.DataSource = propiedades;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            comboBoxTipo.SelectedIndex = -1;
            txtDireccion.Clear();
            txtMetrosCuadrados.Clear();
            txtPrecio.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }
}
