using AppConsultorio.DataSetCancelacionesPacientesTableAdapters;
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
    public partial class frmReporteCancelaciones : Form
    {
        public frmReporteCancelaciones()
        {
            InitializeComponent();
        }

        private void frmReporteCancelaciones_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //RECUPERO LAS CANCELACIONES POR PACIENTE
            DataTable tabla = new DataTable();
            Reportes.RecuperarPacientesCancelaciones(ref tabla);

            rpvCancelaciones.LocalReport.ReportPath = Application.StartupPath + "\\ReporteCancelacionesPacientes.rdlc";
            rpvCancelaciones.LocalReport.DataSources.Clear();
            rpvCancelaciones.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetCancelacionesPacientes", tabla));

            this.rpvCancelaciones.RefreshReport();
        }
    }
}
