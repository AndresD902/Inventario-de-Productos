namespace InventarioFacturacion.vista
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panelMenu = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Ventas = new PictureBox();
            PanelContenedor = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ventas).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(label4);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(Ventas);
            panelMenu.Location = new Point(3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(161, 688);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 446);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(42, 583);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 621);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Cerrar Sesion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 380);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Reportes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 266);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Turnos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar_9131224;
            pictureBox1.Location = new Point(28, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 140);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Ventas e Ingresos";
            // 
            // Ventas
            // 
            Ventas.Image = Properties.Resources._4467031__1_;
            Ventas.Location = new Point(34, 84);
            Ventas.Name = "Ventas";
            Ventas.Size = new Size(78, 53);
            Ventas.SizeMode = PictureBoxSizeMode.Zoom;
            Ventas.TabIndex = 0;
            Ventas.TabStop = false;
            Ventas.Click += Ventas_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BorderStyle = BorderStyle.FixedSingle;
            PanelContenedor.Location = new Point(164, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1187, 688);
            PanelContenedor.TabIndex = 1;
            PanelContenedor.Paint += PanelContenedor_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 749);
            Controls.Add(PanelContenedor);
            Controls.Add(panelMenu);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ventas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Ventas;
        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Panel PanelContenedor;
    }
}