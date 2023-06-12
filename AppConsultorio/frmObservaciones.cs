using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsultorio
{
    public partial class frmObservaciones : Form
    {
        public frmObservaciones()
        {
            InitializeComponent();
        }

        private void frmDetalleTurno_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //RECUPERO LAS OBSERVACIONES DEL TURNO SELECCIONADO Y LLENO EL RICHTEXTBOX 
            DataTable tabla = new DataTable();
            Turnos.RecuperarObservacion(Turnos.idTurnoSelec, ref tabla);
            rchObervaciones.Text = tabla.Rows[0]["observaciones"].ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rchObervaciones.Text)) 
            {
                //GUARDO LAS OBSERVACIONES LLAMANDO AL PROCEDURE CORRESPONDIENTE
                Turnos.GuardarObservaciones(rchObervaciones.Text, Turnos.idTurnoSelec);
            }
            else
            {
                MessageBox.Show("Observacion sin texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rchObervaciones.Focus();
            }
        }
    }
}
