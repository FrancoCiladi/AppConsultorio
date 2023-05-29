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
    public partial class frmTurnosHistoricos : Form
    {
        public frmTurnosHistoricos()
        {
            InitializeComponent();
        }

        private void frmTurnosHistoricos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cbxMeses.Items.Add("Seleccione mes...");
            cbxMeses.Items.Add("Enero");
            cbxMeses.Items.Add("Febrero");
            cbxMeses.Items.Add("Marzo");
            cbxMeses.Items.Add("Abril");
            cbxMeses.Items.Add("Mayo");
            cbxMeses.Items.Add("Junio");
            cbxMeses.Items.Add("Julio");
            cbxMeses.Items.Add("Agosto");
            cbxMeses.Items.Add("Octubre");
            cbxMeses.Items.Add("Noviembre");
            cbxMeses.Items.Add("Diciembre");
            cbxMeses.SelectedIndex = 0;
            cbxMeses.DropDownStyle = ComboBoxStyle.DropDownList;

            if (Usuarios.AccesoLog > 20)
            {
                mnuTurnosHistoricos.Items[1].Visible = false;
            }
        }
        private void CargarGridView()
        {
            DataTable tabla = new DataTable();

            Turnos.RecuperarTurnosHistoricos(cbxMeses.SelectedIndex, ref tabla);
            this.dgvTurnosHistoricos.DataSource = tabla;
            this.dgvTurnosHistoricos.AllowUserToAddRows = false;
            this.dgvTurnosHistoricos.AllowUserToDeleteRows = false;
            this.dgvTurnosHistoricos.Columns["fecha_cancelacion"].Visible = false;
            this.dgvTurnosHistoricos.Columns["idTurno"].Visible = false;
            this.dgvTurnosHistoricos.Columns["estado"].Visible = false;
            this.dgvTurnosHistoricos.Columns["fecha_creacion"].Visible = false;
            this.dgvTurnosHistoricos.Columns["idPaciente"].Visible = false;
            this.dgvTurnosHistoricos.Columns["observaciones"].Visible = false;


        }

        private void ingresarImporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvTurnosHistoricos.CurrentRow != null)
            {
                Turnos.idTurnoSelec = this.dgvTurnosHistoricos.CurrentRow.Cells["idTurno"].Value.ToString();
                frmImporte frmImporte = new frmImporte();
                frmImporte.ShowDialog();
                CargarGridView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTurnosHistoricos.CurrentRow != null)
            {
                Turnos.idTurnoSelec = this.dgvTurnosHistoricos.CurrentRow.Cells["idTurno"].Value.ToString();
                frmObservaciones frmObservaciones = new frmObservaciones();
                frmObservaciones.ShowDialog();
            }
        }

        private void frmTurnosHistoricos_Activated(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void cbxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMeses.SelectedIndex != 0)
            {
                CargarGridView();
            }
            else
            {
                dgvTurnosHistoricos.DataSource = null;
            }
        }
    }
}
