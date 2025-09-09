namespace InventarioFacturacion.vista
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btncobrar = new Button();
            textBox2 = new TextBox();
            agregar = new Button();
            EMPRESA = new ComboBox();
            label = new Label();
            btnBuscar = new Button();
            pictureBox2 = new PictureBox();
            flyCategorias = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(90, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btncobrar);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(agregar);
            panel1.Controls.Add(EMPRESA);
            panel1.Controls.Add(label);
            panel1.Location = new Point(843, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 663);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 380);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 420);
            label2.Name = "label2";
            label2.Size = new Size(237, 17);
            label2.TabIndex = 7;
            label2.Text = "Aun no tienes Productos En El Carrito";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 195);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // btncobrar
            // 
            btncobrar.BackColor = Color.DodgerBlue;
            btncobrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncobrar.ForeColor = Color.White;
            btncobrar.Location = new Point(44, 602);
            btncobrar.Name = "btncobrar";
            btncobrar.Size = new Size(243, 39);
            btncobrar.TabIndex = 5;
            btncobrar.Text = "Cobrar";
            btncobrar.UseVisualStyleBackColor = false;
            btncobrar.Click += btncobrar_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(22, 123);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 36);
            textBox2.TabIndex = 4;
            textBox2.Text = "Consumidor Final";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // agregar
            // 
            agregar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            agregar.ForeColor = Color.DodgerBlue;
            agregar.Location = new Point(277, 123);
            agregar.Name = "agregar";
            agregar.Size = new Size(32, 38);
            agregar.TabIndex = 3;
            agregar.Text = "+";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // EMPRESA
            // 
            EMPRESA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMPRESA.FormattingEnabled = true;
            EMPRESA.Location = new Point(22, 77);
            EMPRESA.Name = "EMPRESA";
            EMPRESA.Size = new Size(287, 28);
            EMPRESA.Sorted = true;
            EMPRESA.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(22, 39);
            label.Name = "label";
            label.Size = new Size(77, 21);
            label.TabIndex = 0;
            label.Text = "Vendedor";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(646, 90);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 38);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // flyCategorias
            // 
            flyCategorias.Location = new Point(22, 156);
            flyCategorias.Name = "flyCategorias";
            flyCategorias.Size = new Size(777, 152);
            flyCategorias.TabIndex = 4;
            flyCategorias.Paint += flyCategorias_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(22, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 303);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(22, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 100);
            panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-3, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(191, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 705);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(flyCategorias);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Button btnBuscar;
        private Label label;
        private Button agregar;
        private ComboBox EMPRESA;
        private Button btncobrar;
        private Label label1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flyCategorias;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
    }
}