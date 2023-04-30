using AppConsultorio.ConsultorioDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConsultorio
{
    public partial class frmPacientes : Form 
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void editarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null){
                Modulo.Operacion = "MODIFICAR";
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                frmAgregarPacientes frmCargaPacientes = new frmAgregarPacientes();
                frmCargaPacientes.ShowDialog();
            }
            
        }

        private void cargarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo.Operacion = "ALTA";
            frmAgregarPacientes frmCargaPacientes = new frmAgregarPacientes();
            frmCargaPacientes.ShowDialog();
        }

        private void verTurnosPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                frmTurnosPaciente frmTurnosPaciente = new frmTurnosPaciente();
                frmTurnosPaciente.ShowDialog();
            }
            
        }


        private void CargarGridView()
        {
            if (string.IsNullOrEmpty(txtFiltroApellido.Text) == false && txtFiltroApellido.Text.Trim().Length >=3)
            {
                if(chkPacientesDeshabilitados.Checked == false)
                {
                    DataTable Tabla = new DataTable();
                    DataGridViewLinkColumn col;
                    col = new DataGridViewLinkColumn();

                    Pacientes.RecuperarPacientesActivos(txtFiltroApellido.Text, ref Tabla);
                    this.dgvPacientes.DataSource = Tabla;
                    this.dgvPacientes.Columns["idPaciente"].Visible = false;
                    this.dgvPacientes.Columns["estado"].Visible = false;
                    this.dgvPacientes.Columns["fecha_registro"].Visible = false;
                    this.dgvPacientes.Columns["idObra_Social"].Visible = false;
                    this.dgvPacientes.Columns["Telefono"].Visible = false;

                    col.DataPropertyName = "Telefono";
                    col.Name = "Telefono";
                    col.DisplayIndex = 3;
                    this.dgvPacientes.Columns.Add(col);
                }
                else
                {
                    DataTable Tabla = new DataTable();
                    DataGridViewLinkColumn col;
                    col = new DataGridViewLinkColumn();

                    Pacientes.RecuperarPacientesDeshabilitados(txtFiltroApellido.Text, ref Tabla);
                    this.dgvPacientes.DataSource = Tabla;
                    this.dgvPacientes.Columns["idPaciente"].Visible = false;
                    this.dgvPacientes.Columns["estado"].Visible = false;
                    this.dgvPacientes.Columns["fecha_registro"].Visible = false;
                    this.dgvPacientes.Columns["idObra_Social"].Visible = false;
                    this.dgvPacientes.Columns["Telefono"].Visible = false;

                    col.DataPropertyName = "Telefono";
                    col.Name = "Telefono";
                    col.DisplayIndex = 3;
                    this.dgvPacientes.Columns.Add(col);
                }
            }
            else
            {
                dgvPacientes.DataSource = null;
            }
        }
        private void txtFiltroApellido_TextChanged(object sender, EventArgs e)
        {
            if (Modulo.ValidarFiltro(txtFiltroApellido.Text.ToString()) == true)
            {
                CargarGridView();
            }
            else
            {
                MessageBox.Show("Ingreso caracter no permitido.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFiltroApellido.Focus();
            }
            
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPacientes.Columns[this.dgvPacientes.CurrentCell.ColumnIndex].HeaderText == "Telefono")
            {
                Process.Start("https://wa.me/+54" + this.dgvPacientes.CurrentCell.EditedFormattedValue);
            }
        }

        private void frmPacientes_Activated(object sender, EventArgs e)
        {
            CargarGridView();
        }



        private void darDeBajaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea dar de baja al paciente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                    Pacientes.BajaPaciente(Pacientes.idPacienteSelec.ToString());
                }
            }
        }

        private void habilitarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                Pacientes.ActivarPaciente(Pacientes.idPacienteSelec.ToString());
            }
        }
    }
}
