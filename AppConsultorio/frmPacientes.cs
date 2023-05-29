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
            if (Usuarios.AccesoLog > 20)
            {
                mnuPacientes.Items[3].Visible = false;
            }
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

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                DataTable tabla = new DataTable();
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                Pacientes.RecuperarTurnosPaciente(Pacientes.idPacienteSelec, ref tabla);
                if (tabla.Rows.Count == 0)
                {
                    Pacientes.EliminarPaciente(Pacientes.idPacienteSelec);
                }
                else
                {
                    MessageBox.Show("No se pueden eliminar pacientes con turnos asignados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarGridView();
            }
        }
    }
}
