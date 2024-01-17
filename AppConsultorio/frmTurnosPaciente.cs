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
    public partial class frmTurnosPaciente : Form
    {
        public frmTurnosPaciente()
        {
            InitializeComponent();
        }

        private void dgvTurnosPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurnosRealizados.CurrentRow != null)
            {
                //CARGO FORMS DE OBSERVACIONES PARA EL TURNO SELECCIONADO DEL PACIENTE
                Turnos.idTurnoSelec = this.dgvTurnosRealizados.CurrentRow.Cells["idTurno"].Value.ToString();
                frmObservaciones frmObservaciones = new frmObservaciones();
                frmObservaciones.ShowDialog();
            }
        }

        private void frmTurnosPaciente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //RECUPERO TODOS LOS TURNOS DEL PACIENTE SELECCIONADO
            DataTable Tabla = new DataTable();
            Pacientes.RecuperarTurnosPacienteRealizados(Pacientes.idPacienteSelec.ToString(), ref Tabla);
            dgvTurnosRealizados.DataSource = Tabla;
            this.dgvTurnosRealizados.Columns["idTurno"].Visible = false;
            this.dgvTurnosRealizados.Columns["estado"].Visible = false;
            this.dgvTurnosRealizados.Columns["fecha"].HeaderText = "Fecha";
        }

        private void tabTurnosPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabTurnosPaciente.SelectedIndex == 0)
            {
                DataTable Tabla = new DataTable();
                Pacientes.RecuperarTurnosPacienteRealizados(Pacientes.idPacienteSelec.ToString(), ref Tabla);
                dgvTurnosRealizados.DataSource = Tabla;
                if (Tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El paciente seleccionado no tiene turnos asignados.", "", MessageBoxButtons.OK);
                }
                this.dgvTurnosRealizados.Columns["idTurno"].Visible = false;
                this.dgvTurnosRealizados.Columns["estado"].Visible = false;
                this.dgvTurnosRealizados.Columns["fecha"].HeaderText = "Fecha";
            }
            else
            {
                DataTable Tabla = new DataTable();
                Pacientes.RecuperarTurnosPacienteReservados(Pacientes.idPacienteSelec.ToString(), ref Tabla);
                dgvTurnosPendientes.DataSource = Tabla;
                this.dgvTurnosPendientes.Columns["idTurno"].Visible = false;
                this.dgvTurnosPendientes.Columns["estado"].Visible = false;
                this.dgvTurnosPendientes.Columns["fecha"].HeaderText = "Fecha";
                if (Tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El paciente seleccionado no tiene turnos pendientes.", "", MessageBoxButtons.OK);
                    tabTurnosPaciente.SelectedIndex = 0;
                }
                
            }
        }
    }
}
