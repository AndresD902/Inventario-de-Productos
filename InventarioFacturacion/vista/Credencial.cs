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
    public partial class Credencial : Form
    {
        public Credencial()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PanelHijo0.Left = (PanelPadre0.ClientSize.Width - PanelHijo0.Width) / 2;
            PanelHijo0.Top = (PanelPadre0.ClientSize.Height - PanelHijo0.Height) / 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void PanelPadre2_Paint(object sender, PaintEventArgs e)
        {
            PanelHijo.Left = (PanelPadre2.ClientSize.Width - PanelHijo.Width) / 2;
            PanelHijo.Top = (PanelPadre2.ClientSize.Height - PanelHijo.Height) / 2;
        }
    }
}
