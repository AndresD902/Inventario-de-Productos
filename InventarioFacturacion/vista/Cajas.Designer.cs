namespace InventarioFacturacion.vista
{
    partial class Cajas
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
            EMPRESA = new ComboBox();
            comboBox3 = new ComboBox();
            TEXTO = new Label();
            TEXTO2 = new Label();
            CajasVista = new Panel();
            Bienvenido = new Label();
            button1 = new Button();
            Botoningresar = new Button();
            CajasVista.SuspendLayout();
            SuspendLayout();
            // 
            // EMPRESA
            // 
            EMPRESA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMPRESA.FormattingEnabled = true;
            EMPRESA.Items.AddRange(new object[] { "La feria del juguete" });
            EMPRESA.Location = new Point(99, 194);
            EMPRESA.Name = "EMPRESA";
            EMPRESA.Size = new Size(381, 28);
            EMPRESA.TabIndex = 1;
            EMPRESA.Text = "Empresa *";
            EMPRESA.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "CAJA 1", "CAJA 2" });
            comboBox3.Location = new Point(99, 259);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(381, 28);
            comboBox3.TabIndex = 3;
            comboBox3.Text = "Cajas *";
            // 
            // TEXTO
            // 
            TEXTO.AutoSize = true;
            TEXTO.Font = new Font("Segoe UI", 13F);
            TEXTO.Location = new Point(48, 81);
            TEXTO.Name = "TEXTO";
            TEXTO.Size = new Size(504, 25);
            TEXTO.TabIndex = 4;
            TEXTO.Text = "Para comenzar a utilizar la aplicación, es necesario que elijas la ";
            // 
            // TEXTO2
            // 
            TEXTO2.AutoSize = true;
            TEXTO2.Font = new Font("Segoe UI", 13F);
            TEXTO2.Location = new Point(86, 116);
            TEXTO2.Name = "TEXTO2";
            TEXTO2.Size = new Size(394, 25);
            TEXTO2.TabIndex = 5;
            TEXTO2.Text = "empresa y la caja que utilizarás en esta maquina.";
            // 
            // CajasVista
            // 
            CajasVista.BorderStyle = BorderStyle.FixedSingle;
            CajasVista.Controls.Add(Bienvenido);
            CajasVista.Controls.Add(button1);
            CajasVista.Controls.Add(Botoningresar);
            CajasVista.Controls.Add(comboBox3);
            CajasVista.Controls.Add(TEXTO2);
            CajasVista.Controls.Add(EMPRESA);
            CajasVista.Controls.Add(TEXTO);
            CajasVista.Location = new Point(400, 151);
            CajasVista.Name = "CajasVista";
            CajasVista.Size = new Size(578, 443);
            CajasVista.TabIndex = 6;
            CajasVista.Paint += CajasVista_Paint;
            // 
            // Bienvenido
            // 
            Bienvenido.AutoSize = true;
            Bienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bienvenido.ForeColor = Color.DodgerBlue;
            Bienvenido.Location = new Point(224, 24);
            Bienvenido.Name = "Bienvenido";
            Bienvenido.Size = new Size(153, 32);
            Bienvenido.TabIndex = 8;
            Bienvenido.Text = "Bienvenidos";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(216, 373);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 7;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // Botoningresar
            // 
            Botoningresar.BackColor = Color.DodgerBlue;
            Botoningresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Botoningresar.ForeColor = SystemColors.ControlLightLight;
            Botoningresar.Location = new Point(216, 317);
            Botoningresar.Name = "Botoningresar";
            Botoningresar.Size = new Size(140, 40);
            Botoningresar.TabIndex = 6;
            Botoningresar.Text = "Ingresar";
            Botoningresar.UseVisualStyleBackColor = false;
            // 
            // Cajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 653);
            Controls.Add(CajasVista);
            Name = "Cajas";
            Text = "Cajas";
            Load += Cajas_Load;
            CajasVista.ResumeLayout(false);
            CajasVista.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox EMPRESA;
        private ComboBox comboBox3;
        private Label TEXTO;
        private Label TEXTO2;
        private Button button1;
        private Button Botoningresar;
        public Panel CajasVista;
        private Label Bienvenido;
    }
}