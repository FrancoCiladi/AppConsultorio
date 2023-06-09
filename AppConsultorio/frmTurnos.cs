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
            
            Turnos.CambiarEstadoTurno();

            cbxTurnosCategorias.Items.Add("Dia");
            cbxTurnosCategorias.Items.Add("Semana");
            cbxTurnosCategorias.Items.Add("Mes");
            cbxTurnosCategorias.SelectedIndex = 0;

            cbxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            
            CargarGridViewTurnos();
            CargarGridViewPacientes();

            this.dtpFecha.MinDate = DateTime.Today;

            if (Usuarios.AccesoLog > 20)
            {
                mnuTurnos.Items[2].Visible = false;
            }
        }
        private void CargarMeses()
        {
            int mes = DateTime.Now.Month;

            DataTable tabla = new DataTable();

            Turnos.RecuperarMeses(mes, ref tabla);

            cbxMeses.DataSource = tabla;
            cbxMeses.DisplayMember = "Descripcion";
            cbxMeses.ValueMember = "idMes";
            cbxMeses.SelectedIndex = 0;
        }
        private void CargarGridViewTurnos()
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
                    Turnos.RecuperarTurnosReservadosMes(DateTime.Now.Month, ref tabla);
                    break;
            }
            switch (cbxMeses.SelectedValue)
            {
                case 1: 
                    Turnos.RecuperarTurnosReservadosMes(1,ref tabla);
                    break;
                case 2:
                    Turnos.RecuperarTurnosReservadosMes(2, ref tabla);
                    break;
                case 3:
                    Turnos.RecuperarTurnosReservadosMes(3, ref tabla);
                    break;
                case 4:
                    Turnos.RecuperarTurnosReservadosMes(4, ref tabla);
                    break;
                case 5:
                    Turnos.RecuperarTurnosReservadosMes(5, ref tabla);
                    break;
                case 6:
                    Turnos.RecuperarTurnosReservadosMes(6, ref tabla);
                    break;
                case 7:
                    Turnos.RecuperarTurnosReservadosMes(7, ref tabla);
                    break;
                case 8:
                    Turnos.RecuperarTurnosReservadosMes(8, ref tabla);
                    break;
                case 9:
                    Turnos.RecuperarTurnosReservadosMes(9, ref tabla);
                    break;
                case 10:
                    Turnos.RecuperarTurnosReservadosMes(10, ref tabla);
                    break;
                case 11:
                    Turnos.RecuperarTurnosReservadosMes(11, ref tabla);
                    break;
                case 12:
                    Turnos.RecuperarTurnosReservadosMes(12, ref tabla);
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


        private void frmTurnos_Activated(object sender, EventArgs e)
        {
            CargarGridViewTurnos();
        }

        private void cancelarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvTurnos.CurrentRow != null)
            {
                Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                Pacientes.idPacienteSelec = this.dgvTurnos.CurrentRow.Cells["idPaciente"].Value.ToString();
                DialogResult dialogresult = MessageBox.Show("¿Desea cancelar el turno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    dialogresult = MessageBox.Show("¿Desea notificar al paciente?","",MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        DataTable tabla = new DataTable();
                        Pacientes.RecuperarTelefonoPaciente(Pacientes.idPacienteSelec, ref tabla);
                        Process.Start("https://wa.me/+54" + tabla.Rows[0]["telefono"].ToString().Trim());
                        Turnos.EliminarTurno(Turnos.idTurnoSelec);
                    }
                    else
                    {
                        Turnos.CancelarTurno(Turnos.idTurnoSelec);
                    }   
                }       
            }
        }

        private void CargarGridViewPacientes()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text) == false && txtFiltrar.Text.Trim().Length >= 3)
            {
                DataTable Tabla = new DataTable();
                DataGridViewLinkColumn col;
                col = new DataGridViewLinkColumn();

                Pacientes.RecuperarPacientesActivos(txtFiltrar.Text, ref Tabla);
                this.dgvPacientes.DataSource = Tabla;
                this.dgvPacientes.Columns["idPaciente"].Visible = false;
                this.dgvPacientes.Columns["estado"].Visible = false;
                this.dgvPacientes.Columns["fecha_registro"].Visible = false;
                this.dgvPacientes.Columns["idObra_Social"].Visible = false;
                this.dgvPacientes.Columns["Telefono"].Visible = false;
                this.dgvPacientes.AllowUserToAddRows = false;
                this.dgvPacientes.AllowUserToDeleteRows = false;

                col.DataPropertyName = "Telefono";
                col.Name = "Telefono";
                col.DisplayIndex = 3;
                this.dgvPacientes.Columns.Add(col);
            }
            else
                    {
                dgvPacientes.DataSource = null;
            }
        }

        private void txtFiltrar_TextChanged_1(object sender, EventArgs e)
        {
            if (Modulo.ValidarFiltro(txtFiltrar.Text.ToString()) == true)
            {
                CargarGridViewPacientes();
            }
            else
            {
                MessageBox.Show("Ingreso caracter no permitido.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFiltrar.Focus();
            }
        }



        private void btnAsignarTurno_Click_1(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                    if (VerificarTurno())
                    {
                        string fecha = dtpFecha.Value.ToShortDateString();
                        string hora = dtpHora.Value.ToShortTimeString();
                        Turnos.AgregarTurno(fecha, hora, Pacientes.idPacienteSelec);
                    }         
            }
            else
            {
                MessageBox.Show("Debe asignar el turno a un paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private bool VerificarTurno()
        {
            bool ok;
            ok = false;

            DataTable tabla = new DataTable();
            string fecha = dtpFecha.Value.ToShortDateString();
            string hora = dtpHora.Value.ToShortTimeString();
            Turnos.VerificarDisponibilidadTurno(fecha, hora, ref tabla);
            if (tabla.Rows.Count == 0)
            {
                ok = true;
            }
            else
            {
                MessageBox.Show("Turno no disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }



        private void ingresarImporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvTurnos.CurrentRow != null)
            {
                Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                frmImporte frmImporte = new frmImporte();
                frmImporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.CurrentRow != null)
            {
                Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                frmObservaciones frmObservaciones = new frmObservaciones();
                frmObservaciones.ShowDialog();
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.Rows.Count  > 0)
            {
                DataTable tabla = new DataTable();
                switch (cbxTurnosCategorias.SelectedIndex)
                {
                    case 0:
                        Turnos.Seleccion = 0;
                        break;
                    case 1:
                        Turnos.Seleccion = 1;
                        break;
                    case 2:
                        Turnos.Seleccion = 2;
                        break;
                }
                frmReporteTurnos frmReporteTurnos = new frmReporteTurnos();
                frmReporteTurnos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay nada para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmAgregarPacientes frmAgregarPacientes = new frmAgregarPacientes();
            frmAgregarPacientes.ShowDialog();
        }

        private void cbxTurnosCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarGridViewTurnos();
            if (cbxTurnosCategorias.SelectedIndex == 2)
            {
                cbxMeses.Enabled = true;
                CargarMeses();                
            }
            else
            {
                cbxMeses.Enabled = false;
            }
        }

        private void dgvPacientes_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
        }

        private void cbxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMeses.SelectedIndex > 0)
            {
                CargarGridViewTurnos();
            }
        }
    }
    
}
