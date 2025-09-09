namespace InventarioFacturacion.vista
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            numerocomprobante = new DataGridViewTextBoxColumn();
            Cajero = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Totalventa = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, numerocomprobante, Cajero, Turno, Cliente, Totalventa, MetodoPago, Estado });
            dataGridView1.Location = new Point(40, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 66);
            dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // numerocomprobante
            // 
            numerocomprobante.HeaderText = "Numero De Comprobante";
            numerocomprobante.Name = "numerocomprobante";
            numerocomprobante.ReadOnly = true;
            numerocomprobante.Width = 130;
            // 
            // Cajero
            // 
            Cajero.HeaderText = "Cajero";
            Cajero.Name = "Cajero";
            Cajero.ReadOnly = true;
            Cajero.Width = 120;
            // 
            // Turno
            // 
            Turno.HeaderText = "Turno";
            Turno.Name = "Turno";
            Turno.ReadOnly = true;
            Turno.Width = 85;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 150;
            // 
            // Totalventa
            // 
            Totalventa.HeaderText = "Total De Ventas";
            Totalventa.Name = "Totalventa";
            Totalventa.ReadOnly = true;
            Totalventa.Width = 130;
            // 
            // MetodoPago
            // 
            MetodoPago.HeaderText = "Metodo De Pago";
            MetodoPago.Name = "MetodoPago";
            MetodoPago.ReadOnly = true;
            MetodoPago.Width = 120;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 140;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(40, 104);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(523, 35);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(610, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-6, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 450);
            Controls.Add(pictureBox3);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Name = "Reporte";
            Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn numerocomprobante;
        private DataGridViewTextBoxColumn Cajero;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Totalventa;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private PictureBox pictureBox3;
    }
}