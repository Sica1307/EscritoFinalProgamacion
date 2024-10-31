namespace Presentacion
{
    partial class VentasPres
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Button btnCargarVentas;
        private System.Windows.Forms.TextBox txtIdPropiedad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIdPropiedad;
        private System.Windows.Forms.Button btnGenerarBoleta; // Nuevo botón para generar boleta

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtIdPropiedad = new TextBox();
            lblIdPropiedad = new Label();
            btnGuardar = new Button();
            dataGridViewVentas = new DataGridView();
            btnCargarVentas = new Button();
            btnGenerarBoleta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            SuspendLayout();
            // 
            // txtIdPropiedad
            // 
            txtIdPropiedad.Location = new Point(150, 20);
            txtIdPropiedad.Name = "txtIdPropiedad";
            txtIdPropiedad.Size = new Size(200, 23);
            txtIdPropiedad.TabIndex = 0;
            // 
            // lblIdPropiedad
            // 
            lblIdPropiedad.AutoSize = true;
            lblIdPropiedad.Location = new Point(20, 20);
            lblIdPropiedad.Name = "lblIdPropiedad";
            lblIdPropiedad.Size = new Size(75, 15);
            lblIdPropiedad.TabIndex = 1;
            lblIdPropiedad.Text = "ID Propiedad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Location = new Point(20, 96);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.Size = new Size(572, 200);
            dataGridViewVentas.TabIndex = 3;
            // 
            // btnCargarVentas
            // 
            btnCargarVentas.Location = new Point(150, 60);
            btnCargarVentas.Name = "btnCargarVentas";
            btnCargarVentas.Size = new Size(120, 30);
            btnCargarVentas.TabIndex = 4;
            btnCargarVentas.Text = "Cargar Ventas";
            btnCargarVentas.UseVisualStyleBackColor = true;
            btnCargarVentas.Click += btnCargarVentas_Click;
            // 
            // btnGenerarBoleta
            // 
            btnGenerarBoleta.Location = new Point(290, 60);
            btnGenerarBoleta.Name = "btnGenerarBoleta";
            btnGenerarBoleta.Size = new Size(120, 30);
            btnGenerarBoleta.TabIndex = 5;
            btnGenerarBoleta.Text = "Generar Boleta";
            btnGenerarBoleta.UseVisualStyleBackColor = true;
            btnGenerarBoleta.Click += btnGenerarBoleta_Click;
            // 
            // VentasPres
            // 
            ClientSize = new Size(630, 350);
            Controls.Add(btnCargarVentas);
            Controls.Add(dataGridViewVentas);
            Controls.Add(btnGenerarBoleta);
            Controls.Add(btnGuardar);
            Controls.Add(lblIdPropiedad);
            Controls.Add(txtIdPropiedad);
            Name = "VentasPres";
            Text = "Gestionar Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
