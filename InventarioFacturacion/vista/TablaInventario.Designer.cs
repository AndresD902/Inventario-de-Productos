namespace InventarioFacturacion.vista
{
    partial class TablaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaInventario));
            textBox1 = new TextBox();
            BtnEditar = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            EMPRESA = new ComboBox();
            btnBuscar = new Button();
            TbInventario = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            UnidadMedida = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewTextBoxColumn();
            BtnEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TbInventario).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(36, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 33);
            textBox1.TabIndex = 7;
            // 
            // BtnEditar
            // 
            BtnEditar.BorderStyle = BorderStyle.FixedSingle;
            BtnEditar.Controls.Add(button1);
            BtnEditar.Controls.Add(pictureBox3);
            BtnEditar.Controls.Add(EMPRESA);
            BtnEditar.Controls.Add(btnBuscar);
            BtnEditar.Controls.Add(TbInventario);
            BtnEditar.Controls.Add(textBox1);
            BtnEditar.Location = new Point(0, 0);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(1169, 689);
            BtnEditar.TabIndex = 8;
            BtnEditar.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(947, 198);
            button1.Name = "button1";
            button1.Size = new Size(150, 25);
            button1.TabIndex = 21;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-10, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // EMPRESA
            // 
            EMPRESA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EMPRESA.FormattingEnabled = true;
            EMPRESA.Items.AddRange(new object[] { "Categoria", "Unidad de Medida" });
            EMPRESA.Location = new Point(856, 118);
            EMPRESA.Name = "EMPRESA";
            EMPRESA.Size = new Size(169, 28);
            EMPRESA.Sorted = true;
            EMPRESA.TabIndex = 19;
            EMPRESA.Text = "Filtrar";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(691, 115);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 33);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // TbInventario
            // 
            TbInventario.BackgroundColor = Color.White;
            TbInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            TbInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TbInventario.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, NombreProducto, UnidadMedida, Precio, Acciones });
            TbInventario.Location = new Point(36, 174);
            TbInventario.Name = "TbInventario";
            TbInventario.Size = new Size(1083, 81);
            TbInventario.TabIndex = 8;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 140;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 8;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 170;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 8;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 250;
            // 
            // UnidadMedida
            // 
            UnidadMedida.HeaderText = "Unidad de Medida";
            UnidadMedida.MinimumWidth = 8;
            UnidadMedida.Name = "UnidadMedida";
            UnidadMedida.ReadOnly = true;
            UnidadMedida.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 160;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.Width = 150;
            // 
            // TablaInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 719);
            Controls.Add(BtnEditar);
            Name = "TablaInventario";
            Text = "TablaInventario";
            Load += TablaInventario_Load;
            BtnEditar.ResumeLayout(false);
            BtnEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)TbInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Panel BtnEditar;
        private DataGridView TbInventario;
        private Button btnBuscar;
        private ComboBox EMPRESA;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn UnidadMedida;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Acciones;
        private PictureBox pictureBox3;
        private Button button1;
    }
}