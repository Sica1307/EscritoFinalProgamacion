namespace Presentacion
{
    partial class PropiedadesPres
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.Button btnCargarPropiedades;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMetrosCuadrados;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMetrosCuadrados;
        private System.Windows.Forms.Label lblPrecio;

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
            txtId = new TextBox();
            lblId = new Label();
            comboBoxTipo = new ComboBox();
            txtDireccion = new TextBox();
            txtMetrosCuadrados = new TextBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dataGridViewPropiedades = new DataGridView();
            btnCargarPropiedades = new Button();
            lblTipo = new Label();
            lblDireccion = new Label();
            lblMetrosCuadrados = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPropiedades).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 9;
            lblId.Text = "ID";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.Items.AddRange(new object[] { "Casa", "Apartamento", "Terreno" });
            comboBoxTipo.Location = new Point(150, 60);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(200, 23);
            comboBoxTipo.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(150, 100);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtMetrosCuadrados
            // 
            txtMetrosCuadrados.Location = new Point(150, 140);
            txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            txtMetrosCuadrados.Size = new Size(200, 23);
            txtMetrosCuadrados.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 180);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(130, 220);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 30);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(240, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(150, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGridViewPropiedades
            // 
            dataGridViewPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPropiedades.Location = new Point(20, 312);
            dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            dataGridViewPropiedades.Size = new Size(524, 200);
            dataGridViewPropiedades.TabIndex = 10;
            // 
            // btnCargarPropiedades
            // 
            btnCargarPropiedades.Location = new Point(424, 260);
            btnCargarPropiedades.Name = "btnCargarPropiedades";
            btnCargarPropiedades.Size = new Size(120, 30);
            btnCargarPropiedades.TabIndex = 9;
            btnCargarPropiedades.Text = "Cargar Propiedades";
            btnCargarPropiedades.UseVisualStyleBackColor = true;
            btnCargarPropiedades.Click += btnCargarPropiedades_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(20, 60);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(20, 100);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección";
            // 
            // lblMetrosCuadrados
            // 
            lblMetrosCuadrados.AutoSize = true;
            lblMetrosCuadrados.Location = new Point(20, 140);
            lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            lblMetrosCuadrados.Size = new Size(104, 15);
            lblMetrosCuadrados.TabIndex = 7;
            lblMetrosCuadrados.Text = "Metros Cuadrados";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(20, 180);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // PropiedadesPres
            // 
            ClientSize = new Size(600, 550);
            Controls.Add(dataGridViewPropiedades);
            Controls.Add(btnCargarPropiedades);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblTipo);
            Controls.Add(comboBoxTipo);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblMetrosCuadrados);
            Controls.Add(txtMetrosCuadrados);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Name = "PropiedadesPres";
            Text = "Gestionar Propiedades";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPropiedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
