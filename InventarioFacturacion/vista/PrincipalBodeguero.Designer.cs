namespace InventarioFacturacion.vista
{
    partial class PrincipalBodeguero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalBodeguero));
            PanelInventario = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PanelContenedor = new Panel();
            PanelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelInventario
            // 
            PanelInventario.BorderStyle = BorderStyle.FixedSingle;
            PanelInventario.Controls.Add(label4);
            PanelInventario.Controls.Add(pictureBox4);
            PanelInventario.Controls.Add(pictureBox3);
            PanelInventario.Controls.Add(pictureBox2);
            PanelInventario.Controls.Add(pictureBox1);
            PanelInventario.Controls.Add(label3);
            PanelInventario.Controls.Add(label2);
            PanelInventario.Controls.Add(label1);
            PanelInventario.Location = new Point(12, 0);
            PanelInventario.Name = "PanelInventario";
            PanelInventario.Size = new Size(175, 684);
            PanelInventario.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 613);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Cerrar Sesion";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(60, 575);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 263);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 316);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Crear Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 205);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 109);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // PanelContenedor
            // 
            PanelContenedor.BorderStyle = BorderStyle.FixedSingle;
            PanelContenedor.Location = new Point(185, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1134, 684);
            PanelContenedor.TabIndex = 1;
            // 
            // PrincipalBodeguero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 749);
            Controls.Add(PanelContenedor);
            Controls.Add(PanelInventario);
            Name = "PrincipalBodeguero";
            Text = "Inventario";
            Load += PrincipalBodeguero_Load;
            PanelInventario.ResumeLayout(false);
            PanelInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelInventario;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel PanelContenedor;
        private PictureBox pictureBox4;
        private Label label4;
    }
}