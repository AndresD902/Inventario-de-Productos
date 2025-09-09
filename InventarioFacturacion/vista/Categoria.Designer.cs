namespace InventarioFacturacion.vista
{
    partial class Categoria
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
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            Agregar = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 0;
            label1.Text = "Creacion De Categorias";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Agregar);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DodgerBlue;
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 612);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(781, 159);
            button1.Name = "button1";
            button1.Size = new Size(118, 35);
            button1.TabIndex = 8;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(45, 82);
            label4.Name = "label4";
            label4.Size = new Size(790, 21);
            label4.TabIndex = 7;
            label4.Text = "Recuerda que si ya tiene Productos la categoria, no los puedes eliminar a menos que lo autorice el Administrador";
            // 
            // Agregar
            // 
            Agregar.AccessibleRole = AccessibleRole.Clock;
            Agregar.BackColor = Color.DodgerBlue;
            Agregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agregar.ForeColor = Color.White;
            Agregar.Location = new Point(635, 159);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(118, 35);
            Agregar.TabIndex = 6;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(274, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(45, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 29);
            textBox1.TabIndex = 3;
            textBox1.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(274, 125);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(45, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 668);
            Controls.Add(panel1);
            Name = "Categoria";
            Text = "Categoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button Agregar;
        private Label label4;
        private Button button1;
    }
}