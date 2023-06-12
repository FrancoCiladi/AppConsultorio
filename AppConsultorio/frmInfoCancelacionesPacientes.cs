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
    public partial class frmInfoCancelacionesPacientes : Form
    {
        public frmInfoCancelacionesPacientes()
        {
            InitializeComponent();
        }

        private void frmCancelacionesPacientes_Load(object sender, EventArgs e)
        {
            //RECUPERO CANCELACIONES POR PACIENTES Y CARGO EL GRIDVIEW
            this.CenterToScreen();
            DataTable tabla = new DataTable();
            Reportes.RecuperarPacientesCancelaciones(ref tabla);
            dgvCancelacionesPacientes.DataSource = tabla;
            dgvCancelacionesPacientes.AllowUserToAddRows = false;
            dgvCancelacionesPacientes.AllowUserToDeleteRows = false;
            dgvCancelacionesPacientes.Columns["CantCancelaciones"].HeaderText = "Cant Cancelaciones";
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCancelaciones frmReporteCancelaciones = new frmReporteCancelaciones();
            frmReporteCancelaciones.ShowDialog();
        }
    }
}
