namespace Presentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnPropiedades;
        private System.Windows.Forms.Button btnVentas;

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
            this.btnPropiedades = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnPropiedades
            this.btnPropiedades.Location = new System.Drawing.Point(50, 50);
            this.btnPropiedades.Name = "btnPropiedades";
            this.btnPropiedades.Size = new System.Drawing.Size(200, 50);
            this.btnPropiedades.TabIndex = 0;
            this.btnPropiedades.Text = "Gestionar Propiedades";
            this.btnPropiedades.UseVisualStyleBackColor = true;
            this.btnPropiedades.Click += new System.EventHandler(this.btnPropiedades_Click);

            // btnVentas
            this.btnVentas.Location = new System.Drawing.Point(50, 120);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 50);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Gestionar Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnPropiedades);
            this.Controls.Add(this.btnVentas);
            this.Name = "Form1";
            this.Text = "Sistema de Gestión";
            this.ResumeLayout(false);
        }
    }
}
