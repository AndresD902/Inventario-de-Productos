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
    public partial class PrincipalBodeguero : Form
    {

        private Form formularioActivo = null;
        public PrincipalBodeguero()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new TablaInventario());
        }


        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Cierra el formulario anterior si existe
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Clear(); // Limpiar antes de agregar uno nuevo
            PanelContenedor.Controls.Add(formHijo);
            PanelContenedor.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Categoria());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Producto());
        }

        private void PrincipalBodeguero_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new TablaInventario());
        }
    }
}
