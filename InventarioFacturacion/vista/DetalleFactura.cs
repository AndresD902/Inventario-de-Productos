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
    public partial class DetalleFactura : Form
    {
        public DetalleFactura()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void codigoProducto_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as Principal;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new Ventas());
                // No necesitas this.Close(); el Principal cierra el activo por ti
            }
        }
    }
}
