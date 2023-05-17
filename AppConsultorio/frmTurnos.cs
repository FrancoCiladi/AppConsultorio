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

            this.pnlTurnoNuevo.Visible = false;
            this.pnlPacienteNuevo.Visible = false;
            CargarGridViewTurnos();
            this.dtpFecha.MinDate = DateTime.Today;

            if (Usuarios.AccesoLog > 20)
            {
                mnuTurnos.Items[2].Visible = false;
            }
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


        private void btnTurnoNuevo_Click(object sender, EventArgs e)
        {
            this.pnlTurnoNuevo.Visible = true;
            this.pnlPacienteNuevo.Visible = true;
            CargarGridViewPacientes();
            CargarObrasSociales();
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
                this.dgvPacientes.Columns["Descripcion"].HeaderText = "Obra Social";
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

        private void CargarObrasSociales()
        {
            DataTable tabla = new DataTable();
            Pacientes.RecuperarObrasSociales(ref tabla);
            cbxObrasSociales.DataSource = tabla;
            cbxObrasSociales.DisplayMember = "descripcion";
            cbxObrasSociales.ValueMember = "idObraSocial";
            cbxObrasSociales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxObrasSociales.SelectedIndex = 0;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
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

        private void cbxTurnosCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarGridViewTurnos();
        }
        private bool Verificar()
        {
            DataTable tabla = new DataTable();
            bool ok = false;
            int nrodoc;

            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    if ((!string.IsNullOrEmpty(txtNroDoc.Text)) && (int.TryParse(txtNroDoc.Text, out nrodoc)))
                    {
                        if (!string.IsNullOrEmpty(txtTelefono.Text))
                        {
                            if (VerificarTelefono(txtTelefono.Text))
                            {
                                    Pacientes.VerificarInsertPaciente(txtNroDoc.Text, ref tabla); 
                                if (tabla.Rows.Count == 0)
                                {
                                    ok = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ya se encuentra un paciente con el mismo DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtNroDoc.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar un nro. de telefono valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTelefono.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un nro. de telefono.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTelefono.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar el nro. de documento del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNroDoc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar el apellido del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            return ok;
        }
        private bool VerificarTelefono(string telefono)
        {
            bool ok = false;

            if (telefono.All(char.IsDigit))
            {
                ok = true;
            }
            return ok;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                string estado = "ACT";
                Pacientes.InsertarPaciente(txtNroDoc.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text, estado, cbxObrasSociales.SelectedValue.ToString());
                LimpiarControles();
                CargarGridViewPacientes();
            }
        }
        private void LimpiarControles()
        {
            this.txtApellido.Text = null;
            this.txtCorreo.Text = null;
            this.txtNombre.Text = null;
            this.txtNroDoc.Text = null;
            this.txtTelefono.Text = null;
            cbxObrasSociales.SelectedIndex = 0;
        }

        private void btnAsignarTurno_Click(object sender, EventArgs e)
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

        private void dgvPacientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
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
    }
    
}
