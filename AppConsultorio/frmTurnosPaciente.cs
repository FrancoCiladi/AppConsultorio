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
            if (dgvTurnosPaciente.CurrentRow != null)
            {
                //CARGO FORMS DE OBSERVACIONES PARA EL TURNO SELECCIONADO DEL PACIENTE
                Turnos.idTurnoSelec = this.dgvTurnosPaciente.CurrentRow.Cells["idTurno"].Value.ToString();
                frmObservaciones frmObservaciones = new frmObservaciones();
                frmObservaciones.ShowDialog();
            }
        }

        private void frmTurnosPaciente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //RECUPERO TODOS LOS TURNOS DEL PACIENTE SELECCIONADA
            DataTable Tabla = new DataTable();
            Pacientes.RecuperarTurnosPaciente(Pacientes.idPacienteSelec.ToString(), ref Tabla);
            dgvTurnosPaciente.DataSource = Tabla;
            if(Tabla.Rows.Count == 0)
            {
                MessageBox.Show("El paciente seleccionado no tiene turnos asignados.", "",MessageBoxButtons.OK);
                this.Close();
            }
            this.dgvTurnosPaciente.Columns["idTurno"].Visible = false;
            this.dgvTurnosPaciente.Columns["fecha"].HeaderText = "Fecha";
            this.dgvTurnosPaciente.Columns["estado"].HeaderText = "Estado";
        }
    }
}
