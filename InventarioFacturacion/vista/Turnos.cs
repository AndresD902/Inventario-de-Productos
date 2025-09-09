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
    public partial class Turnos : Form
    {
        public Turnos()
        {
            InitializeComponent();
            // Configuración del DateTimePicker de inicio
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd MMM yyyy hh:mm tt";
            dtpInicio.ShowUpDown = true;

            // Configuración del DateTimePicker de fin
            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.CustomFormat = "dd MMM yyyy hh:mm tt";
            dtpFinal.ShowUpDown = true;
        }

        private void Turnos_Load(object sender, EventArgs e)
        {

        }

        private void BotonAbrirTurno_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraInicio = dtpInicio.Value;
            DateTime fechaHoraFin = dtpFinal.Value;

            if (fechaHoraInicio >= fechaHoraFin)
            {
                MessageBox.Show("La fecha/hora de inicio debe ser menor que la de fin.");
            }
            else
            {
                MessageBox.Show("Inicio: " + fechaHoraInicio.ToString() +
                                "\nFin: " + fechaHoraFin.ToString());
            }
        }

        private void BotonCerrarTurno_Click(object sender, EventArgs e)
        {
            PanelCerrarTurno.Visible = true; // Mostrar el panel
            PanelCerrarTurno.BringToFront(); // Traerlo al frente del formulario
        }
    }
}
