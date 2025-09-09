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
    public partial class Cobrar : Form
    {
        public Cobrar()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as Principal;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new Ventas());
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as Principal;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new DetalleFactura());
                this.Close(); // cierra el form Ventas que estaba abierto en el panel
            }
        }
    }
}
