using AppConsultorio.ConsultorioDataSetTableAdapters;
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
    public partial class frmReporteTurnos : Form
    {
        public frmReporteTurnos()
        {
            InitializeComponent();
        }

        private void frmReporteTurnos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //RECUPERO INFORMACION DE TURNOS
            DataTable tabla = new DataTable();
            Turnos.RecuperarInfoTurnos(Turnos.Seleccion,ref tabla);

            rpvTurnos.LocalReport.ReportPath = "C:\\Users\\franc\\OneDrive\\Documentos\\GitHub Repositorios\\AppConsultorio\\AppConsultorio\\ReporteTurnos.rdlc";
            rpvTurnos.LocalReport.DataSources.Clear();
            rpvTurnos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetInfoTurnos2", tabla));
            this.rpvTurnos.RefreshReport();
        }
    }
}
