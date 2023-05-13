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
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }
        private void fillChart()
        {
            int TotalTurnosRealizados, TotalTurnosCancelados, TotalRecaudado;
            TotalRecaudado = 0;
            TotalTurnosCancelados = 0;
            TotalTurnosRealizados = 0;
            int aux = 0;
            //Necesario para que no oculte meses en el chart
            chartTurnosRealizados.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chartTurnosCancelados.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chartRecaudado.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            //Mostrar valor exacto de cada barra
            chartTurnosRealizados.Series["Turnos Realizados"].IsValueShownAsLabel = true;
            chartTurnosCancelados.Series["Turnos Cancelados"].IsValueShownAsLabel = true;
            chartRecaudado.Series["Total Recaudado"].IsValueShownAsLabel = true;    
            //Eliminar gridlines
            chartTurnosRealizados.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTurnosRealizados.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartTurnosCancelados.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTurnosCancelados.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartRecaudado.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRecaudado.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            //Hacer que el valor de las labels de barras tengan mejor visibilidad
            chartTurnosRealizados.Series["Turnos Realizados"].Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
            chartTurnosCancelados.Series["Turnos Cancelados"].Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
            chartRecaudado.Series["Total Recaudado"].Font = new System.Drawing.Font("Microsoft Sans Serif",10f,FontStyle.Bold);

            for (int i = 1; i <= 12; i++)
            {
                string fecha;
                DataTable tabla = new DataTable();
                switch (i)
                {
                    case 1:
                        fecha = "01/01/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Enero", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Enero", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Enero", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(),out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 2:
                        fecha = "01/02/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Febrero", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Febrero", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Febrero", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 3:
                        fecha = "01/03/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Marzo", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Marzo", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Marzo", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 4:
                        fecha = "01/04/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Abril", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Abril", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Abril", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 5:
                        fecha = "01/05/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Mayo", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Mayo", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Mayo", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 6:
                        fecha = "01/06/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Junio", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Junio", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Junio", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 7:
                        fecha = "01/07/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Julio", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Julio", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Julio", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 8:
                        fecha = "01/08/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Agosto", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Agosto", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Agosto", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 9:
                        fecha = "01/09/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Septiembre", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Septiembre", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Septiembre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 10:
                        fecha = "01/10/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Octubre", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Octubre", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Octubre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 11:
                        fecha = "01/11/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Noviembre", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Noviembre", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Noviembre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 12:
                        fecha = "01/12/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartTurnosRealizados.Series["Turnos Realizados"].Points.AddXY("Diciembre", tabla.Rows[0]["Realizados"].ToString());
                        TotalTurnosRealizados = TotalTurnosRealizados + int.Parse(tabla.Rows[0]["Realizados"].ToString());
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Diciembre", tabla.Rows[0]["Cancelados"].ToString());
                        TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Diciembre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;        
                }
                              
            }
            lblTotalTurnosRealizados.Text = "Total Turnos Realizados: " + TotalTurnosRealizados.ToString();
            lblTotalTurnosCancelados.Text = "Total Turnos Cancelados: " + TotalTurnosCancelados.ToString();
            lblTotalRecaudado.Text = "Total Recaudado: " + TotalRecaudado.ToString();
        }

        private void PruebaChart_Load(object sender, EventArgs e)
        {
            fillChart();
            this.CenterToScreen(); 
        }

        private void cancelacionesPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelacionesPacientes frmCancelacionesPacientes = new frmCancelacionesPacientes();
            frmCancelacionesPacientes.ShowDialog();
        }
    }
}
