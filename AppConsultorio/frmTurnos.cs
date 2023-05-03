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

namespace AppConsultorio
{
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cbxTurnosCategorias.Items.Add("Dia");
            cbxTurnosCategorias.Items.Add("Semana");
            cbxTurnosCategorias.Items.Add("Mes");
            cbxTurnosCategorias.SelectedIndex = 0;

            
            CargarGridView();
        }

        private void CargarGridView()
        {
            DataTable tabla = new DataTable();
            switch (cbxTurnosCategorias.SelectedIndex)
            {
                case 0:
                    Turnos.RecuperarTurnosReservadosDia(ref tabla);
                    break;
                case 1:
                    Turnos.RecuperarTurnosReservadosSemana(ref tabla);
                    break;
                case 2:
                    Turnos.RecuperarTurnosReservadosMes(ref tabla);
                    break;
            }
            this.dgvTurnos.DataSource = tabla;

            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;

            this.dgvTurnos.Columns["idTurno"].Visible = false;
            this.dgvTurnos.Columns["importe"].Visible = false;
            this.dgvTurnos.Columns["Estado"].Visible = false;
            this.dgvTurnos.Columns["fecha_creacion"].Visible = false;
            this.dgvTurnos.Columns["observaciones"].Visible = false;
            this.dgvTurnos.Columns["idPaciente"].Visible = false;
            this.dgvTurnos.Columns["fecha_cancelacion"].Visible = false;

        }

        private void cbxTurnosCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void frmTurnos_Activated(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void cancelarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvTurnos.CurrentRow != null)
            {
                DialogResult dialogresult = MessageBox.Show("¿Desea cancelar el turno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    dialogresult = MessageBox.Show("¿Desea notificar al paciente?","",MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        DataTable tabla = new DataTable();
                        Pacientes.idPacienteSelec = this.dgvTurnos.CurrentRow.Cells["idPaciente"].Value.ToString();
                        Pacientes.RecuperarTelefonoPaciente(Pacientes.idPacienteSelec, ref tabla);
                        Process.Start("https://wa.me/+54" + tabla.Rows[0]["telefono"].ToString().Trim());

                    }
                    Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                    Turnos.CancelarTurno(Turnos.idTurnoSelec);
                }       
            }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            frmNuevoTurno frmNuevoTurno = new frmNuevoTurno();
            frmNuevoTurno.ShowDialog();
        }
    }
    
}
