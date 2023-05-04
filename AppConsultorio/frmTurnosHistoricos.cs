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
            rbRealizados.Checked = true;

            CargarGridView();
        }
        private void CargarGridView()
        {
            DataTable tabla = new DataTable();
            if (rbRealizados.Checked == true)
            {
                Turnos.RecuperarTurnosRealizadosAño(ref tabla);
                this.dgvTurnosHistoricos.DataSource = tabla;
                this.dgvTurnosHistoricos.Columns["fecha_cancelacion"].Visible = false;
                this.dgvTurnosHistoricos.Columns["importe"].Visible = true;
            }
            else
            {
                if (rbCancelados.Checked == true)
                {
                    Turnos.RecuperarTurnosCanceladosAño(ref tabla);
                    this.dgvTurnosHistoricos.DataSource = tabla;
                    this.dgvTurnosHistoricos.Columns["importe"].Visible = false;
                    this.dgvTurnosHistoricos.Columns["Fecha Cancelacion"].Visible = true;

                }
            }
            
            this.dgvTurnosHistoricos.AllowUserToAddRows = false;
            this.dgvTurnosHistoricos.AllowUserToDeleteRows = false;

            this.dgvTurnosHistoricos.Columns["idTurno"].Visible = false;
            this.dgvTurnosHistoricos.Columns["estado"].Visible = false;
            this.dgvTurnosHistoricos.Columns["fecha_creacion"].Visible = false;
            this.dgvTurnosHistoricos.Columns["idPaciente"].Visible = false;
            this.dgvTurnosHistoricos.Columns["observaciones"].Visible = false;


        }

        private void rbRealizados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRealizados.Checked == true)
            {
                rbCancelados.Checked = false;
            }
            else
            {
                rbCancelados.Checked = true;
            }
            CargarGridView();
        }

        private void rbCancelados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCancelados.Checked == true)
            {
                rbRealizados.Checked = false;
            }
            else
            {
                rbRealizados.Checked = true;
            }
            CargarGridView();
        }
    }
}
