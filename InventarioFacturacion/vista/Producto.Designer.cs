namespace InventarioFacturacion.vista
{
    partial class Producto
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox4 = new TextBox();
            label7 = new Label();
            Categoria = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = "Creación Del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 21);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 1;
            label2.Text = "Datos Generales";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Categoria);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(26, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 254);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(15, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 29);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(15, 167);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 10;
            label7.Text = "Unidad De Medida *";
            // 
            // Categoria
            // 
            Categoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categoria.FormattingEnabled = true;
            Categoria.Location = new Point(15, 102);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(283, 28);
            Categoria.Sorted = true;
            Categoria.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(699, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 29);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(349, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 29);
            textBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(699, 70);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre del producto *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(349, 70);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 3;
            label4.Text = "Codigo del producto *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(15, 70);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 2;
            label3.Text = "Categoria del producto *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(699, 80);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 5;
            label6.Text = "Cantidad en Stock *";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(699, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 29);
            textBox3.TabIndex = 8;
            textBox3.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 34);
            label8.Name = "label8";
            label8.Size = new Size(148, 25);
            label8.TabIndex = 12;
            label8.Text = "Datos Contables";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(15, 80);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 12;
            label9.Text = "Precio 1 *";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(15, 103);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(283, 29);
            textBox5.TabIndex = 13;
            textBox5.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(349, 80);
            label10.Name = "label10";
            label10.Size = new Size(114, 20);
            label10.TabIndex = 14;
            label10.Text = "Precio Opcional";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(349, 103);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(283, 29);
            textBox6.TabIndex = 15;
            textBox6.Text = "0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(26, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 170);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(9, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(1189, 697);
            panel3.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.AliceBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.DodgerBlue;
            btnCancelar.Location = new Point(661, 596);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 38);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(866, 596);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 38);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 718);
            Controls.Add(panel3);
            Name = "Producto";
            Text = "Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private ComboBox Categoria;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
        private Panel panel2;
        private Panel panel3;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}