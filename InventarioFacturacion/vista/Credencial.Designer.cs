namespace InventarioFacturacion.vista
{
    partial class Credencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credencial));
            PanelPadre0 = new Panel();
            PanelHijo0 = new Panel();
            ImagenPrincipal = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Usuario = new TextBox();
            Contraseña = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            PanelHijo = new Panel();
            PanelPadre2 = new Panel();
            PanelPadre0.SuspendLayout();
            PanelHijo0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenPrincipal).BeginInit();
            PanelHijo.SuspendLayout();
            PanelPadre2.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPadre0
            // 
            PanelPadre0.BackColor = Color.DodgerBlue;
            PanelPadre0.Controls.Add(PanelHijo0);
            PanelPadre0.Dock = DockStyle.Left;
            PanelPadre0.Location = new Point(0, 0);
            PanelPadre0.Name = "PanelPadre0";
            PanelPadre0.Size = new Size(683, 645);
            PanelPadre0.TabIndex = 0;
            PanelPadre0.Paint += panel1_Paint;
            // 
            // PanelHijo0
            // 
            PanelHijo0.Controls.Add(ImagenPrincipal);
            PanelHijo0.Location = new Point(0, 92);
            PanelHijo0.Name = "PanelHijo0";
            PanelHijo0.Size = new Size(687, 478);
            PanelHijo0.TabIndex = 1;
            // 
            // ImagenPrincipal
            // 
            ImagenPrincipal.ErrorImage = (Image)resources.GetObject("ImagenPrincipal.ErrorImage");
            ImagenPrincipal.Image = Properties.Resources.la_fewria_del_juguete;
            ImagenPrincipal.Location = new Point(0, 11);
            ImagenPrincipal.Name = "ImagenPrincipal";
            ImagenPrincipal.Size = new Size(896, 896);
            ImagenPrincipal.SizeMode = PictureBoxSizeMode.AutoSize;
            ImagenPrincipal.TabIndex = 0;
            ImagenPrincipal.TabStop = false;
            ImagenPrincipal.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(44, 110);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(44, 213);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // Usuario
            // 
            Usuario.Font = new Font("Segoe UI", 12F);
            Usuario.Location = new Point(44, 152);
            Usuario.Multiline = true;
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(271, 35);
            Usuario.TabIndex = 3;
            // 
            // Contraseña
            // 
            Contraseña.Font = new Font("Segoe UI", 12F);
            Contraseña.Location = new Point(44, 253);
            Contraseña.Multiline = true;
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(271, 35);
            Contraseña.TabIndex = 4;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(119, 385);
            button1.Name = "button1";
            button1.Size = new Size(118, 43);
            button1.TabIndex = 5;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.Location = new Point(213, 63);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crear Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(44, 63);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 7;
            label3.Text = "¿Aún no tienes Cuenta?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.Location = new Point(44, 321);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(144, 19);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Recuperar Contraseña";
            // 
            // PanelHijo
            // 
            PanelHijo.BorderStyle = BorderStyle.FixedSingle;
            PanelHijo.Controls.Add(button1);
            PanelHijo.Controls.Add(linkLabel2);
            PanelHijo.Controls.Add(Usuario);
            PanelHijo.Controls.Add(linkLabel1);
            PanelHijo.Controls.Add(Contraseña);
            PanelHijo.Controls.Add(label3);
            PanelHijo.Controls.Add(label2);
            PanelHijo.Controls.Add(label1);
            PanelHijo.Location = new Point(47, 120);
            PanelHijo.Name = "PanelHijo";
            PanelHijo.Size = new Size(352, 465);
            PanelHijo.TabIndex = 9;
            // 
            // PanelPadre2
            // 
            PanelPadre2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelPadre2.BackColor = Color.White;
            PanelPadre2.Controls.Add(PanelHijo);
            PanelPadre2.Dock = DockStyle.Fill;
            PanelPadre2.Location = new Point(683, 0);
            PanelPadre2.Name = "PanelPadre2";
            PanelPadre2.Size = new Size(450, 645);
            PanelPadre2.TabIndex = 10;
            PanelPadre2.Paint += PanelPadre2_Paint;
            // 
            // Credencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 645);
            Controls.Add(PanelPadre2);
            Controls.Add(PanelPadre0);
            Name = "Credencial";
            Text = "Credencial";
            PanelPadre0.ResumeLayout(false);
            PanelHijo0.ResumeLayout(false);
            PanelHijo0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenPrincipal).EndInit();
            PanelHijo.ResumeLayout(false);
            PanelHijo.PerformLayout();
            PanelPadre2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPadre0;
        private Label label1;
        private Label label2;
        private TextBox Usuario;
        private TextBox Contraseña;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox ImagenPrincipal;
        private LinkLabel linkLabel2;
        private Panel PanelPadre2;
        private Panel PanelHijo0;
        internal Panel PanelHijo;
    }
}