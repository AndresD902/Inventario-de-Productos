using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFacturacion.vista
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            string[] categorias = { "Favoritos", "Productos", "Escolar", "Navidad", "Belleza","Accesorios",
                "Tecnología" };
            foreach (string cat in categorias)
            {
                Button btn = new Button();
                btn.Text = cat;
                btn.AutoSize = true;
                btn.Height = 35;
                btn.Width = 120;
                btn.Click += (s, ev) => FiltrarCategoria(cat);

                flyCategorias.Controls.Add(btn);
            }

        }
        private void FiltrarCategoria(string categoria)
        {
            MessageBox.Show("Filtrando por: " + categoria);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flyCategorias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as Principal;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new Cobrar());
                // No necesitas this.Close(); el Principal cierra el activo por ti
            }


        }

        private void agregar_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as Principal;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new RegistrarCliente());
                // No necesitas this.Close(); el Principal cierra el activo por ti
            }
        }
    }
}
