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
    public partial class frmReportePacientes : Form
    {
        public frmReportePacientes()
        {
            InitializeComponent();
        }

        private void frmReportePacientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Pacientes.RecuperarPacientesListado(Pacientes.opcionFiltrado, Pacientes.seleccion_OS, Pacientes.textoFiltrar, ref tabla);

            rpvPacientes.LocalReport.ReportPath = Application.StartupPath + "\\ReportePacientes.rdlc";
            rpvPacientes.LocalReport.DataSources.Clear();
            rpvPacientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetPacientes", tabla));

            this.rpvPacientes.RefreshReport();
        }
    }
}
