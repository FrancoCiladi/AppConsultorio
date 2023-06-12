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
    public partial class frmInfoImportes : Form
    {
        public frmInfoImportes()
        {
            InitializeComponent();
        }
        private void fillChart()
        {
            //PROCESO DE CARGA DEL CHART
            int TotalRecaudado;
            TotalRecaudado = 0;
            //NECESARIO PARA LLEVAR CUENTA TOTAL DE LOS IMPORTES 
            int aux = 0;
            //Necesario para que no oculte meses en el chart
            chartRecaudado.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            //Mostrar valor exacto de cada barra
            chartRecaudado.Series["Total Recaudado"].IsValueShownAsLabel = true;
            //Eliminar gridlines
            chartRecaudado.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRecaudado.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            //Hacer que el valor de las labels de barras tengan mejor visibilidad
            chartRecaudado.Series["Total Recaudado"].Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);

            for (int i = 1; i <= 12; i++)
            {
                //POR CADA ITERACION DE I GENERO UNA STRING FECHA UTILIZADA PARA EL PROCEDURE Y RECUPERAR INFO DE CADA MES
                string fecha;
                DataTable tabla = new DataTable();
                switch (i)
                {
                    case 1:
                        fecha = "01/01/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Enero", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 2:
                        fecha = "01/02/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Febrero", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 3:
                        fecha = "01/03/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Marzo", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 4:
                        fecha = "01/04/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Abril", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 5:
                        fecha = "01/05/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Mayo", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 6:
                        fecha = "01/06/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Junio", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 7:
                        fecha = "01/07/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Julio", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 8:
                        fecha = "01/08/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Agosto", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 9:
                        fecha = "01/09/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Septiembre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 10:
                        fecha = "01/10/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Octubre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 11:
                        fecha = "01/11/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Noviembre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                    case 12:
                        fecha = "01/12/2023";
                        Reportes.RecuperarInfoReportesMensual(fecha, ref tabla);
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Diciembre", tabla.Rows[0]["Recaudado"].ToString());
                        int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                        TotalRecaudado = TotalRecaudado + aux;
                        break;
                }

            }
            lblTotalRecaudado.Text = "Total Recaudado: " + TotalRecaudado.ToString();
        }

        private void frmInfoImportes_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
