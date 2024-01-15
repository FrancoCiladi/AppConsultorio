using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace AppConsultorio
{
    public partial class frmInfoTurno : Form
    {
        public frmInfoTurno(string paciente, string telefono, string obraSocial, string idTurno, string idPaciente)
        {
            InitializeComponent();
            lblObraSocialComp.Text = obraSocial;
            lblPacienteComp.Text = paciente;
            lblTelefonoCompleto.Text = telefono;
        }

        private void frmInfoTurno_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("¿Desea cancelar el turno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                dialogresult = MessageBox.Show("¿Desea notificar al paciente?", "", MessageBoxButtons.YesNo);
                //PREGUNTO SI DESEA NOTIFICAR AL PACIENTE DE LA CANCELACION
                if (dialogresult == DialogResult.Yes)
                {
                    //EN CASO AFIRMATIVO LA CANCELACION PROVIENE DEL MEDICO/A Y SE RECUPERARA EL NUMERO DEL PACIENTE Y ABRIRA UNA INSTANCIA DE WHATSAPP WEB
                    DataTable tabla = new DataTable();
                    Pacientes.RecuperarTelefonoPaciente(Pacientes.idPacienteSelec, ref tabla);
                    Process.Start("https://wa.me/+54" + tabla.Rows[0]["telefono"].ToString().Trim());
                    //AL HABERLO CANCELADO EL MEDICO AL TURNO ES IRRELEVANTE LA INFORMACION DEL MISMO POR LO TANTO SE PROCEDE A ELIMINARLO DE LA BD
                    Turnos.EliminarTurno(Turnos.idTurnoSelec);
                }
                else
                {
                    //EN CASO DE NO HABER NOTIFICADO AL PACIENTE SIGNIFICA QUE ESTE LO CANCELO Y SE CAMBIA UNICAMENTE EL ESTADO DEL TURNO A CANCELADO
                    Turnos.CancelarTurno(Turnos.idTurnoSelec);
                }
            }
            this.Close();
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            frmObservaciones frmObservaciones = new frmObservaciones();
            frmObservaciones.ShowDialog();
        }

        private void btnImporte_Click(object sender, EventArgs e)
        {
            frmImporte frmImporte = new frmImporte();
            frmImporte.ShowDialog();
        }
    }
}
