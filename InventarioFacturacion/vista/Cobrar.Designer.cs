namespace InventarioFacturacion.vista
{
    partial class Cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobrar));
            panel1 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            EMPRESA = new ComboBox();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            panel7 = new Panel();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            btncobrar = new Button();
            panel8 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            CantProductos = new Label();
            NombreCliente = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 650);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(33, 537);
            panel5.Name = "panel5";
            panel5.Size = new Size(727, 42);
            panel5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(410, 9);
            label5.Name = "label5";
            label5.Size = new Size(151, 21);
            label5.TabIndex = 5;
            label5.Text = "Valor Pago En Linea";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(561, 9);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 6;
            label6.Text = "$8000";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(EMPRESA);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(34, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 189);
            panel3.TabIndex = 3;
            // 
            // EMPRESA
            // 
            EMPRESA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMPRESA.FormattingEnabled = true;
            EMPRESA.Items.AddRange(new object[] { "Tarjeta", "Transferencia" });
            EMPRESA.Location = new Point(43, 76);
            EMPRESA.Name = "EMPRESA";
            EMPRESA.Size = new Size(287, 28);
            EMPRESA.Sorted = true;
            EMPRESA.TabIndex = 10;
            EMPRESA.Text = "Tipo*";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(653, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(369, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 33);
            textBox2.TabIndex = 8;
            textBox2.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 23);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 7;
            label4.Text = "Pagos En Linea";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(33, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 283);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(45, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(635, 33);
            textBox1.TabIndex = 3;
            textBox1.Text = "$";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DodgerBlue;
            button4.Location = new Point(401, 119);
            button4.Name = "button4";
            button4.Size = new Size(279, 46);
            button4.TabIndex = 4;
            button4.Text = "$1000";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(45, 117);
            button3.Name = "button3";
            button3.Size = new Size(279, 46);
            button3.TabIndex = 3;
            button3.Text = "$1000";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(401, 47);
            button2.Name = "button2";
            button2.Size = new Size(279, 46);
            button2.TabIndex = 2;
            button2.Text = "$1000";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(45, 47);
            button1.Name = "button1";
            button1.Size = new Size(279, 46);
            button1.TabIndex = 1;
            button1.Text = "$1000";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Pagos En Efectivo";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(726, 42);
            panel4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 5;
            label2.Text = "Valor En Efectivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(561, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 6;
            label3.Text = "$8000";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(CantProductos);
            panel6.Controls.Add(NombreCliente);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(845, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(347, 650);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label21);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(label18);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(btncobrar);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label10);
            panel7.Location = new Point(-1, 163);
            panel7.Name = "panel7";
            panel7.Size = new Size(347, 486);
            panel7.TabIndex = 13;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(247, 382);
            label21.Name = "label21";
            label21.Size = new Size(49, 20);
            label21.TabIndex = 24;
            label21.Text = "$0000";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(247, 346);
            label20.Name = "label20";
            label20.Size = new Size(49, 20);
            label20.TabIndex = 23;
            label20.Text = "$0000";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(247, 118);
            label19.Name = "label19";
            label19.Size = new Size(49, 20);
            label19.TabIndex = 22;
            label19.Text = "$0000";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(29, 118);
            label18.Name = "label18";
            label18.Size = new Size(70, 20);
            label18.TabIndex = 21;
            label18.Text = "Subtotal:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(247, 72);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 20;
            label17.Text = "$0000";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(247, 27);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 14;
            label16.Text = "$0000";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(29, 346);
            label15.Name = "label15";
            label15.Size = new Size(71, 20);
            label15.TabIndex = 19;
            label15.Text = "Restante:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(29, 383);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 18;
            label14.Text = "Cambio:";
            // 
            // btncobrar
            // 
            btncobrar.BackColor = Color.DodgerBlue;
            btncobrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncobrar.ForeColor = Color.White;
            btncobrar.Location = new Point(29, 424);
            btncobrar.Name = "btncobrar";
            btncobrar.Size = new Size(298, 39);
            btncobrar.TabIndex = 14;
            btncobrar.Text = "Guardar Y Cobrar";
            btncobrar.UseVisualStyleBackColor = false;
            btncobrar.Click += btncobrar_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.GradientActiveCaption;
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(-1, 229);
            panel8.Name = "panel8";
            panel8.Size = new Size(347, 100);
            panel8.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(156, 38);
            label13.Name = "label13";
            label13.Size = new Size(37, 30);
            label13.TabIndex = 17;
            label13.Text = "$0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(120, 14);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 16;
            label12.Text = "Total A Pagar";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 72);
            label11.Name = "label11";
            label11.Size = new Size(149, 20);
            label11.TabIndex = 15;
            label11.Text = "Descuento Aplicado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(29, 27);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 14;
            label10.Text = "Total Bruto:";
            // 
            // CantProductos
            // 
            CantProductos.AutoSize = true;
            CantProductos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CantProductos.Location = new Point(175, 66);
            CantProductos.Name = "CantProductos";
            CantProductos.Size = new Size(17, 20);
            CantProductos.TabIndex = 12;
            CantProductos.Text = "1";
            // 
            // NombreCliente
            // 
            NombreCliente.AutoSize = true;
            NombreCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreCliente.Location = new Point(101, 104);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(124, 20);
            NombreCliente.TabIndex = 11;
            NombreCliente.Text = "Consumidor Final";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 104);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 10;
            label9.Text = "Cliente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 66);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 9;
            label8.Text = "Nro. de Productos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 15);
            label7.Name = "label7";
            label7.Size = new Size(190, 25);
            label7.TabIndex = 8;
            label7.Text = "Informacion de Pago";
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 706);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "Cobrar";
            Text = "Cobrar";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private ComboBox EMPRESA;
        private Panel panel6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Panel panel7;
        private Label CantProductos;
        private Label NombreCliente;
        private Panel panel8;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button btncobrar;
    }
}